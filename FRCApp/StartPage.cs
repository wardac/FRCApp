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
        private string AccessLevel;

        public StartPage(string AccessLevel)
        {
            this.AccessLevel = AccessLevel;
            InitializeComponent();
        }

        private void addNewClient_button_Click(object sender, EventArgs e)
        {
            search_textBox.Text = "";
            NewClient nc = new NewClient();
            nc.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            addItems(search_textBox.Text);
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            if (client_listView.SelectedItems.Count == 0 || (selectedClientId = (String)client_listView.SelectedItems[0].Tag) == "")
            {
                MessageBox.Show("Please select a client");
                return;
            }
            client_listView.SelectedItems.Clear();
            new ClientDetails(selectedClientId).Show();
        }

        private void users_Click(object sender, EventArgs e)
        {
            UsersPage usrpage = new UsersPage();
            usrpage.Show();
        }

        /**
         * Populate listview with all current clients
         */
        private void activated(object sender, EventArgs e)
        {
            if (search_textBox.Text.Equals(""))
            {
                addItems("");
            }
        }

        /**
         * responsible for responsive filtering as the user enters text
         */
        private void textChanged(object sender, EventArgs e)
        {
            addItems(search_textBox.Text);
        }

        /**
         * Populate listview
         */
        private void addItems(string searchOn)
        {
            // clear items
            client_listView.Items.Clear();

            // query database
            DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
            var clients = adapter.ClientLookUp(searchOn);

            // for each row in our query result, add a listViewItem to our listview
            foreach (DataSet1.ClientsRow row in clients)
            {
                ListViewItem item = new ListViewItem(row.LastName + ", " + row.FirstName);
                item.Tag = row.ClientID;
                item.SubItems.Add(row.Birthdate.ToShortDateString());
                item.SubItems.Add(row.Address);
                item.SubItems.Add(row.Phone1);
                client_listView.Items.Add(item);
            }
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            if (!AccessLevel.Equals("admin"))
            {
                usersPagebutton.Visible = false;
            }
        }

    }
}
