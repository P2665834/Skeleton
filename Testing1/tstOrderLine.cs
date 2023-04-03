using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderLine
    {
        string OrderLineID = "1";
        string ProductName = "Macbook Air";
        string Quantity = "1";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void DispatchedOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean TestData = true;
            AnOrderLine.Dispatched = TestData;
            Assert.AreEqual(AnOrderLine.Dispatched, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.Quantity = TestData;
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            string TestData = "Product";
            AnOrderLine.ProductName = TestData;
            Assert.AreEqual(AnOrderLine.ProductName, TestData);
        }

        [TestMethod]
        public void OrderLineIDOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineID = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderID = TestData;
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderLineID = 1;
            Found = AnOrder.Find(OrderLineID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderLineID != 1)

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderID != 1)

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.ProductName != Convert.ToString("Macbook Air"))

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.Quantity != 1)

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 1;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.Dispatched != Convert.ToBoolean(false))

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineIDMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineIDProductsMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(0);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(1);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineIDMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(31);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineProductsMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(32);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(33);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineID = "";
            OrderLineID = OrderLineID.PadRight(16);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "a";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "aa";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(51, 'a');
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(0);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(1);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(31);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantitysMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(32);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(33);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(16);
            Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
            Assert.AreEqual(Error, "");
        }

    }
}