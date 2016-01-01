using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommundon.Resources
{
    class Patient
    {
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int dayleft { get; set; }
        public string ward { get; set; }




        public Patient(int _patientID, string _patientName, int _dayleft, string _ward, bool _critical, int _illnesslevel, 
                        bool _shareward, int _nurseRank, bool _discharge)
        {
            patientID = _patientID;
            patientName = _patientName;
            dayleft = _dayleft;
            ward = _ward;
        }
    }
}
