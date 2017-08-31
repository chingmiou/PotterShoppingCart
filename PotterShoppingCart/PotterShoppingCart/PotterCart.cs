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
            decimal discountRate = 1.0M;

            switch (potterList.Sum(x => x.Quantity))
            {
                case 1:
                    discountRate = 1.0M;
                    break;

                case 2:
                    discountRate = 0.95M;
                    break;

                case 3:
                    discountRate = 0.9M;
                    break;

                case 4:
                    discountRate = 0.8M;
                    break;
            }

            return potterList.Sum(x => x.Price * x.Quantity) * discountRate;
        }
    }
}