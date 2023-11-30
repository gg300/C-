using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ceva_caine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("F:\\ceva caine");

            FileInfo[] imag = dir.GetFiles();
            
            foreach(object item in checkedListBox1.CheckedItems)
            {
            foreach (FileInfo file in imag)
            {
                if(file.Extension == "." + item) { 
                    listBox1.Items.Add(file);
                    Image imagine = Image.FromFile(file.FullName);  
                    
                    }
            }
                

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
