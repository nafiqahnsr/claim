﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="claimListManager.aspx.vb" Inherits="cuticlaim.claimListManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function div_alert_msg_close() {
            $("#<%=div_alert_msg.ClientID%>").hide();
        }

        function confirm_delete(p_id) {
            try {
                $("#<%=hdn_id.ClientID%>").val(p_id);
                console.log(p_id);
                <%= ClientScript.GetPostBackEventReference(btn_del, "", True)%>
            } catch (err) {
                alert(err.message);
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <!-- Column - Content - Row - Alert Message - S -->
    <div class="row" style="margin-top: 0px">
        <div class="col-sm-12">
            <div class="alert alert-danger col-margin-bottom" id="div_alert_msg" runat="server">
                <a href="javascript:div_alert_msg_close();" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
    <!-- Column - Content - Row - Alert Message -E -->

    <div style="display:none">
        <asp:TextBox ID="hdn_id" runat="server"></asp:TextBox>
        <asp:Button ID="btn_del" runat="server"/>
    </div>

    <div class="container">
        <div class="row">
                <div class="col-10">
                    <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" class="table table-striped table-bordered" cellspacing="0" width="100%">
                        <Columns>
                            <asp:BoundField DataField="fullname" HeaderText="Name" ItemStyle-Width="300px"/>
                            <asp:BoundField DataField="staff_id" HeaderText="Staff ID" ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center"/> 
                            <asp:BoundField DataField="request_date" HeaderText="Date" ItemStyle-Width="250" ItemStyle-HorizontalAlign="Center"/>
                            <asp:BoundField DataField="claim_value" HeaderText="RM" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center"/>
                            <asp:TemplateField HeaderText="Status" ItemStyle-Width="200px" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:label ID ="lbl_status" runat="server"></asp:label>
                                </ItemTemplate> 
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action" ItemStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink_edit" runat="server"><span class="grid-action-icon glyphicon glyphicon-edit"/> </asp:HyperLink>
                                    <%--<a href="javascript:confirm_delete('<%#DataBinder.Eval(Container.DataItem, "idx") %>');"><span class="grid-action-icon glyphicon glyphicon-trash"/></a>--%>
                                </ItemTemplate> 
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
        </div>

        <div class="row">
            <div class ="col-sm-12">
                <asp:Label ID="lbl_NoRecord" runat="server" ForeColor="red"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
