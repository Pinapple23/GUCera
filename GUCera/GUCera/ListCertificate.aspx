<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCertificate.aspx.cs" Inherits="GUCera.ListCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">home</asp:LinkButton>
        </p>
        <p>
            view your Certificate</p>
        <p>
            Course_Id</p>
        <p>
            <asp:TextBox ID="Course_Id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Your Certificate" OnClick="Button1_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="CertificateNow" runat="server">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    </form>
</body>
</html>
