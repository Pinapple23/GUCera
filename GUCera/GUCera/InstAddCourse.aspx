<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstAddCourse.aspx.cs" Inherits="GUCera.AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
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
        <div class="auto-style1">
            <br />
            <br />
            <span class="auto-style2">Add New Courses</span><br class="auto-style2" />
            <br />
            Course Details :
            <br />
            <br />
            Credit Hours :
            <asp:TextBox ID="hours" runat="server" style="margin-left: 8px"></asp:TextBox>
            <br />
            <br />
            Name :
            <asp:TextBox ID="courseName" runat="server" style="margin-left: 62px"></asp:TextBox>
            <br />
            <br />
            Price&nbsp; :
            <asp:TextBox ID="coursePrice" runat="server" style="margin-left: 61px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="addCourse" Text="Add Course" Width="288px" />
            <br />
            <br />
            <asp:Label ID="errMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
