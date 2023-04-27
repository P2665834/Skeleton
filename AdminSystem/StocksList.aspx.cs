using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("StocksDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (lstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("StocksDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (lstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("SuppliersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByProductName(txtEnter.Text);
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByProductName("");
        txtEnter.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}