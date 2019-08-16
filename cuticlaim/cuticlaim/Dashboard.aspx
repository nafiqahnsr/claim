<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.vb" Inherits="cuticlaim.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Dashboard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div id="picture">
        <img src="/images/hi.png" style="width:400px;height:200px;"/>
        </div>
    <h1 style="background-color:antiquewhite;">Mindwave Consultancy</h1>

    <ul>
      <li><a class="active" href="#home">Home</a></li>
      <li><a href="#news">News</a></li>
      <li><a href="#contact">Contact</a></li>
    </ul>
    <br />
        <div>
        </div>

            <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
                <Columns>
                    <asp:BoundField DataField="NAMA" HeaderText="Name" ItemStyle-Width="400" />
                    <asp:BoundField DataField="STAFF_ID" HeaderText="Staff ID" ItemStyle-Width="80" />
                    <asp:BoundField DataField="role_jawatan" HeaderText="Position" ItemStyle-Width="100" />
                    <asp:BoundField DataField="EMEL" HeaderText="Email" ItemStyle-Width="180" />
                    <asp:BoundField DataField="TEL1" HeaderText="Phone Number" ItemStyle-Width="150" />

                    <asp:TemplateField HeaderText="Action" ItemStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink>
                    </ItemTemplate> 
                        </asp:TemplateField>

                </Columns>
            </asp:GridView>
    </asp:Content>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadPageScriptContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="NAMA" HeaderText="Name" ItemStyle-Width="100" />
                    <asp:BoundField DataField="STAFF_ID" HeaderText="Staff ID" ItemStyle-Width="150" />
                    <asp:BoundField DataField="role_jawatan" HeaderText="Position" ItemStyle-Width="150" />
                    <asp:BoundField DataField="EMEL" HeaderText="Email" ItemStyle-Width="150" />
                    <asp:BoundField DataField="TEL1" HeaderText="Phone Number" ItemStyle-Width="150" />
                </Columns>
            </asp:GridView>
    </form>
</asp:Content>--%>
