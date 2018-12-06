<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="SearchCategory.aspx.cs" Inherits="MYWEBAPPLICATION3.SearchCategory" %>



<asp:Content ID="SearchCategoryContent" runat="server" ContentPlaceHolderID="HomePageCPH">

    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblCategoryName" runat="server" Text="Category Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
                <td>
                    <asp:HyperLink ID="hlAddCategory" runat="server" NavigateUrl="~/CreateCategory.aspx" >Add Category</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvSearchCategory" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" 
                        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" 
                        AlternatingRowStyle-ForeColor="#000" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:HyperLinkField DataTextField="categoryName" DataNavigateUrlFields="categoryID" 
                                DataNavigateUrlFormatString="~/ViewCategory.aspx?categoryID={0}" 
                                HeaderText="Category Name" ItemStyle-Width="150" />
                            <asp:HyperLinkField DataTextField="categoryName" DataTextFormatString="edit" 
                                DataNavigateUrlFields="categoryID" DataNavigateUrlFormatString="~/UpdateCategory.aspx?categoryID={0}" 
                                HeaderText="" ItemStyle-Width="150" />
                                
                        </Columns>
                    </asp:GridView>
 
                </td>
            </tr>
        </table>
    </div>
</asp:Content> 
