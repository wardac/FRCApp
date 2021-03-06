﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp
{
    public partial class ClientDetails : Form
    {
        private Guid ClientID;
        private Guid householdID;
        private DataSet1.ClientsRow clientData;
        private string userName;

        public ClientDetails(Guid clientID, string userName)
        {
            this.ClientID = clientID;
            this.userName = userName;
            InitializeComponent();
            createClientObject();
            this.username_label.Text = userName;
        }

        /**
        * This will fill all of the required fields
        * relevant to the client
        */
        private void createClientObject()
        {
            // get data fromt the Client table
            clientData = new DataSet1TableAdapters.ClientsTableAdapter().GetData().FindByClientID(ClientID);
            ClientID = (clientData.ClientID);
            householdID = (clientData.HouseholdID);
            ClientDetailsNameTextBox.Text = clientData.FirstName + " " + clientData.MiddleInitial + " " + clientData.LastName;
            if (!clientData.IsAddressNull()) { ClientDetailsAddressTextBox.Text = clientData.Address; }
            if (!clientData.IsAptNoNull()) { txt_aptno.Text = clientData.AptNo; }
            if (!clientData.IsCityNull()) { ClientDetailsCityTextBox.Text = clientData.City; }
            if (!clientData.IsStateNull()) { ClientDetailsStateTextBox.Text = clientData.State; }
            if (!clientData.IsZipNull()) { ClientDetailsZipTextBox.Text = clientData.Zip; }
            if (!clientData.IsPhone1Null()) { ClientDetailsPhone1TextBox.Text = clientData.Phone1; }
            if (!clientData.IsPhone2Null()) { ClientDetailsPhone2TextBox.Text = clientData.Phone2; }
            if (!clientData.IsEmailNull()) { ClientDetailsEmailTextBox.Text = clientData.Email; }
            if (!clientData.IsLastContactNull()) { ClientdateContact.Value = clientData.LastContact; }
        }

        private void addEFAButton_Click(object sender, EventArgs e)
        {
            requestStatusform efareq = new requestStatusform(ClientID, null, true, (() => LoadFormData()));
            efareq.Show();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            LoadFormData();

            lstActiveReq.DoubleClick += new System.EventHandler((object o, System.EventArgs e1) =>
            {
                requestStatusform efareq = new requestStatusform(ClientID, lstActiveReq.SelectedItems[0].Tag.ToString(), false, (() => LoadFormData()));
                efareq.Show();
            });

            lstViewHist.DoubleClick += new System.EventHandler((object o, System.EventArgs e1) =>
            {
                requestStatusform efareq = new requestStatusform(ClientID, lstViewHist.SelectedItems[0].Tag.ToString(), false, (() => LoadFormData()));
                efareq.Show();
            });

            this.ClientdateContact.ValueChanged += new System.EventHandler(this.ClientdateContact_ValueChanged);
        }

        private void LoadFormData()
        {
            lstActiveReq.Items.Clear();
            lstViewHist.Items.Clear();
            var efaRequestDisplayAdapter = new DataSet1TableAdapters.EFARequestsDisplayTableAdapter();
            var activeEfaRequests = efaRequestDisplayAdapter.GetActiveEFARequestsByClientID(ClientID.ToString());
            if (activeEfaRequests.IsInitialized )
            {
                foreach (var efaRequest in activeEfaRequests)
                {
                    var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
               
                    item.Tag = efaRequest.EFARequestID;
                    item.SubItems.Add(efaRequest.RequestTypes);
                    lstActiveReq.Items.Add(item);
                    if (item.Index % 2 == 0)
                    {item.BackColor = Color.Gainsboro;}
                    else
                    {  item.BackColor = Color.WhiteSmoke;}
                }
            }

            var inactiveEfaRequests = efaRequestDisplayAdapter.GetInactiveEFARequestsByClientID(ClientID.ToString());
            DateTime lowestDate=DateTime.Now;
            foreach (var efaRequest in inactiveEfaRequests)
            {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                if (efaRequest.DateRequested < lowestDate)
                {
                    lowestDate = efaRequest.DateRequested;
                }
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.HandledRequestTypes);
                item.SubItems.Add(efaRequest.totalamount + "");
                item.SubItems.Add(efaRequest.RequestTypes);
                lstViewHist.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
            fromDate.Value = lowestDate;
            loadcaseNote();
            loadQuickReport();
        }

        private void loadQuickReport()
        {
            var totalRequest = lstViewHist.Items.Count;
            var totalRequestApproved = 0;
            Decimal totalAmountApproved=0;
            foreach(ListViewItem itm in lstViewHist.Items)
            {
                if (itm.SubItems[2].Text != 0 + "")
                {
                    totalRequestApproved++;
                    totalAmountApproved += Convert.ToDecimal(itm.SubItems[2].Text);
                }
            }
            txtTotalRequest.Text = totalRequest.ToString();
            txtApprovedRequest.Text = totalRequestApproved.ToString();
            //TxtApprovedAmount.Text = totalAmountApproved.ToString();
            TxtApprovedAmount.Text = string.Format("{0:c}", totalAmountApproved) ;
        }
        private void loadcaseNote()
        {
            lstCaseNotes.Items.Clear();
            var casenoteadapter = new DataSet1TableAdapters.CaseNoteTableAdapter();
            var casenotes = casenoteadapter.GetcasenotebyId(ClientID.ToString());
            foreach (var casenote in casenotes)
            {
                var item = new ListViewItem(casenote.date.ToString("MM/dd/yyyy"));
                item.Tag = casenote.Id;
                item.SubItems.Add(casenote.updateType);
                item.SubItems.Add(casenote.comment);
                lstCaseNotes.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            clientData = new DataSet1TableAdapters.ClientsTableAdapter().GetData().FindByClientID(ClientID);
            new NewClient(clientData, userName).Show();
        }

        private void clrbutton_Click(object sender, EventArgs e)
        {
            txtcomment.Text = "";
            txtupdateType.Text = "";
            addcase.Enabled = true;
        }

        private void addcase_Click(object sender, EventArgs e)
        {
            if (txtcomment.Text.Trim() != "" && txtupdateType.Text.Trim() != "")
            {
                DataSet1TableAdapters.CaseNoteTableAdapter caseAdapter = new DataSet1TableAdapters.CaseNoteTableAdapter();
                caseAdapter.addCaseNote(System.DateTime.Now, txtupdateType.Text, txtcomment.Text, ClientID.ToString());
                txtupdateType.Clear();
                txtcomment.Clear();
                lstCaseNotes.Items.Clear();
                loadcaseNote();
            }
        }


        // update any changed information when the form regains focus
        private void ClientDetails_Activated(object sender, EventArgs e)
        {
            // get data fromt the Client table
            clientData = new DataSet1TableAdapters.ClientsTableAdapter().GetData().FindByClientID(ClientID);
            ClientDetailsNameTextBox.Text = clientData.FirstName + " " + clientData.MiddleInitial + " " + clientData.LastName;
            if (!clientData.IsAddressNull()) { ClientDetailsAddressTextBox.Text = clientData.Address; }
            if (!clientData.IsAptNoNull()) { txt_aptno.Text = clientData.AptNo; }
            //TODO: Last contact date
            if (!clientData.IsCityNull()) { ClientDetailsCityTextBox.Text = clientData.City; }
            if (!clientData.IsStateNull()) { ClientDetailsStateTextBox.Text = clientData.State; }
            if (!clientData.IsZipNull()) { ClientDetailsZipTextBox.Text = clientData.Zip; }
            if (!clientData.IsPhone1Null()) { ClientDetailsPhone1TextBox.Text = clientData.Phone1; }
            if (!clientData.IsPhone2Null()) { ClientDetailsPhone2TextBox.Text = clientData.Phone2; }
            if (!clientData.IsEmailNull()) { ClientDetailsEmailTextBox.Text = clientData.Email; }
        }

        private void editHouseholdInformationButton_Click(object sender, EventArgs e)
        {
            new HouseHoldForm(householdID).Show();
        }

        private void editMonthlyExpensesButton_Click(object sender, EventArgs e)
        {
            new ExpenseForm(householdID).Show();
        }

        private void editIncomeAndFinancesButton_Click(object sender, EventArgs e)
        {
            new FinanceForm(householdID.ToString()).Show();
        }

        private void ClientdateContact_ValueChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClientsTableAdapter dateAdapter = new DataSet1TableAdapters.ClientsTableAdapter();
            dateAdapter.editContactDate(ClientdateContact.Value, ClientID);
            MessageBox.Show("last contact date changed");
        }

        private void lstCaseNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCaseNotes.SelectedItems.Count != 1)
            {
                return;
            }
            txtupdateType.Text =lstCaseNotes.SelectedItems[0].SubItems[1].Text;
            txtcomment.Text = lstCaseNotes.SelectedItems[0].SubItems[2].Text;
            addcase.Enabled = false;
            lstCaseNotes.SelectedItems.Clear();
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var efaRequestDisplayAdapter = new DataSet1TableAdapters.EFARequestsDisplayTableAdapter();
            var inactiveEfaRequests = efaRequestDisplayAdapter.GetInactiveEFARequestsByClientID(ClientID.ToString());
            DateTime lowestDate = fromDate.Value;
            lstViewHist.Items.Clear();
            foreach (var efaRequest in inactiveEfaRequests)
            {

                if (efaRequest.DateRequested>=fromDate.Value  && efaRequest.DateRequested <= Todate.Value)
                {
                    var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                    item.Tag = efaRequest.EFARequestID;
                    item.SubItems.Add(efaRequest.HandledRequestTypes);
                    item.SubItems.Add(efaRequest.totalamount + "");
                    item.SubItems.Add(efaRequest.RequestTypes);
                    lstViewHist.Items.Add(item);  
                }
            }
            loadQuickReport();
        }

        private void lstViewHist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
