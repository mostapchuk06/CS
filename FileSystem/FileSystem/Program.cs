using System;
using System.IO;
using static System.Net.WebRequestMethods;


namespace FileSystem
{
    class Program
    {
        public void Add(string DirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(DirPath);

            if (dir.Exists)
                Console.WriteLine("Directory is already exist!");
            else
                dir.Create();
        }
        public void Show(string DirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(DirPath);

            if (dir.Exists)
            {
                Console.WriteLine(
                    $"Directory info: " +
                    $"\n Name: {dir.Name} " +
                    $"\n Creation Time: {dir.CreationTime}\n");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Such direction doesn't Exists");
        }
        public void Delete(string DirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(DirPath);

            dir.Delete();
            Console.WriteLine("Directory has been deleted");
        }
        public void AddFile(string FileName, string DirPath)
        {
            FileInfo file = new FileInfo(FileName);

            if (file.Exists)
                Console.WriteLine("File is already exist");
            else
                file.Create();
        }
        public void DeleteFile(string FileName)
        {
            FileInfo file = new FileInfo(FileName);

            if (file.Exists)
                file.Delete();
            else
                Console.WriteLine("Such file doesn't exists");
        }
        public void ShowFile(string FileName)
        {
            FileInfo file = new FileInfo(FileName);

            Console.WriteLine(
                "Directory info:\n" +
                $"Name: {file.Name}\n" +
                $"Creation Time: {file.CreationTime}\n");
        }
    }
    class Menu
    {
        public Program prog = new Program();
        public int index;

        public void menu()
        {
            do
            {
                Console.WriteLine(
                    "\n\t...Menu..." +
                    "\n...[1]Add Direction..." +
                    "\n...[2]Show Direction..." +
                    "\n...[3]Delete Direction..." +
                    "\n...[4]Add File..." +
                    "\n...[5]Delete File..." +
                    "\n...[6]Show File..." +
                    "\n...[0]To Exit...");
                Console.Write("Enter operation index : ");

                index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    case 1:
                        prog.Add("test");
                        break;
                    case 2:
                        prog.Show("test");
                        break;
                    case 3:
                        prog.Delete("test");
                        break;
                    case 4:
                        prog.AddFile("test.txt", "test");
                        break;
                    case 5:
                        prog.DeleteFile("test.txt");
                        break;
                    case 6:
                        prog.ShowFile("test.txt");
                        break;
                }

            } while (index != 0);
        }
    }
    internal class Prog
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.menu();
        }
    }
}

