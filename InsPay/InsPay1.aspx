
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="InsPay1.aspx.cs" Inherits="HMS.Inspay.InsPay1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" ID="lnkMain" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink></div>
    <center>
    <table style="text-align:left">
        <tr>
            <td colspan="2">PAYMENTS<br />&nbsp;
            </td>
        </tr>
        <tr>
            <td>Prompt For:</td>
            <td><asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem Value="A">Allowed Amount</asp:ListItem>
                    <asp:ListItem Value="N">On Allowed Amount</asp:ListItem>
                    <asp:ListItem Value="C">Charge Amount Only</asp:ListItem>
                    <asp:ListItem Value="O">Other WriteOffs</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Choose Action:</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1">Payments</asp:ListItem>
                    <asp:ListItem Value="2">Debits</asp:ListItem>
                    <asp:ListItem Value="3">Credits</asp:ListItem>
                </asp:DropDownList></td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Flag Refunds" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Duplicate Codes" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Payment by Policy No" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Contractuals/WriteOffs" /></td>
        </tr>
        <tr>
            <td>Contractual Batch #:</td>
            <td>
                <asp:TextBox runat="server" ID="txtContractBatch" MaxLength="4"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adjustment Code:</td>
            <td>
                <asp:TextBox runat="server" ID="txtAdjCode"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox5" runat="server" Text="C059 WriteOff" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox6" runat="server" Text="2% Reduction WriteOff" /></td>
        </tr>
        <tr><td colspan="2" align="right"><asp:Button runat="server" ID="btnNext" Text="Next" Width="80px" OnClick="btnNext_Click" /></td></tr>
    </table>
</center>
</asp:Content>
