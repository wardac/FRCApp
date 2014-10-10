namespace FRCApp
{
    partial class efaRequestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitEfa = new System.Windows.Forms.Button();
            this.cancelEfa = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.efa_clientName = new System.Windows.Forms.TextBox();
            this.efa_ID = new System.Windows.Forms.TextBox();
            this.lblreqId = new System.Windows.Forms.Label();
            this.lblefacategory = new System.Windows.Forms.Label();
            this.cmbEfaCategory = new System.Windows.Forms.ComboBox();
            this.requestdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblamtrequest = new System.Windows.Forms.Label();
            this.efa_reqamount = new System.Windows.Forms.TextBox();
            this.efa_proofGroup = new System.Windows.Forms.GroupBox();
            this.efa_proofaddress = new System.Windows.Forms.CheckBox();
            this.efa_proofIncome = new System.Windows.Forms.CheckBox();
            this.efa_proofharship = new System.Windows.Forms.CheckBox();
            this.efa_proofAssistance = new System.Windows.Forms.CheckBox();
            this.addressdate = new System.Windows.Forms.DateTimePicker();
            this.incomedate = new System.Windows.Forms.DateTimePicker();
            this.hardshipdate = new System.Windows.Forms.DateTimePicker();
            this.assistancedate = new System.Windows.Forms.DateTimePicker();
            this.lblefaComment = new System.Windows.Forms.Label();
            this.efa_comment = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.efa_proofGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.efa_comment);
            this.panel1.Controls.Add(this.lblefaComment);
            this.panel1.Controls.Add(this.efa_proofGroup);
            this.panel1.Controls.Add(this.efa_reqamount);
            this.panel1.Controls.Add(this.lblamtrequest);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.requestdate);
            this.panel1.Controls.Add(this.cmbEfaCategory);
            this.panel1.Controls.Add(this.lblefacategory);
            this.panel1.Controls.Add(this.efa_ID);
            this.panel1.Controls.Add(this.lblreqId);
            this.panel1.Controls.Add(this.efa_clientName);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.cancelEfa);
            this.panel1.Controls.Add(this.submitEfa);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(26, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 543);
            this.panel1.TabIndex = 0;
            // 
            // submitEfa
            // 
            this.submitEfa.Location = new System.Drawing.Point(166, 493);
            this.submitEfa.Name = "submitEfa";
            this.submitEfa.Size = new System.Drawing.Size(76, 23);
            this.submitEfa.TabIndex = 0;
            this.submitEfa.Text = "submit";
            this.submitEfa.UseVisualStyleBackColor = true;
            // 
            // cancelEfa
            // 
            this.cancelEfa.Location = new System.Drawing.Point(270, 493);
            this.cancelEfa.Name = "cancelEfa";
            this.cancelEfa.Size = new System.Drawing.Size(76, 23);
            this.cancelEfa.TabIndex = 1;
            this.cancelEfa.Text = "cancel";
            this.cancelEfa.UseVisualStyleBackColor = true;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(30, 66);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Client Name";
            // 
            // efa_clientName
            // 
            this.efa_clientName.Enabled = false;
            this.efa_clientName.Location = new System.Drawing.Point(161, 66);
            this.efa_clientName.Name = "efa_clientName";
            this.efa_clientName.Size = new System.Drawing.Size(259, 20);
            this.efa_clientName.TabIndex = 3;
            // 
            // efa_ID
            // 
            this.efa_ID.Enabled = false;
            this.efa_ID.Location = new System.Drawing.Point(161, 99);
            this.efa_ID.Name = "efa_ID";
            this.efa_ID.Size = new System.Drawing.Size(112, 20);
            this.efa_ID.TabIndex = 5;
            this.efa_ID.Text = "autogen ID";
            // 
            // lblreqId
            // 
            this.lblreqId.AutoSize = true;
            this.lblreqId.Location = new System.Drawing.Point(30, 102);
            this.lblreqId.Name = "lblreqId";
            this.lblreqId.Size = new System.Drawing.Size(61, 13);
            this.lblreqId.TabIndex = 4;
            this.lblreqId.Text = "Request ID";
            // 
            // lblefacategory
            // 
            this.lblefacategory.AutoSize = true;
            this.lblefacategory.Location = new System.Drawing.Point(30, 136);
            this.lblefacategory.Name = "lblefacategory";
            this.lblefacategory.Size = new System.Drawing.Size(125, 13);
            this.lblefacategory.TabIndex = 6;
            this.lblefacategory.Text = "EFA Assistance category";
            // 
            // cmbEfaCategory
            // 
            this.cmbEfaCategory.FormattingEnabled = true;
            this.cmbEfaCategory.Location = new System.Drawing.Point(161, 136);
            this.cmbEfaCategory.Name = "cmbEfaCategory";
            this.cmbEfaCategory.Size = new System.Drawing.Size(259, 21);
            this.cmbEfaCategory.TabIndex = 7;
            // 
            // requestdate
            // 
            this.requestdate.AutoSize = true;
            this.requestdate.Location = new System.Drawing.Point(30, 172);
            this.requestdate.Name = "requestdate";
            this.requestdate.Size = new System.Drawing.Size(66, 13);
            this.requestdate.TabIndex = 8;
            this.requestdate.Text = "request date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblamtrequest
            // 
            this.lblamtrequest.AutoSize = true;
            this.lblamtrequest.Location = new System.Drawing.Point(30, 206);
            this.lblamtrequest.Name = "lblamtrequest";
            this.lblamtrequest.Size = new System.Drawing.Size(93, 13);
            this.lblamtrequest.TabIndex = 10;
            this.lblamtrequest.Text = "Amount requested";
            // 
            // efa_reqamount
            // 
            this.efa_reqamount.Enabled = false;
            this.efa_reqamount.Location = new System.Drawing.Point(161, 206);
            this.efa_reqamount.Name = "efa_reqamount";
            this.efa_reqamount.Size = new System.Drawing.Size(112, 20);
            this.efa_reqamount.TabIndex = 11;
            // 
            // efa_proofGroup
            // 
            this.efa_proofGroup.Controls.Add(this.assistancedate);
            this.efa_proofGroup.Controls.Add(this.hardshipdate);
            this.efa_proofGroup.Controls.Add(this.incomedate);
            this.efa_proofGroup.Controls.Add(this.addressdate);
            this.efa_proofGroup.Controls.Add(this.efa_proofAssistance);
            this.efa_proofGroup.Controls.Add(this.efa_proofharship);
            this.efa_proofGroup.Controls.Add(this.efa_proofIncome);
            this.efa_proofGroup.Controls.Add(this.efa_proofaddress);
            this.efa_proofGroup.Location = new System.Drawing.Point(39, 247);
            this.efa_proofGroup.Name = "efa_proofGroup";
            this.efa_proofGroup.Size = new System.Drawing.Size(356, 126);
            this.efa_proofGroup.TabIndex = 13;
            this.efa_proofGroup.TabStop = false;
            this.efa_proofGroup.Text = "Required Items";
            // 
            // efa_proofaddress
            // 
            this.efa_proofaddress.AutoSize = true;
            this.efa_proofaddress.Location = new System.Drawing.Point(6, 19);
            this.efa_proofaddress.Name = "efa_proofaddress";
            this.efa_proofaddress.Size = new System.Drawing.Size(102, 17);
            this.efa_proofaddress.TabIndex = 0;
            this.efa_proofaddress.Text = "proof of address";
            this.efa_proofaddress.UseVisualStyleBackColor = true;
            this.efa_proofaddress.CheckedChanged += new System.EventHandler(this.efa_lblproofaddress_CheckedChanged);
            // 
            // efa_proofIncome
            // 
            this.efa_proofIncome.AutoSize = true;
            this.efa_proofIncome.Location = new System.Drawing.Point(6, 42);
            this.efa_proofIncome.Name = "efa_proofIncome";
            this.efa_proofIncome.Size = new System.Drawing.Size(99, 17);
            this.efa_proofIncome.TabIndex = 1;
            this.efa_proofIncome.Text = "proof of income";
            this.efa_proofIncome.UseVisualStyleBackColor = true;
            this.efa_proofIncome.CheckedChanged += new System.EventHandler(this.efa_proofIncome_CheckedChanged);
            // 
            // efa_proofharship
            // 
            this.efa_proofharship.AutoSize = true;
            this.efa_proofharship.Location = new System.Drawing.Point(6, 65);
            this.efa_proofharship.Name = "efa_proofharship";
            this.efa_proofharship.Size = new System.Drawing.Size(105, 17);
            this.efa_proofharship.TabIndex = 2;
            this.efa_proofharship.Text = "proof of hardship";
            this.efa_proofharship.UseVisualStyleBackColor = true;
            this.efa_proofharship.CheckedChanged += new System.EventHandler(this.efa_proofharship_CheckedChanged);
            // 
            // efa_proofAssistance
            // 
            this.efa_proofAssistance.AutoSize = true;
            this.efa_proofAssistance.Location = new System.Drawing.Point(6, 96);
            this.efa_proofAssistance.Name = "efa_proofAssistance";
            this.efa_proofAssistance.Size = new System.Drawing.Size(138, 17);
            this.efa_proofAssistance.TabIndex = 3;
            this.efa_proofAssistance.Text = "proof of assistance type";
            this.efa_proofAssistance.UseVisualStyleBackColor = true;
            this.efa_proofAssistance.CheckedChanged += new System.EventHandler(this.efa_proofAssistance_CheckedChanged);
            // 
            // addressdate
            // 
            this.addressdate.Location = new System.Drawing.Point(150, 19);
            this.addressdate.Name = "addressdate";
            this.addressdate.Size = new System.Drawing.Size(200, 20);
            this.addressdate.TabIndex = 4;
            this.addressdate.Visible = false;
            // 
            // incomedate
            // 
            this.incomedate.Location = new System.Drawing.Point(150, 45);
            this.incomedate.Name = "incomedate";
            this.incomedate.Size = new System.Drawing.Size(200, 20);
            this.incomedate.TabIndex = 5;
            this.incomedate.Visible = false;
            // 
            // hardshipdate
            // 
            this.hardshipdate.Location = new System.Drawing.Point(150, 71);
            this.hardshipdate.Name = "hardshipdate";
            this.hardshipdate.Size = new System.Drawing.Size(200, 20);
            this.hardshipdate.TabIndex = 6;
            this.hardshipdate.Visible = false;
            // 
            // assistancedate
            // 
            this.assistancedate.Location = new System.Drawing.Point(150, 97);
            this.assistancedate.Name = "assistancedate";
            this.assistancedate.Size = new System.Drawing.Size(200, 20);
            this.assistancedate.TabIndex = 7;
            this.assistancedate.Visible = false;
            // 
            // lblefaComment
            // 
            this.lblefaComment.AutoSize = true;
            this.lblefaComment.Location = new System.Drawing.Point(36, 382);
            this.lblefaComment.Name = "lblefaComment";
            this.lblefaComment.Size = new System.Drawing.Size(51, 13);
            this.lblefaComment.TabIndex = 14;
            this.lblefaComment.Text = "Comment";
            // 
            // efa_comment
            // 
            this.efa_comment.Location = new System.Drawing.Point(100, 379);
            this.efa_comment.Multiline = true;
            this.efa_comment.Name = "efa_comment";
            this.efa_comment.Size = new System.Drawing.Size(333, 108);
            this.efa_comment.TabIndex = 15;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(786, 543);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 446;
            this.lineShape1.X2 = 448;
            this.lineShape1.Y1 = 94;
            this.lineShape1.Y2 = 372;
            // 
            // efaRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 591);
            this.Controls.Add(this.panel1);
            this.Name = "efaRequestForm";
            this.Text = " EFA Request Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.efa_proofGroup.ResumeLayout(false);
            this.efa_proofGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox efa_ID;
        private System.Windows.Forms.Label lblreqId;
        private System.Windows.Forms.TextBox efa_clientName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button cancelEfa;
        private System.Windows.Forms.Button submitEfa;
        private System.Windows.Forms.Label lblamtrequest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label requestdate;
        private System.Windows.Forms.ComboBox cmbEfaCategory;
        private System.Windows.Forms.Label lblefacategory;
        private System.Windows.Forms.TextBox efa_comment;
        private System.Windows.Forms.Label lblefaComment;
        private System.Windows.Forms.GroupBox efa_proofGroup;
        private System.Windows.Forms.DateTimePicker assistancedate;
        private System.Windows.Forms.DateTimePicker hardshipdate;
        private System.Windows.Forms.DateTimePicker incomedate;
        private System.Windows.Forms.DateTimePicker addressdate;
        private System.Windows.Forms.CheckBox efa_proofAssistance;
        private System.Windows.Forms.CheckBox efa_proofharship;
        private System.Windows.Forms.CheckBox efa_proofIncome;
        private System.Windows.Forms.CheckBox efa_proofaddress;
        private System.Windows.Forms.TextBox efa_reqamount;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}