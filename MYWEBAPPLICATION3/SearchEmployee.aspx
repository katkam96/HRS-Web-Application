<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomePage.Master" CodeBehind="SearchEmployee.aspx.cs" Inherits="MYWEBAPPLICATION3.SearchEmployee" %>


<asp:content ID="SearchEmployeeContent" runat="server" ContentPlaceHolderID="HomePageCPH" >

        <div>
            <table>
                
                    <caption>Employee Search</caption>
             
                <tr>
                    <td>
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                    <td>
                        <asp:HyperLink ID="hlAddEmployee" NavigateUrl="~/CreateEmployee.aspx" runat="server">Add Employee</asp:HyperLink>
                    </td>
                </tr>

            </table>
            <table>
                <tr>
                    <td>
                        <asp:GridView ID="gvSearchEmployee" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" runat="server" AutoGenerateColumns="false"> 
                            <Columns>
                                <asp:HyperLinkField DataTextField="EmpID" DataNavigateUrlFields="EmpID" 
                                    DataNavigateUrlFormatString="~/ViewEmployee.aspx?EmpID={0}"
                                    HeaderText="Employee ID" ItemStyle-Font-Bold="true"  ItemStyle-Width = "150" />
                                <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" ItemStyle-Width="200" />
                                <asp:BoundField DataField="LevelNo" HeaderText="Level" ItemStyle-Width="200" />
                                <asp:HyperLinkField DataTextField="EmpID" DataTextFormatString="Edit" 
                                    DataNavigateUrlFields="EmpID" 
                                    DataNavigateUrlFormatString="~/UpdateEmployee.aspx?EmpID={0}"
                                    HeaderText="" ItemStyle-Font-Bold="true" ItemStyle-Width="150" />
                                
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </asp:content>
