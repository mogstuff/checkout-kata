using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutLibb;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutLibb.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void GetTotalTest()
        {
            var sut = new Checkout();

            // checkout items
            sut.Items.Add(new Item { SKU = "A99", UnitPrice = 0.50M });
            sut.Items.Add(new Item { SKU = "A99", UnitPrice = 0.50M });
            sut.Items.Add(new Item { SKU = "A99", UnitPrice = 0.50M });
            sut.Items.Add(new Item { SKU = "A99", UnitPrice = 0.50M });


            sut.Items.Add(new Item { SKU = "B15", UnitPrice = 0.30M });
            sut.Items.Add(new Item { SKU = "B15", UnitPrice = 0.30M });
            sut.Items.Add(new Item { SKU = "B15", UnitPrice = 0.30M });

            sut.Items.Add(new Item { SKU = "C40", UnitPrice = 0.60M });

            // special offers
            sut.Offers.Add(new SpecialOffer { SKU = "A99", Quantity = 3, OfferPrice = 1.30M });
            sut.Offers.Add(new SpecialOffer { SKU = "B15", Quantity = 2, OfferPrice = 0.45M });

            decimal total = sut.GetTotal(sut.Items, sut.Offers);

            decimal expectedTotal = 3.15M;

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod()]
        public void ScanItemTest()
        {
            var sut = new Checkout();

            var item = new Item { SKU = "ACME01", UnitPrice = 2.00M };

            sut.ScanItem(item);

            Assert.IsTrue(sut.Items.Count == 1);
        }
    }
}