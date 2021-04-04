using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pr_8
{
    public partial class Form1 : Form
    {
        //y = (3 * (x * x - Math.Abs(3 * x)) + Math.Abs(1 - Math.Cos(x * x))) / (2 * Math.Exp(3 * x - 2) - 3 * (2 + x) / x);
        private double XMin = -100;
        private double XMax = 25;
        private double Step = 10;
        private double[] x;
        private double[] y;
        Chart chart;

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            x = new double[count];
            y = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i;
                y[i] = (3 * (x[i] * x[i] - Math.Abs(3 * x[i])) + Math.Abs(1 - Math.Cos(x[i] * x[i]))) / (2 * Math.Exp(3 * x[i] - 2) - 3 * (2 + x[i]) / x[i]);
            }
        }
        private void CreateChart()
        {
            chart = new Chart();
            chart.Parent = this;
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            ChartArea area = new ChartArea();
            area.Name = "myGraph";
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            area.AxisX.MajorGrid.Interval = Step;
            chart.ChartAreas.Add(area);

            Series series = new Series();
            series.ChartArea = "myGraph";
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;
            series.LegendText = "Функция ";
            chart.Series.Add(series);

            Legend legend = new Legend();
            legend.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
            chart.Legends.Add(legend);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();
            CalcFunction();
            chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}
