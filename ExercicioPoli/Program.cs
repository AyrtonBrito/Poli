using System;
using ExercicioPoli.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Common, used or imported (c/u/i)? ");
                string op = Console.ReadLine();

                if (op == "i" || op == "I")
                {
                    Console.WriteLine("Customs fee:");
                    double customsFree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(customsFree, name, price));
                }
                else if (op == "u" || op == "U")
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(date, name, price));
                } else if (op == "c" || op == "C")
                {
                    products.Add(new Product(name, price));
                } else
                {
                    Console.WriteLine("Invalid Option !");
                }
           
                Console.WriteLine("\nPRICE TAGS:");
                
                foreach(Product pro in products)
                {
                    Console.WriteLine(pro.priceTag());
                }
                  
            }
        }
    }
}
