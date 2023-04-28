using System;

namespace ClassLibrary
{
    public class clsCustomer

    {
        private Int32 mCustomerID;
        private String mName;
        private String mEmailAddress;
        private Int32 mPhoneNumber;
        private Boolean mSignUp;
        private String mAddress;
        private DateTime mDateofBirth;


        public Int32 CustomerID

        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public String Name

        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public String EmailAddress

        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }

        public Int32 PhoneNumber

        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public DateTime DateofBirth

        {
            get
            {
                return mDateofBirth;
            }
            set
            {
                mDateofBirth = value;
            }
        }

        public Boolean SignUp

        {
            get
            {
                return mSignUp;
            }
            set
            {
                mSignUp = value;
            }
        }
        public String Address

        {
            get
            {
                return mAddress;
            }
            set
            { mAddress = value; }

        }

        public bool Find(int customerID)
        {
            clsDataConnection db = new clsDataConnection();


            db.AddParameter("@CustomerID", customerID);

            db.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (db.Count == 1)
            {

                mCustomerID = Convert.ToInt32(db.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(db.DataTable.Rows[0]["Name"]);
                mEmailAddress = Convert.ToString(db.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNumber = Convert.ToInt32(db.DataTable.Rows[0]["PhoneNumber"]);
                mDateofBirth = Convert.ToDateTime(db.DataTable.Rows[0]["DateofBirth"]);
                mSignUp = Convert.ToBoolean(db.DataTable.Rows[0]["SignUp"]);
                mAddress = Convert.ToString(db.DataTable.Rows[0]["Address"]);

                return true;
            }

            else
            {
                return false;
            }

        }

        public string Valid(string name, string emailAddress, string PhoneNumber, string dateofBirth, string Address)
        {

            String Error = "";
            DateTime DateTemp;

            if (string.IsNullOrEmpty(name))
            {

                Error += "The name may not be blank! : ";
            }

            if (name.Length > 50)
            {

                Error += "The name must be less than 50 characters : ";
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                Error += "The phone number may not the blank.";

            }
            if (PhoneNumber.Length > 13)
            {
                Error += "The phone number must be less than 13 characters.";
            }

            if (string.IsNullOrEmpty(emailAddress))
            {

                Error += "The email address may not be blank : ";
            }

            if (emailAddress.Length > 50)
            {

                Error += "The email address must be less than 50 characters : ";
            }
            if (string.IsNullOrEmpty(Address))
            {


                Error += "The address must not be blank";

            }
               
            if (Address.Length > 150)
            {

                Error += "The Address must be less than 150 characters : ";
            }

                    try
                    {


                        DateTemp = Convert.ToDateTime(dateofBirth);


                        if (DateTemp < DateTime.Now.Date.AddYears(-90))
                        {

                            Error += "The date cannot be more than 90 years in the past  ";
                        }
                        if (DateTemp > DateTime.Now.Date.AddYears(-18))
                        {

                            Error += "The date must be over 18 years in the past ";
                        }


                    }
                    catch
                    {
                        Error += "The date was not a valid date ";
                    }
                    return Error;

                }
            }
        }
    

