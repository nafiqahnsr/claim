Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("loginname") Is Nothing Then
            Response.Redirect("/login.aspx")
        Else
            Page.Title = Session("loginname")
        End If
    End Sub

End Class