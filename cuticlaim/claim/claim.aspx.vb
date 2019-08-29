Public Class claim
    Inherits System.Web.UI.Page

    Dim mydb As New mydb
    Dim userID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            userID = Session("userid")
            populate()
        End If

    End Sub

    Public Sub populate()
        Dim dt As New DataTable()

        Dim sql As String = "SELECT * FROM tbl_staff where idx = " & userID
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            name.Text = dt.Rows(0).Item("NAMA")
            tel1.Text = dt.Rows(0).Item("TEL1")
        End If

    End Sub

    Protected Sub btnSubmitDetails_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmitDetails.Click

        If (category.Text = -1) Then
            label1.Text = "Pilih la category"
        Else
            label1.Text = ""
        End If
        'label1.Text = "Selamat Datang" + txt_nama.Text + " from " + txt_alamat.Text
    End Sub

End Class