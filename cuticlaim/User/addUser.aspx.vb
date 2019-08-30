Public Class addUser
    Inherits System.Web.UI.Page
    Dim mydb As New mydb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'Bind_Category_Type("Please Select", "")
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

        If proc Then
            sql = "INSERT INTO pg_users (`UserID`, `staff_fullname`, `password`, `email`, `UserStatus`, `staff_id`) 
                VALUES('" & userID.Text & "','" & name.Text & "', '" & temp_pass & "',
                '" & email.Text & "', 'Aktif' , '" & staffID.Text & "')"

            proc = mydb.Execute(sql)

        End If

    End Sub

    Public Sub Insert_tblstaff()
        Dim sql As String
        Dim proc As Boolean = True

        If proc Then
            sql = "INSERT INTO tbl_staff (`staff_id`, `staff_fullname`, `staff_noic`, `staff_position`, `staff_phone_num`, `address`, `postcode`, `city`, `state`, `flat`)
                VALUES ('" & staffID.Text & "', '" & name.Text & "', '" & noic.Text & "', '" & ddl_position.Text & "', '" & tel1.Text & "', '" & address.Text & "', 
                '" & postcode.Text & "', '" & city.Text & "', '" & state.Text & "', '1')"

            proc = mydb.Execute(sql)

        End If
    End Sub

    'Protected Sub Bind_Category_Type(ByVal p_msg_select As String, ByVal p_selected_parameter_type As String)

    '    Dim litem As ListItem
    '    Dim dt As New DataTable()

    '    Dim sql As String = "SELECT idx, name FROM tbl_claim_category"
    '    dt = mydb.Search(sql)

    '    For Each dtrow As DataRow In dt.Rows
    '        litem = New ListItem(dtrow.Item("name"), dtrow.Item("idx"))
    '        ddl_position.Items.Add(litem)
    '    Next

    'End Sub

End Class