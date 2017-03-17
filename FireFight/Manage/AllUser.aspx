<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="AllUser.aspx.cs" Inherits="FireFight.Manage.AllUser" %>
<%@ Register src="../Controls/CtlUser.ascx" tagname="CtlUser" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <uc1:CtlUser ID="CtlUser1" runat="server" />

</asp:Content>
