using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace HanoiTower
{
    /// <summary>
    /// It stores the constants needed to handle the display of disks
    ///It has a two dimensional array of Disk references that represents the board
    ///It has an ArrayList for storing the moves made
    ///It has a one dimensional array of 4 Disk references for the Disk objects used in the game.
    /// </summary>
    class Board
    {
        private const int NUMOFDISKS = 4;
        private const int NUMOFPEGS = 3;
        private const int FINISHPEG = 3;
        private const int DISKHEIGHT = 24;
        private const int TOPOFBASE = 279;

        private int[] pegLocX = new int[] { 220, 440, 660 };

        private int moveCount = 0;
        private ArrayList movesMade = new ArrayList();  //stores each move as reference to DiskMove object
        private Disk[] diskObj = new Disk[NUMOFDISKS];

        //The 4 Disk references in the constructor are to be used to fill 
        //the array of Disk objects belonging to the Board object
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            diskObj[0] = d1;
            diskObj[1] = d2;
            diskObj[2] = d3;
            diskObj[3] = d4;

        }

        //Reset the game to the beginning
        public void ResetBoard()
        {
            moveCount = 0;
            movesMade.Clear();

            foreach (Disk disk in diskObj)
            {
                disk.setPegNum(1);
            }

        }
        //check if the game is finished
        public bool GameFinished()
        {
            bool finished = false;
            int countDisks = 0;

            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == FINISHPEG)
                {
                    countDisks++;
                }
            }
            if (countDisks == NUMOFDISKS)
            {
                finished = true;
            }

            return finished;
        }

        //Check if it is valid to begin a move with a 
        //particular Disk (only the top Disk on a peg can move). 
        public bool CanStartMove(Disk aDisk)
        {
            bool isTop = true;
            Disk chkDisk = aDisk;

            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == chkDisk.getPegNum())
                {
                    if (disk.getDiameter() < chkDisk.getDiameter())
                    {
                        isTop = false;
                    }
                }

            }
            return isTop;
        }

        //Check if it is valid to drop a particular disk on a Peg (drops are only 
        //allowed for a Disk that is smaller than the top Disk on a peg or for an empty peg).
        public bool CanDrop(Disk aDisk, int aPegNum)
        {
            Disk chkDisk = aDisk;
            int chkPegNum = aPegNum;
            bool validDrop = false;

            bool emptyPeg = true;
            bool smallestDisk = true;
            foreach (Disk disk in diskObj)
            {
                if (disk.getPegNum() == chkPegNum)
                {
                    emptyPeg = false;  // if a disk found on this peg then not empty

                    if (disk.getDiameter() < chkDisk.getDiameter())
                    {
                        smallestDisk = false;  // if the disk found is smaller then not smallest 
                    }
                }
            }

            if (emptyPeg || smallestDisk)
            {
                validDrop = true;
            }

            return validDrop;
        }

        //Move a disk to a new Peg.
        public void Move(int aDiskID, int aPegNum)
        {
            // update disk object
            int movedDiskID = aDiskID;
            int newPegNum = aPegNum;
            diskObj[movedDiskID - 1].setPegNum(newPegNum);
            // record new move
            DiskMove move = new DiskMove(movedDiskID, newPegNum);
            movesMade.Add(move);

            // count move
            moveCount++;
        }

        // find the disk
        public Disk FindDisk(Label aLabel)
        {
            return diskObj[Convert.ToInt32(aLabel.Text) - 1];
        }

        //find the peg number
        public int FindPegNum(Label aPeg)
        {
            Label peg = aPeg;
            int pegNum = 0;
            for (int i = 0; i < NUMOFPEGS; i++)
            {
                if (pegLocX[i] == (peg.Location.X + 13))
                {
                    pegNum = i + 1;
                }
            }

            return pegNum;
        }

        //Display the current position of the disks. This is done by changing the 
        //Top and Left properties of the disks which in turn changes where the labels show on the screen.
        public Point DisplayPosition(int aDiskID, int aPegNum)
        {
            int diskID = aDiskID;
            int pegNum = aPegNum;
            int ptX = 0;
            int ptY = 0;
            int countLevel = 0;

            // Calculate postion of disk working from largest to smallest on specified Peg
            for (int i = 3; i > -1; i--)
            {
                //  Determine level
                if (diskObj[i].getPegNum() == pegNum)
                {
                    countLevel++;
                }

                // Calculate position from Peg and level
                if (diskID == diskObj[i].getDiskID())
                {
                    ptX = DiskLocX(diskID, pegNum);
                    ptY = DiskLocY(diskID, countLevel);
                }
            }
            Point newPt = new Point(ptX, ptY);
            return newPt;
        }

        //find the x coordinate of disk
        public int DiskLocX(int aDiskID, int aPegNum)
        {
            int movedDiskID = aDiskID;
            int toPegNum = aPegNum;

            int diskLocX = pegLocX[aPegNum - 1] - (diskObj[movedDiskID - 1].getDiameter() / 2);

            return diskLocX;
        }

        //dinf the y coordinate if the disk
        public int DiskLocY(int aDiskID, int aLevel)
        {
            int movedDiskID = aDiskID;
            int newLevel = aLevel;

            int diskLocY = TOPOFBASE - ((newLevel) * DISKHEIGHT);

            return diskLocY;
        }

        // count the moves
        public int GetMoveCount()
        {
            return moveCount;
        }

       //Return a string giving the moves so far, one move per line.
        public string AllMovesAsString()
        {
            string allMovesString = "";
            int i = 1;
            foreach (object ob in movesMade)
            {
                allMovesString += (i + ". " + ((DiskMove)ob).OutputAsText() + "\r\n");
                i++;
            }
            return allMovesString;
        }


        public string SaveString()
        {
            string saveString = "";
            foreach (object ob in movesMade)
            {
                saveString += (((DiskMove)ob).SaveAsText() + "\r\n");
            }
            return saveString;

        }

    }
}
