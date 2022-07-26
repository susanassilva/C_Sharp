using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2_wsmodule10.Entities;

namespace Exercise2_wsmodule10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Proudct #{i + 1} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        products.Add(new UsedProduct(name, price, date));

                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());

                        products.Add(new ImportedProduct(name, price, fee));

                        break;

                    case 'c':
                        products.Add(new Product(name, price));
                        break;

                }
            }

            Console.WriteLine("\nPRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag().ToString());
            }
        }
    }
}
