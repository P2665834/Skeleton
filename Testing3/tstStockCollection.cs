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
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);

        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.ProductID = 1;
            TestStock.ProductName = "HP 15s-fq2024na";
            TestStock.StockQuantity = 24;
            TestStock.UnitPrice = 250;
            TestStock.DateOfPurchase = DateTime.Now.Date;
            TestStock.Available = true;
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()

        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 1;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            TestItem.ProductName = "Asus Chromebook CM14";
            TestItem.StockQuantity = 29;
            TestItem.UnitPrice = 300;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductName = "HP 15s-fq2024na";
            TestItem.StockQuantity = 24;
            TestItem.UnitPrice = 250;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("xxxxxxx xxx");
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.ReportByProductName("yyyyyyy yyy");
            if (FilteredStocks.Count == 2)
            {
                if (FilteredStocks.StockList[0].ProductID != 4)
                {
                    OK = false;
                }
                if (FilteredStocks.StockList[1].ProductID != 5)
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

