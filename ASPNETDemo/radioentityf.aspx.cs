using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class radioentityf : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();

            if (!IsPostBack)
            {
                txtend.Enabled = false;
                txtstart.Enabled = false;
                ddldeptno.Enabled = false;
            }
            if (!IsPostBack)
            {
                var E = from E1 in D.DEPTDATAs
                        select E1;
               
                ddldeptno.DataValueField = "Deptno";
                ddldeptno.DataTextField = "Dname";
                ddldeptno.DataSource = E.ToList();
                DataBind();
                



            }
        }

        protected void rdbjob_CheckedChanged(object sender, EventArgs e)
        {

            if(rdbdoj.Checked)
            {

                txtstart.Enabled = true;
                txtend.Enabled = true;
                ddldeptno.Enabled = false;






            }




        }

        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbdeptno.Checked)
            {
               
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = true;
            }



        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if(rdbdoj.Checked)
            {
                
                    DateTime st = DateTime.Parse(txtstart.Text);
                    DateTime end = DateTime.Parse(txtend.Text);
                    var E = from E1 in D.EMPDATAs
                            where E1.HIREDATE >= st && E1.HIREDATE < end
                            select E1;

                    List<EMPDATA> lemp = E.ToList();
                    gvdata.DataSource = lemp;
                    gvdata.DataBind();
                if(gvdata.Rows.Count==0)
                {
                    Label1.Text = "no data found";
                }

                
               
            }
            else
            {
                int dno = int.Parse(ddldeptno.SelectedValue);
                var E = from e1 in D.EMPDATAs
                        where e1.DEPTNO == dno
                        select e1;
                List<EMPDATA> lemp = E.ToList();
                gvdata.DataSource = lemp;
                gvdata.DataBind();
                if (gvdata.Rows.Count == 0)
                {
                    Label1.Text = "no data found";
                }




            }




        }
    }
}