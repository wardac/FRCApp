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
         /*       var amount = 0;
                Service current = new Service((Service)lst_requestedServices.SelectedItems[0]);
                ListViewItem item = new ListViewItem(current.getType() );
                item.Tag = current.getefaSubrequestID();
                item.SubItems.Add(amount.ToString());
                lst_approvedServices.Items.Add(item);
                //lst_approvedServices.Items.Add(lst_requestedServices.SelectedItems[0]);
                lst_requestedServices.Items.Remove(lst_requestedServices.SelectedItems[0]);
            */ 
                Service currentService = ((Service)lst_requestedServices.SelectedItems[0]);
                gridApprovedservices.Rows.Add(currentService.getData());
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
            // TODO: This line of code loads data into the 'dataSet1.IncomeSources' table. You can move, or remove it, as needed.
            this.incomeSourcesTableAdapter.Fill(this.dataSet1.IncomeSources);
            var efaSubrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
            var efaSubrequests = efaSubrequestAdapter.GetEFASubrequestsByEFARequestID(requestID);
            lst_requestedServices.DisplayMember = "Type";
            lst_requestedServices.ValueMember = "EFASubrequestID";
           // lst_approvedServices.Items;
           // lst_approvedServices.DisplayMember = "Type";
            //lst_approvedServices.ValueMember = "EFASubrequestID";
            foreach (var subrequest in efaSubrequests) {
                lst_requestedServices.Items.Add(
                    new Service(subrequest.EFARequestType, subrequest.EFASubrequestID)
                );
            }

            var approvalReasonsAdapter = new DataSet1TableAdapters.EFAApprovalReasonsTableAdapter();
            var denialReasonsAdapter = new DataSet1TableAdapters.EFADenialReasonsTableAdapter();
            var approvalReasons = approvalReasonsAdapter.GetData();
            var denialReasons = denialReasonsAdapter.GetData();
            cmb_approvalReason.DataSource = approvalReasons;
            cmb_approvalReason.DisplayMember = "Reason";
            cmb_approvalReason.ValueMember = "Reason";
            cmb_denialReason.DataSource = denialReasons;
            cmb_denialReason.DisplayMember = "Reason";
            cmb_denialReason.ValueMember = "Reason";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            var efaSubrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
            foreach (Service unapprovedService in lst_requestedServices.Items)
            {
                efaSubrequestAdapter.AddOrUpdateEFASubrequest(unapprovedService.EFASubrequestID, requestID, unapprovedService.Type, DateTime.Now, false);
            }

            foreach (Service approvedService in lst_approvedServices.Items)
            {
                efaSubrequestAdapter.AddOrUpdateEFASubrequest(approvedService.EFASubrequestID, requestID, approvedService.Type, DateTime.Now, true);
            }

            var efaRequestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
            var request = efaRequestAdapter.GetEFARequestsByEFARequestID(requestID)[0];
            var approvalReason = cmb_approvalReason.SelectedValue == null ? "" : cmb_approvalReason.SelectedValue.ToString();
            var deniedReason = cmb_denialReason.SelectedValue == null ? "" : cmb_denialReason.SelectedValue.ToString();
            efaRequestAdapter.AddOrUpdateEFARequest(requestID, 
                request.ClientID,
                (request.IsAddressVerificationNull() ? (DateTime?) null : request.AddressVerification),
                (request.IsHouseholdVerificationNull() ? (DateTime?) null : request.HouseholdVerification),
                (request.IsIncomeVerificationNull() ? (DateTime?) null : request.IncomeVerification),
                (request.IsBillVerificationNull() ? (DateTime?) null : request.BillVerification),
                (request.IsHardshipVerificationNull() ? (DateTime?) null : request.HardshipVerification),
                (request.IsHardshipTypeIDNull() ? (int?) null : request.HardshipTypeID),
                request.HardshipDetail,
                request.DateRequested,
                request.EFARequestStatusID,
                deniedReason,
                approvalReason,
                DateTime.Now);                
            this.Close();
        }

        private class Service
        {
            public String Type;
            public String EFASubrequestID;
            public double amount; 
            public Service(String Type, String EFASubrequestID)
            {
                this.Type = Type;
                this.EFASubrequestID = EFASubrequestID;
                this.amount = 0;
            }
            public Service(Service old)
            {
                this.Type = old.Type;
                this.EFASubrequestID = old.EFASubrequestID;
                this.amount = old.amount;
            }
            public string getType()
            {
                return this.Type;
            }
            public double getAmount()
            { return this.amount; }
            public string getefaSubrequestID()
            { return this.EFASubrequestID; }

            public string[] getData()
            { 
                string []data= {this.EFASubrequestID,this.Type,amount.ToString()};
                return data;
            }
            public override string ToString()
            {
                return Type;
            }
        }
    }
}
