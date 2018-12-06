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
    public partial class UpdateProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                try
                {
                    ProjectController projCont = new ProjectController();
                    int pID = Convert.ToInt32(Request.QueryString["ProjID"]);
                    DataTable dt = projCont.ViewProjectCont(pID);
                    txtProjectName.Text = dt.Rows[0]["ProjName"].ToString();
                    txtProjDesc.Text = dt.Rows[0]["ProjDescription"].ToString();
                    txtClient.Text = dt.Rows[0]["Client"].ToString();
                    txtStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                    txtEndDate.Text = dt.Rows[0]["EndDate"].ToString();
                }
                catch (Exception ex1)
                {
                    System.Diagnostics.Debug.WriteLine(ex1.Message);
                }
            }

        }

        protected void btnUpdateProject_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectController projCont = new ProjectController();
                int pID = Convert.ToInt32(Request.QueryString["ProjID"]);
                int pLastModifiedBy = Convert.ToInt32(Session["LastModifiedBy"]);
                bool x = projCont.UpdateProjectCont(pID, txtProjectName.Text, txtProjDesc.Text, txtClient.Text,
                    Convert.ToDateTime(txtStartDate.Text), Convert.ToDateTime(txtEndDate.Text), pLastModifiedBy);
                if(x==true)
                {
                    lblMessage.Text = "Project details are updated successfully ";
                }
                else
                {
                    lblMessage.Text = "Project details are not updated successfully";
                }
                


            }
            catch(Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                lblMessage.Text = "Project details are not updated ";
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SearchProject.aspx");
        }
    }
}