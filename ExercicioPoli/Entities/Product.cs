using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPoli.Entities;
using System.Globalization;
namespace ExercicioPoli.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {

        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag()
        {
            return name + " $" + price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
