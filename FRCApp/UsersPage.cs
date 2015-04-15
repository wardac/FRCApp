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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
            fillListView();
        }

        /**
         * Fill the list view on the UsersPage with a summary of all of the users 
         * and their permission levels
         **/
        private void fillListView()
        {
            listusers.Items.Clear();
            DataSet1TableAdapters.UsersTableAdapter adapter = new DataSet1TableAdapters.UsersTableAdapter();
            foreach (DataRow row in adapter.GetData().Rows)
            {
                ListViewItem item = new ListViewItem(row["UserName"].ToString());
                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["AccessLevel"].ToString());
                listusers.Items.Add(item);
                if (item.Index % 2 == 0)
                { item.BackColor = Color.Gainsboro; }
                else
                { item.BackColor = Color.WhiteSmoke; }
            }
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            newUser usr = new newUser();
            usr.Show();
        }

        /**
         * Updates the users page every time it is activated
         **/
        private void UsersPage_Activated(object sender, EventArgs e)
        {
            fillListView();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
