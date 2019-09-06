Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("loginname") Is Nothing Then
            Response.Redirect("/login.aspx")
        Else
            Page.Title = Session("loginname")

            lnk_1.NavigateUrl = "/claim/claim.aspx"
            lnk_1.Text = "Claim"

            lnk_2.NavigateUrl = "/User/addUser.aspx"
            lnk_2.Text = "Register"
            If Session("position") = 9 Or Session("position") = 1 Then
                lnk_2.Enabled = True
                lnk_2.Visible = True
            End If

            lnk_3.NavigateUrl = "/User/account.aspx"
            lnk_3.Text = "Account"

            lnk_4.NavigateUrl = "/claim/claimList.aspx"
            lnk_4.Text = "Claim List"
            If Session("position") = 9 Or Session("position") = 1 Then lnk_4.NavigateUrl = "/claim/claimListManager.aspx"

            lnk_5.NavigateUrl = "/login.aspx?action=logout"
            lnk_5.Text = "Log Out"

        End If
    End Sub

End Class