using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void UpDown(string Ez)
        {
            string up = Ez.ToUpper();
            string down = Ez.ToLower();
            Console.WriteLine($"Большой:{up}, маленький:{down}");
        }
        static void Main(string[] args)
        {
            string Ez25 = "НЕ знаю что сюда написать";
            string Ez26 = "Кто ты?";
            string Ez27 = "Я? Аянами Рей";
            string Ez28 = "Ты тоже Аянами Рей?";
            string Ez29 = "Просто придумай что-нибудь";
            UpDown(Ez25);
            UpDown(Ez26);
            UpDown(Ez27);
            UpDown(Ez28);
            UpDown(Ez29);
            Console.ReadKey();
        }
    }
}
