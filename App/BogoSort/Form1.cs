using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BogoSort
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public int Factorial(int n)
        {
            int r = 1;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }

        public int Combination(int k, int n)
        {
            int c = Factorial(n) / (Factorial(k) * Factorial(n - k));
            return c;
        }

        public double Prob(int lmas)
        {
            return 1 / Convert.ToDouble(Convert.ToInt32(z2tbd.Text) - Convert.ToInt32(z2tbo.Text) + 1);
        }

        public double FormulaP(int k, int n)
        {
            int c = Combination(k, n);
            double p = Math.Pow(Prob(n), k);
            double q = Math.Pow((1 - Prob(n)), (n - k));
            double itog = c * p * q;
            return itog;
        }

        public int[] MasShuffle(int[] mas)
        {
            List<int> temp = new List<int>(mas);
            int b = temp.Count();
            for(int i = 0; i < b; i++)
            {
                int curI = rnd.Next(0, temp.Count());
                mas[i] = temp[curI];
                temp.RemoveAt(curI);
            }
            return mas;
        }
        public int[] StartRandom(int n, int s, int f)
        {
            int[] r = new int[n];
            for(int i = 0; i < n; i++)
            {
                int temp = rnd.Next(s, f);
                r[i] = temp;
            }
            return r;
        }
        public bool IfSort(int[] mas)
        {
            bool flag = true;
            for(int i = 1; i < mas.Count(); i++)
            {
                if(mas[i - 1] > mas[i])
                {
                    flag = false;
                }
            }
            return flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbStart.Text = Convert.ToString(0);
            tbEnd.Text = Convert.ToString(100);
            tbBSr.Text = Convert.ToString(10);
            z2tbo.Text = Convert.ToString(1);
            z2tbd.Text = Convert.ToString(4);
            z2tbr.Text = Convert.ToString(10);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            Stopwatch watch = new Stopwatch();
            double raz = 0;
            int n = 2;
            while(n != Convert.ToInt32(tbBSr.Text))
            {
                watch.Start();
                int[] mas = StartRandom(n, Convert.ToInt32(tbStart.Text), Convert.ToInt32(tbEnd.Text));
                while (true)
                {
                    if (IfSort(mas))
                    {
                        watch.Stop();
                        chart1.Series["Series1"].Points.AddXY(n, watch.ElapsedMilliseconds);
                        n++;
                        watch.Restart();
                        break;
                    }
                    mas = MasShuffle(mas);
                }
            }
        }



        private void z2b_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            int[] stats = new int[Convert.ToInt32(z2tbd.Text) - Convert.ToInt32(z2tbo.Text) + 1];
            for(int i = 0; i < stats.Count(); i++)
            {
                stats[i] = 0;
            }
            int[] mast = new int[Convert.ToInt32(z2tbr.Text)];
            for (int i = 0; i < mast.Count(); i++)
            {
                int randi = rnd.Next(Convert.ToInt32(z2tbo.Text), Convert.ToInt32(z2tbd.Text) + 1);
                mast[i] = randi;
                for (int k = Convert.ToInt32(z2tbo.Text); k <= Convert.ToInt32(z2tbd.Text); k++)
                {
                    if (randi == k)
                    {
                        int index = k - Convert.ToInt32(z2tbo.Text);
                        stats[index] = stats[index] + 1;
                    }
                }
            }
            for (int i = Convert.ToInt32(z2tbo.Text); i <= Convert.ToInt32(z2tbd.Text); i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, stats[i - Convert.ToInt32(z2tbo.Text)]);
                if(i == stats[i - Convert.ToInt32(z2tbo.Text)])
                {
                    chart2.Series["Series1"].Points[chart2.Series["Series1"].Points.Count - 1].Color = Color.Red;
                }
            }
        }
    }
}

//int i = Convert.ToInt32(z2tbo.Text);
//for (; i <= Convert.ToInt32(z2tbd.Text); i++)
//{
//    double test = FormulaP(i, Convert.ToInt32(z2tbr.Text));
//    chart2.Series["Series1"].Points.AddXY(i, FormulaP(i, Convert.ToInt32(z2tbr.Text)));

//}