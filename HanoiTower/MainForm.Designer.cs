namespace HanoiTower
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Disk1 = new System.Windows.Forms.Label();
            this.lbl_Disk2 = new System.Windows.Forms.Label();
            this.lbl_Disk3 = new System.Windows.Forms.Label();
            this.lbl_Disk4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pole1 = new System.Windows.Forms.Label();
            this.Pole2 = new System.Windows.Forms.Label();
            this.Pole3 = new System.Windows.Forms.Label();
            this.txt_Moves = new System.Windows.Forms.TextBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Disk1
            // 
            this.lbl_Disk1.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk1.Location = new System.Drawing.Point(195, 184);
            this.lbl_Disk1.Name = "lbl_Disk1";
            this.lbl_Disk1.Size = new System.Drawing.Size(48, 24);
            this.lbl_Disk1.TabIndex = 32;
            this.lbl_Disk1.Text = "1";
            this.lbl_Disk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk2
            // 
            this.lbl_Disk2.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk2.Location = new System.Drawing.Point(179, 208);
            this.lbl_Disk2.Name = "lbl_Disk2";
            this.lbl_Disk2.Size = new System.Drawing.Size(80, 24);
            this.lbl_Disk2.TabIndex = 31;
            this.lbl_Disk2.Text = "2";
            this.lbl_Disk2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk3
            // 
            this.lbl_Disk3.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk3.Location = new System.Drawing.Point(163, 232);
            this.lbl_Disk3.Name = "lbl_Disk3";
            this.lbl_Disk3.Size = new System.Drawing.Size(112, 24);
            this.lbl_Disk3.TabIndex = 30;
            this.lbl_Disk3.Text = "3";
            this.lbl_Disk3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk4
            // 
            this.lbl_Disk4.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk4.Location = new System.Drawing.Point(147, 256);
            this.lbl_Disk4.Name = "lbl_Disk4";
            this.lbl_Disk4.Size = new System.Drawing.Size(144, 24);
            this.lbl_Disk4.TabIndex = 29;
            this.lbl_Disk4.Text = "4";
            this.lbl_Disk4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Disk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(113, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 48);
            this.panel1.TabIndex = 28;
            // 
            // Pole1
            // 
            this.Pole1.AllowDrop = true;
            this.Pole1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Pole1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pole1.Location = new System.Drawing.Point(207, 152);
            this.Pole1.Name = "Pole1";
            this.Pole1.Size = new System.Drawing.Size(24, 144);
            this.Pole1.TabIndex = 34;
            this.Pole1.Text = "1";
            this.Pole1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pole1.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.Pole1.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // Pole2
            // 
            this.Pole2.AllowDrop = true;
            this.Pole2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Pole2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pole2.Location = new System.Drawing.Point(427, 151);
            this.Pole2.Name = "Pole2";
            this.Pole2.Size = new System.Drawing.Size(24, 144);
            this.Pole2.TabIndex = 33;
            this.Pole2.Text = "2";
            this.Pole2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pole2.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.Pole2.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // Pole3
            // 
            this.Pole3.AllowDrop = true;
            this.Pole3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Pole3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pole3.Location = new System.Drawing.Point(647, 151);
            this.Pole3.Name = "Pole3";
            this.Pole3.Size = new System.Drawing.Size(24, 144);
            this.Pole3.TabIndex = 35;
            this.Pole3.Text = "3";
            this.Pole3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pole3.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.Pole3.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // txt_Moves
            // 
            this.txt_Moves.Location = new System.Drawing.Point(819, 47);
            this.txt_Moves.Multiline = true;
            this.txt_Moves.Name = "txt_Moves";
            this.txt_Moves.Size = new System.Drawing.Size(136, 280);
            this.txt_Moves.TabIndex = 36;
            // 
            // lblMoves
            // 
            this.lblMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMoves.Location = new System.Drawing.Point(425, 43);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(48, 24);
            this.lblMoves.TabIndex = 38;
            this.lblMoves.Text = "0";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 40);
            this.label1.TabIndex = 37;
            this.label1.Text = "Moves:";
            // 
            // btnAnimate
            // 
            this.btnAnimate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimate.Location = new System.Drawing.Point(12, 106);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(104, 32);
            this.btnAnimate.TabIndex = 40;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.Visible = false;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 32);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Restart";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 152);
            this.textBox1.TabIndex = 42;
            this.textBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 401);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Moves);
            this.Controls.Add(this.lbl_Disk1);
            this.Controls.Add(this.lbl_Disk2);
            this.Controls.Add(this.lbl_Disk3);
            this.Controls.Add(this.lbl_Disk4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pole1);
            this.Controls.Add(this.Pole2);
            this.Controls.Add(this.Pole3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Towers of Hanoi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Disk1;
        private System.Windows.Forms.Label lbl_Disk2;
        private System.Windows.Forms.Label lbl_Disk3;
        private System.Windows.Forms.Label lbl_Disk4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Pole1;
        private System.Windows.Forms.Label Pole2;
        private System.Windows.Forms.Label Pole3;
        private System.Windows.Forms.TextBox txt_Moves;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer1;
    }
}

