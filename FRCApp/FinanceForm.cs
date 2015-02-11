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
    public partial class FinanceForm : Form
    {

        public FinanceForm()
        {
            InitializeComponent();
        }

        /**
       * Check to ensure each form field has been given a value 
       * returns a message containing information about which field needs to be filled in
       **/
        private string validateForm()
        {
            if (String.IsNullOrEmpty(firstNameTextBox.Text))
            {
                return "Enter a first name";
            }
            else if (String.IsNullOrEmpty(lastNameTextBox.Text))
            {
                return "Enter a last name";
            }
            else if (String.IsNullOrEmpty(sourceOfIncomeTextBox.Text))
            {
                return "Enter a source of income";
            }
            else if (String.IsNullOrEmpty(amountOfIncomeTextBox.Text))
            {
                return "Enter an amount of income";
            }
            else if (String.IsNullOrEmpty(timesIncomeReceievedTextBox.Text))
            {
                return "Enter number of times income is received";
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
            ListViewItem item = new ListViewItem(firstNameTextBox.Text);
            item.SubItems.Add(lastNameTextBox.Text);
            item.SubItems.Add(sourceOfIncomeTextBox.Text);
            item.SubItems.Add(amountOfIncomeTextBox.Text);
            item.SubItems.Add(timesIncomeReceievedTextBox.Text);
            FinancelistView.Items.Add(item);
            //clear the fields
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            sourceOfIncomeTextBox.Clear();
            amountOfIncomeTextBox.Clear();
            timesIncomeReceievedTextBox.Clear();

        }

        //removes the selected items fromt he FinanceListView
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FinancelistView.SelectedItems)
            {
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

        }


    }
}
