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

            decimal totalPrice = 0;

            List<PotterSeries> packageOne = potterList.FindAll(x => x.Quantity >= 1);
            totalPrice += packageOne.Sum(x => x.Price) * _discountRates[packageOne.Count];

            List<PotterSeries> packageTwo = potterList.FindAll(x => x.Quantity >= 2);
            if (packageTwo.Count == 0)
            {
                return totalPrice;
            }

            totalPrice += packageTwo.Sum(x => x.Price) * _discountRates[packageTwo.Count];
            return totalPrice;
        }
    }
}