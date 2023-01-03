
namespace Lab1
{
    abstract class ShippingPriceCalculator
    {
        protected readonly Address ShopAddress = new Address("Politekhnichna St, 6", "Kyiv", "02000");

        public abstract decimal CalculateShippingPrice(Address destination);
    }
}
