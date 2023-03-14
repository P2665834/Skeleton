using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.CustomerName);
        Response.Write(AnOrderLine.ProductName);
        Response.Write(AnOrder.OrderID);
        Response.Write(AnOrderLine.OrderLineID);
        Response.Write(AnOrder.Price);
        Response.Write(AnOrderLine.Quantity);
        Response.Write(AnOrder.DateRecieved);
        Response.Write(AnOrderLine.Dispatched);

    }
}