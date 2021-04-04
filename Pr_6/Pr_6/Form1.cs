using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            generateTextBox.Text = "";
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                generateTextBox.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "";
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] > 0) Mas[i]++;
                outputTextBox.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }
    }
}
