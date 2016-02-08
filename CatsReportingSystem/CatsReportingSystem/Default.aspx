<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatsReportingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-3 col-md-3 col-sm-4 col-xs-12">
            <h2>Search Client</h2>

            <div class="input-group padBot">
                <span class="input-group-addon">Client ID:</span>
                <asp:TextBox ID="txtClientID" runat="server" placeholder="ClientID:" CssClass="form-control" TextMode="Number"></asp:TextBox>

            </div>

            <div class="input-group padBot">
                <span class="input-group-addon">SIN:</span>
                <asp:TextBox ID="txtSIN" runat="server" placeholder="SIN:" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>

            <div class="input-group padBot">
                <span class="input-group-addon">First Name:</span>
                <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name:" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="input-group padBot">
                <span class="input-group-addon">Last Name:</span>
                <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name:" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon">Birth Year:</span>
                <asp:TextBox ID="txtDateofBirth" runat="server" placeholder="Year of Birth:" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <asp:RegularExpressionValidator ID="rgxYear" runat="server" ControlToValidate="txtDateofBirth" ValidationExpression="^(19|20)\d{2}$" ErrorMessage="Enter a Valid Year"></asp:RegularExpressionValidator>
            <div class="input-group">
                <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" CssClass="btn btn-primary" />
            </div>

        </div>
        <div class="col-lg-9 col-md-9 col-sm-8 col-xs-12">
            <h4>
                <asp:Label ID="lblSearchResult" runat="server" Visible="false" /></h4>
            <div>
                <asp:ListView ID="lvClientSearch" runat="server" OnPagePropertiesChanging="lvClientSearch_PagePropertiesChanging" OnSorting="lvClientSearch_Sorting">
                    <LayoutTemplate>
                        <table class="table">
                            <thead runat="server" visible='<%# (int)DataBinder.Eval(Container,"DataItemIndex")==0 %>'>
                                <th style="width:75px;">
                                    <asp:LinkButton ID="lbClientIDSort" Text="ClientID" runat="server" CommandName="sort" CommandArgument="ID" />
                                </th>
                                <th>
                                    <asp:LinkButton ID="lbSinSort" Text="SIN Number" runat="server" CommandName="sort" CommandArgument="SIN" />
                                </th>
                                <th>
                                    <asp:LinkButton ID="lbLastNameSort" Text="Last Name" runat="server" CommandName="sort" CommandArgument="LastName" />
                                </th>
                                <th>
                                    <asp:LinkButton ID="lbFirstNameSort" Text="First Name" runat="server" CommandName="sort" CommandArgument="FirstName" />
                                </th>
                                <th>
                                    <asp:LinkButton ID="lbDobSort" Text="Date of Birth" runat="server" CommandName="sort" CommandArgument="DOB" /></th>
                                <th>
                                    <asp:LinkButton ID="lbLock" Text="Lock" runat="server" /></th>
                            </thead>
                            
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                            <tr>
                                <td>
                                    <asp:DataPager runat="server" ID="dpClientSearch" PagedControlID="lvClientSearch" PageSize="10">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="previous" />
                                            <asp:NumericPagerField ButtonType="Link" CurrentPageLabelCssClass="active" />
                                            <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" ButtonCssClass="next" />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="col-lg-12 col-md-12">
                            <tr>
                                <td style="width:75px;"><%#Eval("ID")%></td>
                                <td><%#Eval("SIN")%></td>
                                <td><%#Eval("LastName")%></td>
                                <td><%#Eval("FirstName")%></td>
                                <td><%#Eval("DOB","{0:d/MM/yyyy}")%></td>
                               <%--<td><%#Eval("Lock") %></td>--%>
                                <%--<td><image id="imgLock" src="images/Padlock.ico" height="24px;" visibility='<%#Eval("Lock").Val == 1 ? "hidden" : "visible" %>'></image></td>--%>
                                <td><asp:Image ID="imgLock" runat="server" ImageUrl="images/Padlock.ico" 
                                       Visible='<%#(Eval("Lock")!=null && (string)Eval("Lock")=="True") ? true : false %>' Height="24px" /></td>
                                <%--<td><span class="glyphicon glyphicon-lock"></span></td>
                                <%--<td><%#Eval("Lock")!=null &&(bool)Eval("Lock") ? " ":"&lt;span class=&#34;glyphicon glyphicon-lock;&#34;&gt;&lt;/span&gt;" %></td>--%>
                                <%--<td><%#Eval("Lock")!=null &&(bool)Eval("Lock") ? " ": "&lt;span class=&#34;glyphicon glyphicon-lock;&#34;&gt;&lt;&#47span&gt;" %></td>--%>

                            <%--!=null &&(bool)Eval("Lock")? "glyphicon glyphicon-lock;" : "display:none;"%>"></span></td>--%>
                            </tr>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
        <asp:GridView ID="gvDatatest" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="Name" />
                <asp:BoundField DataField="Lock" HeaderText="Lock"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
