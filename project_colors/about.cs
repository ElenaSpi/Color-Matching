using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_colors
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            labels();
        }

        void labels()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bgpic.Visible = false;
        }
        
        private void checkFull_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFull.Checked)
            {
                bgpic.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else if (!checkFull.Checked)
            {
                labels();
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menuForm = new menu();
            menuForm.ShowDialog();
        }
    }
}
