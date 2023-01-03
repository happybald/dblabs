
namespace Lab1
{
    class OrderItem
    {
        public int ProductId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }

        public OrderItem(int productId, decimal unitPrice, int units)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}
