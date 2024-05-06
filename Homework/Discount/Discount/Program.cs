using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var discountManager = new DiscountManager();
            discountManager.Demo();
            while (true)
            {
                List<double> numbers = new List<double>();
                Console.WriteLine("Enter new array");
                bool check = true;
                bool check2 = true;
                int discount = 0;
                while (check)
                {
                    Console.WriteLine("Enter next value, -1 to proceed");
                    int num = -10;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num <= 0 && num != -1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Enter valid value (> 0)"); }
                    if (num > 0)
                    {
                        numbers.Add(num);
                    }
                    else
                    {
                        check = false;
                    }
                }
                Console.WriteLine("Entered array");
                discountManager.print(numbers);
                while (check2)
                {
                    Console.WriteLine("Enter discount (from 0 to 100)");
                    int num = -10;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num < 0 || num > 100)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Enter valid value (> 0)"); }
                    if (num > 0)
                    {
                        discount = num;
                        check2 = false;
                    }
                }
                Console.WriteLine($"Entered discount: {discount}");
                discountManager.HighOrderDiscCalc(numbers, x => x * (100 - discount) * 0.01);
                Console.WriteLine($"Array after applying {discount}% discount");
                discountManager.print(numbers);
            }
            

        }
    }
}
