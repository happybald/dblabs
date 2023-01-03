namespace Lab1
{
    class UkrPoshtaShippingPriceCalculator : ShippingPriceCalculator
    {
        override public decimal CalculateShippingPrice(Address destination)
        {
            return (ShopAddress.City.Length + destination.City.Length) / 2 * 5;
        }
    }
}
