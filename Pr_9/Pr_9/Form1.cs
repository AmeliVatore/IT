using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_9
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.DarkGray, 3);
        SolidBrush dimGray_SolidBrush = new SolidBrush(Color.DarkCyan);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Wheat);
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(new Pen(Brushes.Gray, 4), 10, 10 * i - 2, 500, 4 * i + 50);
            }
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(new Pen(Brushes.DimGray, 4), 500, 4 * i + 50, 701, 4 * i + 50);
            }
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(new Pen(Brushes.DarkCyan, 4), 700, 4 * i + 50, 795, 10 * i - 2);
            }

            g.FillRectangle(dimGray_SolidBrush, 0, 0, 45, 450);
            g.DrawLine(new Pen(Brushes.White, 5), 48, 0, 48, 450);
            g.DrawLine(new Pen(Brushes.Black, 5), 45, 0, 45, 450);
            g.DrawLine(new Pen(Brushes.White, 5), 794, 0, 794, 450);
            g.DrawLine(new Pen(Brushes.Black, 5), 797, 0, 797, 450);

            // Голова
            g.FillEllipse(new SolidBrush(Color.White), 444, 94, 212, 212);
            
            // Левая часть платья
            g.DrawLine(new Pen(Brushes.White, 5), 397, 497, 547, 247);
            for (int i = 25; i < 50; i++)
            {
                g.DrawLine(new Pen(Brushes.Olive, 9), 405, 505, 555, 10 * i);
            }
            g.DrawLine(new Pen(Brushes.Black, 5), 400, 500, 550, 250);

            // Правая часть платья
            g.DrawLine(new Pen(Brushes.White, 5), 682, 507, 557, 257);
            for (int i = 25; i < 50; i++)
            {
                g.DrawLine(new Pen(Brushes.Olive, 9), 660, 485, 550, 10 * i + 2);
            }
            g.DrawLine(new Pen(Brushes.Black, 5), 675, 500, 550, 250);

            // Продолжение головы (то, что над платьем)
            g.FillEllipse(new SolidBrush(Color.MistyRose), 450, 100, 200, 200);
            g.DrawEllipse(new Pen(Brushes.Black, 6), 450, 100, 200, 200);

            // Причёска
            g.DrawArc(new Pen(Brushes.Black, 7), 380, 50, 200, 200, 100, -127);
            for (int i = 10; i > 7; i--)
            {
                g.DrawArc(new Pen(Brushes.Black, 9), 3 * i + 345, 5 * i, 20 * i, 200, 100, -127);
            }
            g.DrawArc(new Pen(Brushes.Black, 9), 3 * 7 + 345, 5 * 7, 20 * 7, 200, 100, -120);
            g.DrawArc(new Pen(Brushes.Black, 9), 3 * 6 + 345, 5 * 6, 20 * 6, 200, 100, -107);
            g.FillEllipse(new SolidBrush(Color.Black), 580, 180, 45, 45);
            g.DrawArc(new Pen(Brushes.Black, 7), 580, 175, 45, 45, 100, -125);
        }
    }
}
