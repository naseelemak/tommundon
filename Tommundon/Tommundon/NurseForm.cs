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
    public partial class NurseForm : UserControl
    {
        public NurseForm()
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            RankTextBox.Enabled = false;
            IDTextBox.Enabled = false;
            WardIDTextBox.Enabled = false;
            

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Nurse_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (NurseSelectionBox.SelectedIndex)
            {
                case 0:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = true;
                    RankTextBox.Enabled = true;
                    WardIDTextBox.Enabled = true;
                    NameTextBox.Text = "";
                    RankTextBox.Text = "";
                    IDTextBox.Text = "";
                    WardIDTextBox.Text = "";
                    break;
                case 1:
                    NameTextBox.Enabled = false;
                    RankTextBox.Enabled = false;
                    IDTextBox.Enabled = true;
                    WardIDTextBox.Enabled = false;
                    NameTextBox.Text = "";
                    RankTextBox.Text = "";
                    IDTextBox.Text = "";
                    WardIDTextBox.Text = "";
                    break;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (NurseSelectionBox.SelectedIndex == 0)
                {
                    nurse item = new nurse(IDTextBox.Text, NameTextBox.Text.ToString(), Int32.Parse(RankTextBox.Text), WardIDTextBox.Text.ToString());
                    item.insert(item);
                }
                else if (NurseSelectionBox.SelectedIndex == 1)
                {
                    nurse item = new nurse(IDTextBox.Text);
                    item.delete(item);

                }
            }
            catch
            {
                MessageBox.Show("please insert the data correctly");
            }
        }
    }
}
