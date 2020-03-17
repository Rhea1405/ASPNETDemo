using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class cookieex2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Cookies["user"].Value;//fetching dta from cookies
            Response.Write(s);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cookieex3.aspx");
        }
    }
}