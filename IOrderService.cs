
using System.Threading.Tasks;

namespace Lab1
{
    interface IOrderService
    {
        decimal CalculateShippingPrice(Address destination, DeliveryMethod deliveryMethod);
        Task CreateOrder(Order order);
    }
}
