Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            check_login()
        End If
    End Sub

    Protected Sub check_login()

        Dim userlogin As String = Request("inputUser")
        Dim userpass As String = Request("inputPassword")

        If Not userlogin = "" Then

            If userlogin = "abc" And userpass = "123" Then
                Session("loginname") = userlogin
                Response.Redirect("/cuticlaim/Dashboard.aspx")
            Else
                'lbl_error.Visible = True
                'lbl_error.Text = "Wrong ID or Password entered"
            End If

        End If
        'If Session("loginname") Is Nothing Then
        '    'Session("loginname") = txt_nama.Text
        'End If
        'ni untuk bawa dari page lain ke page lain
        'Response.Redirect("new.aspx")
    End Sub

End Class