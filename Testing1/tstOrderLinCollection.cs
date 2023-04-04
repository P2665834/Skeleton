using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderLinCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList1 = new List<clsOrderLine>();
            clsOrderLine TestItem1 = new clsOrderLine();
            TestItem1.OrderID = 1;
            TestItem1.OrderLineID = 1;
            TestItem1.ProductName = "Macbook Air";
            TestItem1.Quantity = 1;
            TestItem1.Dispatched = false;
            TestList1.Add(TestItem1);
            AllOrderLines.OrderLineList = TestList1;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList1);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.OrderID = 1;
            TestOrderLine.OrderLineID = 1;
            TestOrderLine.ProductName = "Macbook Air";
            TestOrderLine.Quantity = 1;
            TestOrderLine.Dispatched = false;
            TestOrderLine.ThisOrderLine = TestOrderLine;
            Assert.AreNotEqual(AllOrderLines.ThisOrderLine, TestOrderLine);
        }

        public void ListAndCountOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList1 = new List<clsOrderLine>();
            clsOrderLine TestItem1 = new clsOrderLine();
            TestItem1.OrderID = 1;
            TestItem1.OrderLineID = 1;
            TestItem1.ProductName = "Macbook Air";
            TestItem1.Quantity = 1;
            TestItem1.Dispatched = false;
            TestList1.Add(TestItem1);
            AllOrderLines.OrderLineList = TestList1;
            Assert.AreEqual(AllOrderLines.Count, TestList1.Count);
        }
    }
}