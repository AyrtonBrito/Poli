using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPoli.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(DateTime manufactureDate, string name, double price) : base (name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public sealed override string priceTag()
        {
            return name + " (used) $" + price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
