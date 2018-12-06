<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="CreateEmployee.aspx.cs" Inherits="MYWEBAPPLICATION3.CreateEmployee" %>

<asp:Content ID="CreateEmployeeContent" runat="server" ContentPlaceHolderID="HomePageCPH">
    <div>
        <table style="width: 400px">

            <caption style="background-color: aqua; font-size: large; color: brown">Personal Information </caption>
            <tr>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
           
                <td>
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                 
            </tr>
          
            <tr>
                <td>
                    <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
                </td>
                   
                <td>
                    <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlGender" runat="server"></asp:DropDownList>
                </td>
            </tr>

        </table>
        <table style="width: 400px">
            <caption style="background-color: aqua; font-size: large; color: brown">Civil Information</caption>
            <tr>
                <td>
                    <asp:Label ID="lblCivilStatus" runat="server" Text="Civil Status"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCivilStatus" runat="server"></asp:DropDownList>
                </td>
                
            
            
                <td>
                    <asp:Label ID="lblCitizenShip" runat="server" Text="CitizenShip"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCitizenShip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSNNo" runat="server" Text="SSN Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSNNo" runat="server"></asp:TextBox>
                </td>
            
                <td>
            
                    <asp:Label ID="lblTINNo" runat="server" Text="TIN Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTINNo" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width: 400px">
            <caption style="background-color: aqua; font-size: large; color: brown">Address and Contact Information</caption>
            <tr align="center">
                <td>
                    <asp:Label ID="lblStreet1" runat="server" Text="Street1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
                </td>
            
                <td>
                    <asp:Label ID="lblStreet2" runat="server" Text="Street2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
                </td>
            
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMobNo" runat="server" Text="Mobile Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMobNo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblHomeNo" runat="server" Text="Home Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHomeNo" runat="server"></asp:TextBox>
                </td>
            </tr>

        </table>
        <table style="width: 400px">
            <caption style="background-color: aqua; font-size: large; color: brown">Company Information</caption>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblEnterpriseID" runat="server" Text="EnterpriseID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEnterpriseID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLevel" runat="server" Text="Level"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLevel" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblDateHired" runat="server" Text="Date Hired"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateHired" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLMU" runat="server" Text="LMU"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLMU" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblGMU" runat="server" Text="GMU"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGMU" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSpeciality" runat="server" Text="Speciality"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSpeciality" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblWorkGroup" runat="server" Text="Work Group"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtworkGroup" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblServiceLine" runat="server" Text="ServiceLine"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtServiceLine" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table>
            <caption style="background-color: aqua; font-size: large; color: brown;">Educational Background</caption>
            <tr>
                <td>
                    <asp:TextBox ID="txtEduBackGround" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width: 400px">
            <caption style="background-color: aqua; font-size: large; color: brown;">Recognitions and Certifications</caption>
            <tr>
                <td>
                    <asp:TextBox ID="txtRecognitions" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" OnClick="btnAddEmployee_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>



</asp:Content>
