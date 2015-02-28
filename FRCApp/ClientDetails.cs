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
                if (!clientData.IsAddressNull()) { ClientDetailsAddressTextBox.Text = clientData.Address; }
                //TODO: Last contact date
                if (!clientData.IsCityNull()) { ClientDetailsCityTextBox.Text = clientData.City; }
                if (!clientData.IsStateNull()) { ClientDetailsStateTextBox.Text = clientData.State; }
                if (!clientData.IsZipNull()) { ClientDetailsZipTextBox.Text = clientData.Zip; }
                if (!clientData.IsPhone1Null()) { ClientDetailsPhone1TextBox.Text = clientData.Phone1; }
                if (!clientData.IsPhone2Null()) { ClientDetailsPhone2TextBox.Text = clientData.Phone2; }
                if (!clientData.IsEmailNull()) { ClientDetailsEmailTextBox.Text = clientData.Email; }
                /*   foreach (DataSet1.ClientsRow row in data)
                   {
                
                       ListViewItem item = new ListViewItem(row.LastName + ", " + row.FirstName);
                       item.SubItems.Add(row.Birthdate.ToShortDateString());
                       item.SubItems.Add(row.Address);
                       item.SubItems.Add(row.Phone1);
                       client_listView.Items.Add(item);
                   }*/
            
        }

        private void addEFAButton_Click(object sender, EventArgs e)
        {
            requestStatusform efareq = new requestStatusform(ClientID, true);
            efareq.Show();
        }

        private void lstActiveReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            var efaRequestAdapter = new DataSet1TableAdapters.EFARequestsTableAdapter();
            //var efaRequests = efaRequestAdapter.
        }
    }
}
