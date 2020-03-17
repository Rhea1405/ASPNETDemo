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
    public partial class ex2 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            adp = new SqlDataAdapter("sp_extractemp", con);
            if (!IsPostBack)
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "d");

                ddlDeptno.DataSource = ds.Tables["d"];
                ddlDeptno.DataTextField = "Dname";
                ddlDeptno.DataValueField = "Deptno";
                ddlDeptno.DataBind();
            }




        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //adp = new SqlDataAdapter("sp_getdeptdetails", con);
            //adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adp.SelectCommand.Parameters.AddWithValue("@deptno", ddlDeptno.SelectedValue);
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "e");
            //gvdata.DataSource = ds.Tables["e"];
            //gvdata.DataBind();
        }

        protected void ddlDeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_getdeptdetails", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@deptno", ddlDeptno.SelectedValue);
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            gvdata.DataSource = ds.Tables["e"];
            gvdata.DataBind();
        }
    }
}