using System;
using MatrixCalculator.Models;
namespace MatrixCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int rows = 3;
            const int cols = 3;
            var arr = new double[rows][];

            arr[0] = new double[cols] { 10, 20, 30 };
            arr[1] = new double[cols] { 40, 50, 60 };
            arr[2] = new double[cols] { 70, 80, 90 };
            var m = new Matrix(rows, cols, arr);
            
            var arr1 = new double[rows][];

            arr1[0] = new double[cols] { 110, 120, 130 };
            arr1[1] = new double[cols] { 140, 150, 160 };
            arr1[2] = new double[cols] { 170, 180, 190 };
            var m1 = new Matrix(rows, cols, arr1);

            var m2 = m + m1;
            var m3 = m - m1;
            var m4 = m * 3;
            Console.WriteLine("M");
            m.Display();
            Console.WriteLine("M1");
            m1.Display();
            Console.WriteLine("M + M1");
            m2.Display();
            Console.WriteLine("M - M1");
            m3.Display();
            Console.WriteLine("3M");
            m4.Display();
            Console.WriteLine("\n\nFinish");
        }
    }
}