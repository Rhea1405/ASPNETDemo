using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class efex2 : System.Web.UI.Page
    {
        DemoEntities d = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
        }

        protected void txtempno_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;

            //if query returns more than oner record, we assign it to list
            // List<EMPDATA> lemp = E.ToList();//to extract only one record,since empno a primary key

            //if it returns only one, we just assign it to object

            EMPDATA emp = E.First();
           
            txtename.Text = emp.ENAME;
            txtjob.Text = emp.JOB;
            txtmgr.Text = emp.MGR.ToString();
            string hd = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");//zoorian format for date
            txthiredate.Text = hd;
            txtsal.Text = emp.SAL.ToString();
            txtcomm.Text = emp.COMM.ToString();
            txtdeptno.Text = emp.DEPTNO.ToString();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;

            EMPDATA emp = E.First();


            int c = 0;
            bool b = int.TryParse(txtcomm.Text, out c);
            emp.ENAME = txtename.Text;
            emp.JOB = txtjob.Text;
            emp.MGR = int.Parse(txtmgr.Text);
            emp.HIREDATE = DateTime.Parse(txthiredate.Text);
            emp.SAL = int.Parse(txtsal.Text);
            // emp.COMM = Convert.ToInt32(txtcomm.Text);//because comm has null values,null will be converted to 0 but it will not handle empty
            if(c!=0)
            emp.COMM = c;
            emp.DEPTNO = int.Parse(txtdeptno.Text);

           
            d.SaveChanges();


        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;

            EMPDATA emp = E.First();
            d.EMPDATAs.Remove(emp);
            d.SaveChanges();
            txtempno.Text = "";
            txtename.Text = "";
            txtjob.Text = "";
            txtmgr.Text = "";
            txtcomm.Text = "";
            txtsal.Text = "";
            txtdeptno.Text = "";
            txthiredate.Text = "";





        }
    }
}