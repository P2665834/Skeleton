using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["EmployeeID"]);
        if (IsPostBack == false)
        {
            if (EmployeeID != -1)
            {
                DisplayStaff();
            }
        }

    }

    void DisplayStaff()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstEmployeeList.DataSource = Employees.StaffList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "EmployeeFullName";
        lstEmployeeList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session[""] = -1;
        Response.Redirect("StaffssDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;
        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("StaffsDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;
        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("StaffsConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportByProductName(txtEnter.Text);
        lstEmployeeList.DataSource = Employees.StaffList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "EmployeeFullName";
        lstEmployeeList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Suppliers = new clsStaffCollection();
        Suppliers.ReportByProductName("");
        txtEnter.Text = "";
        lstEmployeeList.DataSource = Suppliers.SupplierList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "EmployeeFullName";
        lstEmployeeList.DataBind();
    }
}
