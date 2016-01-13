using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tommundon
{
    public partial class PatientForm : UserControl
    {
        public PatientForm()
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            DayLeftTextBox.Enabled = false;
            IDTextBox.Enabled = false;
            IllnessLevelTextBox.Enabled = false;
            NurseRankCheckBox.Enabled = false;
            WardTextBox.Enabled = false;
            ShareWardYesCheckBox.Enabled = false;
            ShareWardNoCheckBox.Enabled = false;
            CriticalYesCheckBox.Enabled = false;
            CriticalNoCheckBox.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(menu);
            this.Parent.Controls.Remove(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PatientSelectionBox.SelectedIndex)
            {
                case 0:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = true;
                    DayLeftTextBox.Enabled = true;
                    WardTextBox.Enabled = true;
                    CriticalYesCheckBox.Enabled = true;
                    CriticalNoCheckBox.Enabled = true;
                    CriticalNoCheckBox.Checked = true;
                    NameTextBox.Text = "";
                    DayLeftTextBox.Text = "";
                    IDTextBox.Text = "";
                    IllnessLevelTextBox.Text = "";
                    NurseRankCheckBox.Text = "";
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 1:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
                    NurseRankCheckBox.Enabled = false;
                    WardTextBox.Enabled = false;
                    CriticalYesCheckBox.Enabled = false;
                    CriticalNoCheckBox.Enabled = false;
                    ShareWardYesCheckBox.Enabled = false;
                    ShareWardNoCheckBox.Enabled = false;
                    CriticalNoCheckBox.Checked = false;
                    CriticalYesCheckBox.Checked = false;
                    NameTextBox.Text = "";
                    DayLeftTextBox.Text = "";
                    IDTextBox.Text = "";
                    IllnessLevelTextBox.Text = "";
                    NurseRankCheckBox.Text = "";
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 2:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
                    NurseRankCheckBox.Enabled = false;
                    WardTextBox.Enabled = false;
                    CriticalYesCheckBox.Enabled = false;
                    CriticalNoCheckBox.Enabled = false;
                    ShareWardYesCheckBox.Enabled = false;
                    ShareWardNoCheckBox.Enabled = false;
                    CriticalNoCheckBox.Checked = false;
                    NameTextBox.Text = "";
                    DayLeftTextBox.Text = "";
                    IDTextBox.Text = "";
                    IllnessLevelTextBox.Text = "";
                    NurseRankCheckBox.Text = "";
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 3:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
                    NurseRankCheckBox.Enabled = false;
                    WardTextBox.Enabled = false;
                    ShareWardYesCheckBox.Enabled = false;
                    ShareWardNoCheckBox.Enabled = false;
                    CriticalYesCheckBox.Enabled = false;
                    CriticalNoCheckBox.Enabled = false;
                    CriticalNoCheckBox.Checked = false;
                    NameTextBox.Text = "";
                    DayLeftTextBox.Text = "";
                    IDTextBox.Text = "";
                    IllnessLevelTextBox.Text = "";
                    NurseRankCheckBox.Text = "";
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CriticalYesCheckBox.Checked)
            {
                CriticalNoCheckBox.Checked = false;
                IllnessLevelTextBox.Enabled = true;
                NurseRankCheckBox.Enabled = true;
                ShareWardYesCheckBox.Enabled = true;
                ShareWardNoCheckBox.Enabled = true;
                ShareWardYesCheckBox.Checked = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CriticalNoCheckBox.Checked)
            {
                CriticalYesCheckBox.Checked = false;
                IllnessLevelTextBox.Enabled = false;
                NurseRankCheckBox.Enabled = false;
                IllnessLevelTextBox.Text = "";
                NurseRankCheckBox.Text = "";
                ShareWardYesCheckBox.Enabled = false;
                ShareWardNoCheckBox.Enabled = false;
                ShareWardYesCheckBox.Checked = false;
                ShareWardNoCheckBox.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShareWardYesCheckBox.Checked)
            {
                ShareWardNoCheckBox.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShareWardNoCheckBox.Checked)
            {
                ShareWardYesCheckBox.Checked = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
