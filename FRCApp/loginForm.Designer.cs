namespace FRCApp
{
    partial class loginForm
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
            this.login_submit = new System.Windows.Forms.Button();
            this.login_cancel = new System.Windows.Forms.Button();
            this.lbl_usrname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_submit
            // 
            this.login_submit.Location = new System.Drawing.Point(165, 135);
            this.login_submit.Name = "login_submit";
            this.login_submit.Size = new System.Drawing.Size(75, 23);
            this.login_submit.TabIndex = 2;
            this.login_submit.Text = "submit";
            this.login_submit.UseVisualStyleBackColor = true;
            this.login_submit.Click += new System.EventHandler(this.login_submit_Click);
            // 
            // login_cancel
            // 
            this.login_cancel.Location = new System.Drawing.Point(257, 135);
            this.login_cancel.Name = "login_cancel";
            this.login_cancel.Size = new System.Drawing.Size(75, 23);
            this.login_cancel.TabIndex = 3;
            this.login_cancel.Text = "cancel";
            this.login_cancel.UseVisualStyleBackColor = true;
            this.login_cancel.Click += new System.EventHandler(this.login_cancel_Click);
            // 
            // lbl_usrname
            // 
            this.lbl_usrname.AutoSize = true;
            this.lbl_usrname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usrname.Location = new System.Drawing.Point(96, 65);
            this.lbl_usrname.Name = "lbl_usrname";
            this.lbl_usrname.Size = new System.Drawing.Size(62, 12);
            this.lbl_usrname.TabIndex = 2;
            this.lbl_usrname.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(96, 99);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(59, 12);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(165, 61);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(193, 20);
            this.login_username.TabIndex = 0;
            // 
            // login_Password
            // 
            this.login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password.Location = new System.Drawing.Point(165, 95);
            this.login_Password.Name = "login_Password";
            this.login_Password.PasswordChar = '•';
            this.login_Password.Size = new System.Drawing.Size(193, 20);
            this.login_Password.TabIndex = 1;
            // 
            // loginForm
            // 
            this.AcceptButton = this.login_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 214);
            this.Controls.Add(this.login_Password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbl_usrname);
            this.Controls.Add(this.login_cancel);
            this.Controls.Add(this.login_submit);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_submit;
        private System.Windows.Forms.Button login_cancel;
        private System.Windows.Forms.Label lbl_usrname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_Password;
    }
}