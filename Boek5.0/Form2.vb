Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class WpsWindow

    Private Sub Wps_Kar_invoer_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Kar_invoer_but.Click

        For i = 1 To (Wps_FlexGrid1.Rows.Count - 1)
            Wps_FlexGrid1.SetCellCheck(i, 1, C1.Win.C1FlexGrid.CheckEnum.Checked)
        Next

        If Wps_Kar_invoer_but.Text = "Einde" Then
            Wps_Kar_invoer_but.Text = "Kar ingevoerd"
            Form1.Orders_WpsVersturen.Enabled = True
            Me.Close()
            Exit Sub
        End If

        Save_Wps_Flags(wps_ordernr, wps_karnr)

        If wps_karnr < wps_karcount(wps_ordernr) Then
            wps_karnr = wps_karnr + 1
            Fill_WpsWindow(wps_ordernr, wps_karnr)
        Else
            If wps_ordernr <= 100 And wps_idlist(wps_ordernr + 1) >= 0 And wps_ordernr < wps_ordercount Then
                wps_ordernr = wps_ordernr + 1
                wps_karnr = 1
                Fill_WpsWindow(wps_ordernr, wps_karnr)
            Else
                Wps_Kar_invoer_but.Text = "Einde"
            End If
        End If

    End Sub
    Private Sub Save_Wps_Flags(ByVal ordernr As Integer, ByVal karnr As Integer)

        Dim orderyear As String = Trim(Str(Year(wps_date)))
        If staticyear = True Then orderyear = ""
        Dim orderkarlines_db As String = "OrderKarLines" + orderyear

        'check of de order door iemand anders is aangepast in de tussentijd 
        Dim id As Integer = 0
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim cmdstring6 As String = "SELECT * FROM " + orderkarlines_db + " WHERE 1=0"

                For i = 1 To (Wps_FlexGrid1.Rows.Count - 1)
                   
                    Dim Cmd As New OdbcCommand(cmdstring6, Conn)
                    With Cmd
                        id = Wps_FlexGrid1.Item(i, 0)
                        Dim checked As Boolean = Wps_FlexGrid1.Item(i, 1)
                        .CommandText = "UPDATE " + orderkarlines_db + " SET Wps_flag=? WHERE id = " + Trim(Str(id))
                        .Parameters.Clear()
                        .Parameters.AddWithValue("", checked)
                        .ExecuteNonQuery()

                    End With
                Next i
            End Using
        Catch ex As Exception
            MsgBox("Fout opslag wpswindow: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
        UpdateOrderVersienr(id)

    End Sub
    Private Function GID(ByVal table As Array, ByVal id As Integer) As Integer
        Dim Search_id As Integer = 0
        'get ID 
        For i = 0 To UBound(table)
            If table(i).id = id Then
                Search_id = i
                Exit For
            End If
        Next i
        Return Search_id
    End Function
    Private Sub Fill_WpsWindow(ByVal Ordernr, ByVal Karnr)

        ' bereken totaal orders
        Dim wps_ordercount As Integer = 0
        For totaal = 1 To 100
            If wps_idlist(totaal) > 0 Then
                wps_ordercount = wps_ordercount + 1
            End If
        Next
        Wps_ordercount_lbl.Text = "Order " + Trim(Str(wps_ordernr)) + " van " + Trim(Str(wps_ordercount))

        ' klant info & karinfo ophalen
        Dim orderyear As String = Trim(Str(Year(wps_date)))
        If staticyear = True Then orderyear = ""
        Dim orderheader_db As String = "OrderHeaders" + orderyear
        Dim orderlines_db As String = "OrderLines" + orderyear
        Dim orderkarren_db As String = "OrderKarren" + orderyear
        Dim orderkarlines_db As String = "OrderKarLines" + orderyear

        Dim Wps_KarHeaders(Max_Kar_Headers) As Kar_header
        Dim Wps_KarLines(Max_Kar_Lines) As kar_line

        'clear vars
        Array.Clear(Wps_KarHeaders, Wps_KarHeaders.GetLowerBound(0), Wps_KarHeaders.Length)
        Array.Clear(Wps_KarLines, Wps_KarLines.GetLowerBound(0), Wps_KarLines.Length)
        For i = 0 To Wps_KarLines.Length - 1
            Wps_KarLines(i).sorteren = 4000
        Next

        Dim header_id = wps_idlist(Ordernr)

        Dim karcounter As Integer = 1
        Dim linecounter As Integer = 1

        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                ' load header data 
                Dim CmdHeaderString As String = "select * from " + orderheader_db + " WHERE  Header_id = " + Str(header_id) + " "
                Dim CmdHeader As New OdbcCommand(CmdHeaderString, Conn)
                Dim HeaderReader As OdbcDataReader
                Dim koper_ean As String = ""
                HeaderReader = CmdHeader.ExecuteReader
                If HeaderReader.HasRows() Then
                    HeaderReader.Read()
                    koper_ean = CHstr(HeaderReader("koper_ean"))
                    Wps_kopernaam1_lbl.Text = Mid(CHstr(HeaderReader("Koper_naam")), 1, 18)
                    Wps_kopernaam2_lbl.Text = CHstr(HeaderReader("Koper_naam"))
                    Wps_kartype_lbl.Text = kar(GID(kar, CHint(HeaderReader("kar_id")))).karnaam
                    Wps_Order_versie_lbl.Text = CHstr(HeaderReader("versie"))
                    Dim opmerking As String = CHstr(HeaderReader("Opmerking"))
                    If opmerking <> "" Then
                        Wps_opmerking_lbl2.Text = "Pakbon: " + opmerking
                    Else
                        Wps_opmerking_lbl2.Text = ""
                    End If
                End If

                Dim CmdKoperString As String = "select * from klanten WHERE ean = '" + koper_ean + "'"
                Dim CmdKoper As New OdbcCommand(CmdKoperString, Conn)
                Dim KoperReader As OdbcDataReader
                KoperReader = CmdKoper.ExecuteReader
                If KoperReader.HasRows() Then
                    KoperReader.Read()
                    Dim opmerking As String = CHstr(KoperReader("Opmerking"))
                    If opmerking <> "" Then
                        Wps_opmerking_lbl1.Text = "Opm: " + opmerking
                    Else
                        Wps_opmerking_lbl1.Text = ""
                    End If
                End If


                ' load kar-info & lines

                Dim CmdKarString As String = "select * from " + orderkarren_db + " WHERE  Header_id = " + Str(header_id) + " "
                Dim CmdKar As New OdbcCommand(CmdKarString, Conn)
                Dim KarrenReader As OdbcDataReader

                KarrenReader = CmdKar.ExecuteReader
                Do While KarrenReader.Read()
                    Dim kar_id As Integer = CHint(KarrenReader("kar_id"))
                    Wps_KarHeaders(karcounter).tag = True
                    Wps_KarHeaders(karcounter).kar_id = kar_id
                    Wps_KarHeaders(karcounter).header_id = CHint(KarrenReader("header_id"))
                    Wps_KarHeaders(karcounter).aantal_lagen = CHint(KarrenReader("Aantal_lagen"))
                    Wps_KarHeaders(karcounter).aantal_lagenlock = CHint(KarrenReader("Aantal_lagenLock"))
                    Wps_KarHeaders(karcounter).kar_type = CHint(KarrenReader("kar_type"))
                    Wps_KarHeaders(karcounter).sdf_flag = CHbool(KarrenReader("sdf_flag"))
                    Wps_KarHeaders(karcounter).vervoer_flag = CHbool(KarrenReader("vervoer_flag"))
                    Wps_KarHeaders(karcounter).barcode = CHstr(KarrenReader("barcode"))
                    Wps_KarHeaders(karcounter).cc_rfid = CHstr(KarrenReader("cc_rfid"))
                    Wps_KarHeaders(karcounter).kar_nummer = 0

                    'load kar  lines
                    Dim CmdKarLineString As String = "select * from " + orderkarlines_db + " WHERE  kar_id = " + Str(kar_id)
                    Dim CmdKarlines As New OdbcCommand(CmdKarLineString, Conn)
                    Dim KarLineReader As OdbcDataReader
                    KarLineReader = CmdKarlines.ExecuteReader
                    Do While KarLineReader.Read()
                        Wps_KarLines(linecounter).tag = True
                        Wps_KarLines(linecounter).aantal = CHint(KarLineReader("aantal"))
                        Wps_KarLines(linecounter).kar_id = CHint(KarLineReader("kar_id"))
                        Wps_KarLines(linecounter).Orderline_id = CHint(KarLineReader("orderline_id"))
                        Wps_KarLines(linecounter).wps_flag = CHbool(KarLineReader("wps_flag"))
                        Wps_KarLines(linecounter).header_id = CHint(KarLineReader("header_id"))
                        Wps_KarLines(linecounter).kar_nummerref = CHint(KarLineReader("id"))
                        Wps_KarLines(linecounter).sorteren = CHint(KarLineReader("sorteren"))

                        'load extra lineinfo 
                        'load kar  lines
                        Dim CmdInfoLineString As String = "select * from " + orderlines_db + " WHERE  OrderLine_id = " + Str(Wps_KarLines(linecounter).Orderline_id)
                        Dim CmdInfolines As New OdbcCommand(CmdInfoLineString, Conn)
                        Dim KarInfoReader As OdbcDataReader
                        KarInfoReader = CmdInfolines.ExecuteReader
                        If KarInfoReader.HasRows Then
                            KarInfoReader.Read()
                            Wps_KarLines(linecounter).fustlist_id = GID(fust, CHint(KarInfoReader("Fust_id")))
                            Wps_KarLines(linecounter).accessoirelist_id = GID(accessoire, CHint(KarInfoReader("Accessoire1")))
                            Wps_KarLines(linecounter).gp = CHint(KarInfoReader("gp"))
                            Wps_KarLines(linecounter).opmerking = CHstr(KarInfoReader("opmerking"))
                            Dim soort_id As Integer = CHint(KarInfoReader("Soort_id"))
                            Wps_KarLines(linecounter).soort_id = soort_id
                            If soort_id < 10000 Then
                                Wps_KarLines(linecounter).soortnaam = soorten(GID(soorten, soort_id)).soortnaam
                            Else
                                Wps_KarLines(linecounter).soortnaam = mixen(GID(mixen, soort_id - 10000)).naam
                            End If

                        End If
                        linecounter = linecounter + 1
                    Loop
                    karcounter = karcounter + 1
                Loop
                If Karnr > (karcounter - 1) Then
                    Karnr = karcounter - 1
                    wps_karnr = Karnr
                End If

                Wps_karcount_lbl.Text = "Kar " + Trim(Str(Karnr)) + " van " + Trim(Str(karcounter - 1))

            End Using
        Catch ex As Exception
            MessageBox.Show("Fout: Wps window" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try


        ' flexgrid vullen
        Wps_FlexGrid1.Rows.Count = 1
        Dim active_row = 1
        Dim opmerking_set As Boolean = False
        Dim karh_id As Integer = Wps_KarHeaders(Karnr).kar_id
        Wps_Kar_printpakbon.Tag = Str(karh_id) + ";" + Wps_KarHeaders(Karnr).barcode 'save id & pakbonnr for bakbon print
        For i = 0 To Max_Kar_Lines
            If Wps_KarLines(i).kar_id = karh_id Then

                Wps_FlexGrid1.Styles.Clear()
                Dim rs As C1.Win.C1FlexGrid.CellStyle
                rs = Wps_FlexGrid1.Styles.Add("fustkleur")
                rs.BackColor = GetColorValue(fust(Wps_KarLines(i).fustlist_id).kleur)

                Dim listadd(6)

                Dim soortstring As String = ""
                If Wps_KarLines(i).gp > 1 Then
                    soortstring = soortstring + Trim(Str(Wps_KarLines(i).gp)) + " x "
                End If
                soortstring = soortstring + Trim(Str(Wps_KarLines(i).aantal))
                soortstring = soortstring + " x " + Trim(Str(fust(Wps_KarLines(i).fustlist_id).aantal_per_fust))
                soortstring = soortstring + " " + Wps_KarLines(i).soortnaam
                ' If accessoire(Wps_KarLines(i).accessoirelist_id).fust > 0 Or accessoire(Wps_KarLines(i).accessoirelist_id).prijslijst > 0 Then
                If accessoire(Wps_KarLines(i).accessoirelist_id).id > 1 Then
                    soortstring = soortstring + " " + accessoire(Wps_KarLines(i).accessoirelist_id).naam
                End If

                listadd(0) = Wps_KarLines(i).kar_nummerref
                listadd(1) = Wps_KarLines(i).wps_flag
                listadd(2) = soortstring
                If Trim(Wps_KarLines(i).opmerking) <> "" Then
                    opmerking_set = True
                    listadd(3) = Wps_KarLines(i).opmerking
                Else
                    listadd(3) = ""
                End If
                listadd(4) = fust(Wps_KarLines(i).fustlist_id).fustnaam
                listadd(5) = Wps_KarLines(i).soort_id
                Wps_FlexGrid1.AddItem(listadd)
                Wps_FlexGrid1.Rows(active_row).Style = Wps_FlexGrid1.Styles("fustkleur")
                active_row = active_row + 1

            End If
        Next
        If opmerking_set = True Then
            Wps_FlexGrid1.Cols(3).Visible = True
            Me.Width = 462
        Else
            Wps_FlexGrid1.Cols(3).Visible = False
            Me.Width = 288
        End If
        Wps_FlexGrid1.Select(0, 0)
       


    End Sub

    Private Function GetColorValue(ByVal hexstring As String) As System.Drawing.Color
        Dim clr As Color = ColorTranslator.FromHtml(hexstring)
        Return clr
    End Function
    Private Sub WpsWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        For orderloop = 1 To 100
            If wps_idlist(orderloop) > 0 Then
                Dim header_id = wps_idlist(orderloop)
                Form1.SetNewStatusFlag(wps_date, header_id)
            End If
        Next
        Form1.Orders_WpsVersturen.Enabled = True
        'close form
        'Form1.Orders_WpsVersturen.Enabled = True
        'Form1.BringToFront()
        'Form1.Show()
    End Sub
    Private Sub WpsWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bereken aantal orders/karren
        ' bereken totaal orders

        Wps_Kar_invoer_but.Text = "Kar ingevoerd"

        wps_ordercount = 0

        For totaal = 1 To 100
            If wps_idlist(totaal) > 0 Then
                wps_ordercount = wps_ordercount + 1
            End If
        Next

        ' klant info & karinfo ophalen
        Dim orderyear As String = Trim(Str(Year(wps_date)))
        If staticyear = True Then orderyear = ""
        Dim orderkarren_db As String = "OrderKarren" + orderyear
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                For karcount = 1 To wps_ordercount
                    ' load kar-info & lines
                    Dim karcounter As Integer = 0
                    Dim header_id As Integer = wps_idlist(karcount)
                    Dim CmdKarString As String = "select header_id from " + orderkarren_db + " WHERE  Header_id = " + Str(header_id) + " "
                    Dim CmdKar As New OdbcCommand(CmdKarString, Conn)
                    Dim KarrenReader As OdbcDataReader

                    KarrenReader = CmdKar.ExecuteReader
                    Do While KarrenReader.Read()
                        karcounter = karcounter + 1
                    Loop
                    wps_karcount(karcount) = karcounter
                Next karcount

            End Using
        Catch ex As Exception
            MessageBox.Show("Fout: wps-load" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        ' set status on wps active
        Dim orderheader_db As String = "OrderHeaders" + orderyear
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                For orderloop = 1 To 100
                    If wps_idlist(orderloop) > 0 Then
                        Dim header_id = wps_idlist(orderloop)
                        Dim CmdHeaderString As String = "select * from " + orderheader_db + " WHERE 1=0"
                        Dim Cmd As New OdbcCommand(CmdHeaderString, Conn)
                        With Cmd
                            .CommandText = "UPDATE " + orderheader_db + " SET status=? WHERE Header_id = " + Str(header_id)
                            .Parameters.Clear()
                            .Parameters.AddWithValue("", 30)
                            .ExecuteNonQuery()

                        End With

                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox("Fout status wpswindow: " + ex.Message, MsgBoxStyle.OkOnly)
        End Try
        Form1.Set_Boek_reload()
        Form1.Update_Boek()
        ' show box 
        wps_ordernr = 1
        wps_karnr = 1
        Fill_WpsWindow(wps_ordernr, wps_karnr)
    End Sub
    Private Sub Wps_Order_Rechts_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Order_Rechts_but.Click
        If wps_ordernr <= 100 Then
            If wps_idlist(wps_ordernr + 1) >= 0 And wps_ordernr < wps_ordercount Then
                Save_Wps_Flags(wps_ordernr, wps_karnr)
                wps_ordernr = wps_ordernr + 1
                wps_karnr = 1
                Fill_WpsWindow(wps_ordernr, wps_karnr)
            Else
                Save_Wps_Flags(wps_ordernr, wps_karnr)
                Wps_Kar_invoer_but.Text = "Einde"
            End If
        End If
    End Sub
    Private Sub Wps_Order_Links_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Order_Links_but.Click
        If Wps_Kar_invoer_but.Text = "Einde" Then
            Wps_Kar_invoer_but.Text = "Kar ingevoerd"
        End If
        If wps_ordernr > 0 Then
            If wps_idlist(wps_ordernr - 1) >= 0 Then
                Save_Wps_Flags(wps_ordernr, wps_karnr)
                wps_ordernr = wps_ordernr - 1
                wps_karnr = 1
                Fill_WpsWindow(wps_ordernr, wps_karnr)
            End If
        Else
            Save_Wps_Flags(wps_ordernr, wps_karnr)
        End If
    End Sub
    Private Sub Wps_Kar_Rechts_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Kar_Rechts_but.Click
        If wps_karnr < wps_karcount(wps_ordernr) Then
            Save_Wps_Flags(wps_ordernr, wps_karnr)
            wps_karnr = wps_karnr + 1
            Fill_WpsWindow(wps_ordernr, wps_karnr)
        Else
            Save_Wps_Flags(wps_ordernr, wps_karnr)
            If wps_ordernr = wps_ordercount Then
                Wps_Kar_invoer_but.Text = "Einde"
            End If
        End If
    End Sub
    Private Sub Wps_Kar_Links_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Kar_Links_but.Click
        If Wps_Kar_invoer_but.Text = "Einde" Then
            Wps_Kar_invoer_but.Text = "Kar ingevoerd"
        End If
        If wps_karnr > 1 Then
            Save_Wps_Flags(wps_ordernr, wps_karnr)
            wps_karnr = wps_karnr - 1
            Fill_WpsWindow(wps_ordernr, wps_karnr)
        Else
            Save_Wps_Flags(wps_ordernr, wps_karnr)
        End If
    End Sub
    Private Sub Wps_Kar_reset_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Kar_reset_but.Click
        For i = 1 To (Wps_FlexGrid1.Rows.Count - 1)
            Wps_FlexGrid1.SetCellCheck(i, 1, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
            Save_Wps_Flags(wps_ordernr, wps_karnr)
        Next
    End Sub
    Private Sub UpdateOrderVersienr(ByVal karline_id)
        Dim orderyear As String = Trim(Str(Year(wps_date)))
        If staticyear = True Then orderyear = ""
        Dim orderheader_db As String = "OrderHeaders" + orderyear
        Dim orderkarlines_db As String = "OrderKarLines" + orderyear
        Dim Reader As OdbcDataReader
        Dim Versie As Integer = -1
        Dim header_id As Integer = -1
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()


                Dim cmdstring As String = "SELECT header_id FROM " + orderkarlines_db + " where id =" + Str(karline_id)
                Dim Cmd3 As New OdbcCommand(cmdstring, Conn)
                Reader = Cmd3.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()
                    header_id = CHint(Reader("header_id"))
                End If
                Reader.Close()

                cmdstring = "SELECT versie FROM " + orderheader_db + " where header_id =" + Str(header_id)
                Dim Cmd2 As New OdbcCommand(cmdstring, Conn)
                Reader = Cmd2.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()
                    Versie = CHint(Reader("versie"))
                End If
                Reader.Close()


                Cmd2.CommandText = "UPDATE " + orderheader_db + " SET versie=? where header_id =" + Str(header_id)
                Cmd2.Parameters.Clear()
                Cmd2.Parameters.AddWithValue("", Versie + 1)
                Cmd2.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MessageBox.Show("Wps versienr update:" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub Wps_FlexGrid1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Wps_FlexGrid1.MouseMove

        If Wps_FlexGrid1.MouseRow > 0 And (Wps_FlexGrid1.MouseCol = 2 Or Wps_FlexGrid1.MouseCol = 3) Then


            Dim tip As String = ""
            ToolTip1.Active = True
            Static oldx As Integer
            Static oldy As Integer
            If oldx <> Wps_FlexGrid1.MouseCol Or oldy <> Wps_FlexGrid1.MouseRow Then
                ' tip = Me.Wps_FlexGrid1.Item(Wps_FlexGrid1.MouseRow, Wps_FlexGrid1.MouseCol)
                Dim soort_id As Integer = Val(Me.Wps_FlexGrid1.Item(Wps_FlexGrid1.MouseRow, 5))
                If soort_id < 10000 Then
                    tip = Me.Wps_FlexGrid1.Item(Wps_FlexGrid1.MouseRow, Wps_FlexGrid1.MouseCol)
                Else
                    ' fetch mix_vulling
                    Try
                        'Open Connection
                        Using Conn As New OdbcConnection(ConnString)
                            Conn.Open()

                            ' load header data 
                            Dim CmdMixString As String = "select * from mixen_vulling WHERE  mix_id = " + Str(soort_id - 10000) + " "
                            Dim CmdMix As New OdbcCommand(CmdMixString, Conn)
                            Dim MixReader As OdbcDataReader
                            MixReader = CmdMix.ExecuteReader
                            tip = "Mix: " + vbCrLf
                            Do While MixReader.Read
                                Dim mix_soortid As Integer = CHint(MixReader("soort_id"))
                                tip = tip + soorten(GID(soorten, mix_soortid)).soortnaam + vbCrLf
                            Loop
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Fout: Wps window-mixenvulling" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End Try

                End If
                ToolTip1.SetToolTip(Wps_FlexGrid1, tip)
            End If
            oldx = Wps_FlexGrid1.MouseCol
            oldy = Wps_FlexGrid1.MouseRow
        Else
            ToolTip1.Active = False
        End If

    End Sub
    Private Sub Wps_Kar_printpakbon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wps_Kar_printpakbon.Click
        'MsgBox(Wps_Kar_printpakbon.Tag)
        Dim splitstr(2) As String
        splitstr = Split(Wps_Kar_printpakbon.Tag, ";")
        Dim kar_id As Integer = Val(splitstr(0))
        Dim barcode As String = splitstr(1)
        MsgBox("Pakbon " + barcode + " wordt geprint")
        My.Computer.Clipboard.SetText("Pakbon: " + barcode)


        Dim CmdString As String = "SELECT * FROM  printer_spooler  WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "INSERT INTO printer_spooler SET kar_id=?, datum=?"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", kar_id)
                    .Parameters.AddWithValue("", Format(wps_date, "yyyy-MM-dd HH:mm"))
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (pakbon printerspooler)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub


End Class