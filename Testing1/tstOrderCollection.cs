using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;


namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        public object AllOrderLine { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            clsOrderLine TestItem1 = new clsOrderLine();
            TestItem.OrderID = 1;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 1;
            TestOrder.CustomerName = "Joe Bloggs";
            TestOrder.Price = 1300;
            TestOrder.DateRecieved = DateTime.Now.Date;
            TestOrder.ThisOrder = TestOrder;
            Assert.AreNotEqual(AllOrders.ThisOrder, TestOrder);
        }

        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            clsOrderLine TestItem1 = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem1.OrderLineID = 1;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            TestItem1.ProductName = "Macbook Air";
            TestItem1.Quantity = 1;
            TestItem1.Dispatched = false;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            clsOrderLine TestItem1 = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            TestItem1.ProductName = "Macbook Air";
            TestItem1.Quantity = 1;
            TestItem1.Dispatched = false;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestItem.CustomerName = "Elias Barton";
            TestItem.Price = 1300;
            TestItem1.ProductName = "Macbook Air";
            TestItem1.Quantity = 1;
            TestItem1.Dispatched = true;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerName("XXX XXXXXX");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByCustomerName("XXX XXXXXX");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 1)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 2)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }

    }
}