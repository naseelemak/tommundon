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
        public int illnesslevel { get; set; }
        public bool shareward { get; set; }
        public int nurseRank { get; set; }
       


        public CriticalPatient(int _patientID, string _patientName, int _dayleft, string _ward, bool _critical, int _illnesslevel,
                        bool _shareward, int _nurseRank, bool _discharge) : base ( _patientID,_patientName,_dayleft,_ward,_discharge)
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

        public override void discharged(bool x)
        {
            x = false;
        }
    }
   }

