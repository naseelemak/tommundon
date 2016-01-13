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
            if (NameTextBox.Text != "" || RankTextBox.Text != "" || IDTextBox.Text != "" || WardIDTextBox.Text != "")
            {
                //http://stackoverflow.com/questions/3036829/how-to-create-a-message-box-with-yes-no-choices-and-a-dialogresult-in-c
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave? The data you have entered will not be saved.", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Menu menu = new Menu();
                    menu.Dock = DockStyle.Fill;
                    this.Parent.Controls.Add(menu);
                    this.Parent.Controls.Remove(this);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                Menu menu = new Menu();
                menu.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(menu);
                this.Parent.Controls.Remove(this);
            }
            
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
                    try
                    {
                        int x = Int32.Parse(RankTextBox.Text);
                        if (x > 0 && x < 6)
                        {
                            nurse item = new nurse(IDTextBox.Text, NameTextBox.Text.ToString(), Int32.Parse(RankTextBox.Text), WardIDTextBox.Text.ToString());
                            string ID = IDTextBox.Text;
                            int IDlength = ID.Length;
                            if (IDlength == 4)
                            {
                                if (ID[0].ToString().Equals("N") && char.IsDigit(ID[1]) && char.IsDigit(ID[2]) && char.IsDigit(ID[3]))
                                {
                                    string WardID = WardIDTextBox.Text;
                                    int WardIDlength = WardID.Length;
                                    if (WardIDlength == 4)
                                    {
                                        if (WardID[0].ToString().Equals("W") && char.IsDigit(WardID[1]) && char.IsDigit(WardID[2]) && char.IsDigit(WardID[3]))
                                        {
                                            int WardNo = Int32.Parse(WardID[3].ToString());
                                            if (WardNo < 6 && WardNo > 0)
                                            {

                                                item.insert(item);

                                                NameTextBox.Text = "";
                                                RankTextBox.Text = "";
                                                IDTextBox.Text = "";
                                                WardIDTextBox.Text = "";

                                                MessageBox.Show("Information successfully added");
                                            }
                                            else {
                                                MessageBox.Show("Please enter only Ward ID from 001 ~ 005");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid Ward ID format. (Format: N000)");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("WardID can only accept 4 characters"); ;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Nurse ID format. (Format: N000)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("NurseID can only accept 4 characters");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert an integer within 1-5 for the 'Rank' field");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The data either existed or did not follow proper format");
                    }

                }
                else if (NurseSelectionBox.SelectedIndex == 1)
                {
                    nurse item = new nurse(IDTextBox.Text);
                    bool exist = item.delete(item);
                    switch (exist)
                    {
                        case true:
                            MessageBox.Show("Nurse deleted successfully");
                            break;
                        case false:
                            MessageBox.Show("Nurse not found or already deleted");
                            break;
                    }
                }

            }

            catch
            {
                MessageBox.Show("Please fill in the fields correctly.");
            }
        }
    }
}
