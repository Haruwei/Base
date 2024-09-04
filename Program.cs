using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            int c = 9;
            int Max = Math.Max(a, b);
            Max = Math.Max(Max, c);
            Console.WriteLine(Max);
            Console.ReadKey();
        }
    }
}
