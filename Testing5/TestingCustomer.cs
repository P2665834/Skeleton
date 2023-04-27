using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerTesting
{
    [TestClass]
    public class tstCustomer
    {
        string Name = "Sofian";
        string EmailAddress = "sofianelmaghrebi@hotmail.com";
        string PhoneNumber = "07789979887";
        string DateofBirth = Convert.ToDateTime("2003/04/21").ToString();
        string Address = "BrazilStreet";

        [TestMethod]
        public void InstanceOK()
        
            
            clsCustomer ACostumer = new clsCustomer();
           
            Assert.IsNotNull(ACostumer);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            
            clsCustomer ACustomer = new clsCustomer();
            
            int TestData = 1;
            
            ACustomer.CustomerID = TestData;
            
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            
            clsCustomer ACostumer = new clsCustomer();
          
            String TestData = "Usama";
            
            ACostumer.Name = TestData;
            
            Assert.AreEqual(ACostumer.Name, TestData);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
           
            clsCustomer ACostumer = new clsCustomer();
            
            String TestData = "Usama23@gmail.com";
            
            ACostumer.EmailAddress = TestData;
            
            Assert.AreEqual(ACostumer.EmailAddress, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
           
            clsCustomer ACostumer = new clsCustomer();
            
            Int32 TestData = 1;
            
            ACostumer.PhoneNumber = TestData;
            
            Assert.AreEqual(ACostumer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void DateofBirthOK()
        {
            
            clsCustomer ACostumer = new clsCustomer();
           
            DateTime TestData = DateTime.Now.Date;
         
            ACostumer.DateofBirth = TestData;
            
            Assert.AreEqual(ACostumer.DateofBirth, TestData);
        }

        [TestMethod]
        public void SignUpOK()
        {
     
            clsCustomer ACostumer = new clsCustomer();
     
            Boolean TestData = true;
        
            ACostumer.SignUp = TestData;
            
            Assert.AreEqual(ACostumer.SignUp, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            
            Boolean Found = false;
            
            Int32 customerID = 1;
           
            Found = customer.Find(customerID);
            
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
         
            clsCustomer customer = new clsCustomer();
           
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int32 customerID = 1;
            
            Found = customer.Find(customerID);
            
            if (customer.CustomerID != 1)
            {
                OK = false;
            
            
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerNameFound()
        {
            
            clsCustomer customer = new clsCustomer();
            Boolean Found = false;
          
            Boolean OK = true;
           
            Int32 customerID = 1;
            
            Found = customer.Find(customerID);
            
            if (customer.Name != "Samual")
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressFound()
        {
            
            clsCustomer customer = new clsCustomer();
            
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int32 customerID = 1;
            
            Found = customer.Find(customerID);
            
            if (customer.EmailAddress != "Samual@outlook.com")
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void DateOfBirthFound()
        {
        
            clsCustomer customer = new clsCustomer();
          
            Boolean Found = false;
          
            Boolean OK = true;
           
            Int32 customerID = 1;
          
            Found = customer.Find(customerID);
            
            if (customer.DateofBirth != Convert.ToDateTime("13/09/2005"))
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberFound()
        {
          
            clsCustomer customer = new clsCustomer();
          
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int32 customerID = 1;
            
            Found = customer.Find(customerID);
         
            if (customer.PhoneNumber != Convert.ToInt32("9348833126"))
            {
                OK = false;
            }
       
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SignUpFound()
        {
           
            clsCustomer customer = new clsCustomer();
         
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int customerID = 1;
            
            Found = customer.Find(customerID);
           
            if (customer.SignUp != true)
            {
                OK = false;
            }
           
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
           
            string Error = "";
            
            string Name = ""; 
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);


            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            {
                clsCustomer customer = new clsCustomer();
           
                string Error = "";
              
                string Name = "S"; 
               
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);


                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string Name = "SEM";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameNoMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
              
                string Error = "";
               
                string Name = "";
                Name = Name.PadRight(49, 'S');
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string Name = "";
                Name = Name.PadRight(50, 'a');
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string Name = "";
                Name = Name.PadRight(25, 'S');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
              
                string Name = "";
                Name = Name.PadRight(51, 'S');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
              
                string Name = "";
                Name = Name.PadRight(500, 'S');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void DateofBirthExtremeMin()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1000);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMinLessOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100)


            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMin()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMinPlusOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100).AddDays(1);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthExtremeMax()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMax()
        {
            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-18);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMaxLessOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-18)


            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateofBirthMaxPlusOne()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-18).AddDays(1);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateofBirthMid()
        {

            clsCustomer customer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-12);

            string DateofBirth = TestDate.ToString();

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidDate()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";

            string DateofBirth = "Not a Date!";

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }


    }
        
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            
            string Error = "";
            
            string EmailAddress = "";

            Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string EmailAddress = "a";

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string EmailAddress = "kl";

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressNoMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
               
                string Error = "";
             
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(49, 'a');
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(50, 'a');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            {
                clsCustomer customer = new clsCustomer();
            
                string Error = "";
                
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(25, 'a');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
               
                string Error = "";
                
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(51, 'a');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                
                string Error = "";
                
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(500, 'a');

                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);

                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreNotEqual(Error, "");
            }
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "1";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "11";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumbeMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "123456889";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreEqual(Error, "");
            }
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "123456789";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "123456789";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "123456789";
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberExtemeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "";
                PhoneNumber = PhoneNumber.PadRight(500, '1');
                Error = customer.Valid(Name, Address, DateofBirth, EmailAddress, PhoneNumber);
                Assert.AreNotEqual(Error, "");
            }
        }

}

