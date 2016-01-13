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
        public new int nurseID { get; set; }
        public new string nurseName { get; set; }
        public new int nurseRank { get; set; }

        public nurse(int _nurseID, string _nurseName, int _nurseRank) 
        {
            this.nurseID = _nurseID;
            this.nurseName = _nurseName;
            this.nurseRank = _nurseRank;
        }
        public nurse(int _nurseID)
        {
            this.nurseID = _nurseID;
        }

        public nurse()
        {
        
        }

        public override void insert( nurse item)
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "('" + item.nurseID.ToString() + "','" + item.nurseName + "','" + item.nurseRank.ToString() + "')";
            cmd.CommandText = "INSERT into Nurselist ( nurseID, nurseName, nurseRank) values" + query;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public override void delete(nurse item)
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "nurseID =" + item.nurseID.ToString() + "";
            cmd.CommandText = "Delete from Nurselist where "  + query ;
            cmd.ExecuteNonQuery();
            connect.Close();
        }





    }
}
