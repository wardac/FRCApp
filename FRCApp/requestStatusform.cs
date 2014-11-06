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
        public requestStatusform()
        {
            InitializeComponent();
        }

        private void cancelEfa_Click(object sender, EventArgs e)
        {

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
    }
}
