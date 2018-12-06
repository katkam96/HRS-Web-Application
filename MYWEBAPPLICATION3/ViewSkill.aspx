<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="ViewSkill.aspx.cs" Inherits="MYWEBAPPLICATION3.ViewSkill" %>

<asp:Content ID="ViewSkillContent" runat="server" ContentPlaceHolderID="HomePageCPH">
    <div>
        <table>
            <caption style="background-color:aqua;font-size:medium;color:brown;">Skill Information</caption>
            <tr>
                <td>
                    <asp:Label ID="lblCategoryID" runat="server" Text="CategoryName"></asp:Label>
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
                    <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>


        </table>
        <table>
        
        <tr>
            <td>
                <asp:Label ID="lblCreatedBy" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLastModifiedBy" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>





    </div>


</asp:Content>
