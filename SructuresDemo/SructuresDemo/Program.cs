using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SructuresDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(
                new Human(1, "John", "Doe", "Johnson"),
                new Birth(1993,1,11),
                new Address("Ukraine","Center","Kyiv","Shevchenko","Zhilianskia","128/28","4"),
                new Contacts("111-11-11","example@example.com","_john", "_john", "_john", "_john"),
                new Education("#1", "KPI", "IT", "Programmer", "Team Lead"));

            Console.WriteLine(person);
        }
    }
}
