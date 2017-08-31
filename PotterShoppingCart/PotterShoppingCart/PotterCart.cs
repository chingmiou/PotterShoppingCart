using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class PotterCart
    {
        public PotterCart()
        {
        }

        public decimal GetCheckoutPrice(List<PotterSeries> potterList)
        {
            if (potterList.Sum(x => x.Quantity) == 3)
            {
                return potterList.Sum(x => x.Price * x.Quantity) * 0.9M;
            }

            if (potterList.Sum(x => x.Quantity) == 2)
            {
                return potterList.Sum(x => x.Price * x.Quantity) * 0.95M;
            }

            return potterList.Sum(x => x.Price * x.Quantity);
        }
    }
}