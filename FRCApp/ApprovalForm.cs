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
        private String requestID;
        public ApprovalForm(String requestID)
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
            var efaSubrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
            var efaSubrequests = efaSubrequestAdapter.GetEFASubrequestsByEFARequestID(requestID);
            chklst_services.DisplayMember = "Type";
            chklst_services.ValueMember = "EFASubrequestID";
            foreach (var subrequest in efaSubrequests) {
                chklst_services.Items.Add(
                    new { Type = subrequest.EFARequestType, EFASubrequestID = subrequest.EFASubrequestID }
                );
            }
        }
    }
}
