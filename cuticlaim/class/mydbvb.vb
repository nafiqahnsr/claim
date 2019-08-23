Imports MySql.Data.MySqlClient
Public Class mydb
    Public Shared Property _errStatus As Boolean = False
    Public Shared Property _errMsg As String = ""
    Public Property constr As String
    Shared conn As MySqlConnection
    Public Property DbName As String

    Public Sub New()
        constr = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        'constr = ConfigurationManager.ConnectionStrings("constr_local").ConnectionString
        Try
            conn = New MySqlConnection(constr)
            conn.Open()
            DbName = conn.Database
        Catch ex As Exception
            _errStatus = True
            _errMsg = ex.Message
        End Try
    End Sub

    Public Sub Close()
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Public Function CreateCommand() As MySqlCommand
        If conn.State <> ConnectionState.Open Then conn.Open()
        Return conn.CreateCommand()
    End Function

    Public Function Execute(vSQL As String) As Boolean
        Dim tStatus As Boolean = True
        If vSQL = "" Then
            _errStatus = True
            _errMsg = "No query statement to execute"
            Return Nothing
        End If
        Try
            Dim cmd As MySqlCommand = CreateCommand()
            cmd.CommandText = vSQL
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            _errStatus = True
            _errMsg = ex.Message
            tStatus = False
        End Try
        Return tStatus
    End Function

    Public Function Search(vSQL As String) As DataTable
        Dim dt As New DataTable()
        If vSQL = "" Then Return Nothing
        Try
            Dim cmd As MySqlCommand = CreateCommand()
            cmd.CommandText = vSQL
            Dim sda As New MySqlDataAdapter(cmd)
            sda.Fill(dt)
        Catch ex As Exception
            _errStatus = True
            _errMsg = ex.Message
        End Try
        Return dt
    End Function
End Class