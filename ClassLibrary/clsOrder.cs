using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;
        private DateTime mDateRecieved;
        private float mPrice;
        private String mCustomerName;



        public float Price
        {
            get
            {
                return mPrice;

            }

            set
            {
                mPrice = value;
            }
        }
        public int OrderID

        {
            get
            {
                return mOrderID;

            }

            set
            {
                mOrderID = value;
            }
        }
        public DateTime DateRecieved
        {
            get
            {
                return mDateRecieved;

            }

            set
            {
                mDateRecieved = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return mCustomerName;

            }

            set
            {
                mCustomerName = value;
            }
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrderID_FilterByOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDateRecieved = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRecieved"]);
                mPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                return true;

            }
            else
            {
                return false;
            }
        }

        public string Valid(string DateRecieved, string CustomerName, string Price)
        {
            String Error = "";
            DateTime DateTemp;
            if (CustomerName.Length == 0)
            {
                Error = Error + "The Customer Name may not be blank : ";
            }
            if (CustomerName.Length > 50)
            {
                Error = Error + "The Customer name must be less than 50 characters : ";
            }
            
            if (Price.Length > 53)
            {
                Error = Error + "The price must be less than 53 characters : ";
            }
            if (Price.Length == 0)
            {
                Error = Error + "The price may not be blank : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateRecieved);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;

        }


    }
}