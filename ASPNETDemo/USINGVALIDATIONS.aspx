<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="USINGVALIDATIONS.aspx.cs" Inherits="ASPNETDemo.USINGVALIDATIONS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
            <asp:Label ID="Label1" runat="server" Text="Empno"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="empno cannot be blank" ControlToValidate="TextBox1" Font-Bold="True" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="Label2" runat="server" Text="Ename"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="empname cannot be blank" ControlToValidate="TextBox2" Font-Bold="True" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
            </td>

            </tr>
        <tr>
            
            <td>
                <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style9" TextMode="Password"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="confirm password"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox> 
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="passwords do not match" ControlToCompare="TextBox3" ControlToValidate="TextBox4" Font-Bold="True" ForeColor="Red" Display="None"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="salary"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="sal not in specified range" ControlToValidate="TextBox5" MaximumValue="200000" MinimumValue="10000" Type="Double" Font-Bold="True" ForeColor="Red" Display="None"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="sal cannot be blank" ControlToValidate="TextBox5" Display="None" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="pan card"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="pan not in correct format" ControlToValidate="TextBox6" Font-Bold="True" ForeColor="Red" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="DOB"></asp:Label>
                <asp:TextBox ID="txtdob" runat="server"></asp:TextBox>

                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Age must be 21 or above" ControlToValidate="txtdob" Display="None" Font-Bold="True" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>


            </td>
        </tr>

        

        <tr>
            <td><asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" /></td>
        </tr>
        
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="White" BorderColor="#3366FF" Font-Bold="True" ForeColor="Red" Width="370px" />




</asp:Content>
