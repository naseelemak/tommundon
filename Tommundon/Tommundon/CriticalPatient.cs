using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Tommundon
{
    class CriticalPatient: Patient
    {
        public int Level { get; set; }
        public bool Shareward { get; set; }
       


        public CriticalPatient(string _patientID, string _patientName, int _dayleft, string _ward, bool _discharge, bool _critical, int _illnesslevel,
                        bool _shareward) : base ( _patientID,_patientName,_dayleft,_ward,_discharge, _critical)
        {
            PatientID = _patientID;
            PatientName = _patientName;
            Daysleft = _dayleft;
            WardID = _ward;
            Level = _illnesslevel;
            Shareward = _shareward;
            Discharge = _discharge;
            Critical = _critical;

        }

        public override void insert(CriticalPatient item)

        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "('" + item.PatientID + "','" + item.PatientName + "','" + item.WardID + "','" + item.Daysleft.ToString() + "','" + item.Critical.ToString() + "','" + item.Discharge.ToString() + "')";
            cmd.CommandText = "INSERT into General_Patient (PatientID, PatientName, Ward, Dayleft, Critical, Discharge) values" + query;
            cmd.ExecuteNonQuery();
            query = "('" + item.PatientID + "','" + item.Level.ToString() + "','" + item.Shareward.ToString() + "')";
            cmd.CommandText = "INSERT into Critical_Patient (PatientID, [Level], Shareward) values" + query;
            cmd.ExecuteNonQuery();
            connect.Close();
        }




    }
   }

