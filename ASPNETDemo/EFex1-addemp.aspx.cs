using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace ASPNETDemo
{
    public partial class EFex1 : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtempno.Text);
                E.ENAME = txtename.Text;
                E.JOB = txtjob.Text;
                E.MGR = int.Parse(txtmgr.Text);
                E.HIREDATE = DateTime.Parse(txthiredate.Text);
                E.SAL = int.Parse(txtsal.Text);
                E.COMM = int.Parse(txtcomm.Text);
                E.DEPTNO = int.Parse(txtdeptno.Text);
                D.EMPDATAs.Add(E);
                D.SaveChanges();
                label.Text = "1 row added successfully";
                txtempno.Text = "";
                txtename.Text = "";
                txtjob.Text = "";
                txtmgr.Text = "";
                txtcomm.Text = "";
                txtsal.Text = "";
                txtdeptno.Text = "";
                txthiredate.Text = "";
            }
            catch(DbUpdateException s)
            {
                SqlException ex = s.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    label.Text = "no duplicate empno";
                else if (ex.Message.Contains("FK__EMPDATA__DEPTNO__236943A5"))
                    label.Text = "no deptno exists";
                else
                    label.Text = ex.Message;
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
//EF using stored procedure--
        protected void Button2_Click(object sender, EventArgs e)
        {

            ObjectParameter op = new ObjectParameter("res", typeof(string));

            D.sp_insertemp(int.Parse(txtempno.Text), txtename.Text, txtjob.Text, int.Parse(txtmgr.Text),
                DateTime.Parse(txthiredate.Text), int.Parse(txtsal.Text),
                int.Parse(txtcomm.Text), int.Parse(txtdeptno.Text), op);
            label.Text = op.Value.ToString();
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