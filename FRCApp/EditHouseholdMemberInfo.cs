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
                SocialTextBox.Text
            );

            // close form
            this.Close();
        }
    }
}
