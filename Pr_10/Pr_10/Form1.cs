using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_10
{
  public partial class Form1 : Form
  {
    private int x1, y1, r = 150, checker = 0;   // Ball
    private int lx1, ly1, lx2, ly2;             // Lines
    private int r1;                             // Shadow
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.FillEllipse(new SolidBrush(Color.Gray), x1 - 5, 345, r + 10, r1);
      g.FillEllipse(new SolidBrush(Color.Orange), x1, y1, r, r);
      g.DrawLine(new Pen(Brushes.Black, 3), lx1, ly1, lx1, ly1 + r);
      g.DrawLine(new Pen(Brushes.Black, 3), lx2, ly2, lx2 + r, ly2);
      g.DrawArc(new Pen(Brushes.Black, 3), lx1 - 50, ly1 - 45, 100, 100, 15, 150);
      g.DrawArc(new Pen(Brushes.Black, 3), lx2 + 25, ly2 + 20, 100, 100, -15, -150);
      g.DrawEllipse(new Pen(Brushes.Black, 3), x1, y1, r, r);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      x1 = ClientSize.Width / 2 - 75;
      y1 = ClientSize.Height / 2  - 150;
      lx1 = x1 + 75;
      ly1 = y1;
      lx2 = x1;
      ly2 = y1 + 75;
      r1 = r/2 + 5;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (checker == 0 && y1 < 275)
      {
        y1 += 50;
        ly1 += 50;
        ly2 += 50;
        if (y1 >= 275)
          checker = 1;
      }
      if (checker == 1 && y1 > 50)
      {
        y1 -= 50;
        ly1 -= 50;
        ly2 -= 50;
        if (y1 <= 50)
          checker = 0;
      }
        
      Invalidate();
    }
  }
}
