<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="GUCERA.CreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">home</asp:LinkButton>
            <br />
            Add CreditCard information</div>
        <p>
            Creditcard number :</p>
        <p>
            <asp:TextBox ID="ccNO" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Holder Name :</p>
        <p>
            <asp:TextBox ID="CHname" runat="server"></asp:TextBox>
        </p>
        <p>
            Expiry Date:</p>
        <p>
            <asp:TextBox ID="EXP" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        </p>
        <p>
            CVV:</p>
        <p>
            <asp:TextBox ID="CV" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="errMsg" runat="server"></asp:Label>
        </p>
    &nbsp;&nbsp;&nbsp;<asp:Button ID="add" runat="server" Text="ADD" OnClick="add_Click" Width="233px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
