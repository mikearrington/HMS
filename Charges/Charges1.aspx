
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Charges1.aspx.cs" Inherits="HMS.Charges.Charges1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 208px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" ID="lnkHome" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink> </div>
    <center>
        <table style="text-align: left" >
            <tr><td colspan="2" style="">PROJECTED BATCH TOTALS<br /></td></tr>
            <tr>
                <td class="auto-style1" style="">Location:</td>
                <td><asp:TextBox runat="server" ID="txtLocation" MaxLength="4"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Batch #:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch" MaxLength="4"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Operator Inits:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch0" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Total Qty/Amt:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch1" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Total Codes:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch2" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Total Patient No.&#39;s:</td>
                <td>
                    <asp:TextBox runat="server" ID="txtBatch3" MaxLength="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1" style="">Will Ticket #s be used:</td>
                 <td>
                     <asp:DropDownList ID="DropDownList1" runat="server">
                         <asp:ListItem Value="1">Yes</asp:ListItem>
                         <asp:ListItem Value="2">No</asp:ListItem>
                     </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2" align="right"><asp:Button runat="server" ID="btnNext" Text="Next" Width="80px" OnClick="btnNext_Click" /></td>
            </tr>
        </table>
    </center>
</asp:Content>

