<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="MainMenu.aspx.cs" Inherits="HMS.MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Main Menu</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <br />
    <center>
        <table style="text-align: left;">
            <tr>
                <td>MENU OPTIONS
          <br />
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <a href="register.aspx">Register</a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="cashier.aspx">Cashier</a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="charges.aspx">Charges</a>


                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink runat="server" ID="lnkInsPay" NavigateUrl="~/InsPay/InsPay1.aspx">Payments &amp; Adjustments</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink runat="server" ID="lnkInquiry" NavigateUrl="/inquiry/inquiry.aspx">Inquiry</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink runat="server" ID="inspay" NavigateUrl="batchcorrections.aspx">Batch Corrections</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink runat="server" ID="lnkBatchVerify" NavigateUrl="~/batch/batchverify.aspx">Batch Verify</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="miscprocessing.aspx">Miscellaneous Processing</a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="scheduling.aspx">Appointment Scheduling Menu</a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="login.aspx">LogOff</a>
                </td>
            </tr>
        </table>
        <br />
    </center>
</asp:Content>
