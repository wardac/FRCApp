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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EFA = new System.Windows.Forms.TabPage();
            this.fc_tab = new System.Windows.Forms.TabPage();
            this.fc = new FRCApp.fc_tab();
            this.TS = new System.Windows.Forms.TabPage();
            this.ow = new FRCApp.ow_tab();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            TabControl.Controls.Add(this.EFA);
            TabControl.Controls.Add(this.fc_tab);
            TabControl.Controls.Add(this.TS);
            TabControl.Location = new System.Drawing.Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(872, 455);
            TabControl.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.button2);
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.textBox1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(864, 429);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
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
            // EFA
            // 
            this.EFA.Location = new System.Drawing.Point(4, 22);
            this.EFA.Name = "EFA";
            this.EFA.Size = new System.Drawing.Size(864, 429);
            this.EFA.TabIndex = 3;
            this.EFA.Text = "EFA";
            this.EFA.UseVisualStyleBackColor = true;
            // 
            // fc_tab
            // 
            this.fc_tab.Controls.Add(this.fc);
            this.fc_tab.Location = new System.Drawing.Point(4, 22);
            this.fc_tab.Name = "fc_tab";
            this.fc_tab.Padding = new System.Windows.Forms.Padding(3);
            this.fc_tab.Size = new System.Drawing.Size(864, 429);
            this.fc_tab.TabIndex = 2;
            this.fc_tab.Text = "FC";
            this.fc_tab.UseVisualStyleBackColor = true;
            // 
            // fc
            // 
            this.fc.Location = new System.Drawing.Point(0, 0);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(745, 529);
            this.fc.TabIndex = 0;
            this.fc.Load += new System.EventHandler(this.fc_Load);
            // 
            // TS
            // 
            this.TS.Controls.Add(this.ow);
            this.TS.Location = new System.Drawing.Point(4, 22);
            this.TS.Name = "TS";
            this.TS.Padding = new System.Windows.Forms.Padding(3);
            this.TS.Size = new System.Drawing.Size(864, 429);
            this.TS.TabIndex = 1;
            this.TS.Text = "OW";
            this.TS.UseVisualStyleBackColor = true;
            // 
            // ow
            // 
            this.ow.Location = new System.Drawing.Point(0, 0);
            this.ow.Name = "ow";
            this.ow.Size = new System.Drawing.Size(847, 569);
            this.ow.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 708);
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
        private System.Windows.Forms.TabPage EFA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}

