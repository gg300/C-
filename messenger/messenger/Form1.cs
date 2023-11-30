using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_citeste.SelectionColor = Color.Blue;
            text_citeste.AppendText("Ionel: " + text_scrie.Text + "\n");
            text_scrie.Focus();
        }

        private void button_maria_Click(object sender, EventArgs e)
        {
            text_citeste.SelectionColor= Color.Red;
            text_citeste.AppendText("Maria: " + text_scrie.Text + "\n");
            text_scrie.Focus();

        }

        private void button_sterge_Click(object sender, EventArgs e)
        {
            text_citeste.Text = "";
        }

        private void button_salvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == DialogResult.OK)
                text_citeste.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
        }

        private void button_incarcare_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                text_citeste.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}
