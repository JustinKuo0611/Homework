using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        int MouseMoveX = 0, MouseMoveY = 0;
        int GoTop = 0, ToLeft = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > (this.Width - pictureBox1.Width))
            {
                GoTop = 0;
            }
            if (pictureBox1.Left < 0)
            {
                GoTop = 1;
            }

            if (pictureBox1.Top > (this.Height - pictureBox1.Height))
            {
                ToLeft = 0;
            }
            if (pictureBox1.Top < 0)
            {
                ToLeft = 1;
            }

            if (GoTop != 0)
            {
                this.pictureBox1.Left += 80;
            }
            else
            {
                this.pictureBox1.Left -= 80;
            }

            if (ToLeft != 0)
            {
                this.pictureBox1.Top += 80;
            }
            else
            {
                this.pictureBox1.Top -= 80;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((MouseMoveX != 0) && (MouseMoveY !=0))
            {
                if ((Math.Abs(MouseMoveX - e.X) > 5) || Math.Abs(MouseMoveY - e.Y) > 5)
                {
                    Application.Exit();
                }
            }
            MouseMoveX = e.X;
            MouseMoveY = e.Y;
        }
    }
}
