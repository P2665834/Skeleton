using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrder.CustomerName = txtCustomerName.Text;
        AnOrderLine.ProductName = txtProductName.Text;
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        AnOrderLine.OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        AnOrder.Price = Convert.ToInt32(txtPrice.Text);
        AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnOrder.DateRecieved = Convert.ToDateTime(txtDateRecieved.Text);
        AnOrderLine.Dispatched = Convert.ToBoolean(chkDispatched.Checked);

        Session["AnOrder"] = AnOrder;
        Session["AnOrderLine"] = AnOrderLine;
        Response.Redirect("OrdersViewer.aspx");

    }
}