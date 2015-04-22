namespace FRCApp
{
    partial class StartPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.client_listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewClient_button = new System.Windows.Forms.Button();
            this.clientPage_button = new System.Windows.Forms.Button();
            this.usersPagebutton = new System.Windows.Forms.Button();
            this.startPage_panel = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.current_user = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.viewReport = new System.Windows.Forms.Button();
            this.startPage_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.ForeColor = System.Drawing.Color.Teal;
            this.search_label.Location = new System.Drawing.Point(11, 14);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(75, 13);
            this.search_label.TabIndex = 0;
            this.search_label.Text = "Client Lookup:";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(92, 10);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(142, 20);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // client_listView
            // 
            this.client_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.dateOfBirth,
            this.Address,
            this.number});
            this.client_listView.FullRowSelect = true;
            this.client_listView.Location = new System.Drawing.Point(14, 46);
            this.client_listView.MultiSelect = false;
            this.client_listView.Name = "client_listView";
            this.client_listView.Size = new System.Drawing.Size(550, 261);
            this.client_listView.TabIndex = 3;
            this.client_listView.UseCompatibleStateImageBehavior = false;
            this.client_listView.View = System.Windows.Forms.View.Details;
            this.client_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.client_listView_MouseDoubleClick);
            // 
            // name
            // 
            this.name.Text = "Last, First Name";
            this.name.Width = 141;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Text = "Date of Birth";
            this.dateOfBirth.Width = 93;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 188;
            // 
            // number
            // 
            this.number.Text = "Phone Number";
            this.number.Width = 92;
            // 
            // addNewClient_button
            // 
            this.addNewClient_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewClient_button.BackColor = System.Drawing.Color.Teal;
            this.addNewClient_button.ForeColor = System.Drawing.Color.White;
            this.addNewClient_button.Location = new System.Drawing.Point(14, 314);
            this.addNewClient_button.Name = "addNewClient_button";
            this.addNewClient_button.Size = new System.Drawing.Size(91, 23);
            this.addNewClient_button.TabIndex = 4;
            this.addNewClient_button.Text = "Add New Client";
            this.addNewClient_button.UseVisualStyleBackColor = false;
            this.addNewClient_button.Click += new System.EventHandler(this.addNewClient_button_Click);
            // 
            // clientPage_button
            // 
            this.clientPage_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPage_button.BackColor = System.Drawing.Color.Teal;
            this.clientPage_button.ForeColor = System.Drawing.Color.White;
            this.clientPage_button.Location = new System.Drawing.Point(465, 314);
            this.clientPage_button.Name = "clientPage_button";
            this.clientPage_button.Size = new System.Drawing.Size(98, 23);
            this.clientPage_button.TabIndex = 5;
            this.clientPage_button.Text = "Go to Client Page";
            this.clientPage_button.UseVisualStyleBackColor = false;
            this.clientPage_button.Click += new System.EventHandler(this.clientPage_button_Click);
            // 
            // usersPagebutton
            // 
            this.usersPagebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usersPagebutton.BackColor = System.Drawing.Color.Teal;
            this.usersPagebutton.ForeColor = System.Drawing.Color.White;
            this.usersPagebutton.Location = new System.Drawing.Point(411, 8);
            this.usersPagebutton.Name = "usersPagebutton";
            this.usersPagebutton.Size = new System.Drawing.Size(73, 23);
            this.usersPagebutton.TabIndex = 6;
            this.usersPagebutton.Text = "Users Page";
            this.usersPagebutton.UseVisualStyleBackColor = false;
            this.usersPagebutton.Click += new System.EventHandler(this.users_Click);
            // 
            // startPage_panel
            // 
            this.startPage_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startPage_panel.BackColor = System.Drawing.Color.Lavender;
            this.startPage_panel.Controls.Add(this.viewReport);
            this.startPage_panel.Controls.Add(this.logout_button);
            this.startPage_panel.Controls.Add(this.current_user);
            this.startPage_panel.Controls.Add(this.welcome_label);
            this.startPage_panel.Controls.Add(this.usersPagebutton);
            this.startPage_panel.Controls.Add(this.clientPage_button);
            this.startPage_panel.Controls.Add(this.addNewClient_button);
            this.startPage_panel.Controls.Add(this.client_listView);
            this.startPage_panel.Controls.Add(this.search_textBox);
            this.startPage_panel.Controls.Add(this.search_label);
            this.startPage_panel.Location = new System.Drawing.Point(2, 2);
            this.startPage_panel.Name = "startPage_panel";
            this.startPage_panel.Size = new System.Drawing.Size(574, 350);
            this.startPage_panel.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Teal;
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Location = new System.Drawing.Point(490, 8);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(73, 23);
            this.logout_button.TabIndex = 9;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user.ForeColor = System.Drawing.Color.Teal;
            this.current_user.Location = new System.Drawing.Point(321, 12);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(41, 15);
            this.current_user.TabIndex = 8;
            this.current_user.Text = "label1";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.Teal;
            this.welcome_label.Location = new System.Drawing.Point(240, 12);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(84, 15);
            this.welcome_label.TabIndex = 7;
            this.welcome_label.Text = "Logged in as: ";
            // 
            // viewReport
            // 
            this.viewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReport.BackColor = System.Drawing.Color.Teal;
            this.viewReport.ForeColor = System.Drawing.Color.White;
            this.viewReport.Location = new System.Drawing.Point(340, 316);
            this.viewReport.Name = "viewReport";
            this.viewReport.Size = new System.Drawing.Size(98, 23);
            this.viewReport.TabIndex = 10;
            this.viewReport.Text = "View Reports";
            this.viewReport.UseVisualStyleBackColor = false;
            this.viewReport.Click += new System.EventHandler(this.viewReport_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 353);
            this.Controls.Add(this.startPage_panel);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.Activated += new System.EventHandler(this.activated);
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.startPage_panel.ResumeLayout(false);
            this.startPage_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.ListView client_listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dateOfBirth;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Button addNewClient_button;
        private System.Windows.Forms.Button clientPage_button;
        private System.Windows.Forms.Button usersPagebutton;
        private System.Windows.Forms.Panel startPage_panel;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label current_user;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button viewReport;

    }
}