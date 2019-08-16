Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            BindGridView()
        End If
    End Sub

    Private Sub BindGridView()
        Dim claim As String = ConfigurationManager.ConnectionStrings("claim").ConnectionString
        Using con As New MySqlConnection(claim)
            Using cmd As New MySqlCommand("select NAMA, STAFF_ID, ROLE_JAWATAN, EMEL, TEL1 from tbl_staff;")
                Using sda As New MySqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        GridView1.DataSource = dt
                        GridView1.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindGridView()
    End Sub
End Class