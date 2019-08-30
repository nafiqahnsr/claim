﻿Public Class claimList
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        div_alert_msg.Visible = False
        If Not Me.IsPostBack Then
            populate()
        End If
    End Sub

    Private Sub populate()
        Dim mydb As New mydb
        Dim dt As New DataTable()

        Try
            Dim sql As String = "SELECT a.idx as id, b.staff_id, a.request_date, a.claim_category, a.claim_value, b.staff_fullname as fullname FROM tbl_claim_list a JOIN tbl_staff b ON a.staff_id = b.idx"
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
            Dim hyperlink_edit As HyperLink = CType(e.Row.FindControl("HyperLink_edit"), HyperLink)

            'hyperlink_edit.Text = "Edit"
            hyperlink_edit.NavigateUrl = "/cuticlaim/editStaff.aspx?id=" & e.Row.DataItem("id")

        End If
    End Sub

    Protected Sub btn_del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_del.Click
        Dim proc As Boolean = True
        Dim errMsg As String = ""
        Dim sql As String

        Try
            If proc Then

                sql = "DELETE FROM tbl_claim_list WHERE idx =" & hdn_id.Text

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