<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promocodes.aspx.cs" Inherits="GUCERA.promocodes" %>

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
            Promocodes :<asp:Label ID="errMsg" runat="server" Visible="False" ForeColor="Red"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
