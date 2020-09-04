using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace project_colors
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            gameOverPic.Visible = false;
            picWinner.Visible = false;
        }

        Color [] colors = { Color.Purple, Color.DarkCyan, Color.Tomato, Color.Yellow };
        Random random = new Random();
        int total = 0;
        int levelFlag = 1;

        void move(PictureBox box)
        {
            if (box.Top <= this.Height)
            {
                if (levelFlag == 1)
                    box.Top += 8;
                if (levelFlag == 2)
                    box.Top += 10;
                
                if (levelFlag == 3)
                    box.Top += 12;
               
                if (levelFlag == 4) 
                   box.Top += 14;               
            }
            else
            {
                box.Top = 0;
                box.BackColor = colors[random.Next(colors.Length)];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move(box1);
            move(box2);
            move(box3);
            gameover(box1);
            gameover(box2);
            gameover(box3);
        }

        void gameover(PictureBox box)
        {
            
            if (box.Bounds.IntersectsWith(igrac.Bounds))
            {
                if(box.BackColor != igrac.BackColor)
                {
                    SoundPlayer player = new SoundPlayer(@"C:\Users\Lenovo\source\repos\project_colors\project_colors\sound\over.wav");
                    player.Play();
                    timer1.Enabled = false;
                    gameOverPic.Visible = true;
                    MessageBox.Show("Points earned: " + total + " You lost!","Help");
                    player.Stop();
                }
                else
                {
                    total++;
                    labelNumPoints.Text = total.ToString();
                    if(total > 25)
                    {
                        labellNumlvl.Text = "2";
                        levelFlag = 2;
                    }
                    if (total > 50)
                    {
                        labellNumlvl.Text = "3";
                        levelFlag = 3;
                        
                    }
                    if (total > 75)
                    {
                        labellNumlvl.Text = "4";
                        levelFlag = 4;
                    }
                    if (total == 101)
                    {
                        SoundPlayer player = new SoundPlayer(@"C:\Users\Lenovo\source\repos\project_colors\project_colors\sound\win.wav");
                        player.Play();
                        timer1.Enabled = false;
                        picWinner.Visible = true;
                        MessageBox.Show("Congratulations!", "Help");
                        player.Stop();
                    }
                }
                       
            }
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            menu f2 = new menu();
            f2.ShowDialog();
        }
    }
}
