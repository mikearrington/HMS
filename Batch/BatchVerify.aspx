<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BatchVerify.aspx.cs" Inherits="HMS.Batch.BatchVerify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Batch Verify
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" ID="lnkMenu" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink></div>
    <center>
        <asp:Label runat="server" ID="lblHeader">BATCH VERIFY</asp:Label><br />
        &nbsp;</center>

    <table>
        <tr>
            <td>
                <asp:PlaceHolder runat="server" ID="placeAcronym" Visible="true">
                    <asp:Label runat="server" ID="lblAcronym" Text="Batch Number:"></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtBatch"></asp:TextBox>&nbsp;&nbsp;
                </asp:PlaceHolder>
                &nbsp;&nbsp;<asp:Button runat="server" ID="btnSearch" Text="Search" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:GridView  Width="100%" runat="server" ID="grdBatch" AutoGenerateColumns="False" AllowPaging="True"
        AllowSorting="True" GridLines="None" DataKeyNames="TrNo"
        OnPageIndexChanging="grdBatch_PageIndexChanging" PageSize="20" CssClass="tablebody" AlternatingRowStyle-CssClass="altRow" SelectedRowStyle-CssClass="selRow" OnRowDataBound="grdBatch_RowDataBound">
        <Columns>
            <asp:BoundField DataField="TrNo" HeaderText="Tr No">
                <ItemStyle Wrap="False" HorizontalAlign="Right"/>
            </asp:BoundField>
            <asp:BoundField DataField="TrDate" HeaderText="Tr Date" DataFormatString="{0:d}">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="PatNo" HeaderText="Patient No">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Vis" HeaderText="Visit">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="NumCde" HeaderText="Num Cde" >
                <ItemStyle Wrap="False" HorizontalAlign="Right"/>
            </asp:BoundField>
            <asp:BoundField DataField="ProCed" HeaderText="Pro Ced">
                <ItemStyle Wrap="False" HorizontalAlign="Right"/>
            </asp:BoundField>
            <asp:BoundField DataField="Qty" HeaderText="Qty">
                <ItemStyle Wrap="False" HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Amt" HeaderText="Amount">
                <ItemStyle Wrap="False" HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Pt" HeaderText="PT">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Loc" HeaderText="LOC">
                <ItemStyle Wrap="False" HorizontalAlign="Right"/>
            </asp:BoundField>
            <asp:BoundField DataField="TRC" HeaderText="TRC">
                <ItemStyle Wrap="False" HorizontalAlign="Right"/>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>

