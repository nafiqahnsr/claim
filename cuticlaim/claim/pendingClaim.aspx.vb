Public Class pendingClaim
    Inherits System.Web.UI.Page
    Dim mydb As New mydb

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            hdn_id.Text = Request("id")
            Bind_Status_Type("Please Select", "")
            populate()
        Else
            Dim sql As String
            Dim proc As Boolean = True
            Dim statusID As Integer = CInt(ddl_status.SelectedValue)

            If proc Then

                sql = "UPDATE tbl_claim_list SET status = '" & statusID & "' WHERE idx =" & hdn_id.Text
                proc = mydb.Execute(sql)

            End If

            If proc Then
                populate()

            End If
        End If
    End Sub

    Public Sub populate()
        Dim dt As New DataTable()
        Dim temp_category As Integer = 0
        Dim sql As String = "SELECT a.idx as id, b.staff_id, a.request_date, a.claim_category, a.claim_value, b.staff_fullname as fullname, b.staff_phone_num FROM tbl_claim_list a JOIN tbl_staff b ON a.staff_id = b.idx where a.idx = " & hdn_id.Text
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            name.Text = dt.Rows(0).Item("fullname")
            txt_nostaff.Text = dt.Rows(0).Item("staff_id")
            reqdate.Text = dt.Rows(0).Item("request_date")
            tel1.Text = dt.Rows(0).Item("staff_phone_num")
            temp_category = dt.Rows(0).Item("claim_category")
            valueRM.Text = dt.Rows(0).Item("claim_value")

            txt_category.Text = get_Category(temp_category)

            'If categoryID = 1 Then
            '    ddl_category.SelectedValue = 1
            'End If
        End If

    End Sub

    Protected Sub Bind_Status_Type(ByVal p_msg_select As String, ByVal p_selected_parameter_type As String)

        Dim litem As ListItem
        Dim dt As New DataTable()
        'Try

        Dim sql As String = "SELECT idx, name FROM tbl_claim_status"
        dt = mydb.Search(sql)

        For Each dtrow As DataRow In dt.Rows
            litem = New ListItem(dtrow.Item("name"), dtrow.Item("idx"))
            ddl_status.Items.Add(litem)
        Next

        'For i = 0 To dt.Rows.Count - 1
        '    litem = New ListItem(dt.Rows(i).Item("name"), dt.Rows(i).Item("idx"))
        '    ddl_category.Items.Add(litem)
        'Next
        'Catch ex As Exception
        '    Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        'End Try

    End Sub

    Private Function get_Category(ByVal id As Integer) As String
        Dim category As String = ""
        Dim dt As New DataTable()

        Dim sql As String = "SELECT name FROM tbl_claim_category WHERE idx=" & id
        dt = mydb.Search(sql)
        category = dt.Rows(0).Item("name").ToString

        Return category
    End Function

End Class