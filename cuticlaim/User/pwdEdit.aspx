<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="pwdEdit.aspx.vb" Inherits="cuticlaim.pwdEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mb-3">
                <asp:Label ID="lbl_error" runat="server"></asp:Label>
                <br />
                <label>Old Password</label>
                <asp:TextBox ID="txt_oldpwd" type="password" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>New Password</label>
                <asp:TextBox ID="txt_newpwd" type="password" runat="server" class="form-control" Style="width:300px"></asp:TextBox>  

                <label>Confirm Password</label>
                <asp:TextBox ID="txt_confirmpwd" type="password" runat="server" class="form-control" Style="width:300px"></asp:TextBox> 
            </div>
        </div>
    </div>
    <div class="col-md-12 text-center">
        <asp:LinkButton runat="server" ID="btnSubmitDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Submit"/>
    </div>
    <br /><br />
</asp:Content>
