using System;

namespace Task
{
    internal class Program
    {
        public class Instrument
        {
            public string name { get; set; }
            public string type { get; set; }
            public string color { get; set; }
            
            public virtual void Show()
            {
                Console.WriteLine();
            }
        }
        public class Guitar : Instrument
        {
            public string material { get; set; }
            public Guitar(string name, string type, string color, string material)
            {
                this.name = name;
                this.type = type;
                this.color = color;
                this.material = material;
            }
            public override void Show()
            {
                Console.WriteLine($".................{type}....................");
                Console.WriteLine($"\t   {name}");
                Console.WriteLine($"\t   {color}");
                Console.WriteLine($"\t   {material}");
                Console.WriteLine($"...........................................\n");
            }
        }
        public class BassGuitar : Instrument
        {
            public string material { get; set; }
            public BassGuitar(string name, string type, string color, string material)
            {
                this.name = name;
                this.type = type;
                this.color = color;
                this.material = material;
            }
            public override void Show()
            {
                Console.WriteLine($"..............{type}..................");
                Console.WriteLine($"\t   {name}");
                Console.WriteLine($"\t   {color}");
                Console.WriteLine($"\t   {material}");
                Console.WriteLine($"...........................................\n");
            }
        }
        public class ElectroGuitar : Instrument
        {
            public string material { get; set; }
            public ElectroGuitar(string name, string type, string color, string material)
            {
                this.name = name;
                this.type = type;
                this.color = color;
                this.material = material;
            }
            public override void Show()
            {
                Console.WriteLine($"..............{type}...............");
                Console.WriteLine($"\t   {name}");
                Console.WriteLine($"\t   {color}");
                Console.WriteLine($"\t   {material}");
                Console.WriteLine($"...........................................\n");
            }
        }
        static void Main(string[] args)
        {
            Guitar g = new Guitar("Gipson", "Guitar", "Red", "Wood");
            g.Show();
            BassGuitar bg = new BassGuitar("Rickenbacker 4001 V63", "Bass Guitar", "Black", "Wood");
            bg.Show();
            ElectroGuitar eg = new ElectroGuitar("Competition Mustang 1969", "Electro Guitar", "Lake Placid Blue", "Wood");
            eg.Show();
        }
    }
}