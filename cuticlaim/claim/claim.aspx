<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="claim.aspx.vb" Inherits="cuticlaim.claim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function Ctrl() {

            //--Bootstrap Date Picker--
            $('.date-picker').datepicker();

        }

        $(document).ready(function () {
            Ctrl();
        });

        function div_alert_msg_close() {
            $("#<%=div_alert_msg.ClientID%>").hide();
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
                <div class="form-group">
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
                            data-bv-label="Claim Category"></asp:TextBox>
                            <%--<input type="text" class="form-control date-picker"/>--%>
                            <div class="input-group-addon">
                                <span class="glyphicon glyphicon-th"></span>
                            </div>
                        </div>  
                        <label>Phone Number</label>
                        <asp:TextBox ID="tel1" runat="server" class="form-control" Style="width:200px" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;" ReadOnly="true"></asp:TextBox>
                    
                        <label>Claim Category</label>
                        <asp:Dropdownlist ID="ddl_category" runat="server" Style="width:300px" CssClass="form-control wow fadeOut" placeholder="Claim Category">
                            <%--<asp:ListItem Text="Select Category" Value="-1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="MILEAGE" Value="MILEAGE"></asp:ListItem>
                            <asp:ListItem Text="TAXI / GRAB / PUBLIC TRANSPORT" Value="TAXI / GRAB / PUBLIC TRANSPORT"></asp:ListItem>
                            <asp:ListItem Text="PARKING" Value="PARKING"></asp:ListItem>
                            <asp:ListItem Text="FUEL (COMPANY CAR ONLY)" Value="FUEL (COMPANY CAR ONLY)"></asp:ListItem>
                            <asp:ListItem Text="ACCOMODATION LODGING" Value="ACCOMODATION LODGING"></asp:ListItem>
                            <asp:ListItem Text="ALLOWANCES" Value="ALLOWANCES"></asp:ListItem>
                            <asp:ListItem Text="ENTERTAINMENT" Value="ENTERTAINMENT"></asp:ListItem>
                            <asp:ListItem Text="MEDICAL" Value="MEDICAL"></asp:ListItem>
                            <asp:ListItem Text="DENTAL" Value="DENTAL"></asp:ListItem>
                            <asp:ListItem Text="OTHERS / MISCELLANEOUS" Value="OTHERS / MISCELLANEOUS"></asp:ListItem>--%>
                        </asp:Dropdownlist>
                         
                        <label>RM</label>
                        <asp:TextBox ID="valueRM" runat="server" class="form-control" Style="width:300px"></asp:TextBox>

                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:LinkButton ID="btn_upload" Text="Upload" runat="server" OnClick="UploadFile" ></asp:LinkButton>

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
