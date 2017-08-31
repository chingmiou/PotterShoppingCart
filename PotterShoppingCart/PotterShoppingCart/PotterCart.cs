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
            { 4, 0.80M }
        };

        public PotterCart()
        {
        }

        public decimal GetCheckoutPrice(List<PotterSeries> potterList)
        {
            return potterList.Sum(x => x.Price * x.Quantity) * _discountRates[potterList.Sum(x => x.Quantity)];
        }
    }
}