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

        string SupplierName = txtSupplierName.Text;
        string ProductName = txtProductName.Text;
        string QuantityOfProducts = txtQuantityOfProducts.Text;
        string UnitPrice = txtUnitPrice.Text;
        string DatePurchased = txtDatePurchased.Text;
        string Error = "";
        Error = ASupplier.Valid(SupplierName, ProductName, QuantityOfProducts, UnitPrice, DatePurchased);
        if (Error == "")
        {
            ASupplier.SupplierName = SupplierName;
            ASupplier.ProductName = ProductName;
            ASupplier.QuantityOfProducts = Convert.ToInt32(UnitPrice);
            ASupplier.UnitPrice = (float)Convert.ToDouble(UnitPrice);
            ASupplier.DatePurchased = Convert.ToDateTime(DatePurchased);

            Session["ASupplier"] = ASupplier;
            Response.Write("SuppliersViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
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