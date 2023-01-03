
namespace Lab1
{
    class NovaPoshtaShippingPriceCalculator : ShippingPriceCalculator
    {
        override public decimal CalculateShippingPrice(Address destination)
        {
            return (ShopAddress.Street.Length + destination.Street.Length) / 5 * 10.5m;           
        }
    }
}
