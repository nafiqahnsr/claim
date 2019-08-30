<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="addUser.aspx.vb" Inherits="cuticlaim.addUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-md-6 mb-3">
                <label>Name</label>
                <asp:TextBox ID="name" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>User ID</label>
                <asp:TextBox ID="userID" runat="server" class="form-control" Style="width:300px"></asp:TextBox>  

                <label>Staff ID</label>
                <asp:TextBox ID="staffID" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>Email</label>
                <asp:TextBox ID="email" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                    
                <label>Password</label>
                <asp:TextBox ID="pass" type="password" runat="server" class="form-control" Style="width:300px"></asp:TextBox>  
                                
                <label>Phone Number</label>
                <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>
            </div>

            <div class="col-md-6 mb-3">
                <label>IC</label>
                    <asp:TextBox ID="noic" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                
                <label>Position</label>
                    <asp:Dropdownlist ID="ddl_position" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Position"></asp:Dropdownlist>

                <label>Address</label>
                    <asp:TextBox ID="address" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>Postcode</label>
                    <asp:TextBox ID="postcode" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>City</label>
                    <asp:TextBox ID="city" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                <label>State</label>
                    <asp:TextBox ID="state" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
            </div>
                    
        </div>
    </div>
    <br /><br />
    <div class="col-md-12 text-center">
        <asp:LinkButton runat="server" ID="btnSubmitDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Submit"/>
    </div>
        
    <br /><br />

</asp:Content>
