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
        ASupplier.SupplierId = Convert.ToInt32(txtSupplierID.Text);
        ASupplier.SupplierName = Convert.ToString(txtSupplierName.Text);
        ASupplier.ProductName = Convert.ToString(txtProductName.Text);
        ASupplier.QuantityOfProducts = Convert.ToInt32(txtQuantityOfProducts.Text);
        ASupplier.UnitPrice = (float)Convert.ToDouble(txtUnitPrice.Text);
        ASupplier.DatePurchased = Convert.ToDateTime(txtDatePurchased.Text);
        ASupplier.Available = Convert.ToBoolean(chkAvailable.Checked);
        

        Session["ASupplier"] = ASupplier;
        Response.Redirect("SuppliersViewer.aspx");
    }








    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = ASupplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            txtProductName.Text = ASupplier.ProductName;
            txtQuantityOfProducts.Text = ASupplier.QuantityOfProducts.ToString();
            txtUnitPrice.Text = ASupplier.UnitPrice.ToString();
            txtDatePurchased.Text = ASupplier.DatePurchased.ToString();
            chkAvailable.Checked = ASupplier.Available;

        }

    }
}