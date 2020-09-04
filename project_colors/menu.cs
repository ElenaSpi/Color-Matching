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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            game game = new game();
            game.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            help rules = new help();
            rules.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            about desc = new about();
            desc.ShowDialog();
        }
    }
}
