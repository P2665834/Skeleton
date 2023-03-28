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
        public void ProductIDOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.ProductID = TestData;
            Assert.AreEqual(AStock.ProductID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 2;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.ProductID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.ProductName != Convert.ToString("HP 15s-fq2024na"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.StockQuantity != 24)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.UnitPrice != (float)Convert.ToDouble("250"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfPurchaseFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.DateOfPurchase != Convert.ToDateTime("14/02/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.Available != Convert.ToBoolean(true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
