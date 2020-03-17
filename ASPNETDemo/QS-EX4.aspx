<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QS-EX4.aspx.cs" Inherits="ASPNETDemo.QS_EX4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script>
        function func1()
        {
            window.open('QS-ex5.aspx?a=10&b=20');
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="func1();" />
        </div>
    </form>
</body>
</html>
