using System;

namespace ClassLibrary
{
    public class clsSupplier
    {

        private Int32 mSupplierID;
        private String mSupplierName;
        private String mProductName;
        private Int32 mQuantityOfProducts;
        private float mUnitPrice;
        private DateTime mDatePurchased;
        private Boolean mAvailable;


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
        public String SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
       
        

        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mQuantityOfProducts = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityOfProducts"]);
                mUnitPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["UnitPrice"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
               


                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string SupplierName, string ProductName, string QuantityOfProducts, string UnitPrice, string DatePurchased)
        {
            String Error = "";
            DateTime DateTemp;
            if (SupplierName.Length == 0)
            {
                Error = Error + "The Supplier Name may not be blank : ";
            }
            if (SupplierName.Length > 50)
            {
                Error = Error + "The supplier name must be less than 50 characters : ";
            }
            if (ProductName.Length == 0)
            {
                Error = Error + "The product name may not be blank : ";
            }
            if (ProductName.Length > 50)
            {
                Error = Error + "The product name must be less than 50 characters : ";
            }
            if (QuantityOfProducts.Length == 0)
            {
                Error = Error + "The quantity of products may not be blank : ";
            }
            if (QuantityOfProducts.Length > 32)
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
                DateTemp = Convert.ToDateTime(DatePurchased);
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