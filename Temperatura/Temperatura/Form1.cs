namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double temperatura;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Title_Click(object sender, EventArgs e)
        {

        }

        private void transform_Click(object sender, EventArgs e)
        {
            double conversie;
            try
            {
                if (text_temp.Text != "")
                {
                    temperatura = Convert.ToDouble(text_temp.Text);
                }
                if (rad_temp_1.Checked == true)
                {
                    conversie = 9.0 / 5 * temperatura + 32;
                    text_conv.Text = "" + Math.Round(conversie);
                    label_masura.Text = ($"grade {rad_temp_2.Text}");
                }
                else if (rad_temp_2.Checked == true)
                {
                    conversie = (temperatura - 32) * 5.0 / 9;
                    text_conv.Text = "" + Math.Round(conversie);
                    label_masura.Text = ($"grade {rad_temp_1.Text}");
                }
                else
                {
                    MessageBox.Show("AAAAAAAAAAAAAAAAAAAAAAAA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incearca cifre");
            }



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult raspuns = new DialogResult();
            raspuns = MessageBox.Show("Do you really wanna exit?", "exit", MessageBoxButtons.YesNo);
            if (raspuns == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_temperatura_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            text_temp.Text = "";
            text_conv.Text = "";
            label_masura.Text = "(measure)";
            rad_temp_1.Checked = false; 
            rad_temp_2.Checked = false;
        }
    }
}