using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class cookiesex3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string s = Request.Cookies["user"].Value;
                Response.Write(s);
            }
            catch(NullReferenceException f)
            {
                Response.Redirect("cookieex1.aspx");
            }
        }
    }
}