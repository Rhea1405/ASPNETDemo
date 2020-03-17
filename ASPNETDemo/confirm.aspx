<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="ASPNETDemo.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style9 {
        width: 139px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style9">
        <tr>
            <td>Empno</td>
           <td> <asp:Label ID="lblempno" runat="server" Text="Label"></asp:Label></td>
        </tr>



        <tr>
            <td>Ename</td>
           <td> <asp:Label ID="lblename" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td>Job</td>
           <td> <asp:Label ID="lbljob" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td>MGR</td>
           <td> <asp:Label ID="lblmgr" runat="server" Text="Label"></asp:Label></td>
        </tr>
          <tr>
            <td>HireDate</td>
           <td> <asp:Label ID="lblhd" runat="server" Text="Label"></asp:Label></td>
        </tr>
          <tr>
            <td>Sal</td>
           <td> <asp:Label ID="lblsal" runat="server" Text="Label"></asp:Label></td>
        </tr>
          <tr>
            <td>Comm</td>
           <td> <asp:Label ID="lblcomm" runat="server" Text="Label"></asp:Label></td>
        </tr>
          <tr>
            <td>Deptno</td>
           <td> <asp:Label ID="lbldeptno" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
            <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
                </td>
        </tr>

    </table>




</asp:Content>
