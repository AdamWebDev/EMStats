<%@ Page Title="Edit Record" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="EMStats.Edit" %>
<%@ Register src="Alert.ascx" tagname="Alert" tagprefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %></h1>

    <uc:Alert ID="Alert1" runat="server" Visible="false" />

<article id="maincontent" role="main">
<div class="row">
        <div class="span6">
            <asp:Label ID="lblDate" runat="server" Text="Date (MMDDYYYY)" AssociatedControlID="txtDate"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server" CssClass="date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqDate" runat="server" ErrorMessage="Please enter a Date." ControlToValidate="txtDate" Display="Static" CssClass="alert alert-error"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="valServerDate" runat="server" ErrorMessage="Please enter a valid date." Type="Date"  ControlToValidate="txtDate" Operator="DataTypeCheck" CssClass="alert alert-error" Display="Static"></asp:CompareValidator>

        </div>
        <div class="span6">

            <asp:Label ID="lblCallNumber" runat="server" Text="Call Number" AssociatedControlID="txtCallNumber"></asp:Label>
            <asp:TextBox ID="txtCallNumber" runat="server" CssClass="callnumber"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqCallNumber" runat="server" ErrorMessage="Please enter a call number." ControlToValidate="txtCallNumber" CssClass="alert alert-error" Display="Dynamic"></asp:RequiredFieldValidator>
            
        </div>
</div>
<div class="row">
        <div class="span6">

            <asp:Label ID="lblT2" runat="server" Text="T2 (HHMMSS)" AssociatedControlID="txtT2"></asp:Label>
            <asp:TextBox ID="txtT2" runat="server" CssClass="time t2"></asp:TextBox>
            <asp:CustomValidator ID="valT2" runat="server" ErrorMessage="Please enter a valid time for T2." ControlToValidate="txtT2" ClientValidationFunction="CheckTime" ValidateEmptyText="true" CssClass="alert alert-error" Display="Static"></asp:CustomValidator>

        </div>
        <div class="span6">

            <asp:Label ID="lblT3" runat="server" Text="T3 (HHMMSS)" AssociatedControlID="txtT3"></asp:Label>
            <asp:TextBox ID="txtT3" runat="server" CssClass="time"></asp:TextBox>
            <asp:CustomValidator ID="valT3" runat="server" ErrorMessage="Please enter a valid time for T3." ControlToValidate="txtT3" ClientValidationFunction="CheckTime" ValidateEmptyText="true" CssClass="alert alert-error" Display="Static"></asp:CustomValidator>

        </div>
        <div class="span6">

            <asp:Label ID="lblT4" runat="server" Text="T4 (HHMMSS)" AssociatedControlID="txtT4"></asp:Label>
            <asp:TextBox ID="txtT4" runat="server" CssClass="time t4"></asp:TextBox>
            <asp:CustomValidator ID="valT4" runat="server" ErrorMessage="Please enter a valid time for T4." ControlToValidate="txtT4" ClientValidationFunction="CheckTime" ValidateEmptyText="true" CssClass="alert alert-error" Display="Static"></asp:CustomValidator>

        </div>
        <div class="span6">

                <asp:Label ID="lblTDiff" runat="server" Text="T2-T4" AssociatedControlID="txtTDiff"></asp:Label>
                <asp:TextBox ID="txtTDiff" runat="server" Enabled="false" CssClass="timediff"></asp:TextBox>
                
        </div>
    </div>
    <div class="row">
        <div class="span6">

                <asp:Label ID="lblCTAS" runat="server" Text="CTAS" AssociatedControlID="ddCTAS"></asp:Label>
                <asp:DropDownList ID="ddCTAS" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="reqCTAS" runat="server" ErrorMessage="Please enter a CTAS." ControlToValidate="ddCTAS" CssClass="alert alert-error" Display="Static"></asp:RequiredFieldValidator>
        </div>

        <div class="span6">
            <asp:Label ID="lblCallType" runat="server" Text="Call Type" AssociatedControlID="ddCallType"></asp:Label>
            <asp:DropDownList ID="ddCallType" runat="server" AppendDataBoundItems="true" CssClass="CallType">
                <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="reqCallType" runat="server" ErrorMessage="Please enter a call type." ControlToValidate="ddCallType" CssClass="alert alert-error" Display="Static"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row">
        
        <div class="span6">
            <asp:Label ID="lblVSA" runat="server" Text="VSA" AssociatedControlID="ddVSA"></asp:Label>
            <asp:DropDownList ID="ddVSA" runat="server" AppendDataBoundItems="true"></asp:DropDownList>
            <asp:CustomValidator ID="valVSA" runat="server" ErrorMessage="VSA cannot be None." ControlToValidate="ddVSA" ClientValidationFunction="validVSA" CssClass="alert alert-error" Display="Static"></asp:CustomValidator>
        
        </div>
        <div class="span6">

            <asp:Label ID="lblSymptomRelief" runat="server" Text="Symptom Relief" AssociatedControlID="ddSymptomRelief"></asp:Label>
            <asp:DropDownList ID="ddSymptomRelief" runat="server" AppendDataBoundItems="true"></asp:DropDownList>

        </div>

    </div>

    <div class="row">

        <div class="span6">
            <asp:Label ID="lblIVAttempt" runat="server" Text="IV Attempt" AssociatedControlID="ddIVAttempt"></asp:Label>
            <asp:DropDownList ID="ddIVAttempt" runat="server" AppendDataBoundItems="true"></asp:DropDownList>
        </div>
        <div class="span6">
            <asp:HiddenField ID="hdnID" runat="server" />

            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Save" CssClass="btn btn-primary btn-large" OnClick="btnSubmit_Click"   />
        </div>
    </div>

    


</article>    
</asp:Content>
