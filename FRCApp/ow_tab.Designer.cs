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
            this.label1 = new System.Windows.Forms.Label();
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
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.lblzip = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.owpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "date of birth";
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
            this.owpanel.Controls.Add(this.label1);
            this.owpanel.Controls.Add(this.bdate);
            this.owpanel.Controls.Add(this.cancel);
            this.owpanel.Controls.Add(this.save);
            this.owpanel.Controls.Add(this.lstcontact);
            this.owpanel.Controls.Add(this.lastcontact);
            this.owpanel.Controls.Add(this.email);
            this.owpanel.Controls.Add(this.lblmail);
            this.owpanel.Controls.Add(this.telnum);
            this.owpanel.Controls.Add(this.lblnumber);
            this.owpanel.Controls.Add(this.cmbState);
            this.owpanel.Controls.Add(this.lblstate);
            this.owpanel.Controls.Add(this.city);
            this.owpanel.Controls.Add(this.lblcity);
            this.owpanel.Controls.Add(this.zip);
            this.owpanel.Controls.Add(this.lblzip);
            this.owpanel.Controls.Add(this.address);
            this.owpanel.Controls.Add(this.txtlname);
            this.owpanel.Controls.Add(this.txtname);
            this.owpanel.Controls.Add(this.lblAddress);
            this.owpanel.Controls.Add(this.lblLastname);
            this.owpanel.Controls.Add(this.lblname);
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
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(106, 220);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(46, 21);
            this.cmbState.TabIndex = 12;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(21, 228);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(30, 13);
            this.lblstate.TabIndex = 9;
            this.lblstate.Text = "state";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(106, 147);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(174, 20);
            this.city.TabIndex = 8;
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(21, 147);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(23, 13);
            this.lblcity.TabIndex = 7;
            this.lblcity.Text = "city";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(106, 192);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(65, 20);
            this.zip.TabIndex = 6;
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Location = new System.Drawing.Point(21, 192);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(20, 13);
            this.lblzip.TabIndex = 5;
            this.lblzip.Text = "zip";
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "address:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(21, 59);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(52, 13);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "last name";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(21, 25);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "first name";
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

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblname;
    }
}
