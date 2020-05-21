Imports System.Data.Odbc

Public Class Form9

    Private Sub PrintLabels_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintLabels_but.Click

        Dim printer As String = printercombo.Text
        Dim printersplit() As String = printer.Split
        Dim selected_printer As String = printersplit(0)
        Dim labelnummer As Integer = Val(Labelnr_invoer_txt.Text)
        If labelnummer > 0 And Val(selected_printer) > 0 And Val(selected_printer) < 9 Then
            Try
                Using Conn As New OdbcConnection(ConnString)
                    Conn.Open()
                    Dim CmdString8 As String = "UPDATE label_info SET printer = " + selected_printer + ", status = 5 WHERE id = " + Str(labelnummer)
                    Dim Cmd8 As New OdbcCommand(CmdString8, Conn)
                    Cmd8.ExecuteNonQuery()
                    MsgBox("Printing...")
                End Using
            Catch ex As Exception
            End Try
        Else
            MsgBox("Fout bij printopdracht")

        End If

    End Sub
End Class