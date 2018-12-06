<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MYWEBAPPLICATION3.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
        <form id="form1" runat="server">
            <div>

                <table>

                    <caption style="background-color: aqua; font-size: large; color: brown">LOGIN</caption>
                    <tr>
                        <td>
                            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lblPassWord" runat="server" Text="PassWord"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>

                        </td>
                    </tr>
                    <tr align="center">
                        <td colspan="2">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>


                </table>

            </div>
        </form>
    </center>
</body>
</html>
