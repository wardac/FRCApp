namespace FRCApp
{
    partial class EditHouseholdMemberInfo
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SocialLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.RelationshipLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.HealthCoverageLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SocialTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BirthDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.RelationshipTextBox = new System.Windows.Forms.TextBox();
            this.RaceBox = new System.Windows.Forms.ComboBox();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FRCApp.DataSet1();
            this.racesTableAdapter = new FRCApp.DataSet1TableAdapters.RacesTableAdapter();
            this.no_radio_button = new System.Windows.Forms.RadioButton();
            this.yes_radio_button = new System.Windows.Forms.RadioButton();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 13);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 50);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SocialLabel
            // 
            this.SocialLabel.AutoSize = true;
            this.SocialLabel.Location = new System.Drawing.Point(13, 87);
            this.SocialLabel.Name = "SocialLabel";
            this.SocialLabel.Size = new System.Drawing.Size(100, 13);
            this.SocialLabel.TabIndex = 2;
            this.SocialLabel.Text = "Last 4 digits of SSN";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(13, 124);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(54, 13);
            this.BirthDateLabel.TabIndex = 3;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // RelationshipLabel
            // 
            this.RelationshipLabel.AutoSize = true;
            this.RelationshipLabel.Location = new System.Drawing.Point(13, 161);
            this.RelationshipLabel.Name = "RelationshipLabel";
            this.RelationshipLabel.Size = new System.Drawing.Size(124, 13);
            this.RelationshipLabel.TabIndex = 4;
            this.RelationshipLabel.Text = "Relationship to Applicant";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(13, 198);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(78, 13);
            this.RaceLabel.TabIndex = 5;
            this.RaceLabel.Text = "Ethnicity/Race";
            // 
            // HealthCoverageLabel
            // 
            this.HealthCoverageLabel.AutoSize = true;
            this.HealthCoverageLabel.Location = new System.Drawing.Point(13, 235);
            this.HealthCoverageLabel.Name = "HealthCoverageLabel";
            this.HealthCoverageLabel.Size = new System.Drawing.Size(87, 13);
            this.HealthCoverageLabel.TabIndex = 6;
            this.HealthCoverageLabel.Text = "Health Coverage";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(156, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.FirstNameTextBox.TabIndex = 7;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(156, 47);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // SocialTextBox
            // 
            this.SocialTextBox.Location = new System.Drawing.Point(156, 84);
            this.SocialTextBox.Mask = "0000";
            this.SocialTextBox.Name = "SocialTextBox";
            this.SocialTextBox.Size = new System.Drawing.Size(31, 20);
            this.SocialTextBox.TabIndex = 9;
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.Location = new System.Drawing.Point(156, 118);
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.Size = new System.Drawing.Size(196, 20);
            this.BirthDateTextBox.TabIndex = 10;
            // 
            // RelationshipTextBox
            // 
            this.RelationshipTextBox.Location = new System.Drawing.Point(156, 158);
            this.RelationshipTextBox.Name = "RelationshipTextBox";
            this.RelationshipTextBox.Size = new System.Drawing.Size(196, 20);
            this.RelationshipTextBox.TabIndex = 11;
            // 
            // RaceBox
            // 
            this.RaceBox.DataSource = this.racesBindingSource;
            this.RaceBox.DisplayMember = "Race";
            this.RaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Location = new System.Drawing.Point(156, 195);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(196, 21);
            this.RaceBox.TabIndex = 17;
            this.RaceBox.ValueMember = "Race";
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.dataSet1BindingSource;
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
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // no_radio_button
            // 
            this.no_radio_button.AutoSize = true;
            this.no_radio_button.ForeColor = System.Drawing.Color.Teal;
            this.no_radio_button.Location = new System.Drawing.Point(215, 233);
            this.no_radio_button.Name = "no_radio_button";
            this.no_radio_button.Size = new System.Drawing.Size(39, 17);
            this.no_radio_button.TabIndex = 66;
            this.no_radio_button.TabStop = true;
            this.no_radio_button.Text = "No";
            this.no_radio_button.UseVisualStyleBackColor = true;
            // 
            // yes_radio_button
            // 
            this.yes_radio_button.AutoSize = true;
            this.yes_radio_button.ForeColor = System.Drawing.Color.Teal;
            this.yes_radio_button.Location = new System.Drawing.Point(156, 233);
            this.yes_radio_button.Name = "yes_radio_button";
            this.yes_radio_button.Size = new System.Drawing.Size(43, 17);
            this.yes_radio_button.TabIndex = 65;
            this.yes_radio_button.TabStop = true;
            this.yes_radio_button.Text = "Yes";
            this.yes_radio_button.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(97, 277);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 67;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(184, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 68;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditHouseholdMemberInfo
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 312);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.no_radio_button);
            this.Controls.Add(this.yes_radio_button);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.RelationshipTextBox);
            this.Controls.Add(this.BirthDateTextBox);
            this.Controls.Add(this.SocialTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.HealthCoverageLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RelationshipLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.SocialLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "EditHouseholdMemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditHouseholdMemberInfo";
            this.Load += new System.EventHandler(this.EditHouseholdMemberInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SocialLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label RelationshipLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label HealthCoverageLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.MaskedTextBox SocialTextBox;
        private System.Windows.Forms.DateTimePicker BirthDateTextBox;
        private System.Windows.Forms.TextBox RelationshipTextBox;
        private System.Windows.Forms.ComboBox RaceBox;
        private System.Windows.Forms.RadioButton no_radio_button;
        private System.Windows.Forms.RadioButton yes_radio_button;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CancelButton;
        private DataSet1TableAdapters.RacesTableAdapter racesTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource racesBindingSource;

    }
}