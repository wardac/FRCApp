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
        private int ClientID;
        public ClientDetails(int clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
        }

        private void addEFAButton_Click(object sender, EventArgs e)
        {
            efaRequestForm efareq = new efaRequestForm();
            efareq.Show();
        }

        private void lstActiveReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
