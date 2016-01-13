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
    public partial class Patientlist : UserControl
    {
        public Patientlist()
        {
            InitializeComponent();
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            cmd.CommandText = "SELECT  General_Patient.*, Critical_Patient.* FROM(General_Patient LEFT JOIN Critical_Patient ON General_Patient.[PatientID] = Critical_Patient.PatientID) UNION SELECT General_Patient.*, Critical_Patient.*FROM (Critical_Patient LEFT  JOIN General_Patient ON Critical_Patient.[PatientID] = General_Patient.PatientID)";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader["PatientName"], reader["Ward"], reader["DayLeft"], reader["Critical"], reader["Discharge"],  reader["Level"], reader["Shareward"]);
            }
            connect.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(menu);
            this.Parent.Controls.Remove(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
