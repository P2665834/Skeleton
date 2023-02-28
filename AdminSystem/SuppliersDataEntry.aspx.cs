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
        clsSupplier ASupplier = new clsSupplier();
        ASupplier.ProductName = txtProductName.Text;
        Session["ASupplier"] = ASupplier;
        Response.Redirect("SuppliersViewer.aspx");
    }
}