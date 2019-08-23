<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="claim.aspx.vb" Inherits="cuticlaim.claim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Dashboard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div id="picture">
        <img src="/images/hi.png" style="width:400px;height:200px;"/>
        </div>
    <h1 style="background-color:antiquewhite;">Mindwave Consultancy</h1>

    <ul>
      <li><a class="active" href="/cuticlaim/Dashboard.aspx">Home</a></li>
      <li><a href="/claim/claim.aspx">Claim</a></li>
      <li><a href="/offDay/offDay.aspx">Off Day</a></li>
      <li><a href="/login.aspx">Log Out</a></li>
    </ul>
    <br />

</asp:Content>
