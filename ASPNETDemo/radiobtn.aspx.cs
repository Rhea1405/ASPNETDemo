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
    public partial class radiobtn : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                txtend.Enabled = false;
                txtstart.Enabled = false;
                ddldeptno.Enabled = false;
            }
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            adp = new SqlDataAdapter("sp_extractemp", con);
            if (!IsPostBack)
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "d");

                ddldeptno.DataSource = ds.Tables["d"];
                ddldeptno.DataTextField = "Dname";
                ddldeptno.DataValueField = "Deptno";
                ddldeptno.DataBind();

            }
           
        }

        protected void rdbjob_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbdoj.Checked)
            {
               // gvdata.DataSource = null;
                txtstart.Enabled = true;
                txtend.Enabled = true;
                ddldeptno.Enabled = false;

                




            }
        }

        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbdeptno.Checked)
            {
                //gvdata.DataSource = null;
                txtstart.Enabled = false;
                txtend.Enabled =false;
                ddldeptno.Enabled = true;
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if(rdbdoj.Checked)
            {
                
                adp = new SqlDataAdapter("sp_getbetweendates", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@start", DateTime.Parse(txtstart.Text));
                adp.SelectCommand.Parameters.AddWithValue("@end", DateTime.Parse(txtend.Text));
                SqlParameter p = new SqlParameter("@res", SqlDbType.NVarChar, 200);
                p.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(p);

               

                DataSet ds = new DataSet();
                adp.Fill(ds, "e");

                gvdata.DataSource = ds.Tables["e"];
                gvdata.DataBind();
                Label1.Text = p.Value.ToString();



            }
            if(rdbdeptno.Checked)
            {
               
                adp = new SqlDataAdapter("sp_getdeptdetails", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@deptno", ddldeptno.SelectedValue);
                DataSet ds = new DataSet();
                adp.Fill(ds, "e");
                gvdata.DataSource = ds.Tables["e"];
                gvdata.DataBind();
            }



        }
    }
}