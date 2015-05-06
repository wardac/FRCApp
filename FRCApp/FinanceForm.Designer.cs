namespace FRCApp
{
    partial class FinanceForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.FinanceFormTitle = new System.Windows.Forms.Label();
            this.FinanceFormName = new System.Windows.Forms.Label();
            this.FinancePersonWithIncomeLabel = new System.Windows.Forms.Label();
            this.amountOfIncomeTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormAmountOfIncomelabel = new System.Windows.Forms.Label();
            this.FinanceFormSourceOfIncomelabel = new System.Windows.Forms.Label();
            this.FinanceFormNumTimesRecievedlabel = new System.Windows.Forms.Label();
            this.FinancelistView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Archived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.archiveButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.cmb_householdMember = new System.Windows.Forms.ComboBox();
            this.cmb_incomeFreqs = new System.Windows.Forms.ComboBox();
            this.cmb_incomeSourceType = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePickerDateadded = new System.Windows.Forms.DateTimePicker();
            this.radioUnarchived = new System.Windows.Forms.RadioButton();
            this.radioArchived = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Teal;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(196, 289);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // FinanceFormTitle
            // 
            this.FinanceFormTitle.AutoSize = true;
            this.FinanceFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormTitle.ForeColor = System.Drawing.Color.Teal;
            this.FinanceFormTitle.Location = new System.Drawing.Point(16, 11);
            this.FinanceFormTitle.Name = "FinanceFormTitle";
            this.FinanceFormTitle.Size = new System.Drawing.Size(376, 25);
            this.FinanceFormTitle.TabIndex = 17;
            this.FinanceFormTitle.Text = "HOUSEHOLD INCOME AND FINANCES";
            // 
            // FinanceFormName
            // 
            this.FinanceFormName.AutoSize = true;
            this.FinanceFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormName.ForeColor = System.Drawing.Color.Teal;
            this.FinanceFormName.Location = new System.Drawing.Point(19, 80);
            this.FinanceFormName.Name = "FinanceFormName";
            this.FinanceFormName.Size = new System.Drawing.Size(39, 13);
            this.FinanceFormName.TabIndex = 16;
            this.FinanceFormName.Text = "Name";
            // 
            // FinancePersonWithIncomeLabel
            // 
            this.FinancePersonWithIncomeLabel.AutoSize = true;
            this.FinancePersonWithIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinancePersonWithIncomeLabel.ForeColor = System.Drawing.Color.Teal;
            this.FinancePersonWithIncomeLabel.Location = new System.Drawing.Point(19, 51);
            this.FinancePersonWithIncomeLabel.Name = "FinancePersonWithIncomeLabel";
            this.FinancePersonWithIncomeLabel.Size = new System.Drawing.Size(141, 16);
            this.FinancePersonWithIncomeLabel.TabIndex = 34;
            this.FinancePersonWithIncomeLabel.Text = "Person with Income";
            // 
            // amountOfIncomeTextBox
            // 
            this.amountOfIncomeTextBox.Location = new System.Drawing.Point(196, 160);
            this.amountOfIncomeTextBox.Name = "amountOfIncomeTextBox";
            this.amountOfIncomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountOfIncomeTextBox.TabIndex = 2;
            // 
            // FinanceFormAmountOfIncomelabel
            // 
            this.FinanceFormAmountOfIncomelabel.AutoSize = true;
            this.FinanceFormAmountOfIncomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormAmountOfIncomelabel.ForeColor = System.Drawing.Color.Teal;
            this.FinanceFormAmountOfIncomelabel.Location = new System.Drawing.Point(18, 164);
            this.FinanceFormAmountOfIncomelabel.Name = "FinanceFormAmountOfIncomelabel";
            this.FinanceFormAmountOfIncomelabel.Size = new System.Drawing.Size(109, 13);
            this.FinanceFormAmountOfIncomelabel.TabIndex = 35;
            this.FinanceFormAmountOfIncomelabel.Text = "Amount of Income";
            // 
            // FinanceFormSourceOfIncomelabel
            // 
            this.FinanceFormSourceOfIncomelabel.AutoSize = true;
            this.FinanceFormSourceOfIncomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormSourceOfIncomelabel.ForeColor = System.Drawing.Color.Teal;
            this.FinanceFormSourceOfIncomelabel.Location = new System.Drawing.Point(18, 122);
            this.FinanceFormSourceOfIncomelabel.Name = "FinanceFormSourceOfIncomelabel";
            this.FinanceFormSourceOfIncomelabel.Size = new System.Drawing.Size(107, 13);
            this.FinanceFormSourceOfIncomelabel.TabIndex = 39;
            this.FinanceFormSourceOfIncomelabel.Text = "Source of Income";
            // 
            // FinanceFormNumTimesRecievedlabel
            // 
            this.FinanceFormNumTimesRecievedlabel.AutoSize = true;
            this.FinanceFormNumTimesRecievedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormNumTimesRecievedlabel.ForeColor = System.Drawing.Color.Teal;
            this.FinanceFormNumTimesRecievedlabel.Location = new System.Drawing.Point(18, 206);
            this.FinanceFormNumTimesRecievedlabel.Name = "FinanceFormNumTimesRecievedlabel";
            this.FinanceFormNumTimesRecievedlabel.Size = new System.Drawing.Size(175, 13);
            this.FinanceFormNumTimesRecievedlabel.TabIndex = 41;
            this.FinanceFormNumTimesRecievedlabel.Text = "How often income is received";
            // 
            // FinancelistView
            // 
            this.FinancelistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinancelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.incomeSource,
            this.incomeAmount,
            this.incomeFrequency,
            this.Date,
            this.Archived});
            this.FinancelistView.FullRowSelect = true;
            this.FinancelistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FinancelistView.Location = new System.Drawing.Point(414, 51);
            this.FinancelistView.Name = "FinancelistView";
            this.FinancelistView.Size = new System.Drawing.Size(601, 212);
            this.FinancelistView.TabIndex = 5;
            this.FinancelistView.UseCompatibleStateImageBehavior = false;
            this.FinancelistView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 130;
            // 
            // incomeSource
            // 
            this.incomeSource.Text = "Source of Income";
            this.incomeSource.Width = 128;
            // 
            // incomeAmount
            // 
            this.incomeAmount.Text = "Amount of Income";
            this.incomeAmount.Width = 98;
            // 
            // incomeFrequency
            // 
            this.incomeFrequency.Text = "Frequency of Income";
            this.incomeFrequency.Width = 114;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 66;
            // 
            // Archived
            // 
            this.Archived.Text = "Archived";
            // 
            // archiveButton
            // 
            this.archiveButton.BackColor = System.Drawing.Color.Teal;
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.Location = new System.Drawing.Point(317, 289);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(75, 23);
            this.archiveButton.TabIndex = 6;
            this.archiveButton.Text = "Archive";
            this.archiveButton.UseVisualStyleBackColor = false;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.BackColor = System.Drawing.Color.Teal;
            this.doneButton.ForeColor = System.Drawing.Color.White;
            this.doneButton.Location = new System.Drawing.Point(940, 289);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 8;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // cmb_householdMember
            // 
            this.cmb_householdMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_householdMember.FormattingEnabled = true;
            this.cmb_householdMember.Location = new System.Drawing.Point(196, 76);
            this.cmb_householdMember.Name = "cmb_householdMember";
            this.cmb_householdMember.Size = new System.Drawing.Size(200, 21);
            this.cmb_householdMember.TabIndex = 0;
            // 
            // cmb_incomeFreqs
            // 
            this.cmb_incomeFreqs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_incomeFreqs.FormattingEnabled = true;
            this.cmb_incomeFreqs.Location = new System.Drawing.Point(196, 201);
            this.cmb_incomeFreqs.Name = "cmb_incomeFreqs";
            this.cmb_incomeFreqs.Size = new System.Drawing.Size(200, 21);
            this.cmb_incomeFreqs.TabIndex = 3;
            // 
            // cmb_incomeSourceType
            // 
            this.cmb_incomeSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_incomeSourceType.FormattingEnabled = true;
            this.cmb_incomeSourceType.Location = new System.Drawing.Point(196, 118);
            this.cmb_incomeSourceType.Name = "cmb_incomeSourceType";
            this.cmb_incomeSourceType.Size = new System.Drawing.Size(200, 21);
            this.cmb_incomeSourceType.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Teal;
            this.dateLabel.Location = new System.Drawing.Point(19, 248);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 13);
            this.dateLabel.TabIndex = 42;
            this.dateLabel.Text = "Date";
            // 
            // datePickerDateadded
            // 
            this.datePickerDateadded.Location = new System.Drawing.Point(196, 243);
            this.datePickerDateadded.Name = "datePickerDateadded";
            this.datePickerDateadded.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateadded.TabIndex = 43;
            // 
            // radioUnarchived
            // 
            this.radioUnarchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioUnarchived.AutoSize = true;
            this.radioUnarchived.Checked = true;
            this.radioUnarchived.Location = new System.Drawing.Point(750, 28);
            this.radioUnarchived.Name = "radioUnarchived";
            this.radioUnarchived.Size = new System.Drawing.Size(106, 17);
            this.radioUnarchived.TabIndex = 45;
            this.radioUnarchived.TabStop = true;
            this.radioUnarchived.Text = "Unarchived Data";
            this.radioUnarchived.UseVisualStyleBackColor = true;
            this.radioUnarchived.CheckedChanged += new System.EventHandler(this.radioUnarchived_CheckedChanged);
            // 
            // radioArchived
            // 
            this.radioArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioArchived.AutoSize = true;
            this.radioArchived.Location = new System.Drawing.Point(862, 28);
            this.radioArchived.Name = "radioArchived";
            this.radioArchived.Size = new System.Drawing.Size(93, 17);
            this.radioArchived.TabIndex = 46;
            this.radioArchived.Text = "Archived Data";
            this.radioArchived.UseVisualStyleBackColor = true;
            this.radioArchived.CheckedChanged += new System.EventHandler(this.radioArchived_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(953, 28);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(62, 17);
            this.radioAll.TabIndex = 47;
            this.radioAll.Text = "All Data";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1027, 324);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.radioArchived);
            this.Controls.Add(this.radioUnarchived);
            this.Controls.Add(this.datePickerDateadded);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cmb_incomeSourceType);
            this.Controls.Add(this.cmb_incomeFreqs);
            this.Controls.Add(this.cmb_householdMember);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.FinancelistView);
            this.Controls.Add(this.FinanceFormNumTimesRecievedlabel);
            this.Controls.Add(this.FinanceFormSourceOfIncomelabel);
            this.Controls.Add(this.amountOfIncomeTextBox);
            this.Controls.Add(this.FinanceFormAmountOfIncomelabel);
            this.Controls.Add(this.FinancePersonWithIncomeLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.FinanceFormTitle);
            this.Controls.Add(this.FinanceFormName);
            this.Name = "FinanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label FinanceFormTitle;
        private System.Windows.Forms.Label FinanceFormName;
        private System.Windows.Forms.Label FinancePersonWithIncomeLabel;
        private System.Windows.Forms.TextBox amountOfIncomeTextBox;
        private System.Windows.Forms.Label FinanceFormAmountOfIncomelabel;
        private System.Windows.Forms.Label FinanceFormSourceOfIncomelabel;
        private System.Windows.Forms.Label FinanceFormNumTimesRecievedlabel;
        private System.Windows.Forms.ListView FinancelistView;
        private System.Windows.Forms.ColumnHeader incomeSource;
        private System.Windows.Forms.ColumnHeader incomeAmount;
        private System.Windows.Forms.ColumnHeader incomeFrequency;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.ComboBox cmb_householdMember;
        private System.Windows.Forms.ComboBox cmb_incomeFreqs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ComboBox cmb_incomeSourceType;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePickerDateadded;
        private System.Windows.Forms.RadioButton radioUnarchived;
        private System.Windows.Forms.RadioButton radioArchived;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.ColumnHeader Archived;
    }
}
