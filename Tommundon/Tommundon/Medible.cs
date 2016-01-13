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


        public static OleDbConnection AquireConnection()
        {
            // http://stackoverflow.com/questions/1833640/connection-string-with-relative-path-to-the-database-file
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Ward Management System 2.mdb;User Id=admin; Password=;");
            return connect;
        }
        public virtual void insert(nurse item)
        {
            
        }
        public virtual void insert(Patient item)
        {

        }
        public virtual void delete(nurse item)
        {

        }
    }
}
