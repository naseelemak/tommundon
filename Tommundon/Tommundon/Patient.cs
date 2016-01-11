using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommundon
{ 
    class Patient
    {
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int dayleft { get; set; }
        public string ward { get; set; }
      



        public Patient(int _patientID, string _patientName, int _dayleft, string _ward)
        {
            patientID = _patientID;
            patientName = _patientName;
            dayleft = _dayleft;
            ward = _ward;
        }
        
        public virtual void discharged (bool x)
        {
            x = true;
        }
    }
}
