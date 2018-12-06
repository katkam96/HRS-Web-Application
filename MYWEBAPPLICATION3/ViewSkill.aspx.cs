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
    public partial class ViewSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SkillController skiCont = new SkillController();
            if (IsPostBack == false)
            {
                try
                {
                    ddlCategoryID.DataTextField = "CategoryName";
                    ddlCategoryID.DataValueField = "CategoryID";
                    ddlCategoryID.DataSource = skiCont.GetCategoryListCont();
                    ddlCategoryID.DataBind();

                    int sID = Convert.ToInt32(Request.QueryString["SkillID"]);
                    DataTable dt = skiCont.ViewSkillCont(sID);

                    ddlCategoryID.Text = dt.Rows[0]["CategoryID"].ToString();
                    txtSkillName.Text = dt.Rows[0]["SkillName"].ToString();
                    txtSkillDesc.Text = dt.Rows[0]["SkillDescription"].ToString();

                    lblCreatedBy.Text ="Created By:"+dt.Rows[0]["CreatedBy"].ToString();
                    lblLastModifiedBy.Text = "Last Modified By:"+dt.Rows[0]["LastModifiedBy"].ToString();
                    

                }
                catch (Exception ex1)
                {
                    System.Diagnostics.Debug.WriteLine(ex1.Message);
                }

            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchSkill.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchSkill.aspx");
        }
    }
}