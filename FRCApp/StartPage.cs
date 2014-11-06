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
        private int selectedClientId = -1;

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
            DataSet1TableAdapters.ClientsTableAdapter adapter = new DataSet1TableAdapters.ClientsTableAdapter();
            DataSet1.ClientsDataTable data = adapter.GetData();
            foreach (DataSet1.ClientsRow row in data)
            {
                ListViewItem item = new ListViewItem(row.LastName + ", " + row.FirstName);
                item.SubItems.Add(row.Birthdate.ToShortDateString());
                item.SubItems.Add(row.Address);
                item.SubItems.Add(row.Phone1);
                item.SubItems.Add(row.ClientID.ToString());
                client_listView.Items.Add(item);
            }
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            new ClientDetails(selectedClientId).Show();
        }

        private void client_listView_Click(object sender, EventArgs e)
        {
            if (client_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = client_listView.SelectedItems[0];
                selectedClientId = Int16.Parse(selectedItem.SubItems[4].Text);
            }

        }
    }
}
