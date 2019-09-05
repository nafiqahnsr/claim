<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="pendingClaim.aspx.vb" Inherits="cuticlaim.pendingClaim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div style="display:none">
        <asp:TextBox ID="hdn_id" runat="server"></asp:TextBox>
        <asp:Button ID="btn_del" runat="server"/>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-10">
                <div class="form-group">
                    <%--<asp:HiddenField runat="server" ID="idx" />--%>
                    <asp:Label ID="lbl_error" runat="server"></asp:Label>

                    <label>Name</label>
                    <asp:TextBox ID="name" runat="server" class="form-control" Style="width:600px" ReadOnly="true"></asp:TextBox> 
                    
                    <label>Staff ID</label>
                    <asp:TextBox ID="txt_nostaff" runat="server" class="form-control" Style="width:600px" ReadOnly="true"></asp:TextBox>                       
                                
                    <span class="grid-action-icon glyphicon glyphicon-edit" data-toggle="tooltip" data-placement="top" data-original-title="down" />
                    <label>Date</label> 
                    <div class="controls">
                                
                        <div class="input-group date" style="width: 200px">
                            <asp:TextBox ID="reqdate" runat="server" class="form-control date-picker" data-date-format="dd/mm/yyyy" data-mask="99-99-9999"
                            data-bv-label="Claim Category" ReadOnly="true"></asp:TextBox>
                            <%--<input type="text" class="form-control date-picker"/>--%>
                            <div class="input-group-addon">
                                <span class="glyphicon glyphicon-th"></span>
                            </div>
                        </div>  
                        <label>Phone Number</label>
                        <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;" ReadOnly="true"></asp:TextBox>
                    
                        <label>Claim Category</label>
                        <asp:TextBox ID="txt_category" runat="server" class="form-control" Style="width:600px" ReadOnly="true"></asp:TextBox>

                        <%--<label>Claim Category</label>
                        <asp:Dropdownlist ID="ddl_category" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Claim Category">
                        </asp:Dropdownlist>--%>

                        <label>RM</label>
                        <asp:TextBox ID="valueRM" runat="server" class="form-control" Style="width:300px" ReadOnly="true"></asp:TextBox>

                        <label>Status</label>
                        <asp:Dropdownlist ID="ddl_status" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Status">
                        </asp:Dropdownlist>

                        <br />
                        <asp:Label ID ="label1" runat ="server"></asp:Label>

                    </div>
                </div>
            </div>

            <div class="col-md-12 text-center">
                <asp:LinkButton runat="server" ID="btnSubmitDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Submit"/>
            </div>
        </div>
    </div>
    <br /><br />
</asp:Content>