using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection


    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
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
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@UnitPrice", mThisStock.UnitPrice);
            DB.AddParameter("@DateOfPurchase", mThisStock.DateOfPurchase);
            DB.AddParameter("@Available", mThisStock.Available);
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@UnitPrice", mThisStock.UnitPrice);
            DB.AddParameter("@DateOfPurchase", mThisStock.DateOfPurchase);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblStock_FilterByProductName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
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

    }
}