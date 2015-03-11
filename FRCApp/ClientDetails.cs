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
        private string ClientID;
        private string householdID;
        private DataSet1.ClientsRow clientData;

        public ClientDetails(string clientID)
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

            ClientDetailsNameTextBox.Text =
                clientData.FirstName +
                " " + clientData.MiddleInitial +
                " " + clientData.LastName;
            householdID = clientData.HouseholdID;
            if (!clientData.IsAddressNull()) { ClientDetailsAddressTextBox.Text = clientData.Address; }
            //TODO: Last contact date
            if (!clientData.IsCityNull()) { ClientDetailsCityTextBox.Text = clientData.City; }
            if (!clientData.IsStateNull()) { ClientDetailsStateTextBox.Text = clientData.State; }
            if (!clientData.IsZipNull()) { ClientDetailsZipTextBox.Text = clientData.Zip; }
            if (!clientData.IsPhone1Null()) { ClientDetailsPhone1TextBox.Text = clientData.Phone1; }
            if (!clientData.IsPhone2Null()) { ClientDetailsPhone2TextBox.Text = clientData.Phone2; }
            if (!clientData.IsEmailNull()) { ClientDetailsEmailTextBox.Text = clientData.Email; }
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
        }

        private void LoadFormData()
        {
            lstActiveReq.Items.Clear();
            lstViewHist.Items.Clear();
            var efaRequestDisplayAdapter = new DataSet1TableAdapters.EFARequestsDisplayTableAdapter();
            var activeEfaRequests = efaRequestDisplayAdapter.GetActiveEFARequestsByClientID(ClientID);
            foreach (var efaRequest in activeEfaRequests)
            {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.RequestTypes);
                lstActiveReq.Items.Add(item);
            }

            var inactiveEfaRequests = efaRequestDisplayAdapter.GetInactiveEFARequestsByClientID(ClientID);
            foreach (var efaRequest in inactiveEfaRequests)
            {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.RequestTypes);
                lstViewHist.Items.Add(item);
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

        }
    }
}
