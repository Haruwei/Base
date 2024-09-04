using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static void NumCtg()
        {
            double a = 3;
            double ctg = 1 / Math.Tan(a);
            Console.WriteLine(ctg);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            NumCtg();
        }
    }
}

