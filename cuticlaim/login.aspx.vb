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
            Dim dt As New DataTable()
            Dim sql As String = "SELECT * FROM pg_users WHERE UserID='" & inputUser & "'"

            dt = mydb.Search(sql)

            If dt.Rows.Count > 0 Then
                Dim pass As String = dt.Rows(0).Item("Password")

                If inputPassword = pass Then
                    Session("loginname") = inputUser
                    Session("loginpass") = pass
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
        'If Session("loginname") Is Nothing Then
        '    'Session("loginname") = txt_nama.Text
        'End If
        'ni untuk bawa dari page lain ke page lain
        'Response.Redirect("new.aspx")
    End Sub

End Class