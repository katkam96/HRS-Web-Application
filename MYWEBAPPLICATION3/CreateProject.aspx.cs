using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;

namespace MYWEBAPPLICATION3
{
    public partial class CreateProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectController projCont = new ProjectController();
                int i = Convert.ToInt32(Session["CreatedBy"]);
                bool x = projCont.CreateProjectCont(txtProjectName.Text, txtProjDesc.Text, txtClient.Text,
                                                  Convert.ToDateTime(txtStartDate.Text),
                                                  Convert.ToDateTime(txtEndDate.Text), i);
                if(x==true)
                {
                    lblMessage.Text = "Project details are added";
                }
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Project details are not added";
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SearchProject.aspx");
        }
    }
}