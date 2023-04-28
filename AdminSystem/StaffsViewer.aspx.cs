using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff aMemberOfStaff = new clsStaff();
        aMemberOfStaff = (clsSupplier)Session["aMemberOfStaff"];
        Response.Write(aMemberOfStaff.EmployeeID);
        Response.Write(aMemberOfStaff.EmployeeFullName);
        Response.Write(aMemberOfStaff.EmployeePosition);
        Response.Write(aMemberOfStaff.DateOfEmployment);
        Response.Write(aMemberOfStaff.Salary);
        Response.Write(aMemberOfStaff.CurrentlyWorking);


    }
}