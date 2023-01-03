using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    class OrderService : IOrderService
    {
        public decimal CalculateShippingPrice(Address destination, DeliveryMethod deliveryMethod)
        {
            ShippingPriceCalculator shippingPriceCalculator = deliveryMethod switch
            {
                DeliveryMethod.NovaPoshta => new NovaPoshtaShippingPriceCalculator(),
                _ => new UkrPoshtaShippingPriceCalculator()
            };

            return shippingPriceCalculator.CalculateShippingPrice(destination);
        }

        public Task CreateOrder(Order order)
        {
            if (!IsValid(order))
            {
                throw new ArgumentException(nameof(order));
            }

            Console.WriteLine($"Create order. Order total: {order.Total()}");
            return Task.CompletedTask;
        }

        private static bool IsValid(Order order)
        {
            return order.OrderItems.Any() && order.OrderItems.All(item => item.Units > 0);          
        }
    }
}
