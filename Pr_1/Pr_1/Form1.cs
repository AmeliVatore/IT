using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        int label_1 = 0;
        int label_2 = 0;
        int label_3 = 0;
        int label_4 = 1;

        // 143; 1 - 1 и 3; 4 - 3 и 4; 3 - 2, 3, 4; 2 - 4; - уже не используется
        // 1 - 2 и, 4; 2 - 4; 3 - 2 и 4; 4 - 3 и 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_1 ++;
            if (label_1 % 2 == 0) label1.Visible = true;
            if (label_1 % 2 == 1) label1.Visible = false;
            label_3++;
            if (label_3 % 2 == 0) label3.Visible = true;
            if (label_3 % 2 == 1) label3.Visible = false;
            label_4++;
            if (label_4 % 2 == 0) label4.Visible = true;
            if (label_4 % 2 == 1) label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_4++;
            if (label_4 % 2 == 0) label4.Visible = true;
            if (label_4 % 2 == 1) label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_2++;
            if (label_2 % 2 == 0) label2.Visible = true;
            if (label_2 % 2 == 1) label2.Visible = false;          
            label_4++;
            if (label_4 % 2 == 0) label4.Visible = true;
            if (label_4 % 2 == 1) label4.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_3++;
            if (label_3 % 2 == 0) label3.Visible = true;
            if (label_3 % 2 == 1) label3.Visible = false;
            label_4++;
            if (label_4 % 2 == 0) label4.Visible = true;
            if (label_4 % 2 == 1) label4.Visible = false;
        }
    }
}
