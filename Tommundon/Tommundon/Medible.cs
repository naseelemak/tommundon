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
            // http://stackoverflow.com/questions/1833640/connection-string-with-relative-path-to-the-database-file
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Medible.mdb;User Id=admin; Password=;");
            return connect;
        }
        public virtual void insert(nurse item)
        {
            
        }

    }
}
