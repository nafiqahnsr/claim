<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dashboard.aspx.vb" Inherits="cuticlaim.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mindwave Consultancy</title>
   
    <style>
        h1 
        {
            color: #810e41;
            font-family: 'Times New Roman', Times, serif;
            text-align: center;
            font-size: 30px;
            padding: 10px;
        }

        /*NAVIGATION BAR*/
        body {
          font-size: 20px;
        }

        ul {
          list-style-type: none;
          margin: 0;
          padding: 0;
          overflow: hidden;
          background-color: #333;
          position: -webkit-sticky; /* Safari */
          position: sticky;
          top: 0;
        }

        li {
          float: left;
        }

        li a {
          display: block;
          color: white;
          text-align: center;
          padding: 14px 16px;
          text-decoration: none;
        }

        li a:hover {
          background-color: #111;
        }

        .active {
          background-color: #4CAF50;
        }

        /*logo*/
        #picture{
            text-align:center;
        }

    </style>
</head>
<body style="background-color: #f7fef2">

    <div id="picture">
        <img src="/images/hi.png" style="width:400px;height:200px;"/>
        </div>
    <h1 style="background-color:antiquewhite;">Mindwave Consultancy</h1>

    <ul>
      <li><a class="active" href="#home">Home</a></li>
      <li><a href="#news">News</a></li>
      <li><a href="#contact">Contact</a></li>
    </ul>
    <br />
        <form id="form1" runat="server">
        <div>
        </div>
            <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
                <Columns>
                    <asp:BoundField DataField="NAMA" HeaderText="Name" ItemStyle-Width="300" />
                    <asp:BoundField DataField="STAFF_ID" HeaderText="Staff ID" ItemStyle-Width="80" />
                    <asp:BoundField DataField="role_jawatan" HeaderText="Position" ItemStyle-Width="100" />
                    <asp:BoundField DataField="EMEL" HeaderText="Email" ItemStyle-Width="180" />
                    <asp:BoundField DataField="TEL1" HeaderText="Phone Number" ItemStyle-Width="150" />
                </Columns>
            </asp:GridView>
    </form>
</body>
</html>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadPageScriptContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:GridView ID ="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="NAMA" HeaderText="Name" ItemStyle-Width="100" />
                    <asp:BoundField DataField="STAFF_ID" HeaderText="Staff ID" ItemStyle-Width="150" />
                    <asp:BoundField DataField="role_jawatan" HeaderText="Position" ItemStyle-Width="150" />
                    <asp:BoundField DataField="EMEL" HeaderText="Email" ItemStyle-Width="150" />
                    <asp:BoundField DataField="TEL1" HeaderText="Phone Number" ItemStyle-Width="150" />
                </Columns>
            </asp:GridView>
    </form>
</asp:Content>--%>
