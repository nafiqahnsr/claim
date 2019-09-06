Public Class editStaff
    Inherits System.Web.UI.Page

    Dim id As Integer
    Dim mydb As New mydb
    Dim positionID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            id = CInt(Request("id"))
            idx.Value = id
            Bind_Position_Type("Please Select", "")
            populate()
        Else
            Dim sql As String
            Dim proc As Boolean = True
            positionID = CInt(ddl_position.SelectedValue)

            If proc Then
                sql = "UPDATE tbl_staff SET address = '" & address.Text & "', state = '" & state.Text & "' , postcode = '" & postcode.Text & "' , city = '" & city.Text & "' , staff_phone_num = '" & tel1.Text & "' , " &
                "staff_position = '" & positionID & "', updatedby = '" & Session("loginname") & "' " &
                "WHERE idx =" & idx.Value
                proc = mydb.Execute(sql)
            End If

            If proc Then
                lbl_error.Text = "Berjaya"
                populate()

            End If
        End If


    End Sub

    Public Sub populate()
        Dim dt As New DataTable()

        Dim sql As String = "SELECT * FROM tbl_staff where idx = " & idx.Value
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            name.Text = dt.Rows(0).Item("staff_fullname")
            address.Text = dt.Rows(0).Item("address")
            state.Text = dt.Rows(0).Item("state")
            postcode.Text = dt.Rows(0).Item("postcode")
            city.Text = dt.Rows(0).Item("city")
            ic.Text = dt.Rows(0).Item("staff_noic")
            staffid.Text = dt.Rows(0).Item("staff_id")
            positionID = dt.Rows(0).Item("staff_position")
            tel1.Text = dt.Rows(0).Item("staff_phone_num")

            ddl_position.SelectedValue = positionID
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

    Protected Sub Bind_Position_Type(ByVal p_msg_select As String, ByVal p_selected_parameter_type As String)

        Dim litem As ListItem
        Dim dt As New DataTable()
        Try

            Dim sql As String = "SELECT idx, position_name FROM tbl_position"
            dt = mydb.Search(sql)

            For Each dtrow As DataRow In dt.Rows
                litem = New ListItem(dtrow.Item("position_name"), dtrow.Item("idx"))
                ddl_position.Items.Add(litem)
            Next

        Catch ex As Exception
            'Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try

    End Sub
End Class