using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class PotterCart
    {
        public PotterCart()
        {
        }

        public int GetCheckoutPrice(List<PotterSeries> potterList)
        {
            return potterList.Sum(x => x.Price * x.Quantity);
        }
    }
}