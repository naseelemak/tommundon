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
       


        public CriticalPatient(string _patientID, string _patientName, int _dayleft, string _ward, bool _critical, int _illnesslevel,
                        bool _shareward, int _nurseRank, bool _discharge) : base ( _patientID,_patientName,_dayleft,_ward,_discharge, _critical)
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

       
    }
   }

