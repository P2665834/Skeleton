using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection


    { 
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        public clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "hp";
            TestItem.ProductName = "15s - fq2024na";
            TestItem.QuantityOfProducts = 25;
            TestItem.UnitPrice = 200;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;

            mSupplierList.Add(TestItem);
            TestItem = new clsSupplier();
            TestItem.SupplierId = 2;
            TestItem.SupplierName = "Asus";
            TestItem.ProductName = "Chromebook CM14";
            TestItem.QuantityOfProducts = 30;
            TestItem.UnitPrice = 225;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.Available = true;
            mSupplierList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
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
        public clsSupplier ThisSupplier { get; set; }
    }
}