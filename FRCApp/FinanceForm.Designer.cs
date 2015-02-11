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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormLastName = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.FinanceFormTitle = new System.Windows.Forms.Label();
            this.FinanceFormFirstName = new System.Windows.Forms.Label();
            this.FinancePersonWithIncomeLabel = new System.Windows.Forms.Label();
            this.amountOfIncomeTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormAmountOfIncomelabel = new System.Windows.Forms.Label();
            this.sourceOfIncomeTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormSourceOfIncomelabel = new System.Windows.Forms.Label();
            this.timesIncomeReceievedTextBox = new System.Windows.Forms.TextBox();
            this.FinanceFormNumTimesRecievedlabel = new System.Windows.Forms.Label();
            this.FinancelistView = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.submitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(196, 103);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(196, 73);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 0;
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
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(321, 228);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // amountOfIncomeTextBox
            // 
            this.amountOfIncomeTextBox.Location = new System.Drawing.Point(196, 169);
            this.amountOfIncomeTextBox.Name = "amountOfIncomeTextBox";
            this.amountOfIncomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountOfIncomeTextBox.TabIndex = 3;
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
            // sourceOfIncomeTextBox
            // 
            this.sourceOfIncomeTextBox.Location = new System.Drawing.Point(196, 137);
            this.sourceOfIncomeTextBox.Name = "sourceOfIncomeTextBox";
            this.sourceOfIncomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.sourceOfIncomeTextBox.TabIndex = 2;
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
            // timesIncomeReceievedTextBox
            // 
            this.timesIncomeReceievedTextBox.Location = new System.Drawing.Point(196, 202);
            this.timesIncomeReceievedTextBox.Name = "timesIncomeReceievedTextBox";
            this.timesIncomeReceievedTextBox.Size = new System.Drawing.Size(200, 20);
            this.timesIncomeReceievedTextBox.TabIndex = 4;
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
            this.firstName,
            this.lastName,
            this.incomeSource,
            this.incomeAmount,
            this.incomeFrequency});
            this.FinancelistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FinancelistView.Location = new System.Drawing.Point(414, 51);
            this.FinancelistView.MultiSelect = false;
            this.FinancelistView.Name = "FinancelistView";
            this.FinancelistView.Size = new System.Drawing.Size(527, 171);
            this.FinancelistView.TabIndex = 7;
            this.FinancelistView.UseCompatibleStateImageBehavior = false;
            this.FinancelistView.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 85;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 117;
            // 
            // incomeSource
            // 
            this.incomeSource.Text = "Source of Income";
            this.incomeSource.Width = 108;
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
            this.submitButton.Location = new System.Drawing.Point(785, 228);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(240, 228);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(866, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 42;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 270);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.FinancelistView);
            this.Controls.Add(this.timesIncomeReceievedTextBox);
            this.Controls.Add(this.FinanceFormNumTimesRecievedlabel);
            this.Controls.Add(this.sourceOfIncomeTextBox);
            this.Controls.Add(this.FinanceFormSourceOfIncomelabel);
            this.Controls.Add(this.amountOfIncomeTextBox);
            this.Controls.Add(this.FinanceFormAmountOfIncomelabel);
            this.Controls.Add(this.FinancePersonWithIncomeLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.FinanceFormLastName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.FinanceFormTitle);
            this.Controls.Add(this.FinanceFormFirstName);
            this.Name = "FinanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label FinanceFormLastName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label FinanceFormTitle;
        private System.Windows.Forms.Label FinanceFormFirstName;
        private System.Windows.Forms.Label FinancePersonWithIncomeLabel;
        private System.Windows.Forms.TextBox amountOfIncomeTextBox;
        private System.Windows.Forms.Label FinanceFormAmountOfIncomelabel;
        private System.Windows.Forms.TextBox sourceOfIncomeTextBox;
        private System.Windows.Forms.Label FinanceFormSourceOfIncomelabel;
        private System.Windows.Forms.TextBox timesIncomeReceievedTextBox;
        private System.Windows.Forms.Label FinanceFormNumTimesRecievedlabel;
        private System.Windows.Forms.ListView FinancelistView;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader incomeSource;
        private System.Windows.Forms.ColumnHeader incomeAmount;
        private System.Windows.Forms.ColumnHeader incomeFrequency;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.Button cancelButton;
    }
}
