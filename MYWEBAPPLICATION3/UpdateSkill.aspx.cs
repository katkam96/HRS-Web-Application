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
    public partial class UpdateSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SkillController skiCont = new SkillController();
                try
                {
                    int sID = Convert.ToInt32(Request.QueryString["SkillID"]);
                    DataTable dt = skiCont.ViewSkillCont(sID);
                    txtSkillName.Text = dt.Rows[0]["SkillName"].ToString();
                    txtSkillDesc.Text = dt.Rows[0]["SkillDescription"].ToString();


                }
                catch (Exception ex1)
                {
                    System.Diagnostics.Debug.WriteLine(ex1.Message);
                }
            }
        }

        protected void btnUpdateSkill_Click(object sender, EventArgs e)
        {
            try
            {
                SkillController skiCont = new SkillController();
                int lastModifiedBy = Convert.ToInt32(Session["LastModifiedBy"]);
                int sID = Convert.ToInt32(Request.QueryString["SkillID"]);
                bool x = skiCont.UpdateSkillCont(sID, txtSkillName.Text, txtSkillDesc.Text, lastModifiedBy);
                if(x==true)
                {
                    lblMessage.Text = "Skill details are successfully updated";
                }
                else
                {
                    lblMessage.Text = "Skill details are not updated";
                }

            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Skill details are not updated";

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchSkill.aspx");
        }
    }
}