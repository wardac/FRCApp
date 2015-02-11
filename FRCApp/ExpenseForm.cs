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
    public partial class ExpenseForm : Form
    {
        private const int BACKSPACE = 8;
        private const int DELETE = 46;
        private const int DECIMAL = 81;
        private Guid householdID;

        public ExpenseForm(Guid householdID)
        {
            this.householdID = householdID;
            InitializeComponent();
        }

        /**
         * Allow for numbers to only be entered
         **/
        private void validateKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != BACKSPACE && ch != DELETE && ch != DECIMAL)
            {
                e.Handled = true;
            }
        }

        /**
         * Handle user clicking on the cancel button
         **/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /**
         * Submit data to database and close form
         **/
        private void submitButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MonthlyExpensesTableAdapter adapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            adapter.InsertMonthlyExpenses(
                this.householdID.ToString(), 
                System.Convert.ToDecimal(this.ExpenseRentTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseElectricTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseHeatingTextBox.Text),
                System.Convert.ToDecimal(this.ExpensePhoneTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseTrashTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseWaterTextBox.Text), 
                System.Convert.ToDecimal(this.ExpensePrescriptionsTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseLaundryTextBox.Text),
                System.Convert.ToDecimal(this.ExpenseCarPaymentTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseCarInsuranceTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseGasolineTransportTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseHealthInsuranceTextBox.Text),
                System.Convert.ToDecimal(this.ExpenseCableTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseInternetTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseCreditCardTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseLoansTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseGroceriesTextBox.Text),
                System.Convert.ToDecimal(this.ExpenseHygieneTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseHouseholdTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseChildCareTextBox.Text),
                System.Convert.ToDecimal(this.ExpenseChildSupportTextBox.Text), 
                System.Convert.ToDecimal(this.ExpenseOtherTextBox.Text)
            );

            DialogResult messageBox = MessageBox.Show("Successfully submitted data.", "", MessageBoxButtons.OK);
            if (messageBox == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
