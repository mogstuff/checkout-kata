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

            sut.Items.Add(new Item { SKU = "ACME01", UnitPrice = 2.00M });
            sut.Items.Add(new Item { SKU = "ACME01", UnitPrice = 2.00M });
            sut.Items.Add(new Item { SKU = "ACME01", UnitPrice = 2.00M });

            decimal expectedTotal = 6.00M;
            decimal total = sut.GetTotal(sut.Items);

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