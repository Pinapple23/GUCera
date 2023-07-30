<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstdefineAssignment.aspx.cs" Inherits="GUCera.EditCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 100px;
            width: 301px;
        }
        #Text2 {
            margin-left: 25px;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #E9EBEB">
<asp:Label ID="Label8" runat="server" Font-Size="XX-Large" Text="Instructor Panel"></asp:Label>
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
        <div style="text-align: left">
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="text-align: center" Text="Define Course Assignments"></asp:Label>
            <br />
            <br />
            Choose Course : <asp:DropDownList ID="CoursesList" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number : "></asp:Label>
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Type : "></asp:Label>
&nbsp;<asp:RadioButtonList ID="Type" runat="server" Height="17px" Width="291px" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">quiz</asp:ListItem>
                <asp:ListItem>exam</asp:ListItem>
                <asp:ListItem>project</asp:ListItem>
            </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Text="Full Grade :"></asp:Label>
            <asp:TextBox ID="Grade" runat="server" style="margin-left: 12px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Weight :"></asp:Label>
            <asp:TextBox ID="Weight" runat="server" style="margin-left: 40px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Deadline :"></asp:Label>
            <asp:TextBox ID="Deadline" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Content :"></asp:Label>
            <br />
            <asp:TextBox ID="Content" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Text="Apply" Width="279px" OnClick="Apply" />
            <br />
            <asp:Label ID="errMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
