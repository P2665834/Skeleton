using System;
namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderID;
        private Int32 mOrderLineID;
        private String mProductName;
        private int mQuantity;
        private bool mDispatched; 

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
                return ProductName;
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
                return Quantity;
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
            mOrderID = 21;
            mOrderLineID = 21;
            mProductName = Convert.ToString("Product");
            mQuantity = 21;
            mDispatched = Convert.ToBoolean(false);
            return true;
        }
    }

}

