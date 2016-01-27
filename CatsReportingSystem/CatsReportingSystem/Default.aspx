<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:DropDownList ID="ddlUser" runat="server"></asp:DropDownList>
        <asp:Button ID="btnSelect" runat="server" Text="Select Councilor" OnClick="btnSelect_Click" />
        <asp:Label ID="lblUserAccount" runat="server" ></asp:Label>
    </div>

</asp:Content>
