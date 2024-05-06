using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public struct Address
    {
        public string country;
        public string city;
        public string street;
        public string house;
        public string flat;

        public Address(string country, string city, string street, string house, string flat)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.flat = flat;
        }

        public void Display()
        {
            Console.WriteLine($"{country,15}{city,15}{street,15}{house,12}{flat,12}");
        }
    }
}
