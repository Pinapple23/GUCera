<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignments.aspx.cs" Inherits="GUCera.ViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">home</asp:LinkButton>
        </div>
        ViewAssignments<p>
            Course_Id</p>
        <p>
            <asp:TextBox ID="Course_Id" runat="server"></asp:TextBox>
        </p>
        
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="view" />
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="errMsg" runat="server"></asp:Label>
        <asp:GridView ID="showMeNow" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" EmptyDataText="this course currently has no assignments " OnSelectedIndexChanged="showMeNow_SelectedIndexChanged">
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
       
        <p>
            Select An Assignment from the table to submit </p>
        
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" Enabled="False" />
        
        <p>
            <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="Select Assignment from the table to view its grade :"></asp:Label>
        </p>
        <p>
            <asp:Label ID="errMsg2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="view grade " Enabled="False" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
