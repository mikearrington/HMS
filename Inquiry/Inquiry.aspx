<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="Inquiry.aspx.cs" Inherits="HMS.Inquiry.Inquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" id="lnkMenu" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink></div>
    <center>
        <table style="text-align:left;">
            <tr>
                <td>INQUIRY OPTIONS<br/>&nbsp;</td>
            </tr>
            <tr>
                <td><a href="Inquiry2.aspx?Inq=a">Acronym</a></td>
            </tr>
            <tr>
                <td><a href="Inquiry2.aspx?Inq=l">Last Name</a></td>
            </tr>
            <tr>
                <td>Demographic Data</td>
            </tr>
            <tr>
                <td>Transactions</td>
            </tr>
            <tr>
                <td>Appointments</td>
            </tr>
            <tr>
                <td>Transactions</td>
            </tr>
            <tr>
                <td>Patient Action Follow Up</td>
            </tr>
            <tr>
                <td><a href="Inquiry2.aspx?Inq=p">Policy Number</a></td>
            </tr>
            <tr>
                <td><a href="Inquiry2.aspx?Inq=s">Social Security Number</a></td>
            </tr>
            <tr>
                <td><a href="Inquiry2.aspx?Inq=m">Medical Record Number</a></td>
            </tr>
            <tr>
                <td>Aux Number XREF</td>
            </tr>
        </table>
        </center>
</asp:Content>
