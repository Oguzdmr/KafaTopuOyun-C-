using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        int x = 10, y = 10,l=10;
        int i = 0,k=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void oyuncuCrpma()
        {
            Rectangle o1 = new Rectangle();
            Rectangle o2 = new Rectangle();
            Rectangle t = new Rectangle();

            o1.X = picOyuncu1.Left;
            o1.Y = picOyuncu1.Top;
            o1.Height = picOyuncu1.Height;
            o1.Width = picOyuncu1.Width;

            o2.X = picOyuncu2.Left;
            o2.Y = picOyuncu2.Top;
            o2.Height = picOyuncu2.Height;
            o2.Width = picOyuncu2.Width;

            t.X = Top.Left;
            t.Y = Top.Top;
            t.Height = Top.Height;
            t.Width = Top.Width;

            if (t.IntersectsWith(o2))
            {
                if (y > 0 && x > 0)
                {
                    if (o2.Top <= t.Bottom && o2.Left >= t.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (o2.Top <= t.Bottom && o2.Right >= t.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (o2.Bottom >= t.Top && o2.Left >=t.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (o2.Bottom <= t.Top && o2.Right >= t.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            else if (t.IntersectsWith(o1))
            {
                if (y > 0 && x > 0)
                {
                    if (o1.Top <= t.Bottom && o1.Left >= t.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (o1.Top <= t.Bottom && o1.Right >= t.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (o1.Bottom >= t.Top && o1.Left >= t.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (o1.Bottom <= t.Top && o1.Right >= t.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
            }

        }

        private void carpma()
        {
            Rectangle k1 = new Rectangle();
            Rectangle k2 = new Rectangle();
            Rectangle t = new Rectangle();

            k1.X = Kale1.Left;
            k1.Y = Kale1.Top;
            k1.Height = Kale1.Height;
            k1.Width = Kale1.Width;

            k2.X = Kale2.Left;
            k2.Y = Kale2.Top;
            k2.Height = Kale2.Height;
            k2.Width = Kale2.Width;

            t.X = Top.Left;
            t.Y = Top.Top;
            t.Height = Top.Height;
            t.Width = Top.Width;

            if (t.IntersectsWith(k1))
            {
                k++;
                label8.Text = Convert.ToString(k);
                Top.Location = new Point(446, 177);
                
            }

            if (t.IntersectsWith(k2))
            {
                i++;
                label9.Text = Convert.ToString(i);
                Top.Location = new Point(446, 177);
                
            }

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

           
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Top.Left += x;
            Top.Top += y;

            if (Top.Left > this.Width - Top.Width)
            {
                x = x * -1;

            }
            if (Top.Left < 0)
            {
                x = x * -1;
            }
            if (Top.Top > this.Height - Top.Height)
            {
                y = y * -1;
            }
            if (Top.Top < 0)
            {
                y = y * -1;
            }


            oyuncuCrpma();
            carpma();

        }

    
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
          
            if (e.KeyCode == Keys.Up)
            {
                picOyuncu2.Top -= l;
            }
            if (e.KeyCode == Keys.Down)
            {
                picOyuncu2.Top += l;
            }
            if (e.KeyCode == Keys.Right)
            {
                picOyuncu2.Left += l;
            }
            if (e.KeyCode == Keys.Left)
            {
                picOyuncu2.Left -= l;
            }
            
        }

        private void timerHareket_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==119 || e.KeyChar==87)
            picOyuncu1.Top -= l;

            if (e.KeyChar == 115 || e.KeyChar == 83)
                picOyuncu1.Top += l;

            if (e.KeyChar == 100 || e.KeyChar == 68)
                picOyuncu1.Left += l;

            if (e.KeyChar == 97 || e.KeyChar == 65)
                picOyuncu1.Left -= l;
        }
    }
}
