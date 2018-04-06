using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HanoiTower
{
    /// <summary>
    /// This class stores the index of the disk making the move and the new Peg it is dropped on
    /// </summary>
    public class Disk
    {
        private int diskID,
                      disk_Diam,
                      disk_PegNum;

        private Color disk_Colour;

        public Disk(int aDiskID, int aDiameter, Color aColour, int aPeg)
        {
            diskID = aDiskID;
            disk_Diam = aDiameter;
            disk_Colour = aColour;
            disk_PegNum = aPeg;
        }


        public void setPegNum(int newPeg)
        {
            disk_PegNum = newPeg;
        }

        public int getDiskID()
        {
            return diskID;
        }

        public Color getDiskColour()
        {
            return disk_Colour;
        }

        public int getDiameter()
        {
            return disk_Diam;
        }

        public int getPegNum()
        {
            return disk_PegNum;
        }

    }

}
