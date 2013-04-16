<%@ Page Title="Review Stats" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="EMStats.Review" %>
<%@ Register Src="~/WarningIcon.ascx" TagPrefix="uc1" TagName="WarningIcon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <p>Filter by...</p>
    <div class="filters">
        <asp:Label ID="lblMonth" runat="server" Text="Month:" AssociatedControlID="ddMonth"></asp:Label><asp:DropDownList ID="ddMonth" runat="server" />
        <asp:Label ID="lblYear" runat="server" Text="Year:" AssociatedControlID="ddYear"></asp:Label><asp:DropDownList ID="ddYear" runat="server" /> <asp:Button ID="btnSubmit" runat="server" Text="Get Entries" CssClass="btn" />
    </div>
    
    <asp:Repeater ID="rptStats" runat="server" Visible="true" OnItemDataBound="rptStats_ItemDataBound">
        <HeaderTemplate>
            <table class="table table-striped review-table">
                <thead>
                    <tr>
                        <th scope="col">Call Number</th>
                        <th scope="col">Time</th>
                        <th scope="col">CTAS</th>
                        <th scope="col">Call Type</th>
                        <th scope="col">Actions</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr class="summary">
                <th scope="row"><asp:Literal ID="ltCallNumber" runat="server" Text='<%# Eval("CallNumber") %>'/></th>
                <td><asp:Literal ID="ltDiff" runat="server" Text='<%# SecondstoHours(Eval("TDiff")) %>' /><asp:Literal ID="rawDiff" runat="server" Text='<%# Eval("TDiff") %>' Visible="false" /></td>
                <td><asp:Literal ID="ltCTAS" runat="server" Text='<%# Eval("CTAS") %>' /></td>
                <td><asp:Literal ID="ltCallType" runat="server" Text='<%# Eval("CallType") %>' /></td>
                <td><a href="#" class="showdetails">More</a> | <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# String.Format("Edit.aspx?ID={0}",Eval("ID")) %>'>Edit</asp:HyperLink>
                <uc1:WarningIcon runat="server" ID="WarningIcon" Visible="false" />
                </td>
                
            </tr>
            <tr class="details">
                <td colspan="5">
                    <ul>
                        <li><span>T2:</span> <asp:Literal ID="ltT1" runat="server" Text='<%# Eval("T2") %>' /></li>
                        <li><span>T3:</span> <asp:Literal ID="ltT2" runat="server" Text='<%# Eval("T3") %>' /></li>
                        <li><span>T4:</span> <asp:Literal ID="ltT3" runat="server" Text='<%# Eval("T4") %>' /></li>
                        <li><span>VSA:</span> <asp:Literal ID="ltVSA" runat="server" Text='<%# Eval("VSA") %>' /></li>
                        <li><span>Symptom Relief:</span> <asp:Literal ID="ltSymptomRelief" runat="server" Text='<%# Eval("SymptomRelief") %>' /></li>
                        <li><span>IV Attempt:</span> <asp:Literal ID="ltIVAttempt" runat="server" Text='<%# Eval("IVAttempt") %>' /></li>
                        <li><span>Date Entered:</span> <asp:Literal ID="ltDateEntered" runat="server" Text='<%# Eval("DateEntered") %>' /></li>
                        <li><span>Entered By:</span> <asp:Literal ID="ltEnteredBy" runat="server" Text='<%# Eval("EnteredBy") %>' /></li>
                    </ul>
                    
                </td>
            </tr>
            
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
