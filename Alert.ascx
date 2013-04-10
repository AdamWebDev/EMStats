<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Alert.ascx.cs" Inherits="EMStats.Alert" %>
<asp:Panel ID="pnAlert" runat="server" CssClass="alert">
  <button type="button" class="close" data-dismiss="alert">&times;</button>
  <asp:Literal runat="server" ID="ltMessage" Text="This is an alert" />
</asp:Panel>