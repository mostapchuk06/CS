using System;
using System.Text.Json;

namespace Serialization_of_objects
{
    internal class Program
    {
        [Serializable]
        class Fractions
        {
            public int numerator { get; set; }
            public int denominator { get; set; }
            public Fractions() { }
        }
        [Serializable]
        class Work
        {
            public List<Fractions> fractions;
            public void Menu()
            {
                Console.WriteLine("Enter numerator :: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter denominator :: ");
                int denominator = int.Parse(Console.ReadLine());

                Fractions item = new Fractions() { numerator = numerator, denominator = denominator };
                fractions.Add(item);
            }
        }
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Menu();

            string FileName = "Work.json";
            File.Create(FileName);
            
            string JsonString = JsonSerializer.Serialize(work);
            File.WriteAllText(FileName, JsonString);

            JsonString = File.ReadAllText(FileName);
            Work list = JsonSerializer.Deserialize<Work>(JsonString);
        }
    }
}