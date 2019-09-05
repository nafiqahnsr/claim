
Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request("action") = "logout" Then Session.Abandon()
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
            Dim sql As String
            'sql = "SELECT * FROM pg_users WHERE username ='" & inputUser & "'"
            sql = "SELECT * FROM pg_users a JOIN tbl_staff b ON a.staff_id = b.staff_id WHERE a.username ='" & inputUser & "'"

            dt = mydb.Search(sql)

            If dt.Rows.Count > 0 Then
                'Dim pass As String = dt.Rows(0).Item("password")
                'If Hash.Verify(HashType.MD5, inputPassword, String.Empty, True, pass) Then
                If common.VerifyUser(inputPassword, dt.Rows(0).Item("password")) Then

                    Session("loginname") = dt.Rows(0).Item("username")
                    Session("loginpass") = dt.Rows(0).Item("password")
                    Session("userid") = dt.Rows(0).Item("idx")
                    Session("staff_id") = dt.Rows(0).Item("staff_id")
                    Session("position") = dt.Rows(0).Item("staff_position")
                    Session("fullname") = dt.Rows(0).Item("staff_fullname")
                    'Session("position") = dt.Rows()

                    Response.Redirect("/cuticlaim/Dashboard.aspx?idx=" & Session("userid"))

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