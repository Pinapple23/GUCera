<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p style="font-size: xx-large">
            Log In
        </p>
        <p>
            User id :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </p>
        <p>
            Password :
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="errMsg" runat="server" Visible="False" ForeColor="Red"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="login" Text="Log In" style="text-align: center" Height="29px" Width="112px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="30px" OnClick="Button2_Click" Text="Register" Width="107px" />
    </form>
</body>
</html>
