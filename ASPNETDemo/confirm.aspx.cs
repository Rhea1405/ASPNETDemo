using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class confirm : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());

            if (Session["e"] != null)
            {
                EMPDATA ED = (EMPDATA)Session["e"];
                lblempno.Text = ED.EMPNO.ToString();
                lblename.Text = ED.ENAME;
                lbljob.Text = ED.JOB;
                lblhd.Text = ED.HIREDATE.ToString();
                lblmgr.Text = ED.MGR.ToString();
                lblsal.Text = ED.SAL.ToString();
                lblcomm.Text = ED.COMM.ToString();
                lbldeptno.Text = ED.DEPTNO.ToString();


                Session.Remove("e");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            adp = new SqlDataAdapter("sp_insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(lblempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", lblename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", lbljob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(lblmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hiredate", DateTime.Parse(lblhd.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(lblsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse(lblcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(lbldeptno.Text));
            SqlParameter p = new SqlParameter("@res", SqlDbType.NVarChar, 50);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            //Label1.Text = p.Value.ToString();
           




        }
    }
}