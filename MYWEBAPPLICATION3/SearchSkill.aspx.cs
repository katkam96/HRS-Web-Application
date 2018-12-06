using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;

namespace MYWEBAPPLICATION3
{
    public partial class SearchSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchSkill_Click(object sender, EventArgs e)
        {
            try
            {
                SkillController skiCont = new SkillController();
                gvSearchSkill.DataSource = skiCont.SearchSkillCont(txtSkillName.Text);
                gvSearchSkill.DataBind();
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
            }
        }
    }
}