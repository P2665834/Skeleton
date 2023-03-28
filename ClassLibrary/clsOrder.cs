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
    }
}