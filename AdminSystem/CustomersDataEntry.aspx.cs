using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsCustomer ACustomer = new clsCustomer();
        
       
        string Name = txtName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string Address = txtAddress.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string DateofBirth = txtDateofBirth.Text;
        string Error = "";
        Error = ACustomer.Valid( Name, EmailAddress, PhoneNumber, Address, DateofBirth);
        if (Error == "")
        {
            ACustomer.CustomerID = Convert.ToInt32(CustomerID);
            ACustomer.Name = Name;
            ACustomer.PhoneNumber = Convert.ToInt32(PhoneNumber);
            ACustomer.EmailAddress = EmailAddress;
            ACustomer.Address = Address;
            ACustomer.DateofBirth = Convert.ToDateTime(DateofBirth);
            ACustomer.SignUp = chkSignUp.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomersDataEntry.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if (Found == true)
        {
           
            txtName.Text = ACustomer.Name;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            txtDateofBirth.Text = ACustomer.DateofBirth.ToString();
            txtPhoneNumber.Text = ACustomer.PhoneNumber.ToString();
            txtAddress.Text = ACustomer.Address;
            chkSignUp.Checked = ACustomer.SignUp;

        }

    }
}