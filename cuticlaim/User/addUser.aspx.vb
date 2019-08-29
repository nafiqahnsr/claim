Public Class addUser
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
        Else
            Register()
        End If
    End Sub

    Public Sub Register()
        Dim sql As String
        Dim proc As Boolean = True
        Dim common As New common
        Dim temp_pass As String

        temp_pass = common.PasswordHash(pass.Text)

        If proc Then

            sql = "INSERT INTO pg_users (`UserID`, `Fullname`, `Password`, `Email`, `UserStatus`, `STAFF_ID`) VALUES('" & userID.Text & "','" & name.Text & "', '" & temp_pass & "',
                '" & email.Text & "', 'Aktif' , '" & staffID.Text & "')"

            proc = mydb.Execute(sql)

        End If

    End Sub

End Class