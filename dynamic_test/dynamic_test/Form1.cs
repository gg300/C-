using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        int[] c = new int[100];
        TextBox[] a = new TextBox[123];
        private void b_gen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(text.Text);
            for(int i = 1; i <= n; i++)
            { 
                a[i] = new TextBox();
                a[i].Width = 30; a[i].Height = 30;
                a[i].Font = new Font("Arial", 24);
                a[i].Location = new Point((i - 1) * 30 + 10, 200);
                a[i].Name = "NR" + i;
                do
                {
                    x = rnd.Next(1, n + 1);

                } while (c[x] == 1);
                c[x] = 1;
                a[i].Text = "" + x;
                this.Controls.Add(a[i]);
                b_gen.Enabled=false;
            }
            text.Enabled=false;
        }

        private void b_prev_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(text.Text);
            for (int i = 1; i <= n; i++)
            {
                int cif = Convert.ToInt32(a[i].Text);
                --cif;
                if(cif>=1) a[i].Text = Convert.ToString(cif);
                else a[i].Text = Convert.ToString(n);
            }
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(text.Text);
            for (int i = 1; i <= n; i++)
            {
                int cif = Convert.ToInt32(a[i].Text);
                ++cif;
                if (cif <= n) a[i].Text = Convert.ToString(cif);
                else a[i].Text = Convert.ToString(1);
            }
        }
    }
}
