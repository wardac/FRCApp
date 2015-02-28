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
    public partial class ApprovalForm : Form
    {
        private int requestID;
        public ApprovalForm(int requestID)
        {
            this.requestID = requestID;
            InitializeComponent();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
           for(int i=0;i<chklst_services.Items.Count;i++)
           {
               if (chklst_services.GetItemChecked(i))
               {
                   chklst_approved.Items.Add(chklst_services.GetItemChecked(i));
               }
           }
        }

        private void ApprovalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
