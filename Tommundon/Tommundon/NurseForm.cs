﻿using System;
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
        private string text1;
        private string text2;
        private string text3;
        private int v1;
        private int v2;
        OleDbConnection connect = Medible.AquireConnection();

        public NurseForm()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
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
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox4.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 1:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
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
                if (textBox1.Enabled == true && textBox2.Enabled == true)
                {
                    try
                    {
                        int x = Int32.Parse(textBox2.Text);
                        if (x > 0 && x < 6)
                        {
                            nurse item = new nurse(textBox3.Text.ToString(), textBox1.Text.ToString(), Int32.Parse(textBox2.Text), textBox4.Text.ToString());
                            item.insert(item);

                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";

                            MessageBox.Show("Information successfully added");
                        }
                        else
                        {
                            MessageBox.Show("Please insert an integer within 1-5 for the 'Rank' field");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please insert an integer within 1-5 for the 'Rank' field");
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
