using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System.Collections.Generic;

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

        [TestMethod]
        public void Test_Buy_One_Episode1_And_One_Episode2_CheckoutPrice_Should_Be_190()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 190;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_One_Episode1_And_One_Episode2_And_One_Episode3_CheckoutPrice_Should_Be_270()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 270;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_One_Episode1_And_One_Episode2_And_One_Episode3_And_One_Episode4_CheckoutPrice_Should_Be_320()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 320;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_One_Episode1_And_One_Episode2_And_One_Episode3_And_One_Episode4_And_One_Episode5_CheckoutPrice_Should_Be_375()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 1, Price = 100 }
            };
            var expected = 375;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_One_Episode1_And_One_Episode2_And_Two_Episode3_CheckoutPrice_Should_Be_370()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 370;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_One_Episode1_And_Two_Episode2_And_Two_Episode3_CheckoutPrice_Should_Be_460()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 0, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 0, Price = 100 }
            };
            var expected = 460;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_Two_Episode1_And_Two_Episode2_And_Two_Episode3_And_One_Episode4_And_One_Episode5_CheckoutPrice_Should_Be_640()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 1, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 1, Price = 100 }
            };
            var expected = 640;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_Two_Episode1_And_Two_Episode2_And_Two_Episode3_And_Two_Episode4_And_One_Episode5_CheckoutPrice_Should_Be_695()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 1, Price = 100 }
            };
            var expected = 695;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_Four_Episode1_And_Four_Episode2_And_Four_Episode3_And_Two_Episode4_And_Two_Episode5_CheckoutPrice_Should_Be_1280()
        {
            var target = new PotterCart();
            var cartList = new List<PotterSeries>
            {
                new PotterSeries { Episode = 1, Quantity = 4, Price = 100 },
                new PotterSeries { Episode = 2, Quantity = 4, Price = 100 },
                new PotterSeries { Episode = 3, Quantity = 4, Price = 100 },
                new PotterSeries { Episode = 4, Quantity = 2, Price = 100 },
                new PotterSeries { Episode = 5, Quantity = 2, Price = 100 }
            };
            var expected = 1280;

            var actual = target.GetCheckoutPrice(cartList);

            Assert.AreEqual(expected, actual);
        }
    }
}