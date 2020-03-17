using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class Master2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["username"] == null)
            //    Response.Redirect("login.aspx");
            //else
            //{
            //    Label1.Text = "Welcome " + Request.Cookies["username"].Value;
            //}

            if(Session["user"]==null)
            {
                Response.Redirect("LOGIN2.aspx");
            }
            else
            {
                Label1.Text = "Welcome " + Session["user"].ToString();
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if(Request.Cookies["username"]!=null)
            //{
            //    HttpCookie acookie = HttpContext.Current.Request.Cookies["username"];
            //    acookie.Expires = DateTime.Now.AddSeconds(1);
            //    acookie.Value = "";
            //    HttpContext.Current.Response.Cookies.Add(acookie);
            //    Response.Redirect("login.aspx");
            //}
            Session.Clear();
           // Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Login2.aspx");



        }
    }
}