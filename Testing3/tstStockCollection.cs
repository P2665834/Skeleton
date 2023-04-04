using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;


namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);

        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.ProductID = 1;
            TestStock.ProductName = "HP 15s-fq2024na";
            TestStock.StockQuantity = 24;
            TestStock.UnitPrice = 250;
            TestStock.DateOfPurchase = DateTime.Now.Date;
            TestStock.Available = true;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }



    }
}