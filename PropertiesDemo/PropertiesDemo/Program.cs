using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var converter = new Converter("SOLOD");

                Console.Write("\n Enter tempreture in Farenheights: ");
                double x = double.Parse(Console.ReadLine());
                converter.F = x;
                converter.ConvertFromFtoC();
                double y = converter.C;
                Console.WriteLine($" Result: {x:f} F = {y:f} C");
                converter.Type = "Super";
                Console.WriteLine(converter.ToString());
                Console.WriteLine($" Author: {converter.Author}");
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
