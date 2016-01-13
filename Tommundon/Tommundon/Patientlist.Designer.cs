namespace Tommundon
{
    partial class Patientlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Critical_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IllnessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient List";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(208, 361);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 74);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Home";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackgroundImage = global::Tommundon.Properties.Resources.home;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 74);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PatientName,
            this.DayLeft,
            this.Ward,
            this.Critical_Status,
            this.Discharge,
            this.IllnessLevel,
            this.ShareWard,
            this.NurseRank});
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(457, 283);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DayLeft
            // 
            this.DayLeft.HeaderText = "DayLeft";
            this.DayLeft.Name = "DayLeft";
            this.DayLeft.ReadOnly = true;
            // 
            // Ward
            // 
            this.Ward.HeaderText = "Ward";
            this.Ward.Name = "Ward";
            this.Ward.ReadOnly = true;
            // 
            // Critical_Status
            // 
            this.Critical_Status.HeaderText = "Critical Status";
            this.Critical_Status.Name = "Critical_Status";
            this.Critical_Status.ReadOnly = true;
            // 
            // Discharge
            // 
            this.Discharge.HeaderText = "Discharge";
            this.Discharge.Name = "Discharge";
            this.Discharge.ReadOnly = true;
            // 
            // IllnessLevel
            // 
            this.IllnessLevel.HeaderText = "IllnessLevel";
            this.IllnessLevel.Name = "IllnessLevel";
            this.IllnessLevel.ReadOnly = true;
            // 
            // ShareWard
            // 
            this.ShareWard.HeaderText = "ShareWard";
            this.ShareWard.Name = "ShareWard";
            this.ShareWard.ReadOnly = true;
            // 
            // NurseRank
            // 
            this.NurseRank.HeaderText = "NurseRank";
            this.NurseRank.Name = "NurseRank";
            this.NurseRank.ReadOnly = true;
            // 
            // Patientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Patientlist";
            this.Size = new System.Drawing.Size(497, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Critical_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn IllnessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ward;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
