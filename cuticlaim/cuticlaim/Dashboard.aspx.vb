Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            BindGridView()
        End If
    End Sub

    Private Sub BindGridView()
        Dim mydb As New mydb
        Dim dt As New DataTable()
        dt = mydb.Search("select NAMA, STAFF_ID, ROLE_JAWATAN, EMEL, TEL1 from tbl_staff;")
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindGridView()
    End Sub
End Class