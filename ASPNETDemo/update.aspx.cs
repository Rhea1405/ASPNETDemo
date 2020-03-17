using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASPNETDemo
{
    public partial class update : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updateemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@job", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(txtmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(txtsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse(txtcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(txtdeptno.Text));

            SqlParameter p = new SqlParameter("@res", SqlDbType.NVarChar, 50);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            label.Text = p.Value.ToString();
            txtempno.Text = "";
            txtename.Text = "";
            txtjob.Text = "";
            txtmgr.Text = "";
            txthiredate.Text = "";
            txtsal.Text = "";
            txtcomm.Text = "";
            txtdeptno.Text = "";
            txtempno.Focus();



        }
    }
}