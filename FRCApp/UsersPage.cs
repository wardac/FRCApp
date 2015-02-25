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
        }

        private void fillListView()
        {
            DataSet1TableAdapters.UsersTableAdapter adapter = new DataSet1TableAdapters.UsersTableAdapter();
            foreach (DataRow row in adapter.GetData().Rows)
            {
               // ListViewItem item = new ListViewItem(row.);
            }
        }

        private void newUser_Click(object sender, EventArgs e)
        {

            newUser usr = new newUser();
            usr.Show();
        }
    }
}
