<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="CatsReportingSystem.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        ClientID:
        <asp:TextBox ID="txtClientID" runat="server"></asp:TextBox>
    </div>
    <div>
        SIN:
        <asp:TextBox ID="txtSIN" runat="server" placholder="Enter SIN"></asp:TextBox>
    </div>
    <div>
        First Name:
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter First Name"></asp:TextBox>
    </div>
    <div>
        Last Name:
        <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter Last Name"></asp:TextBox>
    </div>
    <div>
        Date of Birth:
        <asp:TextBox ID="txtDateofBirth" runat="server" placeholder="Enter Date Of Birth"></asp:TextBox>
    </div>
    <asp:Button ID="btnUpdate" runat="server" Text="Update Client" />
</asp:Content>
