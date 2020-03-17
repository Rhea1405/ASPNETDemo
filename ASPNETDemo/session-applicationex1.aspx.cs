using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace ASPNETDemo
{
    public partial class session_applicationex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["s"]==null)
            {
                Session["s"] = 1;
            }
            else
            {
                Session["s"] = (int)Session["s"] + 1;
            }

            if (Application["a"] == null)
            {
                Application["a"] = 1;
            }
            else
            {
                Application["a"] = (int)Application["a"] + 1;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Session["s"].ToString();
            TextBox2.Text = Application["a"].ToString();
        }
    }
}