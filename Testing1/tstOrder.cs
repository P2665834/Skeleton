using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        string OrderID = "1";
        string CustomerName = "Joe Bloggs";
        string Price = "1300";
        string DateRecieved = DateTime.Now.Date.ToString();

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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateRecievedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePurchased = TestDate.ToString();
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DatePurchased = TestDate.ToString();
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePurchased = TestDate.ToString();
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePurchased = TestDate.ToString();
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePurchased = TestDate.ToString();
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "";
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerrNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "a";
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "a";
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49,'a');
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(0);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(1);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(52);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(53);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(54);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(26);
            Error = AnOrder.Valid(DateRecieved, CustomerName, Price);
            Assert.AreEqual(Error, "");
        }
    }
}