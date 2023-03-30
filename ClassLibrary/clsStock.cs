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

        public string Valid(string ProductName, string StockQuantity, string UnitPrice, string DateOfPurchase)
        {
            String Error = "";
            DateTime DateTemp;
            
            if (ProductName.Length == 0)
            {
                Error = Error + "The product name may not be blank : ";
            }
            if (ProductName.Length > 50)
            {
                Error = Error + "The product name must be less than 50 characters : ";
            }
            if (StockQuantity.Length == 0)
            {
                Error = Error + "The quantity of products may not be blank : ";
            }
            if (StockQuantity.Length > 32)
            {
                Error = Error + "The quantity of products must be less than 32 characters : ";
            }
            if (UnitPrice.Length > 53)
            {
                Error = Error + "The unit price must be less than 53 characters : ";
            }
            if (UnitPrice.Length == 0)
            {
                Error = Error + "The unit price may not be blank : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateOfPurchase);
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
