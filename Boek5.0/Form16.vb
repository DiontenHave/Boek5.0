Imports System.Data.Odbc
Imports C1.Win.C1FlexGrid

Public Class Form16

    Private FFtask As Integer = 0
    Private DVtask As Integer = 0
    Private GlobalHeader_id As Integer = 0
    Private GlobalKar_id As Integer = 0
    Private GlobalBriefnummer As String = ""
    Private GlobalActie As String = "INIT"

    Private GetDeliveryStatus As Boolean = False
    Private GetFulfillmentStatus As Boolean = False
    Private DeleteDelivery As Integer = 0
    Private DeleteFulFillment As Integer = 0

    Public Sub Init(header_id As Integer, selected_kar_id As Integer)

        GlobalHeader_id = header_id
        GlobalKar_id = selected_kar_id

        GetDeliveryStatus = True
        GetFulfillmentStatus = True
        DVtask = Form1.InsertTask(0, 80, "GET", "delivery-orders", "sync")
        FFtask = Form1.InsertTask(0, 80, "GET", "fulfillment-orders", "sync")
        GlobalActie = "INIT"
        StartTimer()

    End Sub

    Private Sub StartTimer()
        View_txt.Text = "Verbinden met Floriday.. even wachten A.U.B." + vbNewLine
        StatusRapport_but.Enabled = False
        HerstelFoutStatus_but.Enabled = False
        EABAnnuleren_but.Enabled = False
        KarAanpassen_but.Enabled = False
        KarCorrigeren_but.Enabled = False
        TaskTimer.Enabled = True
    End Sub

    Private Sub StopTimer()
        UpdateAanpassenFlexgrid()
        StatusRapport_but.Enabled = True
        HerstelFoutStatus_but.Enabled = True
        EABAnnuleren_but.Enabled = True
        KarAanpassen_but.Enabled = True
        KarCorrigeren_but.Enabled = True
        TaskTimer.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub UpdateAanpassenFlexgrid()

        Dim query As String
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim reader As OdbcDataReader
                Dim reader2 As OdbcDataReader
                Dim reader3 As OdbcDataReader
                Dim reader4 As OdbcDataReader

                Dim cmd As New OdbcCommand("", Conn)
                Dim cmd2 As New OdbcCommand("", Conn)
                Dim cmd3 As New OdbcCommand("", Conn)
                Dim cmd4 As New OdbcCommand("", Conn)

                Dim kopernaam As String = "Onbekend"
                'HEADER ID
                query = "SELECT * From orderheaders WHERE header_id =" + Str(GlobalHeader_id)
                cmd2.CommandText = query
                reader2 = cmd2.ExecuteReader()
                If reader2.HasRows Then
                    reader2.Read()
                    kopernaam = CHstr(reader2("koper_naam"))
                End If
                reader2.Close()


                karren_flx.Rows.Count = 1

                query = "SELECT * From orderkarren WHERE header_id =" + Str(GlobalHeader_id)
                cmd.CommandText = query
                reader = cmd.ExecuteReader()

                Do While reader.Read

                    Dim kar_id As Integer = CHint(reader("kar_id"))
                    Dim floriday_printflag As Integer = CHint(reader("floriday_printflag"))
                    Dim pakbonnr As String = CHstr(reader("barcode"))
                    Dim status As String = "No Fulfillment"
                    Dim loadCarrierType As String = "No Fulfillment"
                    Dim numberOfAdditionalLayers As Integer = 0
                    Dim deliveryOrderId As String = ""
                    Dim fulfillmentOrderId As String = ""
                    Dim deliveryDeleted As Boolean = False
                    Dim deliveryNotFound As Boolean = True
                    Dim kar_type As Integer = CHint(reader("kar_type"))
                    Dim aantal_lagen As Integer = CHint(reader("aantal_lagen"))
                    Dim briefnummer As String = ""

                    Dim aantal_platen As Integer = aantal_lagen
                    If kar_type = 1 Or kar_type = 2 Or kar_type = 4 Or kar_type = 5 Then
                        aantal_platen = aantal_platen - 1
                    End If
                    'TASKRUN
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(kar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()

                    If reader2.HasRows Then
                        reader2.Read()

                        deliveryOrderId = CHstr(reader2("deliveryOrderId"))
                        fulfillmentOrderId = CHstr(reader2("fulfillmentOrderId"))
                        briefnummer = CHstr(reader2("briefnummer"))

                        'FFO info
                        If fulfillmentOrderId <> "" Then
                            query = "SELECT * From floriday_fulfillmentorderssync WHERE fulfillmentOrderId ='" + fulfillmentOrderId + "'"
                            cmd3.CommandText = query
                            reader3 = cmd3.ExecuteReader()
                            If reader3.HasRows Then
                                reader3.Read()

                                status = CHstr(reader3("status"))
                                Dim parent_id As Integer = CHint(reader3("Id"))

                                If fulfillmentOrderId <> "" Then
                                    query = "SELECT * From floriday_fulfillmentorderssync_loadcarriers WHERE parent_Id = " + Str(parent_id)
                                    cmd4.CommandText = query
                                    reader4 = cmd4.ExecuteReader()
                                    If reader4.HasRows Then
                                        reader4.Read()
                                        loadCarrierType = CHstr(reader4("loadCarrierType"))
                                        numberOfAdditionalLayers = CHint(reader4("numberOfAdditionalLayers"))
                                    End If
                                    reader4.Close()
                                End If

                            End If
                            reader3.Close()
                        End If

                        'check delivery

                        If deliveryOrderId <> "" Then
                            query = "SELECT * From floriday_delivery WHERE deliveryOrderId ='" + deliveryOrderId + "'"
                            cmd3.CommandText = query
                            reader3 = cmd3.ExecuteReader()
                            If reader3.HasRows Then
                                reader3.Read()
                                deliveryNotFound = False
                                deliveryDeleted = CHbool(reader3("isDeleted"))
                                Dim dcrc As Double = CHdouble(reader3("crc"))
                                If dcrc = 0 Then deliveryNotFound = True   'geen crc, dan nog niet gepost, of post failed
                            End If
                            reader3.Close()
                        Else
                            deliveryNotFound = True
                        End If



                    End If
                    reader2.Close()

                    Dim gridfill(15) As Object
                    If kar_id = GlobalKar_id Then
                        gridfill(2) = 1  'set select
                    Else
                        gridfill(2) = 0  'clear select
                    End If
                    gridfill(2) = 0  'select
                    gridfill(3) = kar_id
                    gridfill(4) = kopernaam
                    gridfill(5) = loadCarrierType
                    ' NONE, AUCTION_TROLLEY, DANISH_TROLLEY, EURO_TROLLEY, PALLET, EURO_PALLET, DANISH_TROLLEY_NON_CC_RFID, DANISH_TROLLEY_WATER_TRAY, WATERING_CONTAINER
                    gridfill(6) = kar_type
                    gridfill(7) = numberOfAdditionalLayers
                    gridfill(8) = aantal_platen
                    gridfill(9) = pakbonnr
                    If deliveryDeleted = True Or deliveryNotFound = True Then
                        gridfill(10) = False
                    Else
                        gridfill(10) = True
                    End If
                    If fulfillmentOrderId <> "" Then
                        gridfill(11) = True
                    Else
                        gridfill(11) = False
                    End If
                    gridfill(12) = status
                    gridfill(13) = floriday_printflag
                    gridfill(14) = briefnummer


                    karren_flx.AddItem(gridfill)

                    If floriday_printflag = 99 Then
                        karren_flx.Rows(karren_flx.Rows.Count - 1).Style = karren_flx.Styles("RED")
                    End If

                Loop
                reader.Close()




            End Using
        Catch ex As Exception
            MessageBox.Show("Fout: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try



    End Sub

    Private Sub StatusRapport_but_Click(sender As Object, e As EventArgs) Handles StatusRapport_but.Click
        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then
                kar_id = CInt(karren_flx(i, 3))
                Exit For
            End If
        Next
        If kar_id = -1 Then
            MsgBox("Selecteer eerst een kar")
            Exit Sub
        End If

        Dim query As String = ""
        View_txt.Text = "Status rapport"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim reader As OdbcDataReader
                Dim reader2 As OdbcDataReader

                Dim cmd As New OdbcCommand("", Conn)
                Dim cmd2 As New OdbcCommand("", Conn)
                Dim cmd3 As New OdbcCommand("", Conn)
                Dim cmd4 As New OdbcCommand("", Conn)
                Dim cmd5 As New OdbcCommand("", Conn)


                Dim count As Integer

                query = "SELECT COUNT(*) as 'COUNT' FROM floriday_tasks WHERE status=0"
                cmd.CommandText = query
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    count = CHint(reader.Item("COUNT"))
                    View_txt.Text = View_txt.Text + "Serverstatus : " + Str(count) + " opdrachten in de wachtrij" + vbNewLine
                End If
                reader.Close()

                query = "SELECT * From orderkarren WHERE kar_id =" + Str(kar_id)
                cmd2.CommandText = query
                reader2 = cmd2.ExecuteReader()
                Dim floriday_printflag As Integer = 0
                If reader2.HasRows Then
                    reader2.Read()
                    floriday_printflag = CHint(reader2("floriday_printflag"))

                    If floriday_printflag = 0 Then View_txt.Text = View_txt.Text + "Deze kar heeft nog geen print-commando ontvangen (status=0)" + vbNewLine
                    If floriday_printflag = 1 Then View_txt.Text = View_txt.Text + "Deze kar heeft het print commando ontvangen, maar de server heeft het nog niet verwerkt. (status=1)." + vbNewLine
                    If floriday_printflag = 2 Then View_txt.Text = View_txt.Text + "Deze kar heeft het print commando ontvangen, de server is bezig met verwerking (status=2)." + vbNewLine
                    If floriday_printflag = 99 Then View_txt.Text = View_txt.Text + "Deze kar heeft het print commando ontvangen, maar er is iets fout gegaan in het proces (status=99)." + vbNewLine

                End If
                reader2.Close()

                query = "SELECT * From floriday_taskrun WHERE kar_id=" + Str(kar_id)
                cmd.CommandText = query
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()

                    Dim id As Integer = CHint(reader("id"))
                    Dim pakbonnummer As String = CHstr(reader("barcode"))
                    Dim kopernaam As String = CHstr(reader("koper_naam"))
                    Dim dataflag As Integer = CHint(reader("dataflag"))
                    Dim floridayTradeitemFlag As Integer = CHint(reader("floridayTradeitemFlag"))
                    Dim floridayBatchFlag As Integer = CHint(reader("floridayBatchFlag"))
                    Dim floridayDeliveryFlag As Integer = CHint(reader("floridayDeliveryFlag"))
                    Dim floridayFulfillmentFlag As Integer = CHint(reader("floridayFulfillmentFlag"))
                    Dim printFlag As Integer = CHint(reader("printFlag"))
                    Dim klok As Boolean = CHbool(reader("klokorder"))
                    Dim timeout As Integer = CHint(reader("timeout"))
                    Dim fulfillment_STATUS As String = CHstr(reader("fulfillment_STATUS"))
                    Dim data_error As String = CHstr(reader("data_error"))

                    Dim delivery_POST_id As Integer = CHint(reader("delivery_POST_id"))
                    Dim delivery_POST_reply As Integer = CHint(reader("delivery_POST_reply"))
                    Dim delivery_POST_error As String = CHstr(reader("delivery_POST_error"))
                    Dim delivery_GET_id As Integer = CHint(reader("delivery_GET_id"))
                    Dim delivery_GET_reply As Integer = CHint(reader("delivery_GET_reply"))
                    Dim delivery_GET_error As String = CHstr(reader("delivery_GET_error"))
                    Dim fulfillment_POST_id As Integer = CHint(reader("fulfillment_POST_id"))
                    Dim fulfillment_POST_reply As Integer = CHint(reader("fulfillment_POST_reply"))
                    Dim fulfillment_POST_error As String = CHstr(reader("fulfillment_POST_error"))

                    Dim deliveryOrderId As String = CHstr(reader("deliveryOrderId"))
                    Dim fulfillmentOrderId As String = CHstr(reader("fulfillmentOrderId"))
                    reader.Close()

                    If dataflag = 1 Then
                        View_txt.Text = View_txt.Text + "Data-check is bezig" + vbNewLine
                    ElseIf dataflag = 99 Then
                        View_txt.Text = View_txt.Text + "Er is een fout geconstateerd in de data :" + data_error + vbNewLine
                    Else
                        View_txt.Text = View_txt.Text + "De Data-informatie is in orde" + vbNewLine + vbNewLine
                    End If

                    query = "SELECT * From floriday_taskrun_lines WHERE taskrun_id=" + Str(id)
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    Do While reader.Read()
                        kar_id = CHint(reader("kar_id"))
                        Dim tradeItemId As String = CHstr(reader("new_tradeItemId"))
                        Dim tradeitem_POST_id As Integer = CHint(reader("tradeitem_POST_id"))
                        Dim tradeitem_POST_reply As Integer = CHint(reader("tradeitem_POST_reply"))
                        Dim tradeitem_POST_error As String = CHstr(reader("tradeitem_POST_error"))
                        Dim tradeitem_GET_id As Integer = CHint(reader("tradeitem_GET_id"))
                        Dim tradeitem_GET_reply As Integer = CHint(reader("tradeitem_GET_reply"))
                        Dim tradeitem_GET_error As String = CHstr(reader("tradeitem_GET_error"))

                        View_txt.Text = View_txt.Text + "Trade-item: " + tradeItemId + vbNewLine
                        If tradeitem_POST_reply = 202 Then View_txt.Text = View_txt.Text + "Trade-item variant correct verzonden" + vbNewLine
                        If tradeitem_POST_reply > 202 Then
                            View_txt.Text = View_txt.Text + "Trade-item variant niet correct verzonden:" + tradeitem_POST_error + vbNewLine
                        End If
                        If tradeitem_GET_reply = 200 Then View_txt.Text = View_txt.Text + "Trade-item variant correct gevonden op floriday" + vbNewLine
                        If tradeitem_GET_reply > 200 Then
                            View_txt.Text = View_txt.Text + "Trade-item variant niet gevonden op floriday:" + tradeitem_GET_error + vbNewLine
                        End If
                    Loop
                    reader.Close()
                    View_txt.Text = View_txt.Text + vbNewLine

                    query = "SELECT * From floriday_taskrun_lines WHERE taskrun_id=" + Str(id)
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    Do While reader.Read()
                        Dim batch_id As String = CHstr(reader("batchId"))
                        Dim batch_POST_id As Integer = CHint(reader("batch_POST_id"))
                        Dim batch_POST_reply As Integer = CHint(reader("batch_POST_reply"))
                        Dim batch_POST_error As String = CHstr(reader("new_tradeItemId"))
                        Dim batch_GET_id As Integer = CHint(reader("batch_GET_id"))
                        Dim batch_GET_reply As Integer = CHint(reader("batch_GET_reply"))
                        Dim batch_GET_error As String = CHstr(reader("batch_GET_error"))

                        View_txt.Text = View_txt.Text + "Partij aangemaakt: " + batch_id + vbNewLine
                        If batch_POST_reply = 202 Then View_txt.Text = View_txt.Text + "Partij correct verzonden" + vbNewLine
                        If batch_POST_reply > 202 Then
                            View_txt.Text = View_txt.Text + "Partij niet correct verzonden:" + batch_POST_error + vbNewLine
                        End If
                        If batch_GET_reply = 200 Then View_txt.Text = View_txt.Text + "Partij correct gevonden op floriday" + vbNewLine
                        If batch_GET_reply > 200 Then
                            View_txt.Text = View_txt.Text + "Partij niet gevonden op floriday:" + batch_GET_error + vbNewLine
                        End If
                    Loop
                    reader.Close()

                    View_txt.Text = View_txt.Text + vbNewLine

                    View_txt.Text = View_txt.Text + "Delivery aangemaakt: " + deliveryOrderId + vbNewLine
                    If delivery_POST_reply = 202 Then View_txt.Text = View_txt.Text + "Delivery correct verzonden" + vbNewLine
                    If delivery_POST_reply > 202 Then
                        View_txt.Text = View_txt.Text + "Delivery niet correct verzonden:" + delivery_POST_error + vbNewLine
                    End If
                    If delivery_GET_reply = 200 Then View_txt.Text = View_txt.Text + "Delivery correct gevonden op floriday" + vbNewLine
                    If delivery_GET_reply > 200 Then
                        View_txt.Text = View_txt.Text + "Delivery niet gevonden op floriday:" + delivery_GET_error + vbNewLine
                    End If

                    View_txt.Text = View_txt.Text + vbNewLine

                    View_txt.Text = View_txt.Text + "Fulfillment aangemaakt: " + fulfillmentOrderId + vbNewLine
                    If fulfillment_POST_reply = 202 Then View_txt.Text = View_txt.Text + "fulfillment correct verzonden" + vbNewLine
                    If fulfillment_POST_reply > 202 Then
                        View_txt.Text = View_txt.Text + "Fulfillment niet correct verzonden:" + fulfillment_POST_error + vbNewLine
                    End If
                    View_txt.Text = View_txt.Text + "Fulfillment status : " + fulfillment_STATUS + vbNewLine + vbNewLine


                    View_txt.Text = View_txt.Text + vbNewLine
                    View_txt.Text = View_txt.Text + "VERWERKINGSLOG   Kar-id:" + Str(kar_id) + vbNewLine
                    View_txt.Text = View_txt.Text + vbNewLine

                    query = "SELECT * From floriday_taskrun_log WHERE Kar_Id=" + Str(kar_id) + " ORDER BY id"
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    Do While reader.Read
                        Dim datum As DateTime = CHDate2(reader("datum"), Now)
                        Dim message As String = CHstr(reader("message"))
                        View_txt.Text = View_txt.Text + Format(datum, "dd-MM-yyyy HH:mm:ss") + " " + message + vbNewLine
                    Loop
                    reader.Close()


                    If fulfillmentOrderId <> "" Then
                        query = "SELECT * From floriday_fulfillmentorderssync_json WHERE fulfillmentOrderId='" + fulfillmentOrderId + "'"
                        cmd.CommandText = query
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            View_txt.Text = View_txt.Text + vbNewLine

                            View_txt.Text = View_txt.Text + vbNewLine

                            Dim json As String = CHstr(reader("json"))
                            View_txt.Text = View_txt.Text + json
                        End If
                        reader.Close()

                    End If
                Else
                    MsgBox("Kar_id niet gevonden")
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Fout: FD Error reporter" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try



    End Sub

    Private Sub HerstelFoutStatus_but_Click(sender As Object, e As EventArgs) Handles HerstelFoutStatus_but.Click

        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then

                kar_id = CInt(karren_flx(i, 3))

                GlobalActie = "RESETFOUT"

                DeleteDelivery = 1
                DeleteFulFillment = 1
                GlobalKar_id = kar_id
                StartTimer()

                Exit For
            End If


        Next
        If kar_id = -1 Then
            MsgBox("Selecteer eerst een kar")
            Exit Sub
        End If

    End Sub

    Private Sub EABAnnuleren_but_Click(sender As Object, e As EventArgs) Handles EABAnnuleren_but.Click
        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then
                kar_id = CInt(karren_flx(i, 3))

                GlobalActie = "ANNULEREN"

                DeleteDelivery = 1
                DeleteFulFillment = 1
                GlobalKar_id = kar_id
                StartTimer()

                Exit For
            End If
        Next
        If kar_id = -1 Then
            MsgBox("Selecteer eerst een kar")
            Exit Sub
        End If
    End Sub

    Private Sub KarAanpassen_but_Click(sender As Object, e As EventArgs) Handles KarAanpassen_but.Click

        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then
                kar_id = CInt(karren_flx(i, 3))

                Dim oldplaten As Integer = CInt(karren_flx.Item(i, 7))
                Dim newplaten As Integer = CInt(karren_flx.Item(i, 8))
                Dim kartype As String = CHstr(karren_flx.Item(i, 6))
                Dim kar_aanpassen As Boolean = False
                If Val(kartype) > 0 Then
                    kar_aanpassen = True
                End If
                If oldplaten <> newplaten Then
                    kar_aanpassen = True
                End If

                If kar_aanpassen = True Then

                    Dim query As String = ""
                    Try
                        'Open Connection
                        Using Conn As New OdbcConnection(ConnString)
                            Conn.Open()

                            Dim cmd As New OdbcCommand("", Conn)

                            'Kar_type
                            'Aantal_lagen
                            'Aantal_lagenLock

                            Dim kartypeint As Integer = CInt(Val(kartype))
                            Dim aantal_lagen As Integer = newplaten
                            If (kartypeint = 1 Or kartypeint = 2 Or kartypeint = 4 Or kartypeint = 5) And aantal_lagen > 0 Then
                                aantal_lagen = aantal_lagen + 1
                            End If
                            If kartypeint = 8 Then aantal_lagen = 0
                            If kartypeint = 0 Then
                                'kar niet aanpassen
                                query = "UPDATE orderkarren SET aantal_lagen=?,aantal_lagenlock=true WHERE kar_id=" + Str(kar_id)
                                cmd.CommandText = query
                                cmd.Parameters.Clear()
                                cmd.Parameters.AddWithValue("", aantal_lagen)
                                cmd.ExecuteNonQuery()
                            Else
                                query = "UPDATE orderkarren SET Kar_type=?, aantal_lagen=?,aantal_lagenlock=true WHERE kar_id=" + Str(kar_id)
                                cmd.CommandText = query
                                cmd.Parameters.Clear()
                                cmd.Parameters.AddWithValue("", kartypeint)
                                cmd.Parameters.AddWithValue("", aantal_lagen)
                                cmd.ExecuteNonQuery()

                            End If
                            GlobalActie = "AANPASSEN"
                            DeleteDelivery = 1
                            DeleteFulFillment = 1
                            GlobalKar_id = kar_id
                            StartTimer()

                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Fout: FD Kar aanpassen" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End Try

                    Exit For
                Else
                    MsgBox("Karren en platen zijn gelijk, aanpassen niet nodig")
                End If
            End If
        Next
        If kar_id = -1 Then
            MsgBox("Selecteer eerst een kar")
            Exit Sub
        End If


    End Sub

    Private Sub KarCorrigeren_but_Click(sender As Object, e As EventArgs) Handles KarCorrigeren_but.Click

        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then
                kar_id = CInt(karren_flx(i, 3))
                Dim oldplaten As Integer = CInt(karren_flx.Item(i, 7))
                Dim newplaten As Integer = CInt(karren_flx.Item(i, 8))
                Dim kartype As String = CHstr(karren_flx.Item(i, 6))
                GlobalBriefnummer = CHstr(karren_flx.Item(i, 14))
                Dim kar_aanpassen As Boolean = False
                If Val(kartype) > 0 Then
                    kar_aanpassen = True
                End If
                If oldplaten <> newplaten Then
                    kar_aanpassen = True
                End If

                If kar_aanpassen = True Then

                    Dim query As String = ""
                    Try
                        'Open Connection
                        Using Conn As New OdbcConnection(ConnString)
                            Conn.Open()

                            Dim cmd As New OdbcCommand("", Conn)
                            Dim cmd2 As New OdbcCommand("", Conn)
                            Dim cmd3 As New OdbcCommand("", Conn)
                            Dim reader2 As OdbcDataReader
                            Dim reader3 As OdbcDataReader


                            'Kar_type
                            'Aantal_lagen
                            'Aantal_lagenLock
                            Dim doe_correctie As Boolean = True

                            Dim fulfillmentOrderId As String = ""
                            query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(kar_id)
                            cmd2.CommandText = query
                            reader2 = cmd2.ExecuteReader()
                            If reader2.HasRows Then
                                reader2.Read()
                                fulfillmentOrderId = CHstr(reader2("fulfillmentOrderId"))
                            End If
                            query = "SELECT * From floriday_fulfillmentorderssync_logisticlabelcodes WHERE value ='" + GlobalBriefnummer + "'"
                            cmd2.CommandText = query
                            reader2 = cmd2.ExecuteReader()
                            If reader2.HasRows Then
                                reader2.Read()
                                Dim parent_id As Integer = CHint(reader2("parent_id"))

                                query = "SELECT * From fulfillmentOrderId WHERE id =" + Str(parent_id)
                                cmd3.CommandText = query
                                reader3 = cmd3.ExecuteReader()
                                If reader3.HasRows Then
                                    reader3.Read()
                                    Dim fulfillmentOrderId2 As String = CHstr(reader3("fulfillmentOrderId"))
                                    If fulfillmentOrderId <> fulfillmentOrderId2 Then
                                        MsgBox("Briefnummer komt niet overeen met briefnummers in EAB, correctie niet mogelijk")
                                        doe_correctie = False
                                    End If
                                End If

                            Else
                                MsgBox("Briefnummer niet gevonden, aanpassing niet mogelijk")
                                doe_correctie = False
                            End If

                            If doe_correctie = True Then


                                Dim kartypeint As Integer = CInt(Val(kartype))
                                Dim aantal_lagen As Integer = newplaten
                                If (kartypeint = 1 Or kartypeint = 2 Or kartypeint = 4 Or kartypeint = 5) And aantal_lagen > 0 Then
                                    aantal_lagen = aantal_lagen + 1
                                End If
                                If kartypeint = 8 Then aantal_lagen = 0
                                If kartypeint = 0 Then
                                    'kar niet aanpassen
                                    query = "UPDATE orderkarren SET aantal_lagen=?,aantal_lagenlock=true WHERE kar_id=" + Str(kar_id)
                                    cmd.CommandText = query
                                    cmd.Parameters.Clear()
                                    cmd.Parameters.AddWithValue("", aantal_lagen)
                                    cmd.ExecuteNonQuery()
                                Else
                                    query = "UPDATE orderkarren SET Kar_type=?, aantal_lagen=?,aantal_lagenlock=true WHERE kar_id=" + Str(kar_id)
                                    cmd.CommandText = query
                                    cmd.Parameters.Clear()
                                    cmd.Parameters.AddWithValue("", kartypeint)
                                    cmd.Parameters.AddWithValue("", aantal_lagen)
                                    cmd.ExecuteNonQuery()

                                End If
                                GlobalActie = "CORRIGEREN"
                                GlobalKar_id = kar_id
                                StartTimer()
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Fout: FD Kar aanpassen" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End Try

                    Exit For

                Else
                    MsgBox("Karren en platen zijn gelijk, corrigeren niet nodig")

                End If
            End If
        Next
        If kar_id = -1 Then
            MsgBox("Selecteer eerst een kar")
            Exit Sub
        End If
    End Sub

    Private Sub TaskTimer_Tick(sender As Object, e As EventArgs) Handles TaskTimer.Tick

        Dim pvalue As Integer = ProgressBar1.Value
        pvalue = pvalue + 10
        If pvalue > 100 Then pvalue = 0
        ProgressBar1.Value = pvalue

        Dim query As String = ""
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim reader As OdbcDataReader
                Dim cmd As New OdbcCommand("", Conn)
                Dim reader2 As OdbcDataReader
                Dim cmd2 As New OdbcCommand("", Conn)
                Dim reader3 As OdbcDataReader
                Dim cmd3 As New OdbcCommand("", Conn)
                Dim reader4 As OdbcDataReader
                Dim cmd4 As New OdbcCommand("", Conn)
                Dim cmd5 As New OdbcCommand("", Conn)

                ' STATUSSEN OPHALEN


                If FFtask > 0 Then
                    query = "SELECT * From floriday_tasks WHERE id=" + Str(FFtask)
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim xffstatus As Integer = CHint(reader("status"))
                        If xffstatus = 2 Then
                            View_txt.Text = View_txt.Text + "Fulfillment POST gechecked" + vbNewLine
                            GetFulfillmentStatus = False
                            FFtask = 0
                        ElseIf xffstatus = 12 Then
                            View_txt.Text = View_txt.Text + "Er is wat mis met de floriday servers, fulfillment check mislukt." + vbNewLine
                            GetFulfillmentStatus = False
                            FFtask = 0
                        ElseIf xffstatus = 0 Then
                            View_txt.Text = View_txt.Text + "Fulfillment POST staat nog in de wachtrij." + vbNewLine
                        End If
                    End If
                    reader.Close()
                Else
                    GetFulfillmentStatus = False
                End If


                If DVtask > 0 Then
                    query = "SELECT * From floriday_tasks WHERE id=" + Str(DVtask)
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim dvstatus As Integer = CHint(reader("status"))
                        If dvstatus = 2 Then
                            View_txt.Text = View_txt.Text + "Delivery POST gechecked" + vbNewLine
                            GetDeliveryStatus = False
                            DVtask = 0
                        ElseIf dvstatus = 12 Then
                            View_txt.Text = View_txt.Text + "Er is wat mis met de floriday servers, delivery check mislukt." + vbNewLine
                            GetDeliveryStatus = False
                            DVtask = 0
                        ElseIf dvstatus = 0 Then
                            View_txt.Text = View_txt.Text + "Delivery POST staat nog in de wachtrij." + vbNewLine
                        End If
                    End If
                    reader.Close()
                Else
                    GetDeliveryStatus = False
                End If


                ' DELIVERY ANNULEREN POST (als fulfillment delete is afgerond)

                If (DeleteDelivery = 1 Or DeleteDelivery = 3) And DeleteFulFillment = 0 And DVtask = 0 Then
                    Dim deliveryOrderId As String = ""
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(GlobalKar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()
                    Dim deliveryDeleted As Boolean = False
                    Dim deliveryNotFound As Boolean = False
                    If reader2.HasRows Then
                        reader2.Read()

                        deliveryOrderId = CHstr(reader2("deliveryOrderId"))
                        'check delivery

                        If deliveryOrderId <> "" Then
                            query = "SELECT * From floriday_delivery WHERE deliveryOrderId ='" + deliveryOrderId + "'"
                            cmd3.CommandText = query
                            reader3 = cmd3.ExecuteReader()
                            If reader3.HasRows Then
                                reader3.Read()
                                deliveryDeleted = CHbool(reader3("isDeleted"))
                                Dim dcrc As Double = CHdouble(reader3("crc"))
                                If dcrc = 0 Then deliveryNotFound = True   'geen crc, dan nog niet gepost, of post failed
                            End If
                            reader3.Close()
                        Else
                            deliveryNotFound = True
                        End If
                    Else
                        deliveryNotFound = True
                    End If

                    If deliveryNotFound = True Then
                        View_txt.Text = View_txt.Text + "Delivery-order niet gevonden, verwijderen niet nodig." + vbNewLine
                        DeleteDelivery = 0
                    ElseIf deliveryDeleted = True Then
                        View_txt.Text = View_txt.Text + "Delivery-order is verwijderd." + vbNewLine
                        DeleteDelivery = 0
                    Else
                        If deliveryDeleted = False Then
                            View_txt.Text = View_txt.Text + "Delivery-order verwijderen..." + vbNewLine
                            Dim DVDelete As Integer = Form1.InsertTask(0, 95, "DELETE", "delivery-orders", deliveryOrderId, "auction")
                            DVtask = DVDelete
                            DeleteDelivery = 2
                        End If
                        If deliveryDeleted = 3 Then
                            'nieuwe status nog niet 'isDeleted' nog een keer Sync
                            DeleteDelivery = 2
                        End If
                    End If

                End If

                If DeleteDelivery = 2 And DVtask = 0 Then   'haal nieuwe info op en check of de delivery al 'isDeleted' status heeft
                    DVtask = Form1.InsertTask(4, 80, "GET", "delivery-orders", "sync")
                    View_txt.Text = View_txt.Text + "Delivery-order status ophalen..." + vbNewLine
                    DeleteDelivery = 3
                End If


                'FULFILLMENT ANNULEREN

                Dim ffstatus As String = "NOTFOUND"
                If (DeleteFulFillment = 1 Or DeleteFulFillment = 3) And FFtask = 0 Then
                    Dim fulfillmentOrderId As String = ""
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(GlobalKar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()

                    If reader2.HasRows Then
                        reader2.Read()
                        fulfillmentOrderId = CHstr(reader2("fulfillmentOrderId"))

                        'FFO info
                        If fulfillmentOrderId <> "" Then
                            query = "SELECT * From floriday_fulfillmentorderssync WHERE fulfillmentOrderId ='" + fulfillmentOrderId + "'"
                            cmd3.CommandText = query
                            reader3 = cmd3.ExecuteReader()
                            If reader3.HasRows Then
                                reader3.Read()
                                ffstatus = CHstr(reader3("status"))
                            End If
                            reader3.Close()
                        End If
                    End If

                    If ffstatus = "NOTFOUND" Then
                        View_txt.Text = View_txt.Text + "Fulfillment order kan niet gevonden worden, Fulfillment(EAB) verwijderen niet nodig." + vbNewLine
                        DeleteFulFillment = 0
                    End If
                    ' DRAFT, PENDING, ACCEPTED, FAILED, CANCELLED, DELIVERED 
                    If (ffstatus = "DRAFT" Or ffstatus = "PENDING") And DeleteFulFillment = 1 Then
                        View_txt.Text = View_txt.Text + "Deze Fulfillment order kan niet nog niet worden verwijdered, daarvoor is status 'ACCEPTED' nodig." + vbNewLine
                        DeleteDelivery = 0
                        DeleteFulFillment = 0
                        StopTimer()
                        Exit Sub
                    End If
                    If ffstatus = "CANCELLED" And DeleteFulFillment = 1 Then
                        View_txt.Text = View_txt.Text + "Deze Fulfillment order is al verwijderd." + vbNewLine
                        DeleteFulFillment = 0
                    End If
                    If ffstatus = "CANCELLED" And DeleteFulFillment = 3 Then
                        View_txt.Text = View_txt.Text + "De Fulfillment order is verwijderd." + vbNewLine
                        DeleteFulFillment = 0

                        DVtask = Form1.InsertTask(4, 80, "GET", "delivery-orders", "sync")   'delivery updaten
                        View_txt.Text = View_txt.Text + "Delivery order resync." + vbNewLine
                        GetDeliveryStatus = True

                        query = "SELECT * From orderkarlines WHERE kar_id =" + Str(GlobalKar_id)
                        cmd3.CommandText = query
                        reader3 = cmd3.ExecuteReader()
                        Do While reader3.Read()
                            Dim aantal As Integer = CHint(reader3("aantal"))
                            Dim orderline_id As Integer = CHint(reader3("orderline_id"))
                            Dim karline_id As Integer = CHint(reader3("id"))

                            query = "SELECT * From floriday_salesorders_fulfillmentlog WHERE eab_deleted=0 AND karline_id=" + Str(karline_id)
                            cmd4.CommandText = query
                            reader4 = cmd4.ExecuteReader()
                            Do While reader4.Read()
                                Dim logid As Integer = CHint(reader4("id"))
                                Dim packages_fulfilled As Integer = CHint(reader4("packages_fulfilled"))
                                Dim fd_orderlineId As String = CHstr(reader4("fd_orderlineId"))

                                query = "UPDATE floriday_salesorders_boek SET packages_to_fullfill=packages_to_fullfill+? WHERE orderlineId=?"
                                cmd5.CommandText = query
                                cmd5.Parameters.Clear()
                                cmd5.Parameters.AddWithValue("", packages_fulfilled)
                                cmd5.Parameters.AddWithValue("", fd_orderlineId)
                                cmd5.ExecuteNonQuery()

                                query = "UPDATE floriday_salesorders_fulfillmentlog SET eab_deleted=1 WHERE id=?"
                                cmd5.CommandText = query
                                cmd5.Parameters.Clear()
                                cmd5.Parameters.AddWithValue("", logid)
                                cmd5.ExecuteNonQuery()

                            Loop
                            reader4.Close()
                        Loop
                        reader3.Close()

                        query = "UPDATE orderkarren SET floriday_printflag=0 WHERE kar_id=" + Str(GlobalKar_id)
                        cmd3.CommandText = query
                        cmd3.ExecuteNonQuery()
                        Form1.SetNewStatusFlag(Now, GlobalHeader_id, True)

                    End If
                    If ffstatus = "FAILED" Then
                        View_txt.Text = View_txt.Text + "Deze Fulfillment hoeft niet te worden verwijderd, want hij is nooit bevestigd." + vbNewLine
                    End If
                    If (ffstatus = "ACCEPTED" Or ffstatus = "DELIVERED") And DeleteFulFillment = 1 Then
                        View_txt.Text = View_txt.Text + "Fulfilment-order(EAB) wordt verwijderd..." + vbNewLine
                        Dim FFDelete As Integer = Form1.InsertTask(0, 95, "DELETE", "fulfillment-orders", fulfillmentOrderId)
                        FFtask = FFDelete
                        DeleteFulFillment = 2
                    End If
                    If (ffstatus = "ACCEPTED" Or ffstatus = "DELIVERED" Or ffstatus = "PENDING") And DeleteFulFillment = 3 Then
                        DeleteFulFillment = 2
                        'status nog niet veranderd, nogmaals sync
                    End If

                End If

                If DeleteFulFillment = 2 And FFtask = 0 Then   'haal nieuwe info op en check of de delivery al 'isDeleted' status heeft
                    FFtask = Form1.InsertTask(4, 80, "GET", "fulfillment-orders", "sync")
                    View_txt.Text = View_txt.Text + "Fulfillment-order status ophalen..." + vbNewLine
                    DeleteFulFillment = 3
                End If

                If GlobalActie = "CORRIGEREN" Then


                    Dim fulfillmentOrderId As String = ""
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(GlobalKar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()
                    If reader2.HasRows Then
                        reader2.Read()
                        fulfillmentOrderId = CHstr(reader2("fulfillmentOrderId"))
                    End If
                    reader2.Close()

                    query = "INSERT INTO floriday_fulfillmentorders_corrections(correctionId,status,creationDateTime,lastModifiedDateTime,crc,crc_delete) VALUES (?,?,?,?,?,?)"
                    cmd2.CommandText = query
                    cmd2.Parameters.Clear()

                    Dim newid As String = System.Guid.NewGuid().ToString()

                    cmd2.Parameters.AddWithValue("", newid)
                    cmd2.Parameters.AddWithValue("", "")
                    cmd2.Parameters.AddWithValue("", Format(Now, "yy-MM-dd HH:mm:ss"))
                    cmd2.Parameters.AddWithValue("", Format(Now, "yy-MM-dd HH:mm:ss"))
                    cmd2.Parameters.AddWithValue("", 0)
                    cmd2.Parameters.AddWithValue("", 0)
                    cmd2.ExecuteNonQuery()

                    cmd2.CommandText = "SELECT LAST_INSERT_ID()"
                    Dim id As Integer = Convert.ToInt32(cmd2.ExecuteScalar())

                    query = "INSERT INTO floriday_fulfillmentorders_corrections_loadcarriercorrections(logisticLabelCode,loadCarrierType,numberOfAdditionalLayers,crc,crc_delete,parent_id) VALUES (?,?,?,?,?,?)"
                    cmd2.CommandText = query
                    cmd2.Parameters.Clear()

                    Dim kar_type As Integer = 0
                    Dim aantal_lagen As Integer = 4

                    query = "SELECT * From orderkarren WHERE kar_id =" + Str(GlobalKar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()
                    If reader2.HasRows Then
                        reader2.Read()
                        kar_type = CHint(reader2("kar_type"))
                        aantal_lagen = CHint(reader2("aantal_lagen"))
                    End If
                    reader2.Close()

                    Dim kar_enum As String = "AUCTION_TROLLEY"
                    Dim extralagen As Integer = 1
                    Select Case kar_type
                        Case 1, 2
                            kar_enum = "DANISH_TROLLEY"
                            extralagen = aantal_lagen - 1
                        Case 3, 13, 14, 15
                            kar_enum = "AUCTION_TROLLEY"
                            extralagen = aantal_lagen
                        Case 4, 5
                            kar_enum = "DANISH_TROLLEY_NON_CC_RFID"
                            extralagen = aantal_lagen - 1
                        Case 8, 9, 10, 11, 12 : kar_enum = "NONE"
                        Case 6 : kar_enum = "PALLET"
                        Case 7 : kar_enum = "EURO_PALLET"
                        Case 16 : kar_enum = "EURO_TROLLEY"
                    End Select

                    cmd2.Parameters.AddWithValue("", GlobalBriefnummer)
                    cmd2.Parameters.AddWithValue("", kar_enum)
                    cmd2.Parameters.AddWithValue("", extralagen)
                    cmd2.Parameters.AddWithValue("", 0)
                    cmd2.Parameters.AddWithValue("", 0)
                    cmd2.Parameters.AddWithValue("", id)
                    cmd2.ExecuteNonQuery()


                    FFtask = Form1.InsertTask(0, 80, "PUT", "fulfillment-orders", fulfillmentOrderId, "corrections", "", "", "", "", "", "", id)
                    View_txt.Text = View_txt.Text + "Correctie op brief verstuurd." + vbNewLine
                    View_txt.Text = View_txt.Text + "Check of Fulfillment-order is geaccepteerd." + vbNewLine


                End If

                If GetDeliveryStatus = False And GetFulfillmentStatus = False And DeleteDelivery = 0 And DeleteFulFillment = 0 Then


                    If GlobalActie = "AANPASSEN" Or GlobalActie = "ANNULEREN" Or GlobalActie = "RESETFOUT" Then
                        'delete old taskrun
                        query = "UPDATE floriday_taskrun SET kar_id = -kar_id WHERE kar_id=" + Str(GlobalKar_id)
                        cmd3.CommandText = query
                        cmd3.ExecuteNonQuery()
                    End If

                    If GlobalActie = "RESETFOUT" Or GlobalActie = "ANNULEREN" Then
                        query = "UPDATE orderkarren SET floriday_printflag=0 WHERE kar_id=" + Str(GlobalKar_id)
                        cmd3.CommandText = query
                        cmd3.ExecuteNonQuery()
                        Form1.SetNewStatusFlag(Now, GlobalHeader_id, True)
                        View_txt.Text = View_txt.Text + "Verwerking klaar." + vbNewLine
                    End If

                    If GlobalActie = "AANPASSEN" Then
                        'print again
                        View_txt.Text = View_txt.Text + "De brief wordt opnieuw geprint..." + vbNewLine
                        View_txt.Text = View_txt.Text + "Verwerking klaar." + vbNewLine
                        query = "UPDATE orderkarren SET floriday_printflag=1 WHERE kar_id=" + Str(GlobalKar_id)
                        cmd3.CommandText = query
                        cmd3.ExecuteNonQuery()
                        Form1.SetNewStatusFlag(Now, GlobalHeader_id, True)
                    End If

                    If GlobalActie = "CORRIGEREN" Then
                        View_txt.Text = View_txt.Text + "De correctie zal spoedig worden verwerkt, dit kan enige tijd duren (correcties op de veiling zijn traag)." + vbNewLine
                        View_txt.Text = View_txt.Text + "Verwerking klaar." + vbNewLine
                    End If

                    StopTimer()

                End If





            End Using
        Catch ex As Exception
            MessageBox.Show("Fout: FD Error reporter" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub karren_flx_AfterEdit(sender As Object, e As RowColEventArgs) Handles karren_flx.AfterEdit
        If karren_flx.Item(e.Row, 2) = True Then
            For i = 1 To karren_flx.Rows.Count - 1
                If karren_flx.Item(i, 2) = True And Not i = e.Row Then
                    karren_flx.Item(i, 2) = False
                End If
            Next
        End If
    End Sub

End Class