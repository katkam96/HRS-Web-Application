<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="UpdateSkill.aspx.cs" Inherits="MYWEBAPPLICATION3.UpdateSkill" %>


<asp:Content ID="UpdateSkill" runat="server" ContentPlaceHolderID="HomePageCPH" >
    <div>
        <table>
            <caption style="background-color:aqua;font-size:medium;color:brown;">Update Skill</caption>
            
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
                    <asp:Button ID="btnUpdateSkill" runat="server" Text="Update Skill" OnClick="btnUpdateSkill_Click"/>
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