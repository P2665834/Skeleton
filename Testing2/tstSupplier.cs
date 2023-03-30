using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        string SupplierName = "hp";
        string ProductName = "15s-fq2024na";
        string QuantityOfProducts = "25";
        string UnitPrice = "200";
        string DatePurchased = DateTime.Now.Date.ToString();
    
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
        public void SupplierNameOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "supplier";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);

        }

        [TestMethod]
        public void UnitPriceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            float TestData = 1;
            ASupplier.UnitPrice = TestData;
            Assert.AreEqual(ASupplier.UnitPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityOfProductsFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.QuantityOfProducts != 30)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePurchasedFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.DatePurchased != Convert.ToDateTime("07/02/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
            
        }
       
        [TestMethod]
        public void TestAvailableFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.UnitPrice != Convert.ToDouble("225"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.ProductName != Convert.ToString("Chromebook CM14"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierName != Convert.ToString("Asus"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "a";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "aa";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "a";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "aa";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(51, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePurchased = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DatePurchased = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePurchased = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePurchased = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePurchased = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(0);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(1);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(52);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(53);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(54);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = UnitPrice.PadRight(26);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(0);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(1);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(31);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(32);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(33);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityOfProductsMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string QuantityOfProducts = "";
            QuantityOfProducts = QuantityOfProducts.PadRight(16);
            Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
            Assert.AreEqual(Error, "");
        }



    }

}
