Imports System.Data.Odbc

Public Class Form14

    '{
    '  "correctionId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    '  "correctionType": "MODIFICATION","CANCELLATION"
    '  "numberOfPieces": 0,
    '  "pricePerPiece": {
    '    "currency": "EUR",
    '    "value": 0
    '  },
    '  "package": {
    '    "vbnPackageCode": 0,
    '    "customPackageId": "3fa85f64-5717-4562-b3fc-2c963f66afa6"
    '  },
    '  "piecesPerPackage": 0,
    '  "reason": "string"
    '}


    Public Sub Init(OrderlineId As String)
        Dim query As String = ""
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd2 As New OdbcCommand(query, Conn)
                Dim Reader2 As OdbcDataReader

                query = "SELECT * FROM floriday_salesorders WHERE orderLineId='" + OrderlineId + "'"
                Cmd2.CommandText = query
                Reader2 = Cmd2.ExecuteReader()
                If Reader2.HasRows Then
                    Reader2.Read()  'oude data ophalen

                    Dim id As Integer = CHint(Reader2("id"))
                    Dim numberOfPieces As Integer = CHint(Reader2("numberOfPieces"))
                    Dim selectedPackingConfiguration_piecesPerPackage As Integer = CHint(Reader2("selectedPackingConfiguration_piecesPerPackage"))
                    Dim selectedPackingConfiguration_package_vbnPackageCode As Integer = CHint(Reader2("selectedPackingConfiguration_package_vbnPackageCode"))
                    Dim pricePerPiece_currency As String = CHstr(Reader2("pricePerPiece_currency"))
                    Dim pricePerPiece_value As Double = CHdouble(Reader2("pricePerPiece_value"))

                    aantal_bestelling_txt.Text = Str(numberOfPieces)
                    aantal_aanpassing_txt.Text = Str(numberOfPieces)

                    prijs_bestelling_txt.Text = Format(pricePerPiece_value, "0.00") + " " + pricePerPiece_currency
                    prijs_aanpassing_txt.Text = Format(pricePerPiece_value, "0.00")

                    fustcode_bestelling_txt.Text = Str(selectedPackingConfiguration_package_vbnPackageCode)
                    fustcode_aanpassing_txt.Text = Str(selectedPackingConfiguration_package_vbnPackageCode)

                    apf_bestelling_txt.Text = Str(selectedPackingConfiguration_piecesPerPackage)
                    apf_aanpassing_txt.Text = Str(selectedPackingConfiguration_piecesPerPackage)

                    fust.Text = Str(numberOfPieces / selectedPackingConfiguration_piecesPerPackage)
                    aantalperfust2.Text = Str(selectedPackingConfiguration_piecesPerPackage)

                    OrderID_lbl.Text = OrderlineId
                End If
                Reader2.Close()

            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: (Floriday order correctie)" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try


    End Sub

    Private Sub annuleren_but_Click(sender As Object, e As EventArgs) Handles annuleren_but.Click
        Dim query As String = ""
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd2 As New OdbcCommand(query, Conn)

                Dim answer As DialogResult = MessageBox.Show("Weet u zeker dat deze order gewist moet worden", "Order wissen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then

                    query = "INSERT INTO floriday_salesorders_corrections(correctionId,correctionType," _
                           & "numberOfPieces,pricePerPiece_currency,pricePerPiece_value," _
                           & "package_vbnPackageCode,package_customPackageId,piecesPerPackage," _
                           & "reason,crc,crc_delete) VALUES (?,?,?,?,?,?,?,?,?,?,?)"
                    Cmd2.CommandText = query
                    Cmd2.Parameters.Clear()

                    Dim newid As String = System.Guid.NewGuid().ToString()

                    Cmd2.Parameters.AddWithValue("", newid)
                    Cmd2.Parameters.AddWithValue("", "CANCELLATION")
                    Cmd2.Parameters.AddWithValue("", -1)
                    Cmd2.Parameters.AddWithValue("", "")
                    Cmd2.Parameters.AddWithValue("", -1)
                    Cmd2.Parameters.AddWithValue("", -1)
                    Cmd2.Parameters.AddWithValue("", "")
                    Cmd2.Parameters.AddWithValue("", -1)
                    Cmd2.Parameters.AddWithValue("", Mid(reden_annuleren_txt.Text, 1, 500))
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.ExecuteNonQuery()
                End If

                Cmd2.CommandText = "SELECT LAST_INSERT_ID()"
                Dim id As Integer = Convert.ToInt32(Cmd2.ExecuteScalar())
                Dim salesorderid = OrderID_lbl.Text
                Form1.InsertTask(0, 99, "PUT", "sales-orders", salesorderid, "corrections", "", "", "", "", "", "", id)


            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: (Floriday order correctie)" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try



    End Sub

    Private Sub order_aanpassen_but_Click(sender As Object, e As EventArgs) Handles order_aanpassen_but.Click
        Dim query As String = ""
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd2 As New OdbcCommand(query, Conn)

                Dim answer As DialogResult = MessageBox.Show("Weet u zeker dat deze order aangepast moet worden", "Order aanpassen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then

                    Dim aantal As Integer = CInt(Val(aantal_aanpassing_txt.Text))
                    If aantal = 0 Then
                        MsgBox("Aantal moet bij aanpassen groter dan nul zijn.")
                        Exit Sub
                    End If

                    Dim prijs As Double = CVal(prijs_aanpassing_txt.Text)
                    If prijs <= 0 Then
                        MsgBox("Prijs moet bij aanpassen groter dan nul zijn.")
                        Exit Sub
                    End If

                    Dim fustcode As Integer = CInt(Val(fustcode_aanpassing_txt.Text))
                    If fustcode <= 0 Then
                        MsgBox("Fout bij fustcode.")
                        Exit Sub
                    End If

                    Dim apf As Integer = CInt(Val(apf_aanpassing_txt.Text))
                    If apf <= 0 Then
                        MsgBox("Fout bij aantal per fust")
                        Exit Sub
                    End If

                    query = "INSERT INTO floriday_salesorders_corrections(correctionId,correctionType," _
                           & "numberOfPieces,pricePerPiece_currency,pricePerPiece_value," _
                           & "package_vbnPackageCode,package_customPackageId,piecesPerPackage," _
                           & "reason,crc,crc_delete) VALUES (?,?,?,?,?,?,?,?,?,?,?)"
                    Cmd2.CommandText = query
                    Cmd2.Parameters.Clear()

                    Dim newid As String = System.Guid.NewGuid().ToString()

                    Cmd2.Parameters.AddWithValue("", newid)
                    Cmd2.Parameters.AddWithValue("", "MODIFICATION")
                    Cmd2.Parameters.AddWithValue("", aantal)
                    Cmd2.Parameters.AddWithValue("", "EUR")
                    Cmd2.Parameters.AddWithValue("", prijs)
                    Cmd2.Parameters.AddWithValue("", fustcode)
                    Cmd2.Parameters.AddWithValue("", "")
                    Cmd2.Parameters.AddWithValue("", apf)
                    Cmd2.Parameters.AddWithValue("", Mid(reden_aanpassing_txt.Text, 1, 500))
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.ExecuteNonQuery()

                    Cmd2.CommandText = "SELECT LAST_INSERT_ID()"
                    Dim id As Integer = Convert.ToInt32(Cmd2.ExecuteScalar())
                    Dim salesorderid = OrderID_lbl.Text
                    Form1.InsertTask(0, 99, "PUT", "sales-orders", salesorderid, "corrections", "", "", "", "", "", "", id)

                    'floriday_salesorders_boek wissen

                    query = "DELETE FROM floriday_salesorders_boek WHERE orderLineId='" + salesorderid + "'"
                    Cmd2.CommandText = query
                    Cmd2.ExecuteNonQuery()
                    'Dim wait5 As DateTime = DateAdd("s", 5, Now)
                    Form1.InsertTask(5, 99, "GET", "sales-orders", "sync")


                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: (Floriday order correctie)" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub apf_aanpassing_txt_TextChanged(sender As Object, e As EventArgs) Handles apf_aanpassing_txt.TextChanged
        Dim numberOfPieces As Integer = CInt(Val(aantal_aanpassing_txt.Text))
        Dim selectedPackingConfiguration_piecesPerPackage As Integer = CInt(Val(apf_aanpassing_txt.Text))
        If selectedPackingConfiguration_piecesPerPackage > 0 Then
            Dim orgineelaantalfusten As Integer = CInt(Val(fust.Text))
            aantal_aanpassing_txt.Text = orgineelaantalfusten * selectedPackingConfiguration_piecesPerPackage
            aantalperfust2.Text = Str(selectedPackingConfiguration_piecesPerPackage)
        End If
    End Sub

    Private Sub fust_TextChanged(sender As Object, e As EventArgs) Handles fust.TextChanged
        Dim aantalfust As Integer = CInt(Val(fust.Text))
        Dim numberOfPieces As Integer = CInt(Val(aantal_aanpassing_txt.Text))
        Dim selectedPackingConfiguration_piecesPerPackage As Integer = CInt(Val(apf_aanpassing_txt.Text))
        If selectedPackingConfiguration_piecesPerPackage > 0 Then
            aantal_aanpassing_txt.Text = Str(aantalfust * selectedPackingConfiguration_piecesPerPackage)
        End If
    End Sub

    Public Function CVal(ByVal DoubleString As String) As Double
        Dim result As Double = 0
        If InStr(DoubleString, ".") = 0 Then

            If Double.TryParse(DoubleString, Globalization.NumberStyles.Float, New Globalization.CultureInfo("nl-NL"), result) Then
                Return result
            Else
                MsgBox("Could not convert double")
                Return 0
            End If
        Else
            result = Val(DoubleString)
            Return result
        End If

    End Function

End Class