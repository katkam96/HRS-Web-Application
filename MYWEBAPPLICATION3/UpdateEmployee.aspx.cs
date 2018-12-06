using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using System.Data.SqlClient;
using System.Data;

namespace MYWEBAPPLICATION3
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                EmployeeController empCtr = new EmployeeController();
                ddlGender.Items.Add(new ListItem("Male", "M"));
                ddlGender.Items.Add(new ListItem("Female", "F"));

                ddlLevel.DataTextField = "LevelNo";
                ddlLevel.DataValueField = "LevelNo";
                ddlLevel.DataSource = empCtr.GetLevelDetailsCont();
                ddlLevel.DataBind();

                ddlSpeciality.DataTextField = "Speciality";
                ddlSpeciality.DataValueField = "Speciality";
                ddlSpeciality.DataSource = empCtr.GetSpecialityDetailsCont();
                ddlSpeciality.DataBind();

                ddlCivilStatus.DataTextField = "CivilStatus";
                ddlCivilStatus.DataValueField = "CivilStatus";
                ddlCivilStatus.DataSource = empCtr.GetStatusDetailsCont();
                ddlCivilStatus.DataBind();

                int i = Convert.ToInt32(Request.QueryString["EmpID"]);
                int j = Convert.ToInt32(Session["LastModifiedBy"]);
                DataTable dt=empCtr.ViewEmployeeCont(i);

                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLastName.Text = dt.Rows[0]["Lastname"].ToString();
                txtMiddleName.Text = dt.Rows[0]["MiddleName"].ToString();
                txtDateOfBirth.Text = dt.Rows[0]["DateOfBirth"].ToString();
                ddlGender.Text = dt.Rows[0]["Gender"].ToString();
                ddlCivilStatus.Text = dt.Rows[0]["CivilStatus"].ToString();
                txtCitizenShip.Text = dt.Rows[0]["CitizenShip"].ToString();
                txtSSNNo.Text = dt.Rows[0]["SSSNo"].ToString();
                txtTINNo.Text = dt.Rows[0]["TINNo"].ToString();
                txtStreet1.Text = dt.Rows[0]["Street1"].ToString();
                txtStreet2.Text = dt.Rows[0]["Street2"].ToString();
                txtCity.Text = dt.Rows[0]["City"].ToString();
                txtState.Text = dt.Rows[0]["States"].ToString();
                txtCountry.Text = dt.Rows[0]["Country"].ToString();
                txtMobNo.Text = dt.Rows[0]["MobNo"].ToString();
                txtHomeNo.Text = dt.Rows[0]["HomeNo"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtEnterpriseID.Text = dt.Rows[0]["EnterpriseID"].ToString();
                ddlLevel.Text = dt.Rows[0]["LevelNo"].ToString();
                txtDateHired.Text = dt.Rows[0]["DateHired"].ToString();
                txtLMU.Text = dt.Rows[0]["LMU"].ToString();
                txtGMU.Text = dt.Rows[0]["GMU"].ToString();
                ddlSpeciality.Text = dt.Rows[0]["Speciality"].ToString();
                txtworkGroup.Text = dt.Rows[0]["WorkGroup"].ToString();
                txtStatus.Text = dt.Rows[0]["Statuss"].ToString();
                txtServiceLine.Text = dt.Rows[0]["ServiceLine"].ToString();
                txtEduBackGround.Text = dt.Rows[0]["EduBackGround"].ToString();
                txtRecognitions.Text = dt.Rows[0]["Recognitions"].ToString();






            }
        }

        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeController empCtr = new EmployeeController();
                int i = Convert.ToInt32(Request.QueryString["EmpID"]);
                int j = Convert.ToInt32(Session["LastModifiedBy"]);
                bool x=empCtr.UpdateEmployeeCont(i, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                    Convert.ToDateTime(txtDateOfBirth.Text), ddlGender.Text, Convert.ToInt32(ddlCivilStatus.Text),
                    txtSSNNo.Text, txtTINNo.Text, txtCitizenShip.Text, txtMobNo.Text, txtHomeNo.Text,
                    txtStreet1.Text, txtStreet2.Text, txtCity.Text, txtState.Text, txtCountry.Text,
                    txtEduBackGround.Text, txtRecognitions.Text, txtEmail.Text, txtEnterpriseID.Text,
                    Convert.ToInt32(ddlLevel.Text), txtLMU.Text, txtGMU.Text, Convert.ToDateTime(txtDateHired.Text),
                    txtworkGroup.Text, Convert.ToInt32(ddlSpeciality.Text), txtServiceLine.Text,
                    txtStatus.Text, j);
                if (x == true)
                {
                    lblMessage.Text = "Employee details are successfully updated";
                }
                else
                {
                    lblMessage.Text = "Employee details are not updated";
                }
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Employee details are not updated";
            }
            

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SearchEmployee.aspx");
        }
    }
}