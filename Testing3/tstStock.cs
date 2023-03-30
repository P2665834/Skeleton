using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        string ProductName = "HP 15s-fq2024na";
        string StockQuantity = "24";
        string UnitPrice = "250";
        string DateOfPurchase = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "a";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "aa";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockName = "";
            ProductName = ProductName.PadRight(51, 'a');
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfPurchase = TestDate.ToString();
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateOfPurchase = TestDate.ToString();
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfPurchase = TestDate.ToString();
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfPurchase = TestDate.ToString();
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(0);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(1);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(52);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(53);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(54);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(26);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(0);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(1);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(31);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(32);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(33);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(16);
            Error = AStock.Valid(ProductName, StockQuantity, UnitPrice, DateOfPurchase);
            Assert.AreEqual(Error, "");
        }



    }
}
