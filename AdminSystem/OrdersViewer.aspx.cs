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
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.CustomerName);
        Response.Write(AnOrder.ProductName);
        Response.Write(AnOrder.OrderID);
        Response.Write(AnOrder.OrderLineID);
        Response.Write(AnOrder.Price);
        Response.Write(AnOrder.Quantity);
        Response.Write(AnOrder.DateRecieved);
        Response.Write(AnOrder.Dispatched);

    }
}