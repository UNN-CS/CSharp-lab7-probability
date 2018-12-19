using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab77
{
    class Program
    {
        Stopwatch watch = new Stopwatch();
        private static bool Sort(int[] basa)
        {
            int Long = basa.Length;

            while (--Long >= 1)
                if (basa[Long] < basa[Long - 1])
                    return false;
            return true;

        }

        private static void Rand(int[] stan)
        {
            int tmp, rnd;
            Random rand = new Random();
            for (int i = 0; i < stan.Length; i++)
            {
                rnd = rand.Next(stan.Length);
                tmp = stan[i];
                stan[i] = stan[rnd];
                stan[rnd] = tmp;
            }
        }
        static void Form1(string[] args)
        {



            int N = 0;
            N++;

            while (N != 0)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Console.Write("шаг" + N);
                Console.WriteLine("");
                int[] data = new int[N];
                Random rd = new Random();
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = rd.Next(1, 101);
                    Console.Write(" ");
                    Console.Write(data[i]);
                }
                Console.WriteLine("");
                VpolneniiBoogSort(data);
                for (int i = 0; i < data.Length; i++)
                {
                    Console.Write(" ");
                    Console.Write(data[i]);
                }
                watch.Stop();
                Console.WriteLine("");
                Console.Write("Время выполнения программы в часах" + "   " + watch.Elapsed.Hours + "   " + "час.\r\n");
                Console.Write("Время выполнения программы в минутах" + "   " + watch.Elapsed.Minutes + "   " + "мин.\r\n");
                Console.Write("Время выполнения программы в секундах" + "   " + watch.Elapsed.Seconds + "   " + "сек.\r\n");
                Console.Write("Время выполнения программы в миллисекундах" + "   " + watch.ElapsedMilliseconds + "   " + "милсек.\r\n");
                N++;
            }
        }
        public static void VpolneniiBoogSort(int[] data)
        {
            while (!Sort(data))
                Rand(data);
        }
    }
}