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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_submit_Click(object sender, EventArgs e)
        {
            
            StartPage startPage = new StartPage();
            this.Close();
            this.Dispose();
            startPage.Show();
        }

        private void login_cancel_Click(object sender, EventArgs e)
        {
            login_username.Clear();
            login_Password.Clear();
        }
    }
}
