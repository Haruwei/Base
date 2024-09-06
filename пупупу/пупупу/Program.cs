using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пупупу
{
    class Program
    {
        public static void math()
        {
            double prom = 0;
            double summa = 0;
            int x = 3;
            for (int i = 1; i < 10; i++)
            {
                prom = Math.Pow(x, i) / (x + i);
                summa += prom;
            }
            Console.WriteLine(summa);
        }
        static void Main(string[] args)
        {
            math();
            Console.ReadKey();
        }
    }
}
