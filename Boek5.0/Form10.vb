Option Strict On
Imports System.Data.Odbc


Public Class LabelberichtInfo

    Dim koper_ean_save As String = ""
    Dim header_id_save As Integer

    Public Sub InitLB(ByVal header_id As Integer)

        header_id_save = header_id

        Dim koper_naam As String = "Onbekende koper"
        Dim koper_ean As String = ""
        Dim sticker As Integer = 0
        Dim aantal As Integer = 0
        Dim soort_id As Integer = 0
        Dim fust_id As Integer = 0
        Dim accessoire_id As Integer = 0
        Dim koper_ref As String = ""
        Dim label_status As Integer = 0
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim Reader As OdbcDataReader
                Dim Cmd As New OdbcCommand("SELECT * FROM orderheaders where header_id = ?", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("", header_id)
                Reader = Cmd.ExecuteReader()
                If Reader.HasRows Then
                    Reader.Read()
                    koper_ean = CHstr(Reader("koper_ean"))
                    koper_ean_save = koper_ean
                    koper_naam = CHstr(Reader("koper_naam"))
                    sticker = CHint(Reader("sticker"))
                End If
                Reader.Close()

                FlexGridLB.Rows.Count = 1

                Dim Cmd2 As New OdbcCommand("SELECT * FROM orderlines where OrderHeader_id = ?", Conn)
                Cmd2.Parameters.Clear()
                Cmd2.Parameters.AddWithValue("", header_id)
                Reader = Cmd2.ExecuteReader()
                Do While Reader.Read
                    aantal = CHint(Reader("aantal"))
                    soort_id = CHint(Reader("soort_id"))
                    fust_id = CHint(Reader("fust_id"))
                    accessoire_id = CHint(Reader("accessoire1"))
                    koper_ref = CHstr(Reader("kopercode"))
                    label_status = CHint(Reader("label_status"))

                    Dim soort_naam As String = ""
                    If soort_id < 10000 Then
                        'soort
                        soort_naam = GetSoortNaam(soort_id)
                    Else
                        'mix
                        soort_naam = GetMixNaam(soort_id - 10000)
                    End If
                    Dim aantal_per_fust As Integer = GetAantal_per_Fust(fust_id)
                    Dim accessoire_naam As String = GetAccessoireNaam(accessoire_id)

                    Dim flexgridfill(8) As String
                    Dim reader3 As OdbcDataReader
                    Dim Cmd3 As New OdbcCommand("SELECT * FROM label_bericht WHERE CustomerParty_EAN=? AND Referenced_id=?", Conn)
                    Cmd3.Parameters.Clear()
                    Cmd3.Parameters.AddWithValue("", koper_ean)
                    Cmd3.Parameters.AddWithValue("", koper_ref)
                    reader3 = Cmd3.ExecuteReader()

                    Dim ref_found As Boolean = False

                    Do While reader3.Read
                        ref_found = True
                        Dim placement As Integer = CHint(reader3("placement"))
                        Dim quantity As Integer = CHint(reader3("quantity"))
                        Dim status As Integer = CHint(reader3("status"))
                        Dim errorcount As Integer = CHint(reader3("error_count"))
                        Dim labeltype As String = Str(placement)
                        Dim status_tekst As String = ""
                        Select Case placement
                            Case 1 : labeltype = "Pot"
                            Case 2 : labeltype = "Potcover"
                            Case 3 : labeltype = "Fust"
                            Case 4 : labeltype = "Laag"
                            Case 5 : labeltype = "Kar"
                            Case 6 : labeltype = "Etiket"
                        End Select
                        If status < 10 Then status_tekst = "Labels ophalen"
                        If status >= 10 And status < 20 Then status_tekst = "Klaar om te koppelen"
                        If status = 20 Then status_tekst = "Order afgerond"

                        flexgridfill(0) = Str(aantal) + " x " + Str(aantal_per_fust)
                        flexgridfill(1) = soort_naam
                        flexgridfill(2) = accessoire_naam
                        flexgridfill(3) = koper_ref
                        flexgridfill(4) = labeltype
                        flexgridfill(5) = Str(quantity)
                        flexgridfill(6) = status_tekst
                        flexgridfill(7) = Str(errorcount)
                        FlexGridLB.AddItem(flexgridfill)

                    Loop
                    If ref_found = False And label_status > 0 Then
                        flexgridfill(0) = Str(aantal) + " x " + Str(aantal_per_fust)
                        flexgridfill(1) = soort_naam
                        flexgridfill(2) = accessoire_naam
                        flexgridfill(3) = koper_ref
                        flexgridfill(4) = "?"
                        flexgridfill(5) = "?"
                        flexgridfill(6) = "Label (nog) niet gevonden"
                        flexgridfill(7) = "0"
                        FlexGridLB.AddItem(flexgridfill)
                    End If
                Loop

            End Using
        Catch ex As Exception
            MessageBox.Show("Labelbericht overzicht " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Function GetSoortNaam(ByVal id As Integer) As String
        Dim soortnaam As String = ""

        For i = 1 To UBound(soorten)
            If soorten(i).id = id Then
                soortnaam = soorten(i).soortnaam
                Exit For
            End If
        Next i
        Return soortnaam
    End Function

    Public Function GetMixNaam(ByVal id As Integer) As String
        Dim soortnaam As String = ""

        For i = 1 To UBound(mixen)
            If mixen(i).id = id Then
                soortnaam = mixen(i).naam
                Exit For
            End If
        Next i
        Return soortnaam
    End Function

    Public Function GetAccessoireNaam(ByVal id As Integer) As String
        Dim accessoire_naam As String = ""

        For i = 1 To UBound(accessoire)
            If accessoire(i).id = id Then
                accessoire_naam = accessoire(i).naam
                Exit For
            End If
        Next i
        Return accessoire_naam
    End Function

    Public Function GetAantal_per_Fust(ByVal id As Integer) As Integer
        Dim apf As Integer = 0

        For i = 1 To UBound(fust)
            If fust(i).id = id Then
                apf = fust(i).aantal_per_fust
                Exit For
            End If
        Next i
        Return apf
    End Function

    Private Sub reset_fouttelling_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_fouttelling_but.Click
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                If koper_ean_save <> "" Then

                    For i = 1 To FlexGridLB.Rows.Count - 1

                        Dim koper_ref = FlexGridLB.Item(i, 3)

                        Dim Cmd3 As New OdbcCommand("UPDATE label_bericht SET error_count=0 WHERE CustomerParty_EAN=? AND Referenced_id=?", Conn)
                        Cmd3.Parameters.Clear()
                        Cmd3.Parameters.AddWithValue("", koper_ean_save)
                        Cmd3.Parameters.AddWithValue("", koper_ref)
                        Cmd3.ExecuteNonQuery()

                    Next

                    If header_id_save <> 0 Then
                        InitLB(header_id_save)
                    End If

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Labelbericht overzicht " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class