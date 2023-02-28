<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StocksDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="110px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" width="188px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity" width="110px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" width="188px"></asp:TextBox>
        </p>
        <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price" width="110px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" width="188px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfPurchase" runat="server" Text="Date Of Purchase" width="110px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" width="188px"></asp:TextBox>
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
