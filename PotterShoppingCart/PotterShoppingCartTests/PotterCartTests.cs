using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCartTests
{
    [TestClass]
    public class PotterCartTests
    {
        [TestMethod]
        public void Test_Only_Buy_One_Episode1_CheckoutPrice_Should_Be_100()
        {
            var target = new PotterCart();
            var potterList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 100;

            var actual = target.GetCheckoutPrice(potterList);

            Assert.AreEqual(expected, actual);
        }
    }
}
