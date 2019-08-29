<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="claim.aspx.vb" Inherits="cuticlaim.claim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function Ctrl() {

            console.log('bla');
            //--Bootstrap Date Picker--
            $('.date-picker').datepicker();

        }

        $(document).ready(function () {
            Ctrl();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-10">
                <div class="form-group">
                    <asp:HiddenField runat="server" ID="idx" />
                    <asp:HiddenField runat="server" ID="idxstaff" />
                    <asp:HiddenField runat="server" ID="idxstafforganisasi" />

                    <asp:Label ID="lbl_error" runat="server"></asp:Label>

                    <label>Name</label>
                    <asp:TextBox ID="name" runat="server" class="form-control" Style="width:600px" ReadOnly="true"></asp:TextBox>                       
                                
                    <span class="grid-action-icon glyphicon glyphicon-edit" data-toggle="tooltip" data-placement="top" data-original-title="down" />
                    <label>Date</label> 
                    <div class="controls">
                                
                       <div class="input-group date" style="width: 200px">
                            <input type="text"  class="form-control date-picker"  />
                            <div class="input-group-addon">
                                <span class="glyphicon glyphicon-th"></span>
                            </div>
                        </div>  
                        <label>Phone Number</label>
                        <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;"></asp:TextBox>
                    
                        <label>Claim Category</label>
                        <asp:Dropdownlist ID="category" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Claim Category">
                            <asp:ListItem Text="Select Category" Value="-1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="MILEAGE" Value="1"></asp:ListItem>
                            <asp:ListItem Text="TAXI / GRAB / PUBLIC TRANSPORT" Value="2"></asp:ListItem>
                            <asp:ListItem Text="PARKING" Value="3"></asp:ListItem>
                            <asp:ListItem Text="FUEL (COMPANY CAR ONLY)" Value="4"></asp:ListItem>
                            <asp:ListItem Text="ACCOMODATION LODGING" Value="5"></asp:ListItem>
                            <asp:ListItem Text="ALLOWANCES" Value="6"></asp:ListItem>
                            <asp:ListItem Text="ENTERTAINMENT" Value="7"></asp:ListItem>
                            <asp:ListItem Text="MEDICAL" Value="8"></asp:ListItem>
                            <asp:ListItem Text="DENTAL" Value="9"></asp:ListItem>
                            <asp:ListItem Text="OTHERS / MISCELLANEOUS" Value="10"></asp:ListItem>
                        </asp:Dropdownlist>

                        <label>RM</label>
                        <asp:TextBox ID="valueRM" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                        <br />
                        <asp:Label ID ="label1" runat ="server"></asp:Label>

                </div>
            </div>

            <div class="col-md-12 text-center">
                <asp:LinkButton runat="server" ID="btnSubmitDetails" class="btn btn-primary" Text="<i class='fa fa-save'></i>Submit"/>
            </div>
        </div>
        </div>
    <br /><br />
</asp:Content>
