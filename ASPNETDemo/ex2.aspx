<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="ex2.aspx.cs" Inherits="ASPNETDemo.ex2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Enter the Deptno:<asp:DropDownList ID="ddlDeptno" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlDeptno_SelectedIndexChanged">
        <asp:ListItem Value="-1">Select</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView runat="server" ID="gvdata"></asp:GridView>
        <asp:Button runat="server" Text="extract" OnClick="Unnamed1_Click" />
    </h2>


</asp:Content>
