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

        private void submit_button_Click(object sender, EventArgs e)
        {
            foreach (object item in ReferralsBox.CheckedItems)
            {
                Console.WriteLine(((System.Data.DataRowView)item).Row.Field<string>(1));
            }
            DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
            adapter.AddClient(firstName_textBox.Text, lastName_textBox.Text, middleInitial_textBox.Text, DateTime.Parse(dataOfBirth_dateTimePicker.Text), homeAddress_textBox.Text, apartmentNumber_textBox.Text, city_textBox.Text, "Ohio", zipCode_textBox.Text, telephone1_textBox.Text, telephone2_textBox.Text, "", "", "", true, true, true);
            this.Close();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.GoalTypes' table. You can move, or remove it, as needed.
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
        }


    }
}
