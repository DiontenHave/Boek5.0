Imports System.Text
Imports System.IO
Imports System.Data.Odbc

Public Class LabelWindow

    'filetype = 0 : gemaakt door boek
    'filetype = 1 : import via bartender
    'filetype = 2 : oz pot label
    'filetype = 3 : oz fust label
    'filetype = 4 : labelbericht


    Dim file_type As Integer = 0
    Dim bartendercode As String = ""
    Dim flexgridrownr As Integer = 1
    Dim labelnummer As Integer = 0
    Dim save_target As Integer = 0   '(0 = orderinvoer, 1 = florecom, 2 = floriday)

    Dim selected_label_id As Integer = 0
    Dim selected_label_aantal As Integer = 0
    Dim selected_label_zpl As String = ""
    Dim selected_label_info As String = ""
    Dim labelbuttontype As Integer = 1

    Dim save_soort_id As Integer = 0
    Dim save_fust_id As Integer = 0
    Dim save_aantal As Integer = 0

    Dim demoxscale As Double = 1
    Dim demoyscale As Double = 1

    Public Sub Init(ByVal rowlabelnummer As Integer, ByVal soort_id As Integer, ByVal aantal As Integer, ByVal fust_id As Integer, ByVal flexgridrow As Integer, ByVal koper_ean As String, ByVal koper_naam As String, ByVal opmerkingboek As String, ByVal accessoire1naam As String, ByVal savetarget As Integer)
        labelnummer = rowlabelnummer

        save_soort_id = soort_id
        save_aantal = aantal
        save_fust_id = fust_id

        Dim soort As String = soorten(Form1.GID(soorten, soort_id)).soortnaam
        Soortnaam_lbl.Text = soort
        Soortnaam_lbl.Tag = Str(soort_id)
        'LabelType_OrderlineSpec_rb.Tag = Str(aantal) + " x " + Trim(Str(fust(Form1.GID(fust, fust_id)).aantal_per_fust)) + " " + soort
        flexgridrownr = flexgridrow
        save_target = savetarget
        Id_lbl.Text = "0"

        OpmerkingBoek_txt.Text = opmerkingboek

        labelbuttontype = 5
        checkradiobuttonsLBL()

        listtitel_lbl.Text = koper_naam
        listtitel_lbl.Tag = koper_ean

        LoadLabelOverzicht(koper_ean)

        If labelnummer > 0 Then

            ' load label 
            Naam_txt.Text = "Label " + Format(Now, "dd-MMM-yyyy HH:mm:ss")
            file_type = 0
            ShowVoorbeeld(PictureBox1)
            Naam_txt.Enabled = True
            Aantal_txt.Enabled = True
            Top1_txt.Enabled = True
            Top2_txt.Enabled = True
            EAN_txt.Enabled = True
            Bottom1_txt.Enabled = True
            ImportBartenderFile_but.Enabled = True
            ClearBartenderFile_but.Enabled = True
            Voorbeeld_but.Enabled = True
            Print_but.Enabled = True
            Opslaanlabel_but.Enabled = True

            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    Dim Reader As OdbcDataReader

                    Dim cmdstring As String = "SELECT * FROM label_info WHERE id = " + Str(labelnummer)
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)
                    Reader = Cmd.ExecuteReader()
                    If Reader.HasRows Then
                        Reader.Read()
                        Opmerking_txt.Text = CHstr(Reader("soortline"))
                    End If
                    Reader.Close()

                    Dim zpl_id As Integer = -1

                    Dim Reader2 As OdbcDataReader
                    Dim cmdstring2 As String = "SELECT * FROM label_data WHERE labelinfo_id = " + Str(labelnummer) + " ORDER BY type DESC"
                    Dim Cmd2 As New OdbcCommand(cmdstring2, Conn)
                    Reader2 = Cmd2.ExecuteReader()
                    If Reader2.HasRows Then
                        Reader2.Read()
                        'Aantal_txt.Text = CHstr(Reader2("aantal"))

                        Aantal_txt.Text = Str(aantal * fust(Form1.GID(fust, fust_id)).aantal_per_fust)

                        zpl_id = CHint(Reader2("zpl_id"))

                        Labelid_lbl.Tag = Str(zpl_id)
                        Labelid_lbl.Text = "Label id: " + Str(zpl_id)
                    End If
                    Reader2.Close()

                    If zpl_id >= 0 Then
                        Dim cmdstring3 As String = "SELECT * FROM label_zpl WHERE id = " + Str(zpl_id)

                        Dim Reader3 As OdbcDataReader
                        Dim Cmd3 As New OdbcCommand(cmdstring3, Conn)

                        Reader3 = Cmd3.ExecuteReader()
                        If Reader3.HasRows Then

                            Reader3.Read()
                            Dim labeltype As Integer = Reader3("label_type")
                            If labeltype = 0 Then
                                Top1_txt.Text = CHstr(Reader3("top1"))
                                Top2_txt.Text = CHstr(Reader3("top2"))
                                EAN_txt.Text = CHstr(Reader3("ean13"))
                                Bottom1_txt.Text = CHstr(Reader3("bottom"))
                                file_type = 0
                                Aantal_txt.Enabled = True
                                Top1_txt.Enabled = True
                                Top2_txt.Enabled = True
                                EAN_txt.Enabled = True
                                Bottom1_txt.Enabled = True
                                ExtraTextBakstikker_txt.Text = CHstr(Reader3("opmerkingfustlabel"))
                                ShowVoorbeeld(PictureBox2)
                            End If
                            If labeltype = 1 Then
                                Naam_txt.Enabled = True
                                Aantal_txt.Enabled = True
                                Top1_txt.Enabled = False
                                Top2_txt.Enabled = False
                                EAN_txt.Enabled = False
                                Bottom1_txt.Enabled = False
                                ExtraTextBakstikker_txt.Text = CHstr(Reader3("opmerkingfustlabel"))
                                bartendercode = Reader3("zplcode")
                                ShowBartenderVoorbeeld(bartendercode, PictureBox2)
                                file_type = 1
                            End If
                            If labeltype = 2 Or labeltype = 3 Then
                                Naam_txt.Enabled = False
                                Aantal_txt.Enabled = False
                                Top1_txt.Enabled = False
                                Top2_txt.Enabled = False
                                EAN_txt.Enabled = False
                                Bottom1_txt.Enabled = False
                                ImportBartenderFile_but.Enabled = False
                                ClearBartenderFile_but.Enabled = False
                                Voorbeeld_but.Enabled = False
                                Print_but.Enabled = False
                                Opslaanlabel_but.Enabled = False
                                ExtraTextBakstikker_txt.Text = CHstr(Reader3("opmerkingfustlabel"))
                                bartendercode = CHstr(Reader3("zplcode"))
                                ShowBartenderVoorbeeld(bartendercode, PictureBox2)
                                file_type = 2
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try

        Else  '(nieuw label)
            Labelid_lbl.Tag = "0"
            LoadAvailableDefault(koper_ean, soort_id)

            Naam_txt.Text = "Label " + Format(Now, "dd-MMM-yyyy HH:mm:ss")
            file_type = 0
            If koper_ean = "8714231204244" Or koper_ean = "8718288009340" Then
                ExtraTextBakstikker_txt.Text = opmerkingboek
            Else

                ExtraTextBakstikker_txt.Text = accessoire1naam
            End If
            ShowVoorbeeld(PictureBox1)
            Naam_txt.Enabled = True
            Aantal_txt.Enabled = True
            Top1_txt.Enabled = True
            Top2_txt.Enabled = True
            EAN_txt.Enabled = True
            Bottom1_txt.Enabled = True
            ImportBartenderFile_but.Enabled = True
            ClearBartenderFile_but.Enabled = True
            Voorbeeld_but.Enabled = True
            Print_but.Enabled = True
            Opslaanlabel_but.Enabled = True

        End If
        voorbeeldprinter_cmb.SelectedIndex = 6

        'load private label info 


        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Reader As OdbcDataReader
                private_cmb.Items.Clear()
                Dim cmdstring As String = "SELECT * FROM label_private_label"
                Dim Cmd As New OdbcCommand(cmdstring, Conn)
                Reader = Cmd.ExecuteReader()
                Do While Reader.Read
                    Dim id As Integer = CHint(Reader("id"))
                    Dim naam As String = CHstr(Reader("naam"))
                    private_cmb.Items.Add(Trim(Str(id)) + ":  " + naam)
                Loop
                Reader.Close()
                private_cmb.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MsgBox("Fout private label laden: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try


    End Sub


    Private Sub LoadAvailableDefault(ByVal koper_ean As String, ByVal soort_id As Integer)

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Reader As OdbcDataReader
                Dim cmdstring As String = "SELECT * FROM label_default WHERE koper_ean = '" + koper_ean + "' AND Soort_id =" + Str(soort_id)
                Dim Cmd As New OdbcCommand(cmdstring, Conn)
                Dim labelfound As Boolean = False

                Reader = Cmd.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()

                    Dim zpl_id As Integer = CHint(Reader("label_id"))
                    ShowSelectedLabel(zpl_id)
                    Dim soortline As String = CHstr(Reader("soortline"))
                    Dim type As Integer = CHint(Reader("type"))               'absolete
                    Dim aantal As Integer = CHint(Reader("aantal"))
                    Opmerking_txt.Text = soortline
                    ' Aantal_txt.Text = Str(aantal)
                    labelbuttontype = type
                    checkradiobuttonsLBL()

                    labelfound = True
                End If
                Reader.Close()
                If labelfound = False Then   'algemeen label?

                    Dim cmdstring2 As String = "SELECT * FROM label_default WHERE koper_ean = '" + koper_ean + "' AND Soort_id = -1"
                    Dim Cmd2 As New OdbcCommand(cmdstring2, Conn)

                    Reader = Cmd2.ExecuteReader()
                    If Reader.HasRows Then
                        Reader.Read()

                        Dim zpl_id As Integer = CHint(Reader("label_id"))
                        ShowSelectedLabel(zpl_id)
                        Dim soortline As String = CHstr(Reader("soortline"))
                        Dim type As Integer = CHint(Reader("type"))
                        Dim aantal As Integer = CHint(Reader("aantal"))
                        Opmerking_txt.Text = soortline
                        'Aantal_txt.Text = Str(aantal)
                        labelbuttontype = type
                        checkradiobuttonsLBL()

                    End If
                    Reader.Close()
                End If

            End Using
        Catch ex As Exception
            MsgBox("Fout labeldefaults laden: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub Print_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_but.Click

        Dim ipAddress As String = Trim(Form1.Inst_printerip_txt.Text)
        'If voorbeeldprinter_cmb.SelectedIndex = 0 Then ipAddress = "192.168.2.225"
        'If voorbeeldprinter_cmb.SelectedIndex = 1 Then ipAddress = "192.168.2.247"
        'If voorbeeldprinter_cmb.SelectedIndex = 2 Then ipAddress = "192.168.2.225"
        'If voorbeeldprinter_cmb.SelectedIndex = 3 Then ipAddress = "192.168.2.225"
        'If voorbeeldprinter_cmb.SelectedIndex = 4 Then ipAddress = "192.168.2.225"
        'If voorbeeldprinter_cmb.SelectedIndex = 5 Then ipAddress = "192.168.2.226"
        'If voorbeeldprinter_cmb.SelectedIndex = 6 Then ipAddress = "192.168.2.225"
        'If voorbeeldprinter_cmb.SelectedIndex = 7 Then ipAddress = "192.168.2.6"


        Dim port As Integer = 9100
        Dim zplcode As String = ""
        If file_type = 0 Then


            Dim top1 As String = Top1_txt.Text
            Dim top2 As String = Top2_txt.Text
            Dim barcode As String = EAN_txt.Text
            Dim bottom As String = Bottom1_txt.Text

            Dim toph1 As String = "40"
            Dim toph2 As String = "110"
            Dim toph3 As String = "170"
            Dim toph4 As String = "380"

            Dim len_top1 As Integer = Len(top1)
            If len_top1 > 20 Then len_top1 = 20
            Dim len_top2 As Integer = Len(top2)
            If len_top2 > 25 Then len_top2 = 25
            Dim len_bot As Integer = Len(bottom)
            If len_bot > 20 Then len_bot = 20

            Dim starttop1 As String = "100"
            Dim starttop2 As String = "100"
            Dim startbottom As String = "100"
            starttop1 = Trim(Str(50 + (22 - len_top1) * 10))
            starttop2 = Trim(Str(50 + (27 - len_top2) * 12))
            startbottom = Trim(Str(80 + (22 - len_bot) * 10))


            Dim top1A As String = ""
            For i = 1 To Len(top1)
                Dim zplchar As String = Mid(top1, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top1A = top1A + "+"
                ElseIf zplchar = "€" Then
                    top1A = top1A + "_15"
                Else
                    top1A = top1A + zplchar
                End If
            Next
            Dim top2A As String = ""
            For i = 1 To Len(top2)
                Dim zplchar As String = Mid(top2, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top2A = top2A + "+"
                ElseIf zplchar = "€" Then
                    top2A = top2A + "_15"
                Else
                    top2A = top2A + zplchar
                End If
            Next
            Dim bottom2 As String = ""
            For i = 1 To Len(bottom)
                Dim zplchar As String = Mid(bottom, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    bottom2 = bottom2 + "+"
                ElseIf zplchar = "€" Then
                    bottom2 = bottom2 + "_15"
                Else
                    bottom2 = bottom2 + zplchar
                End If
            Next


            Dim streephoogte As String = "150"
            If top2A = "" Then  'geen 2de toptext
                streephoogte = "200"
                toph3 = "120"
            End If

            If top1A = "" Then  'geen 1ste toptext
                streephoogte = "200"
                toph3 = "120"
                toph2 = "50"
            End If

            If top1A = "" And top2A = "" Then  ' 2x geen  toptext
                streephoogte = "250"
                toph3 = "50"
            End If

            If bottom2 = "" Then
                streephoogte = streephoogte + 50
            End If

            If barcode = "" Then
                toph1 = toph1 + 150
                toph2 = toph2 + 150
            End If

            Dim ZPLString1 As String = "^XA^FO" + starttop1 + "," + toph1 + "^A0N,50,50^FH^FD" + top1A + "^FS"  'bovenste regel 1
            Dim ZPLString2 As String = "^FO" + starttop2 + "," + toph2 + "^A0N,40,30^FH^FD" + top2A + "^FS"  'bovenste regel 2
            Dim ZPLString3 As String = ""
            If barcode <> "" Then
                If Len(barcode) = 8 Then
                    ZPLString3 = "^FO180," + toph3 + "^BY4^B8N," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode
                Else
                    ZPLString3 = "^FO150," + toph3 + "^BY4^BEN," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode ean 13
                End If
            End If
            Dim ZPLString4 As String = "^FO" + startbottom + "," + toph4 + "^A0N,50,50^FH^FD" + bottom2 + "^FS"  'onderste regel
            zplcode = ZPLString1 + ZPLString2 + ZPLString3 + ZPLString4 + "^PQ1~SD23^XZ"
        ElseIf file_type = 1 Then
            If bartendercode = "" Then
                Exit Sub
            Else
                zplcode = bartendercode + "^PQ1^XZ"
            End If

        ElseIf file_type = 2 Then
            MsgBox("Geen voorbeeld van labelbericht mogelijk")
            Exit Sub
        End If

        Try
            'Open Connection
            Dim client As New System.Net.Sockets.TcpClient
            client.Connect(ipAddress, port)

            'Write ZPL String to Connection
            Dim writer As New System.IO.StreamWriter(client.GetStream())
            writer.Write(zplcode)

            writer.Flush()

            writer.Close()
            client.Close()

        Catch ex As Exception

            'Catch Exception Here

        End Try


    End Sub
    Private Sub Voorbeeld_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Voorbeeld_but.Click
        ShowVoorbeeld(PictureBox1)
    End Sub
    Private Sub ShowVoorbeeld(ByVal picturebox As PictureBox)

        If file_type = 0 Then

            Dim top1 As String = Top1_txt.Text
            Dim top2 As String = Top2_txt.Text
            Dim barcode As String = EAN_txt.Text
            Dim bottom As String = Bottom1_txt.Text

            Dim toph1 As String = "40"
            Dim toph2 As String = "110"
            Dim toph3 As String = "170"
            Dim toph4 As String = "380"

            Dim len_top1 As Integer = Len(top1)
            If len_top1 > 20 Then len_top1 = 20
            Dim len_top2 As Integer = Len(top2)
            If len_top2 > 25 Then len_top2 = 25
            Dim len_bot As Integer = Len(bottom)
            If len_bot > 20 Then len_bot = 20

            Dim starttop1 As String = "100"
            Dim starttop2 As String = "100"
            Dim startbottom As String = "100"
            starttop1 = Trim(Str(50 + (22 - len_top1) * 10))
            starttop2 = Trim(Str(50 + (27 - len_top2) * 12))
            startbottom = Trim(Str(80 + (22 - len_bot) * 10))


            Dim top1A As String = ""
            For i = 1 To Len(top1)
                Dim zplchar As String = Mid(top1, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top1A = top1A + "+"
                ElseIf zplchar = "€" Then
                    top1A = top1A + "_15"
                Else
                    top1A = top1A + zplchar
                End If
            Next
            Dim top2A As String = ""
            For i = 1 To Len(top2)
                Dim zplchar As String = Mid(top2, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top2A = top2A + "+"
                ElseIf zplchar = "€" Then
                    top2A = top2A + "_15"
                Else
                    top2A = top2A + zplchar
                End If
            Next
            Dim bottom2 As String = ""
            For i = 1 To Len(bottom)
                Dim zplchar As String = Mid(bottom, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    bottom2 = bottom2 + "+"
                ElseIf zplchar = "€" Then
                    bottom2 = bottom2 + "_15"
                Else
                    bottom2 = bottom2 + zplchar
                End If
            Next


            Dim streephoogte As String = "150"
            If top2A = "" Then  'geen 2de toptext
                streephoogte = "200"
                toph3 = "120"
            End If

            If top1A = "" Then  'geen 1ste toptext
                streephoogte = "200"
                toph3 = "120"
                toph2 = "50"
            End If

            If top1A = "" And top2A = "" Then  ' 2x geen  toptext
                streephoogte = "250"
                toph3 = "50"
            End If

            If bottom2 = "" Then
                streephoogte = streephoogte + 50
            End If

            If barcode = "" Then
                toph1 = toph1 + 150
                toph2 = toph2 + 150
            End If

            Dim Img As New Bitmap(picturebox.Width, picturebox.Height)
            Dim g As Graphics = Graphics.FromImage(Img)

            'Dim g As Graphics = PictureBox.CreateGraphics
            g.Clear(Color.White)
            ' Set up string.

            Dim measureString As String = Mid(top1, 1, 22)
            Dim stringFont As New Font("Arial", 12)
            ' Draw string to screen.
            Dim xcoor As Single = (starttop1 - 30) / 3.5
            Dim ycoor As Single = (toph1 - 40) / 3
            g.DrawString(measureString, stringFont, Brushes.Black, New PointF(xcoor, ycoor))


            Dim measureString2 As String = top2
            Dim stringFont2 As New Font("Arial", 8)
            ' Draw string to screen.
            Dim xcoor2 As Single = (starttop2 - 30) / 3.5
            Dim ycoor2 As Single = (toph2 - 40) / 3
            g.DrawString(measureString2, stringFont2, Brushes.Black, New PointF(xcoor2, ycoor2))

            Dim strhgt As Single = streephoogte / 3
            Dim xcoor3 As Single = 20
            Dim ycoor3 As Single = (toph3) / 3
            g.DrawRectangle(New Pen(Color.Black, 2), xcoor3, ycoor3, 150.0F, strhgt)

            Dim measureString4 As String = bottom
            Dim stringFont4 As New Font("Arial", 12)
            ' Draw string to screen.
            Dim xcoor4 As Single = (startbottom - 30) / 3.5
            Dim ycoor4 As Single = (toph4 - 40) / 3
            g.DrawString(measureString4, stringFont2, Brushes.Black, New PointF(xcoor4, ycoor4))

            ' Copy the source image into the destination bitmap.
            'gr_dest.DrawImage(Img, 0, 0, Img2.Width + 1, Img2.Height + 1)

            picturebox.Image = Img
        ElseIf file_type = 1 Then
            If bartendercode <> "" Then
                ShowBartenderVoorbeeld(bartendercode, PictureBox1)
            End If

        ElseIf file_type = 2 Then
            MsgBox("Nog geen voorbeeld van labelbericht mogelijk")
            Exit Sub
        End If

    End Sub
    Private Sub Opslaan_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaanlabel_but.Click

        Dim zplcode As String

        If file_type = 0 Then


            Dim top1 As String = Top1_txt.Text
            Dim top2 As String = Top2_txt.Text
            Dim barcode As String = Trim(EAN_txt.Text)
            If Not (Len(barcode) = 8 Or Len(barcode) = 13 Or Len(barcode) = 0) Then
                MsgBox("Barcode is niet correct (8 of 13 cijfers)")
                Exit Sub
            End If
            Dim bottom As String = Bottom1_txt.Text

            Dim toph1 As String = "40"
            Dim toph2 As String = "110"
            Dim toph3 As String = "170"
            Dim toph4 As String = "380"

            Dim len_top1 As Integer = Len(top1)
            If len_top1 > 20 Then len_top1 = 20
            Dim len_top2 As Integer = Len(top2)
            If len_top2 > 25 Then len_top2 = 25
            Dim len_bot As Integer = Len(bottom)
            If len_bot > 20 Then len_bot = 20

            Dim starttop1 As String = "100"
            Dim starttop2 As String = "100"
            Dim startbottom As String = "100"
            starttop1 = Trim(Str(50 + (22 - len_top1) * 10))
            starttop2 = Trim(Str(50 + (27 - len_top2) * 12))
            startbottom = Trim(Str(80 + (22 - len_bot) * 10))


            Dim top1A As String = ""
            For i = 1 To Len(top1)
                Dim zplchar As String = Mid(top1, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top1A = top1A + "+"
                ElseIf zplchar = "€" Then
                    top1A = top1A + "_15"
                Else
                    top1A = top1A + zplchar
                End If
            Next
            Dim top2A As String = ""
            For i = 1 To Len(top2)
                Dim zplchar As String = Mid(top2, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    top2A = top2A + "+"
                ElseIf zplchar = "€" Then
                    top2A = top2A + "_15"
                Else
                    top2A = top2A + zplchar
                End If
            Next
            Dim bottom2 As String = ""
            For i = 1 To Len(bottom)
                Dim zplchar As String = Mid(bottom, i, 1)
                If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                    bottom2 = bottom2 + "+"
                ElseIf zplchar = "€" Then
                    bottom2 = bottom2 + "_15"
                Else
                    bottom2 = bottom2 + zplchar
                End If
            Next


            Dim streephoogte As String = "150"
            If top2A = "" Then  'geen 2de toptext
                streephoogte = "200"
                toph3 = "120"
            End If

            If top1A = "" Then  'geen 1ste toptext
                streephoogte = "200"
                toph3 = "120"
                toph2 = "50"
            End If

            If top1A = "" And top2A = "" Then  ' 2x geen  toptext
                streephoogte = "250"
                toph3 = "50"
            End If

            If bottom2 = "" Then
                streephoogte = streephoogte + 50
            End If

            If barcode = "" Then
                toph1 = toph1 + 150
                toph2 = toph2 + 150
            End If

            Dim ZPLString1 As String = "^XA^FO" + starttop1 + "," + toph1 + "^A0N,50,50^FH^FD" + top1A + "^FS"  'bovenste regel 1
            Dim ZPLString2 As String = "^FO" + starttop2 + "," + toph2 + "^A0N,40,30^FH^FD" + top2A + "^FS^"  'bovenste regel 2
            Dim ZPLString3 As String = ""
            If barcode <> "" Then
                If Len(barcode) = 8 Then
                    ZPLString3 = "^FO180," + toph3 + "^BY4^B8N," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode
                Else
                    ZPLString3 = "^FO150," + toph3 + "^BY4^BEN," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode ean 13
                End If
            End If
            Dim ZPLString4 As String = "^FO" + startbottom + "," + toph4 + "^A0N,50,50^FH^FD" + bottom2 + "^FS"  'onderste regel
            '^PQ = label aantal
            zplcode = ZPLString1 + ZPLString2 + ZPLString3 + ZPLString4

        ElseIf file_type = 1 Then
            If bartendercode = "" Then Exit Sub
            zplcode = bartendercode

        Else
            Exit Sub
        End If

        Dim cmdstring As String = "SELECT * FROM label_zpl WHERE 1=0"
        Dim koper_ean As String = listtitel_lbl.Tag
        Dim labelnr As Integer = 0
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd As New OdbcCommand(cmdstring, Conn)

                If Naam_txt.Text = Naam_txt.Tag Then   'labelnaam is niet veranderd
                    If Val(Id_lbl.Text) > 0 Then
                        labelnr = Val(Id_lbl.Text)
                    End If
                End If

                If labelnr = 0 Then   'nieuw
                    Cmd.CommandText = "INSERT INTO label_zpl(koper_ean,datum,zplcode,label_type,naam,top1,top2,ean13,bottom,opmerkingfustlabel,privatelabel) VALUES(?,?,?,?,?,?,?,?,?,?,?)"
                Else
                    Cmd.CommandText = "UPDATE label_zpl SET koper_ean=?,datum=?,zplcode=?,label_type=?,naam=?,top1=?,top2=?,ean13=?,bottom=?,opmerkingfustlabel=?,privatelabel=? WHERE id =" + Trim(Str(labelnr))
                End If


                Dim datum As String = Format(Now, "yyyy-MM-dd")
                Dim label_type As Integer = file_type
                Dim aantal As Integer = Val(Aantal_txt.Text)
                If aantal <= 0 Then aantal = 1
                Dim naam = Naam_txt.Text
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("", koper_ean)
                Cmd.Parameters.AddWithValue("", datum)
                Cmd.Parameters.AddWithValue("", zplcode)
                Cmd.Parameters.AddWithValue("", label_type)
                Cmd.Parameters.AddWithValue("", naam)
                Cmd.Parameters.AddWithValue("", Top1_txt.Text)
                Cmd.Parameters.AddWithValue("", Top2_txt.Text)
                Cmd.Parameters.AddWithValue("", EAN_txt.Text)
                Cmd.Parameters.AddWithValue("", Bottom1_txt.Text)
                Cmd.Parameters.AddWithValue("", ExtraTextBakstikker_txt.Text)
                If PrivateLabel_chk.Checked = True Then
                    Cmd.Parameters.AddWithValue("", 1)
                Else
                    Cmd.Parameters.AddWithValue("", 0)
                End If
                Cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MsgBox("Fout labelopslag: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
        LoadLabelOverzicht(koper_ean)

    End Sub
    Private Sub LoadLabelOverzicht(ByVal koper_ean As String)
        Dim cmdstring As String = ""

        If jenptenhave = True Then
            If Verbergfustlabels_chk.Checked = True Then
                cmdstring = "SELECT id,naam FROM label_zpl WHERE koper_ean = '" + koper_ean + "' AND NOT (naam LIKE 'Fust%') AND bericht = 0 order by naam"
            Else
                cmdstring = "SELECT id,naam FROM label_zpl WHERE koper_ean = '" + koper_ean + "' order by naam"
            End If
        Else
            If Verbergfustlabels_chk.Checked = True Then
                cmdstring = "SELECT id,naam FROM label_zpl WHERE koper_ean = '" + koper_ean + "' AND NOT (naam LIKE 'Fust%') AND bericht = 0 order by id desc"
            Else
                cmdstring = "SELECT id,naam FROM label_zpl WHERE koper_ean = '" + koper_ean + "' order by id desc"
            End If
        End If


        Dim labelnr As Integer = 0
        ListBox1.Items.Clear()
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Reader As OdbcDataReader
                Dim Cmd As New OdbcCommand(cmdstring, Conn)

                Reader = Cmd.ExecuteReader()
                Do While Reader.Read()
                    ListBox1.Items.Add(Trim(Str(Reader("id"))) + ": " + CHstr(Reader("naam")))
                Loop
            End Using
        Catch ex As Exception
            MsgBox("Fout labellijst laden: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub ImportBartenderFile_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportBartenderFile_but.Click

        Dim bytecount As Integer = 0
        Dim byteline As Integer = 0
        Dim labelpath As String = "c:\labels\label.zpl"
        If Not My.Computer.FileSystem.FileExists(labelpath) Then
            labelpath = "w:\labels\labels.zpl"
            If Not My.Computer.FileSystem.FileExists(labelpath) Then
                Exit Sub
            End If
        End If

        file_type = 1

        Naam_txt.Enabled = True
        Aantal_txt.Enabled = True
        Top1_txt.Enabled = False
        Top2_txt.Enabled = False
        EAN_txt.Enabled = False
        Bottom1_txt.Enabled = False
        Dim labelstring As String = ""

        labelstring = My.Computer.FileSystem.ReadAllText(labelpath, System.Text.Encoding.ASCII)
        Dim pos As Integer = InStr(labelstring, "~DG000.GRF")

        If pos = 0 Then
            MsgBox("Fout bij importeren label")
            Exit Sub
        End If

        Dim firstcomma As Integer = InStr(pos, labelstring, ",")
        Dim secondcomma As Integer = InStr(firstcomma + 1, labelstring, ",")
        Dim thirdcomma As Integer = InStr(secondcomma + 1, labelstring, ",")

        bytecount = Val(Mid(labelstring, firstcomma + 1, secondcomma - firstcomma - 1))
        byteline = Val(Mid(labelstring, secondcomma + 1, thirdcomma - secondcomma - 1))

        Dim startofimage As Integer = InStr(thirdcomma + 1, labelstring, ",")
        Dim endofimage As Integer = InStr(startofimage, labelstring, "^XA")
        Dim imagetext As String = Mid(labelstring, startofimage, endofimage - startofimage)

        'find 2nd part new bartender files zebra fonts
        Dim poszb As Integer = InStr(labelstring, "^XG")
        Dim zbstart As Integer = InStr(poszb, labelstring, "^FT")
        Dim zbend As Integer = InStr(poszb, labelstring, "^PQ")
        Dim zbblock As String = ""
        If zbstart > 0 And zbend > 0 Then
            zbblock = Mid(labelstring, zbstart, zbend - zbstart)
        End If
        Dim ZPLString1 As String = "^XA~DG000.GRF," + Trim(Str(bytecount)) + "," + Trim(Str(byteline)) + ","
        Dim ZPLSTring3 As String = "^XA^FS~SD25^FT0,0^XG000.GRF,1,1^FS"
        bartendercode = ZPLString1 + imagetext + ZPLSTring3 + zbblock

        ShowBartenderVoorbeeld(bartendercode, PictureBox1)
    End Sub
    Private Sub ShowBartenderVoorbeeld(ByVal labelstring As String, ByVal picturebox As PictureBox)

        Dim bytecount As Integer = 0
        Dim byteline As Integer = 0
        Dim pos As Integer = InStr(labelstring, "~DG000.GRF")
        Dim firstcomma As Integer = InStr(pos, labelstring, ",")
        Dim secondcomma As Integer = InStr(firstcomma + 1, labelstring, ",")
        Dim thirdcomma As Integer = InStr(secondcomma + 1, labelstring, ",")

        bytecount = Val(Mid(labelstring, firstcomma + 1, secondcomma - firstcomma - 1))
        byteline = Val(Mid(labelstring, secondcomma + 1, thirdcomma - secondcomma - 1))

        Dim startofimage As Integer = InStr(thirdcomma + 1, labelstring, ",")
        Dim endofimage As Integer = InStr(startofimage, labelstring, "^XA")
        Dim imagetext As String = Mid(labelstring, startofimage, endofimage - startofimage)

        DrawZPL(bytecount, byteline, imagetext, picturebox)

        'extra private label data laten zien?
        Dim privatelabel As Integer = InStr(labelstring, "^FO")
        If privatelabel > 0 Then
            Dim Img As New Bitmap(picturebox.Width, picturebox.Height)
            Img = picturebox.Image
            Dim g As Graphics = Graphics.FromImage(Img)


            'part 1
            Dim posx1 As Integer = InStr(labelstring, "^FO")
            If posx1 > 0 Then
                Dim firstcommax1 As Integer = InStr(posx1, labelstring, ",")
                Dim endposx1 As Integer = InStr(posx1, labelstring, "^A")
                Dim starttext1 As Integer = InStr(posx1, labelstring, "^FD")
                Dim endtext1 As Integer = InStr(posx1, labelstring, "^FS")
                If posx1 > 0 And firstcommax1 > 0 And endposx1 > 0 And starttext1 > 0 And endtext1 > 0 Then
                    Dim x1str As String = Mid(labelstring, posx1 + 3, firstcommax1 - posx1 - 3)
                    Dim y1str As String = Mid(labelstring, firstcommax1 + 1, endposx1 - firstcommax1 - 1)
                    Dim text1 As String = Mid(labelstring, starttext1 + 3, endtext1 - starttext1 - 3)
                    text1 = text1.Replace("_15", "€")
                    Dim stringFont As New Font("Arial", 10)
                    ' Draw string to screen.
                    Dim xcoor As Single = ((Val(x1str) - 30) / 3.5) * demoxscale
                    Dim ycoor As Single = ((Val(y1str) - 40) / 3) * demoyscale
                    g.DrawString(text1, stringFont, Brushes.Black, New PointF(xcoor, ycoor))
                End If
            End If

            'part 2
            posx1 = InStr(posx1 + 3, labelstring, "^FO")
            If posx1 > 0 Then
                Dim firstcommax1 As Integer = InStr(posx1, labelstring, ",")
                Dim endposx1 As Integer = InStr(posx1, labelstring, "^A")
                Dim starttext1 As Integer = InStr(posx1, labelstring, "^FD")
                Dim endtext1 As Integer = InStr(posx1, labelstring, "^FS")
                If posx1 > 0 And firstcommax1 > 0 And endposx1 > 0 And starttext1 > 0 And endtext1 > 0 Then
                    Dim x1str As String = Mid(labelstring, posx1 + 3, firstcommax1 - posx1 - 3)
                    Dim y1str As String = Mid(labelstring, firstcommax1 + 1, endposx1 - firstcommax1 - 1)
                    Dim text1 As String = Mid(labelstring, starttext1 + 3, endtext1 - starttext1 - 3)
                    text1 = text1.Replace("_15", "€")
                    Dim stringFont As New Font("Arial", 10)
                    ' Draw string to screen.
                    Dim xcoor As Single = ((Val(x1str) - 30) / 3.5) * demoxscale
                    Dim ycoor As Single = ((Val(y1str) - 40) / 3) * demoyscale
                    g.DrawString(text1, stringFont, Brushes.Black, New PointF(xcoor, ycoor))
                End If
            End If


            'part 3
            posx1 = InStr(posx1 + 3, labelstring, "^FO")
            If posx1 > 0 Then
                Dim firstcommax1 As Integer = InStr(posx1, labelstring, ",")
                Dim endposx1 As Integer = InStr(posx1, labelstring, "^A")
                Dim starttext1 As Integer = InStr(posx1, labelstring, "^FD")
                Dim endtext1 As Integer = InStr(posx1, labelstring, "^FS")
                If posx1 > 0 And firstcommax1 > 0 And endposx1 > 0 And starttext1 > 0 And endtext1 > 0 Then
                    Dim x1str As String = Mid(labelstring, posx1 + 3, firstcommax1 - posx1 - 3)
                    Dim y1str As String = Mid(labelstring, firstcommax1 + 1, endposx1 - firstcommax1 - 1)
                    Dim text1 As String = Mid(labelstring, starttext1 + 3, endtext1 - starttext1 - 3)
                    text1 = text1.Replace("_15", "€")
                    Dim stringFont As New Font("Arial", 10)
                    ' Draw string to screen.
                    Dim xcoor As Single = ((Val(x1str) - 30) / 3.5) * demoxscale
                    Dim ycoor As Single = ((Val(y1str) - 40) / 3) * demoyscale
                    g.DrawString(text1, stringFont, Brushes.Black, New PointF(xcoor, ycoor))
                End If
            End If


            picturebox.Image = Img
        End If
    End Sub
    Private Sub DrawZPL(ByVal bytecount As Integer, ByVal byteline As Integer, ByVal imagetext As String, ByVal picturebox As PictureBox)

        'strip down to ascii
        Dim tekstbytes As Byte() = Encoding.Unicode.GetBytes(imagetext)

        Dim xtot As Integer = byteline * 2
        Dim ytot As Integer = bytecount / byteline

        Dim Img As New Bitmap(byteline * 8, ytot)

        Dim pos As Integer = 0
        Dim kar As Byte

        Dim image_bytes(xtot, ytot) As Byte

        Dim multiply As Integer = 0

        For y = 0 To ytot - 1
            Dim xpos = 0
            Dim EndofLine As Boolean = False
            Do While EndofLine = False
                '  kar = Mid(tekst, pos, 1)
                kar = tekstbytes(pos)
                If kar = 0 Then
                    pos = pos + 1
                Else
                    If kar = Asc(":") Then     ' copy old scanline 
                        For x = 0 To xtot - 1
                            image_bytes(x, y) = image_bytes(x, y - 1)
                        Next
                        pos = pos + 1
                        EndofLine = True
                    End If
                    If kar = Asc(",") Then    ' fill rest line with 0
                        For x = xpos To xtot - 1
                            image_bytes(x, y) = 48
                        Next
                        pos = pos + 1
                        EndofLine = True
                    End If
                    If kar = Asc("!") Then    ' fill rest line with 1 ? useless unless they meant 15
                        For x = xpos To xtot - 1
                            image_bytes(x, y) = 49
                        Next
                        pos = pos + 1
                        EndofLine = True
                    End If


                    Dim findstr = "0123456789ABCDEFabcdef"
                    For i = 0 To findstr.Length
                        Dim fchr As String = Mid(findstr, i + 1, 1)
                        If Chr(kar) = fchr Then
                            If multiply = 0 Then multiply = 1
                            For x = xpos To xpos + multiply - 1
                                image_bytes(x, y) = kar
                            Next
                            pos = pos + 1
                            xpos = xpos + multiply
                            multiply = 0
                            If xpos >= xtot Then
                                EndofLine = True
                            End If
                            Exit For
                        End If
                    Next

                    findstr = "GHIJKLMNOPQRSTUVWXY"
                    For i = 0 To findstr.Length
                        Dim fchr As String = Mid(findstr, i + 1, 1)
                        If Chr(kar) = fchr Then
                            multiply = multiply + i + 1
                            pos = pos + 1
                            Exit For
                        End If
                    Next

                    findstr = "ghijklmnopqrstuvwxz"
                    For i = 0 To findstr.Length
                        Dim fchr As String = Mid(findstr, i + 1, 1)
                        If Chr(kar) = fchr Then
                            multiply = multiply + ((i + 1) * 20)
                            pos = pos + 1
                            Exit For
                        End If
                    Next

                End If
            Loop

            Dim nible As String
            For x = 0 To xtot - 1
                nible = image_bytes(x, y)
                Select Case nible
                    Case Asc("0")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("1")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("2")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("3")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("4")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("5")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("6")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("7")
                        Img.SetPixel(x * 4 + 0, y, Color.White)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("8")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("9")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("A")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("B")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.White)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("C")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("D")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.White)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)
                    Case Asc("E")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.White)
                    Case Asc("F")
                        Img.SetPixel(x * 4 + 0, y, Color.Black)
                        Img.SetPixel(x * 4 + 1, y, Color.Black)
                        Img.SetPixel(x * 4 + 2, y, Color.Black)
                        Img.SetPixel(x * 4 + 3, y, Color.Black)

                End Select

            Next

        Next

        Dim Img2 As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim gr_dest As Graphics = Graphics.FromImage(Img2)

        ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(Img, 0, 0, Img2.Width + 1, Img2.Height + 1)

        picturebox.Image = Img2


    End Sub
    Private Sub ClearBartenderFile_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBartenderFile_but.Click
        Naam_txt.Enabled = True
        Aantal_txt.Enabled = True
        Top1_txt.Enabled = True
        Top2_txt.Enabled = True
        EAN_txt.Enabled = True
        Bottom1_txt.Enabled = True
        file_type = 0
        ExtraTextBakstikker_txt.Text = ""
        ShowVoorbeeld(PictureBox1)
    End Sub
    
    Private Sub checkradiobuttonsLBL()

        'Aantal_txt.Text = "1000"

        Dim aantalperfust As Integer = fust(Form1.GID(fust, save_fust_id)).aantal_per_fust
        Dim fust_aantal As Integer = save_aantal
        If labelbuttontype = 3 Or labelbuttontype = 8 Then
            Aantal_txt.Text = Str(fust_aantal)
        Else
            Aantal_txt.Text = Str(aantalperfust * fust_aantal)
        End If

        If labelbuttontype = 1 Then Opmerking_txt.Text = "Label op pot"
        If labelbuttontype = 2 Then Opmerking_txt.Text = "Label op pot+bak"
        If labelbuttontype = 3 Then Opmerking_txt.Text = "Label alleen op bak"
        If labelbuttontype = 4 Then Opmerking_txt.Text = "Label op potcover"
        If labelbuttontype = 5 Then Opmerking_txt.Text = "Label op potcover+bak"
        If labelbuttontype = 6 Then Opmerking_txt.Text = "Label op hoes"
        If labelbuttontype = 7 Then Opmerking_txt.Text = "Label op hoes+bak"

        If PPopPot_rb.Checked = True Then
            Opmerking_txt.Text = "PP op pot+ " + Opmerking_txt.Text
        End If
        If PPopBak_rb.Checked = True Then
            Opmerking_txt.Text = "PP op fust+ " + Opmerking_txt.Text
        End If

    End Sub
    Private Sub Annuleren_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Annuleren_but.Click

        Me.Close()
    End Sub
    Private Sub Annuleer_en_wis_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Annuleer_en_wis_but.Click
        If save_target = 0 Then
            Form1.Order_invoer_FlexGrid.Item(flexgridrownr, labelcol) = ""

        ElseIf save_target = 1 Then
            Form1.SaveLineData("label_nummer", "0")
            Form1.SaveLineData("opmerkingboek", "")
            Form1.ShowLineData(FC_CurrentEditLine)

        ElseIf save_target = 2 Then

            Form1.SaveFloridayLabelData(flexgridrownr, 0, "")
        End If

        Me.Close()
    End Sub
    Private Sub Algemeenlbl_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Algemeenlbl_but.Click
        Naam_txt.Text = "Label " + Format(Now, "dd-MMM-yyyy HH:mm:ss")
    End Sub
    Private Sub Soortlbl_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Soortlbl_but.Click
        Naam_txt.Text = Soortnaam_lbl.Text + " " + Format(Now, "dd-MMM-yy HH:mm:ss")
    End Sub
    Private Sub pot_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pot_but.Click
        labelbuttontype = 1
        checkradiobuttonsLBL()
    End Sub
    Private Sub bakpot_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bakpot_but.Click
        labelbuttontype = 2
        checkradiobuttonsLBL()
    End Sub
    Private Sub bak_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bak_but.Click
        labelbuttontype = 3
        checkradiobuttonsLBL()
    End Sub
    Private Sub hoesbak_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoesbak_but.Click
        labelbuttontype = 7
        checkradiobuttonsLBL()
    End Sub
    Private Sub potcover_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles potcover_but.Click
        labelbuttontype = 4
        checkradiobuttonsLBL()
    End Sub
    Private Sub bakpotcover_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bakpotcover_but.Click
        labelbuttontype = 5
        checkradiobuttonsLBL()
    End Sub
    Private Sub hoes_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoes_but.Click
        labelbuttontype = 6
        checkradiobuttonsLBL()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim lijstitem As String = ListBox1.Items(ListBox1.SelectedIndex).ToString
        Dim lsplit() As String
        lsplit = lijstitem.Split(":")
        Dim lijst_id As Integer = Val(lsplit(0))

        Dim cmdstring As String = ""

        cmdstring = "SELECT * FROM label_zpl WHERE id = " + Str(lijst_id)

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Reader As OdbcDataReader
                Dim Cmd As New OdbcCommand(cmdstring, Conn)

                Reader = Cmd.ExecuteReader()
                Do While Reader.Read()
                    Dim labeltype As Integer = Reader("label_type")
                    If labeltype = 0 Then
                        Id_lbl.Text = Str(lijst_id)
                        Naam_txt.Text = CHstr(Reader("naam"))
                        Naam_txt.Tag = CHstr(Reader("naam"))
                        Top1_txt.Text = CHstr(Reader("top1"))
                        Top2_txt.Text = CHstr(Reader("top2"))
                        EAN_txt.Text = CHstr(Reader("ean13"))
                        Bottom1_txt.Text = CHstr(Reader("bottom"))
                        file_type = 0
                        Aantal_txt.Enabled = True
                        Top1_txt.Enabled = True
                        Top2_txt.Enabled = True
                        EAN_txt.Enabled = True
                        Bottom1_txt.Enabled = True
                        ExtraTextBakstikker_txt.Text = CHstr(Reader("opmerkingfustlabel"))
                        Dim privatelabelflag As Boolean = CHstr(Reader("privatelabel"))
                        If privatelabelflag = True Then
                            PrivateLabel_chk.Checked = True
                            SelectLabel_but.Enabled = False
                        Else
                            PrivateLabel_chk.Checked = False
                            SelectLabel_but.Enabled = True
                        End If
                        ShowVoorbeeld(PictureBox1)
                    End If
                    If labeltype = 1 Then
                        Id_lbl.Text = Str(lijst_id)
                        Naam_txt.Enabled = True
                        Naam_txt.Text = CHstr(Reader("naam"))
                        Naam_txt.Tag = CHstr(Reader("naam"))
                        Aantal_txt.Enabled = True
                        Top1_txt.Enabled = False
                        Top2_txt.Enabled = False
                        EAN_txt.Enabled = False
                        Bottom1_txt.Enabled = False
                        ExtraTextBakstikker_txt.Text = CHstr(Reader("opmerkingfustlabel"))
                        bartendercode = CHstr(Reader("zplcode"))
                        ShowBartenderVoorbeeld(bartendercode, PictureBox1)
                        file_type = 1
                        Dim privatelabelflag As Boolean = CHstr(Reader("privatelabel"))
                        If privatelabelflag = True Then
                            PrivateLabel_chk.Checked = True
                            SelectLabel_but.Enabled = False
                        Else
                            PrivateLabel_chk.Checked = False
                            SelectLabel_but.Enabled = True
                        End If
                    End If
                Loop
            End Using
        Catch ex As Exception
            MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub VerwijderenUitLijst_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerwijderenUitLijst_but.Click
        Dim lijstitem As String = ListBox1.Items(ListBox1.SelectedIndex).ToString
        Dim antwoord As Integer = MsgBox("Label: " + lijstitem + " verwijderen?", vbYesNo)
        If antwoord = vbYes Then
            Dim lsplit() As String
            lsplit = lijstitem.Split(":")
            Dim lijst_id As Integer = Val(lsplit(0))

            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    Dim cmdstring As String = "DELETE FROM label_zpl WHERE id = " + Str(lijst_id)
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)
                    Cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        LoadLabelOverzicht(listtitel_lbl.Tag)
        Labelid_lbl.Tag = ""

    End Sub
    Private Sub SelectLabel_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectLabel_but.Click
        If ListBox1.SelectedIndex >= 0 Then
            Dim lijstitem As String = ListBox1.Items(ListBox1.SelectedIndex).ToString
            Dim lsplit() As String
            lsplit = lijstitem.Split(":")
            Dim lijst_id As Integer = Val(lsplit(0))
            ShowSelectedLabel(lijst_id)
        End If
    End Sub
    Private Sub ShowSelectedLabel(ByVal lijst_id As Integer)
        Labelid_lbl.Tag = Str(lijst_id)
        Labelid_lbl.Text = "Label id: " + Str(lijst_id)

        Dim cmdstring As String = "SELECT * FROM label_zpl WHERE id = " + Str(lijst_id)
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Reader As OdbcDataReader
                Dim Cmd As New OdbcCommand(cmdstring, Conn)

                Reader = Cmd.ExecuteReader()
                Do While Reader.Read()
                    Dim labeltype As Integer = CHint(Reader("label_type"))
                    If labeltype = 0 Then
                        Top1_txt.Text = CHstr(Reader("top1"))
                        Top2_txt.Text = CHstr(Reader("top2"))
                        EAN_txt.Text = CHstr(Reader("ean13"))
                        Bottom1_txt.Text = CHstr(Reader("bottom"))
                        file_type = 0
                        Aantal_txt.Enabled = True
                        Top1_txt.Enabled = True
                        Top2_txt.Enabled = True
                        EAN_txt.Enabled = True
                        Bottom1_txt.Enabled = True
                        ExtraTextBakstikker_txt.Text = CHstr(Reader("opmerkingfustlabel"))
                        ShowVoorbeeld(PictureBox2)
                    End If
                    If labeltype = 1 Then
                        Naam_txt.Enabled = True
                        Aantal_txt.Enabled = True
                        Top1_txt.Enabled = False
                        Top2_txt.Enabled = False
                        EAN_txt.Enabled = False
                        Bottom1_txt.Enabled = False
                        ExtraTextBakstikker_txt.Text = CHstr(Reader("opmerkingfustlabel"))
                        bartendercode = CHstr(Reader("zplcode"))
                        ShowBartenderVoorbeeld(bartendercode, PictureBox2)
                        file_type = 1
                    End If
                Loop
            End Using
        Catch ex As Exception
            MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub GenereerLabelopdracht_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenereerLabelopdracht_but.Click
        GenereerLabels(False)
        Form1.Order_Pakboninfo_txt.Text = "Stikkers plakken!!!"
    End Sub



    Private Sub GenereerLabels(ByVal AlleenPaspoort As Boolean)

        Dim paspoort As Boolean = False
        If GeenPP_rb.Checked = False Then
            paspoort = True
        End If

        Dim normaallabel As Boolean = True
        If AlleenPaspoort = True Then
            normaallabel = False
        End If

        Dim cmdstring As String = "SELECT * FROM label_info WHERE 1=0"
        Dim koper_ean As String = listtitel_lbl.Tag
        Dim koper_naam As String = listtitel_lbl.Text
        Dim opmerking As String = Opmerking_txt.Text
        Dim datum As String = Format(Now, "yyyy-MM-dd")
        Dim info_id As Integer = -1
        Dim aantal As Integer = Val(Aantal_txt.Text)
        If aantal <= 0 Then
            MsgBox("Geef een aantal op")
            Exit Sub
        End If


        Dim aantalperfust As Integer = fust(Form1.GID(fust, save_fust_id)).aantal_per_fust
        Dim soort_id As Integer = save_soort_id
        Dim fust_aantal As Integer = save_aantal

        Dim paspoort_zpl As Integer = 0
        If paspoort = True Then
            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    'fetch paspoort id's
                    Dim paspoort1 As Integer = 0
                    Dim paspoort2 As Integer = 0
                    Dim paspoortb1 As Integer = 0
                    Dim paspoortb2 As Integer = 0
                    Dim Reader As OdbcDataReader
                    Dim Cmd As New OdbcCommand("SELECT * FROM instellingen", Conn)
                    Reader = Cmd.ExecuteReader()
                    If Reader.HasRows Then
                        Reader.Read()
                        paspoort1 = CHint(Reader("paspoort1"))
                        paspoort2 = CHint(Reader("paspoort2"))
                        paspoortb1 = CHint(Reader("paspoortb1"))
                        paspoortb2 = CHint(Reader("paspoortb2"))
                        'default
                        paspoort_zpl = paspoort1
                    End If
                    'vestiging van soort bepalen
                    If soort_id < 10000 Then
                        Dim Reader8 As OdbcDataReader
                        Dim Cmd8 As New OdbcCommand("SELECT * FROM soorten3 WHERE id=?", Conn)
                        Cmd8.Parameters.Clear()
                        Cmd8.Parameters.AddWithValue("", soort_id)
                        Reader8 = Cmd8.ExecuteReader()
                        If Reader8.HasRows Then
                            Reader8.Read()
                            Dim vestiging As Integer = CHint(Reader8("vestiging"))

                            If PPopBak_rb.Checked = True Then  'bak
                                If vestiging = 1 Then
                                    paspoort_zpl = paspoortb1
                                Else
                                    paspoort_zpl = paspoortb2
                                End If
                            Else  '                             pot
                                If vestiging = 1 Then
                                    paspoort_zpl = paspoort1
                                Else
                                    paspoort_zpl = paspoort2
                                End If
                            End If
                        End If
                    Else
                        Dim Reader9 As OdbcDataReader
                        Dim Cmd9 As New OdbcCommand("SELECT * FROM mixen WHERE id=?", Conn)
                        Cmd9.Parameters.Clear()
                        Cmd9.Parameters.AddWithValue("", soort_id - 10000)
                        Reader9 = Cmd9.ExecuteReader()
                        If Reader9.HasRows Then
                            Reader9.Read()
                            Dim vestiging As Integer = CHint(Reader9("vestiging"))
                            If PPopBak_rb.Checked = True Then  'bak
                                If vestiging = 1 Then
                                    paspoort_zpl = paspoortb1
                                Else
                                    paspoort_zpl = paspoortb2
                                End If
                            Else  '                             pot
                                If vestiging = 1 Then
                                    paspoort_zpl = paspoort1
                                Else
                                    paspoort_zpl = paspoort2
                                End If
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Fout genereer labelopslag d1: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If

        Dim zpl_id As Integer = Val(Labelid_lbl.Tag)
        If normaallabel = True Then
            If Not (labelbuttontype = 3) Then
                If zpl_id = 0 Then
                    MsgBox("Selecteer eerste een label")
                    Exit Sub
                End If
            End If
        End If

        If labelbuttontype = 5 Or labelbuttontype = 2 Or labelbuttontype = 3 Or labelbuttontype = 7 Then

            'genereer bak+potstikkers
            info_id = GenereerPotBakLabels(koper_ean, fust_aantal, aantalperfust, soort_id, zpl_id, opmerking, paspoort_zpl)

        Else 'genereer normale order
            Dim volgorde As Integer = 10000
            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()

                    Dim Cmd As New OdbcCommand(cmdstring, Conn)
                    Cmd.CommandText = "INSERT INTO label_info(datum,koper_ean,koper_naam,status,printer,soortline) VALUES(?,?,?,?,?,?)"
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", datum)
                    Cmd.Parameters.AddWithValue("", koper_ean)
                    Cmd.Parameters.AddWithValue("", koper_naam)
                    Cmd.Parameters.AddWithValue("", 0)
                    Cmd.Parameters.AddWithValue("", 0)
                    Cmd.Parameters.AddWithValue("", opmerking)
                    Cmd.ExecuteNonQuery()

                    If postgress = True Then
                        Dim Cmd5 As New OdbcCommand("SELECT CURRVAL(pg_get_serial_sequence('label_info','id'))", Conn)
                        info_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                    Else
                        Dim Cmd5 As New OdbcCommand("SELECT LAST_INSERT_ID()", Conn)
                        info_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                    End If

                    If info_id = -1 Then Exit Sub

                    If normaallabel = True And paspoort = False Then
                        'potstikker / geen paspoort
                        For i = 1 To (aantal / aantalperfust)
                            Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", aantalperfust)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 2)
                            Cmd2.Parameters.AddWithValue("", zpl_id)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()
                            volgorde = volgorde + 1
                        Next i
                    End If

                    If normaallabel = False And paspoort = True Then
                        'alleen paspoort op pot
                        If PPopPot_rb.Checked = True Then
                            For i = 1 To (aantal / aantalperfust)
                                Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                                Cmd2.Parameters.Clear()
                                Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                                Cmd2.Parameters.AddWithValue("", aantalperfust)
                                Cmd2.Parameters.AddWithValue("", 0)
                                Cmd2.Parameters.AddWithValue("", volgorde)
                                Cmd2.Parameters.AddWithValue("", info_id)
                                Cmd2.Parameters.AddWithValue("", 2)
                                Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                                Cmd2.Parameters.AddWithValue("", i)
                                Cmd2.ExecuteNonQuery()
                                volgorde = volgorde + 1
                            Next i
                        End If
                        'alleen paspoort op bak
                        If PPopBak_rb.Checked = True Then
                            For i = 1 To (aantal / aantalperfust)
                                Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                                Cmd2.Parameters.Clear()
                                Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                                Cmd2.Parameters.AddWithValue("", 1)
                                Cmd2.Parameters.AddWithValue("", 0)
                                Cmd2.Parameters.AddWithValue("", volgorde)
                                Cmd2.Parameters.AddWithValue("", info_id)
                                Cmd2.Parameters.AddWithValue("", 1)
                                Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                                Cmd2.Parameters.AddWithValue("", i)
                                Cmd2.ExecuteNonQuery()
                                volgorde = volgorde + 1
                            Next i
                        End If

                    End If

                    If normaallabel = True And paspoort = True And PPopPot_rb.Checked = True Then
                        'potstikker & paspoort pot
                        For i = 1 To aantal
                            Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", 1)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 2)
                            Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()

                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", 1)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 2)
                            Cmd2.Parameters.AddWithValue("", zpl_id)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()

                            volgorde = volgorde + 1
                        Next i
                    End If

                    If normaallabel = True And paspoort = True And PPopBak_rb.Checked = True Then
                        'potstikker & paspoort bak
                        For i = 1 To (aantal / aantalperfust)
                            Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", 1)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 1)
                            Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()

                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", aantalperfust)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 2)
                            Cmd2.Parameters.AddWithValue("", zpl_id)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()

                            volgorde = volgorde + 1
                        Next i
                    End If


                End Using
            Catch ex As Exception
                MsgBox("Fout genereer labelopslag: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If

        If save_target = 0 Then  ' genereer labels in orderinvoer

            Form1.Order_invoer_FlexGrid.Item(flexgridrownr, labelcol) = Str(info_id)
            If Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "" Then
                If AlleenPaspoort = True Then
                    If PPopPot_rb.Checked = True Then
                        Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "PP op Pot!!!"
                    Else
                        Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "PP op Bak!!!"
                    End If
                Else
                    If PPopPot_rb.Checked = True Then
                        Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "PPopPot+Stikker!!!"
                    ElseIf PPopBak_rb.Checked = True Then
                        Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "PPopBak+Stikker!!!"
                    Else
                        Form1.Order_invoer_FlexGrid.Item(flexgridrownr, opmerkingcol) = "Stikker !!!"
                    End If
                End If

            End If

        ElseIf save_target = 1 Then                    ' genereer labels in florecom overzicht

            Dim fopmerking As String = "Stikker!!!"
            If AlleenPaspoort = True Then
                If PPopPot_rb.Checked = True Then
                    fopmerking = "PP op Pot!!!"
                Else
                    fopmerking = "PP op Bak!!!"
                End If
            Else
                If PPopPot_rb.Checked = True Then
                    fopmerking = "PPopPot+Stikker!!!"
                ElseIf PPopBak_rb.Checked = True Then
                    fopmerking = "PPopBak+Stikker!!!"
                Else
                    fopmerking = "Stikker !!!"
                End If
            End If

            Form1.SaveLineData("label_nummer", Str(info_id))
            Form1.SaveLineData("opmerkingboek", fopmerking)
            Form1.ShowLineData(FC_CurrentEditLine)

        ElseIf save_target = 2 Then                    ' genereer labels in floriday overzicht

            Dim fopmerking As String = "Stikker!!!"
            If AlleenPaspoort = True Then
                If PPopPot_rb.Checked = True Then
                    fopmerking = "PP op Pot!!!"
                Else
                    fopmerking = "PP op Bak!!!"
                End If
            Else
                If PPopPot_rb.Checked = True Then
                    fopmerking = "PPopPot+Stikker!!!"
                ElseIf PPopBak_rb.Checked = True Then
                    fopmerking = "PPopBak+Stikker!!!"
                Else
                    fopmerking = "Stikker !!!"
                End If
            End If

            Form1.SaveFloridayLabelData(flexgridrownr, info_id, opmerking)



        End If
        Me.Close()

    End Sub
    Private Sub Zet_Standaard_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zet_Standaard_but.Click
        If Val(Labelid_lbl.Tag) > 0 Or labelbuttontype = 3 Then
            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()

                    Dim koper_ean As String = listtitel_lbl.Tag
                    Dim soort_id As Integer = Val(Soortnaam_lbl.Tag)
                    Dim label_id As Integer = Val(Labelid_lbl.Tag)
                    Dim label_type As Integer = 1
                    'If LabelType_AlgP_rb.Checked = True Then
                    label_type = labelbuttontype
                    ' soort_id = -1
                    ' End If
                    'If LabelType_SoortSpec_rb.Checked = True Then label_type = 2
                    'If LabelType_OrderlineSpec_rb.Checked = True Then label_type = 3
                    Dim aantal As Integer = Val(Aantal_txt.Text)
                    If aantal <= 0 Then aantal = 1
                    Dim soortline As String = Opmerking_txt.Text

                    Dim cmdstring4 As String = "DELETE FROM label_default WHERE koper_ean = '" + koper_ean + "' AND soort_id =" + Str(soort_id)
                    Dim Cmd4 As New OdbcCommand(cmdstring4, Conn)
                    Cmd4.ExecuteNonQuery()

                    Dim cmdstring As String = ""
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)

                    Cmd.CommandText = "INSERT INTO label_default(koper_ean, soort_id, label_id, soortline, type, aantal) VALUES(?,?,?,?,?,?)"
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", koper_ean)
                    Cmd.Parameters.AddWithValue("", soort_id)
                    Cmd.Parameters.AddWithValue("", label_id)
                    Cmd.Parameters.AddWithValue("", soortline)
                    Cmd.Parameters.AddWithValue("", label_type)
                    Cmd.Parameters.AddWithValue("", aantal)

                    Cmd.ExecuteNonQuery()
                    MsgBox("Standaard opgeslagen")
                End Using
            Catch ex As Exception
                MsgBox("Fout labelopslag: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub
    Private Sub Delete_all_Defaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_All_Defaults_but.Click
        Dim antwoord As Integer = MsgBox("Alle Standaad labelkoppelingen verwijderen?", vbYesNo)
        If antwoord = vbYes Then
            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    Dim koper_ean = listtitel_lbl.Tag
                    Dim cmdstring As String = "DELETE FROM label_default WHERE koper_ean = '" + koper_ean + "'"
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Standaards verwijderd")
                End Using
            Catch ex As Exception
                MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        LoadLabelOverzicht(listtitel_lbl.Tag)
        Labelid_lbl.Tag = ""

    End Sub

    Private Function GenereerPotBakLabels(ByVal koper_ean As String, ByVal aantal As Integer, ByVal aantalperfust As Integer, ByVal soort As Integer, ByVal zpl_id As Integer, ByVal opmerking As String, ByVal paspoort_zpl As Integer) As Integer
        'maak fust label

        Dim curyear As String = Trim(Str(Year(Now)))
        If staticyear = True Then curyear = ""
        Dim orderline_db As String = "orderlines" + curyear
        Dim soortnaam As String = ""
        If soort < 10000 Then
            soortnaam = soorten(Form1.GID(soorten, soort)).labelnaam
        Else
            soortnaam = mixen(Form1.GID(mixen, soort - 10000)).labelnaam
        End If

        Dim mixnaam As String = mixen(Form1.GID(mixen, soort - 10000)).naam
        Dim labelnaam As String = "Fust " + soortnaam

        Dim fust_zplid As Integer = 0
        Dim fustopmerking As String = ""
        fustopmerking = Trim(ExtraTextBakstikker_txt.Text)

        If soort < 10000 Then
            fust_zplid = Maak_ZPL_Label(labelnaam, koper_ean, soortnaam, "", "", fustopmerking)
        Else
            fust_zplid = Maak_ZPL_Label(labelnaam, koper_ean, mixnaam, "", "", fustopmerking)
        End If

        'maak pot label

        Dim pot_zplid As Integer = zpl_id

        'vul info tabel
        Dim cmdstring As String = "SELECT * FROM label_info WHERE 1=0"
        Dim koper_naam As String = Form1.getkopernaam(koper_ean)
        Dim datum As String = Format(Now, "yyyy-MM-dd")
        Dim info_id As Integer = -1
        Dim volgorde As Integer = 10000
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Cmd As New OdbcCommand(cmdstring, Conn)
                Cmd.CommandText = "INSERT INTO label_info(datum,koper_ean,koper_naam,status,printer,soortline) VALUES(?,?,?,?,?,?)"
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("", datum)
                Cmd.Parameters.AddWithValue("", koper_ean)
                Cmd.Parameters.AddWithValue("", koper_naam)
                Cmd.Parameters.AddWithValue("", 0)
                Cmd.Parameters.AddWithValue("", 0)
                Cmd.Parameters.AddWithValue("", opmerking)
                Cmd.ExecuteNonQuery()

                If postgress = True Then
                    Dim Cmd5 As New OdbcCommand("SELECT CURRVAL(pg_get_serial_sequence('label_info','id'))", Conn)
                    info_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                Else
                    Dim Cmd5 As New OdbcCommand("SELECT LAST_INSERT_ID()", Conn)
                    info_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                End If

                For i = 1 To aantal
                    'bakstikker
                    Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                    Cmd2.Parameters.Clear()
                    Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                    Cmd2.Parameters.AddWithValue("", 1)
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", volgorde)
                    Cmd2.Parameters.AddWithValue("", info_id)
                    Cmd2.Parameters.AddWithValue("", 1)
                    Cmd2.Parameters.AddWithValue("", fust_zplid)
                    Cmd2.Parameters.AddWithValue("", i)
                    Cmd2.ExecuteNonQuery()
                    volgorde = volgorde + 1
                    '
                    If PPopBak_rb.Checked = True And paspoort_zpl > 0 Then  'fust-stikker + pp
                        Cmd2.Parameters.Clear()
                        Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                        Cmd2.Parameters.AddWithValue("", 1)
                        Cmd2.Parameters.AddWithValue("", 0)
                        Cmd2.Parameters.AddWithValue("", volgorde)
                        Cmd2.Parameters.AddWithValue("", info_id)
                        Cmd2.Parameters.AddWithValue("", 1)
                        Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                        Cmd2.Parameters.AddWithValue("", i)
                        Cmd2.ExecuteNonQuery()
                        volgorde = volgorde + 1
                    End If


                    'potstikker
                    If Not (labelbuttontype = 3) Then

                        If paspoort_zpl = 0 Or PPopBak_rb.Checked = True Then

                            Cmd2.Parameters.Clear()
                            Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                            Cmd2.Parameters.AddWithValue("", aantalperfust)
                            Cmd2.Parameters.AddWithValue("", 0)
                            Cmd2.Parameters.AddWithValue("", volgorde)
                            Cmd2.Parameters.AddWithValue("", info_id)
                            Cmd2.Parameters.AddWithValue("", 2)
                            Cmd2.Parameters.AddWithValue("", pot_zplid)
                            Cmd2.Parameters.AddWithValue("", i)
                            Cmd2.ExecuteNonQuery()
                            volgorde = volgorde + 1
                        Else

                            For j = 1 To aantalperfust
                                Cmd2.Parameters.Clear()
                                Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                                Cmd2.Parameters.AddWithValue("", 1)
                                Cmd2.Parameters.AddWithValue("", 0)
                                Cmd2.Parameters.AddWithValue("", volgorde)
                                Cmd2.Parameters.AddWithValue("", info_id)
                                Cmd2.Parameters.AddWithValue("", 2)
                                Cmd2.Parameters.AddWithValue("", paspoort_zpl)
                                Cmd2.Parameters.AddWithValue("", i)
                                Cmd2.ExecuteNonQuery()
                                volgorde = volgorde + 1

                                Cmd2.Parameters.Clear()
                                Cmd2.CommandText = "INSERT INTO label_data(aantal,done,volgorde,labelinfo_id,type,zpl_id,positie) VALUES(?,?,?,?,?,?,?)"
                                Cmd2.Parameters.AddWithValue("", 1)
                                Cmd2.Parameters.AddWithValue("", 0)
                                Cmd2.Parameters.AddWithValue("", volgorde)
                                Cmd2.Parameters.AddWithValue("", info_id)
                                Cmd2.Parameters.AddWithValue("", 2)
                                Cmd2.Parameters.AddWithValue("", pot_zplid)
                                Cmd2.Parameters.AddWithValue("", i)
                                Cmd2.ExecuteNonQuery()
                                volgorde = volgorde + 1
                            Next


                        End If

                    End If
                Next i


            End Using
        Catch ex As Exception
            MsgBox("Fout genereer labelopslag: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
        Return info_id
    End Function
    Private Function Maak_ZPL_Label(ByVal labelnaam As String, ByVal koper_ean As String, ByVal Label_Top As String, ByVal label_top2 As String, ByVal Label_Ean As String, ByVal bottomstr As String) As Integer

        Dim zplcode As String
        Dim zpl_id As Integer = -1  ' return id of zpl-code in database

        Dim top1 As String = Label_Top
        Dim top2 As String = label_top2
        Dim barcode As String = Label_Ean
        Dim bottom As String = bottomstr

        Dim toph1 As String = "40"
        Dim toph2 As String = "110"
        Dim toph3 As String = "170"
        Dim toph4 As String = "380"

        Dim len_top1 As Integer = Len(top1)
        If len_top1 > 20 Then len_top1 = 20
        Dim len_top2 As Integer = Len(top2)
        If len_top2 > 25 Then len_top2 = 25
        Dim len_bot As Integer = Len(bottom)
        If len_bot > 20 Then len_bot = 20

        Dim starttop1 As String = "100"
        Dim starttop2 As String = "100"
        Dim startbottom As String = "100"
        starttop1 = Trim(Str(50 + (22 - len_top1) * 10))
        starttop2 = Trim(Str(50 + (27 - len_top2) * 12))
        startbottom = Trim(Str(80 + (22 - len_bot) * 10))


        Dim top1A As String = ""
        For i = 1 To Len(top1)
            Dim zplchar As String = Mid(top1, i, 1)
            If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                top1A = top1A + "+"
            ElseIf zplchar = "€" Then
                top1A = top1A + "_15"
            Else
                top1A = top1A + zplchar
            End If
        Next
        Dim top2A As String = ""
        For i = 1 To Len(top2)
            Dim zplchar As String = Mid(top2, i, 1)
            If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                top2A = top2A + "+"
            ElseIf zplchar = "€" Then
                top2A = top2A + "_15"
            Else
                top2A = top2A + zplchar
            End If
        Next
        Dim bottom2 As String = ""
        For i = 1 To Len(bottom)
            Dim zplchar As String = Mid(bottom, i, 1)
            If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                bottom2 = bottom2 + "+"
            ElseIf zplchar = "€" Then
                bottom2 = bottom2 + "_15"
            Else
                bottom2 = bottom2 + zplchar
            End If
        Next


        Dim streephoogte As String = "150"
        If top2A = "" Then  'geen 2de toptext
            streephoogte = "200"
            toph3 = "120"
        End If

        If top1A = "" Then  'geen 1ste toptext
            streephoogte = "200"
            toph3 = "120"
            toph2 = "50"
        End If

        If top1A = "" And top2A = "" Then  ' 2x geen  toptext
            streephoogte = "250"
            toph3 = "50"
        End If

        If bottom2 = "" Then
            streephoogte = streephoogte + 50
        End If

        If barcode = "" Then
            toph1 = toph1 + 150
            toph2 = toph2 + 150
            toph4 = "280"
        End If

        Dim ZPLString1 As String = "^XA^FO" + starttop1 + "," + toph1 + "^A0N,50,50^FH^FD" + top1A + "^FS"  'bovenste regel 1
        Dim ZPLString2 As String = "^FO" + starttop2 + "," + toph2 + "^A0N,40,30^FH^FD" + top2A + "^FS^"  'bovenste regel 2
        Dim ZPLString3 As String = ""
        If barcode <> "" Then
            If Len(barcode) = 8 Then
                ZPLString3 = "^FO180," + toph3 + "^BY4^B8N," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode
            Else
                ZPLString3 = "^FO150," + toph3 + "^BY4^BEN," + streephoogte + ",Y,N^FD" + barcode + "^FS"    'barcode ean 13
            End If
        End If
        Dim ZPLString4 As String = "^FO" + startbottom + "," + toph4 + "^A0N,50,50^FH^FD" + bottom2 + "^FS"  'onderste regel
        '^PQ = label aantal
        zplcode = ZPLString1 + ZPLString2 + ZPLString3 + ZPLString4

        Dim cmdstring As String = "SELECT * FROM label_zpl WHERE 1=0"

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd As New OdbcCommand(cmdstring, Conn)

                Cmd.CommandText = "INSERT INTO label_zpl(koper_ean,datum,zplcode,label_type,naam,top1,top2,ean13,bottom) VALUES(?,?,?,?,?,?,?,?,?)"
                Dim datum As String = Format(Now, "yyyy-MM-dd")
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("", koper_ean)
                Cmd.Parameters.AddWithValue("", datum)
                Cmd.Parameters.AddWithValue("", zplcode)
                Cmd.Parameters.AddWithValue("", 0)
                Cmd.Parameters.AddWithValue("", labelnaam)
                Cmd.Parameters.AddWithValue("", top1)
                Cmd.Parameters.AddWithValue("", top2)
                Cmd.Parameters.AddWithValue("", barcode)
                Cmd.Parameters.AddWithValue("", bottom)

                Cmd.ExecuteNonQuery()

                If postgress = True Then
                    Dim Cmd5 As New OdbcCommand("SELECT CURRVAL(pg_get_serial_sequence('label_zpl','id'))", Conn)
                    zpl_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                Else
                    Dim Cmd5 As New OdbcCommand("SELECT LAST_INSERT_ID()", Conn)
                    zpl_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                End If

            End Using
        Catch ex As Exception
            MsgBox("Fout labelopslag : " + ex.Message, MsgBoxStyle.OkOnly)
        End Try

        Return zpl_id

    End Function

    Private Sub Verbergfustlabels_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verbergfustlabels_chk.CheckedChanged
        If listtitel_lbl.Tag <> "" Then
            LoadLabelOverzicht(listtitel_lbl.Tag)
        End If
    End Sub

    Private Sub private_cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles private_cmb.SelectedIndexChanged
        Dim selectedtext As String = private_cmb.SelectedItem.ToString
        Dim selectedsplit() As String = Microsoft.VisualBasic.Strings.Split(selectedtext, ":")
        Dim selected_id As String = selectedsplit(0)

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Reader As OdbcDataReader
                Dim cmdstring As String = "SELECT * FROM label_private_label where id = " + selected_id
                Dim Cmd As New OdbcCommand(cmdstring, Conn)
                Reader = Cmd.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()
                    Dim id As Integer = CHint(Reader("id"))
                    Dim naam As String = CHstr(Reader("naam"))

                    Dim active1 As Boolean = CHbool(Reader("actief1"))
                    Dim x1 As Integer = CHint(Reader("x1"))
                    Dim y1 As Integer = CHint(Reader("y1"))
                    Dim font1 As String = CHstr(Reader("font1"))
                    Dim label1 As String = CHstr(Reader("label1"))
                    Dim text1 As String = CHstr(Reader("text1"))

                    If active1 = True Then
                        private1_lbl.Visible = True
                        private1_lbl.Text = label1
                        private1_txt.Visible = True
                        private1_txt.Text = text1
                        private_maaklabel_but.Visible = True
                    Else
                        private1_lbl.Visible = False
                        private1_txt.Visible = False
                        private_maaklabel_but.Visible = False
                    End If

                    Dim active2 As Boolean = CHbool(Reader("actief2"))
                    Dim x2 As Integer = CHint(Reader("x2"))
                    Dim y2 As Integer = CHint(Reader("y2"))
                    Dim font2 As String = CHstr(Reader("font2"))
                    Dim label2 As String = CHstr(Reader("label2"))
                    Dim text2 As String = CHstr(Reader("text2"))

                    If active2 = True Then
                        private2_lbl.Visible = True
                        private2_lbl.Text = label2
                        private2_txt.Visible = True
                        private2_txt.Text = text2
                    Else
                        private2_lbl.Visible = False
                        private2_txt.Visible = False
                    End If

                    Dim active3 As Boolean = CHbool(Reader("actief3"))
                    Dim x3 As Integer = CHint(Reader("x3"))
                    Dim y3 As Integer = CHint(Reader("y3"))
                    Dim font3 As String = CHstr(Reader("font3"))
                    Dim label3 As String = CHstr(Reader("label3"))
                    Dim text3 As String = CHstr(Reader("text3"))

                    If active3 = True Then
                        private3_lbl.Visible = True
                        private3_lbl.Text = label3
                        private3_txt.Visible = True
                        private3_txt.Text = text3
                    Else
                        private3_lbl.Visible = False
                        private3_txt.Visible = False
                    End If

                End If
                Reader.Close()
            End Using
        Catch ex As Exception
            MsgBox("Fout private label select: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub private_maaklabel_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles private_maaklabel_but.Click

        Dim selectedtext As String = private_cmb.SelectedItem.ToString
        Dim selectedsplit() As String = Microsoft.VisualBasic.Strings.Split(selectedtext, ":")
        Dim selected_id As String = selectedsplit(0)

        Dim id As Integer = 0
        Dim naam As String = ""

        Dim active1 As Boolean = False
        Dim x1 As Integer = 0
        Dim y1 As Integer = 0
        Dim font1 As String = ""
        Dim label1 As String = ""
        Dim text1 As String = ""

        Dim active2 As Boolean = False
        Dim x2 As Integer = 0
        Dim y2 As Integer = 0
        Dim font2 As String = ""
        Dim label2 As String = ""
        Dim text2 As String = ""

        Dim active3 As Boolean = False
        Dim x3 As Integer = 0
        Dim y3 As Integer = 0
        Dim font3 As String = ""
        Dim label3 As String = ""
        Dim text3 As String = ""

        Dim baselabelbuttontype As Integer = 5
        'load old data

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Reader As OdbcDataReader
                Dim cmdstring As String = "SELECT * FROM label_private_label where id = " + selected_id
                Dim Cmd As New OdbcCommand(cmdstring, Conn)
                Reader = Cmd.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()
                    id = CHint(Reader("id"))
                    naam = CHstr(Reader("naam"))

                    active1 = CHbool(Reader("actief1"))
                    x1 = CHint(Reader("x1"))
                    y1 = CHint(Reader("y1"))
                    font1 = CHstr(Reader("font1"))
                    label1 = CHstr(Reader("label1"))
                    text1 = CHstr(Reader("text1"))

                    active2 = CHbool(Reader("actief2"))
                    x2 = CHint(Reader("x2"))
                    y2 = CHint(Reader("y2"))
                    font2 = CHstr(Reader("font2"))
                    label2 = CHstr(Reader("label2"))
                    text2 = CHstr(Reader("text2"))

                    active3 = CHbool(Reader("actief3"))
                    x3 = CHint(Reader("x3"))
                    y3 = CHint(Reader("y3"))
                    font3 = CHstr(Reader("font3"))
                    label3 = CHstr(Reader("label3"))
                    text3 = CHstr(Reader("text3"))

                    baselabelbuttontype = Reader("labelbuttontype")
                    labelbuttontype = baselabelbuttontype
                    checkradiobuttonsLBL()

                    demoxscale = CHdouble(Reader("demoxscale"))  'load in globals
                    demoyscale = CHdouble(Reader("demoyscale"))

                End If
                Reader.Close()

                'set new data

                If active1 = True Then
                    text1 = Trim(private1_txt.Text)
                    Cmd.CommandText = "UPDATE label_private_label SET text1=? WHERE id =" + selected_id
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", text1)
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                End If
                If active2 = True Then
                    text2 = Trim(private2_txt.Text)
                    Cmd.CommandText = "UPDATE label_private_label SET text2=? WHERE id =" + selected_id
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", text2)
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                End If
                If active3 = True Then
                    text3 = Trim(private3_txt.Text)
                    Cmd.CommandText = "UPDATE label_private_label SET text3=? WHERE id =" + selected_id
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", text3)
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                End If

            End Using
        Catch ex As Exception
            MsgBox("Fout private label create: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try


        'add data to labels

        If ListBox1.SelectedIndex >= 0 Then
            Dim lijstitem As String = ListBox1.Items(ListBox1.SelectedIndex).ToString
            Dim lsplit() As String
            lsplit = lijstitem.Split(":")
            Dim lijst_id As Integer = Val(lsplit(0))

            'nieuwe data toevoegen aan geselecteerde label
            Dim ZPLString1 As String = ""
            Dim ZPLString2 As String = ""
            Dim ZPLString3 As String = ""
            Dim ZPLString4 As String = ""

            If active1 = True Then
                Dim ltext1 As String = ""
                For i = 1 To Len(text1)
                    Dim zplchar As String = Mid(text1, i, 1)
                    If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                        ltext1 = ltext1 + "+"
                    ElseIf zplchar = "€" Then
                        ltext1 = ltext1 + "_15"
                    Else
                        ltext1 = ltext1 + zplchar
                    End If
                Next
                ZPLString1 = "^FO" + Trim(Str(x1)) + "," + Trim(Str(y1)) + font1 + "^FH^FD" + ltext1 + "^FS"  ' regel 1
            End If

            If active2 = True Then
                Dim ltext2 As String = ""
                For i = 1 To Len(text2)
                    Dim zplchar As String = Mid(text2, i, 1)
                    If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                        ltext2 = ltext2 + "+"
                    ElseIf zplchar = "€" Then
                        ltext2 = ltext2 + "_15"
                    Else
                        ltext2 = ltext2 + zplchar
                    End If
                Next
                ZPLString2 = "^FO" + Trim(Str(x2)) + "," + Trim(Str(y2)) + font2 + "^FH^FD" + ltext2 + "^FS"  ' regel 2
            End If

            If active3 = True Then
                Dim ltext3 As String = ""
                For i = 1 To Len(text3)
                    Dim zplchar As String = Mid(text2, i, 1)
                    If zplchar = "~" Or zplchar = "^" Or zplchar = "&" Or zplchar = "_" Then
                        ltext3 = ltext3 + "+"
                    ElseIf zplchar = "€" Then
                        ltext3 = ltext3 + "_15"
                    Else
                        ltext3 = ltext3 + zplchar
                    End If
                Next
                ZPLString3 = "^FO" + Trim(Str(x3)) + "," + Trim(Str(y3)) + font3 + "^FH^FD" + ltext3 + "^FS"  ' regel 3
            End If

            ' load basic label

            Dim zplcode As String = ""
            Dim cmdstring As String = "SELECT * FROM label_zpl WHERE id = " + Str(lijst_id)
            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    Dim Reader As OdbcDataReader
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)

                    Reader = Cmd.ExecuteReader()
                    If Reader.HasRows Then
                        Reader.Read()
                        Dim labeltype As Integer = CHint(Reader("label_type"))
                        zplcode = CHstr(Reader("zplcode"))
                        Reader.Close()
                        If labeltype = 0 Then
                            MsgBox("Private labels kunnen alleen met bartender gemaakt worden")
                        End If
                        If labeltype = 1 Then

                            zplcode = zplcode + ZPLString1 + ZPLString2 + ZPLString3                     'create new label code

                            Dim koper_ean As String = listtitel_lbl.Tag                                  'save new label code

                            Cmd.CommandText = "INSERT INTO label_zpl(koper_ean,datum,zplcode,label_type,naam,top1,top2,ean13,bottom,bericht,opmerkingfustlabel) VALUES(?,?,?,?,?,?,?,?,?,?,?)"

                            Dim datum As String = Format(Now, "yyyy-MM-dd")
                            Dim label_type As Integer = 1
                            Dim aantal As Integer = Val(Aantal_txt.Text)
                            If aantal <= 0 Then aantal = 1
                            naam = Naam_txt.Text
                            Cmd.Parameters.Clear()
                            Cmd.Parameters.AddWithValue("", koper_ean)
                            Cmd.Parameters.AddWithValue("", datum)
                            Cmd.Parameters.AddWithValue("", zplcode)
                            Cmd.Parameters.AddWithValue("", 1)
                            Cmd.Parameters.AddWithValue("", "private" + datum)
                            Cmd.Parameters.AddWithValue("", "")
                            Cmd.Parameters.AddWithValue("", "")
                            Cmd.Parameters.AddWithValue("", "")
                            Cmd.Parameters.AddWithValue("", "")
                            Cmd.Parameters.AddWithValue("", 1)   'bericht type voor delete na 1 maand
                            Cmd.Parameters.AddWithValue("", ExtraTextBakstikker_txt.Text)
                            Cmd.ExecuteNonQuery()


                            'fetch new id
                            If postgress = True Then
                                Dim Cmd5 As New OdbcCommand("SELECT CURRVAL(pg_get_serial_sequence('label_zpl','id'))", Conn)
                                lijst_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                            Else

                                Dim Cmd5 As New OdbcCommand("SELECT LAST_INSERT_ID()", Conn)
                                lijst_id = Convert.ToInt32(Cmd5.ExecuteScalar())
                            End If

                            'ShowBartenderVoorbeeld(zplcode, PictureBox2)
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Fout label laden: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try

            'show nieuwe label

            ShowSelectedLabel(lijst_id)
        End If



    End Sub

    Private Sub AlleenPP_but_Click(sender As System.Object, e As System.EventArgs) Handles AlleenPP_but.Click
        labelbuttontype = 1
        If GeenPP_rb.Checked = True Then
            MsgBox("Selecteer de plaats van het paspoort")
            Exit Sub
        End If

        If PPopBak_rb.Checked = True Then
            Opmerking_txt.Text = "Paspoort op Bak"
        Else
            Opmerking_txt.Text = "Paspoort op Pot"
        End If
        Form1.Order_Pakboninfo_txt.Text = "PlantenPaspoort Stikker!"
        GenereerLabels(True)
    End Sub

    Private Sub PPopPot_rb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PPopPot_rb.CheckedChanged
        checkradiobuttonsLBL()
    End Sub

    Private Sub PPopBak_rb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PPopBak_rb.CheckedChanged
        checkradiobuttonsLBL()
    End Sub

    Private Sub GeenPP_rb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles GeenPP_rb.CheckedChanged
        checkradiobuttonsLBL()
    End Sub
End Class