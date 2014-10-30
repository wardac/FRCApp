﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp {
    public partial class NewClient : Form {
        private HouseHoldForm householdForm;
        private ExpenseForm expenseForm;
        public NewClient() {
            InitializeComponent();
            householdForm = new HouseHoldForm();
            expenseForm = new ExpenseForm();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void householdInfo_button_Click(object sender, EventArgs e)
        {
            householdForm.Show();
        }

        private void monthlyExpenses_button_Click(object sender, EventArgs e)
        {
            expenseForm.Show();
        }

    }
}
