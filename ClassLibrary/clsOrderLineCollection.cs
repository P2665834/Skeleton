using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderLineCollection

    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();

        public clsOrderLineCollection()
        {
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.ProductName = "Macbook Air";
            TestItem.Quantity = 1;
            TestItem.Dispatched = false;


            mOrderLineList.Add(TestItem);
            TestItem = new clsOrderLine();
            TestItem.OrderLineID = 2;
            TestItem.Quantity = 1;
            TestItem.Dispatched = true;
            TestItem.ProductName = "HP 15s-fq2024na";
            mOrderLineList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }





        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {

            }
        }
        public clsOrderLine ThisOrderLine { get; set; }
    }
}