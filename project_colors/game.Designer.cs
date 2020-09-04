namespace project_colors
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelNumPoints = new System.Windows.Forms.Label();
            this.gameOverPic = new System.Windows.Forms.PictureBox();
            this.labelLvl = new System.Windows.Forms.Label();
            this.labellNumlvl = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.igrac = new project_colors.CustomPictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Purple;
            this.box1.Location = new System.Drawing.Point(1, 69);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(383, 50);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Yellow;
            this.box2.Location = new System.Drawing.Point(378, 69);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(241, 50);
            this.box2.TabIndex = 1;
            this.box2.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Tomato;
            this.box3.Location = new System.Drawing.Point(614, 69);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(187, 50);
            this.box3.TabIndex = 2;
            this.box3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.Gold;
            this.labelPoints.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(3, 8);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(158, 40);
            this.labelPoints.TabIndex = 5;
            this.labelPoints.Text = "Points: ";
            // 
            // labelNumPoints
            // 
            this.labelNumPoints.AutoSize = true;
            this.labelNumPoints.BackColor = System.Drawing.Color.Gold;
            this.labelNumPoints.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPoints.Location = new System.Drawing.Point(157, 8);
            this.labelNumPoints.Name = "labelNumPoints";
            this.labelNumPoints.Size = new System.Drawing.Size(62, 40);
            this.labelNumPoints.TabIndex = 6;
            this.labelNumPoints.Text = "0  ";
            // 
            // gameOverPic
            // 
            this.gameOverPic.Image = ((System.Drawing.Image)(resources.GetObject("gameOverPic.Image")));
            this.gameOverPic.Location = new System.Drawing.Point(1, 51);
            this.gameOverPic.Name = "gameOverPic";
            this.gameOverPic.Size = new System.Drawing.Size(800, 400);
            this.gameOverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOverPic.TabIndex = 7;
            this.gameOverPic.TabStop = false;
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.BackColor = System.Drawing.Color.Gold;
            this.labelLvl.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLvl.Location = new System.Drawing.Point(607, 8);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(138, 40);
            this.labelLvl.TabIndex = 8;
            this.labelLvl.Text = "Level: ";
            // 
            // labellNumlvl
            // 
            this.labellNumlvl.AutoSize = true;
            this.labellNumlvl.BackColor = System.Drawing.Color.Gold;
            this.labellNumlvl.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellNumlvl.Location = new System.Drawing.Point(737, 8);
            this.labellNumlvl.Name = "labellNumlvl";
            this.labellNumlvl.Size = new System.Drawing.Size(51, 40);
            this.labellNumlvl.TabIndex = 9;
            this.labellNumlvl.Text = " 1";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Gold;
            this.picBox.Location = new System.Drawing.Point(-9, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(809, 52);
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // picWinner
            // 
            this.picWinner.Image = ((System.Drawing.Image)(resources.GetObject("picWinner.Image")));
            this.picWinner.Location = new System.Drawing.Point(1, 51);
            this.picWinner.Name = "picWinner";
            this.picWinner.Size = new System.Drawing.Size(799, 399);
            this.picWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWinner.TabIndex = 12;
            this.picWinner.TabStop = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.YellowGreen;
            this.lblPause.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPause.Location = new System.Drawing.Point(269, -12);
            this.lblPause.Name = "lblPause";
            this.lblPause.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.lblPause.Size = new System.Drawing.Size(72, 64);
            this.lblPause.TabIndex = 13;
            this.lblPause.Text = "⏸";
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.YellowGreen;
            this.lblStart.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(341, -4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.lblStart.Size = new System.Drawing.Size(74, 56);
            this.lblStart.TabIndex = 14;
            this.lblStart.Text = " ▶";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.LightGray;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenu.Location = new System.Drawing.Point(415, -4);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.lblMenu.Size = new System.Drawing.Size(138, 56);
            this.lblMenu.TabIndex = 15;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // igrac
            // 
            this.igrac.BackColor = System.Drawing.Color.Pink;
            this.igrac.Location = new System.Drawing.Point(347, 343);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(121, 47);
            this.igrac.TabIndex = 4;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.gameOverPic);
            this.Controls.Add(this.picWinner);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.labellNumlvl);
            this.Controls.Add(this.labelLvl);
            this.Controls.Add(this.labelNumPoints);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.igrac);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.Name = "game";
            this.Text = "Color Matching Game";
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.Timer timer1;
        private CustomPictureBox igrac;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelNumPoints;
        private System.Windows.Forms.PictureBox gameOverPic;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Label labellNumlvl;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox picWinner;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblMenu;
    }
}

