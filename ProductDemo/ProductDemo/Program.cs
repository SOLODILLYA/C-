using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(new Info(1, "stick", 10.99, "forest"), 
                new Size(10,2,5), 
                new Color("black", "red"), 
                new Dates(2024, 1, 23, 12, 2026, 12, 2), 
                new Weights(5.5, 4.1), 
                new ProductionAddress("Ukraine", "Kyiv", "Kyiv", "Obolon", "Shasluva", "12", "1423"));
            System.Console.WriteLine(product);
        }
    }
}
