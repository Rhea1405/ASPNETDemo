<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session-applicationex1.aspx.cs" Inherits="ASPNETDemo.session_applicationex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="session"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="application"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br/><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


        </div>
    </form>
</body>
</html>
