
Imports System.IO
Imports System.Data.Odbc
Imports System.Net
Imports System.Drawing.Imaging
Imports C1.Win.C1FlexGrid

Public Class Form15
    Private Sub SelectImage_Click(sender As Object, e As EventArgs) Handles SelectImage_but.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Files|*.jpg;*.pdf"
        openFileDialog1.Title = "Select an image or pdf file"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Get extension.
            Dim extension As String = Path.GetExtension(openFileDialog1.FileName).ToLower
            If extension = ".jpg" Or extension = ".png" Then
                foto_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Status_lbl.Text = "Loading image..."
                LoadImage(openFileDialog1.FileName)
                Status_lbl.Text = "Image loaded."
            End If
        End If
        newimage = True
    End Sub

    Public FotoTradeItemDBId As Integer = 0
    Public rijpheid As Integer = 0
    Public fustcode As Integer = 0
    Public hoogte As Integer = 0
    Public diameter As Integer = 0
    Public schermen As Integer = 0
    Public keurcode As Integer = 0

    Public exportgrid As Integer = 0
    Public flexgridrow As Integer = 0
    Public flexgridcol As Integer = 0
    Public fotopath As String = ""

    Dim TradeItemGUID As String = ""
    Dim newimage As Boolean = False
    Dim selectedImage As String = ""

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand("", Conn)
                Dim reader As OdbcDataReader

                Cmd.CommandText = "SELECT * from floriday_tradeitem WHERE id=" + Str(FotoTradeItemDBId)
                reader = Cmd.ExecuteReader()
                If reader.HasRows Then
                    TradeItemGUID = CHstr(reader("tradeItemId"))
                    Dim tradeItemName As String = CHstr(reader("tradeItemName_nl"))
                    tradeitem_lbl.Text = tradeItemName

                    If FtpDirExists(TradeItemGUID) Then
                        'list files
                        ShowFileList(TradeItemGUID)
                    Else
                        FtpFolderCreate(TradeItemGUID)
                    End If

                End If


            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: (fotos load tradeitem info)" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub ShowFileList(TradeItemGUID As String)
        Foto_Filelist_flx.Rows.Count = 1
        Try
            Dim reqFTP As FtpWebRequest = Nothing
            Dim path As String = "ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + TradeItemGUID + "/"
            Dim relative_path As String = "Fotos/" + TradeItemGUID + "/"
            reqFTP = DirectCast(WebRequest.Create(path), FtpWebRequest)
            reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            reqFTP.Credentials = New NetworkCredential("ftp", "jahoor9580")
            Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(responseStream)

                    Dim ftpline As String = reader.ReadLine
                    While (ftpline IsNot Nothing)
                        'process the line
                        If Mid(ftpline, 1, 1) = "d" Then 'directory
                            'skip
                        Else
                            Dim splitdata() As String = ftpline.Split(New Char() {" "c}, 9, StringSplitOptions.RemoveEmptyEntries)
                            Dim filesize As Integer = CInt(splitdata(4))
                            Dim datestr As String = splitdata(6) + "-" + splitdata(5) + "-" + splitdata(7)
                            Dim filename As String = splitdata(8)
                            Dim flexfill(5) As String

                            If fotopath = TradeItemGUID + "/" + filename Then
                                flexfill(0) = True
                                ShowImage(fotopath)

                            Else
                                flexfill(0) = False
                            End If

                            flexfill(1) = filename
                            flexfill(2) = ""

                            Foto_Filelist_flx.AddItem(flexfill)

                        End If
                        ftpline = reader.ReadLine
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Directory read error")
        End Try



    End Sub

    Private Function FtpDirExists(ByVal directory As String) As Boolean
        Dim returnvalue As Boolean = False
        Try

            Dim reqFTP As FtpWebRequest = Nothing
            reqFTP = DirectCast(WebRequest.Create("ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + directory), FtpWebRequest)
            reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            reqFTP.Credentials = New NetworkCredential("ftp", "jahoor9580")
            Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                returnvalue = True
            End Using

        Catch ex As Exception
            Return False
        End Try

        Return returnvalue
    End Function

    Private Sub Form15_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each filepath In files
            Dim extension As String = Path.GetExtension(filepath).ToLower
            If extension = ".jpg" Or extension = ".png" Then
                foto_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Status_lbl.Text = "Loading image..."
                LoadImage(filepath)
                Status_lbl.Text = "Image loaded."
                newimage = True
            End If
        Next
    End Sub

    Private Sub LoadImage(filepath As String)

        Dim image1 As Bitmap = CType(Image.FromFile(filepath, True), Bitmap)

        Dim width As Integer = image1.Width
        Dim height As Integer = image1.Height

        Dim destwidth As Integer = 800
        Dim destheight As Integer = 800
        If width > height Then
            Dim ratio As Double = width / 800
            destwidth = 800
            destheight = CInt(height / ratio)
        ElseIf height > width Then
            Dim ratio As Double = height / 800
            destheight = 800
            destwidth = CInt(width / ratio)
        Else
            destwidth = 800
            destheight = 800
        End If

        Dim image4 = New Bitmap(destwidth, destheight)
        Using g_image4 As Graphics = Graphics.FromImage(image4)

            Dim src_rect As New Rectangle(0, 0, width, height)
            Dim dst_rect As New Rectangle(0, 0, destwidth, destheight)
            g_image4.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            g_image4.DrawImage(image1, dst_rect, src_rect, GraphicsUnit.Pixel)
            g_image4.Dispose()
            foto_PictureBox.Image = image4
        End Using
        Me.Cursor = Cursors.Default

    End Sub

    Private Function FtpFolderCreate(folder_name As String) As Boolean
        Dim request As Net.FtpWebRequest = CType(FtpWebRequest.Create("ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + folder_name), FtpWebRequest)
        request.Credentials = New NetworkCredential("ftp", "jahoor9580")
        request.Method = WebRequestMethods.Ftp.MakeDirectory

        Try
            Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                ' Folder created
            End Using
        Catch ex As WebException
            Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            ' an error occurred
            If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If
        End Try
        Return True
    End Function

    Private Sub Form15_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Ok_but_Click(sender As Object, e As EventArgs) Handles Ok_but.Click
        If newimage = True Then
            'upload new image to server
            Status_lbl.Text = "Uploading image to server"
            UploadFTP()
            ShowFileList(TradeItemGUID)
            Status_lbl.Text = "Image saved"
        End If

        If exportgrid = 1 Then
            If flexgridrow > 0 And flexgridcol > 0 Then
                Form1.DatabaseFlexGridShow.Item(flexgridrow, flexgridcol) = selectedImage
                Form1.DatabaseFlexGridShow.Item(flexgridrow, 1) = True 'edit flag
                exportgrid = 0
            End If
        End If


        If exportgrid = 2 Then
            If flexgridrow > 0 And flexgridcol > 0 Then
                Form1.Order_invoer_FlexGrid.Item(flexgridrow, flexgridcol) = selectedImage
                exportgrid = 0
            End If
        End If



        Me.Close()

    End Sub

    Private Function MakeValidFilename(test As String) As String

        Const validstring As String = " 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-"
        'naam 
        For ct = 1 To test.Length
            Dim teken As String = Mid(test, ct, 1)
            Dim valid As Boolean = False
            For cr = 1 To validstring.Length
                If teken = Mid(validstring, cr, 1) Then
                    valid = True
                    Exit For
                End If
            Next
            If valid = False Then
                test = test.Replace(teken, "@")
            End If
        Next
        test = Trim(test.Replace("@", ""))


        Return test

    End Function

    Private Sub UploadFTP()

        Dim filename As String = ""
        Dim tradeitemname As String = MakeValidFilename(Mid(tradeitem_lbl.Text, 1, 25))
        Dim s_rijpheid As String = ""
        If rijpheid > 0 Then s_rijpheid = "_R" + Trim(Str(rijpheid))
        Dim s_hoogte As String = ""
        If hoogte > 0 Then s_hoogte = "_H" + Trim(Str(hoogte))
        Dim s_diameter As String = ""
        If diameter > 0 Then s_diameter = "_D" + Trim(Str(diameter))
        Dim s_fust As String = ""
        If fustcode <> 999 Then s_fust = "_F" + Trim(Str(fustcode))
        Dim s_keurcode As String = "_K" + Trim(Str(keurcode))

        filename = tradeitemname + "-" + s_fust + s_rijpheid + s_hoogte + s_diameter
        If keurcode > 0 Then filename = filename + "_A2-" + s_keurcode
        filename = filename + "-" + Format(Now, "yyMMddHHmmss") + ".jpg"

        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + TradeItemGUID + "/" + filename), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential("ftp", "jahoor9580")
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim picStream As New MemoryStream
        foto_PictureBox.Image.Save(picStream, ImageFormat.Jpeg)

        Dim file() As Byte = picStream.ToArray
        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()

        selectedimage_lbl.Text = "Selected image: " + filename
        selectedImage = TradeItemGUID + "/" + filename

    End Sub

    Private Sub test_but_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Foto_Filelist_flx_CellButtonClick(sender As Object, e As RowColEventArgs) Handles Foto_Filelist_flx.CellButtonClick
        Dim fpath = TradeItemGUID + "/"
        Dim filename As String = CType(Foto_Filelist_flx.GetData(e.Row, 1), String)
        ShowImage(fpath + filename)
    End Sub


    Private Sub ShowImage(filepath As String)
        Try


            Dim filepath2 As String = "ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + filepath
            Dim reqFTP As FtpWebRequest = Nothing
            reqFTP = DirectCast(WebRequest.Create(filepath2), FtpWebRequest)

            reqFTP.Method = WebRequestMethods.Ftp.GetFileSize
            reqFTP.Credentials = New NetworkCredential("ftp", "jahoor9580")
            Dim filelength As Integer = 0
            Using ftpResponse As FtpWebResponse = DirectCast(reqFTP.GetResponse, FtpWebResponse)
                filelength = CInt(ftpResponse.ContentLength)
            End Using

            reqFTP = DirectCast(WebRequest.Create(filepath2), FtpWebRequest)
            reqFTP.Method = WebRequestMethods.Ftp.DownloadFile
            reqFTP.Credentials = New NetworkCredential("ftp", "jahoor9580")

            Dim bytebuffer(filelength) As Byte
            Status_lbl.Text = "Downloading"
            Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                Using reader As New BinaryReader(responseStream)

                    ' Loop through length of file
                    Dim pos As Integer = 0
                    ReDim bytebuffer(filelength)
                    While pos < filelength
                        bytebuffer(pos) = reader.ReadByte()
                        pos += 1

                        If pos Mod 100000 = 0 Then
                            Status_lbl.Text = Status_lbl.Text + "."
                            Application.DoEvents()
                        End If

                    End While

                End Using
            End Using
            Status_lbl.Text = "Done."
            foto_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
            Dim picStream2 As New MemoryStream(bytebuffer)
            foto_PictureBox.Image = Image.FromStream(picStream2)

            selectedImage = filepath
            selectedimage_lbl.Text = "Selected image: " + filepath

        Catch ex As Exception
            MsgBox("Directory read error")
        End Try

    End Sub

    Private Sub Verwijderen_but_Click(sender As Object, e As EventArgs) Handles Verwijderen_but.Click

        For i = 1 To Foto_Filelist_flx.Rows.Count - 1

            If Foto_Filelist_flx.GetData(i, 0) = True Then
                Dim filename = Foto_Filelist_flx.GetData(i, 1)
                Dim filepath As String = "ftp://" + Trim(My.Settings.MySQL_Server) + "/Fotos/" + TradeItemGUID + "/" + filename

                Dim answer As DialogResult = MessageBox.Show(filename + " verwijderen van server?", "Foto wissen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then

                    Dim request As FtpWebRequest = WebRequest.Create(filepath)
                    request.Credentials = New NetworkCredential("ftp", "jahoor9580")
                    request.Method = WebRequestMethods.Ftp.DeleteFile

                    Dim response As FtpWebResponse = request.GetResponse
                    MsgBox(response.StatusDescription)
                    response.Close()

                    ShowFileList(TradeItemGUID)

                End If
            End If
        Next

    End Sub
End Class