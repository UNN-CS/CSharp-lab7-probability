using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probability
{
    class RandArray
    { 
        static Random rnd = new Random();
        static public int[] RandFill(int N, int M)
        {
            
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
                mass[i] = rnd.Next(0, M);
            return mass;
        }
        static public int[] Count(int[] mass, int M)
        {
            int[] num = new int[M];
            for (int i = 0; i < mass.Length; i++)
                num[mass[i]]++;
            return num;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
