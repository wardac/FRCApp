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
    public partial class loginForm : Form
    {
        private System.Timers.Timer timer;
        public loginForm(System.Timers.Timer timer)
        {
            InitializeComponent();
            this.timer = timer;
            this.FormClosed += ExitProgramEvent;
        }

        private void login_submit_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter usradapter = new DataSet1TableAdapters.UsersTableAdapter();
            Object level = usradapter.GetAccessLevel(this.login_username.Text, this.login_Password.Text);
            if (level != null)
            {
                // check for default password
                this.FormClosed -= ExitProgramEvent;
                timer.Enabled = true;
                StartPage startPage = new StartPage(level.ToString(), this.login_username.Text);
                this.Close();
                this.Dispose();
                startPage.Show();
            }
            else { MessageBox.Show("sorry wrong credentials"); }
        }



        private void login_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.login_username.Text = "";
            this.login_Password.Text = "";
        }

        private void ExitProgramEvent(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
