﻿using System;
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
        public requestStatusform(String ClientID, String RequestID, Boolean NewRequest)
        {
            this.NewRequest = NewRequest;
            InitializeComponent();
            this.ClientID = ClientID;
            this.RequestID = RequestID;
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
            txt_QHincome.Text = incomeinfo[0].QuarterlyIncome.ToString();
            txt_Mincome.Text = incomeinfo[0].MonthlyIncome.ToString();
            
            var expensesAdapter = new DataSet1TableAdapters.MonthlyExpensesTableAdapter();
            var monthlyExpenses = expensesAdapter.getExpenseInfoByHouseholdID(clients[0].HouseholdID);
            txt_Mexpenses.Text = monthlyExpenses.ToString();

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
            }
        }

        private void update_efa_Click(object sender, EventArgs e)
        {

        }
    }
}
