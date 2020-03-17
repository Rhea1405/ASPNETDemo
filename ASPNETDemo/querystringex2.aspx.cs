using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class querystringex2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["a"];
            string s1 = Request.QueryString["b"];
            string s3 = Request.QueryString["c"];
            Response.Write("s " + s + " s1 " + s1+" s3 "+s3);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QS-ex3.aspx");
        }
    }
}