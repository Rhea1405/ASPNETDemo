using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class USINGVALIDATIONS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //custom validation will happen at server

            DateTime today = DateTime.Today;
            DateTime d = DateTime.Parse(txtdob.Text);
            
            int age = (int)(today.Subtract(d).TotalDays)/365;

            if(age<21)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
            



            

        }
    }
}