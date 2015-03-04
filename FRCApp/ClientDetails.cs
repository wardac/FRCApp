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

        public ClientDetails(string clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
            fillFields();
        }

        /**
        * This will fill all of the required fields
        * relevant to the client
        */
        private void fillFields()
        {
            //get data fromt the Client table
            DataSet1.ClientsRow clientData = new DataSet1TableAdapters.ClientsTableAdapter().GetData().FindByClientID(ClientID);
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
            requestStatusform efareq = new requestStatusform(ClientID, null, true);
            efareq.Show();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            // get all efa requests
            var efaRequestDisplayAdapter = new DataSet1TableAdapters.EFARequestsDisplayTableAdapter();
            var efaRequests = efaRequestDisplayAdapter.GetActiveEFARequestsByClientID(ClientID);
            foreach (var efaRequest in efaRequests) {
                var item = new ListViewItem(efaRequest.DateRequested.ToString("MM/dd/yyyy"));
                item.Tag = efaRequest.EFARequestID;
                item.SubItems.Add(efaRequest.RequestTypes);
                item.SubItems.Add(efaRequest.Status);
                lstActiveReq.Items.Add(item);
            }

            // honestly don't know what this does. Someone explain this.
            lstActiveReq.DoubleClick += new System.EventHandler((object o, System.EventArgs e1) =>
            {
                requestStatusform efareq = new requestStatusform(ClientID, lstActiveReq.SelectedItems[0].Tag.ToString(), false);
                efareq.Show();
            });
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {

            new NewClient(ClientID, householdID).Show();
        }
    }
}
