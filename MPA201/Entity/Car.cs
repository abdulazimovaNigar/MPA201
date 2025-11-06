using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPA201
{
    internal class Car
    {
        public static int defaultId = 0;
        public int Id;
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public double Price;
        public string Status;

        public Car(string brand, string model, string color, int year, double price)
        {
            Id = defaultId;
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
            Status = "Available";
            defaultId++;
        }
    }
}
