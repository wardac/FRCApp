using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp
{
    public partial class EditHouseholdMemberInfo : Form
    {

        private int householdMemberId;
        private Guid householdId;

        public EditHouseholdMemberInfo(int householdMemberId, Guid householdId)
        {            
            InitializeComponent();
            this.householdMemberId = householdMemberId;
            this.householdId = householdId;
        }

        /**
         * Populate form fields with the given houseHoldMemberId
         **/
        private void populateForm()
        {
            DataSet1TableAdapters.HouseholdMembersTableAdapter adapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            foreach (DataRow row in adapter.getHouseholdMembersById(householdId).Rows)
            {
                if ((int)row["HouseholdMemberID"] == householdMemberId)
                {
                    FirstNameTextBox.Text = row["FirstName"].ToString();
                    LastNameTextBox.Text = row["LastName"].ToString();
                    SocialTextBox.Text = row["LastFourSSN"].ToString();
                    BirthDateTextBox.Text = row["Birthdate"].ToString();
                    RelationshipTextBox.Text = row["Relationship"].ToString();
                    RaceBox.Text = row["Race"].ToString();
                    if ((bool)row["HealthCoverage"])
                    {
                        yes_radio_button.Checked = true;
                    }
                    else
                    {
                        no_radio_button.Checked = true;
                    }
                }
            }
        }

        /**
         * Handle Cancle button event
         **/
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditHouseholdMemberInfo_Load(object sender, EventArgs e)
        {
            this.racesTableAdapter.Fill(this.dataSet1.Races);
            RaceBox.SelectedIndex = -1;

            populateForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
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
                householdMemberId,
                householdId,
                FirstNameTextBox.Text,
                LastNameTextBox.Text,
                System.DateTime.Parse(BirthDateTextBox.Text),
                RelationshipTextBox.Text,
                RaceBox.SelectedValue.ToString(),
                !no_radio_button.Checked,
                SocialTextBox.Text,
                true, // isActive
                null // no archive date
            );

            // close form
            this.Close();
        }

        /**
        * Check to ensure each form field has been given a value and household member does not already exist
        * returns a message containing information about which field needs to be filled in
        **/
        private string validateForm()
        {
            if (!textExists(FirstNameTextBox.Text))
            {
                return "Enter a first name";
            }
            else if (!textExists(LastNameTextBox.Text))
            {
                return "Enter a last name";
            }
            else if (!textExists(SocialTextBox.Text) || SocialTextBox.Text.Length != 4)
            {
                return "Enter a valid SSN";
            }
            else if (!textExists(BirthDateTextBox.Text))
            {
                return "Enter a birth date";
            }
            else if (!textExists(RelationshipTextBox.Text))
            {
                return "Enter a relationship to the applicant";
            }
            else if (!textExists((string)RaceBox.SelectedValue))
            {
                return "Enter a Ethnicity";
            }
            else if (!yes_radio_button.Checked && !no_radio_button.Checked)
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
    }
}
