using System;

namespace Sortirovka
{
    class Program
    {
        static int[] arr, sort;
        static bool[] k;
        static int n, min;
        static void foo(int arrColumns, int rand_min, int rand_max)
        {
            Random rnd = new Random();
            arr = new int[arrColumns];
            k = new bool[arrColumns];
            sort = new int[arrColumns];
            
            for(int i = 0; i < arrColumns; i++)
            {
                k[i] = true;
                arr[i] = rnd.Next(rand_min, rand_max);
            }

            min = rand_max;

            for (int i = 0; i < arrColumns; i++)
            {
                for(int j = 0; j < arrColumns; j++)
                {
                    if(min > arr[j] && k[j])
                    {
                        min = arr[j];
                        sort[i] = arr[j];
                        n = j;
                    }
                }
                k[n] = false;
                min = rand_max;
            }
            Console.WriteLine("До сортируеться      После сортируеться");
            for (int i = 0; i < arrColumns; i++)
            {
                Console.WriteLine("     {0:d2}                      {1:d2}", arr[i], sort[i]);
            }
        }
        static void Main(string[] args)
        {
            foo(15, 1, 100);
        }
    }
}
