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
        public int Illnesslevel { get; set; }
        public bool Shareward { get; set; }
        public int NurseRank { get; set; }
       


        public CriticalPatient(int _patientID, string _patientName, int _dayleft, string _ward, bool _critical, int _illnesslevel,
                        bool _shareward, int _nurseRank, bool _discharge) : base ( _patientID,_patientName,_dayleft,_ward,_discharge)
        {
            PatientID = _patientID;
            PatientName = _patientName;
            Dayleft = _dayleft;
            WardID = _ward;
            Illnesslevel = _illnesslevel;
            Shareward = _shareward;
            Discharge = _discharge;

        }

        public override void discharged(bool x)
        {
            x = false;
        }
    }
   }

