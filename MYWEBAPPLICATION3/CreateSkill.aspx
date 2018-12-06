<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="CreateSkill.aspx.cs" Inherits="MYWEBAPPLICATION3.CreateSkill" %>


<asp:Content ID="CreateSkillContent" runat="server" ContentPlaceHolderID="HomePageCPH">

    <div>
        <table>
            <caption style="background-color:aqua;font-size:large;color:brown;">Skill Information</caption>
            <tr>
                <td>
                    <asp:Label ID="lblCategoryID" runat="server" Text="CategoryID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCategoryID" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSkillName" runat="server" Text="Skill Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSkillName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblSkillDesc" runat="server" Text="Skill Description"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSkillDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAddSkill" runat="server" Text="Add Skill" OnClick="btnAddSkill_Click" />
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
