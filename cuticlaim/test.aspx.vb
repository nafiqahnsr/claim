Public Class test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            'populate()

        Else
            Dim common As New common
            Dim mydb As New mydb
            Dim sql As String

            Dim username As String = txt_username.Text
            Dim userpass As String = txt_userpass.Text
            Dim encrypt_passwd As String = ""

            encrypt_passwd = common.PasswordHash(userpass)
            lbl_encrypted.Text = encrypt_passwd

            sql = "insert into pg_users ( UserID, Fullname, Password ) values ('" & username & "', 'aaaaa', '" & encrypt_passwd & "'  )"
            If mydb.Execute(sql) Then
                lbl_status.Text = "Berjaya"
            Else
                lbl_status.Text = "Tidak Berjaya"
            End If




        End If

    End Sub

End Class