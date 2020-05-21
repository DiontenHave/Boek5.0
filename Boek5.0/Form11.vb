Imports System.Data
Imports System.Data.Odbc

Public Class FormConnectionLost

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'test SQL 
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand("SELECT * FROM veiling", Conn)
                Dim Reader As OdbcDataReader
                Reader = Cmd.ExecuteReader()
                If Reader.HasRows Then
                    SQLRUN2 = True
                    Me.Close()
                End If

            End Using
        Catch ex As Exception
            MsgBox("Connection failed")
            SQLRUN = False
        End Try
    End Sub
End Class