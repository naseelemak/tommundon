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
        public int Daysleft { get; set; }
        public string WardID { get; set; }
        public bool Discharge { get; set; }
        public bool Critical { get; set; }



        public Patient(string _patientID, string _patientName, int _dayleft, string _ward, bool _discharge, bool _critical)
        {
            PatientID = _patientID;
            PatientName = _patientName;
            Daysleft = _dayleft;
            WardID = _ward;
            Discharge = _discharge;
            Critical = _critical;
        }
        
        public override void insert (Patient item)
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "('" + item.PatientID + "','" + item.PatientName + "','" + item.WardID + "','" + item.Daysleft.ToString() + "','" + item.Critical.ToString() + "','" + item.Discharge.ToString() + "')";
            cmd.CommandText = "INSERT into General_Patient ( PatientID, PatientName, Ward, Dayleft, Critical, Discharge) values" + query;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public virtual void insert (CriticalPatient item)
        {

        }

    }
    
}
