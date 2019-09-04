Public Class account
    Inherits System.Web.UI.Page

    Dim id As Integer
    Dim mydb As New mydb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            id = Session("userid")
            populate()
        Else
            Dim sql As String
            Dim proc As Boolean = True

            If proc Then

                sql = "UPDATE tbl_staff SET email = '" & email.Text & "', address = '" & address.Text & "', state = '" & state.Text & "' , postcode = '" & postcode.Text & "' , city = '" & city.Text & "' , staff_phone_num = '" & tel1.Text & "' , " &
                    "updatedby = '" & Session("loginname") & "' " &
                "WHERE idx =" & id
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

        Dim sql As String = "SELECT * FROM tbl_staff a JOIN pg_users b ON a.staff_id = b.staff_id WHERE a.idx = " & id
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            name.Text = dt.Rows(0).Item("staff_fullname")
            email.Text = dt.Rows(0).Item("email")
            address.Text = dt.Rows(0).Item("address")
            state.Text = dt.Rows(0).Item("state")
            postcode.Text = dt.Rows(0).Item("postcode")
            city.Text = dt.Rows(0).Item("city")
            ic.Text = dt.Rows(0).Item("staff_noic")
            staffid.Text = dt.Rows(0).Item("staff_id")
            Position1.Text = dt.Rows(0).Item("staff_position")
            tel1.Text = dt.Rows(0).Item("staff_phone_num")
        End If

    End Sub

End Class