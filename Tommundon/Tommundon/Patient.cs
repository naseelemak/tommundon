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
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int dayleft { get; set; }
        public string ward { get; set; }
        public bool discharge { get; set; }



        public Patient(int _patientID, string _patientName, int _dayleft, string _ward, bool _discharge)
        {
            patientID = _patientID;
            patientName = _patientName;
            dayleft = _dayleft;
            ward = _ward;
            discharge = _discharge;
        }
        
        public virtual void discharged (bool x)
        {
            x = true;
        }
    }
}
