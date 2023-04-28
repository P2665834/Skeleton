using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System;


namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            Assert.IsNotNull(AllEmployees);

        }

        [TestMethod]
        public void EmployeeListOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EmployeeID = 1;
            TestItem.EmployeeFullName = "Roger Smith";
            TestItem.EmployeePosition = "Advisor";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 11.50;
            TestItem.CurrentlyWorking = true;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllEmployees.EmployeeList, TestList);
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.EmployeeID = 1;
            TestStaff.EmployeeFullName = "Roger Smith";
            TestStaff.EmployeePosition = "Advisor";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.Salary = 11.50;
            TestStaff.CurrentlyWorking = true;
            AllEmployees.ThisEmployer = TestStaff;
            Assert.AreEqual(AllEmployees.ThisEmployee, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EmployeeID = 1;
            TestItem.EmployeeFullName = "Roger Smith";
            TestItem.EmployeePosition = "Advisor";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 11.50;
            TestItem.CurrentlyWorking = true;
            TestList.Add(TestItem);
            AllEmployees.EmployeeList = TestList;
            Assert.AreEqual(AllEmployees.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()

        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EmployeeID = 1;
            TestItem.EmployeeFullName = "Roger Smith";
            TestItem.EmployeePosition = "Advisor";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 11.50;
            TestItem.CurrentlyWorking = true;
            AllEmployees.ThisEmployee = TestItem;
            PrimaryKey = AllEmployees.Add();
            TestItem.EmployeeID= PrimaryKey;
            AllEmployees.ThisEmployee.Find(PrimaryKey);
            Assert.AreEqual(AllEmployees.ThisEmployee, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EmployeeID = 1;
            TestItem.EmployeeFullName = "Roger Smith";
            TestItem.EmployeePosition = "Advisor";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 11.50;
            TestItem.CurrentlyWorking = true;
            AllEmployees.ThisEmployee = TestItem;
            PrimaryKey = AllEmployees.Add();
            clsStaff TestItem = new clsStaff();
            PrimaryKey = AllEmployees.Add();
            TestItem.EmployeeID = PrimaryKey;
            TestItem.EmployeeFullName = "Spike Richards";
            TestItem.EmployeePosition = "Manager";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 13.50;
            TestItem.CurrentlyWorking = false;
            AllStaff.ThisEmployee = TestItem;
            AllStaff.Update();
            AllStaff.ThisEmployee.Find(PrimaryKey);
            Assert.AreEqual(AllEmployees.ThisEmployee, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.EmployeeFullName = "Roger Smith";
            TestItem.EmployeePosition = "Advisor";
            TestItem.DateOfEmployment = DateTime.Now.Date;
            TestItem.Salary = 11.50;
            TestItem.CurrentlyWorking = true;
            AllEmployees.ThisEmployee = TestItem;
            TestItem.EmployeeID = PrimaryKey;
            AllSuppliers.ThisEmployee.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllEmployees.ThisEmployee.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsStaffCollection AllEmployees = new clsStaffCollection();
            clsStaffCollection FilteredEmployees = new clsStaffCollection();
            FilteredEmployees.ReportByProductName("");
            Assert.AreEqual(AllEmployees.Count, FilteredEmployees.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStaffCollection FilteredEmployees = new clsSupplierCollection();
            FilteredEmployees.ReportByProductName("XXX XXXXX");
            Assert.AreEqual(0, FilteredEmployees.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStaffCollection FilteredEmployees = new clsStaffCollection();
            Boolean OK = true;
            FilteredEmployees.ReportByProductName("XXXXX XXXXX");
            if(FilteredEmployee.Count == 2)
            {
                if(FilteredEmployee.EmployeeList[0].EmployeeID != 4)
                {
                    OK = false;
                }
                if (FilteredEmployee.EmployeeList[1].EmployeeID != 5)
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

