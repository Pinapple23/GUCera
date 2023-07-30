<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="GUCera.AdminViewCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: large">
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Style="text-align: left" Text="Admin Panel"></asp:Label>
            <br />
            <br />
            View All Courses :
            <br />
            <asp:GridView ID="allCourses" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" Style="position: static" CellPadding="4" ForeColor="Black" CellSpacing="2">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            View
            Courses Not Accepted yet :
           
            <asp:GridView ID="notAccepted" runat="server" AutoGenerateSelectButton="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            Select a course from the table to accept :
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="AcceptCourse" Text="Accept Course" />
            <br />
            <asp:Label ID="errMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
        </div>
        <!-- promocode div --> 
        <div style ="background-color: #f7f7f7">
            <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Promo Codes : " style="text-align: left"></asp:Label>
            <br />
            <br />
            code :
        <asp:TextBox ID="Code" runat="server" style="margin-left: 31px"></asp:TextBox>
            <br />
            <br />
            discount :&nbsp;
        <asp:TextBox ID="Discount" runat="server"></asp:TextBox>
            <br />
            <br />
            <!-- reference https://www.guru99.com/handling-date-time-picker-using-selenium.html  -->
            Issue Date :
            <asp:TextBox ID="Issue" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <br />Expiry Date :
            <asp:TextBox ID="Expiry" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Create Promo Code" Width="276px" OnClick="addCode" />
            <br />
            <asp:Label ID="errMsg0" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
        </div>

        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Issue Promo Code : "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Current Promo code ID : "></asp:Label>
        <asp:TextBox ID="currCode" runat="server"></asp:TextBox>
        <br />
        <br />
       Student ID:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="stId" runat="server" style="margin-left: 86px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="issueCode" Text="issue code " Width="361px" />
        <br />
            <asp:Label ID="errMsg1" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
