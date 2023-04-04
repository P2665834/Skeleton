using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection


    {
        List<clsStock> mStockList = new List<clsStock>();

        public clsStockCollection()
        {
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "15s - fq2024na";
            TestItem.StockQuantity = 25;
            TestItem.UnitPrice = 200;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;

            mStockList.Add(TestItem);
            TestItem = new clsStock();
            TestItem.ProductID = 2;
            TestItem.ProductName = "Asus Chromebook CM14";
            TestItem.StockQuantity = 29;
            TestItem.UnitPrice = 300;
            TestItem.DateOfPurchase = DateTime.Now.Date;
            TestItem.Available = true;
            mStockList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.UnitPrice = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["UnitPrice"]);
                AStock.DateOfPurchase = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mStockList.Add(AStock);
                Index++;
            }
        }





        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock { get; set; }
    }
}