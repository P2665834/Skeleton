using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.Price = TestData;
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Customer";
            AnOrder.CustomerName = TestData;
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void DateRecievedOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateRecieved = TestData;
            Assert.AreEqual(AnOrder.DateRecieved, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)

            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateRecieved()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DateRecieved != Convert.ToDateTime("14/02/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Price != (float)Convert.ToDouble("1300"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerName != Convert.ToString("Joe Bloggs"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}