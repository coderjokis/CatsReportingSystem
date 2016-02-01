<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row marTop">
        <div class="col-lg-2 col-md-2 col-sm-3">
            <ul class="nav nav-pills nav-stacked text-center">
                <li class="active"><a href="#pnlContent1" data-toggle="tab">content </a></li>
                <li><a href="#pnlContent2" data-toggle="tab">content </a></li>
                <li><a href="#pnlContent3" data-toggle="tab">content</a></li>

                <li><a href="#pnlContent4" data-toggle="tab">content</a></li>
                <li><a href="#pnlContent5" data-toggle="tab">content</a></li>
                <li><a href="#pnlContent6" data-toggle="tab">content</a></li>

                <li><a href="#pnlContent7" data-toggle="tab">content</a></li>
                <li><a href="#pnlContent8" data-toggle="tab">content</a></li>
                <li><a href="#pnlContent9" data-toggle="tab">content</a></li>
            </ul>
        </div>
        <div class="col-lg-10 col-md-10 col-sm-9 main">
            <div class="panel panel-default" id="pnlContent1">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent2">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent3">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent4">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent5">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent6">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent7">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent8">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
            <div class="panel panel-default" id="pnlContent9">
                <div class="panel-body">
                    Basic panel example
                </div>
            </div>
        </div>
    </div>
    <div>
            ClientID:
            <asp:TextBox ID="txtClientID" runat="server" placeholder="ClientID:"></asp:TextBox>
        </div>
        <div>
            SIN:
            <asp:TextBox ID="txtSIN" runat="server" placeholder="SIN:"></asp:TextBox>
        </div>
        <div>
            First Name:
            <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name:"></asp:TextBox>
        </div>
        <div>
            Last Name:
            <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name:"></asp:TextBox>
        </div>
        <div>
            Date of Birth:
            <asp:TextBox ID="txtDateofBirth" runat="server" placeholder="Date of Birth:"></asp:TextBox>
        </div>
</asp:Content>
