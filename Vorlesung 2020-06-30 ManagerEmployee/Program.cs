using System;
using System.Collections.Generic;

namespace ManagerEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arbeitskräfte!\nGib Name:");
            string Arbeitername = Console.ReadLine();

            Console.WriteLine("Und was bekommt der Knecht?");
            int Arbeiterlohn = Convert.ToInt32(Console.ReadLine());

            Employee Arbeiter = new Employee(Arbeitername, Arbeiterlohn);
            Console.ReadLine();

            List<Employee> alleknechte = new List<Employee>();

            alleknechte.Add(Arbeiter);
            alleknechte.Add(new Employee("ole",999));
            alleknechte.Add(new Employee("Mia",999));
            alleknechte.Add(new Manager("Karl", 123, 123123));
            Console.ReadLine();
        }
    }
}
