using System;
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

        public ClientDetails(Guid clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
            createClientObject();
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
            ClientDetailsNameTextBox.Text =
                clientData.FirstName +
                " " + clientData.MiddleInitial +
                " " + clientData.LastName;
            householdID = (clientData.HouseholdID);
            if (!clientData.IsAddressNull()) { ClientDetailsAddressTextBox.Text = clientData.Address; }
            //TODO: Last contact date
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
            foreach (var efaRequest in activeEfaRequests)
            {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.RequestTypes);
                lstActiveReq.Items.Add(item);
            }

            var inactiveEfaRequests = efaRequestDisplayAdapter.GetInactiveEFARequestsByClientID(ClientID.ToString());
            foreach (var efaRequest in inactiveEfaRequests)
            {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.RequestTypes);
                lstViewHist.Items.Add(item);
            }
            loadcaseNote();
        }

        private void loadcaseNote()
        {
            var casenoteadapter = new DataSet1TableAdapters.CaseNoteTableAdapter();
            var casenotes = casenoteadapter.GetcasenotebyId(ClientID.ToString());
            foreach (var casenote in casenotes)
            {
                var item = new ListViewItem(casenote.date.ToString("MM/dd/yyyy"));
                item.Tag = casenote.Id;
                item.SubItems.Add(casenote.updateType);
                item.SubItems.Add(casenote.comment);
                lstCaseNotes.Items.Add(item);
            }
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            clientData = new DataSet1TableAdapters.ClientsTableAdapter().GetData().FindByClientID(ClientID);
            new NewClient(clientData).Show();
        }

        private void clrbutton_Click(object sender, EventArgs e)
        {
            txtcomment.Text = "";
            txtupdateType.Text = "";
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
            MessageBox.Show("this");
        }
    }
}
