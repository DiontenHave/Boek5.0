<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.printercombo = New System.Windows.Forms.ComboBox()
        Me.Labelnr_invoer_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintLabels_but = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'printercombo
        '
        Me.printercombo.FormattingEnabled = True
        Me.printercombo.Items.AddRange(New Object() {"1 : Werkstation 1", "2 : Werkstation 2", "3 : Werkstation 3", "4 : Werkstation 4", "5 : Werkstation 5", "6 : Werkstation 6", "7 : Werkvoorbereiding", "8 : Kantoor kast"})
        Me.printercombo.Location = New System.Drawing.Point(72, 34)
        Me.printercombo.Name = "printercombo"
        Me.printercombo.Size = New System.Drawing.Size(199, 21)
        Me.printercombo.TabIndex = 0
        Me.printercombo.Text = "7 : Werkvoorbereiding"
        '
        'Labelnr_invoer_txt
        '
        Me.Labelnr_invoer_txt.Location = New System.Drawing.Point(71, 8)
        Me.Labelnr_invoer_txt.Name = "Labelnr_invoer_txt"
        Me.Labelnr_invoer_txt.Size = New System.Drawing.Size(199, 20)
        Me.Labelnr_invoer_txt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Printer"
        '
        'PrintLabels_but
        '
        Me.PrintLabels_but.Location = New System.Drawing.Point(60, 82)
        Me.PrintLabels_but.Name = "PrintLabels_but"
        Me.PrintLabels_but.Size = New System.Drawing.Size(163, 31)
        Me.PrintLabels_but.TabIndex = 4
        Me.PrintLabels_but.Text = "Print"
        Me.PrintLabels_but.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 125)
        Me.Controls.Add(Me.PrintLabels_but)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labelnr_invoer_txt)
        Me.Controls.Add(Me.printercombo)
        Me.Name = "Form9"
        Me.Text = "Print labels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents printercombo As System.Windows.Forms.ComboBox
    Friend WithEvents Labelnr_invoer_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintLabels_but As System.Windows.Forms.Button
End Class
