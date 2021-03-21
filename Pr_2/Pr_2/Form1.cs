using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vvodTextBox.TextLength == 0)
                MessageBox.Show("Введите число", "Вы не ввели число", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                double x = double.Parse(vvodTextBox.Text);
                double y;
                y = (3 * (x * x - Math.Abs(3 * x)) + Math.Abs(1 - Math.Cos(x * x))) / (2 * Math.Exp(3 * x - 2) - 3 * (2 + x) / x);
                vyvodTextBox.Text = "При x = " + x.ToString() + Environment.NewLine + "Результат y = " + y.ToString();
            }
        }
    }
}
