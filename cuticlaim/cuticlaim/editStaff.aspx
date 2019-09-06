<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="editStaff.aspx.vb" Inherits="cuticlaim.editStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <div class="form-group">
                    <asp:HiddenField runat="server" ID="idx" />
                    <asp:HiddenField runat="server" ID="idxstaff" />
                    <asp:HiddenField runat="server" ID="idxstafforganisasi" />

                    <asp:Label ID="lbl_error" runat="server"></asp:Label>

                    <label>Name</label>
                    <asp:TextBox ID="name" runat="server" class="form-control" Style="width:300px" ReadOnly="true"></asp:TextBox>                       
                                
                    <label>Email</label>
                    <asp:TextBox ID="email" runat="server" class="form-control" Style="width:300px"></asp:TextBox>                       
                                
                    <label>Address</label>
                    <asp:TextBox ID="address" TextMode="MultiLine" Rows="3" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                    
                    <label>State</label>
                    <asp:TextBox ID="state" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                                
                    <label>Postcode</label>
                    <asp:TextBox ID="postcode" runat="server" class="form-control" Style="width:200px"></asp:TextBox>                       
                                
                    <label>City</label>
                        <asp:TextBox ID="city" runat="server" class="form-control" Style="width:200px"></asp:TextBox>                
                </div>
            </div>

            <div class="col-sm-4">
                <div class="form-group">
                    <label>IC/Passport Number</label>
                        <asp:TextBox ID="ic" runat="server" class="form-control" Style="width:250px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;" ReadOnly="true"></asp:TextBox>                       
                                
                        <label>Staff ID</label>
                        <asp:TextBox ID="staffid" ReadOnly="true" runat="server" class="form-control" Style="width:250px"></asp:TextBox>                       
                                
                        <label>Position</label>
                        <asp:Dropdownlist ID="ddl_position" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Position"></asp:Dropdownlist>

                        <%--<label>Position</label>
                        <asp:TextBox ID="Position1" ReadOnly="true" runat="server" class="form-control" Style="width:250px"></asp:TextBox>--%>

                        <%--<label>Report To</label>
                        <asp:TextBox ID="rpt_to1" ReadOnly="true" runat="server" class="form-control" Style="width:300px"></asp:TextBox>--%>
                                    
                        <%--<label>Staff Status</label>                                                         
                        <asp:TextBox ID="statuspkj" ReadOnly="true" runat="server" class="form-control" Style="width:300px"></asp:TextBox> --%>
                    
                        <label>Phone Number</label>
                        <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>
                </div>                                
            </div>

            <div class="col-md-12 text-center">
                <asp:LinkButton runat="server" ID="btnSaveDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Save"/>
            </div>
        </div>
        </div>
    <br /><br />
</asp:Content>
