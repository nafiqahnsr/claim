Public Class editStaff
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub populate()
        Dim tmp_name As String = ""
        Dim tmp_email As String = ""
        Dim tmp_addr As String = ""
        Dim tmp_state As String = ""
        Dim tmp_postcode As String = ""
        Dim tmp_city As String = ""
        Dim tmp_noic As String = ""
        Dim tmp_id As String = ""
        Dim tmp_position As String = ""
        Dim tmp_repto As String = ""
        Dim tmp_status As String = ""
        Dim tmp_pnumber As String = ""

        Dim mydb As New mydb
        Dim dt As New DataTable()


    End Sub

    '    Protected Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click
    '        Try
    '            Using db As New PetaPoco.Database(GetConnStr, GetConnProviderStr)
    '                Dim tObj2 = db.FirstOrDefault(Of MWCDL.tbl_staff)(" WHERE idxpelanggan=@0  ORDER by createdate  ASC LIMIT 1 ", Session("idxPelanggan"))
    '                If tObj2 IsNot Nothing Then
    '                    Dim tObj As New MWCDL.tbl_staff
    '                    With tObj
    '                        .idx = tObj2.idx
    '                        .idxpelanggan = Session("idxPelanggan")
    '                        .STAFF_ID = name.Text.ToString
    '                        .alamat1 = add1.Text.ToString
    '                        .alamat2 = add2.Text.ToString
    '                        .bandar = bandar.SelectedValue
    '                        .negeri = state.SelectedValue
    '                        .poskod = poskod.Text.ToString
    '                        .negara = country.SelectedValue
    '                        .tel_hp = phoneno.Text.ToString
    '                        .createid = tObj2.createid
    '                        .createdate = tObj2.createdate
    '                    End With
    '                    db.Update(tObj)


    '                Else

    '                    Dim tObj As New MWCDL.dbp_pelangganAddress
    '                    With tObj
    '                        .idxpelanggan = Session("idxPelanggan")
    '                        .nama_penerima = name.Text.ToString
    '                        .alamat1 = add1.Text.ToString
    '                        .alamat2 = add2.Text.ToString
    '                        .bandar = bandar.SelectedValue
    '                        .negeri = state.SelectedValue
    '                        .poskod = poskod.Text.ToString
    '                        .negara = country.SelectedValue
    '                        .tel_hp = phoneno.Text.ToString
    '                        .createid = Session("idxPelanggan")
    '                        .createdate = Date.Now
    '                    End With
    '                    db.Insert(tObj)

    '                End If

    '                Dim tObjPel As New MWCDL.dbp_pelanggan
    '                With tObjPel
    '                    .idx = Session("idxPelanggan")
    '                    .emel = Session("emel")
    '                    .nama_pelanggan = name.Text.ToString
    '                    .nama_akhir = ""
    '                    .syarikat = compname.Text.ToString
    '                    .nokp = ""
    '                    .dob = birthdate.Text
    '                    .gender = jantina.SelectedValue
    '                    .tel_rumah = 0
    '                    .tel_hp = phoneno.Text.ToString
    '                    .status = 1
    '                End With
    '                db.Update(tObjPel)
    '                ltJSAlert.Text = JSAlertSuccess(RecordUpdated)

    '            End Using

    '        Catch ex As Exception
    '            ex.ToString()
    '        End Try

    '    End Sub

End Class