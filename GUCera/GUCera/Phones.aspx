<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phones.aspx.cs" Inherits="GUCera.Phones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="add_number" Text="add number" />
        </div>
    <p style="text-align: center">
        <asp:Label ID="errorMsg" runat="server" ForeColor="#CC0000" Text="errorMsg" Visible="False"></asp:Label>
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">home</asp:LinkButton>
        </p>
    </form>
    </body>
</html>
