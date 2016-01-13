using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Tommundon
{
    public class Medible
    {
        //nurse
        public int nurseID { get; set; }
        public string nurseName { get; set; }
        public int nurseRank { get; set; }
        //patients
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int dayleft { get; set; }
        public string ward { get; set; }
        public bool discharge { get; set; }


        public static OleDbConnection AquireConnection()
        {
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edmun\Source\Repos\tommundon\Tommundon\Tommundon\Tomundon.accdb;");
            return connect;
        }
        public virtual void insert(nurse item)
        {
            
        }

    }
}
