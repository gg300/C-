using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testare_muschi
{
    public partial class muschi_posteriori : Form
    {
        private Form1 mainForm = null;
        public muschi_posteriori(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
        private void verif_txt(TextBox tex)
        {
            tex.BackColor = Color.Green;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;
            
        }
        private void er_txt(TextBox tex)
        {
            tex.BackColor = Color.Red;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (b_antebrat.Text.ToLower() == "antebrat")
            {
                verif_txt(b_antebrat);
            }
            else {
                er_txt(b_antebrat);
                    
                    }
            if(b_deltoid.Text.ToLower() == "deltoid")
            {
                verif_txt(b_deltoid);
            }
            else {
                er_txt(b_deltoid);
            }
            if (b_dorsalul_mare.Text.ToLower() == "dorsalul mare")
            {
                verif_txt(b_dorsalul_mare);
            }
            else {
                er_txt(b_dorsalul_mare);
                    
                    }
            if (b_fesieri.Text.ToLower() == "fesieri" || b_fesieri.Text.ToLower() == "fesier")
            {
                verif_txt(b_fesieri);
            }
            else {
                er_txt(b_fesieri);
            }
            if (b_gastrocnemian_lateral.Text.ToLower() == "gastrocnemian lateral")
            {
                verif_txt(b_gastrocnemian_lateral);
            }
            else {
                er_txt(b_gastrocnemian_lateral);
            }
            if (b_gastrocnemian_median.Text.ToLower() == "gastrocnemian medial")
            {
                verif_txt(b_gastrocnemian_median);
            }
            else { er_txt(b_gastrocnemian_median); }
            if (b_rotund_mare.Text.ToLower() == "rotund mare")
            {
                verif_txt(b_rotund_mare);
            }
            else { er_txt(b_rotund_mare); }
            if (b_semimembranos.Text.ToLower() == "semimembranos")
            {
                verif_txt(b_semimembranos);
            }
            else { er_txt(b_semimembranos); }
            if (b_trapez.Text.ToLower() == "trapez")
            {
                verif_txt(b_trapez);
            }
            else { er_txt(b_trapez); }
            if (b_triceps.Text.ToLower() == "triceps")
            {
                verif_txt(b_triceps);
            }
            else { er_txt(b_triceps); }
        }
    }
}
