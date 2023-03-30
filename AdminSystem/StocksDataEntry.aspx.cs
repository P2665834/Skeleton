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

        clsStock AStock = new clsStock();

        string ProductName = txtProductName.Text;
        string QuantityOfProducts = txtStockQuantity.Text;
        string UnitPrice = txtUnitPrice.Text;
        string DateOfPurchase = txtDateOfPurchase.Text;
        string Error = "";
        Error = AStock.Valid(ProductName, QuantityOfProducts, UnitPrice, DateOfPurchase);
        if (Error == "")
        {
            AStock.ProductName = ProductName;
            AStock.StockQuantity = Convert.ToInt32(UnitPrice);
            AStock.UnitPrice = (float)Convert.ToDouble(UnitPrice);
            AStock.DateOfPurchase = Convert.ToDateTime(DateOfPurchase);

            Session["AStock"] = AStock;
            Response.Write("StocksViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AStock = new clsSupplier();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AStock.Find(ProductID);
        if (Found == true)
        {
            txtProductName.Text = AStock.ProductName;
            txtStockQuantity.Text = AStock.QuantityOfProducts.ToString();
            txtUnitPrice.Text = AStock.UnitPrice.ToString();
            txtDateOfPurchase.Text = AStock.DatePurchased.ToString();
            chkAvailable.Checked = AStock.Available;

        }

    }
}