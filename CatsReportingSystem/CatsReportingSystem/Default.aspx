<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-3 col-md-3 col-sm-3">
            <h2>Search Client</h2>

            <div class="input-group">
                <span class="input-group-addon">Client ID:</span>
                <asp:TextBox ID="txtClientID" runat="server" placeholder="ClientID:" CssClass="form-control"></asp:TextBox>

            </div>

            <div class="input-group">
                <span class="input-group-addon">SIN:</span>
                <asp:TextBox ID="txtSIN" runat="server" placeholder="SIN:" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon">First Name:</span>
                <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name:" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon">Last Name:</span>
                <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name:" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon">DOB:</span>
                <asp:TextBox ID="txtDateofBirth" runat="server" placeholder="Date of Birth:" CssClass="form-control"></asp:TextBox>
            </div>

            
        </div>
        <div class="col-lg-10 col-md-10 col-sm-9 main">
        </div>
    </div>

</asp:Content>
