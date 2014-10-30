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
            DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
            adapter.AddClient(firstName_textBox.Text, lastName_textBox.Text, middleInitial_textBox.Text, DateTime.Parse(dataOfBirth_dateTimePicker.Text), homeAddress_textBox.Text, apartmentNumber_textBox.Text, city_textBox.Text, "Ohio", zipCode_textBox.Text, telephone1_textBox.Text, telephone2_textBox.Text, "", "", "", true, true, true);
            this.Close();
        }

    }
}
