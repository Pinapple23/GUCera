<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstViewFeedback.aspx.cs" Inherits="GUCera.InstViewFeedback" %>

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
            <asp:Label ID="Label6" runat="server" Text="Select a course : " Font-Size="Larger"></asp:Label>
            <br />
            <asp:DropDownList ID="CourseList" runat="server" OnSelectedIndexChanged="courseSelect" AutoPostBack="True" Height="16px" Width="155px">
            </asp:DropDownList>
            </div>
        <div>
            <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="View Course Feedbacks : "></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Select a course from the drop down to view its feedbacks : "></asp:Label>
            <br />
            <br />
            <asp:GridView ID="studentFeedback" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" EmptyDataText="this course currently have no feedbacks">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
