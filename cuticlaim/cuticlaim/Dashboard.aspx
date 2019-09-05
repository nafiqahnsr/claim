<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.vb" Inherits="cuticlaim.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div id="picture">
        <img src="/images/hi.png" style="width:400px;height:200px;"/>
    </div>
    <br /> <br />
    <div class="container">
        <div class="row">
                <div class="col-10">
                <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" class="table table-striped table-bordered" cellspacing="0" width="100%">
                    <Columns>
                        <asp:BoundField DataField="staff_fullname" HeaderText="Name" ItemStyle-Width="700px"/>
                        <asp:BoundField DataField="staff_id" HeaderText="Staff ID" ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center"/>
                        <asp:TemplateField HeaderText="Position" ItemStyle-Width="200px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:label ID ="lbl_position" runat="server"></asp:label>
                            </ItemTemplate> 
                        </asp:TemplateField>
                        <asp:BoundField DataField="staff_phone_num" HeaderText="Phone Number" ItemStyle-Width="120px" ItemStyle-HorizontalAlign="Center"/>
                        <asp:TemplateField HeaderText="Action" ItemStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" class="grid-action-icon glyphicon glyphicon-edit"/>
                        </ItemTemplate> 
                            </asp:TemplateField>

                    </Columns>
                </asp:GridView>
                    </div>

        </div>
    </div>
    
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
