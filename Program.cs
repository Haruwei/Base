using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static void Array1()
        {
            int[] числа = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int sum = 0;
            for (int i = 0; i < числа.Length; i++)
            {
                if (числа[i] > 0 && числа[i] < 10)
                {
                    sum += числа[i];
                    Console.WriteLine(sum);
                }
            }
            Console.WriteLine("ниже количество");
            Console.ReadKey();
        }
        public static void Array2()
        {
            int[] числа = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int колво = 0;
            for (int i = 0; i < числа.Length; i++)
            {
                if (числа[i] > 0 && числа[i] < 10)
                {
                    колво++;
                }
            }
            Console.WriteLine(колво);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Array1();
            Array2();
        }
    }
}

