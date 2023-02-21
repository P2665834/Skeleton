using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);

        }
        [TestMethod]
        public void AvailableOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void DateOfPurchaseOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateOfPurchase = TestData;
            Assert.AreEqual(AStock.DateOfPurchase, TestData);
        }

        [TestMethod]
        public void UnitPriceOK()
        {
            clsStock AStock = new clsStock();
            float TestData = 1;
            AStock.UnitPrice = TestData;
            Assert.AreEqual(AStock.UnitPrice, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.StockQuantity = TestData;
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "stock";
            AStock.ProductName = TestData;
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]
        public void StockIdOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.StockId = TestData;
            Assert.AreEqual(AStock.StockId, TestData);
        }

    }
}
