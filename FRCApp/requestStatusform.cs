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
        Boolean NewRequest;
        String ClientID;
        String RequestID;
        public requestStatusform(String ClientID, String RequestID, Boolean NewRequest, Action OnCloseEvent)
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
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);
            
           
           
            // TODO: This line of code loads data into the 'dataSet1.EFARequestTypes' table. You can move, or remove it, as needed.
            this.eFARequestTypesTableAdapter.Fill(this.dataSet1.EFARequestTypes);

            //cmbEfaCategory.DataSource = this.eFARequestTypesTableAdapter.GetData();
            //cmbEfaCategory.ValueMember = "EFARequestTypeID";
            //cmbEfaCategory.DisplayMember = "Type";
            

            DataSet1TableAdapters.ClientsTableAdapter client = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = client.GetDataByid(ClientID);
            efa_clientName.Text = clients[0].FirstName;
            DataSet1TableAdapters.IncomeInfoTableAdapter incomeAdapter = new DataSet1TableAdapters.IncomeInfoTableAdapter();
            var incomeinfo = incomeAdapter.GetIncomeInfo(clients[0].HouseholdID);
            if (incomeinfo != null && incomeinfo.Count > 0)
            {
                txt_QHincome.Text = incomeinfo[0].QuarterlyIncome.ToString();
                txt_Mincome.Text = incomeinfo[0].MonthlyIncome.ToString();
            }
            else
            {
                txt_QHincome.Text = "0";
                txt_Mincome.Text = "0";
            }
            
            var expensesAdapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            var monthlyExpenses = expensesAdapter.getExpenseInfoByHouseholdID(clients[0].HouseholdID);
            txt_Mexpenses.Text = monthlyExpenses == null ? "0" : monthlyExpenses.ToString();

            var hardshipsAdapter = new DataSet1TableAdapters.HardshipTypesTableAdapter();
            var hardships = hardshipsAdapter.GetData();
            cmb_hardship.DataSource = hardships;
            cmb_hardship.DisplayMember = "Name";
            cmb_hardship.ValueMember = "HardshipTypeID";

            cmb_hardship.SelectedIndexChanged += new System.EventHandler((object o, System.EventArgs e2) =>
            {
                var hardship = hardshipsAdapter.GetHardshipsByID((int)cmb_hardship.SelectedValue)[0];
                txt_hardshipDesc.Text = hardship.Description;
            });


            if (NewRequest)
            {
                this.Text = "New EFA Request";
                lst_reqTypes.Visible = false;
                var reqTypes = this.eFARequestTypesTableAdapter.GetData();
                foreach (var reqType in reqTypes)
                {
                    checklist_requestType.Items.Add(reqType.Type);
                }
                var hardship = hardshipsAdapter.GetHardshipsByID((int)cmb_hardship.SelectedValue)[0];
                txt_hardshipDesc.Text = hardship.Description;
            }
            else
            {
                checklist_requestType.Visible = false;
                txt_other.Visible = false;
                date_requestDate.Enabled = false;
                var subrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
                var subrequests = subrequestAdapter.GetEFASubrequestsByEFARequestID(RequestID);
                foreach (var subrequest in subrequests)
                {
                    lst_reqTypes.Items.Add(subrequest);
                }
                lst_reqTypes.DisplayMember = "EFARequestType";

                var requestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
                var request = requestAdapter.GetEFARequestsByEFARequestID(RequestID)[0];

                DateTime?[] dates = { (request.IsAddressVerificationNull() ? null : (DateTime?)request.AddressVerification), (request.IsHouseholdVerificationNull() ? null : (DateTime?)request.HouseholdVerification), (request.IsIncomeVerificationNull() ? null : (DateTime?) request.IncomeVerification), (request.IsBillVerificationNull() ? null : (DateTime?)request.BillVerification), (request.IsHardshipVerificationNull() ? null : (DateTime?)request.HardshipVerification) };
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

                cmb_hardship.Text = hardship.Name;
                txt_hardshipDesc.Text = hardship.Description;
                efa_comment.Text = request.HardshipDetail;
                date_requestDate.Value = request.DateRequested;
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
            requestAdapter.AddOrUpdateEFARequest(RequestID, ClientID, dates[0], dates[1], dates[2], dates[3], dates[4], (int)cmb_hardship.SelectedValue, efa_comment.Text, date_requestDate.Value, 3);

            if (NewRequest)
            {
                var subrequestAdapter = new DataSet1TableAdapters.EFASubrequestsTableAdapter();
                foreach (var category in checklist_requestType.CheckedItems)
                {
                    subrequestAdapter.AddOrUpdateEFASubrequest(System.Guid.NewGuid().ToString(), RequestID, category.ToString(), null, null);
                }
            }
            this.Close();
        }

        private void cancelEfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
