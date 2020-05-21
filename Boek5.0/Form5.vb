Imports System.Data.Odbc

Public Class Mail_vervoerder_form


    Public Sub SetupMailGrid()

        Me.Text = "Vervoer voor " + Form1.Vervoer_Vervoerder_cmb.Text

        Dim cn() As String = New String() {"desc"}

        With Vervoer_flexgrid
            .Clear()
            .Cols.Count = 8
            .Rows.Count = 1

            .Cols(0).Caption = "Aantal"
            .Cols(0).DataType = System.Type.GetType("System.String")
            .Cols(0).Width = 60
            .Cols(0).AllowEditing = True

            .Cols(1).Caption = "Kar"
            .Cols(1).DataType = System.Type.GetType("System.String")
            .Cols(1).Width = 150
            Dim mcd_kar As New C1.Win.C1FlexGrid.MultiColumnDictionary(dtt_karvervoer, "ID", cn, 0)
            .Cols(1).DataMap = mcd_kar
            .Cols(1).AllowEditing = True

            .Cols(2).Caption = "Koper"
            .Cols(2).DataType = System.Type.GetType("System.String")
            .Cols(2).Width = 300
            Dim mcd_kopers As New C1.Win.C1FlexGrid.MultiColumnDictionary(dtt_kopersXA, "ID", cn, 0)
            .Cols(2).DataMap = mcd_kopers
            .Cols(2).AllowEditing = True

            .Cols(3).Caption = "adm. nr"
            .Cols(3).DataType = System.Type.GetType("System.String")
            .Cols(3).Width = 80
            .Cols(3).AllowEditing = True

            .Cols(4).Caption = "Opmerking"
            .Cols(4).DataType = System.Type.GetType("System.String")
            .Cols(4).Width = 200

            .Cols(5).Caption = "Veiling"
            .Cols(5).DataType = System.Type.GetType("System.String")
            .Cols(5).Width = 100
            Dim mcd_vervoerloc As New C1.Win.C1FlexGrid.MultiColumnDictionary(dtt_vervoerderloc, "ID", cn, 0)
            .Cols(5).DataMap = mcd_vervoerloc
            .Cols(5).AllowEditing = True

            .Cols(6).Caption = "Retour"
            .Cols(6).DataType = System.Type.GetType("System.String")
            .Cols(6).Width = 60
            .Cols(6).AllowEditing = True

            .Cols(7).Caption = "EAN"
            .Cols(7).DataType = System.Type.GetType("System.String")
            .Cols(7).Width = 100
            .Cols(7).AllowEditing = True
            .Cols(7).Visible = False

        End With

        Opmerking_cmb.Text = ""
        Ophalen1_chk.Text = "Ophalen op " + vestiging(1).adres
        If UBound(vestiging) > 1 Then
            Ophalen2_chk.Text = "Ophalen op " + vestiging(2).adres
            Ophalen2_chk.Visible = True
        Else
            Ophalen2_chk.Visible = False
        End If



    End Sub

    Private Sub Toevoegen_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toevoegen_but.Click
        Dim flexgridfill(8) As String
        flexgridfill(0) = Str(1)

        flexgridfill(1) = Str(3) 'fh
        flexgridfill(2) = "9999999999998"   'koperean
        flexgridfill(3) = 0
        flexgridfill(4) = ""
        flexgridfill(5) = Str(7)
        flexgridfill(6) = ""
        flexgridfill(7) = ""
        Vervoer_flexgrid.AddItem(flexgridfill)
    End Sub
    Private Sub Verwijderen_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verwijderen_but.Click
        Dim rowsel As Integer = Vervoer_flexgrid.Row
        If rowsel > 0 Then
            Vervoer_flexgrid.Rows.Remove(rowsel)
        End If
    End Sub

    Private Sub Vervoer_flexgrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vervoer_flexgrid.Click
        Dim colsel As Integer = Vervoer_flexgrid.Col
        If colsel = 4 Then

            Dim ean_koper As String = Vervoer_flexgrid.Item(Vervoer_flexgrid.Row, 2)
            OpmerkingVervoerMail.Setup(ean_koper)
            OpmerkingVervoerMail.StartPosition = FormStartPosition.CenterScreen

            kopers_mail_opmerking = "*MAGIC*"
            OpmerkingVervoerMail.Show()
            Do While kopers_mail_opmerking = "*MAGIC*"
                Application.DoEvents()
            Loop
            Vervoer_flexgrid.Item(Vervoer_flexgrid.Row, 4) = kopers_mail_opmerking
        End If
    End Sub

    Private Function MakeHTML() As String
        Dim s0 As String
        Dim s1 As String
        Dim s2 As String
        Dim s3 As String
        Dim s4 As String
        Dim s5 As String
        Dim s6 As String

        Dim html As String = ""

        Dim i As Integer
        Dim htmltab As String
        Dim karcount_vba As Integer
        Dim karcount_fh As Integer
        Dim vervoerder_naam As String = ""
        Dim vervoerder_email As String = ""
        Dim vervoerder_id As Integer = Form1.Vervoer_Vervoerder_cmb.SelectedValue
        For i = 1 To UBound(vervoerder) - 1
            If vervoerder_id = vervoerder(i).id Then
                vervoerder_naam = vervoerder(i).vervoerder_naam
                vervoerder_email = vervoerder(i).email
                Exit For
            End If
        Next


        htmltab = Chr(160) + Chr(160) + Chr(160) + Chr(160) + Chr(160) + Chr(160) + Chr(160) + Chr(160) + Chr(160)

        If onze_ean = "8713782568027" Then
            ' *********************************** GEBR TEN HAVE ***********************************
            'Dim html As String = ""
            html = html + "<html>" + vbCrLf
            html = html + "Aanmelding Transport voor " + vervoerder_naam + "<br>" + vbCrLf
            html = html + "<h1>Gebr. ten Have</h1>" + vbCrLf
            html = html + "<b>Adm. Nr : 2086</b> <br>" + vbCrLf
            html = html + "Factuur adres : Haagkamp 9 2675SK Honselersdijk<br>" + vbCrLf
            html = html + "Ophaal adres  : Haagkamp 7 2675SK Honselersdijk<br>" + vbCrLf
            html = html + "<br>" + vbCrLf
            If Ophalen1_chk.Checked = False Then
                html = html + "Deze vracht wordt aangeleverd op Flora Holland<br>" + vbCrLf
                html = html + "Gelieve de bon en de labels voor de chauffeur klaar te hangen<br>" + vbCrLf
            Else
                html = html + "Deze vracht moet worden opgehaald op Haagkamp 7, Honselersdijk  <br> " + vbCrLf
            End If

            html = html + "<br>" + vbCrLf
            html = html + "<TABLE BORDER>" + vbCrLf
            html = html + "<TR><TH>Aantal</TH> <TH>Karren</TH> <TH>Koper</TH><TH>Adm. nr.</TH><TH>Opmerking</TH><TH>Veiling</TH><TH>Retour</TH></TR>" + vbCrLf
        Else
            ' *********************************** J EN P TEN HAVE ***********************************
            'Dim html As String = ""
            html = html + "<html>" + vbCrLf
            html = html + "Aanmelding Transport voor " + vervoerder_naam + "<br>" + vbCrLf
            html = html + "<h1>J&P ten Have</h1>" + vbCrLf
            html = html + "<b>Adm. Nr : -</b> <br>" + vbCrLf
            html = html + "Factuur adres :  " + vestiging(1).adres + "<br>" + vbCrLf
            If Ophalen1_chk.Checked = False And Ophalen2_chk.Checked = False Then
                html = html + "Deze vracht wordt aangeleverd op Flora Holland<br>" + vbCrLf
                html = html + "Gelieve de bon en de labels voor de chauffeur klaar te hangen<br>" + vbCrLf
            Else
                If Ophalen1_chk.Checked = True Then
                    html = html + "Deze vracht moet worden opgehaald op " + vestiging(1).adres + "<br>" + vbCrLf
                Else
                    html = html + "Deze vracht moet worden opgehaald op " + vestiging(2).adres + "<br>" + vbCrLf
                End If

            End If


            html = html + "<br>" + vbCrLf
            html = html + "<TABLE BORDER>" + vbCrLf
            html = html + "<TR><TH>Aantal</TH> <TH>Karren</TH> <TH>Koper</TH><TH>Adm. nr.</TH><TH>Opmerking</TH><TH>Veiling</TH><TH>Retour</TH></TR>" + vbCrLf


        End If

        karcount_vba = 0
        karcount_fh = 0
        For i = 1 To Vervoer_flexgrid.Rows.Count - 1

            'karrencounters

            If Vervoer_flexgrid.Item(i, 1) = 3 Then
                karcount_fh = karcount_fh + Val(Vervoer_flexgrid.Item(i, 6))
            End If

            If Vervoer_flexgrid.Item(i, 1) = 9 Then
                karcount_vba = karcount_vba + Val(Vervoer_flexgrid.Item(i, 6))
            End If

            'html

            Dim foundRows() As DataRow
            html = html + " <TR>" + vbCrLf
            s0 = Vervoer_flexgrid.Item(i, 0)
            If s0 = "" Then s0 = Chr(160)
            Dim search_ean As String = "ID = '" + Trim(Vervoer_flexgrid.Item(i, 1)) + "'"
            foundRows = dtt_karvervoer.Select(search_ean)
            s1 = foundRows(0)(1)
            search_ean = "ID = '" + Trim(Vervoer_flexgrid.Item(i, 2)) + "'"
            foundRows = dtt_kopersXA.Select(search_ean)
            s2 = foundRows(0)(1)
            If s2 = "Verzamel kar" Then s2 = "Decorum Fijndistributie"
            s3 = Vervoer_flexgrid.Item(i, 3)
            If s3 = "" Then s3 = Chr(160)
            s4 = Vervoer_flexgrid.Item(i, 4)
            If s4 = "" Then s4 = Chr(160)
            search_ean = "ID = '" + Trim(Vervoer_flexgrid.Item(i, 5)) + "'"
            foundRows = dtt_vervoerderloc.Select(search_ean)
            s5 = foundRows(0)(1)
            s6 = Vervoer_flexgrid.Item(i, 6)
            If s6 = "" Then s6 = Chr(160)
            html = html + " <TD align=center>" + s0 + "</TD> <TD align=center>" + s1 + "</TD> <TD align=center>" + s2 + "</TD> <TD align=center>" + s3 + "</TD> <TD align=center>" + s4 + "</TD> <TD align=center>" + s5 + "</TD> <TD align=center>" + s6 + "</TD>" + vbCrLf
            html = html + " </TR>" + vbCrLf
        Next i
        html = html + "</TABLE> <br><br>" + vbCrLf
        If karcount_vba > 0 And karcount_fh = 0 Then
            html = html + "In totaal dus " + CStr(karcount_vba) + " VBA-Karren retour a.u.b.<br><br>" + vbCrLf
        End If
        If karcount_fh > 0 And karcount_vba = 0 Then
            html = html + "In totaal dus " + CStr(karcount_fh) + " FH-Karren retour a.u.b.<br><br>" + vbCrLf
        End If
        If karcount_fh > 0 And karcount_vba > 0 Then
            html = html + "In totaal dus " + CStr(karcount_fh) + " FH-Karren en " + CStr(karcount_vba) + " VBA-Karren retour a.u.b.<br><br>" + vbCrLf
        End If

        If Opmerking_cmb.Text <> "" Then
            html = html + "Opmerking: " + Opmerking_cmb.Text + vbCrLf
        End If
        html = html + "<br>" + vbCrLf
        html = html + "Aanmelding verstuurd op: " + Now + "<br>" + vbCrLf
        html = html + "</html>" + vbCrLf

        Return html
    End Function

    Private Sub Versturen_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Versturen_but.Click



        Dim vervoerder_id As Integer = Form1.Vervoer_Vervoerder_cmb.SelectedValue
        Dim vervoerder_naam As String = ""

        Dim vervoerder_email As String = "verkoop@campanula.com"
        If onze_ean = "8713782568027" Then
            vervoerder_email = "verkoop@campanula.com"
        Else
            vervoerder_email = "verkoop@jenptenhave.nl"
        End If

        For i = 1 To UBound(vervoerder) - 1
            If vervoerder_id = vervoerder(i).id Then
                vervoerder_naam = vervoerder(i).vervoerder_naam
                vervoerder_email = vervoerder(i).email
                Exit For
            End If
        Next

        Dim html As String = MakeHTML()

        Dim mailman As New Chilkat.MailMan()

        Dim success As Boolean
        success = mailman.UnlockComponent("CAIWNLMAILQ_Z9R85EV9nR4V")
        If (success <> True) Then
            MsgBox("MailComponent unlock failed, sendmail failed")
            MsgBox(mailman.LastErrorText)
            Exit Sub
        End If

        '  Set the SMTP server.
        If ExternalMailHost <> "" Or MailRecipient <> "" Then
            mailman.SmtpHost = ExternalMailHost
            If jenptenhave = False Then
                mailman.SmtpSsl = True
                mailman.SmtpPassword = "jahoorok"
                mailman.SmtpUsername = "fox@caiw.nl"
                mailman.SmtpPort = 465
            End If

        Else
            MsgBox("<Mailhost/recipient not found> Cannot send edi")
            Exit Sub
        End If
        '  Create a new email object
        Dim email As New Chilkat.Email()

        If onze_ean = "8713782568027" Then
            email.Subject = "Aanmelding transport van Gebr. ten Have"
            email.SetHtmlBody(html)
            email.From = "verkoop@campanula.com"
            email.AddTo("vervoerder", vervoerder_email)
            email.ClearBcc()
            email.AddBcc("Aanmelding Vervoer BCC", "verkoop@campanula.com")
        Else
            email.Subject = "Aanmelding transport van J&P ten Have"
            email.SetHtmlBody(html)
            email.From = "verkoop@jenptenhave.nl"
            email.AddTo("vervoerder", vervoerder_email)
            email.ClearBcc()
            email.AddBcc("Aanmelding Vervoer BCC", "verkoop@jenptenhave.nl")
        End If

        'Dim attachmentContent As String
        'attachmentContent = html

        'email.AddStringAttachment2(tempname, attachmentContent, "ansi")
        'email.AddAttachmentHeader(0, "Content-Type", "application/edifact")
        success = mailman.SendEmail(email)
        If (success <> True) Then
            MsgBox("Mail error, Send mail failed")
        Else
            MsgBox("Mail verstuurd", vbOKOnly)


            'make logs
            If Len(html) >= 19999 Then
                html = Mid(html, 1, 19999)
            End If
            Dim cmdstring As String = ""

            Try
                'Open Connection
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    'Execute Query
                    Dim Cmd As New OdbcCommand(cmdstring, Conn)
                    Cmd.CommandText = "INSERT INTO vervoer_logs(datum,html,vervoerder) VALUES(?,?,?)"
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.AddWithValue("", Format(Now, "yyyy-MM-dd HH:mm"))
                    Cmd.Parameters.AddWithValue("", html)
                    Cmd.Parameters.AddWithValue("", vervoerder_naam)
                    Cmd.ExecuteNonQuery()

                    'Dim CmdString2 As String = ""
                    'Dim Cmd2 As New OdbcCommand(CmdString2, Conn)
                    'Cmd2.CommandText = "UPDATE " + orderheader_db + " SET agenda_mark=0 WHERE agenda_mark=3 AND DATE(afleverdatum) >= '" + Start_DatumStr + "' AND DATE(afleverdatum) <= '" + End_DatumStr + "' "
                    'Cmd2.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                MsgBox("Fout vervoerlog: " + ex.Message, MsgBoxStyle.OkOnly)
            End Try
            Form1.Vervoer_MonthCalendar.SelectionStart = Now

            ReCalcStatus()

            Me.Close()
        End If
        ' 



    End Sub

    Private Sub ReCalcStatus()

        Dim orderyear As String = Trim(Str(Year(Form1.Order_MonthCalendar.SelectionStart)))
        If staticyear = True Then orderyear = ""
        Dim orderheader_db As String = "OrderHeaders" + orderyear
        ' ******* fetch start/end datum *****
        Dim Start_datum As Date
        Dim End_datum As Date
        Start_datum = Form1.Order_MonthCalendar.SelectionStart
        End_datum = Form1.Order_MonthCalendar.SelectionEnd
        If End_datum < Start_datum Then
            End_datum = Start_datum
        End If
        Dim Start_DatumStr As String = Start_datum.ToString("yyyy/MM/dd")
        Dim End_DatumStr As String = End_datum.ToString("yyyy/MM/dd")

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim CmdHeaderString As String = "select * from " + orderheader_db + " WHERE agenda_mark=3 AND DATE(afleverdatum) >= '" + Start_DatumStr + "' AND DATE(afleverdatum) <= '" + End_DatumStr + "' "
                Dim Cmd As New OdbcCommand(CmdHeaderString, Conn)
                Dim Reader As OdbcDataReader
                Dim header_id As Integer
                Dim ean As String
                Reader = Cmd.ExecuteReader()
                Do While Reader.Read
                    header_id = CHint(Reader("header_id"))
                    ean = CHstr(Reader("koper_ean"))
                    Dim cmdstring As String = ""
                    Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                    If Mid(ean, 1, 13) = "9000000000000" Then  'verzamelkar
                        Cmd2.CommandText = "UPDATE " + orderheader_db + " SET agenda_mark=0, status=51  WHERE header_id = " + Trim(Str(header_id))
                        Cmd2.ExecuteNonQuery()
                    Else
                        Cmd2.CommandText = "UPDATE " + orderheader_db + " SET agenda_mark=0 WHERE header_id = " + Trim(Str(header_id))
                        Cmd2.ExecuteNonQuery()
                        Form1.SetNewStatusFlag(Form1.Order_MonthCalendar.SelectionStart, header_id, False)
                    End If
                    'Cmd2.CommandText = "UPDATE " + orderheader_db + " SET agenda_mark=0 WHERE header_id = " + Trim(Str(header_id))
                    'Cmd2.ExecuteNonQuery()
                    'Form1.SetNewStatusFlag(Form1.Order_MonthCalendar.SelectionStart, header_id, False)
                Loop


            End Using
        Catch ex As Exception
            MsgBox("Fout opslag recalc vervoer mark: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
        Form1.Set_Boek_reload()
        Form1.Update_Boek()

    End Sub

    Private Sub Printen_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim html As String = MakeHTML()

        vervoerslog_form.WebBrowser1.Navigate("about:blank")
        If vervoerslog_form.WebBrowser1.Document IsNot Nothing Then
            vervoerslog_form.WebBrowser1.Document.Write(String.Empty)
        End If
        vervoerslog_form.WebBrowser1.DocumentText = html

        vervoerslog_form.StartPosition = FormStartPosition.CenterScreen
        vervoerslog_form.Show()
        Application.DoEvents()

        vervoerslog_form.WebBrowser1.ShowPrintDialog()

        Me.Close()


    End Sub
End Class