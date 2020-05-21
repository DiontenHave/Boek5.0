<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_invoer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Code_deel1_txt = New System.Windows.Forms.TextBox()
        Me.Code_deel2_txt = New System.Windows.Forms.TextBox()
        Me.Code_aantal_txt = New System.Windows.Forms.TextBox()
        Me.Code_toevoegen_but = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.code_code_lbl = New System.Windows.Forms.Label()
        Me.Code_aantal_lbl = New System.Windows.Forms.Label()
        Me.Code_aantal2_txt = New System.Windows.Forms.TextBox()
        Me.Code_lang_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Code_deel1_txt
        '
        Me.Code_deel1_txt.Location = New System.Drawing.Point(59, 31)
        Me.Code_deel1_txt.Name = "Code_deel1_txt"
        Me.Code_deel1_txt.Size = New System.Drawing.Size(37, 20)
        Me.Code_deel1_txt.TabIndex = 0
        '
        'Code_deel2_txt
        '
        Me.Code_deel2_txt.Location = New System.Drawing.Point(118, 31)
        Me.Code_deel2_txt.Name = "Code_deel2_txt"
        Me.Code_deel2_txt.Size = New System.Drawing.Size(37, 20)
        Me.Code_deel2_txt.TabIndex = 1
        '
        'Code_aantal_txt
        '
        Me.Code_aantal_txt.Location = New System.Drawing.Point(12, 31)
        Me.Code_aantal_txt.Name = "Code_aantal_txt"
        Me.Code_aantal_txt.Size = New System.Drawing.Size(28, 20)
        Me.Code_aantal_txt.TabIndex = 2
        '
        'Code_toevoegen_but
        '
        Me.Code_toevoegen_but.Location = New System.Drawing.Point(171, 22)
        Me.Code_toevoegen_but.Name = "Code_toevoegen_but"
        Me.Code_toevoegen_but.Size = New System.Drawing.Size(75, 55)
        Me.Code_toevoegen_but.TabIndex = 9
        Me.Code_toevoegen_but.Text = "Toevoegen"
        Me.Code_toevoegen_but.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "-"
        '
        'code_code_lbl
        '
        Me.code_code_lbl.AutoSize = True
        Me.code_code_lbl.Location = New System.Drawing.Point(56, 10)
        Me.code_code_lbl.Name = "code_code_lbl"
        Me.code_code_lbl.Size = New System.Drawing.Size(32, 13)
        Me.code_code_lbl.TabIndex = 5
        Me.code_code_lbl.Text = "Code"
        '
        'Code_aantal_lbl
        '
        Me.Code_aantal_lbl.AutoSize = True
        Me.Code_aantal_lbl.Location = New System.Drawing.Point(9, 10)
        Me.Code_aantal_lbl.Name = "Code_aantal_lbl"
        Me.Code_aantal_lbl.Size = New System.Drawing.Size(37, 13)
        Me.Code_aantal_lbl.TabIndex = 6
        Me.Code_aantal_lbl.Text = "Aantal"
        '
        'Code_aantal2_txt
        '
        Me.Code_aantal2_txt.Location = New System.Drawing.Point(12, 57)
        Me.Code_aantal2_txt.Name = "Code_aantal2_txt"
        Me.Code_aantal2_txt.Size = New System.Drawing.Size(28, 20)
        Me.Code_aantal2_txt.TabIndex = 8
        '
        'Code_lang_txt
        '
        Me.Code_lang_txt.Location = New System.Drawing.Point(59, 57)
        Me.Code_lang_txt.Name = "Code_lang_txt"
        Me.Code_lang_txt.Size = New System.Drawing.Size(96, 20)
        Me.Code_lang_txt.TabIndex = 7
        '
        'Code_invoer
        '
        Me.AcceptButton = Me.Code_toevoegen_but
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 102)
        Me.Controls.Add(Me.Code_aantal2_txt)
        Me.Controls.Add(Me.Code_lang_txt)
        Me.Controls.Add(Me.Code_aantal_lbl)
        Me.Controls.Add(Me.code_code_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Code_toevoegen_but)
        Me.Controls.Add(Me.Code_aantal_txt)
        Me.Controls.Add(Me.Code_deel2_txt)
        Me.Controls.Add(Me.Code_deel1_txt)
        Me.Name = "Code_invoer"
        Me.Text = "Code invoer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Code_deel1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Code_deel2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Code_aantal_txt As System.Windows.Forms.TextBox
    Friend WithEvents Code_toevoegen_but As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents code_code_lbl As System.Windows.Forms.Label
    Friend WithEvents Code_aantal_lbl As System.Windows.Forms.Label
    Friend WithEvents Code_aantal2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Code_lang_txt As System.Windows.Forms.TextBox


    Private Sub Code_deel1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code_deel1_txt.TextChanged
        Dim lengte As Integer = Len(Code_deel1_txt.Text)
        If lengte = 4 Then
            Code_deel2_txt.Focus()
        End If
    End Sub

    Private Sub Code_deel2_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code_deel2_txt.TextChanged
        Dim lengte As Integer = Len(Code_deel2_txt.Text)
        If lengte = 1 And Code_deel2_txt.Text = "-" Then  'cut out the - 
            Code_deel2_txt.Text = ""
        End If
        If lengte = 4 Then
            Code_aantal_txt.Focus()
        End If

        If (Code_deel1_txt.Text = "PC11" Or Code_deel1_txt.Text = "pc11") And lengte = 2 Then
            Code_aantal_txt.Focus()
        End If

    End Sub

    Private Sub Code_toevoegen_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code_toevoegen_but.Click
        'checks
        Dim lengte1 As Integer = Len(Code_deel1_txt.Text)
        Dim lengte2 As Integer = Len(Code_deel2_txt.Text)
        Dim aantal As Integer = Val(Code_aantal_txt.Text)
        Dim aantal2 As Integer = Val(Code_aantal2_txt.Text)
        Dim lengtelang As Integer = Len(Code_lang_txt.Text)

        If lengte1 = 4 And lengte2 = 4 And aantal > 0 Then
            Dim soort_code As String = Mid(Code_deel1_txt.Text, 2, 3)
            Dim accessoire1_code As String = Mid(Code_deel2_txt.Text, 1, 2)
            Dim accessoire2_code As String = Mid(Code_deel2_txt.Text, 3, 2)
            Form1.Load_CodeLine(soort_code, accessoire1_code, accessoire2_code, aantal)
            Code_deel1_txt.Text = ""
            Code_deel2_txt.Text = ""
            Code_aantal_txt.Text = ""
            Code_deel1_txt.Focus()
        End If

        If lengtelang > 0 And aantal2 > 0 Then
            Form1.Load_CodeLine2(Code_lang_txt.Text, aantal2)
            Code_lang_txt.Text = ""
            Code_aantal2_txt.Text = ""
            Code_lang_txt.Focus()
        End If

    End Sub


    Private Sub Code_lang_txt_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Code_lang_txt.PreviewKeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.IsInputKey = True
        End Select
    End Sub

    Private Sub Code_lang_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code_lang_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Code_aantal2_txt.Focus()
        End If
    End Sub

    Private Sub Code_aantal2_txt_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Code_aantal2_txt.PreviewKeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.IsInputKey = True
        End Select
    End Sub

    Private Sub Code_aantal2_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code_aantal2_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Code_toevoegen_but_Click(sender, e)
            Code_aantal2_txt.Text = ""
            Code_lang_txt.Text = ""
            Code_lang_txt.Focus()
        End If
    End Sub



End Class
