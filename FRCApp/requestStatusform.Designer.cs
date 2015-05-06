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
            this.label2 = new System.Windows.Forms.Label();
            this.lstFinances = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qincome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mincome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mexpenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datagridRequests = new System.Windows.Forms.DataGridView();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_completedDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_completedDate = new System.Windows.Forms.Label();
            this.btn_handleRequest = new System.Windows.Forms.Button();
            this.lst_reqTypes = new System.Windows.Forms.ListBox();
            this.checklist_requestType = new System.Windows.Forms.CheckedListBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.grpcauseshardship = new System.Windows.Forms.GroupBox();
            this.txt_hardshipDesc = new System.Windows.Forms.TextBox();
            this.cmb_hardship = new System.Windows.Forms.ComboBox();
            this.efa_financegroup = new System.Windows.Forms.GroupBox();
            this.txt_Mexpenses = new System.Windows.Forms.TextBox();
            this.txt_Mincome = new System.Windows.Forms.TextBox();
            this.txt_QHincome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCQinfo = new System.Windows.Forms.Label();
            this.txt_other = new System.Windows.Forms.TextBox();
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
            this.date_requestDate = new System.Windows.Forms.DateTimePicker();
            this.requestdate = new System.Windows.Forms.Label();
            this.lblefacategory = new System.Windows.Forms.Label();
            this.efa_clientName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.cancelEfa = new System.Windows.Forms.Button();
            this.update_efa = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataSet1 = new FRCApp.DataSet1();
            this.eFARequestTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFARequestTypesTableAdapter = new FRCApp.DataSet1TableAdapters.EFARequestTypesTableAdapter();
            this.requestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRequests)).BeginInit();
            this.grpcauseshardship.SuspendLayout();
            this.efa_financegroup.SuspendLayout();
            this.efa_proofGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFARequestTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestPanel
            // 
            this.requestPanel.Controls.Add(this.label2);
            this.requestPanel.Controls.Add(this.lstFinances);
            this.requestPanel.Controls.Add(this.datagridRequests);
            this.requestPanel.Controls.Add(this.date_completedDate);
            this.requestPanel.Controls.Add(this.lbl_completedDate);
            this.requestPanel.Controls.Add(this.btn_handleRequest);
            this.requestPanel.Controls.Add(this.lst_reqTypes);
            this.requestPanel.Controls.Add(this.checklist_requestType);
            this.requestPanel.Controls.Add(this.lblComment);
            this.requestPanel.Controls.Add(this.grpcauseshardship);
            this.requestPanel.Controls.Add(this.efa_financegroup);
            this.requestPanel.Controls.Add(this.txt_other);
            this.requestPanel.Controls.Add(this.efa_comment);
            this.requestPanel.Controls.Add(this.efa_proofGroup);
            this.requestPanel.Controls.Add(this.date_requestDate);
            this.requestPanel.Controls.Add(this.requestdate);
            this.requestPanel.Controls.Add(this.lblefacategory);
            this.requestPanel.Controls.Add(this.efa_clientName);
            this.requestPanel.Controls.Add(this.lblname);
            this.requestPanel.Controls.Add(this.cancelEfa);
            this.requestPanel.Controls.Add(this.update_efa);
            this.requestPanel.Controls.Add(this.shapeContainer1);
            this.requestPanel.Location = new System.Drawing.Point(24, 12);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(867, 632);
            this.requestPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Financial summary";
            // 
            // lstFinances
            // 
            this.lstFinances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.Qincome,
            this.Mincome,
            this.Mexpenses});
            this.lstFinances.FullRowSelect = true;
            this.lstFinances.Location = new System.Drawing.Point(30, 452);
            this.lstFinances.Name = "lstFinances";
            this.lstFinances.Size = new System.Drawing.Size(452, 138);
            this.lstFinances.TabIndex = 26;
            this.lstFinances.UseCompatibleStateImageBehavior = false;
            this.lstFinances.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "significant date";
            this.date.Width = 100;
            // 
            // Qincome
            // 
            this.Qincome.Text = "Quaterly Income";
            this.Qincome.Width = 107;
            // 
            // Mincome
            // 
            this.Mincome.Text = "Monthly income";
            this.Mincome.Width = 119;
            // 
            // Mexpenses
            // 
            this.Mexpenses.Text = "Monthly Expenses";
            this.Mexpenses.Width = 120;
            // 
            // datagridRequests
            // 
            this.datagridRequests.BackgroundColor = System.Drawing.Color.White;
            this.datagridRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request,
            this.amount});
            this.datagridRequests.Location = new System.Drawing.Point(161, 52);
            this.datagridRequests.Name = "datagridRequests";
            this.datagridRequests.RowHeadersWidth = 20;
            this.datagridRequests.Size = new System.Drawing.Size(270, 157);
            this.datagridRequests.TabIndex = 25;
            this.datagridRequests.Visible = false;
            // 
            // Request
            // 
            this.Request.HeaderText = "request";
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            this.Request.Width = 175;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 60;
            // 
            // date_completedDate
            // 
            this.date_completedDate.Enabled = false;
            this.date_completedDate.Location = new System.Drawing.Point(200, 251);
            this.date_completedDate.Name = "date_completedDate";
            this.date_completedDate.Size = new System.Drawing.Size(200, 20);
            this.date_completedDate.TabIndex = 9;
            this.date_completedDate.Visible = false;
            // 
            // lbl_completedDate
            // 
            this.lbl_completedDate.AutoSize = true;
            this.lbl_completedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completedDate.ForeColor = System.Drawing.Color.Teal;
            this.lbl_completedDate.Location = new System.Drawing.Point(30, 251);
            this.lbl_completedDate.Name = "lbl_completedDate";
            this.lbl_completedDate.Size = new System.Drawing.Size(96, 15);
            this.lbl_completedDate.TabIndex = 8;
            this.lbl_completedDate.Text = "Date Completed";
            this.lbl_completedDate.Visible = false;
            // 
            // btn_handleRequest
            // 
            this.btn_handleRequest.BackColor = System.Drawing.Color.Teal;
            this.btn_handleRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_handleRequest.ForeColor = System.Drawing.Color.White;
            this.btn_handleRequest.Location = new System.Drawing.Point(355, 596);
            this.btn_handleRequest.Name = "btn_handleRequest";
            this.btn_handleRequest.Size = new System.Drawing.Size(76, 29);
            this.btn_handleRequest.TabIndex = 24;
            this.btn_handleRequest.Text = "Handle";
            this.btn_handleRequest.UseVisualStyleBackColor = false;
            this.btn_handleRequest.Click += new System.EventHandler(this.btn_handleRequest_Click);
            // 
            // lst_reqTypes
            // 
            this.lst_reqTypes.FormattingEnabled = true;
            this.lst_reqTypes.Location = new System.Drawing.Point(161, 52);
            this.lst_reqTypes.Name = "lst_reqTypes";
            this.lst_reqTypes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_reqTypes.Size = new System.Drawing.Size(259, 95);
            this.lst_reqTypes.TabIndex = 23;
            // 
            // checklist_requestType
            // 
            this.checklist_requestType.CheckOnClick = true;
            this.checklist_requestType.FormattingEnabled = true;
            this.checklist_requestType.Location = new System.Drawing.Point(161, 52);
            this.checklist_requestType.Name = "checklist_requestType";
            this.checklist_requestType.Size = new System.Drawing.Size(259, 94);
            this.checklist_requestType.TabIndex = 22;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Teal;
            this.lblComment.Location = new System.Drawing.Point(450, 153);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(161, 15);
            this.lblComment.TabIndex = 20;
            this.lblComment.Text = "Hardship Details / Comment";
            // 
            // grpcauseshardship
            // 
            this.grpcauseshardship.Controls.Add(this.txt_hardshipDesc);
            this.grpcauseshardship.Controls.Add(this.cmb_hardship);
            this.grpcauseshardship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpcauseshardship.ForeColor = System.Drawing.Color.Teal;
            this.grpcauseshardship.Location = new System.Drawing.Point(446, 32);
            this.grpcauseshardship.Name = "grpcauseshardship";
            this.grpcauseshardship.Size = new System.Drawing.Size(397, 115);
            this.grpcauseshardship.TabIndex = 19;
            this.grpcauseshardship.TabStop = false;
            this.grpcauseshardship.Text = "Cause of Hardship";
            // 
            // txt_hardshipDesc
            // 
            this.txt_hardshipDesc.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_hardshipDesc.Enabled = false;
            this.txt_hardshipDesc.Location = new System.Drawing.Point(7, 48);
            this.txt_hardshipDesc.Multiline = true;
            this.txt_hardshipDesc.Name = "txt_hardshipDesc";
            this.txt_hardshipDesc.ReadOnly = true;
            this.txt_hardshipDesc.Size = new System.Drawing.Size(384, 61);
            this.txt_hardshipDesc.TabIndex = 1;
            // 
            // cmb_hardship
            // 
            this.cmb_hardship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hardship.FormattingEnabled = true;
            this.cmb_hardship.Location = new System.Drawing.Point(7, 20);
            this.cmb_hardship.Name = "cmb_hardship";
            this.cmb_hardship.Size = new System.Drawing.Size(384, 23);
            this.cmb_hardship.TabIndex = 0;
            // 
            // efa_financegroup
            // 
            this.efa_financegroup.Controls.Add(this.txt_Mexpenses);
            this.efa_financegroup.Controls.Add(this.txt_Mincome);
            this.efa_financegroup.Controls.Add(this.txt_QHincome);
            this.efa_financegroup.Controls.Add(this.label1);
            this.efa_financegroup.Controls.Add(this.label3);
            this.efa_financegroup.Controls.Add(this.lblCQinfo);
            this.efa_financegroup.Location = new System.Drawing.Point(457, 303);
            this.efa_financegroup.Name = "efa_financegroup";
            this.efa_financegroup.Size = new System.Drawing.Size(386, 131);
            this.efa_financegroup.TabIndex = 18;
            this.efa_financegroup.TabStop = false;
            this.efa_financegroup.Text = "Financial Summary";
            // 
            // txt_Mexpenses
            // 
            this.txt_Mexpenses.Enabled = false;
            this.txt_Mexpenses.Location = new System.Drawing.Point(302, 25);
            this.txt_Mexpenses.Name = "txt_Mexpenses";
            this.txt_Mexpenses.Size = new System.Drawing.Size(73, 20);
            this.txt_Mexpenses.TabIndex = 7;
            // 
            // txt_Mincome
            // 
            this.txt_Mincome.Enabled = false;
            this.txt_Mincome.Location = new System.Drawing.Point(115, 51);
            this.txt_Mincome.Name = "txt_Mincome";
            this.txt_Mincome.Size = new System.Drawing.Size(73, 20);
            this.txt_Mincome.TabIndex = 6;
            // 
            // txt_QHincome
            // 
            this.txt_QHincome.Enabled = false;
            this.txt_QHincome.Location = new System.Drawing.Point(115, 26);
            this.txt_QHincome.Name = "txt_QHincome";
            this.txt_QHincome.Size = new System.Drawing.Size(73, 20);
            this.txt_QHincome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monthly Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(199, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monthly expenses";
            // 
            // lblCQinfo
            // 
            this.lblCQinfo.AutoSize = true;
            this.lblCQinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCQinfo.ForeColor = System.Drawing.Color.Teal;
            this.lblCQinfo.Location = new System.Drawing.Point(9, 26);
            this.lblCQinfo.Name = "lblCQinfo";
            this.lblCQinfo.Size = new System.Drawing.Size(100, 15);
            this.lblCQinfo.TabIndex = 0;
            this.lblCQinfo.Text = "Quarterly Income";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(161, 152);
            this.txt_other.MaxLength = 30;
            this.txt_other.Multiline = true;
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(259, 20);
            this.txt_other.TabIndex = 17;
            this.txt_other.Text = "if other explain";
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
            this.efa_proofGroup.Location = new System.Drawing.Point(24, 276);
            this.efa_proofGroup.Name = "efa_proofGroup";
            this.efa_proofGroup.Size = new System.Drawing.Size(407, 158);
            this.efa_proofGroup.TabIndex = 13;
            this.efa_proofGroup.TabStop = false;
            this.efa_proofGroup.Text = "Required Items";
            // 
            // householdDate
            // 
            this.householdDate.Location = new System.Drawing.Point(179, 41);
            this.householdDate.Name = "householdDate";
            this.householdDate.Size = new System.Drawing.Size(200, 20);
            this.householdDate.TabIndex = 9;
            this.householdDate.Visible = false;
            // 
            // efa_proofHousehold
            // 
            this.efa_proofHousehold.AutoSize = true;
            this.efa_proofHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efa_proofHousehold.ForeColor = System.Drawing.Color.Teal;
            this.efa_proofHousehold.Location = new System.Drawing.Point(6, 44);
            this.efa_proofHousehold.Name = "efa_proofHousehold";
            this.efa_proofHousehold.Size = new System.Drawing.Size(157, 19);
            this.efa_proofHousehold.TabIndex = 8;
            this.efa_proofHousehold.Text = "ID Household Members";
            this.efa_proofHousehold.UseVisualStyleBackColor = true;
            this.efa_proofHousehold.CheckedChanged += new System.EventHandler(this.efa_proofHousehold_CheckedChanged);
            // 
            // assistancedate
            // 
            this.assistancedate.Location = new System.Drawing.Point(179, 116);
            this.assistancedate.Name = "assistancedate";
            this.assistancedate.Size = new System.Drawing.Size(200, 20);
            this.assistancedate.TabIndex = 7;
            this.assistancedate.Visible = false;
            // 
            // hardshipdate
            // 
            this.hardshipdate.Location = new System.Drawing.Point(179, 91);
            this.hardshipdate.Name = "hardshipdate";
            this.hardshipdate.Size = new System.Drawing.Size(200, 20);
            this.hardshipdate.TabIndex = 6;
            this.hardshipdate.Visible = false;
            // 
            // incomedate
            // 
            this.incomedate.Location = new System.Drawing.Point(179, 66);
            this.incomedate.Name = "incomedate";
            this.incomedate.Size = new System.Drawing.Size(200, 20);
            this.incomedate.TabIndex = 5;
            this.incomedate.Visible = false;
            // 
            // addressdate
            // 
            this.addressdate.Location = new System.Drawing.Point(179, 16);
            this.addressdate.Name = "addressdate";
            this.addressdate.Size = new System.Drawing.Size(200, 20);
            this.addressdate.TabIndex = 4;
            this.addressdate.Visible = false;
            // 
            // efa_proofAssistance
            // 
            this.efa_proofAssistance.AutoSize = true;
            this.efa_proofAssistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efa_proofAssistance.ForeColor = System.Drawing.Color.Teal;
            this.efa_proofAssistance.Location = new System.Drawing.Point(6, 119);
            this.efa_proofAssistance.Name = "efa_proofAssistance";
            this.efa_proofAssistance.Size = new System.Drawing.Size(150, 19);
            this.efa_proofAssistance.TabIndex = 3;
            this.efa_proofAssistance.Text = "Proof of Hardship Type";
            this.efa_proofAssistance.UseVisualStyleBackColor = true;
            this.efa_proofAssistance.CheckedChanged += new System.EventHandler(this.efa_proofAssistance_CheckedChanged);
            // 
            // efa_proofharship
            // 
            this.efa_proofharship.AutoSize = true;
            this.efa_proofharship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efa_proofharship.ForeColor = System.Drawing.Color.Teal;
            this.efa_proofharship.Location = new System.Drawing.Point(6, 94);
            this.efa_proofharship.Name = "efa_proofharship";
            this.efa_proofharship.Size = new System.Drawing.Size(121, 19);
            this.efa_proofharship.TabIndex = 2;
            this.efa_proofharship.Text = "Proof of Hardship";
            this.efa_proofharship.UseVisualStyleBackColor = true;
            this.efa_proofharship.CheckedChanged += new System.EventHandler(this.efa_proofharship_CheckedChanged);
            // 
            // efa_proofIncome
            // 
            this.efa_proofIncome.AutoSize = true;
            this.efa_proofIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efa_proofIncome.ForeColor = System.Drawing.Color.Teal;
            this.efa_proofIncome.Location = new System.Drawing.Point(6, 69);
            this.efa_proofIncome.Name = "efa_proofIncome";
            this.efa_proofIncome.Size = new System.Drawing.Size(112, 19);
            this.efa_proofIncome.TabIndex = 1;
            this.efa_proofIncome.Text = "Proof of Income";
            this.efa_proofIncome.UseVisualStyleBackColor = true;
            this.efa_proofIncome.CheckedChanged += new System.EventHandler(this.efa_proofIncome_CheckedChanged);
            // 
            // efa_proofaddress
            // 
            this.efa_proofaddress.AutoSize = true;
            this.efa_proofaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efa_proofaddress.ForeColor = System.Drawing.Color.Teal;
            this.efa_proofaddress.Location = new System.Drawing.Point(6, 19);
            this.efa_proofaddress.Name = "efa_proofaddress";
            this.efa_proofaddress.Size = new System.Drawing.Size(115, 19);
            this.efa_proofaddress.TabIndex = 0;
            this.efa_proofaddress.Text = "Proof of Address";
            this.efa_proofaddress.UseVisualStyleBackColor = true;
            this.efa_proofaddress.CheckedChanged += new System.EventHandler(this.efa_proofaddress_CheckedChanged);
            // 
            // date_requestDate
            // 
            this.date_requestDate.Location = new System.Drawing.Point(200, 227);
            this.date_requestDate.Name = "date_requestDate";
            this.date_requestDate.Size = new System.Drawing.Size(200, 20);
            this.date_requestDate.TabIndex = 9;
            // 
            // requestdate
            // 
            this.requestdate.AutoSize = true;
            this.requestdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestdate.ForeColor = System.Drawing.Color.Teal;
            this.requestdate.Location = new System.Drawing.Point(30, 227);
            this.requestdate.Name = "requestdate";
            this.requestdate.Size = new System.Drawing.Size(96, 15);
            this.requestdate.TabIndex = 8;
            this.requestdate.Text = "Date Requested";
            // 
            // lblefacategory
            // 
            this.lblefacategory.AutoSize = true;
            this.lblefacategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblefacategory.ForeColor = System.Drawing.Color.Teal;
            this.lblefacategory.Location = new System.Drawing.Point(14, 52);
            this.lblefacategory.Name = "lblefacategory";
            this.lblefacategory.Size = new System.Drawing.Size(141, 15);
            this.lblefacategory.TabIndex = 6;
            this.lblefacategory.Text = "EFA Assistance Category";
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
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Teal;
            this.lblname.Location = new System.Drawing.Point(30, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(75, 15);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Client Name";
            // 
            // cancelEfa
            // 
            this.cancelEfa.BackColor = System.Drawing.Color.Teal;
            this.cancelEfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEfa.ForeColor = System.Drawing.Color.White;
            this.cancelEfa.Location = new System.Drawing.Point(455, 596);
            this.cancelEfa.Name = "cancelEfa";
            this.cancelEfa.Size = new System.Drawing.Size(76, 29);
            this.cancelEfa.TabIndex = 1;
            this.cancelEfa.Text = "Cancel";
            this.cancelEfa.UseVisualStyleBackColor = false;
            this.cancelEfa.Click += new System.EventHandler(this.cancelEfa_Click);
            // 
            // update_efa
            // 
            this.update_efa.BackColor = System.Drawing.Color.Teal;
            this.update_efa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_efa.ForeColor = System.Drawing.Color.White;
            this.update_efa.Location = new System.Drawing.Point(255, 596);
            this.update_efa.Name = "update_efa";
            this.update_efa.Size = new System.Drawing.Size(76, 29);
            this.update_efa.TabIndex = 0;
            this.update_efa.Text = "Submit";
            this.update_efa.UseVisualStyleBackColor = false;
            this.update_efa.Click += new System.EventHandler(this.update_efa_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(867, 632);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 436;
            this.lineShape1.X2 = 436;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 378;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(903, 649);
            this.Controls.Add(this.requestPanel);
            this.Name = "requestStatusform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Status";
            this.Load += new System.EventHandler(this.requestStatusform_Load);
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRequests)).EndInit();
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
        private System.Windows.Forms.GroupBox efa_financegroup;
        private System.Windows.Forms.TextBox txt_Mexpenses;
        private System.Windows.Forms.TextBox txt_Mincome;
        private System.Windows.Forms.TextBox txt_QHincome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCQinfo;
        private System.Windows.Forms.TextBox txt_other;
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
        private System.Windows.Forms.DateTimePicker date_requestDate;
        private System.Windows.Forms.Label requestdate;
        private System.Windows.Forms.Label lblefacategory;
        private System.Windows.Forms.TextBox efa_clientName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button cancelEfa;
        private System.Windows.Forms.Button update_efa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eFARequestTypesBindingSource;
        private DataSet1TableAdapters.EFARequestTypesTableAdapter eFARequestTypesTableAdapter;
        private System.Windows.Forms.CheckedListBox checklist_requestType;
        private System.Windows.Forms.ListBox lst_reqTypes;
        private System.Windows.Forms.TextBox txt_hardshipDesc;
        private System.Windows.Forms.ComboBox cmb_hardship;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_handleRequest;
        private System.Windows.Forms.DateTimePicker date_completedDate;
        private System.Windows.Forms.Label lbl_completedDate;
        private System.Windows.Forms.DataGridView datagridRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstFinances;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader Qincome;
        private System.Windows.Forms.ColumnHeader Mincome;
        private System.Windows.Forms.ColumnHeader Mexpenses;
    }
}