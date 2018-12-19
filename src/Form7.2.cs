using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2_zadania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 5;
            int x = 0;
            int[] data = new int[N];
            int[] CS = new int[N];
            Random rd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                CS[i] = -1;
            }
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rd.Next(1, 5);
            }
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {

                    if (data[i] == CS[j])
                    {
                        break;
                    }
                    if (data[i] == data[j])
                    {
                        ++x;
                    }                   
                }
                CS[i] = data[i];
                chart1.Series[0].Points.AddXY(data[i], x);
                x = 0;
            }
        }
    }
}
