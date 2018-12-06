using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;


namespace MYWEBAPPLICATION3
{
    public partial class SearchProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchProject_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectController projCont = new ProjectController();
                gvSearchProject.DataSource = projCont.SearchProjectCont(txtProjectName.Text);
                gvSearchProject.DataBind();
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
            }
        }
    }
}