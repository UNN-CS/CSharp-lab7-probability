using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            int n =  Convert.ToInt32(textBox1.Text),n2= Convert.ToInt32(textBox2.Text)+1;
            var n1 = new Random(); 
            List<int> m = new List<int>(n);
            int[] mas = new int[n];
            int[] mas1 = new int[n2];
            for (int i = 0; i < n; i++)
            {
                mas[i] = n1.Next()%n2;
               
            }
            for (int i = 0; i < n2; i++)
                mas1[i] = 0;
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (mas[i] == j)
                        mas1[j]++;
                }
            }
            for(int i=0;i<n2;i++)
                chart1.Series[0].Points.AddXY(i, mas1[i]);

        }
        private void bogosort(int[] mas, int i)
        {
            Random rand = new Random();
            int f = 1,j,n,n1;
            while (f != 0)
            {

                f = 0;

                for (j = 0; j < i; ++j)
                {
                    n = mas[j];
                    n1 = rand.Next() % i;
                    mas[j] = mas[n1];
                    mas[n1] = n;
                    //f1++;
                    //mas1[i - 1] = f1 + 1;
                }
                for (j = 0; j < i - 1; j++)
                    if (mas[j] > mas[j + 1])
                        f = 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Stopwatch watch= Stopwatch.StartNew();;
            int n, f = 1, j,n1,f1=0,i,N=10,l=0;
            double[] mas1 = new double[N];
            for (i = 1; i < N; i++)
            {
                
                int[] mas = new int[i];
                watch.Start();// 
                for (j = 0; j <i; j++)
                    {
                        mas[j] = rand.Next(0,100) ;
                    
                    }
                bogosort(mas, i);
              
                watch.Stop();
                mas1[i - 1] = (double)watch.ElapsedMilliseconds/1000 ;

            }
            for ( i = 1; i < N; i++)
            {
                chart2.Series[0].Points.AddXY(i,mas1[i-1] );
            }
        }
    }
}
