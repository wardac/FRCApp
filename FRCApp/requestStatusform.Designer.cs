namespace FRCApp
{
    partial class requestStatusform
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
            this.components = new System.ComponentModel.Container();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.lblReferals = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.follow_up = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Responsibleparty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.approvedlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkApprovedReason = new System.Windows.Forms.CheckedListBox();
            this.ChkDeniedReason = new System.Windows.Forms.CheckedListBox();
            this.chkDenied = new System.Windows.Forms.CheckBox();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.grpcauseshardship = new System.Windows.Forms.GroupBox();
            this.txtother = new System.Windows.Forms.TextBox();
            this.chkother = new System.Windows.Forms.CheckBox();
            this.chkmajorLchange = new System.Windows.Forms.CheckBox();
            this.chkUnexpectedloss = new System.Windows.Forms.CheckBox();
            this.chklossBenefit = new System.Windows.Forms.CheckBox();
            this.chkLosseanedIncome = new System.Windows.Forms.CheckBox();
            this.chkrecentlyemp = new System.Windows.Forms.CheckBox();
            this.chkjobloss = new System.Windows.Forms.CheckBox();
            this.efa_financegroup = new System.Windows.Forms.GroupBox();
            this.txtMexpenses = new System.Windows.Forms.TextBox();
            this.txtMicome = new System.Windows.Forms.TextBox();
            this.txtQCincome = new System.Windows.Forms.TextBox();
            this.txt_QHincome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQInfo = new System.Windows.Forms.Label();
            this.lblCQinfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.efa_comment = new System.Windows.Forms.TextBox();
            this.efa_proofGroup = new System.Windows.Forms.GroupBox();
            this.householdDate = new System.Windows.Forms.DateTimePicker();
            this.efa_proofHousehold = new System.Windows.Forms.CheckBox();
            this.assistancedate = new System.Windows.Forms.DateTimePicker();
            this.hardshipdate = new System.Windows.Forms.DateTimePicker();
            this.incomedate = new System.Windows.Forms.DateTimePicker();
            this.addressdate = new System.Windows.Forms.DateTimePicker();
            this.efa_proofAssistance = new System.Windows.Forms.CheckBox();
            this.efa_proofharship = new System.Windows.Forms.CheckBox();
            this.efa_proofIncome = new System.Windows.Forms.CheckBox();
            this.efa_proofaddress = new System.Windows.Forms.CheckBox();
            this.efa_reqamount = new System.Windows.Forms.TextBox();
            this.lblamtrequest = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.requestdate = new System.Windows.Forms.Label();
            this.cmbEfaCategory = new System.Windows.Forms.ComboBox();
            this.lblefacategory = new System.Windows.Forms.Label();
            this.efa_ID = new System.Windows.Forms.TextBox();
            this.lblreqId = new System.Windows.Forms.Label();
            this.efa_clientName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.cancelEfa = new System.Windows.Forms.Button();
            this.update_efa = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataSet1 = new FRCApp.DataSet1();
            this.eFARequestTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFARequestTypesTableAdapter = new FRCApp.DataSet1TableAdapters.EFARequestTypesTableAdapter();
            this.requestPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.grpcauseshardship.SuspendLayout();
            this.efa_financegroup.SuspendLayout();
            this.efa_proofGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFARequestTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestPanel
            // 
            this.requestPanel.Controls.Add(this.statusPanel);
            this.requestPanel.Controls.Add(this.lblComment);
            this.requestPanel.Controls.Add(this.grpcauseshardship);
            this.requestPanel.Controls.Add(this.efa_financegroup);
            this.requestPanel.Controls.Add(this.textBox1);
            this.requestPanel.Controls.Add(this.efa_comment);
            this.requestPanel.Controls.Add(this.efa_proofGroup);
            this.requestPanel.Controls.Add(this.efa_reqamount);
            this.requestPanel.Controls.Add(this.lblamtrequest);
            this.requestPanel.Controls.Add(this.dateTimePicker1);
            this.requestPanel.Controls.Add(this.requestdate);
            this.requestPanel.Controls.Add(this.cmbEfaCategory);
            this.requestPanel.Controls.Add(this.lblefacategory);
            this.requestPanel.Controls.Add(this.efa_ID);
            this.requestPanel.Controls.Add(this.lblreqId);
            this.requestPanel.Controls.Add(this.efa_clientName);
            this.requestPanel.Controls.Add(this.lblname);
            this.requestPanel.Controls.Add(this.cancelEfa);
            this.requestPanel.Controls.Add(this.update_efa);
            this.requestPanel.Controls.Add(this.shapeContainer1);
            this.requestPanel.Location = new System.Drawing.Point(24, 12);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(867, 597);
            this.requestPanel.TabIndex = 1;
            // 
            // statusPanel
            // 
            this.statusPanel.AutoScroll = true;
            this.statusPanel.Controls.Add(this.lblReferals);
            this.statusPanel.Controls.Add(this.checkedListBox1);
            this.statusPanel.Controls.Add(this.listView1);
            this.statusPanel.Controls.Add(this.approvedlabel);
            this.statusPanel.Controls.Add(this.label2);
            this.statusPanel.Controls.Add(this.chkApprovedReason);
            this.statusPanel.Controls.Add(this.ChkDeniedReason);
            this.statusPanel.Controls.Add(this.chkDenied);
            this.statusPanel.Controls.Add(this.chkApproved);
            this.statusPanel.Location = new System.Drawing.Point(446, 261);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(408, 289);
            this.statusPanel.TabIndex = 21;
            // 
            // lblReferals
            // 
            this.lblReferals.AutoSize = true;
            this.lblReferals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferals.Location = new System.Drawing.Point(11, 283);
            this.lblReferals.Name = "lblReferals";
            this.lblReferals.Size = new System.Drawing.Size(163, 13);
            this.lblReferals.TabIndex = 8;
            this.lblReferals.Text = "Referals and other services";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
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
            this.checkedListBox1.Location = new System.Drawing.Point(7, 299);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(268, 109);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.follow_up,
            this.Responsibleparty,
            this.completionDate});
            this.listView1.Location = new System.Drawing.Point(7, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // follow_up
            // 
            this.follow_up.Text = "Follow up ";
            this.follow_up.Width = 131;
            // 
            // Responsibleparty
            // 
            this.Responsibleparty.Text = "Responsible Party";
            this.Responsibleparty.Width = 103;
            // 
            // completionDate
            // 
            this.completionDate.Text = "Completion date";
            this.completionDate.Width = 127;
            // 
            // approvedlabel
            // 
            this.approvedlabel.AutoSize = true;
            this.approvedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedlabel.Location = new System.Drawing.Point(189, 4);
            this.approvedlabel.Name = "approvedlabel";
            this.approvedlabel.Size = new System.Drawing.Size(94, 13);
            this.approvedlabel.TabIndex = 5;
            this.approvedlabel.Text = "Very long name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "approved by:";
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
            this.chkApprovedReason.Location = new System.Drawing.Point(7, 52);
            this.chkApprovedReason.Name = "chkApprovedReason";
            this.chkApprovedReason.ScrollAlwaysVisible = true;
            this.chkApprovedReason.Size = new System.Drawing.Size(194, 109);
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
            this.ChkDeniedReason.Location = new System.Drawing.Point(207, 52);
            this.ChkDeniedReason.Name = "ChkDeniedReason";
            this.ChkDeniedReason.ScrollAlwaysVisible = true;
            this.ChkDeniedReason.Size = new System.Drawing.Size(190, 109);
            this.ChkDeniedReason.TabIndex = 2;
            this.ChkDeniedReason.Visible = false;
            // 
            // chkDenied
            // 
            this.chkDenied.AutoSize = true;
            this.chkDenied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDenied.Location = new System.Drawing.Point(196, 31);
            this.chkDenied.Name = "chkDenied";
            this.chkDenied.Size = new System.Drawing.Size(73, 17);
            this.chkDenied.TabIndex = 1;
            this.chkDenied.Text = "DENIED";
            this.chkDenied.UseVisualStyleBackColor = true;
            this.chkDenied.CheckedChanged += new System.EventHandler(this.chkDenied_CheckedChanged);
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApproved.Location = new System.Drawing.Point(7, 31);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(93, 17);
            this.chkApproved.TabIndex = 0;
            this.chkApproved.Text = "APPROVED";
            this.chkApproved.UseVisualStyleBackColor = true;
            this.chkApproved.CheckedChanged += new System.EventHandler(this.chkApproved_CheckedChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(450, 153);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(128, 13);
            this.lblComment.TabIndex = 20;
            this.lblComment.Text = "hardship details/comment";
            // 
            // grpcauseshardship
            // 
            this.grpcauseshardship.Controls.Add(this.txtother);
            this.grpcauseshardship.Controls.Add(this.chkother);
            this.grpcauseshardship.Controls.Add(this.chkmajorLchange);
            this.grpcauseshardship.Controls.Add(this.chkUnexpectedloss);
            this.grpcauseshardship.Controls.Add(this.chklossBenefit);
            this.grpcauseshardship.Controls.Add(this.chkLosseanedIncome);
            this.grpcauseshardship.Controls.Add(this.chkrecentlyemp);
            this.grpcauseshardship.Controls.Add(this.chkjobloss);
            this.grpcauseshardship.Location = new System.Drawing.Point(446, 32);
            this.grpcauseshardship.Name = "grpcauseshardship";
            this.grpcauseshardship.Size = new System.Drawing.Size(397, 115);
            this.grpcauseshardship.TabIndex = 19;
            this.grpcauseshardship.TabStop = false;
            this.grpcauseshardship.Text = "Causes of hardship";
            // 
            // txtother
            // 
            this.txtother.Location = new System.Drawing.Point(7, 85);
            this.txtother.Name = "txtother";
            this.txtother.Size = new System.Drawing.Size(384, 20);
            this.txtother.TabIndex = 7;
            this.txtother.Visible = false;
            // 
            // chkother
            // 
            this.chkother.AutoSize = true;
            this.chkother.Location = new System.Drawing.Point(241, 12);
            this.chkother.Name = "chkother";
            this.chkother.Size = new System.Drawing.Size(50, 17);
            this.chkother.TabIndex = 6;
            this.chkother.Text = "other";
            this.chkother.UseVisualStyleBackColor = true;
            // 
            // chkmajorLchange
            // 
            this.chkmajorLchange.AutoSize = true;
            this.chkmajorLchange.Location = new System.Drawing.Point(139, 61);
            this.chkmajorLchange.Name = "chkmajorLchange";
            this.chkmajorLchange.Size = new System.Drawing.Size(106, 17);
            this.chkmajorLchange.TabIndex = 5;
            this.chkmajorLchange.Text = "major life change";
            this.chkmajorLchange.UseVisualStyleBackColor = true;
            // 
            // chkUnexpectedloss
            // 
            this.chkUnexpectedloss.AutoSize = true;
            this.chkUnexpectedloss.Location = new System.Drawing.Point(139, 38);
            this.chkUnexpectedloss.Name = "chkUnexpectedloss";
            this.chkUnexpectedloss.Size = new System.Drawing.Size(130, 17);
            this.chkUnexpectedloss.TabIndex = 4;
            this.chkUnexpectedloss.Text = "unexpected expenses";
            this.chkUnexpectedloss.UseVisualStyleBackColor = true;
            // 
            // chklossBenefit
            // 
            this.chklossBenefit.AutoSize = true;
            this.chklossBenefit.Location = new System.Drawing.Point(139, 15);
            this.chklossBenefit.Name = "chklossBenefit";
            this.chklossBenefit.Size = new System.Drawing.Size(91, 17);
            this.chklossBenefit.TabIndex = 3;
            this.chklossBenefit.Text = "loss of benefit";
            this.chklossBenefit.UseVisualStyleBackColor = true;
            // 
            // chkLosseanedIncome
            // 
            this.chkLosseanedIncome.AutoSize = true;
            this.chkLosseanedIncome.Location = new System.Drawing.Point(7, 62);
            this.chkLosseanedIncome.Name = "chkLosseanedIncome";
            this.chkLosseanedIncome.Size = new System.Drawing.Size(129, 17);
            this.chkLosseanedIncome.TabIndex = 2;
            this.chkLosseanedIncome.Text = "loss of earned income";
            this.chkLosseanedIncome.UseVisualStyleBackColor = true;
            // 
            // chkrecentlyemp
            // 
            this.chkrecentlyemp.AutoSize = true;
            this.chkrecentlyemp.Location = new System.Drawing.Point(7, 40);
            this.chkrecentlyemp.Name = "chkrecentlyemp";
            this.chkrecentlyemp.Size = new System.Drawing.Size(116, 17);
            this.chkrecentlyemp.TabIndex = 1;
            this.chkrecentlyemp.Text = "Recently employed";
            this.chkrecentlyemp.UseVisualStyleBackColor = true;
            // 
            // chkjobloss
            // 
            this.chkjobloss.AutoSize = true;
            this.chkjobloss.Location = new System.Drawing.Point(7, 20);
            this.chkjobloss.Name = "chkjobloss";
            this.chkjobloss.Size = new System.Drawing.Size(61, 17);
            this.chkjobloss.TabIndex = 0;
            this.chkjobloss.Text = "job loss";
            this.chkjobloss.UseVisualStyleBackColor = true;
            // 
            // efa_financegroup
            // 
            this.efa_financegroup.Controls.Add(this.txtMexpenses);
            this.efa_financegroup.Controls.Add(this.txtMicome);
            this.efa_financegroup.Controls.Add(this.txtQCincome);
            this.efa_financegroup.Controls.Add(this.txt_QHincome);
            this.efa_financegroup.Controls.Add(this.label1);
            this.efa_financegroup.Controls.Add(this.label3);
            this.efa_financegroup.Controls.Add(this.lblQInfo);
            this.efa_financegroup.Controls.Add(this.lblCQinfo);
            this.efa_financegroup.Location = new System.Drawing.Point(45, 383);
            this.efa_financegroup.Name = "efa_financegroup";
            this.efa_financegroup.Size = new System.Drawing.Size(386, 130);
            this.efa_financegroup.TabIndex = 18;
            this.efa_financegroup.TabStop = false;
            this.efa_financegroup.Text = "Financial Summary";
            // 
            // txtMexpenses
            // 
            this.txtMexpenses.Enabled = false;
            this.txtMexpenses.Location = new System.Drawing.Point(290, 95);
            this.txtMexpenses.Name = "txtMexpenses";
            this.txtMexpenses.Size = new System.Drawing.Size(90, 20);
            this.txtMexpenses.TabIndex = 7;
            // 
            // txtMicome
            // 
            this.txtMicome.Enabled = false;
            this.txtMicome.Location = new System.Drawing.Point(142, 94);
            this.txtMicome.Name = "txtMicome";
            this.txtMicome.Size = new System.Drawing.Size(100, 20);
            this.txtMicome.TabIndex = 6;
            // 
            // txtQCincome
            // 
            this.txtQCincome.Enabled = false;
            this.txtQCincome.Location = new System.Drawing.Point(142, 73);
            this.txtQCincome.Name = "txtQCincome";
            this.txtQCincome.Size = new System.Drawing.Size(100, 20);
            this.txtQCincome.TabIndex = 5;
            // 
            // txt_QHincome
            // 
            this.txt_QHincome.Enabled = false;
            this.txt_QHincome.Location = new System.Drawing.Point(142, 45);
            this.txt_QHincome.Name = "txt_QHincome";
            this.txt_QHincome.Size = new System.Drawing.Size(100, 20);
            this.txt_QHincome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monthly Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monthly expenses";
            // 
            // lblQInfo
            // 
            this.lblQInfo.AutoSize = true;
            this.lblQInfo.Location = new System.Drawing.Point(10, 73);
            this.lblQInfo.Name = "lblQInfo";
            this.lblQInfo.Size = new System.Drawing.Size(110, 13);
            this.lblQInfo.TabIndex = 1;
            this.lblQInfo.Text = "Client quaterly income";
            // 
            // lblCQinfo
            // 
            this.lblCQinfo.AutoSize = true;
            this.lblCQinfo.Location = new System.Drawing.Point(7, 45);
            this.lblCQinfo.Name = "lblCQinfo";
            this.lblCQinfo.Size = new System.Drawing.Size(135, 13);
            this.lblCQinfo.TabIndex = 0;
            this.lblCQinfo.Text = "Household quaterly income";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 47);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "if other explain";
            // 
            // efa_comment
            // 
            this.efa_comment.Location = new System.Drawing.Point(446, 174);
            this.efa_comment.Multiline = true;
            this.efa_comment.Name = "efa_comment";
            this.efa_comment.Size = new System.Drawing.Size(408, 71);
            this.efa_comment.TabIndex = 15;
            // 
            // efa_proofGroup
            // 
            this.efa_proofGroup.Controls.Add(this.householdDate);
            this.efa_proofGroup.Controls.Add(this.efa_proofHousehold);
            this.efa_proofGroup.Controls.Add(this.assistancedate);
            this.efa_proofGroup.Controls.Add(this.hardshipdate);
            this.efa_proofGroup.Controls.Add(this.incomedate);
            this.efa_proofGroup.Controls.Add(this.addressdate);
            this.efa_proofGroup.Controls.Add(this.efa_proofAssistance);
            this.efa_proofGroup.Controls.Add(this.efa_proofharship);
            this.efa_proofGroup.Controls.Add(this.efa_proofIncome);
            this.efa_proofGroup.Controls.Add(this.efa_proofaddress);
            this.efa_proofGroup.Location = new System.Drawing.Point(39, 206);
            this.efa_proofGroup.Name = "efa_proofGroup";
            this.efa_proofGroup.Size = new System.Drawing.Size(392, 157);
            this.efa_proofGroup.TabIndex = 13;
            this.efa_proofGroup.TabStop = false;
            this.efa_proofGroup.Text = "Required Items";
            // 
            // householdDate
            // 
            this.householdDate.Location = new System.Drawing.Point(150, 42);
            this.householdDate.Name = "householdDate";
            this.householdDate.Size = new System.Drawing.Size(200, 20);
            this.householdDate.TabIndex = 9;
            this.householdDate.Visible = false;
            // 
            // efa_proofHousehold
            // 
            this.efa_proofHousehold.AutoSize = true;
            this.efa_proofHousehold.Location = new System.Drawing.Point(6, 42);
            this.efa_proofHousehold.Name = "efa_proofHousehold";
            this.efa_proofHousehold.Size = new System.Drawing.Size(131, 17);
            this.efa_proofHousehold.TabIndex = 8;
            this.efa_proofHousehold.Text = "id household members";
            this.efa_proofHousehold.UseVisualStyleBackColor = true;
            this.efa_proofHousehold.CheckedChanged += new System.EventHandler(this.efa_proofHousehold_CheckedChanged);
            // 
            // assistancedate
            // 
            this.assistancedate.Location = new System.Drawing.Point(150, 121);
            this.assistancedate.Name = "assistancedate";
            this.assistancedate.Size = new System.Drawing.Size(200, 20);
            this.assistancedate.TabIndex = 7;
            this.assistancedate.Visible = false;
            // 
            // hardshipdate
            // 
            this.hardshipdate.Location = new System.Drawing.Point(150, 95);
            this.hardshipdate.Name = "hardshipdate";
            this.hardshipdate.Size = new System.Drawing.Size(200, 20);
            this.hardshipdate.TabIndex = 6;
            this.hardshipdate.Visible = false;
            // 
            // incomedate
            // 
            this.incomedate.Location = new System.Drawing.Point(150, 68);
            this.incomedate.Name = "incomedate";
            this.incomedate.Size = new System.Drawing.Size(200, 20);
            this.incomedate.TabIndex = 5;
            this.incomedate.Visible = false;
            // 
            // addressdate
            // 
            this.addressdate.Location = new System.Drawing.Point(150, 19);
            this.addressdate.Name = "addressdate";
            this.addressdate.Size = new System.Drawing.Size(200, 20);
            this.addressdate.TabIndex = 4;
            this.addressdate.Visible = false;
            // 
            // efa_proofAssistance
            // 
            this.efa_proofAssistance.AutoSize = true;
            this.efa_proofAssistance.Location = new System.Drawing.Point(6, 120);
            this.efa_proofAssistance.Name = "efa_proofAssistance";
            this.efa_proofAssistance.Size = new System.Drawing.Size(138, 17);
            this.efa_proofAssistance.TabIndex = 3;
            this.efa_proofAssistance.Text = "proof of assistance type";
            this.efa_proofAssistance.UseVisualStyleBackColor = true;
            this.efa_proofAssistance.CheckedChanged += new System.EventHandler(this.efa_proofAssistance_CheckedChanged);
            // 
            // efa_proofharship
            // 
            this.efa_proofharship.AutoSize = true;
            this.efa_proofharship.Location = new System.Drawing.Point(6, 89);
            this.efa_proofharship.Name = "efa_proofharship";
            this.efa_proofharship.Size = new System.Drawing.Size(105, 17);
            this.efa_proofharship.TabIndex = 2;
            this.efa_proofharship.Text = "proof of hardship";
            this.efa_proofharship.UseVisualStyleBackColor = true;
            this.efa_proofharship.CheckedChanged += new System.EventHandler(this.efa_proofharship_CheckedChanged);
            // 
            // efa_proofIncome
            // 
            this.efa_proofIncome.AutoSize = true;
            this.efa_proofIncome.Location = new System.Drawing.Point(6, 65);
            this.efa_proofIncome.Name = "efa_proofIncome";
            this.efa_proofIncome.Size = new System.Drawing.Size(99, 17);
            this.efa_proofIncome.TabIndex = 1;
            this.efa_proofIncome.Text = "proof of income";
            this.efa_proofIncome.UseVisualStyleBackColor = true;
            this.efa_proofIncome.CheckedChanged += new System.EventHandler(this.efa_proofIncome_CheckedChanged);
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
            this.efa_proofaddress.CheckedChanged += new System.EventHandler(this.efa_proofaddress_CheckedChanged);
            // 
            // efa_reqamount
            // 
            this.efa_reqamount.Enabled = false;
            this.efa_reqamount.Location = new System.Drawing.Point(161, 153);
            this.efa_reqamount.Name = "efa_reqamount";
            this.efa_reqamount.Size = new System.Drawing.Size(112, 20);
            this.efa_reqamount.TabIndex = 11;
            // 
            // lblamtrequest
            // 
            this.lblamtrequest.AutoSize = true;
            this.lblamtrequest.Location = new System.Drawing.Point(30, 153);
            this.lblamtrequest.Name = "lblamtrequest";
            this.lblamtrequest.Size = new System.Drawing.Size(93, 13);
            this.lblamtrequest.TabIndex = 10;
            this.lblamtrequest.Text = "Amount requested";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // requestdate
            // 
            this.requestdate.AutoSize = true;
            this.requestdate.Location = new System.Drawing.Point(30, 179);
            this.requestdate.Name = "requestdate";
            this.requestdate.Size = new System.Drawing.Size(66, 13);
            this.requestdate.TabIndex = 8;
            this.requestdate.Text = "request date";
            // 
            // cmbEfaCategory
            // 
            this.cmbEfaCategory.FormattingEnabled = true;
            this.cmbEfaCategory.Location = new System.Drawing.Point(161, 73);
            this.cmbEfaCategory.Name = "cmbEfaCategory";
            this.cmbEfaCategory.Size = new System.Drawing.Size(259, 21);
            this.cmbEfaCategory.TabIndex = 7;
            // 
            // lblefacategory
            // 
            this.lblefacategory.AutoSize = true;
            this.lblefacategory.Location = new System.Drawing.Point(30, 73);
            this.lblefacategory.Name = "lblefacategory";
            this.lblefacategory.Size = new System.Drawing.Size(125, 13);
            this.lblefacategory.TabIndex = 6;
            this.lblefacategory.Text = "EFA Assistance category";
            // 
            // efa_ID
            // 
            this.efa_ID.Enabled = false;
            this.efa_ID.Location = new System.Drawing.Point(161, 45);
            this.efa_ID.Name = "efa_ID";
            this.efa_ID.Size = new System.Drawing.Size(112, 20);
            this.efa_ID.TabIndex = 5;
            this.efa_ID.Text = "autogen ID";
            // 
            // lblreqId
            // 
            this.lblreqId.AutoSize = true;
            this.lblreqId.Location = new System.Drawing.Point(30, 48);
            this.lblreqId.Name = "lblreqId";
            this.lblreqId.Size = new System.Drawing.Size(61, 13);
            this.lblreqId.TabIndex = 4;
            this.lblreqId.Text = "Request ID";
            // 
            // efa_clientName
            // 
            this.efa_clientName.Enabled = false;
            this.efa_clientName.Location = new System.Drawing.Point(161, 19);
            this.efa_clientName.Name = "efa_clientName";
            this.efa_clientName.Size = new System.Drawing.Size(259, 20);
            this.efa_clientName.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(30, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Client Name";
            // 
            // cancelEfa
            // 
            this.cancelEfa.Location = new System.Drawing.Point(411, 556);
            this.cancelEfa.Name = "cancelEfa";
            this.cancelEfa.Size = new System.Drawing.Size(76, 29);
            this.cancelEfa.TabIndex = 1;
            this.cancelEfa.Text = "cancel";
            this.cancelEfa.UseVisualStyleBackColor = true;
            // 
            // update_efa
            // 
            this.update_efa.Location = new System.Drawing.Point(307, 556);
            this.update_efa.Name = "update_efa";
            this.update_efa.Size = new System.Drawing.Size(76, 29);
            this.update_efa.TabIndex = 0;
            this.update_efa.Text = "submit";
            this.update_efa.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(867, 597);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 436;
            this.lineShape1.X2 = 438;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 378;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eFARequestTypesBindingSource
            // 
            this.eFARequestTypesBindingSource.DataMember = "EFARequestTypes";
            this.eFARequestTypesBindingSource.DataSource = this.dataSet1;
            // 
            // eFARequestTypesTableAdapter
            // 
            this.eFARequestTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestStatusform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.requestPanel);
            this.Name = "requestStatusform";
            this.Text = "Request Status";
            this.Load += new System.EventHandler(this.requestStatusform_Load);
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.grpcauseshardship.ResumeLayout(false);
            this.grpcauseshardship.PerformLayout();
            this.efa_financegroup.ResumeLayout(false);
            this.efa_financegroup.PerformLayout();
            this.efa_proofGroup.ResumeLayout(false);
            this.efa_proofGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFARequestTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.GroupBox grpcauseshardship;
        private System.Windows.Forms.TextBox txtother;
        private System.Windows.Forms.CheckBox chkother;
        private System.Windows.Forms.CheckBox chkmajorLchange;
        private System.Windows.Forms.CheckBox chkUnexpectedloss;
        private System.Windows.Forms.CheckBox chklossBenefit;
        private System.Windows.Forms.CheckBox chkLosseanedIncome;
        private System.Windows.Forms.CheckBox chkrecentlyemp;
        private System.Windows.Forms.CheckBox chkjobloss;
        private System.Windows.Forms.GroupBox efa_financegroup;
        private System.Windows.Forms.TextBox txtMexpenses;
        private System.Windows.Forms.TextBox txtMicome;
        private System.Windows.Forms.TextBox txtQCincome;
        private System.Windows.Forms.TextBox txt_QHincome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQInfo;
        private System.Windows.Forms.Label lblCQinfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox efa_comment;
        private System.Windows.Forms.GroupBox efa_proofGroup;
        private System.Windows.Forms.DateTimePicker householdDate;
        private System.Windows.Forms.CheckBox efa_proofHousehold;
        private System.Windows.Forms.DateTimePicker assistancedate;
        private System.Windows.Forms.DateTimePicker hardshipdate;
        private System.Windows.Forms.DateTimePicker incomedate;
        private System.Windows.Forms.DateTimePicker addressdate;
        private System.Windows.Forms.CheckBox efa_proofAssistance;
        private System.Windows.Forms.CheckBox efa_proofharship;
        private System.Windows.Forms.CheckBox efa_proofIncome;
        private System.Windows.Forms.CheckBox efa_proofaddress;
        private System.Windows.Forms.TextBox efa_reqamount;
        private System.Windows.Forms.Label lblamtrequest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label requestdate;
        private System.Windows.Forms.ComboBox cmbEfaCategory;
        private System.Windows.Forms.Label lblefacategory;
        private System.Windows.Forms.TextBox efa_ID;
        private System.Windows.Forms.Label lblreqId;
        private System.Windows.Forms.TextBox efa_clientName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button cancelEfa;
        private System.Windows.Forms.Button update_efa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.CheckedListBox chkApprovedReason;
        private System.Windows.Forms.CheckedListBox ChkDeniedReason;
        private System.Windows.Forms.CheckBox chkDenied;
        private System.Windows.Forms.CheckBox chkApproved;
        private System.Windows.Forms.Label approvedlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader follow_up;
        private System.Windows.Forms.ColumnHeader Responsibleparty;
        private System.Windows.Forms.ColumnHeader completionDate;
        private System.Windows.Forms.Label lblReferals;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eFARequestTypesBindingSource;
        private DataSet1TableAdapters.EFARequestTypesTableAdapter eFARequestTypesTableAdapter;
    }
}