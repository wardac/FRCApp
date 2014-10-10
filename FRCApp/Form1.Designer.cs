namespace FRCApp
{
    partial class Form1
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
            System.Windows.Forms.TabControl TabControl;
            this.Main = new System.Windows.Forms.TabPage();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.efa_tab = new System.Windows.Forms.TabPage();
            this.fc_tab = new System.Windows.Forms.TabPage();
            this.TS = new System.Windows.Forms.TabPage();
            this.fc = new FRCApp.fc_tab();
            this.ow = new FRCApp.ow_tab();
            this.efatab = new FRCApp.efa_tab();
            TabControl = new System.Windows.Forms.TabControl();
            TabControl.SuspendLayout();
            this.Main.SuspendLayout();
            this.fc_tab.SuspendLayout();
            this.TS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(this.Main);
            TabControl.Controls.Add(this.efa_tab);
            TabControl.Controls.Add(this.fc_tab);
            TabControl.Controls.Add(this.TS);
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(1099, 532);
            TabControl.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.lstClients);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.panel1);
            this.Main.Controls.Add(this.button2);
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.textBox1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1091, 506);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(9, 40);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(339, 173);
            this.lstClients.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Details";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(355, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 209);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Case History";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 182);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "New Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Lookup:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // efa_tab
            // 
            //added this
            this.efa_tab.Controls.Add(this.efatab);
            this.efa_tab.Location = new System.Drawing.Point(4, 22);
            this.efa_tab.Name = "efa_tab";
            this.efa_tab.Size = new System.Drawing.Size(1091, 506);
            this.efa_tab.TabIndex = 3;
            this.efa_tab.Text = "EFA";
            this.efa_tab.UseVisualStyleBackColor = true;
            // 
            // fc_tab
            // 
            this.fc_tab.Controls.Add(this.fc);
            this.fc_tab.Location = new System.Drawing.Point(4, 22);
            this.fc_tab.Name = "fc_tab";
            this.fc_tab.Padding = new System.Windows.Forms.Padding(3);
            this.fc_tab.Size = new System.Drawing.Size(1091, 506);
            this.fc_tab.TabIndex = 2;
            this.fc_tab.Text = "FC";
            this.fc_tab.UseVisualStyleBackColor = true;
            // 
            // TS
            // 
            this.TS.Controls.Add(this.ow);
            this.TS.Location = new System.Drawing.Point(4, 22);
            this.TS.Name = "TS";
            this.TS.Padding = new System.Windows.Forms.Padding(3);
            this.TS.Size = new System.Drawing.Size(1091, 506);
            this.TS.TabIndex = 1;
            this.TS.Text = "OW";
            this.TS.UseVisualStyleBackColor = true;
            // 
            // fc
            // 
            this.fc.Location = new System.Drawing.Point(0, 3);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(745, 529);
            this.fc.TabIndex = 0;
            this.fc.Load += new System.EventHandler(this.fc_Load);
            // 
            // ow
            // 
            this.ow.Location = new System.Drawing.Point(0, 0);
            this.ow.Name = "ow";
            this.ow.Size = new System.Drawing.Size(883, 500);
            this.ow.TabIndex = 0;
            this.ow.Load += new System.EventHandler(this.ow_Load);
            // 
            // efatab
            // 
            this.efatab.Location = new System.Drawing.Point(0, 0);
            this.efatab.Name = "efatab";
            this.efatab.Size = new System.Drawing.Size(1095, 546);
            this.efatab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 556);
            this.Controls.Add(TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            TabControl.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.fc_tab.ResumeLayout(false);
            this.TS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage fc_tab;
        private fc_tab fc;
        private System.Windows.Forms.TabPage TS;
        private ow_tab ow;
        private System.Windows.Forms.TabPage Main;
      //  private System.Windows.Forms.TabPage EFA;
        //added this
        private System.Windows.Forms.TabPage efa_tab;
        private efa_tab efatab;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstClients;

    }
}

