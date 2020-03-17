<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="ASPNETDemo.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="SCRIPTS/insertvalidation.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border-spacing:30px">
        <tr>
        <td>
            EMP NO
        </td>
        <td>
            <asp:TextBox ID="txtempno" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
        <tr>
            <td>EMP NAME</td>
            <td>
                <asp:TextBox ID="txtename" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>JOB</td>
            <td>
                <asp:TextBox ID="txtjob" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>MGR</td>
            <td>
                <asp:TextBox ID="txtmgr" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>HIREDATE</td>
            <td>
                <asp:TextBox ID="txthiredate" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>SAL</td>
            <td>
                <asp:TextBox ID="txtsal" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>COMM</td>
            <td>
                <asp:TextBox ID="txtcomm" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>DEPTNO</td>
            <td>
                <asp:TextBox ID="txtdeptno" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" OnClientClick="return ivalidate();" BackColor="White" BorderColor="Black" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" ForeColor="Black"/></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF3300" ></asp:Label></td>
        </tr>
        
    </table>






</asp:Content>
