namespace FRCApp
{
    partial class ow_tab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ow_dob_label = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.lstcontact = new System.Windows.Forms.Label();
            this.lastcontact = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.telnum = new System.Windows.Forms.TextBox();
            this.owpanel = new System.Windows.Forms.Panel();
            this.lblnumber = new System.Windows.Forms.Label();
            this.ow_state_combobox = new System.Windows.Forms.ComboBox();
            this.ow_state_label = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.ow_city_label = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.ow_zip_label = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.ow_address_label = new System.Windows.Forms.Label();
            this.ow_last_name_label = new System.Windows.Forms.Label();
            this.ow_first_name_label = new System.Windows.Forms.Label();
            this.owpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ow_dob_label
            // 
            this.ow_dob_label.AutoSize = true;
            this.ow_dob_label.Location = new System.Drawing.Point(21, 84);
            this.ow_dob_label.Name = "ow_dob_label";
            this.ow_dob_label.Size = new System.Drawing.Size(63, 13);
            this.ow_dob_label.TabIndex = 22;
            this.ow_dob_label.Text = "date of birth";
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(106, 78);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(174, 20);
            this.bdate.TabIndex = 21;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(229, 313);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(137, 313);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 19;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lstcontact
            // 
            this.lstcontact.AutoSize = true;
            this.lstcontact.Location = new System.Drawing.Point(310, 59);
            this.lstcontact.Name = "lstcontact";
            this.lstcontact.Size = new System.Drawing.Size(92, 13);
            this.lstcontact.TabIndex = 18;
            this.lstcontact.Text = "last contacted on:";
            // 
            // lastcontact
            // 
            this.lastcontact.Location = new System.Drawing.Point(313, 75);
            this.lastcontact.Name = "lastcontact";
            this.lastcontact.Size = new System.Drawing.Size(193, 20);
            this.lastcontact.TabIndex = 17;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(106, 287);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(124, 20);
            this.email.TabIndex = 16;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(21, 287);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(25, 13);
            this.lblmail.TabIndex = 15;
            this.lblmail.Text = "mail";
            // 
            // telnum
            // 
            this.telnum.Location = new System.Drawing.Point(106, 261);
            this.telnum.Name = "telnum";
            this.telnum.Size = new System.Drawing.Size(124, 20);
            this.telnum.TabIndex = 14;
            // 
            // owpanel
            // 
            this.owpanel.Controls.Add(this.ow_dob_label);
            this.owpanel.Controls.Add(this.bdate);
            this.owpanel.Controls.Add(this.cancel);
            this.owpanel.Controls.Add(this.save);
            this.owpanel.Controls.Add(this.lstcontact);
            this.owpanel.Controls.Add(this.lastcontact);
            this.owpanel.Controls.Add(this.email);
            this.owpanel.Controls.Add(this.lblmail);
            this.owpanel.Controls.Add(this.telnum);
            this.owpanel.Controls.Add(this.lblnumber);
            this.owpanel.Controls.Add(this.ow_state_combobox);
            this.owpanel.Controls.Add(this.ow_state_label);
            this.owpanel.Controls.Add(this.city);
            this.owpanel.Controls.Add(this.ow_city_label);
            this.owpanel.Controls.Add(this.zip);
            this.owpanel.Controls.Add(this.ow_zip_label);
            this.owpanel.Controls.Add(this.address);
            this.owpanel.Controls.Add(this.txtlname);
            this.owpanel.Controls.Add(this.txtname);
            this.owpanel.Controls.Add(this.ow_address_label);
            this.owpanel.Controls.Add(this.ow_last_name_label);
            this.owpanel.Controls.Add(this.ow_first_name_label);
            this.owpanel.Location = new System.Drawing.Point(3, 3);
            this.owpanel.Name = "owpanel";
            this.owpanel.Size = new System.Drawing.Size(549, 379);
            this.owpanel.TabIndex = 1;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(21, 261);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(41, 13);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "tel num";
            // 
            // ow_state_combobox
            // 
            this.ow_state_combobox.FormattingEnabled = true;
            this.ow_state_combobox.Location = new System.Drawing.Point(106, 220);
            this.ow_state_combobox.Name = "ow_state_combobox";
            this.ow_state_combobox.Size = new System.Drawing.Size(46, 21);
            this.ow_state_combobox.TabIndex = 12;
            // 
            // ow_state_label
            // 
            this.ow_state_label.AutoSize = true;
            this.ow_state_label.Location = new System.Drawing.Point(21, 228);
            this.ow_state_label.Name = "ow_state_label";
            this.ow_state_label.Size = new System.Drawing.Size(30, 13);
            this.ow_state_label.TabIndex = 9;
            this.ow_state_label.Text = "state";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(106, 147);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(174, 20);
            this.city.TabIndex = 8;
            // 
            // ow_city_label
            // 
            this.ow_city_label.AutoSize = true;
            this.ow_city_label.Location = new System.Drawing.Point(21, 147);
            this.ow_city_label.Name = "ow_city_label";
            this.ow_city_label.Size = new System.Drawing.Size(23, 13);
            this.ow_city_label.TabIndex = 7;
            this.ow_city_label.Text = "city";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(106, 192);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(65, 20);
            this.zip.TabIndex = 6;
            // 
            // ow_zip_label
            // 
            this.ow_zip_label.AutoSize = true;
            this.ow_zip_label.Location = new System.Drawing.Point(21, 192);
            this.ow_zip_label.Name = "ow_zip_label";
            this.ow_zip_label.Size = new System.Drawing.Size(20, 13);
            this.ow_zip_label.TabIndex = 5;
            this.ow_zip_label.Text = "zip";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(106, 120);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(174, 21);
            this.address.TabIndex = 4;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(106, 52);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(174, 20);
            this.txtlname.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(106, 25);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // ow_address_label
            // 
            this.ow_address_label.AutoSize = true;
            this.ow_address_label.Location = new System.Drawing.Point(21, 120);
            this.ow_address_label.Name = "ow_address_label";
            this.ow_address_label.Size = new System.Drawing.Size(47, 13);
            this.ow_address_label.TabIndex = 2;
            this.ow_address_label.Text = "address:";
            // 
            // ow_last_name_label
            // 
            this.ow_last_name_label.AutoSize = true;
            this.ow_last_name_label.Location = new System.Drawing.Point(21, 59);
            this.ow_last_name_label.Name = "ow_last_name_label";
            this.ow_last_name_label.Size = new System.Drawing.Size(52, 13);
            this.ow_last_name_label.TabIndex = 1;
            this.ow_last_name_label.Text = "last name";
            // 
            // ow_first_name_label
            // 
            this.ow_first_name_label.AutoSize = true;
            this.ow_first_name_label.Location = new System.Drawing.Point(21, 25);
            this.ow_first_name_label.Name = "ow_first_name_label";
            this.ow_first_name_label.Size = new System.Drawing.Size(52, 13);
            this.ow_first_name_label.TabIndex = 0;
            this.ow_first_name_label.Text = "first name";
            // 
            // ow_tab
            // 
            this.Controls.Add(this.owpanel);
            this.Name = "ow_tab";
            this.Size = new System.Drawing.Size(847, 569);
            this.owpanel.ResumeLayout(false);
            this.owpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ow_dob_label;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label lstcontact;
        private System.Windows.Forms.DateTimePicker lastcontact;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox telnum;
        private System.Windows.Forms.Panel owpanel;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.ComboBox ow_state_combobox;
        private System.Windows.Forms.Label ow_state_label;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label ow_city_label;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label ow_zip_label;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label ow_address_label;
        private System.Windows.Forms.Label ow_last_name_label;
        private System.Windows.Forms.Label ow_first_name_label;
    }
}
