
Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            check_login()
        End If
    End Sub

    Protected Sub check_login()

        Dim inputUser As String = Request("inputUser")
        Dim inputPassword As String = Request("inputPassword")

        If Not inputUser = "" Then
            Dim mydb As New mydb
            Dim common As New common
            Dim dt As New DataTable()
            Dim sql As String = "SELECT * FROM pg_users WHERE UserID='" & inputUser & "'"

            dt = mydb.Search(sql)

            If dt.Rows.Count > 0 Then
                'Dim pass As String = dt.Rows(0).Item("Password")
                'If Hash.Verify(HashType.MD5, inputPassword, String.Empty, True, pass) Then
                If common.VerifyUser(inputPassword, dt.Rows(0).Item("Password")) Then

                    Session("loginname") = inputUser
                    Session("loginpass") = dt.Rows(0).Item("Password")
                    Session("userid") = dt.Rows(0).Item("idx")
                    Session("fullname") = dt.Rows(0).Item("Fullname")

                    Response.Redirect("/cuticlaim/Dashboard.aspx")

                Else
                    lbl_error.Visible = True
                    lbl_error.Text = "Invalid Password!"
                End If

            Else

                lbl_error.Visible = True
                lbl_error.Text = "Wrong ID or Password entered"

            End If

        End If

    End Sub

End Class