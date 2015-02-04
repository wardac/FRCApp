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
    public partial class HouseHoldForm : Form
    {
        private DataSet1.HouseholdMembersDataTable table;
        private Guid houseHoldId;

        public HouseHoldForm(Guid houseHoldId)
        {
            InitializeComponent();
            table = new DataSet1.HouseholdMembersDataTable();
            this.houseHoldId = houseHoldId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HouseHoldAddButton_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                MessageBox.Show("You must enter all of the information.");
                return;
            } 
            
            //Add the items to the listView
            ListViewItem item = new ListViewItem(HouseHoldFormFirstNameTextBox.Text);
            //item.SubItems.Add();
            item.SubItems.Add(HouseHoldFormlastNameTextBox.Text);
            item.SubItems.Add(HouseHoldFormlast4DigitsOfSsnTextBox.Text);
            item.SubItems.Add(HouseHoldFormBirthDateDateTimePicker.Text);
            item.SubItems.Add(HouseHoldFormRelationshipToApplicant.Text);
            item.SubItems.Add(HouseHoldFormEthnicityListBox.SelectedValue.ToString());
            item.SubItems.Add((!HouseHoldFormRadioButtonNo.Checked).ToString());

            HouseHoldForm_ListView_Summary.Items.Add(item);
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void HouseHoldFormLastName_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // add ListView items to DataSet1 table
           DataSet1TableAdapters.HouseholdMembersTableAdapter adapter = new DataSet1TableAdapters.HouseholdMembersTableAdapter();
            foreach (ListViewItem item in HouseHoldForm_ListView_Summary.Items) {
               
                adapter.addHouseHoldMember(houseHoldId.ToString(),
                        item.SubItems[0].Text,
                        item.SubItems[1].Text,
                        System.DateTime.Parse(item.SubItems[3].Text),
                        item.SubItems[4].Text,
                        item.SubItems[5].Text,
                        Convert.ToBoolean(item.SubItems[6].Text),
                        item.SubItems[2].Text
                 );
            }

            this.Close();
        }

        private void HouseHoldForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Races' table. You can move, or remove it, as needed.
            this.racesTableAdapter.Fill(this.dataSet1.Races);

        }

        private bool validateForm() {
            return textExists(HouseHoldFormFirstNameTextBox.Text)
                && textExists(HouseHoldFormlastNameTextBox.Text)
                && textExists(HouseHoldFormlast4DigitsOfSsnTextBox.Text)
                && textExists(HouseHoldFormBirthDateDateTimePicker.Text)
                && textExists(HouseHoldFormRelationshipToApplicant.Text)
                && textExists((string)HouseHoldFormEthnicityListBox.SelectedValue)
                && (HouseHoldFormRadioButtonYes.Checked || HouseHoldFormRadioButtonNo.Checked);
        }

        private bool textExists(string str) {
            return str != null && str != "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HouseHoldFormCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /**
         * Remove all of the selected items form the HouseHoldForm_ListView_Summary
         **/
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in HouseHoldForm_ListView_Summary.SelectedItems)
            {
                item.Remove();
            }     
        }
    }
}
