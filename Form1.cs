using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba7
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
            int[] basa = new int[N];
            int[] CS = new int[N];
            Random rd = new Random();
            for (int i = 0; i < basa.Length; i++)
            {
                CS[i] = -1;
            }
            for (int i = 0; i < basa.Length; i++)
            {
                basa[i] = rd.Next(1, 5);
            }
            for (int i = 0; i < basa.Length; i++)
            {
                for (int j = 0; j < basa.Length; j++)
                {

                    if (basa[i] == CS[j])
                    {
                        break;
                    }
                    if (basa[i] == basa[j])
                    {
                        ++x;
                    }
                }
                CS[i] = basa[i];
                chart1.Series[0].Points.AddXY(basa[i], x);
                x = 0;
            }
        }
    }
}