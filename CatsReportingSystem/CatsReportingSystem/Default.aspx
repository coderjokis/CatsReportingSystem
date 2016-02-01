<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-3 col-md-3 col-sm-4 col-xs-12">
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
            <div>
                <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" CssClass="btn btn-primary btn-lg" />
            </div>

        </div>
        <div class="col-lg-9 col-md-9 col-sm-8 col-xs-12">
            
            <asp:GridView ID="gvClientSearch" runat="server" AllowPaging="True" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Yellow" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ClientID" HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White">
                        <HeaderStyle BackColor="Black" ForeColor="White"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="SIN" HeaderText="S.I.N." HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White">
                        <HeaderStyle BackColor="Black" ForeColor="White"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White">
                        <HeaderStyle BackColor="Black" ForeColor="White"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="LastName" HeaderText="LastName" HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White">
                        <HeaderStyle BackColor="Black" ForeColor="White"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White">
                        <HeaderStyle BackColor="Black" ForeColor="White"></HeaderStyle>
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </div>

</asp:Content>
