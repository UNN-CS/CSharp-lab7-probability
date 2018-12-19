using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            int N = 5;
            int x = 0;
            int[] stan = new int[N];
            int[] Q = new int[N];
            Random rd = new Random();
            for (int i = 0; i < stan.Length; i++)
            {
                Q[i] = -1;
            }
            for (int i = 0; i < stan.Length; i++)
            {
                stan[i] = rd.Next(1, 5);
            }
            for (int i = 0; i < stan.Length; i++)
            {
                for (int j = 0; j < stan.Length; j++)
                {

                    if (stan[i] == Q[j])
                    {
                        break;
                    }
                    if (stan[i] == stan[j])
                    {
                        ++x;
                    }
                }
                Q[i] = stan[i];
                chart1.Series[0].Points.AddXY(stan[i], x);
                x = 0;
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
