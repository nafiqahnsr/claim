Imports Effortless.Net.Encryption
Public Class common

    Public Function PasswordHash(plain_passwd As String) As String
        Dim encrypt_passwd As String
        encrypt_passwd = Hash.Create(HashType.MD5, plain_passwd, String.Empty, True)

        Return encrypt_passwd
    End Function

    Public Function VerifyUser(plain_passwd As String, encrypt_passwd As String) As Boolean

        If Hash.Verify(HashType.MD5, plain_passwd, String.Empty, True, encrypt_passwd) Then
            Return True
        End If
        Return False

    End Function
End Class
