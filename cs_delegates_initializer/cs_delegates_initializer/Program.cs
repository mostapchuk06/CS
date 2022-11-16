using System;

namespace DelegatesInitializer
{
    internal class Program
    {
        static void Initializer(int[] arr, Func<int, int> init)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = init(i);
            }
        }
        static void Show<T>(T[] arr, string title)
        {
            Console.Write($"{title}: ");
            foreach (var item in arr) 
                Console.Write(item + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] OneTo100RandNumbSize = new int[15];
            int[] Plus3ArraySize = new int[10];
            int[] TwoinDegreeArraySize = new int[20];

            Initializer(OneTo100RandNumbSize, (i) => new Random().Next(100));
            Show(OneTo100RandNumbSize, "OneTo100RandNumbersArray");

            Initializer(Plus3ArraySize, (i) => i * 3);
            Show(Plus3ArraySize, "Plus3Array");

            Initializer(TwoinDegreeArraySize, (i) => (int)Math.Pow(2, i));
            Show(TwoinDegreeArraySize, "TwoInDegreeArray");
        }
    }
}