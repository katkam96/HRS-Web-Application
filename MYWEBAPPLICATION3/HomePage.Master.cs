using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYWEBAPPLICATION3
{
    public partial class HomePage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Session["LastModifiedBy"]);
            int j = Convert.ToInt32(Session["CreatedBy"]);
            
            int k = Convert.ToInt32(Session["UserID"]);
            lblMessage.Text = "Welcome to User ID: " + k.ToString();
           
           /* lblCreatedBy.Text = " Created By: " + j.ToString();
            lblLastModifiedBy.Text = "Last Modified By: " + i.ToString();*/

        }


        protected void ImgEmployee_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~//SearchEmployee.aspx");
        }

        protected void ImgProject_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~//SearchProject.aspx");
        }

        protected void ImgCategory_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~//SearchCategory.aspx");
        }

        protected void ImgSkill_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~//SearchSkill.aspx");
        }
    }
}