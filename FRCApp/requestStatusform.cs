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
        String ClientID;
        public requestStatusform(String ClientID, Boolean request)
        {
            newrequest =request;
            InitializeComponent();
            this.ClientID = ClientID;
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


        private void requestStatusform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);
            if (newrequest)
            {
                this.Text = "New EFA Request";
            }
           
           
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);

            //cmbEfaCategory.DataSource = this.eFARequestTypesTableAdapter.GetData();
            //cmbEfaCategory.ValueMember = "EFARequestTypeID";
            //cmbEfaCategory.DisplayMember = "Type";
            var reqTypes = this.eFARequestTypesTableAdapter.GetData();
            foreach (var reqType in reqTypes) {
                checklist_requestType.Items.Add(reqType.Type);
            }

            DataSet1TableAdapters.ClientsTableAdapter client = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = client.GetDataByid(ClientID);
            efa_clientName.Text = clients[0].FirstName;
            DataSet1TableAdapters.IncomeInfoTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeInfoTableAdapter();
            var incomeinfo = incomeAdapter.GetIncomeInfo(clients[0].HouseholdID);
            txt_QHincome.Text = incomeinfo[0].QuarterlyIncome.ToString();
            txt_Mincome.Text = incomeinfo[0].MonthlyIncome.ToString();
            
            var expensesAdapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            var monthlyExpenses = expensesAdapter.getExpenseInfoByHouseholdID(clients[0].HouseholdID);
            txt_Mexpenses.Text = monthlyExpenses.ToString();
        }

        private void update_efa_Click(object sender, EventArgs e)
        {

        }
    }
}
