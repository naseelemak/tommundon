using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Tommundon
{ 
    public class Patient : Medible
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public int Dayleft { get; set; }
        public string Ward { get; set; }
        public bool Discharge { get; set; }



        public Patient(string _patientID, string _patientName, int _dayleft, string _ward, bool _discharge)
        {
            PatientID = _patientID;
            PatientName = _patientName;
            Dayleft = _dayleft;
            Ward = _ward;
            Discharge = _discharge;
        }
        
        public override void insert (Patient item)
 
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "('" + item.PatientID + "','" + item.PatientName + "','" + item.Dayleft.ToString() + "','" + item.Ward + "','" + item.Discharge.ToString() + "')";
            cmd.CommandText = "INSERT into General Patient Info ( PatientID, PatientName, Dayleft, Ward, Discharge) values" + query;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
    
}
