<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="ActionFollowup.aspx.cs" Inherits="HMS.Inquiry.ActionFollowup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Patient Action Follow Up
    </title>
    <style type="text/css">
        .auto-style1 {
            width: 797px;
            font-weight: 700;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" id="lnkMenu" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink> > <asp:HyperLink runat="server" ID="lnkInquiry"  NavigateUrl="~/Inquiry/Inquiry.aspx">Inquiry Menu</asp:HyperLink></div>
    <center>
        <asp:Label runat="server" ID="lblHeader" ForeColor="#0B2577"></asp:Label><br />
        &nbsp;</center>
     <table>
        <tr>
            <td class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:PlaceHolder runat="server" ID="placePatActFU" Visible="true">
                    <asp:Label runat="server" ID="lblAccount" Text="Account #:"></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtAccount"></asp:TextBox>&nbsp;&nbsp;
                </asp:PlaceHolder>
                &nbsp;&nbsp;<asp:Button runat="server" ID="btnSearch" Text="Search" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblPatientName" runat="server" Text="Patient: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>

    <asp:GridView runat="server" ID="grdPatFollowUp" AutoGenerateColumns="False" AllowPaging="True"
        AllowSorting="True"
        OnPageIndexChanging="grdInquiryByAcronym_PageIndexChanging" PageSize="20" CssClass="tablebody" AlternatingRowStyle-CssClass="altRow" SelectedRowStyle-CssClass="selRow" Height="337px" HorizontalAlign="Center" Width="783px">
<AlternatingRowStyle CssClass="altRow"></AlternatingRowStyle>
        <Columns>
            <asp:BoundField DataField="TRNumber" HeaderText="TR#">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="ActDate" HeaderText="Date" DataFormatString="{0:d}">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="No" HeaderText="No">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Action" HeaderText="Action Taken">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="INIT" HeaderText="INIT" DataFormatString="{0:d}">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
        </Columns>

<SelectedRowStyle CssClass="selRow"></SelectedRowStyle>
    </asp:GridView>
</asp:Content>

