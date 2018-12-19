using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Csharp_2_zadania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            int N = Convert.ToInt32(textBox1.Text);
            int M =  Convert.ToInt32(textBox2.Text);
            int x = 0;
            int[] data = new int[N];
            Hashtable hash_table = new Hashtable();
            Random rd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rd.Next(1, M);
                chart1.Series[0].Points.AddXY(data[i], Math.Pow((Convert.ToDouble(1) / N), Convert.ToDouble(data[i])));
            }
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (hash_table.ContainsKey(data[i]))
                {
                    sum = Convert.ToInt32(hash_table[data[i]]);
                    hash_table[data[i]] = ++sum;
                }
                else
                {
                    hash_table.Add(data[i], 1);
                }
            }
            foreach (DictionaryEntry hash in hash_table)
            {
                chart2.Series[0].Points.AddXY(hash.Key, hash.Value);
            }

        }
    }
}