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
            this.FinanceFormlastNameTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormLastName = new System.Windows.Forms.Label();
            this.FinanceSubmitAdd = new System.Windows.Forms.Button();
            this.FinanceFormTitle = new System.Windows.Forms.Label();
            this.FinanceFormFirstName = new System.Windows.Forms.Label();
            this.FinancePersonWithIncomeLabel = new System.Windows.Forms.Label();
            this.FinanceFormAmountOfIncomeTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormAmountOfIncomelabel = new System.Windows.Forms.Label();
            this.FinanceFormSourceOfIncomeTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormSourceOfIncomelabel = new System.Windows.Forms.Label();
            this.FinanceFormNumTimesIncomeReceievedTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormNumTimesRecievedlabel = new System.Windows.Forms.Label();
            this.FinancelistView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinanceRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinanceFormlastNameTextBox
            // 
            this.FinanceFormlastNameTextBox.Location = new System.Drawing.Point(196, 103);
            this.FinanceFormlastNameTextBox.Name = "FinanceFormlastNameTextBox";
            this.FinanceFormlastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinanceFormlastNameTextBox.TabIndex = 26;
            this.FinanceFormlastNameTextBox.TextChanged += new System.EventHandler(this.FinanceFormlastNameTextBox_TextChanged);
            // 
            // FinanceFormFirstNameTextBox
            // 
            this.FinanceFormFirstNameTextBox.Location = new System.Drawing.Point(196, 73);
            this.FinanceFormFirstNameTextBox.Name = "FinanceFormFirstNameTextBox";
            this.FinanceFormFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinanceFormFirstNameTextBox.TabIndex = 25;
            this.FinanceFormFirstNameTextBox.TextChanged += new System.EventHandler(this.FinanceFormFirstNameTextBox_TextChanged);
            // 
            // FinanceFormLastName
            // 
            this.FinanceFormLastName.AutoSize = true;
            this.FinanceFormLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormLastName.Location = new System.Drawing.Point(19, 110);
            this.FinanceFormLastName.Name = "FinanceFormLastName";
            this.FinanceFormLastName.Size = new System.Drawing.Size(67, 13);
            this.FinanceFormLastName.TabIndex = 19;
            this.FinanceFormLastName.Text = "Last Name";
            this.FinanceFormLastName.Click += new System.EventHandler(this.FinanceFormLastName_Click);
            // 
            // FinanceSubmitAdd
            // 
            this.FinanceSubmitAdd.Location = new System.Drawing.Point(321, 228);
            this.FinanceSubmitAdd.Name = "FinanceSubmitAdd";
            this.FinanceSubmitAdd.Size = new System.Drawing.Size(75, 23);
            this.FinanceSubmitAdd.TabIndex = 18;
            this.FinanceSubmitAdd.Text = "Add";
            this.FinanceSubmitAdd.UseVisualStyleBackColor = true;
            this.FinanceSubmitAdd.Click += new System.EventHandler(this.FinanceSubmitAdd_Click);
            // 
            // FinanceFormTitle
            // 
            this.FinanceFormTitle.AutoSize = true;
            this.FinanceFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormTitle.Location = new System.Drawing.Point(16, 11);
            this.FinanceFormTitle.Name = "FinanceFormTitle";
            this.FinanceFormTitle.Size = new System.Drawing.Size(376, 25);
            this.FinanceFormTitle.TabIndex = 17;
            this.FinanceFormTitle.Text = "HOUSEHOLD INCOME AND FINANCES";
            this.FinanceFormTitle.Click += new System.EventHandler(this.FinanceFormTitle_Click);
            // 
            // FinanceFormFirstName
            // 
            this.FinanceFormFirstName.AutoSize = true;
            this.FinanceFormFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormFirstName.Location = new System.Drawing.Point(19, 80);
            this.FinanceFormFirstName.Name = "FinanceFormFirstName";
            this.FinanceFormFirstName.Size = new System.Drawing.Size(67, 13);
            this.FinanceFormFirstName.TabIndex = 16;
            this.FinanceFormFirstName.Text = "First Name";
            this.FinanceFormFirstName.Click += new System.EventHandler(this.FinanceFormFirstName_Click);
            // 
            // FinancePersonWithIncomeLabel
            // 
            this.FinancePersonWithIncomeLabel.AutoSize = true;
            this.FinancePersonWithIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinancePersonWithIncomeLabel.Location = new System.Drawing.Point(19, 51);
            this.FinancePersonWithIncomeLabel.Name = "FinancePersonWithIncomeLabel";
            this.FinancePersonWithIncomeLabel.Size = new System.Drawing.Size(141, 16);
            this.FinancePersonWithIncomeLabel.TabIndex = 34;
            this.FinancePersonWithIncomeLabel.Text = "Person with Income";
            // 
            // FinanceFormAmountOfIncomeTextBox
            // 
            this.FinanceFormAmountOfIncomeTextBox.Location = new System.Drawing.Point(196, 169);
            this.FinanceFormAmountOfIncomeTextBox.Name = "FinanceFormAmountOfIncomeTextBox";
            this.FinanceFormAmountOfIncomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinanceFormAmountOfIncomeTextBox.TabIndex = 37;
            // 
            // FinanceFormAmountOfIncomelabel
            // 
            this.FinanceFormAmountOfIncomelabel.AutoSize = true;
            this.FinanceFormAmountOfIncomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormAmountOfIncomelabel.Location = new System.Drawing.Point(18, 176);
            this.FinanceFormAmountOfIncomelabel.Name = "FinanceFormAmountOfIncomelabel";
            this.FinanceFormAmountOfIncomelabel.Size = new System.Drawing.Size(109, 13);
            this.FinanceFormAmountOfIncomelabel.TabIndex = 35;
            this.FinanceFormAmountOfIncomelabel.Text = "Amount of Income";
            // 
            // FinanceFormSourceOfIncomeTextBox
            // 
            this.FinanceFormSourceOfIncomeTextBox.Location = new System.Drawing.Point(196, 137);
            this.FinanceFormSourceOfIncomeTextBox.Name = "FinanceFormSourceOfIncomeTextBox";
            this.FinanceFormSourceOfIncomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinanceFormSourceOfIncomeTextBox.TabIndex = 40;
            // 
            // FinanceFormSourceOfIncomelabel
            // 
            this.FinanceFormSourceOfIncomelabel.AutoSize = true;
            this.FinanceFormSourceOfIncomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormSourceOfIncomelabel.Location = new System.Drawing.Point(18, 144);
            this.FinanceFormSourceOfIncomelabel.Name = "FinanceFormSourceOfIncomelabel";
            this.FinanceFormSourceOfIncomelabel.Size = new System.Drawing.Size(107, 13);
            this.FinanceFormSourceOfIncomelabel.TabIndex = 39;
            this.FinanceFormSourceOfIncomelabel.Text = "Source of Income";
            // 
            // FinanceFormNumTimesIncomeReceievedTextBox
            // 
            this.FinanceFormNumTimesIncomeReceievedTextBox.Location = new System.Drawing.Point(196, 202);
            this.FinanceFormNumTimesIncomeReceievedTextBox.Name = "FinanceFormNumTimesIncomeReceievedTextBox";
            this.FinanceFormNumTimesIncomeReceievedTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinanceFormNumTimesIncomeReceievedTextBox.TabIndex = 42;
            // 
            // FinanceFormNumTimesRecievedlabel
            // 
            this.FinanceFormNumTimesRecievedlabel.AutoSize = true;
            this.FinanceFormNumTimesRecievedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceFormNumTimesRecievedlabel.Location = new System.Drawing.Point(18, 209);
            this.FinanceFormNumTimesRecievedlabel.Name = "FinanceFormNumTimesRecievedlabel";
            this.FinanceFormNumTimesRecievedlabel.Size = new System.Drawing.Size(175, 13);
            this.FinanceFormNumTimesRecievedlabel.TabIndex = 41;
            this.FinanceFormNumTimesRecievedlabel.Text = "How often income is received";
            // 
            // FinancelistView
            // 
            this.FinancelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.incomeSource,
            this.incomeAmount,
            this.incomeFrequency});
            this.FinancelistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FinancelistView.Location = new System.Drawing.Point(414, 51);
            this.FinancelistView.MultiSelect = false;
            this.FinancelistView.Name = "FinancelistView";
            this.FinancelistView.Size = new System.Drawing.Size(405, 171);
            this.FinancelistView.TabIndex = 43;
            this.FinancelistView.UseCompatibleStateImageBehavior = false;
            this.FinancelistView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "First, Last Name";
            this.name.Width = 88;
            // 
            // incomeSource
            // 
            this.incomeSource.Text = "Source of Income";
            this.incomeSource.Width = 97;
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
            // FinanceRemoveButton
            // 
            this.FinanceRemoveButton.Location = new System.Drawing.Point(744, 228);
            this.FinanceRemoveButton.Name = "FinanceRemoveButton";
            this.FinanceRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.FinanceRemoveButton.TabIndex = 44;
            this.FinanceRemoveButton.Text = "Remove";
            this.FinanceRemoveButton.UseVisualStyleBackColor = true;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 270);
            this.Controls.Add(this.FinanceRemoveButton);
            this.Controls.Add(this.FinancelistView);
            this.Controls.Add(this.FinanceFormNumTimesIncomeReceievedTextBox);
            this.Controls.Add(this.FinanceFormNumTimesRecievedlabel);
            this.Controls.Add(this.FinanceFormSourceOfIncomeTextBox);
            this.Controls.Add(this.FinanceFormSourceOfIncomelabel);
            this.Controls.Add(this.FinanceFormAmountOfIncomeTextBox);
            this.Controls.Add(this.FinanceFormAmountOfIncomelabel);
            this.Controls.Add(this.FinancePersonWithIncomeLabel);
            this.Controls.Add(this.FinanceFormlastNameTextBox);
            this.Controls.Add(this.FinanceFormFirstNameTextBox);
            this.Controls.Add(this.FinanceFormLastName);
            this.Controls.Add(this.FinanceSubmitAdd);
            this.Controls.Add(this.FinanceFormTitle);
            this.Controls.Add(this.FinanceFormFirstName);
            this.Name = "FinanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FinanceFormlastNameTextBox;
        private System.Windows.Forms.TextBox FinanceFormFirstNameTextBox;
        private System.Windows.Forms.Label FinanceFormLastName;
        private System.Windows.Forms.Button FinanceSubmitAdd;
        private System.Windows.Forms.Label FinanceFormTitle;
        private System.Windows.Forms.Label FinanceFormFirstName;
        private System.Windows.Forms.Label FinancePersonWithIncomeLabel;
        private System.Windows.Forms.TextBox FinanceFormAmountOfIncomeTextBox;
        private System.Windows.Forms.Label FinanceFormAmountOfIncomelabel;
        private System.Windows.Forms.TextBox FinanceFormSourceOfIncomeTextBox;
        private System.Windows.Forms.Label FinanceFormSourceOfIncomelabel;
        private System.Windows.Forms.TextBox FinanceFormNumTimesIncomeReceievedTextBox;
        private System.Windows.Forms.Label FinanceFormNumTimesRecievedlabel;
        private System.Windows.Forms.ListView FinancelistView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader incomeSource;
        private System.Windows.Forms.ColumnHeader incomeAmount;
        private System.Windows.Forms.ColumnHeader incomeFrequency;
        private System.Windows.Forms.Button FinanceRemoveButton;
    }
}
