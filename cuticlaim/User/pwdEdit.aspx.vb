Public Class pwdEdit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then

            Dim inputPassword As String = txt_oldpwd.Text
            Dim temp_pass As String
            Dim mydb As New mydb
            Dim common As New common
            Dim dt As New DataTable()
            Dim sql As String
            Dim proc As Boolean = True
            sql = "SELECT * FROM pg_users WHERE username ='" & Session("loginname") & "'"

            dt = mydb.Search(sql)

            If dt.Rows.Count > 0 Then
                If common.VerifyUser(inputPassword, dt.Rows(0).Item("password")) Then
                    If txt_newpwd.Text = txt_confirmpwd.Text Then
                        temp_pass = common.PasswordHash(txt_newpwd.Text)
                        If proc Then
                            sql = "UPDATE pg_users SET password = '" & temp_pass & "' WHERE username ='" & Session("loginname") & "'"
                            proc = mydb.Execute(sql)
                        End If
                    Else
                        lbl_error.Visible = True
                        lbl_error.Text = "Please re-enter new password and confirm password."
                        Clear()
                    End If
                Else
                    lbl_error.Visible = True
                    lbl_error.Text = "Invalid Password!"
                    Clear()
                End If
            End If
        End If
    End Sub
    Protected Sub Clear()
        txt_oldpwd.Text = ""
        txt_newpwd.Text = ""
        txt_confirmpwd.Text = ""
    End Sub

End Class