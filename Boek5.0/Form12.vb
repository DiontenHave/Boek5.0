Imports System.Data.Odbc

Public Class FloridayFilters


    Dim customerOrganizationId As String = ""
    Dim koper_ean As String = ""
    Dim tradeItemId As String = ""
    Public Sub init(orderlineId As String)
        Dim query As String = ""
        Dim soort_id As Integer = 0
        Dim fust_id As Integer = 0
        Dim hoes_id As Integer = 0
        Dim accessoire1 As Integer = 0
        Dim accessoire2 As Integer = 0
        Dim accessoire3 As Integer = 0
        Dim accessoire4 As Integer = 0

        Dim orgsoort_id As Integer = 0
        Dim orgfust_id As Integer = 0
        Dim orghoes_id As Integer = 0
        Dim orgaccessoire1 As Integer = 0
        Dim orgaccessoire2 As Integer = 0
        Dim orgaccessoire3 As Integer = 0
        Dim orgaccessoire4 As Integer = 0

        Dim opmerking As String = ""
        Dim kopernaam As String = "Koper onbekend"
        Dim tradeItemName As String = ""
        customerOrganizationId = ""
        tradeItemId = ""
        koper_ean = ""

        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd2 As New OdbcCommand(query, Conn)
                Dim Reader2 As OdbcDataReader

                query = "SELECT * FROM floriday_salesorders_boek WHERE orderLineId='" + orderlineId + "'"
                Cmd2.CommandText = query
                Reader2 = Cmd2.ExecuteReader()
                If Reader2.HasRows Then
                    Reader2.Read()  'oude data ophalen
                    soort_id = CHint(Reader2("boek_soortId"))
                    accessoire1 = CHint(Reader2("boek_accessoire1"))
                    accessoire2 = CHint(Reader2("boek_accessoire2"))
                    accessoire3 = CHint(Reader2("boek_accessoire3"))
                    accessoire4 = CHint(Reader2("boek_accessoire4"))
                    fust_id = CHint(Reader2("boek_fustid"))
                    hoes_id = CHint(Reader2("boek_hoesid"))

                    orgsoort_id = CHint(Reader2("org_soortId"))
                    orgaccessoire1 = CHint(Reader2("org_accessoire1"))
                    orgaccessoire2 = CHint(Reader2("org_accessoire2"))
                    orgaccessoire3 = CHint(Reader2("org_accessoire3"))
                    orgaccessoire4 = CHint(Reader2("org_accessoire4"))
                    orgfust_id = CHint(Reader2("org_fustid"))
                    orghoes_id = CHint(Reader2("org_hoesid"))

                    opmerking = CHstr(Reader2("boek_opmerking"))
                    customerOrganizationId = CHstr(Reader2("customerOrganizationId"))
                    tradeItemName = CHstr(Reader2("tradeItemName"))
                    tradeItemId = CHstr(Reader2("tradeItemId"))
                End If
                Reader2.Close()

                'kopernaam ophalen

                query = "SELECT * FROM floriday_organizations WHERE organizationId='" + customerOrganizationId + "'"
                Cmd2.CommandText = query
                Reader2 = Cmd2.ExecuteReader()
                If Reader2.HasRows Then
                    kopernaam = CHstr(Reader2("name"))
                    koper_ean = CHstr(Reader2("companyGln"))
                End If
                Reader2.Close()


                koper_txt.Text = kopernaam
                koper_chk.Checked = True

                tradeitem_txt.Text = tradeItemName
                tradeitem_chk.Checked = True

                LoadCombo(soort1_cmb, dtt_soortmix, False)
                LoadCombo(soort2_cmb, dtt_soortmix, False)
                soort1_cmb.SelectedValue = orgsoort_id
                soort2_cmb.SelectedValue = soort_id
                If orgsoort_id <> soort_id Then
                    soort_chk.Checked = True
                Else
                    soort_chk.Checked = False
                End If

                LoadCombo(fust1_cmb, dt_fust, False)
                LoadCombo(fust2_cmb, dt_fust, False)
                fust1_cmb.SelectedValue = orgfust_id
                fust2_cmb.SelectedValue = fust_id
                If orgfust_id <> fust_id Then
                    fust_chk.Checked = True
                Else
                    fust_chk.Checked = False
                End If

                LoadCombo(hoes1_cmb, dt_accessoire, False)
                LoadCombo(hoes2_cmb, dt_accessoire, False)
                hoes1_cmb.SelectedValue = orghoes_id
                hoes2_cmb.SelectedValue = hoes_id
                If orghoes_id <> hoes_id Then
                    hoes_chk.Checked = True
                Else
                    hoes_chk.Checked = False
                End If

                LoadCombo(acce1A_cmb, dt_accessoire, False)
                LoadCombo(acce2A_cmb, dt_accessoire, False)
                LoadCombo(acce3A_cmb, dt_accessoire, False)
                LoadCombo(acce4A_cmb, dt_accessoire, False)
                LoadCombo(acce1B_cmb, dt_accessoire, False)
                LoadCombo(acce2B_cmb, dt_accessoire, False)
                LoadCombo(acce3B_cmb, dt_accessoire, False)
                LoadCombo(acce4B_cmb, dt_accessoire, False)

                acce1A_cmb.SelectedValue = orgaccessoire1
                acce2A_cmb.SelectedValue = orgaccessoire2
                acce3A_cmb.SelectedValue = orgaccessoire3
                acce4A_cmb.SelectedValue = orgaccessoire4

                acce1B_cmb.SelectedValue = accessoire1
                acce2B_cmb.SelectedValue = accessoire2
                acce3B_cmb.SelectedValue = accessoire3
                acce4B_cmb.SelectedValue = accessoire4

                If accessoire1 <> orgaccessoire1 Then
                    accessoire1_chk.Checked = True
                Else
                    accessoire1_chk.Checked = False
                End If
                If accessoire2 <> orgaccessoire2 Then
                    accessoire2_chk.Checked = True
                Else
                    accessoire2_chk.Checked = False
                End If
                If accessoire3 <> orgaccessoire3 Then
                    accessoire3_chk.Checked = True
                Else
                    accessoire3_chk.Checked = False
                End If
                If accessoire4 <> orgaccessoire4 Then
                    accessoire4_chk.Checked = True
                Else
                    accessoire4_chk.Checked = False
                End If

                opmerking_txt.Text = opmerking

            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: floriday filters instellen" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try


    End Sub

    Private Sub opslaan_but_Click(sender As Object, e As EventArgs) Handles opslaan_but.Click
        Dim query As String = ""
        Try
            Using Conn As New OdbcConnection(ConnString)
                Conn.Open()
                Dim Cmd2 As New OdbcCommand(query, Conn)

                query = "INSERT INTO floriday_salesorders_filters(customer_check, customerOrganizationId, customerName," _
                    & "customerEAN, tradeItemCheck, tradeItemName, tradeItemId, opmerkingCheck, Opmerking, soortCheck, soortOrg, soortNew," _
                    & "fustCheck, fustOrg, fustNew, hoesCheck, hoesOrg, hoesNew, accessoire1Check, accessoire1Org," _
                    & "accessoire1New, accessoire2Check, accessoire2Org, accessoire2New, accessoire3Check, accessoire3Org," _
                    & "accessoire3New, accessoire4Check, accessoire4Org, accessoire4New)" _
                    & " VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Cmd2.CommandText = query
                Cmd2.Parameters.Clear()
                Cmd2.Parameters.AddWithValue("", koper_chk.Checked)
                If koper_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", customerOrganizationId)
                    Cmd2.Parameters.AddWithValue("", koper_txt.Text)
                    Cmd2.Parameters.AddWithValue("", koper_ean)
                Else
                    Cmd2.Parameters.AddWithValue("", "")
                    Cmd2.Parameters.AddWithValue("", "Alle kopers")
                    Cmd2.Parameters.AddWithValue("", "")
                End If

                Cmd2.Parameters.AddWithValue("", tradeitem_chk.Checked)
                If tradeitem_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", tradeitem_txt.Text)
                    Cmd2.Parameters.AddWithValue("", tradeItemId)
                Else
                    Cmd2.Parameters.AddWithValue("", "Alle soorten")
                    Cmd2.Parameters.AddWithValue("", "")
                End If

                Cmd2.Parameters.AddWithValue("", opmerking_chk.Checked)
                Cmd2.Parameters.AddWithValue("", opmerking_txt.Text)
                Cmd2.Parameters.AddWithValue("", soort_chk.Checked)
                If soort_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(soort1_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(soort2_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", fust_chk.Checked)
                If fust_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(fust1_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(fust2_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", hoes_chk.Checked)
                If hoes_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(hoes1_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(hoes2_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", accessoire1_chk.Checked)
                If accessoire1_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce1A_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce1B_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", accessoire2_chk.Checked)
                If accessoire2_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce2A_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce2B_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", accessoire3_chk.Checked)
                If accessoire3_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce3A_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce3B_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.Parameters.AddWithValue("", accessoire4_chk.Checked)
                If accessoire4_chk.Checked = True Then
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce4A_cmb))
                    Cmd2.Parameters.AddWithValue("", GetCmbValue(acce4B_cmb))
                Else
                    Cmd2.Parameters.AddWithValue("", 0)
                    Cmd2.Parameters.AddWithValue("", 0)
                End If

                Cmd2.ExecuteNonQuery()
                MsgBox("Filter opgeslagen")
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Database fout: floriday filters opslaan" + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Form1.FiltersToepassen()

    End Sub

    Private Function GetCmbValue(xcombo As ComboBox) As Integer
        Dim returnvalue As Integer = 0
        Try
            returnvalue = xcombo.SelectedValue
        Catch ex As Exception
            returnvalue = 0
        End Try
        Return returnvalue
    End Function

    Private Sub LoadCombo(ByVal Combobox1 As ComboBox, ByVal datasource1 As DataTable, ByVal autocomplete As Boolean, Optional ByVal maxdropdown As Integer = 12)
        If autocomplete = True Then
            Combobox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Combobox1.AutoCompleteSource = AutoCompleteSource.CustomSource
            Combobox1.DisplayMember = "desc"
            Combobox1.ValueMember = "ID"
            Combobox1.DropDownStyle = ComboBoxStyle.DropDown
            Combobox1.MaxDropDownItems = maxdropdown
            Combobox1.DataSource = New DataView(datasource1)
            Combobox1.SelectedValue = "0000000000000"
        Else
            Combobox1.DisplayMember = "desc"
            Combobox1.ValueMember = "ID"
            Combobox1.DropDownStyle = ComboBoxStyle.DropDownList
            Combobox1.MaxDropDownItems = maxdropdown
            Combobox1.DataSource = New DataView(datasource1)
        End If
    End Sub


End Class