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
        clsSupplier ASupplier = new clsSupplier();
        ASupplier = (clsSupplier)Session["ASupplier"];
        Response.Write(ASupplier.ProductName);
        Response.Write(ASupplier.SupplierId);
        Response.Write(ASupplier.QuantityOfProducts);
        Response.Write(ASupplier.DatePurchased);
        Response.Write(ASupplier.UnitPrice);
        Response.Write(ASupplier.Available);


    }
}