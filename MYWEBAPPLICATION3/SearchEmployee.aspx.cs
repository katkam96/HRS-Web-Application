using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;

namespace MYWEBAPPLICATION3
{
    public partial class SearchEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeController empCtr = new EmployeeController();
                gvSearchEmployee.DataSource = empCtr.SearchEmployeebyNameCont(txtFirstName.Text, txtLastName.Text);
                gvSearchEmployee.DataBind();
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
            }

        }
    }
}