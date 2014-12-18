<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Inquiry2.aspx.cs" Inherits="HMS.Inquiry.InqAcro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inquiry By Acronym
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="breadcrumb"><asp:HyperLink runat="server" id="lnkMenu" NavigateUrl="~/mainmenu.aspx">Main Menu</asp:HyperLink> > <asp:HyperLink runat="server" ID="lnkInquiry"  NavigateUrl="~/Inquiry/Inquiry.aspx">Inquiry Menu</asp:HyperLink></div>
    <center>
        <asp:Label runat="server" ID="lblHeader"></asp:Label><br />
        &nbsp;</center>

    <table>
        <tr>
            <td>
                <asp:PlaceHolder runat="server" ID="placeAcronym" Visible="false">
                    <asp:Label runat="server" ID="lblAcronym" Text="Patient's Acronym:"></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtAcronym"></asp:TextBox>&nbsp;&nbsp;
                <asp:Label runat="server" ID="lblAcronymFirstName" Text="First Name:"></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtAcronymFirstName"></asp:TextBox>&nbsp;&nbsp;
                <asp:Label runat="server" ID="lblAcronymDOB" Text="DOB:"></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtAcronymDOB"></asp:TextBox>
                </asp:PlaceHolder>
                <asp:PlaceHolder runat="server" ID="placePolicy" Visible="false">
                    <asp:Label runat="server" ID="lblPolicy" Text="Policy Number"></asp:Label>&nbsp;
                    <asp:TextBox runat="server" ID="txtPolicy"></asp:TextBox>
                </asp:PlaceHolder>
                <asp:PlaceHolder runat="server" ID="placeSSN" Visible="false">
                    <asp:Label runat="server" ID="lblSSN" Text="Social Security Number"></asp:Label>&nbsp;
                    <asp:TextBox runat="server" ID="txtSSN"></asp:TextBox>
                </asp:PlaceHolder>
                <asp:PlaceHolder runat="server" ID="placeMRN" Visible="false">
                    <asp:Label runat="server" ID="lblMRN" Text="Patient's Medical Record Number"></asp:Label>&nbsp;
                    <asp:TextBox runat="server" ID="txtMRN"></asp:TextBox>
                </asp:PlaceHolder>
                &nbsp;&nbsp;<asp:Button runat="server" ID="btnSearch" Text="Search" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:GridView runat="server" ID="grdInquiry" AutoGenerateColumns="False" AllowPaging="True"
        AllowSorting="True" AutoGenerateSelectButton="True" GridLines="None"
        OnPageIndexChanging="grdInquiryByAcronym_PageIndexChanging" PageSize="20" CssClass="tablebody" AlternatingRowStyle-CssClass="altRow" SelectedRowStyle-CssClass="selRow">
        <Columns>
            <asp:BoundField DataField="AccountNumber" HeaderText="Acct#">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Sex" HeaderText="Sex">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="DRNO" HeaderText="DRNO">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="DOB" HeaderText="DOB" DataFormatString="{0:d}">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="LastVisit" HeaderText="Last Visit" DataFormatString="{0:d}">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Balance" HeaderText="Balance">
                <ItemStyle Wrap="False" HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Address1" HeaderText="Address1">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Address2" HeaderText="Address2">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="City">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="State" HeaderText="State">
                <ItemStyle Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Zip" HeaderText="Zip">
                <ItemStyle Width="20px" Wrap="False" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
