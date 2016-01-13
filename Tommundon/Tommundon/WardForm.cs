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
            //http://stackoverflow.com/questions/15128361/getting-data-from-ms-access-database-and-display-it-in-a-listbox
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;

            //http://www.java2s.com/Code/CSharp/Database-ADO.net/Getcountvaluefromaselectquery.htm
            cmd.CommandText = "SELECT COUNT(*) FROM General_Patient WHERE Ward = '" + WardSelectionBox.Text + "'";
            int count = (int)cmd.ExecuteScalar();

            cmd.CommandText = "SELECT COUNT('General_Patient.*') FROM (General_Patient INNER JOIN Critical_Patient ON General_Patient.PatientID = Critical_Patient.PatientID) WHERE (General_Patient.Ward) = '" + WardSelectionBox.Text + "'";
            int ccount = (int)cmd.ExecuteScalar();

            cmd.CommandText = "SELECT COUNT(*) FROM Nurses WHERE WardID = '" + WardSelectionBox.Text + "'";
            int ncount = (int)cmd.ExecuteScalar();

            cmd.CommandText = "SELECT COUNT(*) FROM Nurses WHERE Rank > 2 AND WardID = '" + WardSelectionBox.Text + "'";
            int cncount = (int)cmd.ExecuteScalar();

            cmd.CommandText = "UPDATE Wards SET VeterenNursesRequired = '" + cncount + "' WHERE WardID = '" + WardSelectionBox.Text + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE Wards SET NursesRequired = '" + ncount + "' WHERE WardID = '" + WardSelectionBox.Text + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE Wards SET NoOfCriticalPatients = '" + ccount + "' WHERE WardID = '" + WardSelectionBox.Text + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE Wards SET NoOfPatients = '" + count + "' WHERE WardID = '" + WardSelectionBox.Text + "'";
            cmd.ExecuteNonQuery();

            string query = "WardID = '" + WardSelectionBox.Text + "'";
            cmd.CommandText = "SELECT * From Wards where " + query;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NoPatientTextBox.Text = reader["NoOfPatients"].ToString();
                NoNursesTextBox.Text = reader["NursesRequired"].ToString();
                NoCPatientTextBox.Text = reader["NoOfCriticalPatients"].ToString();
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
            float nocpatient = Int32.Parse(NoCPatientTextBox.Text);
            float nocnurse = Int32.Parse(NoRank3TextBox.Text);
            float cstatus = (nocpatient / nocnurse);
            if (cstatus == 0)
            {
                CStatusTextBox.Text = "Sufficient Rank 3+ Nurse";
            }
            else
            {
                CStatusTextBox.Text = "Insufficient Rank 3+ Nurse";
            }

        }

        private void NoPatientTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
