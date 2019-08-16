﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="editStaff.aspx.vb" Inherits="cuticlaim.editStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class="row">
        <div class="col-sm-4">
            <div class="form-group">
                <asp:HiddenField runat="server" ID="idxstaff" />
                <asp:HiddenField runat="server" ID="idxstafforganisasi" />

                <label>Name</label>
                <asp:TextBox ID="name" runat="server" class="form-control" Style="width:300px"></asp:TextBox>                       
                                
                <label>Email</label>
                <asp:TextBox ID="email" runat="server" class="form-control" Style="width:300px"></asp:TextBox>                       
                                
                <label>Address</label>
                <asp:TextBox ID="address" TextMode="MultiLine" Rows="3" runat="server" class="form-control" Style="width:300px"></asp:TextBox>                       
                                
                <label>State</label>
                <div class="input-group">
                    <asp:DropDownList ID="state" runat="server" Style="width:200px"></asp:DropDownList>
                </div>

                <label>Poscode</label>
                <asp:TextBox ID="postcode" runat="server" class="form-control" Style="width:200px"></asp:TextBox>                       
                                
                <label>City</label>
                    <asp:TextBox ID="city" runat="server" class="form-control" Style="width:200px"></asp:TextBox>                
            </div>
        </div>

        <div class="col-sm-4">
            <div class="form-group">
                <label>IC/Passport Number</label>
                    <asp:TextBox ID="ic" runat="server" class="form-control" Style="width:250px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>                       
                                
                    <label>Staff ID</label>
                    <asp:TextBox ID="staffid" ReadOnly="true" runat="server" class="form-control" Style="width:250px"></asp:TextBox>                       
                                
                    <label>Position</label>
                    <asp:TextBox ID="Position1" ReadOnly="true" runat="server" class="form-control" Style="width:250px"></asp:TextBox>
                                                     
                                    
                    <label>Department</label>                
                    <asp:TextBox ID="dptmnt" ReadOnly="true" runat="server" class="form-control" Style="width:250px"></asp:TextBox>

                    <label>Report To</label>
                    <asp:TextBox ID="rpt_to1" ReadOnly="true" runat="server" class="form-control" Style="width:300px"></asp:TextBox>
                                    
                    <label>Staff Status</label>                                                         
                    <asp:TextBox ID="statuspkj" ReadOnly="true" runat="server" class="form-control" Style="width:300px"></asp:TextBox>                                                           
            </div>                                
        </div>
                            
        <div class="col-sm-4">
            <div class="form-group">
                <label>Phone Number(1)</label>
                <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>                       
            </div>
        </div>

    </div>   

</asp:Content>