using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_7
{
    public partial class Form1 : Form
    {
        int[,] a = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int max = a[0, 0]; int max_i = 0; int max_j = 0;
            int min = a[0, 0]; int min_i = 0; int min_j = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i, j];
                        min_i = i;
                        min_j = j;
                    }
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        max_i = i;
                        max_j = j;
                    }
                }
            dataGridView1.Rows[max_i].Cells[max_j].Value = Convert.ToString(min);
            dataGridView1.Rows[min_i].Cells[min_j].Value = Convert.ToString(max);
            a[max_i, max_j] = min;
            a[min_i, min_j] = max;
        }
    }
}
