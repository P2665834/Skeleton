<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="txtEmployee" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblEmployeePosition" runat="server" Text="Employee Position"></asp:Label>
            <asp:TextBox ID="txtEmployeePosition" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="110px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" width="190px"></asp:TextBox>
        </p>
        <p>
         <asp:Label ID="lblDateOfEmployment" runat="server" Text="Date Hired" width="110px"></asp:Label>
         <asp:TextBox ID="txtDateOfEmployment" runat="server" width="190px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="110px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" width="190px"></asp:TextBox>
        <p>
            
        </p>
        <asp:CheckBox ID="chkCurrentlyWorking" runat="server" Text="Currently Working" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>