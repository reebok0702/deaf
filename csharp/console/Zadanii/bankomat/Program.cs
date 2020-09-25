using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {

        public static int ValueMoney = 0,
            money = 10000,
            money1000 = 5,
            money500 = 5,
            money200 = 5,
            money100 = 10,
            money50 = 10;
        public static string y = "y";


        
        static void Main(string[] args)
        {
            
            Class1.func1(ValueMoney);
            while(y == "y")
            {
                Console.WriteLine("Снять наличие деньги:");
                Console.Write("==> ");
                ValueMoney = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Class1.func1(ValueMoney);
                Console.WriteLine("Продолжить работу? (y/n)");
                y = Console.ReadLine();
                y.ToLower();
                Console.WriteLine();
            }
        }
    }
}
