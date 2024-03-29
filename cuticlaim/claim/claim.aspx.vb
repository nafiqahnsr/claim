﻿Imports System.IO
Public Class claim
    Inherits System.Web.UI.Page

    Dim mydb As New mydb
    Dim userID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        div_alert_msg.Visible = False

        If Not IsPostBack Then
            userID = Session("userid")
            Bind_Category_Type("Please Select", "")
            populate()
        End If
    End Sub

    Public Sub populate()
        Dim dt As New DataTable()

        Dim sql As String = "SELECT * FROM tbl_staff where idx = " & userID
        dt = mydb.Search(sql)

        If dt.Rows.Count > 0 Then
            hdn_id.Text = dt.Rows(0).Item("idx")
            name.Text = dt.Rows(0).Item("staff_fullname")
            txt_nostaff.Text = dt.Rows(0).Item("staff_id")
            tel1.Text = dt.Rows(0).Item("staff_phone_num")
        End If

    End Sub

    Protected Sub btnSubmitDetails_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmitDetails.Click
        Dim proc As Boolean = True
        Dim errMsg As String = ""
        Dim sql As String

        Try
            Dim rdate As String = CDate(reqdate.Text).ToString("yyyy/MM/dd")
            Dim categoryID As Integer = CInt(ddl_category.SelectedValue)

            If proc Then

                sql = "INSERT INTO tbl_claim_list (`staff_id`, `request_date`, `claim_category`, `claim_value`, `status`, `upload`) 
                VALUES('" & hdn_id.Text & "', '" & rdate & "', " & categoryID & " , '" & valueRM.Text & "' , '1', '" & Session("uploaded") & "')"

                If Not mydb.Execute(sql) Then
                    Throw New Exception(mydb._errMsg)
                    proc = False
                End If

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

    Protected Sub Display_Success_Message(ByVal obj_lbl_msg As Label,
                                        ByVal obj_div_alert_msg As HtmlControl,
                                        ByVal err_Msg As String)
        If Not obj_div_alert_msg Is Nothing Then
            obj_div_alert_msg.Visible = True
        End If

        If err_Msg.Length > 0 Then
            obj_lbl_msg.Text += "SUCCESS ID : " & err_Msg & "<br />"
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

            'For i = 0 To dt.Rows.Count - 1
            '    litem = New ListItem(dt.Rows(i).Item("name"), dt.Rows(i).Item("idx"))
            '    ddl_category.Items.Add(litem)
            'Next
        Catch ex As Exception
            Display_Error_Message(lbl_msg, div_alert_msg, ex.Message)
        End Try

    End Sub

    Protected Sub UploadFile(sender As Object, e As EventArgs)
        Dim folderPath As String = Server.MapPath("~/Files/")
        Session("uploaded") = FileUpload1.FileName
        If FileUpload1.FileName.Count = 0 Then
            ClientScript.RegisterStartupScript(Me.GetType(), "Popup", "ShowPopup('" & Title & "', 'Please select upload file!');", True)
            'System.Web.UI.ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "Script", "javascript:alert('Please select upload file!');", True)
            'Display_Error_Message(lbl_msg, div_alert_msg, "Please select upload file!")
            Exit Sub
        End If

        'Check whether Directory (Folder) exists.
        If Not Directory.Exists(folderPath) Then
            'If Directory (Folder) does not exists. Create it.
            Directory.CreateDirectory(folderPath)
        End If

        Dim ext As String = Right(FileUpload1.FileName, 3)
        If Not ext = "jpg" Then
            Display_Error_Message(lbl_msg, div_alert_msg, Path.GetFileName(FileUpload1.FileName) + "Invalid file extension.")
            Exit Sub
        End If

        Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream)
        Dim height As Integer = img.Height
        Dim width As Integer = img.Width
        Dim size As Decimal = Math.Round((CDec(FileUpload1.PostedFile.ContentLength) / CDec(1024)), 2)



        'Save the File to the Directory (Folder).
        FileUpload1.SaveAs(folderPath & Path.GetFileName(FileUpload1.FileName))

        'If File.Exists(folderPath & Path.GetFileName(FileUpload1.FileName)) Then
        '    img_upload.ImageUrl = Page.ResolveUrl("~/Files/" & FileUpload1.FileName)
        '    img_upload.Width = width
        '    img_upload.Height = height
        '    'Dim uploaded As String = folderPath & Path.GetFileName(FileUpload1.FileName)
        '    'Session("uploaded") = uploaded
        'Else
        '    Display_Error_Message(lbl_msg, div_alert_msg, Path.GetFileName(FileUpload1.FileName) + " file not found.")
        'End If

        'Display the success message.
        Display_Success_Message(lbl_msg, div_alert_msg, Path.GetFileName(FileUpload1.FileName) + " has been uploaded.")

    End Sub



End Class