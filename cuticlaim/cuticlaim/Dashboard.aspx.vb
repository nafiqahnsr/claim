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
        dt = mydb.Search("select idx, staff_fullname, staff_id, staff_position, staff_phone_num from tbl_staff;")
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindGridView()
    End Sub

    Private Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowIndex <> -1 Then
            Dim hyperlink1 As HyperLink = CType(e.Row.FindControl("HyperLink1"), HyperLink)

            hyperlink1.Text = "Edit"
            hyperlink1.NavigateUrl = "/cuticlaim/editStaff.aspx?id=" & e.Row.DataItem("idx")
        End If
    End Sub
End Class