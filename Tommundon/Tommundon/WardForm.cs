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
    public partial class WardForm : UserControl
    {
        public WardForm()
        {
            InitializeComponent();
            NoNursesTextBox.Enabled = false;
            StatusTextBox.Enabled = false;
            NoPatientTextBox.Enabled = false;
            NoRank3TextBox.Enabled = false;
            CStatusTextBox.Enabled = false;
            NoCPatientTextBox.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(menu);
            this.Parent.Controls.Remove(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WardSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
           
            string query = "WardID = '" + WardSelectionBox.Text + "'";
            cmd.CommandText = "SELECT * From Wards where " + query;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NoPatientTextBox.Text = reader["NoOfPatients"].ToString();
                NoNursesTextBox.Text = reader["NursesRequired"].ToString();
                NoRank3TextBox.Text = reader["VeterenNursesRequired"].ToString();
            }
            connect.Close();
            float nopatient = Int32.Parse(NoPatientTextBox.Text);
            float nonurses = Int32.Parse(NoNursesTextBox.Text);
            float status = (nopatient / nonurses);
            if (status <= 5)
            {
                StatusTextBox.Text = "Sufficient Nurse";
            }
            else
            {
                StatusTextBox.Text = "Insufficient Nurse";
            }

        }

        private void NoPatientTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
