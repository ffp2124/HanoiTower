using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    public class DiskMove
    {
        private string diskIDStr, pegNumStr;


        public DiskMove(Int32 aDisk, Int32 aPeg)
        {
            diskIDStr = aDisk.ToString();
            pegNumStr = aPeg.ToString();
        }


        public string OutputAsText()
        {
            return ("Disk " + diskIDStr + " to Peg " + pegNumStr);
        }

        public string SaveAsText()
        {
            return (diskIDStr + "," + pegNumStr);
        }
    }

}
