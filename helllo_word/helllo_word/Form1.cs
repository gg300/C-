using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace helllo_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void link_l_foldersifisier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
            Process.Start("E://");
            }
            catch {MessageBox.Show("Invalid Command", "Error",MessageBoxButtons.OK); }
        }

        private void link_minister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.edupedu.ro");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (object item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexer = 0;
            while (indexer < checkedListBox1.Items.Count)
            {
            checkedListBox1.SetItemChecked(indexer, false);
                indexer++;
            }

            listBox1.Items.Clear();


        }
    }
}
