<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="CreateCategory.aspx.cs" Inherits="MYWEBAPPLICATION3.CreateCategory" %>

<asp:Content ID="CreateCategoryContent" runat="server" ContentPlaceHolderID="HomePageCPH">

    <div>
        <table>

            <caption style="background-color:aqua;font-size:large;color:brown;">Category Information</caption>
            <tr>
                <td>
                    <asp:Label ID="lblCatName" runat="server" Text="Category Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCatName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblCatDesc" runat="server" Text="Category Description"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCatDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnAddCategory" runat="server" Text="Add Category" OnClick="btnAddCategory_Click" />
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
