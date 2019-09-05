<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="test.aspx.vb" Inherits="cuticlaim.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="row">
                <asp:Label ID="lbl_username" runat="server" Text="Username"></asp:Label> <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Label ID="lbl_userpass" runat="server" Text="Userpass"></asp:Label> <asp:TextBox ID="txt_userpass" runat="server"></asp:TextBox>
            </div>
            <div class="row">

                <asp:Label ID="lbl_encrypted" runat="server"></asp:Label>
                <asp:Label ID="lbl_status" runat="server"></asp:Label>

                <asp:Button id="btn_submit" runat="server" Text="Submit"/>
            </div>

        </div>
    </form>
</body>
</html>
