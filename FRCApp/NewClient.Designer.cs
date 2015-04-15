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
            this.telephone1_label = new System.Windows.Forms.Label();
            this.telephone2_label = new System.Windows.Forms.Label();
            this.householdType_label = new System.Windows.Forms.Label();
            this.educationLevel_label = new System.Windows.Forms.Label();
            this.employmentStatus_label = new System.Windows.Forms.Label();
            this.referral_label = new System.Windows.Forms.Label();
            this.futureGoals_label = new System.Windows.Forms.Label();
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
            this.email_label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.telephone1_textBox = new System.Windows.Forms.MaskedTextBox();
            this.telephone2_textBox = new System.Windows.Forms.MaskedTextBox();
            this.zipCode_textBox = new System.Windows.Forms.MaskedTextBox();
            this.social_label = new System.Windows.Forms.Label();
            this.social_textbox = new System.Windows.Forms.MaskedTextBox();
            this.health_coverage_label = new System.Windows.Forms.Label();
            this.yes_radio_button = new System.Windows.Forms.RadioButton();
            this.no_radio_button = new System.Windows.Forms.RadioButton();
            this.race_label = new System.Windows.Forms.Label();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesTableAdapter = new FRCApp.DataSet1TableAdapters.RacesTableAdapter();
            this.RaceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.householdTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(51, 18);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(61, 13);
            this.lastName_label.TabIndex = 0;
            this.lastName_label.Text = "Last Name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(335, 18);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(60, 13);
            this.firstName_label.TabIndex = 0;
            this.firstName_label.Text = "First Name:";
            // 
            // middleInitial_label
            // 
            this.middleInitial_label.AutoSize = true;
            this.middleInitial_label.Location = new System.Drawing.Point(594, 18);
            this.middleInitial_label.Name = "middleInitial_label";
            this.middleInitial_label.Size = new System.Drawing.Size(68, 13);
            this.middleInitial_label.TabIndex = 0;
            this.middleInitial_label.Text = "Middle Initial:";
            // 
            // dateOfBirth_label
            // 
            this.dateOfBirth_label.AutoSize = true;
            this.dateOfBirth_label.Location = new System.Drawing.Point(43, 45);
            this.dateOfBirth_label.Name = "dateOfBirth_label";
            this.dateOfBirth_label.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirth_label.TabIndex = 0;
            this.dateOfBirth_label.Text = "Date of Birth:";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(117, 15);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(212, 20);
            this.lastName_textBox.TabIndex = 1;
            // 
            // middleInitial_textBox
            // 
            this.middleInitial_textBox.Location = new System.Drawing.Point(667, 15);
            this.middleInitial_textBox.Name = "middleInitial_textBox";
            this.middleInitial_textBox.Size = new System.Drawing.Size(48, 20);
            this.middleInitial_textBox.TabIndex = 3;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(400, 15);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(189, 20);
            this.firstName_textBox.TabIndex = 2;
            // 
            // dataOfBirth_dateTimePicker
            // 
            this.dataOfBirth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOfBirth_dateTimePicker.Location = new System.Drawing.Point(117, 41);
            this.dataOfBirth_dateTimePicker.Name = "dataOfBirth_dateTimePicker";
            this.dataOfBirth_dateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.dataOfBirth_dateTimePicker.TabIndex = 4;
            // 
            // homeAddress_label
            // 
            this.homeAddress_label.AutoSize = true;
            this.homeAddress_label.Location = new System.Drawing.Point(64, 70);
            this.homeAddress_label.Name = "homeAddress_label";
            this.homeAddress_label.Size = new System.Drawing.Size(48, 13);
            this.homeAddress_label.TabIndex = 16;
            this.homeAddress_label.Text = "Address:";
            // 
            // homeAddress_textBox
            // 
            this.homeAddress_textBox.Location = new System.Drawing.Point(117, 67);
            this.homeAddress_textBox.Name = "homeAddress_textBox";
            this.homeAddress_textBox.Size = new System.Drawing.Size(462, 20);
            this.homeAddress_textBox.TabIndex = 6;
            // 
            // apartmentNumber_label
            // 
            this.apartmentNumber_label.AutoSize = true;
            this.apartmentNumber_label.Location = new System.Drawing.Point(585, 70);
            this.apartmentNumber_label.Name = "apartmentNumber_label";
            this.apartmentNumber_label.Size = new System.Drawing.Size(68, 13);
            this.apartmentNumber_label.TabIndex = 18;
            this.apartmentNumber_label.Text = "Apartment #:";
            // 
            // apartmentNumber_textBox
            // 
            this.apartmentNumber_textBox.Location = new System.Drawing.Point(659, 67);
            this.apartmentNumber_textBox.Name = "apartmentNumber_textBox";
            this.apartmentNumber_textBox.Size = new System.Drawing.Size(56, 20);
            this.apartmentNumber_textBox.TabIndex = 7;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(85, 96);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(27, 13);
            this.city_label.TabIndex = 20;
            this.city_label.Text = "City:";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(117, 93);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(150, 20);
            this.city_textBox.TabIndex = 8;
            // 
            // zipCode_label
            // 
            this.zipCode_label.AutoSize = true;
            this.zipCode_label.Location = new System.Drawing.Point(273, 96);
            this.zipCode_label.Name = "zipCode_label";
            this.zipCode_label.Size = new System.Drawing.Size(53, 13);
            this.zipCode_label.TabIndex = 22;
            this.zipCode_label.Text = "Zip Code:";
            // 
            // telephone1_label
            // 
            this.telephone1_label.AutoSize = true;
            this.telephone1_label.Location = new System.Drawing.Point(62, 122);
            this.telephone1_label.Name = "telephone1_label";
            this.telephone1_label.Size = new System.Drawing.Size(50, 13);
            this.telephone1_label.TabIndex = 24;
            this.telephone1_label.Text = "Phone 1:";
            // 
            // telephone2_label
            // 
            this.telephone2_label.AutoSize = true;
            this.telephone2_label.Location = new System.Drawing.Point(207, 122);
            this.telephone2_label.Name = "telephone2_label";
            this.telephone2_label.Size = new System.Drawing.Size(50, 13);
            this.telephone2_label.TabIndex = 26;
            this.telephone2_label.Text = "Phone 2:";
            // 
            // householdType_label
            // 
            this.householdType_label.AutoSize = true;
            this.householdType_label.Location = new System.Drawing.Point(24, 179);
            this.householdType_label.Name = "householdType_label";
            this.householdType_label.Size = new System.Drawing.Size(88, 13);
            this.householdType_label.TabIndex = 28;
            this.householdType_label.Text = "Household Type:";
            // 
            // educationLevel_label
            // 
            this.educationLevel_label.AutoSize = true;
            this.educationLevel_label.Location = new System.Drawing.Point(25, 206);
            this.educationLevel_label.Name = "educationLevel_label";
            this.educationLevel_label.Size = new System.Drawing.Size(87, 13);
            this.educationLevel_label.TabIndex = 34;
            this.educationLevel_label.Text = "Education Level:";
            // 
            // employmentStatus_label
            // 
            this.employmentStatus_label.AutoSize = true;
            this.employmentStatus_label.Location = new System.Drawing.Point(12, 233);
            this.employmentStatus_label.Name = "employmentStatus_label";
            this.employmentStatus_label.Size = new System.Drawing.Size(100, 13);
            this.employmentStatus_label.TabIndex = 39;
            this.employmentStatus_label.Text = "Employment Status:";
            // 
            // referral_label
            // 
            this.referral_label.AutoSize = true;
            this.referral_label.Location = new System.Drawing.Point(19, 287);
            this.referral_label.Name = "referral_label";
            this.referral_label.Size = new System.Drawing.Size(93, 13);
            this.referral_label.TabIndex = 43;
            this.referral_label.Text = "Referrals Needed:";
            // 
            // futureGoals_label
            // 
            this.futureGoals_label.AutoSize = true;
            this.futureGoals_label.Location = new System.Drawing.Point(75, 417);
            this.futureGoals_label.Name = "futureGoals_label";
            this.futureGoals_label.Size = new System.Drawing.Size(37, 13);
            this.futureGoals_label.TabIndex = 57;
            this.futureGoals_label.Text = "Goals:";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(327, 546);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 19;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // HouseholdTypeBox
            // 
            this.HouseholdTypeBox.DataSource = this.householdTypesBindingSource;
            this.HouseholdTypeBox.DisplayMember = "Type";
            this.HouseholdTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HouseholdTypeBox.FormattingEnabled = true;
            this.HouseholdTypeBox.Location = new System.Drawing.Point(117, 176);
            this.HouseholdTypeBox.Name = "HouseholdTypeBox";
            this.HouseholdTypeBox.Size = new System.Drawing.Size(598, 21);
            this.HouseholdTypeBox.TabIndex = 13;
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
            this.EducationLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationLevelBox.FormattingEnabled = true;
            this.EducationLevelBox.Location = new System.Drawing.Point(117, 203);
            this.EducationLevelBox.Name = "EducationLevelBox";
            this.EducationLevelBox.Size = new System.Drawing.Size(598, 21);
            this.EducationLevelBox.TabIndex = 14;
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
            this.EmploymentStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmploymentStatusBox.FormattingEnabled = true;
            this.EmploymentStatusBox.Location = new System.Drawing.Point(117, 230);
            this.EmploymentStatusBox.Name = "EmploymentStatusBox";
            this.EmploymentStatusBox.Size = new System.Drawing.Size(598, 21);
            this.EmploymentStatusBox.TabIndex = 15;
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
            this.ReferralsBox.Location = new System.Drawing.Point(117, 287);
            this.ReferralsBox.Name = "ReferralsBox";
            this.ReferralsBox.Size = new System.Drawing.Size(598, 124);
            this.ReferralsBox.TabIndex = 17;
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
            this.GoalsBox.Location = new System.Drawing.Point(117, 417);
            this.GoalsBox.Name = "GoalsBox";
            this.GoalsBox.Size = new System.Drawing.Size(598, 124);
            this.GoalsBox.TabIndex = 18;
            // 
            // goalTypesTableAdapter
            // 
            this.goalTypesTableAdapter.ClearBeforeFill = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(640, 546);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(77, 153);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 59;
            this.email_label.Text = "Email:";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(117, 150);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(262, 20);
            this.email_textBox.TabIndex = 12;
            // 
            // telephone1_textBox
            // 
            this.telephone1_textBox.Location = new System.Drawing.Point(118, 119);
            this.telephone1_textBox.Mask = "(999) 000-0000";
            this.telephone1_textBox.Name = "telephone1_textBox";
            this.telephone1_textBox.Size = new System.Drawing.Size(83, 20);
            this.telephone1_textBox.TabIndex = 10;
            // 
            // telephone2_textBox
            // 
            this.telephone2_textBox.Location = new System.Drawing.Point(263, 119);
            this.telephone2_textBox.Mask = "(999) 000-0000";
            this.telephone2_textBox.Name = "telephone2_textBox";
            this.telephone2_textBox.Size = new System.Drawing.Size(81, 20);
            this.telephone2_textBox.TabIndex = 11;
            // 
            // zipCode_textBox
            // 
            this.zipCode_textBox.Location = new System.Drawing.Point(332, 93);
            this.zipCode_textBox.Mask = "00000";
            this.zipCode_textBox.Name = "zipCode_textBox";
            this.zipCode_textBox.Size = new System.Drawing.Size(35, 20);
            this.zipCode_textBox.TabIndex = 9;
            this.zipCode_textBox.ValidatingType = typeof(int);
            // 
            // social_label
            // 
            this.social_label.AutoSize = true;
            this.social_label.Location = new System.Drawing.Point(273, 45);
            this.social_label.Name = "social_label";
            this.social_label.Size = new System.Drawing.Size(103, 13);
            this.social_label.TabIndex = 60;
            this.social_label.Text = "Last 4 digits of SSN:";
            // 
            // social_textbox
            // 
            this.social_textbox.Location = new System.Drawing.Point(382, 41);
            this.social_textbox.Mask = "0000";
            this.social_textbox.Name = "social_textbox";
            this.social_textbox.Size = new System.Drawing.Size(31, 20);
            this.social_textbox.TabIndex = 5;
            // 
            // health_coverage_label
            // 
            this.health_coverage_label.AutoSize = true;
            this.health_coverage_label.Location = new System.Drawing.Point(420, 45);
            this.health_coverage_label.Name = "health_coverage_label";
            this.health_coverage_label.Size = new System.Drawing.Size(115, 13);
            this.health_coverage_label.TabIndex = 62;
            this.health_coverage_label.Text = "Health Care Coverage:";
            // 
            // yes_radio_button
            // 
            this.yes_radio_button.AutoSize = true;
            this.yes_radio_button.Location = new System.Drawing.Point(542, 43);
            this.yes_radio_button.Name = "yes_radio_button";
            this.yes_radio_button.Size = new System.Drawing.Size(43, 17);
            this.yes_radio_button.TabIndex = 63;
            this.yes_radio_button.TabStop = true;
            this.yes_radio_button.Text = "Yes";
            this.yes_radio_button.UseVisualStyleBackColor = true;
            // 
            // no_radio_button
            // 
            this.no_radio_button.AutoSize = true;
            this.no_radio_button.Location = new System.Drawing.Point(592, 43);
            this.no_radio_button.Name = "no_radio_button";
            this.no_radio_button.Size = new System.Drawing.Size(39, 17);
            this.no_radio_button.TabIndex = 64;
            this.no_radio_button.TabStop = true;
            this.no_radio_button.Text = "No";
            this.no_radio_button.UseVisualStyleBackColor = true;
            // 
            // race_label
            // 
            this.race_label.AutoSize = true;
            this.race_label.Location = new System.Drawing.Point(31, 264);
            this.race_label.Name = "race_label";
            this.race_label.Size = new System.Drawing.Size(81, 13);
            this.race_label.TabIndex = 66;
            this.race_label.Text = "Ethnicity/Race:";
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.dataSet1;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // RaceBox
            // 
            this.RaceBox.DataSource = this.racesBindingSource;
            this.RaceBox.DisplayMember = "Race";
            this.RaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Location = new System.Drawing.Point(117, 260);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(598, 21);
            this.RaceBox.TabIndex = 16;
            this.RaceBox.ValueMember = "Race";
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 579);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.race_label);
            this.Controls.Add(this.no_radio_button);
            this.Controls.Add(this.yes_radio_button);
            this.Controls.Add(this.health_coverage_label);
            this.Controls.Add(this.social_textbox);
            this.Controls.Add(this.social_label);
            this.Controls.Add(this.zipCode_textBox);
            this.Controls.Add(this.telephone2_textBox);
            this.Controls.Add(this.telephone1_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.GoalsBox);
            this.Controls.Add(this.ReferralsBox);
            this.Controls.Add(this.EmploymentStatusBox);
            this.Controls.Add(this.EducationLevelBox);
            this.Controls.Add(this.HouseholdTypeBox);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.futureGoals_label);
            this.Controls.Add(this.referral_label);
            this.Controls.Add(this.employmentStatus_label);
            this.Controls.Add(this.educationLevel_label);
            this.Controls.Add(this.householdType_label);
            this.Controls.Add(this.telephone2_label);
            this.Controls.Add(this.telephone1_label);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.householdTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
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
        private System.Windows.Forms.Label telephone1_label;
        private System.Windows.Forms.Label telephone2_label;
        private System.Windows.Forms.Label householdType_label;
        private System.Windows.Forms.Label educationLevel_label;
        private System.Windows.Forms.Label employmentStatus_label;
        private System.Windows.Forms.Label referral_label;
        private System.Windows.Forms.Label futureGoals_label;
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
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.MaskedTextBox telephone1_textBox;
        private System.Windows.Forms.MaskedTextBox telephone2_textBox;
        private System.Windows.Forms.MaskedTextBox zipCode_textBox;
        private System.Windows.Forms.Label social_label;
        private System.Windows.Forms.MaskedTextBox social_textbox;
        private System.Windows.Forms.Label health_coverage_label;
        private System.Windows.Forms.RadioButton yes_radio_button;
        private System.Windows.Forms.RadioButton no_radio_button;
        private System.Windows.Forms.Label race_label;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private DataSet1TableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.ComboBox RaceBox;
    }
}