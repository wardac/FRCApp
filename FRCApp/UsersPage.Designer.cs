namespace FRCApp
{
    partial class UsersPage
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
            this.listusers = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newUser = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listusers
            // 
            this.listusers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listusers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.firstName,
            this.lastname,
            this.AccessLevel});
            this.listusers.FullRowSelect = true;
            this.listusers.Location = new System.Drawing.Point(41, 25);
            this.listusers.MultiSelect = false;
            this.listusers.Name = "listusers";
            this.listusers.Size = new System.Drawing.Size(542, 216);
            this.listusers.TabIndex = 0;
            this.listusers.UseCompatibleStateImageBehavior = false;
            this.listusers.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 131;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 146;
            // 
            // lastname
            // 
            this.lastname.Text = "Last Name";
            this.lastname.Width = 126;
            // 
            // AccessLevel
            // 
            this.AccessLevel.Text = "Access Level";
            this.AccessLevel.Width = 199;
            // 
            // newUser
            // 
            this.newUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newUser.BackColor = System.Drawing.Color.Teal;
            this.newUser.ForeColor = System.Drawing.Color.White;
            this.newUser.Location = new System.Drawing.Point(41, 263);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(129, 23);
            this.newUser.TabIndex = 1;
            this.newUser.Text = "Create User";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackColor = System.Drawing.Color.Teal;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(452, 263);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(129, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(178, 263);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete User";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_edit.BackColor = System.Drawing.Color.Teal;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(315, 263);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit User";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(613, 298);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.listusers);
            this.Name = "UsersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users page";
            this.Activated += new System.EventHandler(this.UsersPage_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listusers;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader AccessLevel;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}