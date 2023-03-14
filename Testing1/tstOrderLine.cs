using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderLine
    {
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
            Int32 OrderLineID = 21;
            Found = AnOrder.Find(OrderLineID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineID = 21;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderLineID != 21)

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
            Int32 OrderLineID = 21;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.OrderID != 21)

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
            Int32 OrderLineID = 21;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.ProductName != Convert.ToString("Product"))

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
            Int32 OrderLineID = 21;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.Quantity != 21)

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
            Int32 OrderLineID = 21;
            Found = AnOrderLine.Find(OrderLineID);
            if (AnOrderLine.Dispatched != Convert.ToBoolean(false))

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

    }
}