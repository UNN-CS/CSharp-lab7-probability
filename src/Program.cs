using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bogosort
{
    class Bogo
    {
        static bool isCorrect(int[] mass, int size)
        {
            while (--size > 0)
                if (mass[size - 1] > mass[size])
                    return false;
            return true;
        }
        static void Shuffle(int[] mass, int size)
        {
            int i;
            Random rnd = new Random();
            for (i = 0; i < size; ++i)
            {
                int rand = rnd.Next(0, size);
                int temp = mass[rand];
                mass[rand] = mass[i];
                mass[i] = temp;
            }
        }
        static public void BogoSort(int[] mass, int size)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            while (!isCorrect(mass, size))
                Shuffle(mass, size);

            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            string runTime = String.Format("{0} min {1:#0.000} sec ", time.Minutes, (double)time.Seconds + (double)time.Milliseconds / 1000);
            Console.WriteLine("\nRuntime with Size = " + size + ": " + runTime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int N = 12;
            for(int i = 1; i < N; i++)
            {
                int[] mass = new int[i];
                for (int j = 0; j < i; j++)
                    mass[j] = rnd.Next(0, 100);
                Console.WriteLine("\nGenerate array:");
                for (int j = 0; j < i; j++)
                    Console.Write(mass[j] + " ");
                Bogo.BogoSort(mass, i);
                Console.WriteLine("Sort array:");
                for (int j = 0; j < i; j++)
                    Console.Write(mass[j] + " ");
                Console.WriteLine();
            }
        }
    }
}
