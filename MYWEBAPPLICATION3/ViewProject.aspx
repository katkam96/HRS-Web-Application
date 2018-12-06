<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="ViewProject.aspx.cs" Inherits="MYWEBAPPLICATION3.ViewProject" %>

<asp:Content ID="ViewProjectContent" runat="server" ContentPlaceHolderID="HomePageCPH">
    <div>
        <table>
            <caption style="background-color:aqua;font-size:large;color:brown;">Project Information</caption>
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
                <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                <asp:Label ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                <asp:Label ID="lblClient" runat="server" Text="Client"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txtClient" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                <asp:Label ID="lblProjDesc" runat="server" Text="Project Description"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txtProjDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
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
        </div>
        <div>
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


