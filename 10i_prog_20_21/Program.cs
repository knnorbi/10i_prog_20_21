using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10i_prog_20_21
{
    class Program
    {
        static int Sorozatszamitas(int[] x)
        {
            int ertek = 0;
            for (int i = 0; i < x.Length; i++)
            {
                ertek += x[i];                   // ertek = ertek + x[i];
            }
            return ertek;
        }

        static bool Eldontes(int[] x)
        {
            int i = 0;
            while (i < x.Length && !(x[i] > 100))
            {
                i++;                                // i = i + 1;
            }
            return i < x.Length;
        }

        static void Main(string[] args)
        {
            int[] t = { 42, 6, 7, 65, 8, 54, 23, 45, 9, 10 };

            int sorozat = Sorozatszamitas(t);
            Console.WriteLine(sorozat);

            bool vane = Eldontes(t);
            Console.WriteLine(vane);

            Console.ReadKey();
        }
    }
}
