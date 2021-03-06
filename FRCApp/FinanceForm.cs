﻿using System;
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

        public FinanceForm(String householdID)
        {
            this.householdID = householdID;
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

            // Add entry to the database
            var incomeSourcesAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();
            incomeSourcesAdapter.AddIncomeSource((int)cmb_householdMember.SelectedValue, cmb_incomeSourceType.GetItemText(cmb_incomeSourceType.SelectedItem), Decimal.Parse(amountOfIncomeTextBox.Text), (int)cmb_incomeFreqs.SelectedValue, datePickerDateadded.Value, true);
            fillListViewFromDatabase();

            //clear the fields
            cmb_householdMember.SelectedIndex = -1;
            cmb_incomeFreqs.SelectedIndex = -1;
            cmb_incomeSourceType.SelectedIndex = -1;
            amountOfIncomeTextBox.Clear();
        }

        //removes the selected items from the FinanceListView
        private void archiveButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.IncomeSourcesTableAdapter incomeSourceAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();

            foreach (ListViewItem item in FinancelistView.SelectedItems) {
                if (archiveButton.Text == "Archive") {
                    incomeSourceAdapter.ArchiveIncomeSourceByID((int)item.Tag);
                }
                else if (archiveButton.Text == "Unarchive") {
                    incomeSourceAdapter.UnarchiveIncomeSourceByID((int)item.Tag);
                }
            }
            fillListViewFromDatabase();
        }

        //Gives the user a cancel button, and then closes the form if desired
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillListViewFromDatabase()
        {
            FinancelistView.Items.Clear();
            var householdMembersAdapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            var householdMembers = householdMembersAdapter.GetHouseholdMembersByHouseholdID(new Guid(householdID));
            DataSet1TableAdapters.IncomeSourcesTableAdapter incomeSourceAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();


            foreach (DataRow householdMember in householdMembers.Rows)
            {
                var incomeDetails = incomeSourceAdapter.GetIncomeSourcesByHouseholdMemberID(Int32.Parse(householdMember["HouseholdMemberID"].ToString()));
                foreach (DataRow row in incomeDetails.Rows)
                {
                    //show all data
                    if (radioAll.Checked)
                    {
                        fillListViewItem(row, householdMember["Name"].ToString());
                    } 
                    //show only archived data
                    else if(radioArchived.Checked && !(bool)row["IsActive"]){
                        fillListViewItem(row, householdMember["Name"].ToString());
                    }
                    //show only unarchived data
                    else if(radioUnarchived.Checked && (bool)row["IsActive"])
                    {
                        fillListViewItem(row, householdMember["Name"].ToString());
                    }
                }
            }
        }

        private void fillListViewItem(DataRow row, String name)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(row["IncomeSource"].ToString());
            item.SubItems.Add(row["Amount"].ToString());
            DataSet1TableAdapters.IncomeFrequenciesTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeFrequenciesTableAdapter();
            String frequency = incomeAdapter.GetFrequencyByID(Int32.Parse(row["FrequencyID"].ToString())).ToString();
            item.SubItems.Add(frequency);
            item.Tag = row["IncomeSourceID"];
            item.SubItems.Add(row["DateAdded"].ToString().Split(' ')[0]);
            item.SubItems.Add(row["DateArchived"] == null ? "" : row["DateArchived"].ToString().Split(' ')[0]);
            //item.SubItems.Add((!((bool)row["IsActive"])).ToString());
            //alternating row colors
            if (item.Index % 2 == 0)
            { item.BackColor = Color.Gainsboro; }
            else
            { item.BackColor = Color.WhiteSmoke; }
            FinancelistView.Items.Add(item);
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            // Get household members for this household as entered on a previous form
            // Put them in the dropdown with HouseholdMemberID as the ValueMember and 
            // Name (combined first and last) as the DisplayMember
            var householdMembersAdapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            var householdMembers = householdMembersAdapter.GetActiveHouseholdMembersByHouseholdID(new Guid(householdID));
            //var householdMembers = householdMembersAdapter.GetHouseholdMembersByHouseholdID(new Guid(householdID));
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
            fillListViewFromDatabase();
        }

        private void archiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            fillListViewFromDatabase();
        }

        private void radioUnarchived_CheckedChanged(object sender, EventArgs e)
        {
            fillListViewFromDatabase();
        }

        private void radioArchived_CheckedChanged(object sender, EventArgs e)
        {
            //change the text of the archive button to unarchive if othe radioArchived Button is Checked
            if (radioArchived.Checked)
            {
                archiveButton.Text = "Unarchive";
            }
            else
            {
                archiveButton.Text = "Archive";
            }
            fillListViewFromDatabase();
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAll.Checked) {
                archiveButton.Visible = false;
            }
            else {
                archiveButton.Visible = true;
            }
            fillListViewFromDatabase();
        }
    }
}
