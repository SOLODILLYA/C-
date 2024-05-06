using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductDemo
{
    struct Info
    {
        public int id;
        public string name;
        public double price;
        public string producer;
        public override string ToString()
        {
            return $"\nInfo: \n {id,4}{name,10}{price,10}{producer,10}\n";
        }
        public Info(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
    }
    struct Size
    {
        public double height;
        public double width;
        public double length;
        public override string ToString()
        {
            return $"\nSize: \n {height,4}{width,4}{length,4}\n";
        }
        public Size(double height, double width, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }
    }

    struct Color
    {
        public string primaryColor;
        public string secondaryColor;
        public override string ToString()
        {
            return $"\nColor: \n {primaryColor,10}{secondaryColor,10}\n";
        }
        public Color(string primaryColor, string secondartColor)
        {
            this.primaryColor = primaryColor;
            this.secondaryColor = secondartColor;
        }
    }

    struct Dates
    {
        public int productionYear;
        public int productionMonth;
        public int productionDay;
        public int productionHour;

        public int expieryYear;
        public int expieryMonth;
        public int expieryDay;

        public override string ToString()
        {
            return string.Format("\nProduction Date:\n {0,4}{1,4}{2,4}{3,4}\n\nExpiaery Date:\n {4,4}{5,4}{6,4}\n", productionYear, productionMonth, productionDay, productionHour, expieryYear, expieryMonth, expieryDay);
        }
        public Dates(int productionYear, int productionMonth,int productionDay,
            int productionHour, int expieryYear, int expieryMonth, int expieryDay)
        {
            this.productionYear = productionYear;
            this.productionMonth = productionMonth;
            this.productionDay = productionDay;
            this.productionHour = productionHour;
            this.expieryYear = expieryYear;
            this.expieryMonth = expieryMonth;
            this.expieryDay = expieryDay;
        }
    }

    struct Weights
    {
        public double weightWithBox;
        public double weightWithoutBox;
        public override string ToString()
        {
            return $"\nWeight: \n {weightWithBox,4}{weightWithoutBox,4}\n";
        }

        public Weights(double weightWithBox, double weightWithoutBox)
        {
            this .weightWithBox = weightWithBox;
            this .weightWithoutBox = weightWithoutBox;
        }
    }

    struct ProductionAddress
    {
        public string country;
        public string region;
        public string city;
        public string district;
        public string street;
        public string flat;
        public string postalCode;
        public override string ToString()
        {
            return string.Format("\nProduction Adress:\n {0}{1,10}{2,10}{3,10}{4,10}{5,5}{6,7}", country, region, city, district, street, flat, postalCode);
        }
        public ProductionAddress(string country, string region, string city, 
            string district, string street, string flat, string postalCode)
        {
            this .country = country;
            this .region = region;
            this .city = city;
            this .district = district;
            this .street = street;
            this .flat = flat;
            this .postalCode = postalCode;
        }
    }

    

    internal class Product
    {
        protected Info info;
        protected Size size;
        protected Color color;
        protected Dates dates;
        protected Weights weights;
        protected ProductionAddress productionAddress;

        public Product(Info info, Size size, Color color, Dates dates, Weights weights, ProductionAddress productionAddress) {
            this.info = info;
            this.size = size;
            this.color = color;
            this.dates = dates;
            this.weights = weights;
            this.productionAddress = productionAddress;
        }
        public override string ToString()
        {
            return info.ToString() + size.ToString() + color.ToString() +
                dates.ToString() + weights.ToString() + productionAddress.ToString();
        }
    }
}
