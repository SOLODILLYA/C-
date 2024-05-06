using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    //0 - Delegate type selection
    delegate double CalcDelegate(double x, double y);
    delegate int SquaresDelegate(int x);
    delegate void GreetingDeleagte();
    delegate bool FilterDeleagte(int x);
    internal class ExampleManager
    {
        public void Example1()
        {
            Console.WriteLine("\n> 1. Arifmethic operations control: ");

            CalcDelegate op1 = (x, y) => x + y;
            CalcDelegate op2 = (x, y) => x - y;
            CalcDelegate op3 = (x, y) => x * y;
            CalcDelegate op4 = (x, y) => x / y;

            double a = 123.34;
            double b = 234.45;

            Console.WriteLine($" {a} + {b} = {op1(a, b):f}");
            Console.WriteLine($" {a} - {b} = {op2(a, b):f}");
            Console.WriteLine($" {a} * {b} = {op3(a, b):f}");
            Console.WriteLine($" {a} / {b} = {op4(a, b):f}");
        }
        public void Example2() {

            Console.WriteLine("\n> 2. Lambda expression with one argument: ");

            SquaresDelegate calcSquare = x => x * x;
            Console.Write(" Enter number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($" -> {a} ^ 2 = {calcSquare(a)}");
        }
        public void Example3()
        {

            Console.WriteLine("\n> 2. Lambda expression without arguments: ");

            GreetingDeleagte g1 = () => Console.WriteLine(" -> Good Morning");
            GreetingDeleagte g2 = () => Console.WriteLine(" -> Good Evening");

            int h = DateTime.Now.Hour;
            if(h >= 12 && h < 17)
            {
                g1();
            }
            else
            {
                g2();
            }
        }
        private void ShowHello()
        {
            Console.WriteLine(" -> Hello World");
        }
        public void Example4()
        {

            Console.WriteLine("\n> 2. Call of external method in lambda expression: ");

            GreetingDeleagte hello = () => ShowHello();
            hello();
        }

        private int HighOrderCalc(int[] numbers, FilterDeleagte filter)
        {
            int sum = 0; 
            foreach (int number in numbers)
                if (filter(number)) sum += number;
            return sum;
        }

        private void displayNumbers(int[] numbers)
        {
            foreach (int number in numbers) {
                Console.Write($" {number}");
            }
            Console.WriteLine();
        }
        public void Example5()
        {

            Console.WriteLine("\n> 2. Usage of lambda expression for data filtering: ");

            int[] numbers = { 1,2,3,5,7,-10, 23, -52, -3,23};
            displayNumbers(numbers);

            int res = HighOrderCalc(numbers, x => x >= 0);
            Console.WriteLine($" -> Sum of positive elements: {res}");

            int res2 = HighOrderCalc(numbers, x => x <= 0);
            Console.WriteLine($" -> Sum of negative elements: {res2}");

            int res3 = HighOrderCalc(numbers, x => x % 2 == 0);
            Console.WriteLine($" -> Sum of even elements: {res3}");

            int res4 = HighOrderCalc(numbers, x => x % 2 == 1);
            Console.WriteLine($" -> Sum of odd elements: {res4}");
        }
    }
}
