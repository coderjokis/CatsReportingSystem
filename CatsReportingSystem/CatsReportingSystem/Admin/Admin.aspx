<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="CatsReportingSystem.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvUsers" DataKeyNames="UserID" AutoGenerateColumns="false" runat="server" OnRowCommand="gvUsers_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Upd" Text="Update" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="UserName" HeaderText="UserName" />
        </Columns>
    </asp:GridView>
    <div>
        UserID:
        <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
    </div>
    <div>
        UserName:
        <asp:TextBox ID="txtUsername" runat="server" placholder=" Enter UserName"></asp:TextBox>
    </div>
    <asp:Button ID="btnUpdate" runat="server" Text="Update User" OnClick="btnUpdate_Click" />
    <br />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>
