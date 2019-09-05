Public Class Dashboard
    Inherits System.Web.UI.Page
    Dim mydb As New mydb

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            BindGridView()
        End If
    End Sub

    Private Sub BindGridView()
        Dim dt As New DataTable()
        dt = mydb.Search("SELECT idx, staff_fullname, staff_id, staff_position, staff_phone_num FROM tbl_staff;")
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindGridView()
    End Sub

    Private Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowIndex <> -1 Then
            Dim lbl_position As Label = CType(e.Row.FindControl("lbl_position"), Label)
            Dim hyperlink1 As HyperLink = CType(e.Row.FindControl("HyperLink1"), HyperLink)

            lbl_position.Text = get_Position(e.Row.DataItem("staff_position"))
            hyperlink1.NavigateUrl = "/cuticlaim/editStaff.aspx?id=" & e.Row.DataItem("idx")
        End If
    End Sub

    Private Function get_Position(ByVal id As Integer) As String
        Dim position As String = ""
        Dim dt As New DataTable()

        Dim sql As String = "SELECT position_name FROM tbl_position WHERE idx=" & id
        dt = mydb.Search(sql)
        position = dt.Rows(0).Item("position_name").ToString

        Return position
    End Function
End Class