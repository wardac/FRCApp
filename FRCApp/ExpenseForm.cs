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
        private int monthlyExpenseID = -1;

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
            // validate form
            String message = validateForm();
            if (message != "OK")
            {
                MessageBox.Show(message);
                return;
            }

            DataSet1TableAdapters.MonthlyExpensesTableAdapter adapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            adapter.AddOrUpdateMonthlyExpenses(
                this.householdID,
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
            decimal totalAmt = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    totalAmt = totalAmt + System.Convert.ToDecimal(ctrl.Text);
                }
            }
           // DataSet1TableAdapters.MonthlyExpensesSummaryTableAdapter sumadapter = new DataSet1TableAdapters.MonthlyExpensesSummaryTableAdapter();
           // sumadapter.add(this.householdID, totalAmt, DateTime.Now);

            this.Close();
        }

        /**
         * Validate form, checking for data in each box
         **/
        private string validateForm()
        {
            if (!textExists(this.ExpenseRentTextBox.Text))
                return "Enter rent expense.";
            else if (!textExists(this.ExpenseElectricTextBox.Text))
                return "Enter electric expense";
            else if (!textExists(this.ExpenseHeatingTextBox.Text))
                return "Enter heating expense";
            else if (!textExists(this.ExpensePhoneTextBox.Text))
                return "Enter phone expense";
            else if (!textExists(this.ExpenseTrashTextBox.Text))
                return "Enter trash expense";
            else if (!textExists(this.ExpenseWaterTextBox.Text))
                return "Enter water expense";
            else if (!textExists(this.ExpensePrescriptionsTextBox.Text))
                return "Enter prescriptions expense";
            else if (!textExists(this.ExpenseLaundryTextBox.Text))
                return "Enter laundry expense";
            else if (!textExists(this.ExpenseCarPaymentTextBox.Text))
                return "Enter car payment expense";
            else if (!textExists(this.ExpenseGasolineTransportTextBox.Text))
                return "Enter transportation expense";
            else if (!textExists(this.ExpenseHealthInsuranceTextBox.Text))
                return "Enter health insurance expense";
            else if (!textExists(this.ExpenseCableTextBox.Text))
                return "Enter cable expense";
            else if (!textExists(this.ExpenseInternetTextBox.Text))
                return "Enter internet expense";
            else if (!textExists(this.ExpenseCreditCardTextBox.Text))
                return "Enter credit card expense";
            else if (!textExists(this.ExpenseLoansTextBox.Text))
                return "Enter loan expense";
            else if (!textExists(this.ExpenseGroceriesTextBox.Text))
                return "Enter groceries expense";
            else if (!textExists(this.ExpenseHygieneTextBox.Text))
                return "Enter hygiene expense";
            else if (!textExists(this.ExpenseHouseholdTextBox.Text))
                return "Enter household expense";
            else if (!textExists(this.ExpenseChildCareTextBox.Text))
                return "Enter child care expense";
            else if (!textExists(this.ExpenseChildSupportTextBox.Text))
                return "Enter child support expense";
            else if (!textExists(this.ExpenseOtherTextBox.Text))
                return "Enter other expense";
            else
            return "OK";
        }

        /**
         * Check if text exists inside a textbox. Used for validating our form
         **/
        private bool textExists(string str)
        {
            return str != null && str != "";
        }

        /**
         * Load data from database
         **/
        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            DataSet1.MonthlyExpensesDataTable monthlyExpenseData = new DataSet1TableAdapters.MonthlyExpensesTableAdapter().GetMonthlyExpensesByHouseholdID(householdID);
            foreach (DataRow row in monthlyExpenseData.Rows)
            {
                monthlyExpenseID = Int32.Parse(row["MonthlyExpenseID"].ToString());
                ExpenseRentTextBox.Text = row["Rent"].ToString();
                ExpenseElectricTextBox.Text = row["Electric"].ToString();
                ExpenseHeatingTextBox.Text = row["Heating"].ToString();
                ExpensePhoneTextBox.Text = row["Phone"].ToString();
                ExpenseTrashTextBox.Text = row["Trash"].ToString();
                ExpenseWaterTextBox.Text = row["Water"].ToString();
                ExpensePrescriptionsTextBox.Text = row["Prescriptions"].ToString();
                ExpenseLaundryTextBox.Text = row["Laundry"].ToString();
                ExpenseCarPaymentTextBox.Text = row["CarPayment"].ToString();
                ExpenseCarInsuranceTextBox.Text = row["CarInsurance"].ToString();
                ExpenseGasolineTransportTextBox.Text = row["Transportation"].ToString();
                ExpenseHealthInsuranceTextBox.Text = row["HealthInsurance"].ToString();
                ExpenseCableTextBox.Text = row["Cable"].ToString();
                ExpenseInternetTextBox.Text = row["Internet"].ToString();
                ExpenseCreditCardTextBox.Text = row["CreditCard"].ToString();
                ExpenseLoansTextBox.Text = row["Loans"].ToString();
                ExpenseGroceriesTextBox.Text = row["Groceries"].ToString();
                ExpenseHygieneTextBox.Text = row["Hygiene"].ToString();
                ExpenseHouseholdTextBox.Text = row["Household"].ToString();
                ExpenseChildCareTextBox.Text = row["ChildCare"].ToString();
                ExpenseChildSupportTextBox.Text = row["ChildSupport"].ToString();
                ExpenseOtherTextBox.Text = row["Other"].ToString();
            }
        }
    }
}
