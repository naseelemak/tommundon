using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommundon
{
    class CriticalPatient
    {
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int dayleft { get; set; }
        public string ward { get; set; }
        public int illnesslevel { get; set; }
        public bool shareward { get; set; }
        public int nurseRank { get; set; }
        public bool discharge { get; set; }



        public CriticalPatient(int _patientID, string _patientName, int _dayleft, string _ward, int _illnesslevel,
                        bool _shareward, int _nurseRank, bool _discharge)
        {
            patientID = _patientID;
            patientName = _patientName;
            dayleft = _dayleft;
            ward = _ward;
            illnesslevel = _illnesslevel;
            shareward = _shareward;
            nurseRank = _nurseRank;
            discharge = _discharge;
        }
    }
   }

