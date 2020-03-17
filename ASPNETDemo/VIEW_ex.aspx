<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="VIEW_ex.aspx.cs" Inherits="ASPNETDemo.VIEW_ex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 106px;
        }
        .auto-style11 {
            width: 141px;
        }
        .auto-style12 {
            width: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  OnPageIndexChanging="GridView1_PageIndexChanging"  PageSize="1"></asp:GridView>

    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True" OnPageIndexChanging="DetailsView1_PageIndexChanging"></asp:DetailsView>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" OnPageIndexChanging="FormView1_PageIndexChanging">
        <ItemTemplate>
    <table class="auto-style9">
        <tr>
            <td class="auto-style10">OrderID</td>
            <td class="auto-style11">ORDERDESC</td>
            <td class="auto-style12">Total cost</td>
            <td>Discounted total</td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="l1" runat="server" Text='<%# Eval("orderid") %>'></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:Label ID="l2" runat="server" Text='<%# Eval("orderdesc") %>'></asp:Label>
            </td>
            <td class="auto-style12">
                <asp:Label ID="l3" runat="server" Text='<%# Eval("total") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="l4" runat="server" Text='<%# Eval("final") %>'></asp:Label>
            </td>
        </tr>
    </table>
            </ItemTemplate>
        </asp:FormView>









</asp:Content>
