Public Class addUser
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("position") <> 9 Then
            Response.Redirect("/cuticlaim/Dashboard.aspx")
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        div_alert_msg.Visible = False

        If Not IsPostBack Then
            Bind_Position_Type("Please Select", "")
        Else
            Insert_pgusers()
            Insert_tblstaff()
        End If
    End Sub

    Public Sub Insert_pgusers()
        Dim sql As String
        Dim proc As Boolean = True
        Dim common As New common
        Dim temp_pass As String

        temp_pass = common.PasswordHash(pass.Text)
        Try
            If proc Then
                sql = "INSERT INTO pg_users (`username`, `password`, `email`, `UserStatus`, `staff_id`) 
                VALUES('" & userID.Text & "', '" & temp_pass & "', '" & email.Text & "', 'Aktif' , '" & staffID.Text & "')"

                proc = mydb.Execute(sql)

            End If

        Catch ex As Exception
            Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try

    End Sub

    Public Sub Insert_tblstaff()
        Dim sql As String
        Dim proc As Boolean = True
        Dim positionID As Integer = CInt(ddl_position.SelectedValue)
        Try
            If proc Then
                sql = "INSERT INTO tbl_staff (`staff_id`, `staff_fullname`, `staff_noic`, `staff_position`, `staff_phone_num`, `address`, `postcode`, `city`, `state`, `flat`)
                VALUES ('" & staffID.Text & "', '" & name.Text & "', '" & noic.Text & "', '" & positionID & "', '" & tel1.Text & "', '" & address.Text & "', 
                '" & postcode.Text & "', '" & city.Text & "', '" & state.Text & "', '1')"

                proc = mydb.Execute(sql)
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
            Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try

    End Sub

End Class