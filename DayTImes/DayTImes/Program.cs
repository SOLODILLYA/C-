using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTImes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var maneger = new GreetingManager();
                    maneger.GreetingsDemo();
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($" FormatException -> {fe.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Some Exception -> {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("\n\nFinish");
                }
            }
        }
    }
}
