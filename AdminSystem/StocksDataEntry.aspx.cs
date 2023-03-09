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
        AStock.ProductName = txtProductName.Text;
        AStock.StockId = Convert.ToInt32(txtStockID.Text);
        AStock.DateOfPurchase = Convert.ToDateTime(txtDateOfPurchase.Text);
        AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        AStock.UnitPrice = (float)Convert.ToDouble(txtUnitPrice.Text);
        AStock.Available = Convert.ToBoolean(chkAvailable.Checked);

        Session["AStock"] = AStock;
        Response.Redirect("StocksViewer.aspx");
    }
}