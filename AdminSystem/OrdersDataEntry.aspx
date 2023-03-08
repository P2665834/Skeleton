<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %> 

 

<!DOCTYPE html> 

 

<html xmlns="http://www.w3.org/1999/xhtml"> 

<head runat="server"> 

    <title></title> 

</head> 

<body> 

    This is the order entry page 

    <form id="form1" runat="server"> 

        <div> 

        </div> 

        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label> 

        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox> 

        <p> 

            <asp:Label ID="lblOrderLineID" runat="server" Text="Order Line ID" width="144px"></asp:Label> 

            <asp:TextBox ID="txtOrderLineID" runat="server" width="308px"></asp:TextBox> 

        </p> 

        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="144px"></asp:Label> 

        <asp:TextBox ID="txtCustomerName" runat="server" width="308px"></asp:TextBox> 

        <p> 

            <asp:Label ID="lblProductID" runat="server" Text="Product Name" width="144px"></asp:Label> 

            <asp:TextBox ID="txtProductName" runat="server" width="308px"></asp:TextBox> 

        </p> 

        <asp:Label ID="lblPrice" runat="server" Text="Price" width="144px"></asp:Label> 

        <asp:TextBox ID="txtPrice" runat="server" width="308px"></asp:TextBox> 

        <p> 

            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="144px"></asp:Label> 

            <asp:TextBox ID="txtQuantity" runat="server" width="308px"></asp:TextBox> 

        </p> 

        <asp:Label ID="lblDateRecieved" runat="server" Text="Date Recieved" width="144px"></asp:Label> 

        <asp:TextBox ID="txtDateRecieved" runat="server" width="308px"></asp:TextBox> 

        <p> 

            <asp:CheckBox ID="chkDispatched" runat="server" Text="Disptached" /> 

        </p> 

        <p> 

            <asp:Label ID="lblError" runat="server"></asp:Label> 

        </p> 

        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" /> 

        <asp:Button ID="btncancel" runat="server" Text="Cancel" /> 

    </form> 

</body> 

</html>