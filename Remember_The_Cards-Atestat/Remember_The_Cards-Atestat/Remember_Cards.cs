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
    public partial class Remember_Cards : Form
    {
        private Form1 mainForm = null;
        public Remember_Cards(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Remember_Cards_Load(object sender, EventArgs e)
        {

        }
    }
}
