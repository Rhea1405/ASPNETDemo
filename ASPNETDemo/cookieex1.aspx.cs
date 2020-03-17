using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class cookieex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length!=0)
            {
                Response.Cookies["user"].Value = TextBox1.Text;//create cookie variable
                Response.Cookies["user"].Expires = DateTime.Now.AddSeconds(10);
                Response.Redirect("cookieex2.aspx");


                //method 2 to create a cookie
                HttpCookie h = new HttpCookie("cookie");
                h.Value = TextBox1.Text;
                Response.Cookies.Add(h);
            }
        }
    }
}