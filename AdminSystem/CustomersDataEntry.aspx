<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="CustomerDataEntry" %>
<!DOCTYPE html>
<script runat="server">

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            z-index: 1;
            left: 78px;
            top: 53px;
            position: absolute;
        }
    </style>
</head>
<body style="height: 761px; width: 923px">
    <form id="Form1" runat="server">
        <div>
        </div>
        <asp:Label ID="txtCustomerEntry" runat="server" BorderColor="Black" BorderStyle="Dashed" Font-Bold="True" Font-Size="Large" ForeColor="#003366" style="z-index: 1; left: 39px; top: 37px; position: absolute; height: 26px; width: 342px" Text="Customer Details Entry" BorderWidth="4px"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 34px; top: 106px; position: absolute; height: 31px; width: 131px" Text="CustomerID" Font-Overline="False" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 164px; top: 103px; position: absolute; height: 26px" Font-Size="Medium" width="191px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 34px; top: 154px; position: absolute; height: 31px; width: 131px" Text="Name" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 161px; top: 152px; position: absolute; height: 26px; width: 191px;" Font-Size="Medium"></asp:TextBox>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 30px; top: 204px; position: absolute; height: 31px; width: 131px;" Text="Email Address" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 162px; top: 201px; position: absolute; height: 26px; width: 191px;" Font-Size="Medium"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 32px; top: 314px; position: absolute" Text="Phone Number" Font-Size="Medium" height="31px" width="131px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 155px; top: 309px; position: absolute" TextMode="Phone" Font-Size="Medium" height="26px" width="191px"></asp:TextBox>
        <asp:Label ID="lblDateofBirth" runat="server" style="z-index: 1; left: 34px; top: 259px; position: absolute; height: 31px; width: 131px" Text="Date of Birth" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="txtDateofBirth" runat="server" style="z-index: 1; left: 157px; top: 254px; position: absolute" Font-Size="Medium" height="26px" width="191px"></asp:TextBox>
        <asp:CheckBox ID="chkSignUp" runat="server" style="z-index: 1; left: 27px; top: 427px; position: absolute; height: 23px; width: 145px; right: 622px;" Text="SignUp" TextAlign="Left" Font-Size="Medium" OnCheckedChanged="chkActive_CheckedChanged" />
        <asp:Button ID="btnOK" runat="server" BorderColor="#003366" BorderStyle="Solid" BorderWidth="4px" ForeColor="#003366" OnClick="btnOK_Click" style="z-index: 1; left: 398px; top: 164px; position: absolute; height: 47px; width: 83px" Text="OK" Font-Size="Medium" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 33px; top: 364px; position: absolute; height: 31px; width: 131px;" Text="Address" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 156px; top: 364px; position: absolute; height: 26px; width: 191px;" Font-Size="Medium"></asp:TextBox>
       
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 400px; top: 111px; position: absolute; height: 39px; width: 79px" Text="FInd" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" BorderColor="#003366" BorderWidth="4px" style="z-index: 1; left: 398px; top: 224px; position: absolute; height: 47px; width: 83px;" Text="Cancel" Font-Size="Medium" OnClick="btnCancel_Click" />
       
</form>
</body>
</html>
