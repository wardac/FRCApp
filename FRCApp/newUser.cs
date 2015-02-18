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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool valid=true;
            foreach( Control x in this.Controls)
            {
                if ((x is TextBox)&&( x.Text.Trim()==""))
                {
                    valid = false;
                    MessageBox.Show(x.Name + " cannot be empty");
                }
            }
            if (valid == true)
            {
                MessageBox.Show( "cool");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
