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

namespace Probability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Titles.Add("Вероятность совпадения чисел с количеством их повторений в массиве при 100 запусках");
            Series series = chart1.Series.Add("Числа");
            series.Color = Color.Pink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && int.Parse(textBox1.Text) > 0 && int.Parse(textBox2.Text) > 0)
            {
                int N = int.Parse(textBox1.Text);
                int M = int.Parse(textBox2.Text);
                chart1.Series.Clear();
                Series series = chart1.Series.Add("Числа");
                series.Color = Color.Pink;
                int[] nums = new int[M];
                for (int i = 0; i < 100; i++)
                {
                    int[] mass = RandArray.RandFill(N, M);
                    int[] num = RandArray.Count(mass, M);
                    for (int j = 0; j < M; j++)
                        if (num[j] == j)
                            nums[j]++;
                }
                double[] p = new double[M];
                for (int j = 0; j < M; j++)
                    p[j] = (double)nums[j] / 100;
                for (int i = 0; i < M; i++)
                    series.Points.AddXY(i, p[i]);
            }
        }
    }
}
