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
        public nurse(string _NurseID)
        {
            this.NurseID = _NurseID;
        }

        public nurse()
        {
        
        }

        public override void insert(nurse item)
        {
            //source:https://www.youtube.com/channel/UCs6nmQViDpUw0nuIx9c_WvA
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "('" + item.NurseID + "','" + item.NurseName + "','" + item.Rank.ToString() + "','" + item.WardID + "')";
            cmd.CommandText = "INSERT into Nurses ( NurseID, NurseName, Rank, WardID ) values" + query;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public override bool delete(nurse item)
        {
            OleDbConnection connect = Medible.AquireConnection();
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = "NurseID = '" + item.NurseID.ToString() + "'";
            cmd.CommandText = "SELECT * From Nurses where " + query;
            OleDbDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                exist = reader.HasRows;
            }
            connect.Close();
            if (!exist)
            {
                return exist;
            }
            else
            {
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "Delete from Nurses where " + query;
                cmd.ExecuteNonQuery();
                connect.Close();
                return exist;
            }
        }
    }
}
