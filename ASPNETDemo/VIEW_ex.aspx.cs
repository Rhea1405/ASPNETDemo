using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class VIEW_ex : System.Web.UI.Page
    {
        DemoEntities d = null;
        public  void bind()
        {
            d = new DemoEntities();
            var v = from o in d.orderviewws
                    select o;
            GridView1.DataSource = v.ToList();
            GridView1.DataBind();



            //displaying in detailsview
            DetailsView1.DataSource = v.ToList();
            DetailsView1.DataBind();


            //formview

            FormView1.DataSource = v.ToList();
            FormView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
//            d = new DemoEntities();
//            var v = from o in d.orderviewws
//                    select o;
//            GridView1.DataSource = v.ToList();
//            GridView1.DataBind();
////displaying in detailsview
//            DetailsView1.DataSource = v.ToList();
//            DetailsView1.DataBind();


//            //formview

//            FormView1.DataSource = v.ToList();
//            FormView1.DataBind();


        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            bind();
            
            
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}