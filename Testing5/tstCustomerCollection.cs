using System;
using System.Collections.Generic;
using ClassLibrary
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestingCustomer
{
    public class tstCustomerCollection
    using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;


namespace Testing2
    {
        [TestClass]
        public class tstCustomerCollection
        {


            [TestMethod]
            public void InstanceOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                Assert.IsNotNull(AllCustomers);

            }

            [TestMethod]
            public void CustomerListOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                List<clsCustomer> TestList = new List<clsCustomer>();
                clsCustomer TestItem = new clsCustomer();
                TestItem.CustomerID = 1;
                TestItem.Name = "steve";
                TestItem.Address= "minecraft";
                TestItem.PhoneNumber= 1010101101;
                TestItem.EmailAddress = "steve@gmail.com";
                TestItem.DateofBirth = "2003/04/11";
                TestItem.SignUp = true;
                TestList.Add(TestItem);
                AllCustomers.CustomerList = TestList;
                Assert.AreEqual(AllCustomers.CustomerList, TestList);
            }

            [TestMethod]
            public void ThisCustomerPropertyOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                clsCustomer TestCustomer = new clsCustomer();
                TestCustomer.CustomerID = 1;
                TestCustomer.Name = "steve";
                TestCustomer.Address = "minecraft";
                TestCustomer.PhoneNumber = 1010101101;
                TestCustomer.EmailAddress = "steve@gmail.com";
                TestCustomer.DateofBirth = DateTime."2003/04/11";
                TestCustomer.SignUp = true;
                AllCustomers.ThisCustomer = TestCustomer;
                Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                List<clsCustomer> TestList = new List<clsCustomer>();
                clsCustomer TestItem = new clsCustomer();
                TestItem.CustomerID = 1;
                TestItem.Name = "steve";
                TestItem.Address = "minecraft";
                TestItem.PhoneNumber = 1010101101;
                TestItem.EmailAddress = "steve@gmail.com";
                TestItem.DateofBirth = DateTime."2003/04/11";
                TestItem.SignUp = true;
                TestList.Add(TestItem);
                AllCustomers.CustomerList = TestList;
                Assert.AreEqual(AllCustomers.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()

            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                clsCustomer TestItem = new clsCustomer();
                Int32 PrimaryKey = 0;
                TestItem.CustomerID = 1;
                TestItem.Name = "villager";
                TestItem.Address = "town";
                TestItem.PhoneNumber = 098765324;
                TestItem.EmailAddress = "huuuuh@gmail.com";
                TestItem.DateofBirth = DateTime. "1956/03/30";
                TestItem.SignUp = true;
                AllCustomers.ThisCustomer = TestItem;
                PrimaryKey = AllCustomers.Add();
                TestItem.CustomerID = PrimaryKey;
                AllCustomers.ThisCustomer.Find(PrimaryKey);
                Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
            }

            [TestMethod]
            public void UpdateMethodOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                clsCustomer TestItem = new clsCustomer();
                Int32 PrimaryKey = 0;
                TestItem.Name = "spider";
                TestItem.Address = "cave";
                TestItem.PhoneNumber = 12345632;
                TestItem.EmailAddress = "spider@outlook.com";
                TestItem.DateofBirth = DateTime "1965/06/28";
                TestItem.SignUp = true;
                AllCustomers.ThisCustomer = TestItem;
                PrimaryKey = AllCustomers.Add();
                TestItem.CustomerID = PrimaryKey;
                TestItem.Name = "creeper";
                TestItem.Address = "underground";
                TestItem.PhoneNumber = 000000000;
                TestItem.EmailAddress = "creeper@hotmail.com";
                TestItem.DateofBirth = DateTime "1934/02/13";
                TestItem.SignUp = false;
                AllCustomers.ThisCustomer = TestItem;
                AllCustomers.Update();
                AllCustomers.ThisCustomer.Find(PrimaryKey);
                Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            }

            [TestMethod]
            public void DeleteMethodOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                clsCustomer TestItem = new clsCustomer();
                Int32 PrimaryKey = 0;
                TestItem.Name = "alex";
                TestItem.Address = "minecraft";
                TestItem.PhoneNumber = 68684993;
                TestItem.EmailAddress = "alex@gmail.com";
                TestItem.DateofBirth = DateTime "2003/03/20";
                TestItem.SignUp = true;
                AllCustomers.ThisCustomer = TestItem;
                TestItem.CustomerID = PrimaryKey;
                AllCustomers.ThisCustomer.Find(PrimaryKey);
                AllCustomers.Delete();
                Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
                Assert.IsFalse(Found);
            }

            [TestMethod]
            public void ReportByAddressMethodOK()
            {
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                FilteredCustomers.ReportByAddress("");
                Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
            }

            [TestMethod]
            public void ReportByAddressNoneFound()
            {
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                FilteredCustomers.ReportByAddress("minecraft");
                Assert.AreEqual(0, FilteredCustomers.Count);
            }

            [TestMethod]
            public void ReportByAddressDataFound()
            {
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                Boolean OK = true;
                FilteredCustomers.ReportByAddress("minecraft");
                if (FilteredCustomers.Count == 2)
                {
                    if (FilteredCustomers.CustomerList[0].CustomerID != 4)
                    {
                        OK = false;
                    }
                    if (FilteredCustomers.CustomerList[1].CustomerID != 5)
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










