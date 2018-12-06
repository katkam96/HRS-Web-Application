<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="SearchProject.aspx.cs" Inherits="MYWEBAPPLICATION3.SearchProject" %>

<asp:content ID="SearchProjectContent" runat="server" ContentPlaceHolderID="HomePageCPH" >
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSearchProject" runat="server" Text="Search" OnClick="btnSearchProject_Click" />
                </td>
                <td>
                    <asp:HyperLink ID="hlAddProject" NavigateUrl="~/CreateProject.aspx"
                        runat="server">Add project</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvSearchProject" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" 
                        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" 
                        AlternatingRowStyle-ForeColor="#000" runat="server" AutoGenerateColumns="false">
                        <Columns>
                    <asp:HyperLinkField DataTextField="ProjName" DataNavigateUrlFields="ProjID" 
                                DataNavigateUrlFormatString="~/ViewProject.aspx?ProjID={0}"
                                HeaderText="Project Name" ItemStyle-Width="150" />
                     <asp:BoundField DataField="StartDate" HeaderText="Start Date" ItemStyle-Width="150" />
                     <asp:BoundField DataField="EndDate" HeaderText="End Date" ItemStyle-Width="150" />
                     <asp:HyperLinkField DataTextField="ProjName" DataTextFormatString="edit" 
                                DataNavigateUrlFields="ProjID" DataNavigateUrlFormatString="~/UpdateProject.aspx?ProjID={0}" 
                                HeaderText="" ItemStyle-Width="150" />
                        </Columns>
                        </asp:GridView>             
                </td>
            </tr>
        </table>
    </div>
</asp:content>


