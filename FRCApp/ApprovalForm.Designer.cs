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
            this.components = new System.ComponentModel.Container();
            this.lblReferals = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rightArrows = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_leftArrows = new System.Windows.Forms.Button();
            this.cmb_denialReason = new System.Windows.Forms.ComboBox();
            this.cmb_approvalReason = new System.Windows.Forms.ComboBox();
            this.lst_requestedServices = new System.Windows.Forms.ListBox();
            this.incomeSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FRCApp.DataSet1();
            this.gridApprovedservices = new System.Windows.Forms.DataGridView();
            this.subreqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeSourcesTableAdapter = new FRCApp.DataSet1TableAdapters.IncomeSourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedservices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferals
            // 
            this.lblReferals.AutoSize = true;
            this.lblReferals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferals.ForeColor = System.Drawing.Color.Teal;
            this.lblReferals.Location = new System.Drawing.Point(9, 408);
            this.lblReferals.Name = "lblReferals";
            this.lblReferals.Size = new System.Drawing.Size(222, 13);
            this.lblReferals.TabIndex = 8;
            this.lblReferals.Text = "REFERRALS AND OTHER SERVICES";
            this.lblReferals.Visible = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.checkedListBox2.Location = new System.Drawing.Point(12, 424);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.ScrollAlwaysVisible = true;
            this.checkedListBox2.Size = new System.Drawing.Size(396, 199);
            this.checkedListBox2.TabIndex = 7;
            this.checkedListBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
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
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(493, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "APPROVED SERVICES";
            // 
            // btn_rightArrows
            // 
            this.btn_rightArrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rightArrows.Location = new System.Drawing.Point(414, 166);
            this.btn_rightArrows.Name = "btn_rightArrows";
            this.btn_rightArrows.Size = new System.Drawing.Size(76, 23);
            this.btn_rightArrows.TabIndex = 26;
            this.btn_rightArrows.Text = ">>";
            this.btn_rightArrows.UseVisualStyleBackColor = true;
            this.btn_rightArrows.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
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
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(493, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "APPROVAL REASON";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.Teal;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(735, 600);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.BackColor = System.Drawing.Color.Teal;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(816, 600);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 29;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_leftArrows
            // 
            this.btn_leftArrows.Location = new System.Drawing.Point(415, 196);
            this.btn_leftArrows.Name = "btn_leftArrows";
            this.btn_leftArrows.Size = new System.Drawing.Size(75, 23);
            this.btn_leftArrows.TabIndex = 33;
            this.btn_leftArrows.Text = "<<";
            this.btn_leftArrows.UseVisualStyleBackColor = true;
            this.btn_leftArrows.Click += new System.EventHandler(this.btn_leftArrows_Click);
            // 
            // cmb_denialReason
            // 
            this.cmb_denialReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_denialReason.FormattingEnabled = true;
            this.cmb_denialReason.Location = new System.Drawing.Point(13, 371);
            this.cmb_denialReason.Name = "cmb_denialReason";
            this.cmb_denialReason.Size = new System.Drawing.Size(395, 21);
            this.cmb_denialReason.TabIndex = 34;
            // 
            // cmb_approvalReason
            // 
            this.cmb_approvalReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_approvalReason.FormattingEnabled = true;
            this.cmb_approvalReason.Location = new System.Drawing.Point(496, 371);
            this.cmb_approvalReason.Name = "cmb_approvalReason";
            this.cmb_approvalReason.Size = new System.Drawing.Size(395, 21);
            this.cmb_approvalReason.TabIndex = 34;
            // 
            // lst_requestedServices
            // 
            this.lst_requestedServices.FormattingEnabled = true;
            this.lst_requestedServices.Location = new System.Drawing.Point(12, 43);
            this.lst_requestedServices.Name = "lst_requestedServices";
            this.lst_requestedServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_requestedServices.Size = new System.Drawing.Size(396, 303);
            this.lst_requestedServices.TabIndex = 31;
            // 
            // incomeSourcesBindingSource
            // 
            this.incomeSourcesBindingSource.DataMember = "IncomeSources";
            this.incomeSourcesBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridApprovedservices
            // 
            this.gridApprovedservices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridApprovedservices.BackgroundColor = System.Drawing.Color.White;
            this.gridApprovedservices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridApprovedservices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subreqID,
            this.services,
            this.amounts});
            this.gridApprovedservices.GridColor = System.Drawing.Color.White;
            this.gridApprovedservices.Location = new System.Drawing.Point(496, 43);
            this.gridApprovedservices.Name = "gridApprovedservices";
            this.gridApprovedservices.Size = new System.Drawing.Size(392, 303);
            this.gridApprovedservices.TabIndex = 36;
            this.gridApprovedservices.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridApprovedservices_EditingControlShowing);
            // 
            // subreqID
            // 
            this.subreqID.HeaderText = "subReqId";
            this.subreqID.Name = "subreqID";
            this.subreqID.ReadOnly = true;
            this.subreqID.Visible = false;
            this.subreqID.Width = 90;
            // 
            // services
            // 
            this.services.HeaderText = "services";
            this.services.Name = "services";
            this.services.ReadOnly = true;
            this.services.Width = 290;
            // 
            // amounts
            // 
            this.amounts.HeaderText = "amount";
            this.amounts.Name = "amounts";
            this.amounts.Width = 90;
            // 
            // incomeSourcesTableAdapter
            // 
            this.incomeSourcesTableAdapter.ClearBeforeFill = true;
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(904, 635);
            this.Controls.Add(this.gridApprovedservices);
            this.Controls.Add(this.cmb_approvalReason);
            this.Controls.Add(this.cmb_denialReason);
            this.Controls.Add(this.btn_leftArrows);
            this.Controls.Add(this.lst_requestedServices);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblReferals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rightArrows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ApprovalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Approval";
            this.Load += new System.EventHandler(this.ApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeSourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedservices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferals;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rightArrows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_leftArrows;
        private System.Windows.Forms.ComboBox cmb_denialReason;
        private System.Windows.Forms.ComboBox cmb_approvalReason;
        private System.Windows.Forms.ListBox lst_requestedServices;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource incomeSourcesBindingSource;
        private DataSet1TableAdapters.IncomeSourcesTableAdapter incomeSourcesTableAdapter;
        private System.Windows.Forms.DataGridView gridApprovedservices;
        private System.Windows.Forms.DataGridViewTextBoxColumn subreqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn services;
        private System.Windows.Forms.DataGridViewTextBoxColumn amounts;
    }
}