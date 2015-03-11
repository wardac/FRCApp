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

        // form members
        private HouseHoldForm householdForm;
        private ExpenseForm expenseForm;
        private FinanceForm financeForm;
        public Guid clientID;
        public Guid householdID;
        public String clientIdAsString = "";
        public String householdIdAsString = "";
        private const int BACKSPACE = 8;
        private const int DELETE = 46;

        public NewClient() 
        {
            InitializeComponent();
            clientID = Guid.NewGuid();
            householdID = Guid.NewGuid();
        }

        public NewClient(String ClientID, String householdId)
        {
            InitializeComponent();
            clientIdAsString = ClientID;
            householdIdAsString = householdId;
        }

        public NewClient(DataSet1.ClientsRow clientData)
        {
            InitializeComponent();
            populateFormData(clientData);
        }

        private void householdInfo_button_Click(object sender, EventArgs e)
        {
            householdForm = new HouseHoldForm(householdID);
            householdForm.Show();
        }

        private void monthlyExpenses_button_Click(object sender, EventArgs e)
        {
            expenseForm = new ExpenseForm(householdID);
            expenseForm.Show();
        }

        private void householdIncome_button_Click(object sender, EventArgs e)
        {
            financeForm = new FinanceForm(householdID.ToString());
            financeForm.Show();
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
            else if (string.IsNullOrEmpty(zipCode_textBox.Text) || zipCode_textBox.Text.Length != 5)
            {
                MessageBox.Show("Please enter in a valid zip code");
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

                if (clientIdAsString.Equals(""))
                {
                    adapter.AddClient(
                        clientID.ToString(),
                        householdID.ToString(),
                        firstName_textBox.Text,
                        lastName_textBox.Text,
                        middleInitial_textBox.Text,
                        DateTime.Parse(dataOfBirth_dateTimePicker.Text),
                        homeAddress_textBox.Text,
                        apartmentNumber_textBox.Text,
                        city_textBox.Text,
                        "Ohio",
                        zipCode_textBox.Text,
                        telephone1_textBox.Text,
                        telephone2_textBox.Text,
                        email_textBox.Text,
                        EducationLevelBox.Text,
                        EmploymentStatusBox.Text,
                        false, // bank account
                        false, // credit score
                        false  // credit report
                    );
                }
                else
                {
                    adapter.UpdateClient(
                        clientIdAsString,
                        householdIdAsString,
                        firstName_textBox.Text,
                        lastName_textBox.Text,
                        middleInitial_textBox.Text,
                        DateTime.Parse(dataOfBirth_dateTimePicker.Text),
                        homeAddress_textBox.Text,
                        apartmentNumber_textBox.Text,
                        city_textBox.Text,
                        "Ohio",
                        zipCode_textBox.Text,
                        telephone1_textBox.Text,
                        telephone2_textBox.Text,
                        email_textBox.Text,
                        EducationLevelBox.Text,
                        EmploymentStatusBox.Text,
                        false, // bank account
                        false, // credit score
                        false,  // credit report
                        clientIdAsString
                    );
                }
                this.Close();
                new ClientDetails(clientID.ToString()).Show();
            }
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            this.goalTypesTableAdapter.Fill(this.dataSet1.GoalTypes);
            this.referralTypesTableAdapter.Fill(this.dataSet1.ReferralTypes);
            this.employmentStatusesTableAdapter.Fill(this.dataSet1.EmploymentStatuses);
            this.educationLevelsTableAdapter.Fill(this.dataSet1.EducationLevels);
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

        /**
         * Restric zip code to only accept numbers
         */
        private void zipCode_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != BACKSPACE && ch != DELETE)
            {
                e.Handled = true;
            }
        }

        /**
         * Handle clicking of cancel button
         */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /**
         * Populate form via given DataSet
         */
        private void populateFormData(DataSet1.ClientsRow clientData)
        {
            clientIdAsString = clientData.ClientID;
            householdIdAsString = clientData.HouseholdID;
            firstName_textBox.Text = clientData.FirstName;
            lastName_textBox.Text = clientData.LastName;
            middleInitial_textBox.Text = clientData.MiddleInitial;
            dataOfBirth_dateTimePicker.Text = clientData.Birthdate.ToString();
            homeAddress_textBox.Text = clientData.Address;
            if (!clientData.IsAptNoNull()) { apartmentNumber_textBox.Text = clientData.AptNo; }
            if (!clientData.IsCityNull()) { city_textBox.Text = clientData.City; }
            if (!clientData.IsZipNull()) { zipCode_textBox.Text = clientData.Zip; }
            if (!clientData.IsPhone1Null()) { telephone1_textBox.Text = clientData.Phone1; }
            if (!clientData.IsPhone2Null()) { telephone2_textBox.Text = clientData.Phone2; } 
            if (!clientData.IsEmailNull()) { email_textBox.Text = clientData.Email; }
            if (!clientData.IsEducationLevelNull()) { EducationLevelBox.Text = clientData.EducationLevel; }
            if (!clientData.IsEmploymentStatusNull()) { EmploymentStatusBox.Text = clientData.EmploymentStatus; }
        }

    }
}
