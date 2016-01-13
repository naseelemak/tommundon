namespace Tommundon
{
    partial class PatientForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.PatientSelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayLeftTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IllnessLevelTextBox = new System.Windows.Forms.TextBox();
            this.ShareWardYesCheckBox = new System.Windows.Forms.CheckBox();
            this.ShareWardNoCheckBox = new System.Windows.Forms.CheckBox();
            this.CriticalYesCheckBox = new System.Windows.Forms.CheckBox();
            this.CriticalNoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DonePictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DischargeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WardTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonePictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Home";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HomePictureBox);
            this.panel1.Location = new System.Drawing.Point(131, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePictureBox.BackgroundImage = global::Tommundon.Properties.Resources.home;
            this.HomePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomePictureBox.Location = new System.Drawing.Point(0, 0);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(60, 60);
            this.HomePictureBox.TabIndex = 6;
            this.HomePictureBox.TabStop = false;
            this.HomePictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PatientSelectionBox
            // 
            this.PatientSelectionBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientSelectionBox.FormattingEnabled = true;
            this.PatientSelectionBox.Items.AddRange(new object[] {
            "Add",
            "Search",
            "Discharge",
            "Delete"});
            this.PatientSelectionBox.Location = new System.Drawing.Point(9, 3);
            this.PatientSelectionBox.Name = "PatientSelectionBox";
            this.PatientSelectionBox.Size = new System.Drawing.Size(219, 21);
            this.PatientSelectionBox.TabIndex = 0;
            this.PatientSelectionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Location = new System.Drawing.Point(76, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(152, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Day Left";
            // 
            // DayLeftTextBox
            // 
            this.DayLeftTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DayLeftTextBox.Location = new System.Drawing.Point(76, 90);
            this.DayLeftTextBox.Name = "DayLeftTextBox";
            this.DayLeftTextBox.Size = new System.Drawing.Size(152, 20);
            this.DayLeftTextBox.TabIndex = 3;
            this.DayLeftTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IDTextBox.Location = new System.Drawing.Point(76, 31);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(152, 20);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Critical";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Illness Level";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Share Ward";
            // 
            // IllnessLevelTextBox
            // 
            this.IllnessLevelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IllnessLevelTextBox.Location = new System.Drawing.Point(77, 191);
            this.IllnessLevelTextBox.Name = "IllnessLevelTextBox";
            this.IllnessLevelTextBox.Size = new System.Drawing.Size(152, 20);
            this.IllnessLevelTextBox.TabIndex = 7;
            this.IllnessLevelTextBox.TextChanged += new System.EventHandler(this.IllnessLevelTextBox_TextChanged);
            // 
            // ShareWardYesCheckBox
            // 
            this.ShareWardYesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShareWardYesCheckBox.AutoSize = true;
            this.ShareWardYesCheckBox.Location = new System.Drawing.Point(76, 216);
            this.ShareWardYesCheckBox.Name = "ShareWardYesCheckBox";
            this.ShareWardYesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.ShareWardYesCheckBox.TabIndex = 8;
            this.ShareWardYesCheckBox.Text = "Yes";
            this.ShareWardYesCheckBox.UseVisualStyleBackColor = true;
            this.ShareWardYesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ShareWardNoCheckBox
            // 
            this.ShareWardNoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShareWardNoCheckBox.AutoSize = true;
            this.ShareWardNoCheckBox.Location = new System.Drawing.Point(126, 215);
            this.ShareWardNoCheckBox.Name = "ShareWardNoCheckBox";
            this.ShareWardNoCheckBox.Size = new System.Drawing.Size(40, 17);
            this.ShareWardNoCheckBox.TabIndex = 9;
            this.ShareWardNoCheckBox.Text = "No";
            this.ShareWardNoCheckBox.UseVisualStyleBackColor = true;
            this.ShareWardNoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CriticalYesCheckBox
            // 
            this.CriticalYesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriticalYesCheckBox.AutoSize = true;
            this.CriticalYesCheckBox.Location = new System.Drawing.Point(76, 168);
            this.CriticalYesCheckBox.Name = "CriticalYesCheckBox";
            this.CriticalYesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.CriticalYesCheckBox.TabIndex = 5;
            this.CriticalYesCheckBox.Text = "Yes";
            this.CriticalYesCheckBox.UseVisualStyleBackColor = true;
            this.CriticalYesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // CriticalNoCheckBox
            // 
            this.CriticalNoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriticalNoCheckBox.AutoSize = true;
            this.CriticalNoCheckBox.Location = new System.Drawing.Point(126, 168);
            this.CriticalNoCheckBox.Name = "CriticalNoCheckBox";
            this.CriticalNoCheckBox.Size = new System.Drawing.Size(40, 17);
            this.CriticalNoCheckBox.TabIndex = 6;
            this.CriticalNoCheckBox.Text = "No";
            this.CriticalNoCheckBox.UseVisualStyleBackColor = true;
            this.CriticalNoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DonePictureBox);
            this.panel2.Location = new System.Drawing.Point(65, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 60);
            this.panel2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Done";
            // 
            // DonePictureBox
            // 
            this.DonePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DonePictureBox.BackgroundImage = global::Tommundon.Properties.Resources.done;
            this.DonePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DonePictureBox.Location = new System.Drawing.Point(0, 0);
            this.DonePictureBox.Name = "DonePictureBox";
            this.DonePictureBox.Size = new System.Drawing.Size(60, 60);
            this.DonePictureBox.TabIndex = 6;
            this.DonePictureBox.TabStop = false;
            this.DonePictureBox.Click += new System.EventHandler(this.DonePictureBox_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.DischargeLabel);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.WardTextBox);
            this.panel3.Controls.Add(this.PatientSelectionBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NameTextBox);
            this.panel3.Controls.Add(this.CriticalNoCheckBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.CriticalYesCheckBox);
            this.panel3.Controls.Add(this.DayLeftTextBox);
            this.panel3.Controls.Add(this.ShareWardNoCheckBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ShareWardYesCheckBox);
            this.panel3.Controls.Add(this.IDTextBox);
            this.panel3.Controls.Add(this.IllnessLevelTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 271);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // DischargeLabel
            // 
            this.DischargeLabel.AutoSize = true;
            this.DischargeLabel.Location = new System.Drawing.Point(73, 146);
            this.DischargeLabel.Name = "DischargeLabel";
            this.DischargeLabel.Size = new System.Drawing.Size(21, 13);
            this.DischargeLabel.TabIndex = 30;
            this.DischargeLabel.Text = "No";
            this.DischargeLabel.Click += new System.EventHandler(this.DischargeLabel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Discharge";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ward";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // WardTextBox
            // 
            this.WardTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WardTextBox.Location = new System.Drawing.Point(76, 118);
            this.WardTextBox.Name = "WardTextBox";
            this.WardTextBox.Size = new System.Drawing.Size(152, 20);
            this.WardTextBox.TabIndex = 4;
            this.WardTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Patient";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.Size = new System.Drawing.Size(256, 387);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonePictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox PatientSelectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DayLeftTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IllnessLevelTextBox;
        private System.Windows.Forms.CheckBox ShareWardYesCheckBox;
        private System.Windows.Forms.CheckBox ShareWardNoCheckBox;
        private System.Windows.Forms.CheckBox CriticalYesCheckBox;
        private System.Windows.Forms.CheckBox CriticalNoCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox DonePictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WardTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DischargeLabel;
        private System.Windows.Forms.Label label12;
    }
}
