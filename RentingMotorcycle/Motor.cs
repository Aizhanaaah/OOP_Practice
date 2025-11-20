using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycles
{
    internal class Motor
    {
        string brand;
        int price;
        int year;

        public string Brand { get { return brand; } set { brand = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Year { get { return year; } set { if (value > 1990 && value < 2024) year = value; } }
        public Motor(string line)
        {
            string[] distribution = line.Split(":");
            Brand = distribution[0];
            Price = int.Parse(distribution[1]);
            Year = int.Parse(distribution[2]);
        }
        public string ShowIt()
        {
            return $"Brand: {Brand}, Price: {Price}, Year: {Year}";
        }
        public int PriceChange(int change)
        {
            if (change>=Price)
            {
                Price = change;
            }
            return Price;
        }
    }
}
    

