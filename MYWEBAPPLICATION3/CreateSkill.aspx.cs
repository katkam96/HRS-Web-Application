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
    public partial class CreateSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                try
                {
                    SkillController skiCont = new SkillController();
                    ddlCategoryID.DataTextField = "CategoryID";
                    ddlCategoryID.DataValueField = "CategoryID";
                    ddlCategoryID.DataSource = skiCont.GetCategoryListCont();
                    ddlCategoryID.DataBind();
                    ddlCategoryID.Items.Insert(0, "Select");

                }
                catch (Exception ex1)
                {
                    System.Diagnostics.Debug.WriteLine(ex1.Message);
                }
            }

        }

        protected void btnAddSkill_Click(object sender, EventArgs e)
        {
            SkillController skillCont = new SkillController();
            try
            {
                
                int createdBy = Convert.ToInt32(Session["CreatedBy"]);
                bool x = skillCont.CreateSkillCont(txtSkillName.Text, txtSkillDesc.Text, 
                                                   Convert.ToInt32(ddlCategoryID.Text), createdBy);
                if(x==true)
                {
                    
                    lblMessage.Text = "Skill Details are successfully added";
                }
                else
                {
                    lblMessage.Text = "Skill details are not added";
                }
            }
            catch(Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.Message);
                lblMessage.Text = "Skill details are not added";
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchSkill.aspx");
        }
    }
}