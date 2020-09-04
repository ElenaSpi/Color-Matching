using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_colors
{
    class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(IContainer container)
        {
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.UserMouse, true);
            TabStop = true;
            container.Add(this);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (this.Focused)
                ControlPaint.DrawFocusRectangle(pe.Graphics, ClientRectangle);
            base.OnPaint(pe);
        }
        
        public void changeColor(CustomPictureBox box, Color color)
        {
            box.BackColor = color;
        }

        Color[] colors = { Color.Purple, Color.Tomato, Color.Yellow};
        Random random = new Random();
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (this.Left <= (game.ActiveForm.Width - 122))
                {
                    e.IsInputKey = true;
                    x += 20;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (this.Left >= 0)
                    x -= 20;
            } 
            this.Location = new Point(x, y);
            if (e.KeyCode == Keys.Space)
            {
                changeColor(this, colors[random.Next(colors.Length)]);
            }
            base.OnPreviewKeyDown(e);
        }
    }
}