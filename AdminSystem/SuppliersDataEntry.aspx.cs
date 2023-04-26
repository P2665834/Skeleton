using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;
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
            ASupplier.SupplierId = Convert.ToInt32(SupplierId);
            ASupplier.SupplierName = SupplierName;
            ASupplier.ProductName = ProductName;
            ASupplier.QuantityOfProducts = Convert.ToInt32(QuantityOfProducts);
            ASupplier.UnitPrice = (float)Convert.ToDouble(UnitPrice);
            ASupplier.DatePurchased = Convert.ToDateTime(DatePurchased);
            ASupplier.Available = chkAvailable.Checked;
            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplierId == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }
            Response.Redirect("SuppliersDataEntry.aspx");
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