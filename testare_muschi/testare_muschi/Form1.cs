using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testare_muschi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        muschi_anteriori m_a = new muschi_anteriori(this);
            m_a.Show();
            m_a.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        muschi_posteriori m_p = new muschi_posteriori(this);
            m_p.Show();
            m_p.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
