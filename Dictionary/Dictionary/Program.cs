using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Employee
    {
        public Dictionary<string, string> employee = new Dictionary<string, string>();

        public Employee()
        {
            employee.Add("User283949", "a5j376h6df");
            employee.Add("User488247", "Fj85dw7739");
            employee.Add("User426790", "m328v188jd");
            employee.Add("User374933", "r7208379jj");
        }
        public void Add(string login, string password)
        {
            employee[login] = password;
            Console.WriteLine($"{login} has been added...");
        }
        public void Delete(string login)
        {
            employee.Remove(login);
            Console.WriteLine($"{login} has been deleted...");
        }
        public void Change(string old_l, string new_l, string new_pass)
        {
            Console.WriteLine($"Old login:: {old_l}");
            Console.WriteLine($"Old password:: {employee[old_l]}\n");
            employee.Remove(old_l);
            employee.Add(new_l, new_pass);
            Console.WriteLine($"New login:: {new_l}");
            Console.WriteLine($"New password:: {employee[new_l]}\n");
        }
        public void PrintPassAndLog(string login)
        {
            Console.WriteLine($"\nSelected login :: {login}");
            Console.WriteLine($"Selected login password:: {employee[login]}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.PrintPassAndLog("User283949");
            emp.Change("User374933","_dimkakka._", "293SPOneL0ve");
            emp.PrintPassAndLog("_dimkakka._");
            emp.Delete("User426790");
            emp.Add("User659785", "w2h446820");
            emp.PrintPassAndLog("User659785");
        }
    }
}
