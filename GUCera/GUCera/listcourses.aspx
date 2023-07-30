<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listcourses.aspx.cs" Inherits="GUCERA.listcourses" %>

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
            <asp:DropDownList ID="courseList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="courseList_SelectedIndexChanged">
                <asp:ListItem Text="Choose a course" Selected="true" ></asp:ListItem>
            </asp:DropDownList>
            <br />
        <asp:GridView ID="courseInfo" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="62px" Width="260px" AutoGenerateSelectButton="True">
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
            <asp:Label ID="errMsg" runat="server"></asp:Label>
            <br />
        </div>
        <asp:Button ID="button1" runat="server" OnClick="Enroll" Text="Enroll" Width="242px" />
        <br />
        <br />
    </form>
</body>
</html>
