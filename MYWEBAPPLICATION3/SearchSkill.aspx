<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="SearchSkill.aspx.cs" Inherits="MYWEBAPPLICATION3.SearchSkill" %>

<asp:Content ID="SearchSkillContent" runat="server" ContentPlaceHolderID="HomePageCPH">
    
    <div>
        <table>
            <caption>Skill Search</caption>
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
                    <asp:Button ID="btnSearchSkill" runat="server" Text="Search" OnClick="btnSearchSkill_Click" />
                </td>
                <td>
                    <asp:HyperLink ID="hlAddSkill" runat="server" NavigateUrl="~/CreateSkill.aspx">Add Skill</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvSearchSkill" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" 
                        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" 
                        AlternatingRowStyle-ForeColor="#000" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:HyperLinkField DataTextField="SkillName" DataNavigateUrlFields="SkillID" 
                                DataNavigateUrlFormatString="~/ViewSkill.aspx?SkillID={0}" HeaderText="Skill Name" ItemStyle-Width="150" />
                            <asp:BoundField DataField="SkillID" HeaderText="SkillID" ItemStyle-Width="200" />
                            <asp:BoundField DataField="categoryName" HeaderText="Category Name" ItemStyle-Width="200" />
                            <asp:HyperLinkField DataTextField="SkillName" DataTextFormatString="edit" 
                                DataNavigateUrlFields="SkillID" 
                                DataNavigateUrlFormatString="~/UpdateSkill.aspx?SkillID={0}" HeaderText=""
                                itemStyle-Width="150" />
                        </Columns>

                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
