<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueCertificate.aspx.cs" Inherits="GUCera.IssueCertificate" %>

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
        <div style="text-align: center">
            
            <br />
            <br />
            
            <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" Text="Issue certificates :"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Course id :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Student id :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sId" runat="server"></asp:TextBox>
            <br />
            <br />
            issue date :
            <asp:TextBox ID="issDate" runat="server" TextMode="DateTimeLocal" style="margin-left: 46px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Apply" OnClick="Button2_Click" Width="309px" />
            <br />
            <asp:Label ID="errMsg" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
