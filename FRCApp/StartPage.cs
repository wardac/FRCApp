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
    public partial class StartPage : Form
    {
        private string selectedClientId = "";

        public StartPage()
        {
            InitializeComponent();
        }

        private void addNewClient_button_Click(object sender, EventArgs e)
        {
            NewClient nc = new NewClient();
            nc.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // earse any previous search results
            foreach (ListViewItem item in client_listView.Items)
            {
                item.Remove();
            }

            // query database
            DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = adapter.ClientLookUp(search_textBox.Text);

            // for each row in our query result, add a listViewItem to our listview
            foreach (DataSet1.ClientsRow row in clients)
            {
                ListViewItem item = new ListViewItem(row.ClientID.ToString());
                item.SubItems.Add(row.LastName + ", " + row.FirstName);
                item.SubItems.Add(row.Birthdate.ToShortDateString());
                item.SubItems.Add(row.Address);
                item.SubItems.Add(row.Phone1);
                client_listView.Items.Add(item);
            }
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            if (client_listView.SelectedItems.Count == 0 || (selectedClientId = client_listView.SelectedItems[0].SubItems[0].Text) == "")
            {
                MessageBox.Show("Please select a client");
                return;
            }
            client_listView.SelectedItems.Clear();
            new ClientDetails(selectedClientId).Show();
        }

        private void client_listView_Click(object sender, EventArgs e)
        {
        }

        private void users_Click(object sender, EventArgs e)
        {
            UsersPage usrpage = new UsersPage();
            usrpage.Show();
        }

    }
}
