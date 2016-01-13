namespace Tommundon
{
    partial class WardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.NoCPatientTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CStatusTextBox = new System.Windows.Forms.TextBox();
            this.NoNursesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoPatientTextBox = new System.Windows.Forms.TextBox();
            this.NoRank3TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WardSelectionBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HomePictureBox);
            this.panel1.Location = new System.Drawing.Point(98, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.WardSelectionBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.NoCPatientTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CStatusTextBox);
            this.panel3.Controls.Add(this.NoNursesTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.StatusTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.NoPatientTextBox);
            this.panel3.Controls.Add(this.NoRank3TextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 252);
            this.panel3.TabIndex = 29;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "No. C.Patients";
            // 
            // NoCPatientTextBox
            // 
            this.NoCPatientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoCPatientTextBox.Location = new System.Drawing.Point(86, 118);
            this.NoCPatientTextBox.Name = "NoCPatientTextBox";
            this.NoCPatientTextBox.Size = new System.Drawing.Size(142, 20);
            this.NoCPatientTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Nurses";
            // 
            // CStatusTextBox
            // 
            this.CStatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CStatusTextBox.Location = new System.Drawing.Point(86, 175);
            this.CStatusTextBox.Name = "CStatusTextBox";
            this.CStatusTextBox.Size = new System.Drawing.Size(142, 20);
            this.CStatusTextBox.TabIndex = 6;
            // 
            // NoNursesTextBox
            // 
            this.NoNursesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoNursesTextBox.Location = new System.Drawing.Point(86, 60);
            this.NoNursesTextBox.Name = "NoNursesTextBox";
            this.NoNursesTextBox.Size = new System.Drawing.Size(142, 20);
            this.NoNursesTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatusTextBox.Location = new System.Drawing.Point(86, 90);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(142, 20);
            this.StatusTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. Patients";
            // 
            // NoPatientTextBox
            // 
            this.NoPatientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoPatientTextBox.Location = new System.Drawing.Point(86, 31);
            this.NoPatientTextBox.Name = "NoPatientTextBox";
            this.NoPatientTextBox.Size = new System.Drawing.Size(142, 20);
            this.NoPatientTextBox.TabIndex = 1;
            // 
            // NoRank3TextBox
            // 
            this.NoRank3TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoRank3TextBox.Location = new System.Drawing.Point(86, 147);
            this.NoRank3TextBox.Name = "NoRank3TextBox";
            this.NoRank3TextBox.Size = new System.Drawing.Size(143, 20);
            this.NoRank3TextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "C.Status";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "No. Rank 3+";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Ward Status";
            // 
            // WardSelectionBox
            // 
            this.WardSelectionBox.FormattingEnabled = true;
            this.WardSelectionBox.Items.AddRange(new object[] {
            "Ward 1",
            "Ward 2",
            "Ward 3",
            "Ward 4",
            "Ward 5"});
            this.WardSelectionBox.Location = new System.Drawing.Point(9, 4);
            this.WardSelectionBox.Name = "WardSelectionBox";
            this.WardSelectionBox.Size = new System.Drawing.Size(219, 21);
            this.WardSelectionBox.TabIndex = 0;
            // 
            // WardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "WardForm";
            this.Size = new System.Drawing.Size(256, 369);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NoCPatientTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CStatusTextBox;
        private System.Windows.Forms.TextBox NoNursesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoPatientTextBox;
        private System.Windows.Forms.TextBox NoRank3TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox WardSelectionBox;
    }
}
