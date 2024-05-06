using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ModelsLibrary;

namespace ModelsLibrary
{
    public class Employee : Human
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, Address addr, string position, decimal salary) 
            : base(name, age, addr)
        {
            Position = position;
            Salary = salary;
        }

        public virtual void Display()
        {
            base.Display();
            Console.WriteLine($"    Position: {Position}");
            Console.WriteLine($"    Salary: {Salary}");
        }
    }
}
