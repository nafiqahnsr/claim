Public Class claimList
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            BindGridView()
        End If
    End Sub

    Private Sub BindGridView()
        Dim mydb As New mydb
        Dim dt As New DataTable()
        dt = mydb.Search("SELECT idx, staff_fullname, staff_id, staff_position, staff_noic, staff_phone_num FROM tbl_staff;")
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindGridView()
    End Sub

    Private Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowIndex <> -1 Then
            Dim hyperlink_edit As HyperLink = CType(e.Row.FindControl("HyperLink_edit"), HyperLink)

            'hyperlink_edit.Text = "Edit"
            hyperlink_edit.NavigateUrl = "/cuticlaim/editStaff.aspx?id=" & e.Row.DataItem("idx")

        End If
    End Sub

    Protected Sub btn_del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_del.Click
        Dim proc As Boolean = True
        Dim errMsg As String = ""
        Dim sql As String

        Try
            If proc Then

                sql = "DELETE FROM tbl_ WHERE idx =" hdn_idx.Text

                If Not mydb.Execute(sql) Then
                    Throw New Exception(mydb._errMsg)
                    proc = False
                End If

            End If

        Catch ex As Exception
            'Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try
    End Sub

End Class