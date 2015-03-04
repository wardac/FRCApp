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
        public ApprovalForm(String requestID, Action OnCloseEvent)
        {
            this.requestID = requestID;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler((o, e) => OnCloseEvent());
            InitializeComponent();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            while (lst_requestedServices.SelectedItems.Count > 0)
            {
                lst_approvedServices.Items.Add(lst_requestedServices.SelectedItems[0]);
                lst_requestedServices.Items.Remove(lst_requestedServices.SelectedItems[0]);
            }
            
        }

        private void btn_leftArrows_Click(object sender, EventArgs e)
        {
            while (lst_approvedServices.SelectedItems.Count > 0)
            {
                lst_requestedServices.Items.Add(lst_approvedServices.SelectedItems[0]);
                lst_approvedServices.Items.Remove(lst_approvedServices.SelectedItems[0]);
            }
        }

        private void ApprovalForm_Load(object sender, EventArgs e)
        {
            var efaSubrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
            var efaSubrequests = efaSubrequestAdapter.GetEFASubrequestsByEFARequestID(requestID);
            lst_requestedServices.DisplayMember = "Type";
            lst_requestedServices.ValueMember = "EFASubrequestID";
            lst_approvedServices.DisplayMember = "Type";
            lst_approvedServices.ValueMember = "EFASubrequestID";
            foreach (var subrequest in efaSubrequests) {
                lst_requestedServices.Items.Add(
                    new { Type = subrequest.EFARequestType, EFASubrequestID = subrequest.EFASubrequestID }
                );
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {

        }

        
    }
}
