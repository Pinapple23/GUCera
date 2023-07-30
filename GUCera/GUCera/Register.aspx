<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GUCera.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: xx-large">
            Register <br />
            <br />
        </div>
        <div class="auto-style1">
        I am :
&nbsp;<asp:DropDownList ID="userType" runat="server" Height="19px">
            <asp:ListItem>Instructor</asp:ListItem>
            <asp:ListItem>Student</asp:ListItem>
        </asp:DropDownList>
            <br />
        <br />
        first name :
        <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
            <br />
        <br />
        Last name :<asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            <br />
        <br />
        Password :
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
        <br />
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Email" runat="server" style="margin-left: 5px"></asp:TextBox>
            <br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
        <br />
        Gender :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem Value="true">male</asp:ListItem>
                <asp:ListItem Value="false">female</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="RegisterUser" Text="Register" Width="271px" />
            <br />
            <br />
            <asp:Label ID="errorMsg" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            </div>
    </form>
    </body>
</html>