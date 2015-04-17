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
            populateForm();
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
                    FistNameTextBox.Text = row["FirstName"].ToString();
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
    }
}
