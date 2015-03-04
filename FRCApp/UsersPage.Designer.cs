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
            this.SuspendLayout();
            // 
            // listusers
            // 
            this.listusers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.firstName,
            this.lastname,
            this.AccessLevel});
            this.listusers.FullRowSelect = true;
            this.listusers.Location = new System.Drawing.Point(41, 25);
            this.listusers.Name = "listusers";
            this.listusers.Size = new System.Drawing.Size(542, 216);
            this.listusers.TabIndex = 0;
            this.listusers.UseCompatibleStateImageBehavior = false;
            this.listusers.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "Username";
            this.UserName.Width = 131;
            // 
            // firstName
            // 
            this.firstName.Text = "First name";
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
            this.newUser.Location = new System.Drawing.Point(58, 263);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(129, 23);
            this.newUser.TabIndex = 1;
            this.newUser.Text = "create new User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(403, 263);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(129, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Cancel";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 298);
            this.Controls.Add(this.back);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.listusers);
            this.Name = "UsersPage";
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
    }
}