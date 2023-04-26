using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();

        string OrderLineID = txtOrderLineID.Text;
        string CustomerName = txtCustomerName.Text;
        string ProductName = txtProductName.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string DateRecieved = txtDateRecieved.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomerName, Price, DateRecieved);
        Error = AnOrderLine.Valid(OrderLineID, ProductName, Quantity);
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.CustomerName = CustomerName;
            AnOrder.Price = (float)Convert.ToDouble(Price);
            AnOrder.DateRecieved = Convert.ToDateTime(DateRecieved);
            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrdersDataEntry.aspx");
        }

        else
        {
            lblError.Text = Error;
        }





    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            txtOrderLineID.Text = AnOrderLine.OrderLineID.ToString();
            txtCustomerName.Text = AnOrder.CustomerName;
            txtProductName.Text = AnOrderLine.ProductName;
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
            txtPrice.Text = AnOrder.Price.ToString();
            txtDateRecieved.Text = AnOrder.DateRecieved.ToString();
            chkDispatched.Checked = AnOrderLine.Dispatched;

        }

    }

}