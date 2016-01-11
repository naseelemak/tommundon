using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommundon
{
    public class nurse
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
       

       
    }
}
