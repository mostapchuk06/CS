using System;

namespace strings
{
    internal class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("\t...Task.1...");
            Console.WriteLine(String.Join(" ", "Some sentence 0_0".Split().Reverse()) + "\n\n");

            //Task 2
            Console.WriteLine("\t...Task.2...");
            string str;
            int upper = 0;
            Console.WriteLine("Enter sentence : ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
            }
            Console.Write("Characters in uppercase: {0}\n\n", upper);

            //Task 3
            Console.WriteLine("\t...Task.3...");
            Console.WriteLine("Enter sentence : ");
            string str2 = Console.ReadLine();
            string[] words = str2.Split(' ', '.', ',', '!', '?');
            int most_long = 0;
            foreach (string word in words)
            {
                if (word.Length > most_long)
                {
                    most_long = word.Length;
                }
            }
            Console.WriteLine(most_long);

            //Task 4
            Console.WriteLine("\t...Task.4...");
            Console.WriteLine("Enter sentence : ");
            string str3 = Console.ReadLine(); 
            Console.WriteLine(str3.Replace('.', '!'));
        
        }
    }
}