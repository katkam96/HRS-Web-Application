using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;

namespace MYWEBAPPLICATION3
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                EmployeeController empCtr = new EmployeeController();
                ddlGender.Items.Add(new ListItem("Male", "M"));
                ddlGender.Items.Add(new ListItem("Female", "F"));
                ddlGender.Items.Insert(0, new ListItem("Select",""));

                ddlLevel.DataTextField = "LevelNo";
                ddlLevel.DataValueField = "LevelNo";
                //ddlLevel.SelectedValue = "12";
                ddlLevel.DataSource = empCtr.GetLevelDetailsCont();
                ddlLevel.DataBind();
                ddlLevel.Items.Insert(0, new ListItem("Select", ""));

                ddlSpeciality.DataTextField = "Speciality";
                ddlSpeciality.DataValueField = "Speciality";
                ddlSpeciality.DataSource = empCtr.GetSpecialityDetailsCont();
                ddlSpeciality.DataBind();
                ddlSpeciality.Items.Insert(0, new ListItem("Select", ""));

                ddlCivilStatus.DataTextField = "CivilStatus";
                ddlCivilStatus.DataValueField = "CivilStatus";
                ddlCivilStatus.DataSource = empCtr.GetStatusDetailsCont();
                ddlCivilStatus.DataBind();
                ddlCivilStatus.Items.Insert(0, new ListItem("Select", ""));

            }


        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeController empCont = new EmployeeController();
                int p = Convert.ToInt32(Session["CreatedBy"]);
                bool x=empCont.CreateEmployeeCont(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                    Convert.ToDateTime(txtDateOfBirth.Text), ddlGender.Text, Convert.ToInt32(ddlCivilStatus.Text),
                    txtSSNNo.Text, txtTINNo.Text, txtCitizenShip.Text, txtMobNo.Text, txtHomeNo.Text,
                    txtStreet1.Text, txtStreet2.Text, txtCity.Text, txtState.Text, txtCountry.Text,
                    txtEduBackGround.Text, txtRecognitions.Text, txtEmail.Text, txtEnterpriseID.Text,
                    Convert.ToInt32(ddlLevel.Text), txtLMU.Text, txtGMU.Text, Convert.ToDateTime(txtDateHired.Text),
                    txtworkGroup.Text, Convert.ToInt32(ddlSpeciality.Text), txtServiceLine.Text,
                    txtStatus.Text, p);
                if (x == true)
                {
                    lblMessage.Text = "Employee details are successfully added";
                }
                else
                {
                    lblMessage.Text = "Employee details are not added";
                }
            }
            catch(Exception ex1)
            {
                System.Diagnostics.Debug.WriteLine(ex1.Message);
                lblMessage.Text = "Employee details are not added due to error";
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~//SearchEmployee.aspx");
        }
    }
}