using System;
using System.Linq;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("\t...Task.1...");
            int[] test = { 10, 15, 1, 3, 3, 5, 2, 4, 3, 6 };
            int min_v = test[0];
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] < min_v)
                    min_v = test[i];
                Console.WriteLine($"[{i + 1}] - {test[i]}");
            }
            Console.WriteLine($"Min element is {min_v}\n\n");


            // Task 2
            Console.WriteLine("\t...Task.2...");
            int min = 0;
            int max = 10;
            int[] test2 = new int[5];

            Random randNum = new Random();
            Console.WriteLine("Test2 array :");
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(min, max);
                Console.WriteLine($"[{i + 1}] - {test2[i]}");
            }
            if (test2.Length != test2.Distinct().Count())
            {
                Console.WriteLine("Contains duplicates");
            }
            else
            {
                Console.WriteLine("Not contains duplicates");
            }
            Console.Write("\n\n");

            //Task 3
            Console.WriteLine("\t...Task.3...");
            int[] test3 = { 4, 8, 3, 3 };
            int[] other_test3;

            List<int> cache = new List<int>();

            for (int i = 0; i < test3.Length; i++)
            { 
                Console.WriteLine($"[{i + 1}] - {test3[i]}");
            }

            foreach (int num in test3)
            {
                if (num % 2 == 0)
                {
                    cache.Add(num);
                }
            }
            other_test3 = cache.ToArray();

            Console.Write("Pair numbers are : ");
            foreach (int num in other_test3)
            {
                Console.Write(num + " ");
            }
            Console.Write("\n\n");

        }
    }
}
