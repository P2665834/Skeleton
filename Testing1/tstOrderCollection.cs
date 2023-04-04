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

    }
}
