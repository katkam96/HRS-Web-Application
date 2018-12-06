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
    public partial class ViewCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryController catCont = new CategoryController();
            if (IsPostBack == false)
            {
                try
                {
                    int i = Convert.ToInt32(Request.QueryString["CategoryID"]);
                    DataTable dt = catCont.ViewCategoryCont(i);
                    txtCatName.Text = dt.Rows[0]["CategoryName"].ToString();
                    txtCatDesc.Text = dt.Rows[0]["CategoryDescription"].ToString();

                    lblCreatedBy.Text = "Created By:" + dt.Rows[0]["CreatedBy"].ToString();
                    lblLastModifiedBy.Text = "Last Modified By:" + dt.Rows[0]["LastModifiedBy"].ToString();


                }
                catch (Exception ex1)
                {
                    System.Diagnostics.Debug.WriteLine(ex1.Message);
                }
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchCategory.aspx");
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchCategory.aspx");
        }
    }
}