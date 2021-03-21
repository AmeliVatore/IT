using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }

        static double Sum(int n)
        {
            double res = 0;
            int n_Current = 2;
            double res_Current;
            double chislitel;
            double znamenatel;
            while (n_Current <= n)
            {
            chislitel = n_Current - 1;
            znamenatel = 2 * Factorial(n_Current) - 2;
            res_Current = chislitel / znamenatel;
            res += res_Current;
            n_Current++;
            }
            return res;
        }

        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }

        private void raschetButton_Click(object sender, EventArgs e)
        {
            int n;
            if (vvodTextBox.TextLength == 0)
            MessageBox.Show("Введите число", "Вы не ввели число", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                n = Convert.ToInt32(vvodTextBox.Text);
                if (n < 2)
                    MessageBox.Show("Вводимое число должно быть больше или равно 2", "Неверное число", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    double S = Sum(n);
                    resultTextBox.Text = "При n = " + n + Environment.NewLine + "Сумма ряда S = " + S;
                }
            }
        }
    }
}
