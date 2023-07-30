<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessDenied.aspx.cs" Inherits="GUCera.AccessDenied" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="Access Denied !"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="you are either not logged in or trying to access a page you are not allowed to visit"></asp:Label>
    </form>
</body>
</html>
