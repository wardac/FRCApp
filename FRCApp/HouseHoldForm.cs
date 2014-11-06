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
        public HouseHoldForm()
        {
            InitializeComponent();
            table = new DataSet1.HouseholdMembersDataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HouseHoldSubmitButton_Click(object sender, EventArgs e)
        {
            //DataSet1.HouseholdMembersRow row = new DataSet1.HouseholdMembersRow();
            
            DataSet1.HouseholdMembersRow row = table.NewHouseholdMembersRow();
            row.FirstName = HouseHoldFormFirstNameTextBox.Text;
            row.LastName = HouseHoldFormlastNameTextBox.Text;
            row.Birthdate = DateTime.Parse(HouseHoldFormBirthDateDateTimePicker.Text);
            row.Race = HouseHoldFormEthnicityListBox.SelectedItem.ToString();
            row.HealthCoverage = !HouseHoldFormRadioButtonNo.Checked;
            row.LastFourSSN = HouseHoldFormlast4DigitsOfSsnTextBox.Text;
            row.Relationship = HouseHoldFormRelationshipToApplicant.Text;
            table.AddHouseholdMembersRow(row);
            HouseHoldFormSummaryListBox.Items.Add(row);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void HouseHoldFormLastName_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
