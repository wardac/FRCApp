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
    public partial class ExpenseForm : Form
    {
        private const int BACKSPACE = 8;
        private const int DELETE = 46;
        private const int DECIMAL = 81;

        public ExpenseForm()
        {
            InitializeComponent();
        }

        /**
         * Allow for numbers to only be entered
         **/
        private void validateKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != BACKSPACE && ch != DELETE && ch != DECIMAL)
            {
                e.Handled = true;
            }
        }

        /**
         * Handle user clicking on the cancel button
         **/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
