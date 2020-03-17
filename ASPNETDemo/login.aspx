<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASPNETDemo.news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <script src="SCRIPTS/loginvalidations.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="border-spacing:50px;">
        <tr>
            <td>Username</td>
            <td>
                <asp:TextBox ID="txtusername" runat="server"  ClientIDMode="Static"></asp:TextBox></td>
            <td> </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelmsg" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#FF3300"></asp:Label></td>
        </tr>
        <tr>
            
            <td>
                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" OnClientClick="return validate();"   /></td>
        </tr>
    </table>






</asp:Content>
