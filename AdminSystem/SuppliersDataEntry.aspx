<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="110px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" width="188px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblQuantityOfProducts" runat="server" Text="Quantity Of Products" width="110px"></asp:Label>
            <asp:TextBox ID="txtQuantityOfProducts" runat="server" width="188px"></asp:TextBox>
        </p>
        <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price" width="110px"></asp:Label>
        <asp:TextBox ID="txtUnitPrice" runat="server" width="188px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDatePurchased" runat="server" Text="Date Purchased" width="110px"></asp:Label>
            <asp:TextBox ID="txtDatePurchased" runat="server" width="188px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
