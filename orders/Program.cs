using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using orders.Entities;
using orders.Entities.Enums;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse((Console.ReadLine()));

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, orderStatus, client);
            

            Console.Write("How many items to this order? ");
            int numbersItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersItems; i++)
            {
                Console.WriteLine($"Entrer #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

               
                OrderItem orderItem = new OrderItem(quant, price, product);
                
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);

        }
    }
}
