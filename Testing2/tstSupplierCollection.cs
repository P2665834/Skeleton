using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;


namespace Testing2
{
    [TestClass]
    public class tstSupplierCollection
    {
        

        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);

        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s - fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierName = "hp";
            TestSupplier.ProductName = "15s - fq2024na";
            TestSupplier.QuantityOfProducts = 25;
            TestSupplier.UnitPrice = 200;
            TestSupplier.DatePurchased = DateTime.Now.Date;
            TestSupplier.Available = true;
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s - fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()

        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s-fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s-fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.SupplierName = "Lenovo";
            TestItem.ProductName = "ThinkBook 13x";
            TestItem.QuantityOfProducts = 35;
            TestItem.UnitPrice = 250;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = false;
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s-fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            AllSuppliers.ThisSupplier = TestItem;
            TestItem.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByProductName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByProductName("xxxxxxx xxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportByProductName("yyyyyyy yyy");
            if(FilteredSuppliers.Count == 2)
            {
                if(FilteredSuppliers.SupplierList[0].SupplierId != 4)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[1].SupplierId != 5)
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

