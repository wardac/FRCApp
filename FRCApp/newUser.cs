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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        /**
        * Check to ensure each form field has been given a value 
        * returns a message containing information about which field needs to be filled in
        **/
        private string validateForm()
        {
            if (String.IsNullOrEmpty(FirstnameTextbox.Text))
            {
                return "Enter a first name";
            }
            else if (String.IsNullOrEmpty(LastNameTextBox.Text))
            {
                return "Enter a last name";
            }
            else if (String.IsNullOrEmpty(UserNameTextBox.Text))
            {
                return "Enter a username";
            }
            else if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                return "Enter a password";
            }
            else if (AccessLevelComboBox.SelectedIndex == -1)
            {
                return "Select an access level";
            }
            return "OK";
        }

        private void save_Click(object sender, EventArgs e)
        {
            //validate the form
            String message = validateForm();
            if (message != "OK")
            {
                MessageBox.Show(message);
                return;
            }
            //Add the data to the users database with the default password frc123
            DataSet1TableAdapters.UsersTableAdapter adapter = new DataSet1TableAdapters.UsersTableAdapter();
            var users = adapter.GetUsersByUserName(UserNameTextBox.Text);
            if (users.Count > 0) {
                MessageBox.Show("A user with that name already exists");
                return;
            }
            adapter.AddUser(UserNameTextBox.Text, FirstnameTextbox.Text, LastNameTextBox.Text, passwordTextBox.Text, AccessLevelComboBox.GetItemText(AccessLevelComboBox.SelectedItem));
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
            this.Dispose();
        }
    }
}
