using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Tommundon
{
    class ward
    {
        public int wardno { get; set; }
        public int patientno { get; set; }
        public int nurseno { get; set; }
        public int nurserank3no { get; set; }
        public int critpatientno { get; set; }
        public string status { get; set; }
        public string critstatus { get; set; }
    }
     
}
