<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:DropDownList ID="ddlUser" runat="server"></asp:DropDownList>
        <asp:Label ID="lblUserAccount" runat="server" ></asp:Label>
    </div>

</asp:Content>
