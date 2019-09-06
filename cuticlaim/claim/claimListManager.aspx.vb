Public Class claimListManager
    Inherits System.Web.UI.Page
    Dim mydb As New mydb

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("position") <> 9 Then
            Response.Redirect("/cuticlaim/Dashboard.aspx")
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        div_alert_msg.Visible = False
        If Not Me.IsPostBack Then
            'hdn_id.Text = Session("userid")
            populate()
        End If
    End Sub

    Private Sub populate()
        Dim mydb As New mydb
        Dim dt As New DataTable()

        Try
            Dim sql As String = "SELECT a.idx as id, a.staff_id as idx, b.staff_id, a.request_date, a.claim_category, a.claim_value, " &
                "b.staff_fullname as fullname, a.status FROM tbl_claim_list a JOIN tbl_staff b ON a.staff_id = b.idx" &
                " ORDER BY a.request_date"
            dt = mydb.Search(sql)
            GridView1.DataSource = dt
            GridView1.DataBind()
            If dt.Rows.Count = 0 Then
                lbl_NoRecord.Text = "No records found"
            End If

        Catch ex As Exception
            Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        populate()
    End Sub

    Private Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowIndex <> -1 Then
            Dim lbl_status As Label = CType(e.Row.FindControl("lbl_status"), Label)
            Dim hyperlink_edit As HyperLink = CType(e.Row.FindControl("HyperLink_edit"), HyperLink)

            'hyperlink_edit.Text = "Edit"
            lbl_status.Text = get_Status(e.Row.DataItem("status"))
            hyperlink_edit.NavigateUrl = "/claim/pendingClaim.aspx?id=" & e.Row.DataItem("id")

        End If
    End Sub

    Private Function get_Status(ByVal id As Integer) As String
        Dim status As String = ""
        Dim dt As New DataTable()

        Dim sql As String = "SELECT name FROM tbl_claim_status WHERE idx=" & id
        dt = mydb.Search(sql)
        status = dt.Rows(0).Item("name").ToString

        Return status
    End Function

    Protected Sub btn_del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_del.Click
        Dim proc As Boolean = True
        Dim errMsg As String = ""
        Dim sql As String

        Try
            If proc Then

                sql = "DELETE FROM tbl_claim_list WHERE staff_id =" & hdn_id.Text

                If Not mydb.Execute(sql) Then
                    Throw New Exception(mydb._errMsg)
                    proc = False
                End If

            End If

            If proc Then
                populate()
            End If

        Catch ex As Exception
            Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try
    End Sub

    Protected Sub Display_Error_Message(ByVal obj_lbl_msg As Label,
                                        ByVal obj_div_alert_msg As HtmlControl,
                                        ByVal err_Msg As String)
        If Not obj_div_alert_msg Is Nothing Then
            obj_div_alert_msg.Visible = True
        End If

        If err_Msg.Length > 0 Then
            obj_lbl_msg.Text += "ERROR ID : " & err_Msg & "<br />"
        End If

    End Sub

End Class