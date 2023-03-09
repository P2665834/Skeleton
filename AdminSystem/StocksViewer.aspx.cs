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
        clsStock AStock = new clsStock();
        AStock = (clsStock)Session["AStock"];
        Response.Write(AStock.ProductName);
        Response.Write(AStock.StockId);
        Response.Write(AStock.StockQuantity);
        Response.Write(AStock.DateOfPurchase);
        Response.Write(AStock.UnitPrice);
        Response.Write(AStock.Available);
    }
}