﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fc_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {
            NewClient nc = new NewClient();
            nc.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lstClients.Items.Clear();
            dBDataSetTableAdapters.ClientsTableAdapter tbl = new dBDataSetTableAdapters.ClientsTableAdapter();

            foreach (dBDataSet.ClientsRow r in tbl.GetClientsByLastName(textBox1.Text.Trim()))
                lstClients.Items.Add(r.LastName + ", " + r.FirstName);

        }

        private void ow_Load(object sender, EventArgs e)
        {

        }
    }
}
