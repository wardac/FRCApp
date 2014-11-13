using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp {
    public partial class NewClient : Form {
        private HouseHoldForm householdForm;
        private ExpenseForm expenseForm;
        public NewClient() {
            InitializeComponent();
            householdForm = new HouseHoldForm();
            expenseForm = new ExpenseForm();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void householdInfo_button_Click(object sender, EventArgs e)
        {
            householdForm.Show();
        }

        private void monthlyExpenses_button_Click(object sender, EventArgs e)
        {
            expenseForm.Show();
        }


        /**
         * Validates the form data
         * returns true if the form is valid
         * returns false otherwise
         */
        private bool formHasValidData()
        {
            if (string.IsNullOrEmpty(firstName_textBox.Text))
            {
                MessageBox.Show("Please enter in a first name");
                return false;
            }
            else if (string.IsNullOrEmpty(lastName_textBox.Text))
            {
                MessageBox.Show("Please enter in a last name");
                return false;
            }
            else if (string.IsNullOrEmpty(homeAddress_textBox.Text))
            {
                MessageBox.Show("Please enter in an address");
                return false;
            }
            else if (string.IsNullOrEmpty(city_textBox.Text))
            {
                MessageBox.Show("Please enter in a City");
                return false;
            }
            else if (string.IsNullOrEmpty(zipCode_textBox.Text))
            {
                MessageBox.Show("Please enter in a zip code");
                return false;
            }
            return true;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (formHasValidData())
            {

                foreach (object item in ReferralsBox.CheckedItems)
                {
                    Console.WriteLine(((System.Data.DataRowView)item).Row.Field<string>(1));
                }
                DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
                adapter.AddClient(firstName_textBox.Text, lastName_textBox.Text, middleInitial_textBox.Text, DateTime.Parse(dataOfBirth_dateTimePicker.Text), homeAddress_textBox.Text, apartmentNumber_textBox.Text, city_textBox.Text, "Ohio", zipCode_textBox.Text, telephone1_textBox.Text, telephone2_textBox.Text, "", "", "", true, true, true);
                this.Close();
            }
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GoalTypes' table. You can move, or remove it, as needed.
            this.goalTypesTableAdapter.Fill(this.dataSet1.GoalTypes);
            // TODO: This line of code loads data into the 'dataSet1.ReferralTypes' table. You can move, or remove it, as needed.
            this.referralTypesTableAdapter.Fill(this.dataSet1.ReferralTypes);
            // TODO: This line of code loads data into the 'dataSet1.EmploymentStatuses' table. You can move, or remove it, as needed.
            this.employmentStatusesTableAdapter.Fill(this.dataSet1.EmploymentStatuses);
            // TODO: This line of code loads data into the 'dataSet1.EducationLevels' table. You can move, or remove it, as needed.
            this.educationLevelsTableAdapter.Fill(this.dataSet1.EducationLevels);
            // TODO: This line of code loads data into the 'dataSet1.HouseholdTypes' table. You can move, or remove it, as needed.
            this.householdTypesTableAdapter.Fill(this.dataSet1.HouseholdTypes);
           
            ReferralsBox.DataSource = this.referralTypesTableAdapter.GetData();
            ReferralsBox.DisplayMember = "ReferralType";
            ReferralsBox.ValueMember = "ReferralTypeID";

            GoalsBox.DataSource = this.goalTypesTableAdapter.GetData();
            GoalsBox.DisplayMember = "GoalType";
            GoalsBox.ValueMember = "GoalTypeID";

            HouseholdTypeBox.SelectedIndex = -1;
            EducationLevelBox.SelectedIndex = -1;
            EmploymentStatusBox.SelectedIndex = -1;
        }


    }
}
