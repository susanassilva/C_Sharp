using System;
using ws_modulo8.Entities;
using ws_modulo8.Entities.Enums;

namespace ws_modulo8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus),"Delivered");
            Console.WriteLine(os);
        }
    }
}
