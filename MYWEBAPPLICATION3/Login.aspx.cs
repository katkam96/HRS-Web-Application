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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryController catCont = new CategoryController();
                DataTable dt = new DataTable();
                dt = catCont.ValidateUserCont(txtUserName.Text, txtPassWord.Text);
                int retVal = Convert.ToInt32(dt.Rows[0]["RetVal"]);
                if (retVal == 1)
                {
                    lblMessage.Text = "Login Successful";
                    int userID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    Session.Add("UserID", userID);
                    Session.Add("LastModifiedBy", userID);
                    Session.Add("CreatedBy", userID);

                    Response.Redirect("~//Default.aspx");
                }
                else if (retVal == 2)
                
                 {
                        lblMessage.Text = "Login Successful but no authority to access Human Resources";
                 }

                else
                {
                    lblMessage.Text = "Invalid UserID or PassWord";
                }
                
                    

            }
            catch(Exception ex1)
            {
                lblMessage.Text = "Invalid UserID or PassWord";
                System.Diagnostics.Debug.WriteLine(ex1.Message);
            }

        }
    }
}