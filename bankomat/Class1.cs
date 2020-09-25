using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class Class1
    {
        public static bool CheckValueMoney(int valueMoney)
        {
            if (valueMoney % 50 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int MinMaxMoney(int valueMoney)
        {
            if (valueMoney > 1000)
            {
                return 1000;
            }
            else if (valueMoney > 500)
            {
                return 500;
            }
            else if (valueMoney > 200)
            {
                return 200;
            }
            else if (valueMoney > 100)
            {
                return 100;
            }
            else
            {
                return 50;
            }
        }
        public static void func1(int valueMoney)
        {


            if (!CheckValueMoney(valueMoney))
            {
                if (valueMoney > 1000)
                {
                    Console.WriteLine($"Рекомендуеться {MinMaxMoney(valueMoney)}");
                }
                else
                {
                    Console.WriteLine($"Рекомендуеться {MinMaxMoney(valueMoney)} грн. или {(MinMaxMoney(valueMoney)) * 2} грн.");
                }
                return;
            }

            if (Program.money < valueMoney)
            {
                Console.WriteLine("Банкомат недостаточно средств.\n");
                return;
            }

            while (Program.money > 0 && valueMoney > 0)
            {
                if (Program.money1000 > 0 && valueMoney >= 1000)
                {
                    Program.money -= 1000;
                    valueMoney -= 1000;
                    Program.money1000--;
                    Console.Write("1000");
                }
                else if (Program.money500 > 0 && valueMoney >= 500)
                {
                    Program.money -= 500;
                    valueMoney -= 500;
                    Program.money500--;
                    Console.Write("500");
                }
                else if (Program.money200 > 0 && valueMoney >= 200)
                {
                    Program.money -= 200;
                    valueMoney -= 200;
                    Program.money200--;
                    Console.Write("200");
                }
                else if (Program.money100 > 0 && valueMoney >= 100)
                {
                    Program.money -= 100;
                    valueMoney -= 100;
                    Program.money100--;
                    Console.Write("100");
                }
                else if (Program.money50 > 0 && valueMoney >= 50)
                {
                    Program.money -= 50;
                    valueMoney -= 50;
                    Program.money50--;
                    Console.Write("50");
                }

                if (valueMoney > 0)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(" = " + Program.ValueMoney + " грн.");
                }
            }

            if (Program.money == 0)
            {
                Console.WriteLine("\nНет средства в банкомате!");
            }


            Console.WriteLine("\n\n=====================================");
            Console.WriteLine("Осталось деньги: " + Program.money + " грн.");
            Console.WriteLine(Program.money1000 + " копьюров по 1000 грн.");
            Console.WriteLine(Program.money500 + " копьюров по 500 грн.");
            Console.WriteLine(Program.money200 + " копьюров по 200 грн.");
            Console.WriteLine(Program.money100 + " копьюров по 100 грн.");
            Console.WriteLine(Program.money50 + " копьюров по 50 грн.");
            Console.WriteLine("=====================================\n");
        }
    }
}
