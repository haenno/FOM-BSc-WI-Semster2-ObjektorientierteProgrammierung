using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerEmployee
{
    
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee (string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Manager : Employee
    {
        public int Bonus { get; set; }
        public Manager (string name, int salary, int bonus) : base (name, salary)
        {
            Bonus = bonus;

        }
    }
}
