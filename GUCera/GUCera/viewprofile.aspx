
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewprofile.aspx.cs" Inherits="GUCERA.viewprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Profile</div>
        <p>
            &nbsp;First name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="FNAME" runat="server"></asp:Label>
        </p>
        <p>
            Last name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LNAME" runat="server"></asp:Label>
        </p>
        <p>
            Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="EMAIL" runat="server"></asp:Label>
        </p>
        <p>
            Address :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ADDRESS" runat="server"></asp:Label>
        </p>
        <p>
            Gender :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="gender" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="pass" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/promocodes.aspx">view promocodes</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/listcourses.aspx">courses</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/CreditCard.aspx">credit cards</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ViewAssignments.aspx">assignments</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/ListCertificate.aspx">certificates</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Feedback.aspx">feedback</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Phones.aspx">add phone number</asp:HyperLink>
    </form>
</body>
</html>
