<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HMS.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Login Page</title>
   <link href="main.css" rel="stylesheet" />
  <style type="text/css">
    td
    {
      padding: 10px;
      margin: 10px;
    }
  </style>
</head>
<body style="margin-left: auto; margin-right: auto; height: 149px;">
  <form id="frmLogin" runat="server">
  <center><br /><br />
      <h1>Medical Management Systems</h1><br /><br /><br />
    <table cellpadding="0" cellspacing="0">
      <tr>
        <td>
          <asp:RequiredFieldValidator ID="valUserId" runat="server" 
            ControlToValidate="txtUser" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;User&nbsp;Id:&nbsp;
        </td>
        <td>
          <asp:TextBox runat="server" ID="txtUser"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>
          <asp:RequiredFieldValidator ID="valPwd" runat="server" 
            ControlToValidate="txtPwd" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;Password:&nbsp;
        </td>
        <td>
          <asp:TextBox runat="server" ID="txtPwd" TextMode="Password"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td colspan="2" align="center">
          <asp:Button runat="server" ID="btnLogin" Text="Log In" />
          <br />
          <br />
          <asp:label runat="server" ID="lblInvalidLogin" ForeColor="Red" Text=""></asp:label>
        </td>
      </tr>
    </table>
  </center>
  </form>
</body>
</html>
