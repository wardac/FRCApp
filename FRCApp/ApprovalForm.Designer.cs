namespace FRCApp
{
    partial class ApprovalForm
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
            this.chklst_services = new System.Windows.Forms.CheckedListBox();
            this.chklst_approved = new System.Windows.Forms.CheckedListBox();
            this.lblReferals = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.chkApprovedReason = new System.Windows.Forms.CheckedListBox();
            this.ChkDeniedReason = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // chklst_services
            // 
            this.chklst_services.FormattingEnabled = true;
            this.chklst_services.Location = new System.Drawing.Point(12, 43);
            this.chklst_services.Name = "chklst_services";
            this.chklst_services.Size = new System.Drawing.Size(396, 304);
            this.chklst_services.TabIndex = 0;
            // 
            // chklst_approved
            // 
            this.chklst_approved.FormattingEnabled = true;
            this.chklst_approved.Location = new System.Drawing.Point(496, 43);
            this.chklst_approved.Name = "chklst_approved";
            this.chklst_approved.Size = new System.Drawing.Size(396, 304);
            this.chklst_approved.TabIndex = 1;
            // 
            // lblReferals
            // 
            this.lblReferals.AutoSize = true;
            this.lblReferals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferals.Location = new System.Drawing.Point(9, 500);
            this.lblReferals.Name = "lblReferals";
            this.lblReferals.Size = new System.Drawing.Size(222, 13);
            this.lblReferals.TabIndex = 8;
            this.lblReferals.Text = "REFERRALS AND OTHER SERVICES";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Benefit Bank: food stamp",
            "Oxford works",
            "Habitat for humanity",
            "OCCP",
            "Oxford free Clinic",
            "FONIN",
            "Heap/pipp",
            "Oxford Free Clinic",
            "Thrift Store voucher",
            "GED",
            "Lions Club",
            "PUSH",
            "Getting Ahead",
            "OAAC",
            "Senior Commodities",
            "Other"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 516);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.ScrollAlwaysVisible = true;
            this.checkedListBox2.Size = new System.Drawing.Size(396, 109);
            this.checkedListBox2.TabIndex = 7;
            this.checkedListBox2.Visible = false;
            // 
            // chkApprovedReason
            // 
            this.chkApprovedReason.FormattingEnabled = true;
            this.chkApprovedReason.Items.AddRange(new object[] {
            "HH Member recently unemployed",
            "Household temporary loss income",
            "HH member recently employed",
            "HH member participating in programming",
            "HH has major life event",
            "HH has emergency medical need",
            "HH is homeless",
            "Assistance promotes self-sufficency",
            "Household unexpected expenses",
            "other"});
            this.chkApprovedReason.Location = new System.Drawing.Point(12, 372);
            this.chkApprovedReason.Name = "chkApprovedReason";
            this.chkApprovedReason.ScrollAlwaysVisible = true;
            this.chkApprovedReason.Size = new System.Drawing.Size(396, 109);
            this.chkApprovedReason.TabIndex = 3;
            this.chkApprovedReason.Visible = false;
            // 
            // ChkDeniedReason
            // 
            this.ChkDeniedReason.FormattingEnabled = true;
            this.ChkDeniedReason.Items.AddRange(new object[] {
            "HH income > 125% of FPG",
            "HH has  not experienced qualifying hardship",
            "HH expenses unsustainable",
            "Poor Payment History",
            "HH exceeded financial assistance limit",
            "HH withdrew request",
            "HH did not follow up",
            "HH not compliance with action/program",
            "HH request on NON approved Rx",
            "other"});
            this.ChkDeniedReason.Location = new System.Drawing.Point(496, 372);
            this.ChkDeniedReason.Name = "ChkDeniedReason";
            this.ChkDeniedReason.ScrollAlwaysVisible = true;
            this.ChkDeniedReason.Size = new System.Drawing.Size(395, 109);
            this.ChkDeniedReason.TabIndex = 2;
            this.ChkDeniedReason.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "REQUESTED SERVICES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "APPROVED SERVICES";
            // 
            // btn_approve
            // 
            this.btn_approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approve.Location = new System.Drawing.Point(414, 166);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(76, 23);
            this.btn_approve.TabIndex = 26;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "DENIAL REASON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "APPROVAL REASON";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(735, 599);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(816, 599);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 29;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(904, 635);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 890;
            this.lineShape1.Y1 = 491;
            this.lineShape1.Y2 = 491;
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 635);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblReferals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkDeniedReason);
            this.Controls.Add(this.chkApprovedReason);
            this.Controls.Add(this.chklst_approved);
            this.Controls.Add(this.chklst_services);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ApprovalForm";
            this.Text = "Request Approval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklst_services;
        private System.Windows.Forms.CheckedListBox chklst_approved;
        private System.Windows.Forms.Label lblReferals;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox chkApprovedReason;
        private System.Windows.Forms.CheckedListBox ChkDeniedReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}