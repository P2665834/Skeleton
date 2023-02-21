using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()

        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Available = TestData;
            Assert.AreEqual(ASupplier.Available, TestData);
        }

        [TestMethod]
        public void DatePurchasePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DatePurchased = TestData;
            Assert.AreEqual(ASupplier.DatePurchased, TestData);
        }

        [TestMethod]
        public void QuantityOfProductsOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.QuantityOfProducts = TestData;
            Assert.AreEqual(ASupplier.QuantityOfProducts, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "supplier";
            ASupplier.ProductName = TestData;
            Assert.AreEqual(ASupplier.ProductName, TestData);
        }

        [TestMethod]
        public void SupplierIdOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierId = TestData;
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void UnitPriceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            float TestData = 1;
            ASupplier.UnitPrice = TestData;
            Assert.AreEqual(ASupplier.UnitPrice, TestData);
        }
    }
}
