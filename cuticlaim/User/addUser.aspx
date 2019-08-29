<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="addUser.aspx.vb" Inherits="cuticlaim.addUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-10">
                <div class="form-group">
                    <asp:HiddenField runat="server" ID="idx" />
                    <asp:HiddenField runat="server" ID="idxstaff" />

                    <%--<asp:Label ID="lbl_error" runat="server"></asp:Label>--%>

                    <label>Name</label>
                    <asp:TextBox ID="name" runat="server" class="form-control" Style="width:600px"></asp:TextBox>  
                    
                    <label>Email</label>
                    <asp:TextBox ID="email" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                                
                    <label>User ID</label>
                    <asp:TextBox ID="userID" runat="server" class="form-control" Style="width:300px"></asp:TextBox>  

                    <label>Staff ID</label>
                    <asp:TextBox ID="staffID" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                    
                    <label>Password</label>
                    <asp:TextBox ID="pass" type="password" runat="server" class="form-control" Style="width:300px"></asp:TextBox>  
                                
                    <%--<label>Phone Number</label>
                    <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>--%>
                    
                    <asp:Label ID="lbl_newPass" runat="server"></asp:Label>

                </div>
            </div>

            <div class="col-md-12 text-center">
                <asp:LinkButton runat="server" ID="btnSubmitDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Submit"/>
            </div>
        </div>
        </div>
    <br /><br />

</asp:Content>
