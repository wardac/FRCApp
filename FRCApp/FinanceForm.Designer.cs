﻿namespace FRCApp
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
            this.submitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cmb_householdMember = new System.Windows.Forms.ComboBox();
            this.cmb_incomeFreqs = new System.Windows.Forms.ComboBox();
            this.cmb_incomeSourceType = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.Teal;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(321, 291);
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
            this.Date});
            this.FinancelistView.FullRowSelect = true;
            this.FinancelistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FinancelistView.Location = new System.Drawing.Point(414, 51);
            this.FinancelistView.Name = "FinancelistView";
            this.FinancelistView.Size = new System.Drawing.Size(545, 212);
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
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.Teal;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(737, 291);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.Teal;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(414, 291);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Teal;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(818, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(196, 243);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 43;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(967, 324);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cmb_incomeSourceType);
            this.Controls.Add(this.cmb_incomeFreqs);
            this.Controls.Add(this.cmb_householdMember);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.submitButton);
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
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox cmb_householdMember;
        private System.Windows.Forms.ComboBox cmb_incomeFreqs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ComboBox cmb_incomeSourceType;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
