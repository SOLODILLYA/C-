using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTImes
{
    delegate void GreetingDelegate();

    internal class Greeting
    {
        public int Id { get; set; }
        public GreetingDelegate GD { get; set; }
        public void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public void GoodAfternoon()
        {
            Console.WriteLine("Good Afternoon");
        }
        public void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        public void GoodNight()
        {
            Console.WriteLine("Good Night");
        }

        public void Invalid()
        {
            Console.WriteLine("Such time does not exist");
        }
    }
}
