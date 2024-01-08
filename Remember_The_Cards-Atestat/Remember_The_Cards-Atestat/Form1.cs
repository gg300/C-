using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember_The_Cards_Atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_play_Click(object sender, EventArgs e)
        {
           Remember_Cards game = new Remember_Cards(this);
            game.Show();
            game.Visible = true;
            this.Visible = false;   
        }
    }
}
