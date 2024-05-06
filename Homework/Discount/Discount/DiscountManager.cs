using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    delegate double DiscountDeleagte(double x);
    internal class DiscountManager
    {
        public void print(List<double> numbers)
        {
            foreach (double number in numbers)
            {
                Console.Write($" {number:f}");
            }
            Console.WriteLine();
        }

        public void HighOrderDiscCalc(List<double> numbers, DiscountDeleagte discount)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = discount(numbers[i]);
            }
        }

        public void Demo()
        {
            Console.WriteLine("Original Array");
            List<double> nums = new List<double>();
            for(int i = 1; i < 15; i++)
            {
                nums.Add(i);
            }
            print(nums);
            int discount_value = 10;
            HighOrderDiscCalc(nums, x => x * (100 - discount_value) * 0.01);
            Console.WriteLine("Array After 10% Discount");
            print(nums);
        }
    }
}
