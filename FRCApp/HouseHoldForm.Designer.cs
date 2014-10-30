namespace FRCApp
{
    partial class HouseHoldForm
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
            this.title = new System.Windows.Forms.Panel();
            this.HouseHoldFormSummaryListBox = new System.Windows.Forms.ListBox();
            this.HouseHoldFormRadioButtonNo = new System.Windows.Forms.RadioButton();
            this.HouseHoldFormRadioButtonYes = new System.Windows.Forms.RadioButton();
            this.HouseHoldFormHealthCoverageRadioButton = new System.Windows.Forms.Label();
            this.HouseHoldFormRelationshipToApplicant = new System.Windows.Forms.TextBox();
            this.HouseHoldFormBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HouseHoldFormlast4DigitsOfSsnTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormlastNameTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormEthnicityListBox = new System.Windows.Forms.ListBox();
            this.HouseHoldFormEthnicity = new System.Windows.Forms.Label();
            this.HouseHoldFormRelationship = new System.Windows.Forms.Label();
            this.HouseHoldFormBirthDate = new System.Windows.Forms.Label();
            this.HouseHoldFormSSN = new System.Windows.Forms.Label();
            this.HouseHoldFormLastName = new System.Windows.Forms.Label();
            this.HouseHoldSubmitAdd = new System.Windows.Forms.Button();
            this.HouseHoldFormTitle = new System.Windows.Forms.Label();
            this.HouseHoldFormFirstName = new System.Windows.Forms.Label();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Controls.Add(this.HouseHoldFormSummaryListBox);
            this.title.Controls.Add(this.HouseHoldFormRadioButtonNo);
            this.title.Controls.Add(this.HouseHoldFormRadioButtonYes);
            this.title.Controls.Add(this.HouseHoldFormHealthCoverageRadioButton);
            this.title.Controls.Add(this.HouseHoldFormRelationshipToApplicant);
            this.title.Controls.Add(this.HouseHoldFormBirthDateDateTimePicker);
            this.title.Controls.Add(this.HouseHoldFormlast4DigitsOfSsnTextBox);
            this.title.Controls.Add(this.HouseHoldFormlastNameTextBox);
            this.title.Controls.Add(this.HouseHoldFormFirstNameTextBox);
            this.title.Controls.Add(this.HouseHoldFormEthnicityListBox);
            this.title.Controls.Add(this.HouseHoldFormEthnicity);
            this.title.Controls.Add(this.HouseHoldFormRelationship);
            this.title.Controls.Add(this.HouseHoldFormBirthDate);
            this.title.Controls.Add(this.HouseHoldFormSSN);
            this.title.Controls.Add(this.HouseHoldFormLastName);
            this.title.Controls.Add(this.HouseHoldSubmitAdd);
            this.title.Controls.Add(this.HouseHoldFormTitle);
            this.title.Controls.Add(this.HouseHoldFormFirstName);
            this.title.Location = new System.Drawing.Point(0, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(822, 385);
            this.title.TabIndex = 0;
            this.title.Paint += new System.Windows.Forms.PaintEventHandler(this.title_Paint);
            // 
            // HouseHoldFormSummaryListBox
            // 
            this.HouseHoldFormSummaryListBox.FormattingEnabled = true;
            this.HouseHoldFormSummaryListBox.Location = new System.Drawing.Point(418, 21);
            this.HouseHoldFormSummaryListBox.Name = "HouseHoldFormSummaryListBox";
            this.HouseHoldFormSummaryListBox.Size = new System.Drawing.Size(399, 355);
            this.HouseHoldFormSummaryListBox.TabIndex = 15;
            this.HouseHoldFormSummaryListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            
            // 
            // HouseHoldFormRadioButtonNo
            // 
            this.HouseHoldFormRadioButtonNo.AutoSize = true;
            this.HouseHoldFormRadioButtonNo.Location = new System.Drawing.Point(234, 291);
            this.HouseHoldFormRadioButtonNo.Name = "HouseHoldFormRadioButtonNo";
            this.HouseHoldFormRadioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.HouseHoldFormRadioButtonNo.TabIndex = 14;
            this.HouseHoldFormRadioButtonNo.TabStop = true;
            this.HouseHoldFormRadioButtonNo.Text = "No";
            this.HouseHoldFormRadioButtonNo.UseVisualStyleBackColor = true;
            // 
            // HouseHoldFormRadioButtonYes
            // 
            this.HouseHoldFormRadioButtonYes.AutoSize = true;
            this.HouseHoldFormRadioButtonYes.Location = new System.Drawing.Point(184, 291);
            this.HouseHoldFormRadioButtonYes.Name = "HouseHoldFormRadioButtonYes";
            this.HouseHoldFormRadioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.HouseHoldFormRadioButtonYes.TabIndex = 13;
            this.HouseHoldFormRadioButtonYes.TabStop = true;
            this.HouseHoldFormRadioButtonYes.Text = "Yes";
            this.HouseHoldFormRadioButtonYes.UseVisualStyleBackColor = true;
            // 
            // HouseHoldFormHealthCoverageRadioButton
            // 
            this.HouseHoldFormHealthCoverageRadioButton.AutoSize = true;
            this.HouseHoldFormHealthCoverageRadioButton.Location = new System.Drawing.Point(9, 291);
            this.HouseHoldFormHealthCoverageRadioButton.Name = "HouseHoldFormHealthCoverageRadioButton";
            this.HouseHoldFormHealthCoverageRadioButton.Size = new System.Drawing.Size(87, 13);
            this.HouseHoldFormHealthCoverageRadioButton.TabIndex = 12;
            this.HouseHoldFormHealthCoverageRadioButton.Text = "Health Coverage";
            // 
            // HouseHoldFormRelationshipToApplicant
            // 
            this.HouseHoldFormRelationshipToApplicant.Location = new System.Drawing.Point(184, 156);
            this.HouseHoldFormRelationshipToApplicant.Name = "HouseHoldFormRelationshipToApplicant";
            this.HouseHoldFormRelationshipToApplicant.Size = new System.Drawing.Size(100, 20);
            this.HouseHoldFormRelationshipToApplicant.TabIndex = 11;
            this.HouseHoldFormRelationshipToApplicant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HouseHoldFormBirthDateDateTimePicker
            // 
            this.HouseHoldFormBirthDateDateTimePicker.Location = new System.Drawing.Point(184, 126);
            this.HouseHoldFormBirthDateDateTimePicker.Name = "HouseHoldFormBirthDateDateTimePicker";
            this.HouseHoldFormBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormBirthDateDateTimePicker.TabIndex = 10;
            // 
            // HouseHoldFormlast4DigitsOfSsnTextBox
            // 
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Location = new System.Drawing.Point(184, 95);
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Name = "HouseHoldFormlast4DigitsOfSsnTextBox";
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Size = new System.Drawing.Size(100, 20);
            this.HouseHoldFormlast4DigitsOfSsnTextBox.TabIndex = 9;
            // 
            // HouseHoldFormlastNameTextBox
            // 
            this.HouseHoldFormlastNameTextBox.Location = new System.Drawing.Point(184, 68);
            this.HouseHoldFormlastNameTextBox.Name = "HouseHoldFormlastNameTextBox";
            this.HouseHoldFormlastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormlastNameTextBox.TabIndex = 8;
            // 
            // HouseHoldFormFirstNameTextBox
            // 
            this.HouseHoldFormFirstNameTextBox.Location = new System.Drawing.Point(184, 41);
            this.HouseHoldFormFirstNameTextBox.Name = "HouseHoldFormFirstNameTextBox";
            this.HouseHoldFormFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormFirstNameTextBox.TabIndex = 7;
            // 
            // HouseHoldFormEthnicityListBox
            // 
            this.HouseHoldFormEthnicityListBox.FormattingEnabled = true;
            this.HouseHoldFormEthnicityListBox.Items.AddRange(new object[] {
            "White",
            "Black, African Am, ",
            "Asian Indian",
            "Chinese",
            "Filipino",
            "Japanese",
            "Korean",
            "Vietnamese",
            "Native Hawaiian",
            "Guamanian",
            "Samoan",
            "Other"});
            this.HouseHoldFormEthnicityListBox.Location = new System.Drawing.Point(184, 182);
            this.HouseHoldFormEthnicityListBox.Name = "HouseHoldFormEthnicityListBox";
            this.HouseHoldFormEthnicityListBox.Size = new System.Drawing.Size(120, 95);
            this.HouseHoldFormEthnicityListBox.TabIndex = 6;
            this.HouseHoldFormEthnicityListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HouseHoldFormEthnicity
            // 
            this.HouseHoldFormEthnicity.AutoSize = true;
            this.HouseHoldFormEthnicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormEthnicity.Location = new System.Drawing.Point(6, 182);
            this.HouseHoldFormEthnicity.Name = "HouseHoldFormEthnicity";
            this.HouseHoldFormEthnicity.Size = new System.Drawing.Size(92, 13);
            this.HouseHoldFormEthnicity.TabIndex = 5;
            this.HouseHoldFormEthnicity.Text = "Ethnicity/Race";
            // 
            // HouseHoldFormRelationship
            // 
            this.HouseHoldFormRelationship.AutoSize = true;
            this.HouseHoldFormRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormRelationship.Location = new System.Drawing.Point(6, 156);
            this.HouseHoldFormRelationship.Name = "HouseHoldFormRelationship";
            this.HouseHoldFormRelationship.Size = new System.Drawing.Size(149, 13);
            this.HouseHoldFormRelationship.TabIndex = 4;
            this.HouseHoldFormRelationship.Text = "Relationship to Applicant";
            // 
            // HouseHoldFormBirthDate
            // 
            this.HouseHoldFormBirthDate.AutoSize = true;
            this.HouseHoldFormBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormBirthDate.Location = new System.Drawing.Point(6, 126);
            this.HouseHoldFormBirthDate.Name = "HouseHoldFormBirthDate";
            this.HouseHoldFormBirthDate.Size = new System.Drawing.Size(64, 13);
            this.HouseHoldFormBirthDate.TabIndex = 3;
            this.HouseHoldFormBirthDate.Text = "Birth Date";
            // 
            // HouseHoldFormSSN
            // 
            this.HouseHoldFormSSN.AutoSize = true;
            this.HouseHoldFormSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormSSN.Location = new System.Drawing.Point(6, 98);
            this.HouseHoldFormSSN.Name = "HouseHoldFormSSN";
            this.HouseHoldFormSSN.Size = new System.Drawing.Size(116, 13);
            this.HouseHoldFormSSN.TabIndex = 2;
            this.HouseHoldFormSSN.Text = "last 4 digits of SSN";
            // 
            // HouseHoldFormLastName
            // 
            this.HouseHoldFormLastName.AutoSize = true;
            this.HouseHoldFormLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormLastName.Location = new System.Drawing.Point(6, 68);
            this.HouseHoldFormLastName.Name = "HouseHoldFormLastName";
            this.HouseHoldFormLastName.Size = new System.Drawing.Size(67, 13);
            this.HouseHoldFormLastName.TabIndex = 1;
            this.HouseHoldFormLastName.Text = "Last Name";
            this.HouseHoldFormLastName.Click += new System.EventHandler(this.HouseHoldFormLastName_Click);
            // 
            // HouseHoldSubmitAdd
            // 
            this.HouseHoldSubmitAdd.Location = new System.Drawing.Point(152, 331);
            this.HouseHoldSubmitAdd.Name = "HouseHoldSubmitAdd";
            this.HouseHoldSubmitAdd.Size = new System.Drawing.Size(75, 23);
            this.HouseHoldSubmitAdd.TabIndex = 1;
            this.HouseHoldSubmitAdd.Text = "Add";
            this.HouseHoldSubmitAdd.UseVisualStyleBackColor = true;
            this.HouseHoldSubmitAdd.Click += new System.EventHandler(this.HouseHoldSubmitButton_Click);
            // 
            // HouseHoldFormTitle
            // 
            this.HouseHoldFormTitle.AutoSize = true;
            this.HouseHoldFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormTitle.Location = new System.Drawing.Point(4, 4);
            this.HouseHoldFormTitle.Name = "HouseHoldFormTitle";
            this.HouseHoldFormTitle.Size = new System.Drawing.Size(282, 25);
            this.HouseHoldFormTitle.TabIndex = 0;
            this.HouseHoldFormTitle.Text = "HOUSEHOLD INFORMATION";
            this.HouseHoldFormTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // HouseHoldFormFirstName
            // 
            this.HouseHoldFormFirstName.AutoSize = true;
            this.HouseHoldFormFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormFirstName.Location = new System.Drawing.Point(6, 41);
            this.HouseHoldFormFirstName.Name = "HouseHoldFormFirstName";
            this.HouseHoldFormFirstName.Size = new System.Drawing.Size(67, 13);
            this.HouseHoldFormFirstName.TabIndex = 0;
            this.HouseHoldFormFirstName.Text = "First Name";
            this.HouseHoldFormFirstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HouseHoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 394);
            this.Controls.Add(this.title);
            this.Name = "HouseHoldForm";
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title;
        //private dBDataSetTableAdapters.BarriersToSubtypesTableAdapter barriersToSubtypesTableAdapter1;
        private System.Windows.Forms.Button HouseHoldSubmitAdd;
        private System.Windows.Forms.Label HouseHoldFormTitle;
        private System.Windows.Forms.Label HouseHoldFormBirthDate;
        private System.Windows.Forms.Label HouseHoldFormSSN;
        private System.Windows.Forms.Label HouseHoldFormLastName;
        private System.Windows.Forms.Label HouseHoldFormFirstName;
        private System.Windows.Forms.ListBox HouseHoldFormEthnicityListBox;
        private System.Windows.Forms.Label HouseHoldFormEthnicity;
        private System.Windows.Forms.Label HouseHoldFormRelationship;
        private System.Windows.Forms.DateTimePicker HouseHoldFormBirthDateDateTimePicker;
        private System.Windows.Forms.TextBox HouseHoldFormlast4DigitsOfSsnTextBox;
        private System.Windows.Forms.TextBox HouseHoldFormlastNameTextBox;
        private System.Windows.Forms.TextBox HouseHoldFormFirstNameTextBox;
        private System.Windows.Forms.TextBox HouseHoldFormRelationshipToApplicant;
        private System.Windows.Forms.ListBox HouseHoldFormSummaryListBox;
        private System.Windows.Forms.RadioButton HouseHoldFormRadioButtonNo;
        private System.Windows.Forms.RadioButton HouseHoldFormRadioButtonYes;
        private System.Windows.Forms.Label HouseHoldFormHealthCoverageRadioButton;
    }
}
