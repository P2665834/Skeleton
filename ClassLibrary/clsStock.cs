using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductID;
        private String mProductName;
        private float mUnitPrice;
        private int mStockQuantity;
        private DateTime mDateOfPurchase;
        private Boolean mAvailable;

        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
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

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblStock_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mUnitPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["UnitPrice"]);
                mDateOfPurchase = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
