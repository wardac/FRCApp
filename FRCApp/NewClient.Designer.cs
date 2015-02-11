namespace FRCApp {
    partial class NewClient {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.middleInitial_label = new System.Windows.Forms.Label();
            this.dateOfBirth_label = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.middleInitial_textBox = new System.Windows.Forms.TextBox();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.dataOfBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeAddress_label = new System.Windows.Forms.Label();
            this.homeAddress_textBox = new System.Windows.Forms.TextBox();
            this.apartmentNumber_label = new System.Windows.Forms.Label();
            this.apartmentNumber_textBox = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.zipCode_label = new System.Windows.Forms.Label();
            this.zipCode_textBox = new System.Windows.Forms.TextBox();
            this.telephone1_label = new System.Windows.Forms.Label();
            this.telephone1_textBox = new System.Windows.Forms.TextBox();
            this.telephone2_label = new System.Windows.Forms.Label();
            this.telephone2_textBox = new System.Windows.Forms.TextBox();
            this.householdType_label = new System.Windows.Forms.Label();
            this.educationLevel_label = new System.Windows.Forms.Label();
            this.employmentStatus_label = new System.Windows.Forms.Label();
            this.referral_label = new System.Windows.Forms.Label();
            this.futureGoals_label = new System.Windows.Forms.Label();
            this.householdInfo_button = new System.Windows.Forms.Button();
            this.monthlyExpenses_button = new System.Windows.Forms.Button();
            this.emergencyFunds_button = new System.Windows.Forms.Button();
            this.householdIncome_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.HouseholdTypeBox = new System.Windows.Forms.ComboBox();
            this.householdTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FRCApp.DataSet1();
            this.householdTypesTableAdapter = new FRCApp.DataSet1TableAdapters.HouseholdTypesTableAdapter();
            this.EducationLevelBox = new System.Windows.Forms.ComboBox();
            this.educationLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationLevelsTableAdapter = new FRCApp.DataSet1TableAdapters.EducationLevelsTableAdapter();
            this.EmploymentStatusBox = new System.Windows.Forms.ComboBox();
            this.employmentStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employmentStatusesTableAdapter = new FRCApp.DataSet1TableAdapters.EmploymentStatusesTableAdapter();
            this.ReferralsBox = new System.Windows.Forms.CheckedListBox();
            this.referralTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referralTypesTableAdapter = new FRCApp.DataSet1TableAdapters.ReferralTypesTableAdapter();
            this.GoalsBox = new System.Windows.Forms.CheckedListBox();
            this.goalTypesTableAdapter = new FRCApp.DataSet1TableAdapters.GoalTypesTableAdapter();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.householdTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(51, 70);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(61, 13);
            this.lastName_label.TabIndex = 0;
            this.lastName_label.Text = "Last Name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(52, 18);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(60, 13);
            this.firstName_label.TabIndex = 0;
            this.firstName_label.Text = "First Name:";
            // 
            // middleInitial_label
            // 
            this.middleInitial_label.AutoSize = true;
            this.middleInitial_label.Location = new System.Drawing.Point(44, 44);
            this.middleInitial_label.Name = "middleInitial_label";
            this.middleInitial_label.Size = new System.Drawing.Size(68, 13);
            this.middleInitial_label.TabIndex = 0;
            this.middleInitial_label.Text = "Middle Initial:";
            // 
            // dateOfBirth_label
            // 
            this.dateOfBirth_label.AutoSize = true;
            this.dateOfBirth_label.Location = new System.Drawing.Point(43, 97);
            this.dateOfBirth_label.Name = "dateOfBirth_label";
            this.dateOfBirth_label.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirth_label.TabIndex = 0;
            this.dateOfBirth_label.Text = "Date of Birth:";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(117, 67);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(150, 20);
            this.lastName_textBox.TabIndex = 3;
            // 
            // middleInitial_textBox
            // 
            this.middleInitial_textBox.Location = new System.Drawing.Point(117, 41);
            this.middleInitial_textBox.Name = "middleInitial_textBox";
            this.middleInitial_textBox.Size = new System.Drawing.Size(47, 20);
            this.middleInitial_textBox.TabIndex = 2;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(117, 15);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(150, 20);
            this.firstName_textBox.TabIndex = 1;
            // 
            // dataOfBirth_dateTimePicker
            // 
            this.dataOfBirth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOfBirth_dateTimePicker.Location = new System.Drawing.Point(117, 93);
            this.dataOfBirth_dateTimePicker.Name = "dataOfBirth_dateTimePicker";
            this.dataOfBirth_dateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.dataOfBirth_dateTimePicker.TabIndex = 4;
            this.dataOfBirth_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // homeAddress_label
            // 
            this.homeAddress_label.AutoSize = true;
            this.homeAddress_label.Location = new System.Drawing.Point(64, 122);
            this.homeAddress_label.Name = "homeAddress_label";
            this.homeAddress_label.Size = new System.Drawing.Size(48, 13);
            this.homeAddress_label.TabIndex = 16;
            this.homeAddress_label.Text = "Address:";
            // 
            // homeAddress_textBox
            // 
            this.homeAddress_textBox.Location = new System.Drawing.Point(117, 119);
            this.homeAddress_textBox.Name = "homeAddress_textBox";
            this.homeAddress_textBox.Size = new System.Drawing.Size(598, 20);
            this.homeAddress_textBox.TabIndex = 5;
            this.homeAddress_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apartmentNumber_label
            // 
            this.apartmentNumber_label.AutoSize = true;
            this.apartmentNumber_label.Location = new System.Drawing.Point(44, 148);
            this.apartmentNumber_label.Name = "apartmentNumber_label";
            this.apartmentNumber_label.Size = new System.Drawing.Size(68, 13);
            this.apartmentNumber_label.TabIndex = 18;
            this.apartmentNumber_label.Text = "Apartment #:";
            // 
            // apartmentNumber_textBox
            // 
            this.apartmentNumber_textBox.Location = new System.Drawing.Point(117, 145);
            this.apartmentNumber_textBox.Name = "apartmentNumber_textBox";
            this.apartmentNumber_textBox.Size = new System.Drawing.Size(47, 20);
            this.apartmentNumber_textBox.TabIndex = 6;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(85, 174);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(27, 13);
            this.city_label.TabIndex = 20;
            this.city_label.Text = "City:";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(117, 171);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(150, 20);
            this.city_textBox.TabIndex = 7;
            // 
            // zipCode_label
            // 
            this.zipCode_label.AutoSize = true;
            this.zipCode_label.Location = new System.Drawing.Point(59, 200);
            this.zipCode_label.Name = "zipCode_label";
            this.zipCode_label.Size = new System.Drawing.Size(53, 13);
            this.zipCode_label.TabIndex = 22;
            this.zipCode_label.Text = "Zip Code:";
            // 
            // zipCode_textBox
            // 
            this.zipCode_textBox.Location = new System.Drawing.Point(117, 197);
            this.zipCode_textBox.Name = "zipCode_textBox";
            this.zipCode_textBox.Size = new System.Drawing.Size(150, 20);
            this.zipCode_textBox.TabIndex = 8;
            // 
            // telephone1_label
            // 
            this.telephone1_label.AutoSize = true;
            this.telephone1_label.Location = new System.Drawing.Point(62, 226);
            this.telephone1_label.Name = "telephone1_label";
            this.telephone1_label.Size = new System.Drawing.Size(50, 13);
            this.telephone1_label.TabIndex = 24;
            this.telephone1_label.Text = "Phone 1:";
            // 
            // telephone1_textBox
            // 
            this.telephone1_textBox.Location = new System.Drawing.Point(117, 223);
            this.telephone1_textBox.Name = "telephone1_textBox";
            this.telephone1_textBox.Size = new System.Drawing.Size(150, 20);
            this.telephone1_textBox.TabIndex = 9;
            // 
            // telephone2_label
            // 
            this.telephone2_label.AutoSize = true;
            this.telephone2_label.Location = new System.Drawing.Point(62, 249);
            this.telephone2_label.Name = "telephone2_label";
            this.telephone2_label.Size = new System.Drawing.Size(50, 13);
            this.telephone2_label.TabIndex = 26;
            this.telephone2_label.Text = "Phone 2:";
            // 
            // telephone2_textBox
            // 
            this.telephone2_textBox.Location = new System.Drawing.Point(117, 249);
            this.telephone2_textBox.Name = "telephone2_textBox";
            this.telephone2_textBox.Size = new System.Drawing.Size(150, 20);
            this.telephone2_textBox.TabIndex = 10;
            // 
            // householdType_label
            // 
            this.householdType_label.AutoSize = true;
            this.householdType_label.Location = new System.Drawing.Point(24, 278);
            this.householdType_label.Name = "householdType_label";
            this.householdType_label.Size = new System.Drawing.Size(88, 13);
            this.householdType_label.TabIndex = 28;
            this.householdType_label.Text = "Household Type:";
            // 
            // educationLevel_label
            // 
            this.educationLevel_label.AutoSize = true;
            this.educationLevel_label.Location = new System.Drawing.Point(25, 306);
            this.educationLevel_label.Name = "educationLevel_label";
            this.educationLevel_label.Size = new System.Drawing.Size(87, 13);
            this.educationLevel_label.TabIndex = 34;
            this.educationLevel_label.Text = "Education Level:";
            // 
            // employmentStatus_label
            // 
            this.employmentStatus_label.AutoSize = true;
            this.employmentStatus_label.Location = new System.Drawing.Point(12, 334);
            this.employmentStatus_label.Name = "employmentStatus_label";
            this.employmentStatus_label.Size = new System.Drawing.Size(100, 13);
            this.employmentStatus_label.TabIndex = 39;
            this.employmentStatus_label.Text = "Employment Status:";
            // 
            // referral_label
            // 
            this.referral_label.AutoSize = true;
            this.referral_label.Location = new System.Drawing.Point(19, 358);
            this.referral_label.Name = "referral_label";
            this.referral_label.Size = new System.Drawing.Size(93, 13);
            this.referral_label.TabIndex = 43;
            this.referral_label.Text = "Referrals Needed:";
            // 
            // futureGoals_label
            // 
            this.futureGoals_label.AutoSize = true;
            this.futureGoals_label.Location = new System.Drawing.Point(75, 488);
            this.futureGoals_label.Name = "futureGoals_label";
            this.futureGoals_label.Size = new System.Drawing.Size(37, 13);
            this.futureGoals_label.TabIndex = 57;
            this.futureGoals_label.Text = "Goals:";
            // 
            // householdInfo_button
            // 
            this.householdInfo_button.Location = new System.Drawing.Point(14, 618);
            this.householdInfo_button.Name = "householdInfo_button";
            this.householdInfo_button.Size = new System.Drawing.Size(149, 23);
            this.householdInfo_button.TabIndex = 16;
            this.householdInfo_button.Text = "Enter Household Information";
            this.householdInfo_button.UseVisualStyleBackColor = true;
            this.householdInfo_button.Click += new System.EventHandler(this.householdInfo_button_Click);
            // 
            // monthlyExpenses_button
            // 
            this.monthlyExpenses_button.Location = new System.Drawing.Point(173, 618);
            this.monthlyExpenses_button.Name = "monthlyExpenses_button";
            this.monthlyExpenses_button.Size = new System.Drawing.Size(134, 23);
            this.monthlyExpenses_button.TabIndex = 17;
            this.monthlyExpenses_button.Text = "Enter Monthly Expenses";
            this.monthlyExpenses_button.UseVisualStyleBackColor = true;
            this.monthlyExpenses_button.Click += new System.EventHandler(this.monthlyExpenses_button_Click);
            // 
            // emergencyFunds_button
            // 
            this.emergencyFunds_button.Location = new System.Drawing.Point(535, 618);
            this.emergencyFunds_button.Name = "emergencyFunds_button";
            this.emergencyFunds_button.Size = new System.Drawing.Size(180, 23);
            this.emergencyFunds_button.TabIndex = 19;
            this.emergencyFunds_button.Text = "New Emergency Funds Request";
            this.emergencyFunds_button.UseVisualStyleBackColor = true;
            // 
            // householdIncome_button
            // 
            this.householdIncome_button.Location = new System.Drawing.Point(313, 618);
            this.householdIncome_button.Name = "householdIncome_button";
            this.householdIncome_button.Size = new System.Drawing.Size(216, 23);
            this.householdIncome_button.TabIndex = 18;
            this.householdIncome_button.Text = "Enter Household Income and Finances";
            this.householdIncome_button.UseVisualStyleBackColor = true;
            this.householdIncome_button.Click += new System.EventHandler(this.householdIncome_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(327, 647);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 20;
            this.submit_button.Text = "Add Client";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // HouseholdTypeBox
            // 
            this.HouseholdTypeBox.DataSource = this.householdTypesBindingSource;
            this.HouseholdTypeBox.DisplayMember = "Type";
            this.HouseholdTypeBox.FormattingEnabled = true;
            this.HouseholdTypeBox.Location = new System.Drawing.Point(117, 275);
            this.HouseholdTypeBox.Name = "HouseholdTypeBox";
            this.HouseholdTypeBox.Size = new System.Drawing.Size(598, 21);
            this.HouseholdTypeBox.TabIndex = 11;
            this.HouseholdTypeBox.ValueMember = "HouseholdTypeID";
            // 
            // householdTypesBindingSource
            // 
            this.householdTypesBindingSource.DataMember = "HouseholdTypes";
            this.householdTypesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // householdTypesTableAdapter
            // 
            this.householdTypesTableAdapter.ClearBeforeFill = true;
            // 
            // EducationLevelBox
            // 
            this.EducationLevelBox.DataSource = this.educationLevelsBindingSource;
            this.EducationLevelBox.DisplayMember = "EducationLevel";
            this.EducationLevelBox.FormattingEnabled = true;
            this.EducationLevelBox.Location = new System.Drawing.Point(117, 303);
            this.EducationLevelBox.Name = "EducationLevelBox";
            this.EducationLevelBox.Size = new System.Drawing.Size(598, 21);
            this.EducationLevelBox.TabIndex = 12;
            this.EducationLevelBox.ValueMember = "EducationLevelID";
            // 
            // educationLevelsBindingSource
            // 
            this.educationLevelsBindingSource.DataMember = "EducationLevels";
            this.educationLevelsBindingSource.DataSource = this.dataSet1;
            // 
            // educationLevelsTableAdapter
            // 
            this.educationLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // EmploymentStatusBox
            // 
            this.EmploymentStatusBox.DataSource = this.employmentStatusesBindingSource;
            this.EmploymentStatusBox.DisplayMember = "EmploymentStatus";
            this.EmploymentStatusBox.FormattingEnabled = true;
            this.EmploymentStatusBox.Location = new System.Drawing.Point(117, 331);
            this.EmploymentStatusBox.Name = "EmploymentStatusBox";
            this.EmploymentStatusBox.Size = new System.Drawing.Size(598, 21);
            this.EmploymentStatusBox.TabIndex = 13;
            this.EmploymentStatusBox.ValueMember = "EmploymentStatusID";
            // 
            // employmentStatusesBindingSource
            // 
            this.employmentStatusesBindingSource.DataMember = "EmploymentStatuses";
            this.employmentStatusesBindingSource.DataSource = this.dataSet1;
            // 
            // employmentStatusesTableAdapter
            // 
            this.employmentStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // ReferralsBox
            // 
            this.ReferralsBox.FormattingEnabled = true;
            this.ReferralsBox.Location = new System.Drawing.Point(117, 358);
            this.ReferralsBox.Name = "ReferralsBox";
            this.ReferralsBox.Size = new System.Drawing.Size(598, 124);
            this.ReferralsBox.TabIndex = 14;
            // 
            // referralTypesBindingSource
            // 
            this.referralTypesBindingSource.DataMember = "ReferralTypes";
            this.referralTypesBindingSource.DataSource = this.dataSet1;
            // 
            // referralTypesTableAdapter
            // 
            this.referralTypesTableAdapter.ClearBeforeFill = true;
            // 
            // GoalsBox
            // 
            this.GoalsBox.FormattingEnabled = true;
            this.GoalsBox.Location = new System.Drawing.Point(117, 488);
            this.GoalsBox.Name = "GoalsBox";
            this.GoalsBox.Size = new System.Drawing.Size(598, 124);
            this.GoalsBox.TabIndex = 15;
            // 
            // goalTypesTableAdapter
            // 
            this.goalTypesTableAdapter.ClearBeforeFill = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(640, 647);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 58;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 675);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.GoalsBox);
            this.Controls.Add(this.ReferralsBox);
            this.Controls.Add(this.EmploymentStatusBox);
            this.Controls.Add(this.EducationLevelBox);
            this.Controls.Add(this.HouseholdTypeBox);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.householdIncome_button);
            this.Controls.Add(this.emergencyFunds_button);
            this.Controls.Add(this.monthlyExpenses_button);
            this.Controls.Add(this.householdInfo_button);
            this.Controls.Add(this.futureGoals_label);
            this.Controls.Add(this.referral_label);
            this.Controls.Add(this.employmentStatus_label);
            this.Controls.Add(this.educationLevel_label);
            this.Controls.Add(this.householdType_label);
            this.Controls.Add(this.telephone2_textBox);
            this.Controls.Add(this.telephone2_label);
            this.Controls.Add(this.telephone1_textBox);
            this.Controls.Add(this.telephone1_label);
            this.Controls.Add(this.zipCode_textBox);
            this.Controls.Add(this.zipCode_label);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.apartmentNumber_textBox);
            this.Controls.Add(this.apartmentNumber_label);
            this.Controls.Add(this.homeAddress_textBox);
            this.Controls.Add(this.homeAddress_label);
            this.Controls.Add(this.dataOfBirth_dateTimePicker);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.middleInitial_textBox);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.middleInitial_label);
            this.Controls.Add(this.dateOfBirth_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.lastName_label);
            this.Name = "NewClient";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.householdTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label middleInitial_label;
        private System.Windows.Forms.Label dateOfBirth_label;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox middleInitial_textBox;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.DateTimePicker dataOfBirth_dateTimePicker;
        private System.Windows.Forms.Label homeAddress_label;
        private System.Windows.Forms.TextBox homeAddress_textBox;
        private System.Windows.Forms.Label apartmentNumber_label;
        private System.Windows.Forms.TextBox apartmentNumber_textBox;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.Label zipCode_label;
        private System.Windows.Forms.TextBox zipCode_textBox;
        private System.Windows.Forms.Label telephone1_label;
        private System.Windows.Forms.TextBox telephone1_textBox;
        private System.Windows.Forms.Label telephone2_label;
        private System.Windows.Forms.TextBox telephone2_textBox;
        private System.Windows.Forms.Label householdType_label;
        private System.Windows.Forms.Label educationLevel_label;
        private System.Windows.Forms.Label employmentStatus_label;
        private System.Windows.Forms.Label referral_label;
        private System.Windows.Forms.Label futureGoals_label;
        private System.Windows.Forms.Button householdInfo_button;
        private System.Windows.Forms.Button monthlyExpenses_button;
        private System.Windows.Forms.Button emergencyFunds_button;
        private System.Windows.Forms.Button householdIncome_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ComboBox HouseholdTypeBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource householdTypesBindingSource;
        private DataSet1TableAdapters.HouseholdTypesTableAdapter householdTypesTableAdapter;
        private System.Windows.Forms.ComboBox EducationLevelBox;
        private System.Windows.Forms.BindingSource educationLevelsBindingSource;
        private DataSet1TableAdapters.EducationLevelsTableAdapter educationLevelsTableAdapter;
        private System.Windows.Forms.ComboBox EmploymentStatusBox;
        private System.Windows.Forms.BindingSource employmentStatusesBindingSource;
        private DataSet1TableAdapters.EmploymentStatusesTableAdapter employmentStatusesTableAdapter;
        private System.Windows.Forms.CheckedListBox ReferralsBox;
        private System.Windows.Forms.BindingSource referralTypesBindingSource;
        private DataSet1TableAdapters.ReferralTypesTableAdapter referralTypesTableAdapter;
        private System.Windows.Forms.CheckedListBox GoalsBox;
        private DataSet1TableAdapters.GoalTypesTableAdapter goalTypesTableAdapter;
        private System.Windows.Forms.Button cancelButton;
    }
}