<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="radiobtn.aspx.cs" Inherits="ASPNETDemo.radiobtn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <table class="auto-style11">
    <tr>
        <td class="auto-style10">
        <asp:RadioButton ID="rdbdoj" Text="Joining date" runat="server" GroupName="g1" OnCheckedChanged="rdbjob_CheckedChanged" AutoPostBack="True" />
        </td>
        <td class="auto-style10">
            <asp:TextBox ID="txtstart" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtend" runat="server" TextMode="Date"></asp:TextBox>
        </td></tr>
    <tr><td class="auto-style9">
        <asp:RadioButton ID="rdbdeptno" Text="Dept no" runat="server" GroupName="g1" AutoPostBack="True" OnCheckedChanged="rdbdeptno_CheckedChanged" />
        </td><td class="auto-style9">
            <asp:DropDownList ID="ddldeptno" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">Select</asp:ListItem>
            </asp:DropDownList>
        </td></tr>
            <tr> 
                <td>
                    <asp:Button ID="btn" runat="server" Text="extract" OnClick="btn_Click" />
                </td>
            </tr>
             <asp:GridView runat="server" ID="gvdata"></asp:GridView>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>


</table>  
        


</asp:Content>
