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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.HouseHoldFormDoneButton = new System.Windows.Forms.Button();
            this.HouseHoldForm_ListView_Summary = new System.Windows.Forms.ListView();
            this.First = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Relationship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ethnicity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HouseHoldFormRadioButtonNo = new System.Windows.Forms.RadioButton();
            this.HouseHoldFormRadioButtonYes = new System.Windows.Forms.RadioButton();
            this.HouseHoldFormHealthCoverageRadioButton = new System.Windows.Forms.Label();
            this.HouseHoldFormRelationshipToApplicant = new System.Windows.Forms.TextBox();
            this.HouseHoldFormBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HouseHoldFormlast4DigitsOfSsnTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormlastNameTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.HouseHoldFormEthnicityListBox = new System.Windows.Forms.ListBox();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FRCApp.DataSet1();
            this.HouseHoldFormEthnicity = new System.Windows.Forms.Label();
            this.HouseHoldFormRelationship = new System.Windows.Forms.Label();
            this.HouseHoldFormBirthDate = new System.Windows.Forms.Label();
            this.HouseHoldFormSSN = new System.Windows.Forms.Label();
            this.HouseHoldFormLastName = new System.Windows.Forms.Label();
            this.btnHouseholdMemberAdd = new System.Windows.Forms.Button();
            this.HouseHoldFormTitle = new System.Windows.Forms.Label();
            this.HouseHoldFormFirstName = new System.Windows.Forms.Label();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesTableAdapter = new FRCApp.DataSet1TableAdapters.RacesTableAdapter();
            this.editButton = new System.Windows.Forms.Button();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Lavender;
            this.title.Controls.Add(this.editButton);
            this.title.Controls.Add(this.removeButton);
            this.title.Controls.Add(this.HouseHoldFormDoneButton);
            this.title.Controls.Add(this.HouseHoldForm_ListView_Summary);
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
            this.title.Controls.Add(this.btnHouseholdMemberAdd);
            this.title.Controls.Add(this.HouseHoldFormTitle);
            this.title.Controls.Add(this.HouseHoldFormFirstName);
            this.title.Location = new System.Drawing.Point(0, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(966, 420);
            this.title.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Teal;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(315, 353);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // HouseHoldFormDoneButton
            // 
            this.HouseHoldFormDoneButton.BackColor = System.Drawing.Color.Teal;
            this.HouseHoldFormDoneButton.ForeColor = System.Drawing.Color.White;
            this.HouseHoldFormDoneButton.Location = new System.Drawing.Point(880, 382);
            this.HouseHoldFormDoneButton.Name = "HouseHoldFormDoneButton";
            this.HouseHoldFormDoneButton.Size = new System.Drawing.Size(75, 23);
            this.HouseHoldFormDoneButton.TabIndex = 11;
            this.HouseHoldFormDoneButton.Text = "Done";
            this.HouseHoldFormDoneButton.UseVisualStyleBackColor = false;
            this.HouseHoldFormDoneButton.Click += new System.EventHandler(this.HouseHoldFormCancelButton_Click);
            // 
            // HouseHoldForm_ListView_Summary
            // 
            this.HouseHoldForm_ListView_Summary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First,
            this.Last,
            this.SSN,
            this.BirthDate,
            this.Relationship,
            this.Ethnicity,
            this.Coverage});
            this.HouseHoldForm_ListView_Summary.FullRowSelect = true;
            this.HouseHoldForm_ListView_Summary.Location = new System.Drawing.Point(417, 4);
            this.HouseHoldForm_ListView_Summary.MultiSelect = false;
            this.HouseHoldForm_ListView_Summary.Name = "HouseHoldForm_ListView_Summary";
            this.HouseHoldForm_ListView_Summary.Size = new System.Drawing.Size(538, 372);
            this.HouseHoldForm_ListView_Summary.TabIndex = 12;
            this.HouseHoldForm_ListView_Summary.UseCompatibleStateImageBehavior = false;
            this.HouseHoldForm_ListView_Summary.View = System.Windows.Forms.View.Details;
            // 
            // First
            // 
            this.First.Text = "First";
            this.First.Width = 103;
            // 
            // Last
            // 
            this.Last.Text = "Last";
            this.Last.Width = 119;
            // 
            // SSN
            // 
            this.SSN.Text = "SSN";
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "Birth Date";
            // 
            // Relationship
            // 
            this.Relationship.Text = "Relationship";
            this.Relationship.Width = 73;
            // 
            // Ethnicity
            // 
            this.Ethnicity.Text = "Ethnicity";
            // 
            // Coverage
            // 
            this.Coverage.Text = "Coverage";
            // 
            // HouseHoldFormRadioButtonNo
            // 
            this.HouseHoldFormRadioButtonNo.AutoSize = true;
            this.HouseHoldFormRadioButtonNo.Location = new System.Drawing.Point(234, 291);
            this.HouseHoldFormRadioButtonNo.Name = "HouseHoldFormRadioButtonNo";
            this.HouseHoldFormRadioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.HouseHoldFormRadioButtonNo.TabIndex = 7;
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
            this.HouseHoldFormRadioButtonYes.TabIndex = 6;
            this.HouseHoldFormRadioButtonYes.TabStop = true;
            this.HouseHoldFormRadioButtonYes.Text = "Yes";
            this.HouseHoldFormRadioButtonYes.UseVisualStyleBackColor = true;
            // 
            // HouseHoldFormHealthCoverageRadioButton
            // 
            this.HouseHoldFormHealthCoverageRadioButton.AutoSize = true;
            this.HouseHoldFormHealthCoverageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormHealthCoverageRadioButton.ForeColor = System.Drawing.Color.Teal;
            this.HouseHoldFormHealthCoverageRadioButton.Location = new System.Drawing.Point(9, 291);
            this.HouseHoldFormHealthCoverageRadioButton.Name = "HouseHoldFormHealthCoverageRadioButton";
            this.HouseHoldFormHealthCoverageRadioButton.Size = new System.Drawing.Size(102, 13);
            this.HouseHoldFormHealthCoverageRadioButton.TabIndex = 12;
            this.HouseHoldFormHealthCoverageRadioButton.Text = "Health Coverage";
            // 
            // HouseHoldFormRelationshipToApplicant
            // 
            this.HouseHoldFormRelationshipToApplicant.Location = new System.Drawing.Point(184, 156);
            this.HouseHoldFormRelationshipToApplicant.Name = "HouseHoldFormRelationshipToApplicant";
            this.HouseHoldFormRelationshipToApplicant.Size = new System.Drawing.Size(100, 20);
            this.HouseHoldFormRelationshipToApplicant.TabIndex = 4;
            // 
            // HouseHoldFormBirthDateDateTimePicker
            // 
            this.HouseHoldFormBirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HouseHoldFormBirthDateDateTimePicker.Location = new System.Drawing.Point(184, 126);
            this.HouseHoldFormBirthDateDateTimePicker.Name = "HouseHoldFormBirthDateDateTimePicker";
            this.HouseHoldFormBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormBirthDateDateTimePicker.TabIndex = 3;
            // 
            // HouseHoldFormlast4DigitsOfSsnTextBox
            // 
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Location = new System.Drawing.Point(184, 95);
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Name = "HouseHoldFormlast4DigitsOfSsnTextBox";
            this.HouseHoldFormlast4DigitsOfSsnTextBox.Size = new System.Drawing.Size(100, 20);
            this.HouseHoldFormlast4DigitsOfSsnTextBox.TabIndex = 2;
            this.HouseHoldFormlast4DigitsOfSsnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseHoldFormlast4DigitsOfSsnTextBox_KeyPress);
            // 
            // HouseHoldFormlastNameTextBox
            // 
            this.HouseHoldFormlastNameTextBox.Location = new System.Drawing.Point(184, 68);
            this.HouseHoldFormlastNameTextBox.Name = "HouseHoldFormlastNameTextBox";
            this.HouseHoldFormlastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormlastNameTextBox.TabIndex = 1;
            // 
            // HouseHoldFormFirstNameTextBox
            // 
            this.HouseHoldFormFirstNameTextBox.Location = new System.Drawing.Point(184, 41);
            this.HouseHoldFormFirstNameTextBox.Name = "HouseHoldFormFirstNameTextBox";
            this.HouseHoldFormFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HouseHoldFormFirstNameTextBox.TabIndex = 0;
            // 
            // HouseHoldFormEthnicityListBox
            // 
            this.HouseHoldFormEthnicityListBox.DataSource = this.racesBindingSource;
            this.HouseHoldFormEthnicityListBox.DisplayMember = "Race";
            this.HouseHoldFormEthnicityListBox.FormattingEnabled = true;
            this.HouseHoldFormEthnicityListBox.Location = new System.Drawing.Point(184, 182);
            this.HouseHoldFormEthnicityListBox.Name = "HouseHoldFormEthnicityListBox";
            this.HouseHoldFormEthnicityListBox.Size = new System.Drawing.Size(120, 95);
            this.HouseHoldFormEthnicityListBox.TabIndex = 5;
            this.HouseHoldFormEthnicityListBox.ValueMember = "Race";
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HouseHoldFormEthnicity
            // 
            this.HouseHoldFormEthnicity.AutoSize = true;
            this.HouseHoldFormEthnicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormEthnicity.ForeColor = System.Drawing.Color.Teal;
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
            this.HouseHoldFormRelationship.ForeColor = System.Drawing.Color.Teal;
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
            this.HouseHoldFormBirthDate.ForeColor = System.Drawing.Color.Teal;
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
            this.HouseHoldFormSSN.ForeColor = System.Drawing.Color.Teal;
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
            this.HouseHoldFormLastName.ForeColor = System.Drawing.Color.Teal;
            this.HouseHoldFormLastName.Location = new System.Drawing.Point(6, 68);
            this.HouseHoldFormLastName.Name = "HouseHoldFormLastName";
            this.HouseHoldFormLastName.Size = new System.Drawing.Size(67, 13);
            this.HouseHoldFormLastName.TabIndex = 1;
            this.HouseHoldFormLastName.Text = "Last Name";
            // 
            // btnHouseholdMemberAdd
            // 
            this.btnHouseholdMemberAdd.BackColor = System.Drawing.Color.Teal;
            this.btnHouseholdMemberAdd.ForeColor = System.Drawing.Color.White;
            this.btnHouseholdMemberAdd.Location = new System.Drawing.Point(234, 353);
            this.btnHouseholdMemberAdd.Name = "btnHouseholdMemberAdd";
            this.btnHouseholdMemberAdd.Size = new System.Drawing.Size(75, 23);
            this.btnHouseholdMemberAdd.TabIndex = 8;
            this.btnHouseholdMemberAdd.Text = "Add";
            this.btnHouseholdMemberAdd.UseVisualStyleBackColor = false;
            this.btnHouseholdMemberAdd.Click += new System.EventHandler(this.HouseHoldAddButton_Click);
            // 
            // HouseHoldFormTitle
            // 
            this.HouseHoldFormTitle.AutoSize = true;
            this.HouseHoldFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormTitle.ForeColor = System.Drawing.Color.Teal;
            this.HouseHoldFormTitle.Location = new System.Drawing.Point(4, 4);
            this.HouseHoldFormTitle.Name = "HouseHoldFormTitle";
            this.HouseHoldFormTitle.Size = new System.Drawing.Size(282, 25);
            this.HouseHoldFormTitle.TabIndex = 0;
            this.HouseHoldFormTitle.Text = "HOUSEHOLD INFORMATION";
            // 
            // HouseHoldFormFirstName
            // 
            this.HouseHoldFormFirstName.AutoSize = true;
            this.HouseHoldFormFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHoldFormFirstName.ForeColor = System.Drawing.Color.Teal;
            this.HouseHoldFormFirstName.Location = new System.Drawing.Point(6, 41);
            this.HouseHoldFormFirstName.Name = "HouseHoldFormFirstName";
            this.HouseHoldFormFirstName.Size = new System.Drawing.Size(67, 13);
            this.HouseHoldFormFirstName.TabIndex = 0;
            this.HouseHoldFormFirstName.Text = "First Name";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(417, 382);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // HouseHoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 425);
            this.Controls.Add(this.title);
            this.Name = "HouseHoldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HouseHoldForm_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title;
        //private dBDataSetTableAdapters.BarriersToSubtypesTableAdapter barriersToSubtypesTableAdapter1;
        private System.Windows.Forms.Button btnHouseholdMemberAdd;
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
        private System.Windows.Forms.RadioButton HouseHoldFormRadioButtonNo;
        private System.Windows.Forms.RadioButton HouseHoldFormRadioButtonYes;
        private System.Windows.Forms.Label HouseHoldFormHealthCoverageRadioButton;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private DataSet1TableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.ListView HouseHoldForm_ListView_Summary;
        private System.Windows.Forms.ColumnHeader First;
        private System.Windows.Forms.ColumnHeader Last;
        private System.Windows.Forms.ColumnHeader SSN;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Relationship;
        private System.Windows.Forms.ColumnHeader Ethnicity;
        private System.Windows.Forms.ColumnHeader Coverage;
        private System.Windows.Forms.Button HouseHoldFormDoneButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
    }
}
