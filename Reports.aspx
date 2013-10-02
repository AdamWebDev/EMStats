<%@ Page Title="Reports" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="EMStats.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row report-filter">
        <div class="form-group span4">
            <asp:Label ID="lblStartMonth" runat="server" Text="Start Month:" AssociatedControlID="ddStartMonth"></asp:Label><asp:DropDownList ID="ddStartMonth" runat="server" CssClass="span4" />
            <asp:Label ID="lblStartYear" runat="server" Text="Start Year:" AssociatedControlID="ddStartYear"></asp:Label><asp:DropDownList ID="ddStartYear" runat="server" CssClass="span4" /> 
        </div>
        <div class="form-group span4">
        <asp:Label ID="lblEndMonth" runat="server" Text="End Month:" AssociatedControlID="ddEndMonth"></asp:Label><asp:DropDownList ID="ddEndMonth" runat="server" CssClass="span4" />
        <asp:Label ID="lblEndYear" runat="server" Text="End Year:" AssociatedControlID="ddEndYear"></asp:Label><asp:DropDownList ID="ddEndYear" runat="server" CssClass="span4" /> 
        </div>

        <div class="span4">
            <asp:Button ID="btnSubmit" runat="server" Text="Get Report" CssClass="btn btn-primary btn-large btn-report" OnClick="btnSubmit_Click"  />
        </div>
     </div>

    <asp:PlaceHolder runat="server" ID="phResults" Visible="false">
        <table class="table report-table">
            <caption>Proposed EMS Response Time Targets - <asp:Literal runat="server" ID="ltTimeSpan"></asp:Literal></caption>
            <thead>
                <tr>
                    <th colspan="col">Type of Call</th>
                    <th colspan="col">Target Time</th>
                    <th colspan="col">Target Percentage</th>
                    <th colspan="col">Actual Total Calls</th>
                    <th colspan="col">Actual Percentage</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th colspan="row">a. Sudden Cardiac Arrest</th>
                    <td>Defibrillator Response<br />Six (6) minutes</td>
                    <td>50%</td>
                    <td><asp:Literal runat="server" ID="ltTotalSCA"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageSCA"></asp:Literal></td>
                </tr>
                <tr>
                    <th colspan="row">b. CTAS 1</th>
                    <td>Paramedic Response<br />Eight (8) minutes</td>
                    <td>50%</td>
                    <td><asp:Literal runat="server" ID="ltTotalCTAS1"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageCTAS1"></asp:Literal></td>
                </tr>
                <tr>
                    <th colspan="row">c. CTAS 2</th>
                    <td>Paramedic Response<br />13 minutes</td>
                    <td>90%</td>
                    <td><asp:Literal runat="server" ID="ltTotalCTAS2"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageCTAS2"></asp:Literal></td>
                </tr>
                <tr>
                    <th colspan="row">d. CTAS 3</th>
                    <td>Paramedic Response<br />13 minutes</td>
                    <td>90%</td>
                    <td><asp:Literal runat="server" ID="ltTotalCTAS3"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageCTAS3"></asp:Literal></td>
                </tr>
                <tr>
                    <th colspan="row">e. CTAS 4</th>
                    <td>Paramedic Response<br />20 minutes</td>
                    <td>90%</td>
                    <td><asp:Literal runat="server" ID="ltTotalCTAS4"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageCTAS4"></asp:Literal></td>
                </tr>
                <tr>
                    <th colspan="row">f. CTAS 5</th>
                    <td>Paramedic Response<br />30 minutes</td>
                    <td>90%</td>
                    <td><asp:Literal runat="server" ID="ltTotalCTAS5"></asp:Literal></td>
                    <td><asp:Literal runat="server" ID="ltPercentageCTAS5"></asp:Literal></td>
                </tr>

            </tbody>

        </table>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="phStart">
            <p>Please select a date range to report.</p>
        </asp:PlaceHolder>
</asp:Content>
