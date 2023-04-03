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

        

    }
}
