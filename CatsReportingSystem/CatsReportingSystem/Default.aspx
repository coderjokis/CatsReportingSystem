<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:DropDownList ID="ddlUser" runat="server"></asp:DropDownList>
        <asp:TextBox ID="txtUserAccount" runat="server"></asp:TextBox>
    </div>

</asp:Content>
