using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        public bool Find (int EmployeeID)
        { 
        string EmployeeFullName = "Roger Smith";
        string EmployeePosition = "Advisor";
        string Salary = "11.50";
        string DateOfEmployment = DateTime.Now.Date.ToString();
        }

        [TestMethod]
        public void InstanceOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();

            Assert.IsNotNull(aMemberOfStaff);
        }


          [TestMethod]
        public void StaffEmployeeIDOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Int32 TestData = 2;
            aMemberOfStaff.EmployeeID = TestData;
            Assert.AreEqual(aMemberOfStaff.EmployeeID, TestData);
        }

        [TestMethod]
        public void EmployeeFullNameOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            string TestData = "Roger Smith";
            aMemberOfStaff.EmployeeFullName = TestData;
            Assert.AreEqual(aMemberOfStaff.EmployeeFullName, TestData);
        }


        [TestMethod]
        public void StaffEmployeePositionOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            string TestData = "Advisor";
            aMemberOfStaff.EmployeePosition = TestData;
            Assert.AreEqual(aMemberOfStaff.EmployeePosition, TestData);
        }

        [TestMethod]
        public void StaffDateOfEmploymentOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aMemberOfStaff.DateOfEmployment = TestData;
            Assert.AreEqual(aMemberOfStaff.DateOfEmployment, TestData);
        }

        [TestMethod]
        public void StaffSalaryOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            float TestData = 11.50;
            aMemberOfStaff.Salary = TestData;
            Assert.AreEqual(aMemberOfStaff.Salary, TestData);
        }

        [TestMethod]
        public void StaffCurrentlyWorkingOk()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean TestData = true;
            aMemberOfStaff.CurrentlyWorking = TestData;
            Assert.AreEqual(aMemberOfStaff.CurrentlyWorking, TestData);
        }

         [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Int32 EmployeeID = 2;
            Found = ASupplier.Find(EmployeeID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeIDFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if (aMemberOfStaff.EmployeeID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmployeeFullNameFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if(aMemberOfStaff.EmployeeFullName != Convert.ToString("Roger Smith"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

       [TestMethod]
        public void TestEmployeePositionFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if(aMemberOfStaff.EmployeeFullName != Convert.ToString("Advisor"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
            
            
        }
       
       [TestMethod]
        public void TestDateOfEmploymentFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if(aMemberOfStaff.DateOfEmployment != Convert.ToDateTime("28/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if (aMemberOfStaff.Salary != Convert.ToDouble("11.50"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

       [TestMethod]
        public void TestCurrentlyWorkingFound()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 2;
            Found = aMemberOfStaff.Find(EmployeeID);
            if (aMemberOfStaff.CurrentlyWorking != Convert.ToBoolean(true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        

        
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeFullNameMinLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMin()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "a";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMinPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "aa";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMaxLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "";
            EmployeeFullName = EmployeeFullName.PadRight(49, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMax()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "";
            EmployeeFullName = EmployeeFullName.PadRight(50, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

     [TestMethod]
        public void EmployeeFullNameMaxPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "";
            EmployeeFullName = EmployeeFullName.PadRight(51, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMid()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeeFullName = "";
            EmployeeFullName = EmployeeFullName.PadRight(25, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }
        

         }

        [TestMethod]
        public void EmployeePositionMinLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMin()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "a";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMinPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "aa";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMaxLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "";
            EmployeePosition = EmployeePosition.PadRight(49, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMax()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "";
            EmployeePosition= EmployeePosition.PadRight(50, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

     [TestMethod]
        public void EmployeePositionMaxPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "";
            EmployeePosition = EmployeePosition.PadRight(51, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMid()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string EmployeePosition = "";
            EmployeePosition = EmployeePosition.PadRight(25, 'a');
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentExtremeMin()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfEmployment = TestDate.ToString();
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentMinLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateOfEmployment = TestDate.ToString();
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

         [TestMethod]
        public void DateOfEmploymentMin()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfEmployment = TestDate.ToString();
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

     [TestMethod]
        public void DateOfEmploymentMinPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfEmployment = TestDate.ToString();
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentExtremeMax()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfEmployment = TestDate.ToString();
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMin()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(0);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(1);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(52);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(53);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(54);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMid()
        {
            clsStaff aMemberOfStaff = new clsStaff();
            String Error = "";
            string Salary = "";
            Salary = Salary.PadRight(26);
            Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
            Assert.AreEqual(Error, "");
        }

      