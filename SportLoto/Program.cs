using System;

namespace SportLoto
{
    class Program
    {
        static uint NumberHits = 0;
        static Random rnd = new Random();
        static bool[,] arrbool = new bool[36,2];
        static int[,] arrint = new int[5,2];
        
        static void foo<T>(T i)
        {
            T temp = i;
            Console.WriteLine(temp);  
        }
        static void ValueDefaultNumber()
        {
            for(int i = 0; i < 36; i++)
            {
                arrbool[i, 0] = false;
                arrbool[i, 1] = false;
            }
        }

        static bool ValueNumber(int i)
        {
            if(i < 1 || i >= 36)
            {
                Console.WriteLine("Неверно значение. Должен быть от 1 до 36 значении.");
                return false;
            }
            else
            {
                if(!arrbool[i, 0])
                {
                    arrbool[i, 0] = true;
                }
                else
                {
                    Console.WriteLine("уже занят число, ввести другое число");
                    return false;
                }
            }
            return true;
        }
        
        static bool RandomNumber(int i)
        {
            if (!arrbool[i, 1])
            {
                arrbool[i, 1] = true;
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            foo<string>("Hello");
                
            ValueDefaultNumber();
            Console.WriteLine("Ввести 5 число от 1 до 36:");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i+1 + " - ");
                int a = Convert.ToInt32(Console.ReadLine());
                if(!ValueNumber(a))
                {
                    i--;
                }
                else
                {
                    arrint[i,0] = a;
                }
            }

            Console.WriteLine("\n\nРезультат:");
            Console.Write("Наше число -      ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(arrint[i, 0] + "\t");
            }

            Console.WriteLine();
            Console.Write("Случайные числа - ");
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(1, 36);
                if (!RandomNumber(a))
                {
                    i--;
                }
                else
                {
                    arrint[i, 1] = a;
                    Console.Write(arrint[i, 1] + "\t");
                }
            }

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(arrint[j, 0] == arrint[i, 1])
                    {
                        NumberHits++;
                    }
                }
            }
            Console.WriteLine("\nЧисло попаданий: " + NumberHits);
            
        }
    }
}
