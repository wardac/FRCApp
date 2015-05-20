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
        private const int BACKSPACE = 8;
        private const int DELETE = 46;
        public ApprovalForm(String requestID, Action OnCloseEvent)
        {
            this.requestID = requestID;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler((o, e) => OnCloseEvent());
            InitializeComponent();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            while (lst_requestedServices.SelectedItems.Count > 0)
            {

                Service currentService = ((Service)lst_requestedServices.SelectedItems[0]);
                gridApprovedservices.Rows.Add(currentService.getData());
                lst_requestedServices.Items.Remove(lst_requestedServices.SelectedItems[0]);
            }
            
        }

        private void btn_leftArrows_Click(object sender, EventArgs e)
        {
            while (gridApprovedservices.SelectedRows.Count > 0)
            {
                Service service = new Service( Convert.ToString(gridApprovedservices.SelectedRows[0].Cells[1].Value),Convert.ToString(gridApprovedservices.SelectedRows[0].Cells[0].Value));
                lst_requestedServices.Items.Add(service);
                gridApprovedservices.Rows.Remove(gridApprovedservices.SelectedRows[0]);
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
            foreach (var subrequest in efaSubrequests) {
                lst_requestedServices.Items.Add(
                    new Service(subrequest.EFARequestType, subrequest.EFASubrequestID)
                );
            }

            var approvalReasonsAdapter = new DataSet1TableAdapters.EFAApprovalReasonsTableAdapter();
            var denialReasonsAdapter = new DataSet1TableAdapters.EFADenialReasonsTableAdapter();
            var approvalReasons = approvalReasonsAdapter.GetEFAApprovalReasons();
            var denialReasons = denialReasonsAdapter.GetData();
            cmb_approvalReason.DataSource = approvalReasons;
            cmb_approvalReason.DisplayMember = "Reason";
            cmb_approvalReason.ValueMember = "Reason";
            cmb_denialReason.DataSource = denialReasons;
            cmb_denialReason.DisplayMember = "Reason";
            cmb_denialReason.ValueMember = "Reason";
        }
        private void gridApprovedservices_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gridApprovedservices.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == BACKSPACE)
            {
                return;
            }
            Double value =0;
            if (!Double.TryParse(((TextBox)sender).Text + e.KeyChar, out value))
            {
                e.Handled = true;
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (cmb_approvalReason.Text == "None" && cmb_denialReason.Text == "None")
            {
                MessageBox.Show("Approval and Denial reasons can't both be None");
                return;
            }
            var efaSubrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
            for (int i = 0; i < lst_requestedServices.Items.Count; ++i)
            //foreach (Service unapprovedService in lst_requestedServices.Items)
            {
                Service unapprovedService = (Service)lst_requestedServices.Items[i];
                efaSubrequestAdapter.AddOrUpdateEFASubrequest(unapprovedService.EFASubrequestID, requestID, unapprovedService.Type, DateTime.Now, false, unapprovedService.amount);
            }

            for (int i = 0; i < gridApprovedservices.Rows.Count; ++i)
            //foreach(DataGridViewRow data in gridApprovedservices.Rows)
            {
                DataGridViewRow data = gridApprovedservices.Rows[i];
                if (data != null && Convert.ToString(data.Cells[0].Value) != "")
                {
                    Service approvedService = new Service(Convert.ToString(data.Cells[0].Value), Convert.ToString(data.Cells[1].Value), Convert.ToDecimal(data.Cells[2].Value));
                    efaSubrequestAdapter.AddOrUpdateEFASubrequest(approvedService.EFASubrequestID, requestID, approvedService.Type, DateTime.Now, true, approvedService.amount);
                }
            }


            var efaRequestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
            var request = efaRequestAdapter.GetEFARequestsByEFARequestID(requestID)[0];
            var approvalReason = cmb_approvalReason.SelectedValue == null ? "" : cmb_approvalReason.SelectedValue.ToString();
            var deniedReason = cmb_denialReason.SelectedValue == null ? "" : cmb_denialReason.SelectedValue.ToString();
            efaRequestAdapter.AddOrUpdateEFARequest(requestID, 
                request.ClientID.ToString(),
                (request.IsAddressVerificationNull() ? (DateTime?) null : request.AddressVerification),
                (request.IsHouseholdVerificationNull() ? (DateTime?) null : request.HouseholdVerification),
                (request.IsIncomeVerificationNull() ? (DateTime?) null : request.IncomeVerification),
                (request.IsBillVerificationNull() ? (DateTime?) null : request.BillVerification),
                (request.IsHardshipVerificationNull() ? (DateTime?) null : request.HardshipVerification),
                ( request.HardshipTypeID),
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
            public Decimal amount; 
            public Service(String Type, String EFASubrequestID)
            {
                this.Type = Type;
                this.EFASubrequestID = EFASubrequestID;
                this.amount = 0;
            }

            public Service(String EFASubrequestID, String Type, Decimal amount)
            {
                this.Type = Type;
                this.EFASubrequestID = EFASubrequestID;
                this.amount = amount;
            }
            public Service(Service old)
            {
                this.Type = old.Type;
                this.EFASubrequestID = old.EFASubrequestID;
                this.amount = old.amount;
            }
            public String getType()
            {
                return this.Type;
            }
            public Decimal getAmount()
            { return this.amount; }
            public String getefaSubrequestID()
            { return this.EFASubrequestID; }

            public String[] getData()
            { 
                String []data= {this.EFASubrequestID,this.Type,amount.ToString()};
                return data;
            }
            public override string ToString()
            {
                return Type;
            }
        }
    }
}
