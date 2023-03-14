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

        public bool Find(int orderID)
        {
            mOrderID = 21;
            mDateRecieved = Convert.ToDateTime("13/03/2023");
            mPrice = (float)Convert.ToDouble("1.0");
            mCustomerName = Convert.ToString("Customer");
            return true;

        }
    }
}