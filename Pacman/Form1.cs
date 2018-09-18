using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            SolidBrush pacmanBrush = new SolidBrush(Color.Yellow);
            Font congratsFont = new Font("Arial", 15, FontStyle.Italic);

            int x = 2;
            int y = 45;


            while (x != 202)
            {
                Redraw();
                x = x + 20;
                g.FillPie(pacmanBrush, x, y, 49, 49, 30, 300);
                Thread.Sleep(200);
                Redraw();
                x = x + 20;
                g.FillEllipse(pacmanBrush, x, y, 49, 49);
                Thread.Sleep(200);
            }
            while (y != 225)
            {
                Redraw();
                y = y + 20;
                g.FillPie(pacmanBrush, x, y, 49, 49, 120, 300);
                Thread.Sleep(200);
                if (y != 225)
                {
                    Redraw();
                    y = y + 20;
                    g.FillEllipse(pacmanBrush, x, y, 49, 49);
                    Thread.Sleep(200);
                }
            }
            g.DrawString("Congratulations!", congratsFont, pacmanBrush, 300, 50);
        }

        private void Redraw()
        {
            //I noticed I was copy and pasting too many times, so there's a function!
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Pen borderPen = new Pen(Color.White, 7);
            g.DrawLine(borderPen, 50, 40, 260, 40);
            g.DrawLine(borderPen, 257, 37, 257, 250);
            g.DrawLine(borderPen, 50, 100, 200, 100);
            g.DrawLine(borderPen, 197, 97, 197, 250);
        }
        //let's say I've made some changes

    }
}