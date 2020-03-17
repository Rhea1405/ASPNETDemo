using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ASPNETDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                 con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet ds = new DataSet();
            adp.Fill(ds,"e");
            DataRow r = ds.Tables["e"].NewRow();
            r[0] = int.Parse(txtempno.Text);
            r[1] = txtempname.Text;
            r[2] = txtjob.Text;
            r[3] = int.Parse(txtmgrid.Text);
            r[4] = DateTime.Parse(txthiredate.Text);
            r[5] = int.Parse(txtsal.Text);
            r[6] = int.Parse(txtcomm.Text);
            r[7] = int.Parse(txtdeptno.Text);
            ds.Tables["e"].Rows.Add(r);

            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
        adp.InsertCommand=cmd.GetInsertCommand();
            adp.Update(ds, "e");
            Response.Write("<script> alert('1 row inserted')</script>");
            


        }
    }
}