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
        private Guid selectedClientId = Guid.Empty;
        private string AccessLevel;
        private string userName;

        public StartPage(string AccessLevel, string userName)
        {
            this.AccessLevel = AccessLevel;
            this.userName = userName;        
            InitializeComponent();
            this.current_user.Text = userName;
            this.FormClosed += ExitProgramEvent;
        }

        private void addNewClient_button_Click(object sender, EventArgs e)
        {
            search_textBox.Text = "";
            NewClient nc = new NewClient(userName);
            nc.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            addItems(search_textBox.Text);
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            if (client_listView.SelectedItems.Count == 0 || (selectedClientId = new Guid(client_listView.SelectedItems[0].Tag.ToString())) == Guid.Empty)
            {
                MessageBox.Show("Please select a client");
                return;
            }
            client_listView.SelectedItems.Clear();
            new ClientDetails(selectedClientId, userName).Show();
        }

        private void users_Click(object sender, EventArgs e)
        {
            UsersPage usrpage = new UsersPage(userName);
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
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            if (!AccessLevel.Equals("Administrator"))
            {
                usersPagebutton.Visible = false;
            }
        }

        private void client_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (client_listView.SelectedItems.Count == 0 || (selectedClientId = new Guid(client_listView.SelectedItems[0].Tag.ToString())) == Guid.Empty)
            {
                MessageBox.Show("Please select a client");
                return;
            }
            client_listView.SelectedItems.Clear();
            new ClientDetails(selectedClientId, userName).Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.FormClosed -= ExitProgramEvent;
                this.Close();
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += ((o, a) => { if (LoginTimeout.LastInputTime() < DateTime.Now.AddMinutes(-30)) { Application.Exit(); } });
                new loginForm(timer).Show();
            }
        }

        private void viewReport_Click(object sender, EventArgs e)
        {
            new report(DateTime.Now.Year).Show();
        }

        private void ExitProgramEvent(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
