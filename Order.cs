using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Order
    {
        public int ClientId { get; private set; }
        public Address Destination { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }

        public DeliveryMethod DeliveryMethod { get; private set; }

        public Order(int clientId,
                     Address destination,
                     List<OrderItem> orderItems,
                     DeliveryMethod deliveryMethod)
        {
            ClientId = clientId;
            Destination = destination;
            OrderItems = orderItems;
            DeliveryMethod = deliveryMethod;
        }

        public decimal Total()
        {
            return OrderItems.Sum(item => item.UnitPrice * item.Units);
        } 
    }
}
