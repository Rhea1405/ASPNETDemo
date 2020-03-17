using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class sessionex11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txtempno.Text);
            E.ENAME = txtename.Text;
            E.JOB = txtjob.Text;
            E.MGR = int.Parse(txtmgr.Text);
            E.HIREDATE = DateTime.Parse(txthiredate.Text);
            E.SAL = int.Parse(txtsal.Text);
            E.COMM = int.Parse(txtcomm.Text);
            E.DEPTNO = int.Parse(txtdeptno.Text);
            Session["e"] = E;
            Response.Redirect("confirm.aspx");



        }
    }
}