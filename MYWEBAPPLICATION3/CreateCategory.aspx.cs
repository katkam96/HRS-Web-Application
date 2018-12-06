using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;

namespace MYWEBAPPLICATION3
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryController catCont = new CategoryController();
            try
            {
                int i = Convert.ToInt32(Request.QueryString["CreatedBy"]);
                bool x = catCont.CreateCategoryCont(txtCatName.Text, txtCatDesc.Text, i);
                if(x==true)
                {
                    lblMessage.Text = "Category details are successfully added";

                }
                else
                {
                    lblMessage.Text = "Category details are not added";
                }
                
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Category details are not added";
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Searchcategory.aspx");
        }
    }
}