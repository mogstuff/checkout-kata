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
            Assert.Fail();
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