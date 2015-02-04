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
    public partial class efaRequestForm : Form
    {
        public efaRequestForm()
        {
            InitializeComponent();
        }

        private void efa_lblproofaddress_CheckedChanged(object sender, EventArgs e)
        {
            if (efa_proofaddress.Checked)
            {
                addressdate.Visible = true;
                addressdate.Value = DateTime.Today.Date;
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

        private void chkother_CheckedChanged(object sender, EventArgs e)
        {
            txtother.Visible = true;
        }

        private void submitEfa_Click(object sender, EventArgs e)
        {

        }

        private void efaRequestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);
            DataSet1TableAdapters.ClientsTableAdapter client = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = client.GetDataByid("80E28AD9-D5D6-431D-B198-A12DC2478DE8");
            efa_clientName.Text = clients[0].FirstName;
            DataSet1TableAdapters.IncomeInfoTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeInfoTableAdapter();
            var incomeinfo = incomeAdapter.GetIncomeInfo("80E28AD9-D5D6-431D-B198-A12DC2478DE8");
            

        }
    }
}
