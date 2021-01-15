Imports System.Data.Odbc
Imports C1.Win.C1FlexGrid

Public Class Form16

    Private FFtask As Integer = 0
    Private DVtask As Integer = 0
    Private GlobalHeader_id As Integer = 0
    Private GlobalKar_id As Integer = 0

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
        StartTimer()

    End Sub

    Private Sub StartTimer()
        View_txt.Text = "Verbinden met Floriday.. even wachten A.U.B." + vbNewLine
        StatusRapport_but.Enabled = False
        HerstelStatusRapport_but.Enabled = False
        EABAnnuleren_but.Enabled = False
        KarAanpassen_but.Enabled = False
        KarCorrigeren_but.Enabled = False
        TaskTimer.Enabled = True
    End Sub

    Private Sub StopTimer()
        UpdateAanpassenFlexgrid()
        StatusRapport_but.Enabled = True
        HerstelStatusRapport_but.Enabled = True
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
                    Dim deliveryNotFound As Boolean = False
                    'TASKRUN
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(kar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()

                    If reader2.HasRows Then
                        reader2.Read()

                        deliveryOrderId = CHstr(reader2("deliveryOrderId"))
                        fulfillmentOrderId = CHstr(reader2("fulfillmentOrderId"))

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

                    Dim gridfill(12) As Object
                    If kar_id = GlobalKar_id Then
                        gridfill(2) = 1  'set select
                    Else
                        gridfill(2) = 0  'clear select
                    End If
                    gridfill(2) = 0  'select
                    gridfill(3) = kar_id
                    gridfill(4) = kopernaam
                    gridfill(5) = loadCarrierType
                    gridfill(6) = ""
                    gridfill(7) = numberOfAdditionalLayers
                    gridfill(8) = numberOfAdditionalLayers
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

                    karren_flx.AddItem(gridfill)


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

    Private Sub HerstelStatusRapport_but_Click(sender As Object, e As EventArgs) Handles HerstelStatusRapport_but.Click

    End Sub

    Private Sub EABAnnuleren_but_Click(sender As Object, e As EventArgs) Handles EABAnnuleren_but.Click
        Dim kar_id As Integer = -1
        For i = 1 To karren_flx.Rows.Count - 1
            If karren_flx.Item(i, 2) = True Then
                kar_id = CInt(karren_flx(i, 3))
                EAB_Annuleren(kar_id)
                Exit For
            End If
        Next
    End Sub

    Private Sub EAB_Annuleren(kar_id)
        DeleteDelivery = 1
        DeleteFulFillment = 1
        GlobalKar_id = kar_id
        StartTimer()
    End Sub
    Private Sub KarAanpassen_but_Click(sender As Object, e As EventArgs) Handles KarAanpassen_but.Click

    End Sub

    Private Sub KarCorrigeren_but_Click(sender As Object, e As EventArgs) Handles KarCorrigeren_but.Click

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


                ' STATUSSEN OPHALEN


                If FFtask > 0 Then
                    query = "SELECT * From floriday_tasks WHERE id=" + Str(FFtask)
                    cmd.CommandText = query
                    reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim ffstatus As Integer = CHint(reader("status"))
                        If ffstatus = 2 Then
                            View_txt.Text = View_txt.Text + "Fulfillment POST gechecked" + vbNewLine
                            GetFulfillmentStatus = False
                            FFtask = 0
                        ElseIf ffstatus = 12 Then
                            View_txt.Text = View_txt.Text + "Er is wat mis met de floriday servers, fulfillment check mislukt." + vbNewLine
                            GetFulfillmentStatus = False
                            FFtask = 0
                        ElseIf ffstatus = 0 Then
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


                ' DELIVERY ANNULEREN POST

                If (DeleteDelivery = 1 Or DeleteDelivery = 3) And DVtask = 0 Then
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
                        View_txt.Text = View_txt.Text + "Delivery kan niet gevonden worden, delivery-order verwijderen mislukt." + vbNewLine
                    End If
                    If deliveryNotFound = True Then
                        View_txt.Text = View_txt.Text + "Delivery-order niet gevonden, verwijderen niet nodig." + vbNewLine
                        DeleteDelivery = 0
                    ElseIf deliveryDeleted = True Then
                        View_txt.Text = View_txt.Text + "Delivery-order is verwijderd." + vbNewLine
                        DeleteDelivery = 0
                    Else
                        If deliveryDeleted = 1 Then
                            View_txt.Text = View_txt.Text + "Delivery-order verwijderen..." + vbNewLine
                            Dim DVDelete As Integer = Form1.InsertTask(120, 95, "DELETE", "delivery-orders", deliveryOrderId)
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


                If 1 = 0 And DeleteFulFillment = 1 And DeleteDelivery = 0 Then
                    query = "SELECT * From floriday_taskrun WHERE kar_id =" + Str(GlobalKar_id)
                    cmd2.CommandText = query
                    reader2 = cmd2.ExecuteReader()

                    If reader2.HasRows Then
                        reader2.Read()

                        Dim deliveryOrderId As String = CHstr(reader2("deliveryOrderId"))
                        Dim fulfillmentOrderId As String = CHstr(reader2("fulfillmentOrderId"))

                        'FFO info
                        If fulfillmentOrderId <> "" Then
                            query = "SELECT * From floriday_fulfillmentorderssync WHERE fulfillmentOrderId ='" + fulfillmentOrderId + "'"
                            cmd3.CommandText = query
                            reader3 = cmd3.ExecuteReader()
                            If reader3.HasRows Then
                                reader3.Read()


                                Dim parent_id As Integer = CHint(reader3("Id"))

                            End If
                            reader3.Close()
                        End If


                    End If


                End If




                If GetDeliveryStatus = False And GetFulfillmentStatus = False And DeleteDelivery = 0 And DeleteFulFillment = 0 Then
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