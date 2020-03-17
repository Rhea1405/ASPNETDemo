<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNETDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/javascript">

        function Validate()
        {
            var empno = document.getElementById("txtempno").value;
           
            var empname = document.getElementById("txtempname").value;
            
            var job = document.getElementById("txtjob").value;
            
            var mgr = document.getElementById("txtmgrid").value;
           
            var hd = document.getElementById("txthiredate").value;
           
            var sal = document.getElementById("txtsal").value;
           
            var comm = document.getElementById("txtcomm").value;
            
            var dno = document.getElementById("txtdeptno").value;
            

            if (empno.length != 0 && empnanme.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
            {

               
                return true;
               
            }
            else
            {
                alert("please enter all details");
                return false;
            }


        }




    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 510px; height: 139px">
                <tr>
                    <td>Empno</td>
                    <td>
                        <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Empname</td>
                    <td>
                        <asp:TextBox ID="txtempname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Job</td>
                    <td>
                        <asp:TextBox ID="txtjob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manager id</td>
                    <td>
                        <asp:TextBox ID="txtmgrid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Hiredate</td>
                    <td>
                        <asp:TextBox ID="txthiredate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>sal</td>
                    <td>
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>comm</td>
                    <td>
                        <asp:TextBox ID="txtcomm" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>deptno</td>
                    <td>
                        <asp:TextBox ID="txtdeptno" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
           
        </div>
        <asp:Button ID="btnsubmit" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="btnsubmit_Click" />

    </form>
</body>
</html>
