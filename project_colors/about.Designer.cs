namespace project_colors
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMadeby = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.picStyle = new System.Windows.Forms.PictureBox();
            this.checkFull = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Thistle;
            this.lblDesc.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Location = new System.Drawing.Point(35, 23);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(10);
            this.lblDesc.Size = new System.Drawing.Size(248, 60);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightBlue;
            this.lblName.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(168, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(542, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Game Name: Color Matching";
            // 
            // lblMadeby
            // 
            this.lblMadeby.AutoSize = true;
            this.lblMadeby.BackColor = System.Drawing.Color.White;
            this.lblMadeby.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMadeby.Location = new System.Drawing.Point(169, 116);
            this.lblMadeby.Name = "lblMadeby";
            this.lblMadeby.Size = new System.Drawing.Size(461, 40);
            this.lblMadeby.TabIndex = 2;
            this.lblMadeby.Text = "Elena Spirkoska 171186";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.LightGray;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenu.Location = new System.Drawing.Point(706, 22);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.lblMenu.Size = new System.Drawing.Size(70, 62);
            this.lblMenu.TabIndex = 17;
            this.lblMenu.Text = "↩";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // picStyle
            // 
            this.picStyle.BackColor = System.Drawing.Color.White;
            this.picStyle.Location = new System.Drawing.Point(0, 104);
            this.picStyle.Name = "picStyle";
            this.picStyle.Size = new System.Drawing.Size(799, 120);
            this.picStyle.TabIndex = 18;
            this.picStyle.TabStop = false;
            // 
            // checkFull
            // 
            this.checkFull.AutoSize = true;
            this.checkFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkFull.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFull.Location = new System.Drawing.Point(329, 63);
            this.checkFull.Name = "checkFull";
            this.checkFull.Size = new System.Drawing.Size(198, 21);
            this.checkFull.TabIndex = 19;
            this.checkFull.Text = "Read full description?";
            this.checkFull.UseVisualStyleBackColor = false;
            this.checkFull.CheckedChanged += new System.EventHandler(this.checkFull_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(42, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "The game has simple rules. You need to have matching colors on the bars that move" +
    "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "and your player.  It has implemented 4 levels, each with 25 points difference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "If the colors of the bars and the player don\'t match - you lose the game.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(624, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "and faster moving horizontal bars. If you reach 100+ points, you are a winner.";
            // 
            // bgpic
            // 
            this.bgpic.BackColor = System.Drawing.Color.LightCoral;
            this.bgpic.Location = new System.Drawing.Point(0, 278);
            this.bgpic.Name = "bgpic";
            this.bgpic.Size = new System.Drawing.Size(807, 126);
            this.bgpic.TabIndex = 25;
            this.bgpic.TabStop = false;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkFull);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMadeby);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.picStyle);
            this.Controls.Add(this.bgpic);
            this.DoubleBuffered = true;
            this.Name = "about";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMadeby;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picStyle;
        private System.Windows.Forms.CheckBox checkFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox bgpic;
    }
}