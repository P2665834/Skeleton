using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    
       Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerID);
        Customer.Delete();
        Response.Redirect("CustomersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerID);
        Customer.Delete();
        Response.Redirect("CustomersList.aspx");
    }
}