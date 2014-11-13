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
    public partial class FinanceForm : Form
    {
        // ListView to keep track of all formData
        ListView formData;

        public FinanceForm()
        {
            InitializeComponent();
        }

        public FinanceForm(ListView data)
        {
            InitializeComponent();
            formData = data;
        }

        private void FinanceFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void FinanceFormlastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinanceFormFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinanceFormLastName_Click(object sender, EventArgs e)
        {

        }

        private void FinanceSubmitAdd_Click(object sender, EventArgs e)
        {

        }

        private void FinanceFormFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
