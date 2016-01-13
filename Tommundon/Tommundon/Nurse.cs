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
        public string NurseID { get; set; }
        public string NurseName { get; set; }
        public int Rank { get; set; }
        public string WardID { get; set; }

        public nurse(string _NurseID, string _NurseName, int _Rank, string _WardID) 
        {
            this.NurseID = _NurseID;
            this.NurseName = _NurseName;
            this.Rank = _Rank;
            this.WardID = _WardID;
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
            string query = "('" + item.NurseID + "','" + item.NurseName + "','" + item.Rank.ToString() + "','" + item.WardID + "')";
            cmd.CommandText = "INSERT into Nurses ( NurseID, NurseName, Rank, WardID ) values" + query;
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
