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

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestQuantityOfProductsFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            if(ASupplier.QuantityOfProducts != 21)
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
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            if(ASupplier.DatePurchased != Convert.ToDateTime("09/03/2023"))
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
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
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
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            if (ASupplier.UnitPrice != (float)Convert.ToDouble("1.0"))
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
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            if(ASupplier.ProductName != Convert.ToString("product"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 QuantityOfProducts = 21;
            Found = ASupplier.Find(QuantityOfProducts);
            if(ASupplier.SupplierId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

                    
        }

        
    }
}
