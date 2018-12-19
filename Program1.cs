using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laba_7._1
{
    class Program
    {
        Stopwatch watch = new Stopwatch();
        private static bool Sort(int[] basa)
        {
            int dlina = basa.Length;

            while (--dlina >= 1)
                if (basa[dlina] < basa[dlina - 1])
                    return false;
            return true;

        }

        private static void Rand(int[] basa)
        {
            int tmp, rnd;
            Random rand = new Random();
            for (int i = 0; i < basa.Length; i++)
            {
                rnd = rand.Next(basa.Length);
                tmp = basa[i];
                basa[i] = basa[rnd];
                basa[rnd] = tmp;
            }
        }
        static void Main(string[] args)
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