using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;
        private Boolean mAvailable;
        private float mUnitPrice;
        private int mStockQuantity;
        private String mProductName;
        private DateTime mDateOfPurchase;


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
        public DateTime DateOfPurchase
        {
            get
            {
                return mDateOfPurchase;
            }
            set
            {
                mDateOfPurchase = value;
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
        public int StockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
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
        public int StockId
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }

        public bool Find(int stockQuantity)
        {
            mStockID = 21;
            mAvailable = Convert.ToBoolean(false);
            mUnitPrice = (float)Convert.ToDouble("1.0");
            mStockQuantity = 21;
            mProductName = Convert.ToString("product");
            mDateOfPurchase = Convert.ToDateTime("09/03/2023");
            return true;
        }
    }
}