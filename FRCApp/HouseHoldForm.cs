using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FRCApp
{
    public partial class HouseHoldForm : Form
    {
        private DataSet1.HouseholdMembersDataTable table;
        private Guid houseHoldId;
        private const int BACKSPACE = 8;
        private const int DELETE = 46;

        public HouseHoldForm(Guid houseHoldId)
        {
            InitializeComponent();
            table = new DataSet1.HouseholdMembersDataTable();
            this.houseHoldId = houseHoldId;
            fillListView();
        }

        /**
         * Fill the list view on the Household form with data from the database
         **/
        private void fillListView()
        {
            HouseHoldForm_ListView_Summary.Items.Clear();
            DataSet1TableAdapters.HouseholdMembersTableAdapter adapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            foreach (DataRow row in adapter.getHouseholdMembersById(houseHoldId).Rows)
            {
                if (archivedCheckBox.Checked || (bool)row["IsActive"])
                {
                    ListViewItem item = new ListViewItem(row["FirstName"].ToString());
                    item.SubItems.Add(row["LastName"].ToString());
                    item.SubItems.Add(row["LastFourSSN"].ToString());
                    item.SubItems.Add(row["Birthdate"].ToString());
                    item.SubItems.Add(row["Relationship"].ToString());
                    item.SubItems.Add(row["Race"].ToString());
                    item.SubItems.Add(row["HealthCoverage"].ToString());
                    item.Tag = row["HouseholdMemberID"];
                    HouseHoldForm_ListView_Summary.Items.Add(item);
                }
            }
        }

        /**
         * Event handler for when the user clicks the "Add" button.
         * Add data from form fields to ListView
         **/
        private void HouseHoldAddButton_Click(object sender, EventArgs e)
        {
            String message = validateForm();
            if (message != "OK")
            {
                MessageBox.Show(message);
                return;
            }

            // add ListView items to DataSet1 table
            DataSet1TableAdapters.HouseholdMembersTableAdapter adapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            adapter.AddOrUpdateHouseholdMembers(
                -1,
                houseHoldId,
                HouseHoldFormFirstNameTextBox.Text,
                HouseHoldFormlastNameTextBox.Text,
                System.DateTime.Parse(HouseHoldFormBirthDateDateTimePicker.Text),
                HouseHoldFormRelationshipToApplicant.Text,
                HouseHoldFormEthnicityListBox.SelectedValue.ToString(),
                !HouseHoldFormRadioButtonNo.Checked,
                HouseHoldFormlast4DigitsOfSsnTextBox.Text,
                true, //isActive
                null // no date archived
            );

            //clear the form fields
            HouseHoldFormFirstNameTextBox.Clear();
            HouseHoldFormlastNameTextBox.Clear();
            HouseHoldFormlast4DigitsOfSsnTextBox.Clear();
            HouseHoldFormRelationshipToApplicant.Clear();
            HouseHoldFormRelationshipToApplicant.Clear();
            HouseHoldFormEthnicityListBox.SelectedIndex = -1;
            HouseHoldFormRadioButtonNo.Checked = false;
            HouseHoldFormRadioButtonYes.Checked = false;

            // fill the listview
            fillListView();
        }

        /**
         * Upon start up, load data from DB into Races table
         **/
        private void HouseHoldForm_Load(object sender, EventArgs e)
        {
            this.racesTableAdapter.Fill(this.dataSet1.Races);
        }

        /**
         * Check to ensure each form field has been given a value and household member does not already exist
         * returns a message containing information about which field needs to be filled in
         **/
        private string validateForm()
        {
            if (!textExists(HouseHoldFormFirstNameTextBox.Text))
            {
                return "Enter a first name";
            }
            else if (!textExists(HouseHoldFormlastNameTextBox.Text))
            {
                return "Enter a last name";
            }
            else if (!textExists(HouseHoldFormlast4DigitsOfSsnTextBox.Text) || HouseHoldFormlast4DigitsOfSsnTextBox.Text.Length != 4)
            {
                return "Enter a valid SSN";
            }
            else if (!textExists(HouseHoldFormBirthDateDateTimePicker.Text))
            {
                return "Enter a birth date";
            }
            else if (!textExists(HouseHoldFormRelationshipToApplicant.Text))
            {
                return "Enter a relationship to the applicant";
            }
            else if (!textExists((string)HouseHoldFormEthnicityListBox.SelectedValue))
            {
                return "Enter a Ethnicity";
            }
            else if (!HouseHoldFormRadioButtonYes.Checked && !HouseHoldFormRadioButtonNo.Checked)
            {
                return "Enter health insurance info";
            }

            return "OK";
        }

        /**
         * Check if text exists inside a textbox. Used for validating our form
         **/
        private bool textExists(string str)
        {
            return str != null && str != "";
        }

        /**
         * Handle clicking the Done button
         **/
        private void HouseHoldFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Remove all of the selected items form the HouseHoldForm_ListView_Summary
         **/
        private void removeButton_Click(object sender, EventArgs e)
        {
            // archive household member's income sources
            DataSet1TableAdapters.IncomeSourcesTableAdapter incomeSourceAdapter = new DataSet1TableAdapters.IncomeSourcesTableAdapter();
            foreach (ListViewItem item in HouseHoldForm_ListView_Summary.SelectedItems)
            {
                var incomeDetails = incomeSourceAdapter.GetIncomeSourcesByHouseholdMemberID(Int32.Parse(item.Tag.ToString()));
                foreach (DataRow row in incomeDetails.Rows)
                {
                    incomeSourceAdapter.AddOrUpdateIncomeSources(
                        Int32.Parse(row["IncomeSourceID"].ToString()),
                        Int32.Parse(row["HouseholdMemberID"].ToString()),
                        row["IncomeSource"].ToString(),
                        Decimal.Parse(row["Amount"].ToString()),
                        Int32.Parse(row["FrequencyID"].ToString()),
                        DateTime.Parse(row["DateAdded"].ToString()),
                        false, // not active
                        DateTime.Now // date archived
                    );
                }
            }


            // archive household member
            DataSet1TableAdapters.HouseholdMembersTableAdapter adapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            foreach (ListViewItem item in HouseHoldForm_ListView_Summary.SelectedItems)
            {
                adapter.AddOrUpdateHouseholdMembers(
                    Int32.Parse(item.Tag.ToString()),
                    houseHoldId,
                    item.SubItems[0].Text, // first name
                    item.SubItems[1].Text, // last name
                    DateTime.Parse(item.SubItems[3].Text), // birth date
                    item.SubItems[4].Text, // relationship
                    item.SubItems[5].Text, // race
                    Boolean.Parse(item.SubItems[6].Text), // health care coverage
                    item.SubItems[2].Text, // last 4 SSN
                    false, // not active
                    DateTime.Now // date archived
                );
            }
            fillListView();
        }

        /**
         * Handle Edit Event
         **/
        private void editButton_Click(object sender, EventArgs e)
        {
            if (HouseHoldForm_ListView_Summary.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a household member");
                return;
            }

            new EditHouseholdMemberInfo((int)HouseHoldForm_ListView_Summary.SelectedItems[0].Tag, houseHoldId).Show();
        }

        private void HouseHoldForm_Activated(object sender, EventArgs e)
        {
            this.racesTableAdapter.Fill(this.dataSet1.Races);
            fillListView();
        }

        private void HouseHoldForm_ListView_Summary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (HouseHoldForm_ListView_Summary.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a household member");
                return;
            }

            new EditHouseholdMemberInfo((int)HouseHoldForm_ListView_Summary.SelectedItems[0].Tag, houseHoldId).Show();
        }

        private void archivedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fillListView();
        }
    }
}
