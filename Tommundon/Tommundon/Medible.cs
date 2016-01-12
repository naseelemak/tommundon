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
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edmun\Source\Repos\tommundon\Tommundon\Tommundon\Tomundon.accdb;");
            return connect;
        }
        protected virtual void insert(OleDbConnection connect, nurse item)
        {
            

        }

    }
}
