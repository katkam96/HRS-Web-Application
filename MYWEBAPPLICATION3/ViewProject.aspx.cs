using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using System.Data;

namespace MYWEBAPPLICATION3
{
    public partial class ViewProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectController projCont = new ProjectController();
                int i = Convert.ToInt32(Request.QueryString["ProjID"]);
                DataTable dt = projCont.ViewProjectCont(i);
                txtProjectName.Text = dt.Rows[0]["ProjName"].ToString();
                txtProjDesc.Text = dt.Rows[0]["ProjDescription"].ToString();
                txtClient.Text = dt.Rows[0]["Client"].ToString();
                txtStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                txtEndDate.Text = dt.Rows[0]["EndDate"].ToString();

                lblCreatedBy.Text = "Created By:" + dt.Rows[0]["CreatedBy"].ToString();
                lblLastModifiedBy.Text = "Last Modified By:" + dt.Rows[0]["LastModifiedBy"].ToString();


            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchProject.aspx");
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchProject.aspx");
        }
    }
}