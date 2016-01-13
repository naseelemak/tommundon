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
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 1:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
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
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 2:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
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
                    WardTextBox.Text = "";
                    ShareWardYesCheckBox.Checked = false;
                    ShareWardNoCheckBox.Checked = false;
                    break;
                case 3:
                    IDTextBox.Enabled = true;
                    NameTextBox.Enabled = false;
                    DayLeftTextBox.Enabled = false;
                    IllnessLevelTextBox.Enabled = false;
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
                IllnessLevelTextBox.Text = "";
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

        private void DonePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                //ADD
                if (PatientSelectionBox.SelectedIndex == 0)
                {
                    if (CriticalYesCheckBox.Checked == true)
                    {
                        bool shareward = false;
                        if (ShareWardYesCheckBox.Checked == true)
                        {
                            shareward = true;
                        }
                        else if (ShareWardYesCheckBox.Checked == false)
                        {
                            shareward = false;
                        }
                        CriticalPatient item = new CriticalPatient(IDTextBox.Text, NameTextBox.Text, Int32.Parse(DayLeftTextBox.Text), WardTextBox.Text, false, true, Int32.Parse(IllnessLevelTextBox.Text), shareward );
                        string query = "('" + item.PatientID + "','" + item.PatientName + "','" + item.WardID + "','" + item.Daysleft.ToString() + "','" + item.Critical.ToString() + "','" + item.Discharge.ToString() + "')";
                        string query2 = "('" + item.PatientID + "','" + item.Level.ToString() + "','" + item.Shareward.ToString() + "')";
                        MessageBox.Show(query + query2);
                        item.insert(item);
                        
                    }
                    else if (CriticalYesCheckBox.Checked == false)
                    {

                        Patient item = new Patient(IDTextBox.Text, NameTextBox.Text, Int32.Parse(DayLeftTextBox.Text), WardTextBox.Text, false, false );
                        string query = "('" + item.PatientID + "','" + item.PatientName + "','" + item.WardID + "','" + item.Daysleft.ToString() + "'," + item.Critical.ToString() + "," + item.Discharge.ToString() + ")";
                        MessageBox.Show(query);
                        item.insert(item);
                        
                    }
                    

                }
                //SEARCH
                else if (PatientSelectionBox.SelectedIndex == 1)
                {
                    string query = "'" + IDTextBox.Text.ToString() + "'";
                    string tof1 = "";
                    string tof2 = "";

                    OleDbConnection connect = Medible.AquireConnection();
                    connect.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "select * from General_Patient where PatientID = " + query;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IDTextBox.Text = reader["PatientID"].ToString();
                        NameTextBox.Text = reader["PatientName"].ToString();
                        DayLeftTextBox.Text = reader["DayLeft"].ToString();
                        WardTextBox.Text = reader["Ward"].ToString();
                        
                        tof1 = reader["Critical"].ToString();
                        tof2 = reader["Discharge"].ToString();

                    }
                    connect.Close();


                    if (tof1 == "True")
                    {
                        CriticalYesCheckBox.Checked = true;
                        CriticalNoCheckBox.Checked = false;
                        ShareWardNoCheckBox.Enabled = false;
                        ShareWardYesCheckBox.Enabled = false;
                        IllnessLevelTextBox.Enabled = false;

                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "select * from Critical_Patient where PatientID = " + query;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string tof = reader["Shareward"].ToString();

                            IllnessLevelTextBox.Text = reader["Level"].ToString();

                            if (tof == "True")
                            {
                                ShareWardNoCheckBox.Checked = false;
                                ShareWardYesCheckBox.Checked = true;
                            }
                            else
                            {
                                ShareWardNoCheckBox.Checked = true;
                                ShareWardYesCheckBox.Checked = false;
                            }
                        }
                        connect.Close();

                    }
                    else
                    {
                        CriticalNoCheckBox.Checked = true;
                        CriticalYesCheckBox.Checked = false;
                    }

                    if (tof2 == "True")
                    {
                        DischargeLabel.Text = "Yes";
                    }
                    else
                    {
                        DischargeLabel.Text = "No";
                    }
                    
                    
                }
                //Discharge
                else if (PatientSelectionBox.SelectedIndex == 2)
                {
                    Patient item = new Patient(IDTextBox.Text);
                    item.discharge(item);
                }//Delete
                else if (PatientSelectionBox.SelectedIndex == 3)
                {
                    Patient item = new Patient(IDTextBox.Text);
                    item.delete(item);

                }
            }
            catch
            {
                MessageBox.Show("please insert the data correctly");
            }
        }

        private void DischargeLabel_Click(object sender, EventArgs e)
        {

        }

        private void IllnessLevelTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
