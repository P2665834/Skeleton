using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection

    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.Price = 1300;
            TestItem.DateRecieved = DateTime.Now.Date;
            

            mOrderList.Add(TestItem);
            TestItem = new clsOrder();
            TestItem.OrderID = 2;
            TestItem.CustomerName = "Elias Barton";
            TestItem.Price = 250;
            TestItem.DateRecieved = DateTime.Now.Date;
            mOrderList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.DateRecieved = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRecieved"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.Price = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }





        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder { get; set; }
    }
}