using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HanoiTower
{
    /// <summary>
    /// This form lets the user play a game of HanoiTowers.
    /// 4 labels representing disks are shown on the first of three poles. It is possible 
    /// to drag a disk from one pole to another. The rules for a valid move are that
    /// a bigger disk cannot be dropped on top of a smaller one. The aim of the game
    /// is to move the stack of disks to another pole one disk at a time.
    /// Moves made by Dragging are recorder as lines of text in a textBox
    /// It is possible to reset the disks to their original position
    /// It is also possible to replay the moves stored in the textbox
    /// or from a timer - started by the [Animate] button
    /// </summary>
    public partial class MainForm : Form
    {
        private Board board;
        private Disk selectedDiskObj;
        private int toPegNum;
        private bool isSaveGame = false; //Make sure the game is loading from a saved file.
        private bool isAnimation = false;//When it is playing animation, the moves wouldn't be displaying to the testbox.
        private Label[] lbl_Disks = new Label[4];
        int tmrCount = 0;

        public MainForm()
        {
            InitializeComponent();
            makeGame();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void makeGame()
            //initialize the game
        {
            Disk disk1 = new Disk(1, lbl_Disk1.Width, lbl_Disk1.BackColor, 1);
            Disk disk2 = new Disk(2, lbl_Disk2.Width, lbl_Disk2.BackColor, 1);
            Disk disk3 = new Disk(3, lbl_Disk3.Width, lbl_Disk3.BackColor, 1);
            Disk disk4 = new Disk(4, lbl_Disk4.Width, lbl_Disk4.BackColor, 1);
            board = new Board(disk1, disk2, disk3, disk4);

            lbl_Disks[0] = lbl_Disk1;
            lbl_Disks[1] = lbl_Disk2;
            lbl_Disks[2] = lbl_Disk3;
            lbl_Disks[3] = lbl_Disk4;
        }

        private void anyDisk_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropEffects result = DragDropEffects.None;

            Label lbl_Disk = sender as Label;
            selectedDiskObj = board.FindDisk(lbl_Disk);//find the selected disk

            if (board.CanStartMove(selectedDiskObj))
            {
                result = lbl_Disk.DoDragDrop(0, DragDropEffects.All);
            }

            if (result != DragDropEffects.None)
            {
                ExecuteMove(lbl_Disk, selectedDiskObj.getDiskID());
            }
        }


        private void peg_DragEnter(object sender, DragEventArgs e)
        {
            Label peg = sender as Label;
            int chkPegNum = board.FindPegNum(peg);// checks move is valid
            if (board.CanDrop(selectedDiskObj, chkPegNum))
            {
                e.Effect = DragDropEffects.Move;
            }
        }


        private void peg_DragDrop(object sender, DragEventArgs e)
        {
            Label peg = sender as Label;
            toPegNum = board.FindPegNum(peg);//Return the peg number after dropping the disk to the peg
        }


        public void ExecuteMove(Label alblDisk, int aDiskID)
        {
            Label lbl_Disk = alblDisk;
            int diskID = aDiskID;

            board.Move(diskID, toPegNum);

            Point newPt = new Point();
            newPt = board.DisplayPosition(diskID, toPegNum); // calculates co-ordinates of new disk location
            lbl_Disk.Location = newPt;//set coordinates of the new disk
            if (!isAnimation)
                //if it is not playing an animation, the moves will output to the testboxes
            {
                MoveOutput();// adds new move to text box
                SaveOutput();
                tmrCount++;
            }
            if (isSaveGame)
                //if it is loading a saved game, show the moves to the testbox
            {
                MoveOutput();
            }
            // check last move finished game
            bool gameFinished = board.GameFinished();
            if (gameFinished && !isAnimation)
            {
                DisplayFinish();
                btnAnimate.Visible = true;
            }
        }

        public void MoveOutput()
        {
            txt_Moves.Clear();
            lblMoves.Text = (board.GetMoveCount()).ToString();
            txt_Moves.Text = board.AllMovesAsString();

        }

        public void SaveOutput()
        {
            textBox1.Text = board.SaveString();
        }

        public void DisplayFinish()
        {
            if (board.GetMoveCount() == 15)
            //make sure the game has been finished in minimum moves or not
            {
                MessageBox.Show("You have successfully completed the game with the minimum number of moves!");
            }
            else
            {
                MessageBox.Show("You have successfully completed the game but not with the minimum number of moves");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //move all the disks to peg1
            toPegNum = 1;
            ExecuteMove(lbl_Disk4, 4);
            ExecuteMove(lbl_Disk3, 3);
            ExecuteMove(lbl_Disk2, 2);
            ExecuteMove(lbl_Disk1, 1);
            board.ResetBoard();
            //set moves to 0
            lblMoves.Text = "0";
            //empty the testboxes
            txt_Moves.Clear();
            textBox1.Clear();
            isAnimation = false;
            tmrCount = 0;
            btnAnimate.Visible = false;
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            //move all the disks to peg1, then play a animation
            toPegNum = 1;
            isAnimation = true;
            isSaveGame = false;
            ExecuteMove(lbl_Disk4, 4);
            ExecuteMove(lbl_Disk3, 3);
            ExecuteMove(lbl_Disk2, 2);
            ExecuteMove(lbl_Disk1, 1);
            tmrCount = 0;
            timer1.Enabled = true;
        }

        private Label getDisk(string DiskName)
        //given a string with the .Name property of a disk
        //return a reference to that disk assuming that only valid names are passed
        {

            if (DiskName == "1")
            {
                return lbl_Disk1;
            }
            else if (DiskName == "2")
            {
                return lbl_Disk2;
            }
            else if (DiskName == "3")
            {
                return lbl_Disk3;
            }
            else return lbl_Disk4;
        }

        private bool MakeNextMove()
        //repeat one of the moves stored in the textbox
        {

            if (textBox1.Lines.Length == 0)
                return false;
            string aMove = textBox1.Lines[tmrCount];
            string[] parts = aMove.Split(',');
            if (parts.Length < 2)
                return false;
            Label aDisk = getDisk(parts[0]);
            toPegNum = Convert.ToInt32(parts[1]);
            selectedDiskObj = board.FindDisk(aDisk);
            ExecuteMove(aDisk, selectedDiskObj.getDiskID());
            tmrCount++;
            if (tmrCount >= textBox1.Lines.Length)
            {
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!MakeNextMove())
            {
                timer1.Enabled = false;
                isAnimation = false;
            }

        }

        private void exit_Click(object sender, EventArgs e)
            //exit the game 
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            //save the current game
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
            //load a saved game, then use timer to play all the movess
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                isSaveGame = true;
                isAnimation = true;
                timer1.Enabled = true;
                lblMoves.Text = (textBox1.Lines.Length - 1).ToString();

            }
        }
    }
}
