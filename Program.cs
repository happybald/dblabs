
using System;
using System.Collections.Generic;

namespace Lab1
{
    static class Program
    {
        private readonly static ILogger Logger = new AppLoger();
        private static void Main(string[] args)
        {
            IOrderService orderService = new OrderService();

            var order = new Order(100, new Address("Some street", "City", "03001"),
                new List<OrderItem>()
                {
                    new OrderItem(2, 10,3),
                    new OrderItem(4, 100, 1)
                }, DeliveryMethod.UkrPoshta);

            var shippingPrice = orderService.CalculateShippingPrice(order.Destination, order.DeliveryMethod);
            Console.WriteLine($"Shipping price: {shippingPrice}");

            orderService.CreateOrder(order);

            var invalidOrder = new Order(102, new Address("Some street", "City", "03001"),
                new List<OrderItem>()
                {
                    new OrderItem(2, 10,3),
                    new OrderItem(4, 10, 0)
                }, DeliveryMethod.UkrPoshta);

            try
            {
                orderService.CreateOrder(invalidOrder);
            }
            catch(Exception ex)
            {
                Logger.LogError("Failed to create order.", ex, true);
            }
        }
    }
}
