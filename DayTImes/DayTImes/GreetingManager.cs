using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTImes
{
    internal class GreetingManager
    {
        public Greeting _Greeting { get; set; }

        public GreetingManager()
        {
            _Greeting = new Greeting();
        }

        public void GreetingsDemo()
        {
            //1
            Console.Write("\n> What time is it? - ");
            if(!int.TryParse(Console.ReadLine(), out int hours))
            {
                throw new FormatException("Time Format Error");
            }

            //2
            if(hours >= 4 && hours < 12)
            {
                _Greeting.GD = _Greeting.GoodMorning;
            }else if (hours >= 12 && hours < 17)
            {
                _Greeting.GD = _Greeting.GoodAfternoon;
            }else if (hours >= 17 && hours < 24)
            {
                _Greeting.GD = _Greeting.GoodEvening;
            }else if ((hours >= 0 && hours < 4) || hours == 24)
            {
                _Greeting.GD = _Greeting.GoodNight;
            }
            else
            {
                _Greeting.GD= _Greeting.Invalid;
            }

            //3
            _Greeting.GD.Invoke();
        }
    }
}
