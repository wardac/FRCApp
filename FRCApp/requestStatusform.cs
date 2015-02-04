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
    public partial class requestStatusform : Form
    {
        Boolean newrequest;
        public requestStatusform(Boolean request)
        {
            newrequest =request;
            InitializeComponent();
        }



        private void efa_proofaddress_CheckedChanged(object sender, EventArgs e)
        {
            if (efa_proofaddress.Checked)
            {
                addressdate.Visible = true;
                addressdate.Value = DateTime.Today.Date;
            }
        }

        private void efa_proofHousehold_CheckedChanged(object sender, EventArgs e)
        {
            if (efa_proofHousehold.Checked)
            {
                householdDate.Visible = true;
                householdDate.Value = DateTime.Today.Date;
            }
        }

        private void efa_proofIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (efa_proofIncome.Checked)
            {
                incomedate.Visible = true;
                incomedate.Value = DateTime.Today.Date;
            }
        }

        private void efa_proofharship_CheckedChanged(object sender, EventArgs e)
        {
            if (efa_proofharship.Checked)
            {
                hardshipdate.Visible = true;
                hardshipdate.Value = DateTime.Today.Date;
            }
        }

        private void efa_proofAssistance_CheckedChanged(object sender, EventArgs e)
        {
            assistancedate.Visible = true;
            assistancedate.Value = DateTime.Today.Date;
        }

        private void chkApproved_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApproved.Checked)
            {
                chkApprovedReason.Visible = true;
                ChkDeniedReason.Visible = false;
                chkDenied.Enabled = false;

            }
        }

        private void chkDenied_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDenied.Checked)
            {
                chkApprovedReason.Visible = false;
                ChkDeniedReason.Visible = true;
                chkApprovedReason.Enabled = false;

            }
        }

        private void requestStatusform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);
            if (newrequest)
            {
                this.Text = "New EFA Request";
                statusPanel.Visible = false;
                efa_reqamount.Enabled = true;
            }
           
           
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);

            cmbEfaCategory.DataSource = this.eFARequestTypesTableAdapter.GetData();
            cmbEfaCategory.ValueMember = "EFARequestTypeID";
            cmbEfaCategory.DisplayMember = "Type";

            DataSet1TableAdapters.ClientsTableAdapter client = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = client.GetDataByid("80E28AD9-D5D6-431D-B198-A12DC2478DE8");
            efa_clientName.Text = clients[0].FirstName;
            DataSet1TableAdapters.IncomeInfoTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeInfoTableAdapter();
            var incomeinfo = incomeAdapter.GetIncomeInfo("80E28AD9-D5D6-431D-B198-A12DC2478DE8");
            txt_QHincome.Text = incomeinfo[0].QuarterlyIncome.ToString();
            txt_Mincome.Text = incomeinfo[0].MonthlyIncome.ToString();
            DataSet1TableAdapters.MonthlyExpensesTableAdapter expenseAdapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            var expenseInfo = expenseAdapter.MonthlyExpensesByHouseholdID("9C437FC1-9301-47D0-BFBA-FE48294F4C65");
            txt_Mexpenses.Text = expenseInfo.ToString();
        }
    }
}
