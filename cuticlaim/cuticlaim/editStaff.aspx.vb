Public Class editStaff
    Inherits System.Web.UI.Page

    Dim id As Integer
    Dim mydb As New mydb

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            id = CInt(Request("id"))
            idx.Value = id
            populate()
        Else
            Dim sql As String
            Dim proc As Boolean = True
            'state.Text
            'postcode.Text
            'city.Text
            'ic.Text
            'staffid.Text
            'Position1.Text

            If proc Then

                sql = "UPDATE tbl_staff SET NAMA = '" & name.Text & "' , EMEL = '" & email.Text & "' , ALAMAT = '" & address.Text & "', " &
                    "UPDATEBY = '" & Session("loginname") & "' " &
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
            name.Text = dt.Rows(0).Item("NAMA")
            email.Text = dt.Rows(0).Item("EMEL")
            address.Text = dt.Rows(0).Item("ALAMAT")
            state.Text = dt.Rows(0).Item("NEGERI")
            postcode.Text = dt.Rows(0).Item("POSKOD")
            city.Text = dt.Rows(0).Item("BANDAR")
            ic.Text = dt.Rows(0).Item("NOIC")
            staffid.Text = dt.Rows(0).Item("STAFF_ID")
            Position1.Text = dt.Rows(0).Item("ROLE_JAWATAN")
            'rpt_to1.Text = dt.Rows(0).Item("NAMA")
            'statuspkj.Text = dt.Rows(0).Item("NAMA")
            tel1.Text = dt.Rows(0).Item("NAMA")
        End If

    End Sub
End Class