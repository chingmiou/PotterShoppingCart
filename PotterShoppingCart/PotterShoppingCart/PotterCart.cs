using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class PotterCart
    {
        private Dictionary<int, decimal> _discountRates = new Dictionary<int, decimal>
        {
            { 1, 1.00M },
            { 2, 0.95M },
            { 3, 0.90M },
            { 4, 0.80M },
            { 5, 0.75M }
        };

        public PotterCart()
        {
        }

        public decimal GetCheckoutPrice(List<PotterSeries> potterList)
        {
            int countBuyOne = potterList.Count(x => x.Quantity == 1);
            int countBuyTwo = potterList.Count(x => x.Quantity == 2);

            if (countBuyOne > 0 && countBuyTwo > 1 && countBuyOne % 2 == 0)
            {
                return potterList.Sum(x => x.Price * x.Quantity) * _discountRates[countBuyTwo + 1];
            }

            return CalculateCheckoutPrice(potterList);
        }

        private decimal CalculateCheckoutPrice(List<PotterSeries> potterList)
        {
            decimal totalPrice = 0;

            foreach (var discountQuantity in _discountRates.Keys)
            {
                List<PotterSeries> seriesList = potterList.FindAll(x => x.Quantity >= discountQuantity);
                totalPrice += seriesList.Count == 0 ? 0 : seriesList.Sum(x => x.Price) * _discountRates[seriesList.Count];
            }

            return totalPrice;
        }
    }
}