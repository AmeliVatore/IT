using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    static double math(double x, int choice)
    {
      double res = 0;
      double f_x = 0;

      switch (choice)
      {
        case 1:
          f_x = (Math.Exp(x) - Math.Exp(-x)) / 2;
          break;
        case 2:
          f_x = (Math.Exp(x) + Math.Exp(-x)) / 2;
          break;
        case 3:
          f_x = Math.Exp(x);
          break;
      }

      if (x > 3) res = 0.5 * f_x;
      if ((x >= 0) && (x <= 3)) res = 2;
      if (x < 0) res = 1 / f_x;

      return res;
    }


    private void raschetButton_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(xTextBox.Text);

      int choice = 1;
      if (shRadioButton.Checked == true)
        choice = 2;
      else
      if (expRadioButton.Checked == true)
        choice = 3;

      double result = math(x, choice);
      resultTextBox.Text = "При x = " + x + Environment.NewLine + "y = " + result;
    }
  }
}
