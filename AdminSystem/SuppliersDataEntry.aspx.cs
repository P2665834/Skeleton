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
        ASupplier.SupplierId = Convert.ToInt32(txtSupplierID.Text);
        ASupplier.DatePurchased = Convert.ToDateTime(txtDatePurchased.Text);
        ASupplier.QuantityOfProducts = Convert.ToInt32(txtQuantityOfProducts.Text);
        ASupplier.UnitPrice = (float)Convert.ToDouble(txtUnitPrice.Text);
        ASupplier.Available = Convert.ToBoolean(chkAvailable.Checked);

        Session["ASupplier"] = ASupplier;
        Response.Redirect("SuppliersViewer.aspx");
    }
}