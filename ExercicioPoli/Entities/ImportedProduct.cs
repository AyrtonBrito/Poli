using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPoli.Entities
{
    class ImportedProduct : Product
    {
        public double customsFree { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(double customsFree, string name, double price) : base (name, price)
        {
            this.customsFree = customsFree;
        }

        public sealed override string priceTag()
        {
            return name + " $" + price.ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + customsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double totalPrice()
        {
            return price + customsFree;
        } 
    }
}
