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
            if(efa_proofaddress.Checked)
            {
                addressdate.Visible = true;
                addressdate.Value=DateTime.Today.Date;
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
    }
}
