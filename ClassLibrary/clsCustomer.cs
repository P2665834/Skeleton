using System;

namespace ClassLibrary
{
    public class Customer
    {
        private Int mCustomerID;
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        private String mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private String mEmailAddress;
        public string EmailAddress
        {
            get { return mEmailAddress; }
            set { mEmailAddress = value; }
        }

        private Int mPhoneNumber;
        public int PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }

        private DateTime mDateofBirth;
        public DateTime DateofBirth
        {
            get { return mDateofBirth; }
            set { mDateofBirth = value; }
        }

        private Boolean mSignUp;
        public bool SignUp
        {
            get { return mSignUp; }
            set { mSignUp = value; }

        private String mAddress;
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }

        }
    }

    public bool Find(int customerID)
    {
        
        var db = new DataConnection();
        
        db.AddParameter("@CustomerID", customerID);
        
        db.Execute("sproc_tblCustomer_FilterByCustomerID");
    
        if (db.Count == 1)
        {

            mCustomerID = Convert.ToInt32(db.DataTable.Rows[0]["CustomerID"]);
            mName = Convert.ToString(db.DataTable.Rows[0]["Name"]);
            mEmailAddress = Convert.ToString(db.DataTable.Rows[0]["EmailAddress"]);
            mPhoneNumber = Convert.ToInt32(db.DataTable.Rows[0]["PhoneNumber"]);
            mDateofBirth = Convert.ToDateTime(db.DataTable.Rows[0]["DateofBirth"]);
            mSignup = Convert.ToBoolean(db.DataTable.Rows[0]["SignUp"]);
            mAddress = Convert.ToString(db.DataTable.rows[0]["Address"]);

            return true;
        }

        else
        {
            return false;
        }

    }

    public string Validate(string name, string emailAddress, string PhoneNumber, string dateofBirth, string Address)
    {

        String Error = "";
        DateTime DateTemp;

        if (string.IsNullOrEmpty(name))
        {

            Error += "The name may not be blank : ";
        }

        if (name.Length > 50)
        {

            Error += "The name must be less than 50 characters : ";
        }

        if (string.IsNullOrEmpty(PhoneNumber)
            {
            Error += "The phone number may not the blank.";

        }
        if (PhoneNumber.Length > 13)
        {
            Error = Error + "The phone number must be less than 13 characters.";
        }

        if (string.IsNullOrEmpty(emailAddress)
            {

            Error += "The email address may not be blank : ";
        }

        if (emailAddress.Length > 50)
        {

            Error += "The email address must be less than 50 characters : ";
            {
                if (string.IsNullOrEmpty(Address)
    
                Error += "The address must not be blank"


            {
                    if (Address.Length > 150)

                        Error += "The Address must be less than 150 characters : ";
                }
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
