<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="claimList.aspx.vb" Inherits="cuticlaim.claimList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class="container">
        <div class="row">
                <div class="col-10">
                    <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
                        <Columns>
                            <asp:BoundField DataField="NAMA" HeaderText="Name" ItemStyle-Width="100%"/>
                            <asp:BoundField DataField="STAFF_ID" HeaderText="Staff ID"/>
                            <asp:BoundField DataField="role_jawatan" HeaderText="Date"/>
                            <asp:BoundField DataField="EMEL" HeaderText="RM"/>

                            <asp:TemplateField HeaderText="Action" ItemStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:Button ID="button1" runat="server" Text="Update"/>
                                    <asp:Button ID="button2" runat="server" Text="Status" />
                                    <%--<asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink>--%>
                                </ItemTemplate> 
                            </asp:TemplateField>
                        
                        </Columns>
                    </asp:GridView>
                </div>

        </div>
    </div>

</asp:Content>
