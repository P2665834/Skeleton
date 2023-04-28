using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff aMemberOfStaff = new clsStaff();

        string EmployeeFullName = txtEmployeeFullName.Text;
        string EmployeePosition = txtEmployeePositionName.Text;
        string DateOfEmployment = txtDateOfEmployment.Text;
        string Salary = txtSalary.Text;
        string Error = "";
        Error = aMemberOfStaff.Valid(EmployeeFullName, EmployeePosition, DateOfEmployment, Salary);
        if (Error == "")
        {
            aMemberOfStaff.EmployeeID = Convert.ToInt32(SupplierId);
            aMemberOfStaff.EmployeeFullName = EmployeeFullName;
            aMemberOfStaff.EmployeePositionName = EmployeePositionName;
            aMemberOfStaff.DateOfEmployment = Convert.ToDateTime(DateOfEmployment);
            aMemberOfStaff.Salary = (float)Convert.ToDouble(Salary);
            aMemberOfStaff.CurrentlyWorking = chkCurrentlyWorking.Checked;
            clsStaffCollection EmployeeList = new clsStaffCollection();

            if (EmployeeID == -1)
            {
                EmployeeList.ThisEmployee= aMemberOfStaff;
                EmployeeList.Add();
            }
            else
            {
                EmployeeList.ThisEmployee.Find(EmployeeID);
                EmployeeList.ThisEmployee = aMemberOfStaff;
                EmployeeList.Update();
            }
            Response.Redirect("StaffsDataEntry.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff aMemberOfStaff = new clsStaff();
        Int32 EmployeeID;
        Boolean Found = false;
        EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
        Found = aMemberOfStaff.Find(EmployeeID);
        if (Found == true)
        {
            txtEmployeeFullName.Text = aMemberOfStaff.EmployeeFullName;
            txtEmployeePosition.Text = aMemberOfStaff.EmployeePosition;
            txtDateOfEmployment.Text = aMemberOfStaff.DateOfEmployment.ToString();
            txtSalary.Text = aMemberOfStaff.Salary.ToString();
            chkCurrentlyWorking.Checked = aMemberOfStaff.CurrentlyWorking;

        }

    }
}