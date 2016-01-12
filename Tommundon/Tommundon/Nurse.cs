using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Tommundon
{
    public class nurse : Medible
    {
        public int nurseID { get; set; }
        public string nurseName { get; set; }
        public int nurseRank { get; set; }

        public nurse(int _nurseID, string _nurseName, int _nurseRank)
        {
            this.nurseID = _nurseID;
            this.nurseName = _nurseName;
            this.nurseRank = _nurseRank;
        }

        protected override void insert(OleDbConnection connect, nurse item)
        {

            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            cmd.CommandText = "INSERT into Nurselist ( nurseID, nurseName, nurseRank) values ('" + item.nurseID+ "','" + item.nurseName + "','" + item.nurseName + "')";
            cmd.ExecuteNonQuery();
            connect.Close();

        }

        public static void Insert2(OleDbConnection connect, nurse item)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            cmd.CommandText = "INSERT into Nurselist ( nurseID, nurseName, nurseRank) values ('" + item.nurseID + "','" + item.nurseName + "','" + item.nurseName + "')";
            cmd.ExecuteNonQuery();
            connect.Close();
        }


    }
}
