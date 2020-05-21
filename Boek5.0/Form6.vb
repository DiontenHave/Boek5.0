Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class OpmerkingVervoerMail

    Private Sub OpmerkingVervoerMail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kopers_mail_opmerking = "*MAGIC*" Then kopers_mail_opmerking = ""
    End Sub

    Private Sub OpmerkingVervoerMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Setup(ByVal koper_ean As String)
        koper_ean_lbl.Text = koper_ean 'save ean
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                Dim CmdString2 As String = "SELECT * FROM klanten where ean = '" + Str(koper_ean) + "'"
                Dim Reader2 As OdbcDataReader
                Dim Cmd2 As New OdbcCommand(CmdString2, Conn)
                Reader2 = Cmd2.ExecuteReader()
                If Reader2.HasRows Then
                    Reader2.Read()
                    opmerking1_txt.Text = CHstr(Reader2("transport_opmerking1"))
                    opmerking2_txt.Text = CHstr(Reader2("transport_opmerking2"))
                    opmerking3_txt.Text = CHstr(Reader2("transport_opmerking3"))
                    opmerking4_txt.Text = CHstr(Reader2("transport_opmerking4"))
                    opmerking5_txt.Text = CHstr(Reader2("transport_opmerking5"))
                End If
                Reader2.Close()


            End Using
        Catch ex As Exception
            MessageBox.Show("Form6 : MailOpmerking fout:" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Select1_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select1_but.Click
        kopers_mail_opmerking = opmerking1_txt.Text
        Me.Close()
    End Sub

    Private Sub Select2_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select2_but.Click
        kopers_mail_opmerking = opmerking2_txt.Text
        Me.Close()
    End Sub

    Private Sub Select3_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select3_but.Click
        kopers_mail_opmerking = opmerking3_txt.Text
        Me.Close()
    End Sub

    Private Sub Select4_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select4_but.Click
        kopers_mail_opmerking = opmerking4_txt.Text
        Me.Close()
    End Sub

    Private Sub Select5_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select5_but.Click
        kopers_mail_opmerking = opmerking5_txt.Text
        Me.Close()
    End Sub

    Private Sub Opslaan1_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaan1_but.Click
        Dim CmdString As String = "SELECT * FROM klanten WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "UPDATE klanten SET transport_opmerking1=? WHERE ean = '" + Trim(koper_ean_lbl.Text) + "'"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", opmerking1_txt.Text)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (save koper transportopmerking)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Opslaan2_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaan2_but.Click
        Dim CmdString As String = "SELECT * FROM klanten WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "UPDATE klanten SET transport_opmerking2=? WHERE ean = '" + Trim(koper_ean_lbl.Text) + "'"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", opmerking2_txt.Text)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (save koper transportopmerking)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Opslaan3_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaan3_but.Click
        Dim CmdString As String = "SELECT * FROM klanten WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "UPDATE klanten SET transport_opmerking3=? WHERE ean = '" + Trim(koper_ean_lbl.Text) + "'"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", opmerking3_txt.Text)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (save koper transportopmerking)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Opslaan4_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaan4_but.Click
        Dim CmdString As String = "SELECT * FROM klanten WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "UPDATE klanten SET transport_opmerking4=? WHERE ean = '" + Trim(koper_ean_lbl.Text) + "'"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", opmerking4_txt.Text)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (save koper transportopmerking)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Opslaan5_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opslaan5_but.Click
        Dim CmdString As String = "SELECT * FROM klanten WHERE 1=0"
        Try
            'Open Connection
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()

                'Execute Query
                Dim Cmd As New OdbcCommand(CmdString, Conn)
                With Cmd

                    .CommandText = "UPDATE klanten SET transport_opmerking5=? WHERE ean = '" + Trim(koper_ean_lbl.Text) + "'"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("", opmerking5_txt.Text)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Database fout: (save koper transportopmerking)" + ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class