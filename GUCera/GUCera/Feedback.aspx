<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="GUCera.Feedback" %>

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
            Feedbacks<br />
            <br />
            your_Comment<br />
            <br />
            <asp:TextBox ID="your_Comment" runat="server" Height="71px" TextMode="MultiLine" Width="218px"></asp:TextBox>
            <br />
            <br />
            Course_Id<br />
            <br />
            <asp:TextBox ID="Course_Id" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="post" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        </p>
    </form>
</body>
</html>
