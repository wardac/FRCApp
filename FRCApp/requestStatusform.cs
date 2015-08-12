using System;
using System.Collections.Generic;
using System.Collections;
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
        Boolean NewRequest;
        Guid ClientID;
        String RequestID;
        public requestStatusform(Guid ClientID, String RequestID, Boolean NewRequest, Action OnCloseEvent)
        {
            this.NewRequest = NewRequest;
            InitializeComponent();
            this.ClientID = ClientID;
            this.RequestID = RequestID ?? System.Guid.NewGuid().ToString();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler((o, e) => OnCloseEvent());
        }



        private void efa_proofaddress_CheckedChanged(object sender, EventArgs e)
        {
            addressdate.Visible = efa_proofaddress.Checked;
        }

        private void efa_proofHousehold_CheckedChanged(object sender, EventArgs e)
        {
            householdDate.Visible = efa_proofHousehold.Checked;
        }

        private void efa_proofIncome_CheckedChanged(object sender, EventArgs e)
        {
            incomedate.Visible = efa_proofIncome.Checked;
        }

        private void efa_proofharship_CheckedChanged(object sender, EventArgs e)
        {
            hardshipdate.Visible = efa_proofharship.Checked;
        }

        private void efa_proofAssistance_CheckedChanged(object sender, EventArgs e)
        {
            assistancedate.Visible = efa_proofAssistance.Checked;
        }


        private void requestStatusform_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClientsTableAdapter client = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = client.GetDataByid(ClientID);
            efa_clientName.Text = clients[0].FirstName;
            DataSet1TableAdapters.IncomeInfoTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeInfoTableAdapter();
            var incomeinfo = incomeAdapter.GetIncomeInfo(clients[0].HouseholdID);

            var hardshipsAdapter = new DataSet1TableAdapters.HardshipTypesTableAdapter();
            var hardships = hardshipsAdapter.GetData();

            //adding financial summary
            DataSet1TableAdapters.MonthlyExpensesSummaryTableAdapter monthExpensesAdapter = new DataSet1TableAdapters.MonthlyExpensesSummaryTableAdapter();
            var monthRequests = monthExpensesAdapter.getMonthlyExpensesByHouseholdID(clients[0].HouseholdID);
            DataSet1TableAdapters.IncomeByHouseholdIDAndChangeDateTableAdapter amtAdapter = new DataSet1TableAdapters.IncomeByHouseholdIDAndChangeDateTableAdapter();
            var reqs = amtAdapter.getIncomeChangesByDate(clients[0].HouseholdID);
            foreach (var req in reqs)
            {

                ListViewItem item = new ListViewItem(req.Date.ToString("MM/dd/yyyy"));
                String[] data = { req.QuarterlyAmount.ToString("F"), req.MonthlyAmount.ToString("F") };
            
                item.SubItems.AddRange(data);
                lstFinances.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }

                //end of financial summmary
            foreach (var amt in monthRequests)
            {
                ListViewItem item = new ListViewItem(amt.dateChanged.ToString("MM/dd/yyyy"));
                String[] data = { amt.MonthExpenses.ToString("F"), };
                item.SubItems.AddRange(data);
                lstExpenses.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
                if (NewRequest)
                {
                    this.Text = "New EFA Request";
                    lst_reqTypes.Visible = false;
                    var reqTypes = this.eFARequestTypesTableAdapter.GetData();
                    foreach (var reqType in reqTypes)
                    {
                        checklist_requestType.Items.Add(reqType.Type);
                    }
                    btn_handleRequest.Visible = false;
                }
                else
                {

                    checklist_requestType.Visible = false;
                    txt_other.Visible = false;
                    date_requestDate.Enabled = false;
                    datagridRequests.Visible = true;
                    var subrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
                    var subrequests = subrequestAdapter.GetEFASubrequestsByEFARequestID(RequestID);
                    datagridRequests.Rows.Clear();
                    foreach (var subrequest in subrequests)
                    {
                        lst_reqTypes.Items.Add(subrequest);
                        if (datagridRequests.Visible == true)
                        {
                            String[] data = { subrequest.EFARequestType, subrequest.amount + "" };
                            datagridRequests.Rows.Add(data);
                        }
                    }
                    lst_reqTypes.DisplayMember = "EFARequestType";

                    var requestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
                    var request = requestAdapter.GetEFARequestsByEFARequestID(RequestID)[0];
                    DateTime?[] dates = { (request.IsAddressVerificationNull() ? null : (DateTime?)request.AddressVerification), (request.IsHouseholdVerificationNull() ? null : (DateTime?)request.HouseholdVerification), (request.IsIncomeVerificationNull() ? null : (DateTime?)request.IncomeVerification), (request.IsBillVerificationNull() ? null : (DateTime?)request.BillVerification), (request.IsHardshipVerificationNull() ? null : (DateTime?)request.HardshipVerification) };
                    CheckBox[] boxes = { efa_proofaddress, efa_proofHousehold, efa_proofIncome, efa_proofAssistance, efa_proofharship };
                    DateTimePicker[] pickers = { addressdate, householdDate, incomedate, assistancedate, hardshipdate };

                    for (int i = 0; i < dates.Length; ++i)
                    {
                        if (dates[i] != null)
                        {
                            boxes[i].Checked = true;
                            pickers[i].Text = dates[i].ToString();
                        }
                    }

                    var hardship = hardshipsAdapter.GetHardshipsByID(request.HardshipTypeID)[0];

                    efa_comment.Text = request.HardshipDetail;
                    date_requestDate.Value = request.DateRequested;

                    if (!request.IsDateClosedNull())
                    {
                        lblApproval.Visible = true;
                        lblDenial.Visible = true;
                        txtApproval.Visible = true;
                        txtDenial.Visible = true;
                        date_completedDate.Value = request.DateClosed;
                        lbl_completedDate.Visible = true;
                        date_completedDate.Visible = true;
                        btn_handleRequest.Visible = false;
                        update_efa.Visible = false;
                        efa_comment.Enabled = false;
                        boxes.ToList().ForEach((box) => box.Enabled = false);
                        pickers.ToList().ForEach((picker) => picker.Enabled = false);
                        txtApproval.Text = request.ApprovalReason;
                        txtDenial.Text = request.DenialReason;
                    }

                }
        }

        private void update_efa_Click(object sender, EventArgs e)
        {

            CheckBox[] boxes = { efa_proofaddress, efa_proofHousehold, efa_proofIncome, efa_proofAssistance, efa_proofharship };
            DateTimePicker[] pickers = { addressdate, householdDate, incomedate, assistancedate, hardshipdate };
            DateTime?[] dates = new DateTime?[boxes.Length];
            for (int i = 0; i < boxes.Length; ++i) {
                dates[i] = boxes[i].Checked ? (DateTime?)DateTime.Parse(pickers[i].Text) : null;
            }

            var requestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
            requestAdapter.AddOrUpdateEFARequest(RequestID, ClientID.ToString(), dates[0], dates[1], dates[2], dates[3], dates[4], 7, efa_comment.Text, date_requestDate.Value, 3, null, null, null);

            if (NewRequest)
            {
                var subrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
                foreach (var category in checklist_requestType.CheckedItems)
                {
                    subrequestAdapter.AddOrUpdateEFASubrequest(System.Guid.NewGuid().ToString(), RequestID, category.ToString() == "Other" ? txt_other.Text : category.ToString(), null, null,0);
                }
            }
            this.Close();
        }

        private void cancelEfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_handleRequest_Click(object sender, EventArgs e)
        {
            var approvalForm = new ApprovalForm(RequestID, (() => this.Close()));
            this.Hide();
            approvalForm.Show();
        }
    }
}
