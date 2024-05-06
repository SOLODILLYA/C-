using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{

    public enum FamilyStatus { Married, Single }
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Addr { get; set; }
        public FamilyStatus Status { get; set; }
        public Human(string name, int age, Address addr) {
            Name = name;
            Age = age;
            Addr = addr;
            Status = FamilyStatus.Single;
        }

        public void ModifyStatus(FamilyStatus status)
        {
            Status = status;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n> Name: {Name}");
            Console.WriteLine($"    > Age: {Age}");
            Console.WriteLine($"    > Address:");
            Addr.Display();
            Console.WriteLine($"    > Family Status: {Status}");

        }
    }
}
