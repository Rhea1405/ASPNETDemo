<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ex1.aspx.cs" Inherits="ASPNETDemo.ex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="96px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="105px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
