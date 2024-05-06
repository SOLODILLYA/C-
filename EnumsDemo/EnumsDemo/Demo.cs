using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDemo
{
    enum Seasons { Winter = 1 , Spring, Summer, Autumn};
    internal class Demo
    {
        public void Example1()
        {
            Console.WriteLine("\n Enter serial number of season: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(Seasons.Winter);

            switch (m)
            {
                case (int)Seasons.Winter: Console.WriteLine("Winter: December, January, February");
                    break;
                case (int)Seasons.Spring: Console.WriteLine("Spring: March, April, May");
                    break;
                case (int)Seasons.Summer: Console.WriteLine("Summer: June, July, August");
                    break;
                case (int)Seasons.Autumn: Console.WriteLine("Autumn: September, October, November"); 
                    break;
                default: Console.WriteLine("Invalid season number"); 
                    break;
            }
        }

        public void Example2()
        {

            Console.WriteLine("\n> Scan of seasonsContent:");
            int count = 0;
            var seasonsValues = Enum.GetValues(typeof(Seasons));
            foreach (var season in seasonsValues) { Console.WriteLine($"{++count}. {season} -> {(int)season}"); }
        }

        public void Example3()
        {

            Console.WriteLine("\n> Scan of colorsContent:");
            int count = 0;
            var seasonsValues = Enum.GetValues(typeof(ConsoleColor));
            foreach (var season in seasonsValues) { Console.WriteLine($"{++count}. {season} -> {(int)season}"); }
        }
    }
}
