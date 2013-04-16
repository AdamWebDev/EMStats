<%@ Page Title="Review Stats" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="EMStats.Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:DropDownList ID="ddMonth" runat="server" /> <asp:DropDownList ID="ddYear" runat="server" /> <asp:Button ID="btnSubmit" runat="server" Text="Get Entries" CssClass="btn" />

    <asp:Repeater ID="rptStats" runat="server" Visible="true">
        <HeaderTemplate>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">Call Number</th>
                        <th scope="col">Time</th>
                        <th scope="col">CTAS</th>
                        <th scope="col">Call Type</th>
                        <th scope="col">Edit</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <th scope="row"><asp:Literal ID="ltCallNumber" runat="server" Text='<%# Eval("CallNumber") %>'/></th>
                <td><asp:Literal ID="ltDiff" runat="server" Text='<%# SecondstoHours(Eval("TDiff")) %>' /></td>
                <td><asp:Literal ID="ltCTAS" runat="server" Text='<%# Eval("CTAS") %>' /></td>
                <td><asp:Literal ID="ltCallType" runat="server" Text='<%# Eval("CallType") %>' /></td>
                <td><asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# String.Format("Edit.aspx?ID={0}",Eval("ID")) %>'>Edit</asp:HyperLink></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
