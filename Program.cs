using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static void MaxEz()
        {
            int a = 5;
            int b = 8;
            int c = 9;
            int MaxNumber = Math.Max(a, b);
            MaxNumber = Math.Max(MaxNumber, c);
            Console.WriteLine(MaxNumber);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MaxEz();
        }
    }
}

