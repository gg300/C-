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
    public partial class muschi_anteriori : Form
    {
        private Form1 mainForm = null;
        public muschi_anteriori(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (b_abdominal.Text.ToLower() == "abdominal")
            {
                verif_txt(b_abdominal);
            }
            else
            {
                er_txt(b_abdominal);
            }
            if (b_biceps.Text.ToLower() == "biceps")
            {
                verif_txt(b_biceps);
            }
            else
            {
                er_txt(b_biceps);
            }
            if (b_deltoid.Text.ToLower() == "deltoid")
            {
                verif_txt(b_deltoid);
            }
            else {
                er_txt(b_deltoid);
            }
            if (b_drept_femural.Text.ToLower() == "drept femural" || b_drept_femural.Text == "femur")
            {
                verif_txt(b_drept_femural);
            }
            else
            {
                er_txt(b_drept_femural);
            }
            if (b_flexor_radial.Text.ToLower() == "flexor radial")
            {
                verif_txt(b_flexor_radial);
            }
            else
            {
                er_txt(b_flexor_radial);
            }
            if (b_gastrocnemius.Text.ToLower() == "gastrocnemius")
            {
                verif_txt(b_gastrocnemius);
            }
            else
            {
                er_txt(b_gastrocnemius);
            }
            if (b_oblici.Text.ToLower() == "oblici")
            {
                verif_txt(b_oblici);
            }
            else
            {
                er_txt(b_oblici);
            }
            if (b_pectoral.Text.ToLower() == "pectoral" || b_pectoral.Text.ToLower() == "pectorali")
            {
                verif_txt(b_pectoral);
            }
            else
            {
                er_txt(b_pectoral);
            }
            if (b_peronier_lung.Text.ToLower() == "peronier lung" || b_peronier_lung.Text.ToLower()== "peronier")
            {
                verif_txt(b_peronier_lung);
            }
            else
            {
                er_txt(b_peronier_lung);
            }
            if (b_trapez.Text.ToLower() == "trapez")
            {
                verif_txt(b_trapez); ;
            }
            else
            {
                er_txt(b_trapez);
            }
            if (b_triceps_medial.Text.ToLower() == "triceps medial" || b_triceps_medial.Text.ToLower() == "triceps")
            {
                verif_txt(b_triceps_medial);
            }
            else
            {
                er_txt(b_triceps_medial) ;
            }
        }
    }
}
