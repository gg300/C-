using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaxia_dupa_o_luna_in_vaslui
{
    public partial class Form1 : Form
    {
        PictureBox[] picturebox = new PictureBox[67];
        public Form1()
        {
            InitializeComponent();
            picturebox[1] = pictureBox1;
            picturebox[2] = pictureBox2;
            picturebox[3] = pictureBox3;
            picturebox[4] = pictureBox4;
            picturebox[5] = pictureBox5;
            picturebox[6] = pictureBox6;
            picturebox[7] = pictureBox7;
            picturebox[8] = pictureBox8;
            picturebox[9] = pictureBox9;
            picturebox[10] = pictureBox10;
            picturebox[11] = pictureBox11;
            picturebox[12] = pictureBox12;
            picturebox[13] = pictureBox13;
            picturebox[14] = pictureBox14;
            picturebox[15] = pictureBox15;
            picturebox[16] = pictureBox16;
            picturebox[17] = pictureBox17;
            picturebox[18] = pictureBox18;
            picturebox[19] = pictureBox19;
            picturebox[20] = pictureBox20;
            picturebox[21] = pictureBox21;
            picturebox[22] = pictureBox22;
            picturebox[23] = pictureBox23;
            picturebox[24] = pictureBox24;
            picturebox[25] = pictureBox25;
            picturebox[26] = pictureBox26;
            picturebox[27] = pictureBox27;
            picturebox[28] = pictureBox28;
            picturebox[29] = pictureBox29;
            picturebox[30] = pictureBox30;
            picturebox[31] = pictureBox31;
            picturebox[32] = pictureBox32;
            picturebox[33] = pictureBox33;
            picturebox[34]= pictureBox34;
            picturebox[35]= pictureBox35;
            picturebox[36]= pictureBox36;
            picturebox[37]= pictureBox37;
            picturebox[38]= pictureBox38;
            picturebox[39]= pictureBox39;
            picturebox[40]= pictureBox40;
            picturebox[41]= pictureBox41;
            picturebox[42]= pictureBox42;
            picturebox[43]= pictureBox43;
            picturebox[44]= pictureBox44;
            picturebox[45]= pictureBox45;
            picturebox[46]= pictureBox46;
            picturebox[47]= pictureBox47;
            picturebox[48]= pictureBox48;
            picturebox[49]= pictureBox49;
            picturebox[50]= pictureBox50;
            picturebox[51]= pictureBox51;
            picturebox[52]= pictureBox52;
            picturebox[53]= pictureBox53;
            picturebox[54]= pictureBox54;
            picturebox[55]= pictureBox55;
            picturebox[56]= pictureBox56;
            picturebox[57]= pictureBox57;
            picturebox[58]= pictureBox58;
            picturebox[59]= pictureBox59;
            picturebox[60]= pictureBox60;
            picturebox[61]= pictureBox61;
            picturebox[62]= pictureBox62;
            picturebox[63]= pictureBox63;
            picturebox[64]= pictureBox64;
            picturebox[65]= pictureBox65;
            picturebox[66]= pictureBox66;
        }
        int dx = 10, dy=10,dhh ;
        bool key_left = false, key_right = false;
        Random ran = new Random();
        int score = 0 , lives = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 1; i <= 66; i++)
            {
                if (picturebox[i].Bounds.IntersectsWith(ball.Bounds))
                {
                    picturebox[i].Dispose();
                    picturebox[i].Location = new Point(Width+10,Height+20);
                    dy = -dy;
                    score += 1;
                }
            }
            ball.Top += dy;
            if (key_left == true)
            {
                if (player.Left >= 0)
                    player.Left -= dx;
            }
            if (key_right == true)
            { 
                if(player.Left <= Width-150)
                    player.Left += dx;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                dy = -dy;
                dhh = ran.Next(-5, 5);
            }
            if (ball.Top <= 0)
            {
                dy = -dy;
                dhh = ran.Next(-5, 5);
            }
            if(ball.Left <=0)
            {
                dhh = -dhh;

            }
            if (ball.Left >= Width-25)
            {
                dhh = -dhh;
            }
            ball.Left += dhh;
            if(ball.Top>= player.Top)
            {
                lives -= 1;
                ball.Location = new Point( Width/2, Height/2);
            }
            if (lives >= 0)
            {
            life.Text = "lives : " + lives;
            }
            if(lives <= 0)
            {
                lives = 9999;
                MessageBox.Show("esti gg");
                this.Close();
                
            }
            scoree.Text = $"score : {score}";
            if(score == 66)
            {
                MessageBox.Show("bravo tzarane");
                score = 0;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            key_left = false;  key_right = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                key_left = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                key_right = true;
            }
        }
    }
}
