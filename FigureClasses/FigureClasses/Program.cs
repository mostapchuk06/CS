using System;

namespace Task_Figures
{
    public class Figure
    {
        public int area;
        public int perimeter;

        public virtual int GetArea()
        {
            return area;
        }
        public virtual int GetPerimeter()
        {
            return perimeter;
        }

        public virtual void Show()
        {
            Console.WriteLine();
        }
    }
    public class Square : Figure
    {
        public int size;

        public Square(int size)
        {
            this.size = size;
        }

        public override int GetArea()
        {
            area = size * 2;
            return area;
        }
        public override int GetPerimeter()
        {
            perimeter = (size + size) * 2;
            return perimeter;
        }
        public override void Show()
        {
            Console.WriteLine($"\t...Square...");
            Console.WriteLine($"Perimeter :: {GetPerimeter()}");
            Console.WriteLine($"Area :: {GetArea()}");
        }
    }
    public class Reqtangle : Figure
    {
        public int w;
        public int h;

        public Reqtangle(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public override int GetArea()
        {
            area = w * h;
            return area;
        }
        public override int GetPerimeter()
        {
            perimeter = (w + h) * 2;
            return perimeter;
        }
        public override void Show()
        {
            Console.WriteLine($"\t...Reqtangle...");
            Console.WriteLine($"Perimeter :: {GetPerimeter()}");
            Console.WriteLine($"Area :: {GetArea()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(4);
            s1.Show();
            Reqtangle r1 = new Reqtangle(4, 5);
            r1.Show();
        }
    }
}

