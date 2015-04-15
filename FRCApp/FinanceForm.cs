using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FRCApp
{
    public partial class FinanceForm : Form
    {
        private String householdID;
        private List<IncomeSource> incomeSourcesList;

        public FinanceForm(String householdID)
        {
            this.householdID = householdID;
            incomeSourcesList = new List<IncomeSource>();
            InitializeComponent();
        }

        /**
       * Check to ensure each form field has been given a value 
       * returns a message containing information about which field needs to be filled in
       **/
        private string validateForm()
        {
            if (cmb_householdMember.SelectedIndex == -1)
            {
                return "Select a household member";
            }
            else if (cmb_incomeSourceType.SelectedIndex == -1)
            {
                return "Enter a source of income";
            }
            else if (String.IsNullOrEmpty(amountOfIncomeTextBox.Text))
            {
                return "Enter an amount of income";
            }
            else if (cmb_incomeFreqs.SelectedIndex == -1)
            {
                return "Select an income frequency";
            }
            return "OK";
        }

        /**
         * Add the form fields to the ListView also validate the input and clear
         * the form data
         */
        private void addButton_Click(object sender, EventArgs e)
        {
            //validate the form
            String message = validateForm();
            if (message != "OK")
            {
                MessageBox.Show(message);
                return;
            }
            
            //Add the data to the listView
            ListViewItem item = new ListViewItem(cmb_householdMember.GetItemText(cmb_householdMember.SelectedItem));
            item.SubItems.Add(cmb_incomeSourceType.GetItemText(cmb_incomeSourceType.SelectedItem));
            item.SubItems.Add(amountOfIncomeTextBox.Text);
            item.SubItems.Add(cmb_incomeFreqs.GetItemText(cmb_incomeFreqs.SelectedItem));
            FinancelistView.Items.Add(item);
            if (item.Index % 2 == 0)
            { item.BackColor = Color.Gainsboro; }
            else
            { item.BackColor = Color.WhiteSmoke; }
            
            // Add entry to the incomeSourcesList
            incomeSourcesList.Add(new IncomeSource((int)cmb_householdMember.SelectedValue, cmb_incomeSourceType.GetItemText(cmb_incomeSourceType.SelectedItem), amountOfIncomeTextBox.Text, (int)cmb_incomeFreqs.SelectedValue, cmb_householdMember.GetItemText(cmb_householdMember.SelectedItem), cmb_incomeFreqs.GetItemText(cmb_incomeFreqs.SelectedItem)));
            
            //clear the fields
            cmb_householdMember.SelectedIndex = -1;
            cmb_incomeFreqs.SelectedIndex = -1;
            cmb_incomeSourceType.SelectedIndex = -1;
            amountOfIncomeTextBox.Clear();
        }

        //removes the selected items from the FinanceListView
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FinancelistView.SelectedItems)
            {
                incomeSourcesList.RemoveAt(item.Index);
                item.Remove();
            }     
        }

        //Gives the user a cancel button, and then closes the form if desired
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // submits the data to the database
        private void submitButton_Click(object sender, EventArgs e)
        {

            var incomeSourcesAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();
            foreach (IncomeSource source in incomeSourcesList)
            {
                incomeSourcesAdapter.AddIncomeSource(source.householdMemberID, source.incomeSource, Decimal.Parse(source.amount), source.frequencyID);
            }
            this.Close();
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            // Get household members for this household as entered on a previous form
            // Put them in the dropdown with HouseholdMemberID as the ValueMember and 
            // Name (combined first and last) as the DisplayMember
            var householdMembersAdapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            var householdMembers = householdMembersAdapter.GetHouseholdMembersByHouseholdID(householdID);
            cmb_householdMember.DataSource = householdMembers;
            cmb_householdMember.ValueMember = "HouseholdMemberID";
            cmb_householdMember.DisplayMember = "Name";

            // Get income frequencies from the IncomeFrequencies table
            // Used the ID as the ValueMember and Frequency as the DisplayMember
            var incomeFreqsAdapter = new DataSet1TableAdapters.IncomeFrequenciesTableAdapter();
            var incomeFreqs = incomeFreqsAdapter.GetData();
            cmb_incomeFreqs.DataSource = incomeFreqs;
            cmb_incomeFreqs.ValueMember = "IncomeFrequencyID";
            cmb_incomeFreqs.DisplayMember = "Frequency";

            // Get income sources from the IncomeSourceTypes table
            var incomeSourceTypesAdapter = new DataSet1TableAdapters.IncomeSourceTypesTableAdapter();
            var incomeSourceTypes = incomeSourceTypesAdapter.GetData();
            cmb_incomeSourceType.DataSource = incomeSourceTypes;
            cmb_incomeSourceType.ValueMember = "IncomeSourceType";
            cmb_incomeSourceType.DisplayMember = "IncomeSourceType";

            // Fill listview with any persons from the database
            DataSet1TableAdapters.IncomeSourcesTableAdapter incomeSourceAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();
            foreach (DataRow householdMember in householdMembers.Rows)
            {
                var incomeDetails = incomeSourceAdapter.GetIncomeSourcesByHouseholdMemberID(Int32.Parse(householdMember["HouseholdMemberID"].ToString()));                
                foreach (DataRow row in incomeDetails.Rows)
                {
                    if (!row["IncomeSource"].ToString().Equals(""))
                    {
                        ListViewItem item = new ListViewItem(householdMember["Name"].ToString());
                        item.SubItems.Add(row["IncomeSource"].ToString());
                        item.SubItems.Add(row["Amount"].ToString());
                        DataSet1TableAdapters.IncomeFrequenciesTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeFrequenciesTableAdapter();
                        String frequency = incomeAdapter.GetFrequencyByID(Int32.Parse(row["FrequencyID"].ToString())).ToString();
                        item.SubItems.Add(frequency);
                        item.Tag = row["IncomeSourceID"];
                        FinancelistView.Items.Add(item);
                    }
                }                
            }            
        }

        private class IncomeSource {

            public int householdMemberID;
            public int frequencyID;
            public String incomeSource;
            public String amount;
            public String name;
            public String frequency;
            
            
            public IncomeSource(int householdMemberID, String incomeSource, String amount, int frequencyID, String name, String frequency)
            {
                this.householdMemberID = householdMemberID;
                this.frequencyID = frequencyID;
                this.incomeSource = incomeSource;
                this.amount = amount;
                this.name = name;
                this.frequency = frequency;
            }

            public override String ToString() {
                return householdMemberID + " " + frequencyID + " " + incomeSource + " " + amount + " " + name + " " + frequency;
            }
        }

    }
}
