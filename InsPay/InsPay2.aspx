<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="InsPay2.aspx.cs" Inherits="HMS.InsPay.InsPay2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" ID="lnkHome" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink> > <asp:HyperLink runat="server" ID="lnkInsPay" NavigateUrl="~/InsPay/InsPay1.aspx">Payments</asp:HyperLink></div>
    <center>
        <table style="text-align: left">
            <tr><td colspan="2">PROJECTED BATCH TOTALS<br />&nbsp;</td></tr>
            <tr>
                <td>Batch #:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch" MaxLength="4"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Operator Inits:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch0" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Total Qty/Amt:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch1" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Total Codes:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch2" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Total Patient No:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch3" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="right"><asp:Button runat="server" ID="btnNext" Text="Next" Width="80px" OnClick="btnNext_Click" /></td>
            </tr>
        </table>
    </center>
</asp:Content>

