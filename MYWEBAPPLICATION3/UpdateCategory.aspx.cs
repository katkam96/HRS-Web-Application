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
    public partial class UpdateCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                CategoryController catCont = new CategoryController();
                int i = Convert.ToInt32(Request.QueryString["CategoryID"]);
                DataTable dt = catCont.ViewCategoryCont(i);
                txtCatName.Text = dt.Rows[0]["CategoryName"].ToString();
                txtCatDesc.Text = dt.Rows[0]["CategoryDescription"].ToString();

            }

        }

        protected void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryController catCont = new CategoryController();
                int catID = Convert.ToInt32(Request.QueryString["CategoryID"]);
                int lastModifiedBy = Convert.ToInt32(Session["LastModifiedBy"]);
                bool x = catCont.UpdateCategoryCont(catID, txtCatName.Text, txtCatDesc.Text, lastModifiedBy);
                if (x == true)
                {
                    lblMessage.Text = "Category details are successfully updated";
                }
                else
                {
                    lblMessage.Text = "Category details are not updated";
                }
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Category details are not updated";

            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchCategory.aspx");
        }
    }
}