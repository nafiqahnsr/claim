Public Class editClaim
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Dim categoryID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            hdn_id.Text = Request("id")
            Bind_Category_Type("Please Select", "")
            populate()
        Else
            Dim sql As String
            Dim proc As Boolean = True
            categoryID = CInt(ddl_category.SelectedValue)

            If proc Then
                sql = "UPDATE tbl_claim_list SET claim_category = '" & categoryID & "', claim_value = '" & valueRM.Text & "' WHERE idx =" & hdn_id.Text
                proc = mydb.Execute(sql)

            End If

            If proc Then
                populate()

            End If
        End If
    End Sub

    Public Sub populate()
        Dim dt As New DataTable()

        Dim sql As String = "SELECT a.idx as id, b.staff_id, a.request_date, a.claim_category, a.claim_value, b.staff_fullname as fullname, b.staff_phone_num FROM tbl_claim_list a JOIN tbl_staff b ON a.staff_id = b.idx WHERE a.idx = " & hdn_id.Text
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            name.Text = dt.Rows(0).Item("fullname")
            txt_nostaff.Text = dt.Rows(0).Item("staff_id")
            reqdate.Text = dt.Rows(0).Item("request_date")
            tel1.Text = dt.Rows(0).Item("staff_phone_num")
            categoryID = dt.Rows(0).Item("claim_category")
            valueRM.Text = dt.Rows(0).Item("claim_value")

            ddl_category.SelectedValue = categoryID

        End If

    End Sub

    Protected Sub Bind_Category_Type(ByVal p_msg_select As String, ByVal p_selected_parameter_type As String)

        Dim litem As ListItem
        Dim dt As New DataTable()
        Try

            Dim sql As String = "SELECT idx, name FROM tbl_claim_category"
            dt = mydb.Search(sql)

            For Each dtrow As DataRow In dt.Rows
                litem = New ListItem(dtrow.Item("name"), dtrow.Item("idx"))
                ddl_category.Items.Add(litem)
            Next

        Catch ex As Exception
            'Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try

    End Sub

End Class