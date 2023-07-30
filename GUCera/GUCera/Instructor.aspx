<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="GUCera.Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>

    <form id="form1" runat="server">


        <div style="text-align: center; background-color: #E9EBEB">
<asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Instructor Panel"></asp:Label>
            <br />
        </div>
        
        <div style="text-align: center; background-color: #E9EBEB">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/InstAddCourse.aspx">Add Courses</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/InstdefineAssignment.aspx">Define Assignments</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/InstViewAssignments.aspx">View &amp; Grade Assignments</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/InstViewFeedback.aspx">Courses Feedback</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/IssueCertificate.aspx">Issue Certificates</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Phones.aspx">add phone number</asp:HyperLink>
        
            &nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        
        <br />
        <br />
        
    </form>
</body>
</html>
