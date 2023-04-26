using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection

    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public clsSupplierCollection()
        {
           
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
            
        }





        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductName", mThisSupplier.ProductName);
            DB.AddParameter("@QuantityOfProducts", mThisSupplier.QuantityOfProducts);
            DB.AddParameter("@UnitPrice", mThisSupplier.UnitPrice);
            DB.AddParameter("@DatePurchased", mThisSupplier.DatePurchased);
            DB.AddParameter("@Available", mThisSupplier.Available);
            return DB.Execute("sproc_tblSupplier_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductName", mThisSupplier.ProductName);
            DB.AddParameter("@QuantityOfProducts", mThisSupplier.QuantityOfProducts);
            DB.AddParameter("@UnitPrice", mThisSupplier.UnitPrice);
            DB.AddParameter("@DatePurchased", mThisSupplier.DatePurchased);
            DB.AddParameter("@Available", mThisSupplier.Available);
            DB.Execute("sproc_tblSupplier_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierId);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblSupplier_FilterByProductName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                ASupplier.QuantityOfProducts = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityOfProducts"]);
                ASupplier.UnitPrice = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["UnitPrice"]);
                ASupplier.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                ASupplier.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mSupplierList.Add(ASupplier);
                Index++;
            }
        }
    }
}