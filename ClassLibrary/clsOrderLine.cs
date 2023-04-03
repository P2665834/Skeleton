using System;
namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderID;
        private Int32 mOrderLineID;
        private String mProductName;
        private Int32 mQuantity;
        private Boolean mDispatched;

        public int OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
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

        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public bool Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }

        public bool Find(int OrderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", OrderLineID);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string OrderLineID, string ProductName, string Quantity)
        {
            String Error = "";
            DateTime DateTemp;
            if (OrderLineID.Length == 0)
            {
                Error = Error + "The OrderLineID may not be blank : ";
            }
            if (OrderLineID.Length > 32)
            {
                Error = Error + "The OrderLineID must be less than 32 characters : ";
            }
            if (ProductName.Length == 0)
            {
                Error = Error + "The product name may not be blank : ";
            }
            if (ProductName.Length > 50)
            {
                Error = Error + "The product name must be less than 50 characters : ";
            }
            if (Quantity.Length == 0)
            {
                Error = Error + "The quantity may not be blank : ";
            }
            if (Quantity.Length > 32)
            {
                Error = Error + "The quantity of products must be less than 32 characters : ";

            }

            return Error;

        }
    }
}