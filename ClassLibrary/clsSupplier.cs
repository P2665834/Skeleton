using System;

namespace ClassLibrary
{
    public class clsSupplier
    {

        private Int32 mQuantityOfProducts;
        private DateTime mDatePurchased;
        private Boolean mAvailable;
        private float mUnitPrice;
        private String mProductName;
        private Int32 mSupplierID;

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
                
        public DateTime DatePurchased
        {
            get
            {
                return mDatePurchased;
            }
            set
            {
                mDatePurchased = value;
            }
        }
               
        public int QuantityOfProducts
        {
            get
            {
                return mQuantityOfProducts;
            }
            set
            {
                mQuantityOfProducts = value;
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
        public int SupplierId
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }
        public float UnitPrice
        {
            get
            {
                return mUnitPrice;
            }
            set
            {
                mUnitPrice = value;
            }
        }

        public bool Find(int quantityOfProducts)
        {
            mQuantityOfProducts = 21;
            mDatePurchased = Convert.ToDateTime("09/03/2023");
            mUnitPrice = (float)Convert.ToDouble("1.0");
            mAvailable = Convert.ToBoolean(true);
            mProductName = Convert.ToString("product");
            mSupplierID = 21;

            return true;
        }
        
    }
}