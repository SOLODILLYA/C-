using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var manager = new WeaponManager();
                    manager.MakeSound();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($" FromatException -> {ex.Message}");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($" ApplicationException -> {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Some Standart Exception -> {ex.Message}");
                }
            }
        }
    }
}
