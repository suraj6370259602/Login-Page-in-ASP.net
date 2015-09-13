<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-weight: bold;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            text-align: right;
            width: 72px;
        }
        .auto-style4 {
            width: 72px;
        }
        .auto-style5 {
            width: 270px;
        }
        .auto-style6 {
            text-align: left;
        }
        .auto-style7 {
            width: 72px;
            height: 33px;
        }
        .auto-style8 {
            width: 270px;
            height: 33px;
        }
        .auto-style9 {
            text-align: left;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Login Page</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">UserName</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxUNL" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUNL" ErrorMessage="Please enter Username." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxPassL" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassL" ErrorMessage="Please enter Password." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Button ID="BtnLogin" runat="server" Height="25px" OnClick="BtnLogin_Click" Text="Login" Width="77px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration/Registration.aspx" style ="text-decoration:none" ForeColor="#00CCFF">New User Registration</asp:HyperLink>
                </td>
                <td class="auto-style9">
                    </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="#00CCFF" NavigateUrl="~/Registration/ResetPassword.aspx">Forget Password?</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
