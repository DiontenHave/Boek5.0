<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.components = New System.ComponentModel.Container()
        Me.karren_flx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.KarAanpassen_but = New System.Windows.Forms.Button()
        Me.EABAnnuleren_but = New System.Windows.Forms.Button()
        Me.TaskTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusRapport_but = New System.Windows.Forms.Button()
        Me.HerstelFoutStatus_but = New System.Windows.Forms.Button()
        Me.KarCorrigeren_but = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.View_txt = New System.Windows.Forms.TextBox()
        CType(Me.karren_flx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'karren_flx
        '
        Me.karren_flx.ColumnInfo = "10,0,0,0,0,-1,Columns:"
        Me.karren_flx.Location = New System.Drawing.Point(12, 12)
        Me.karren_flx.Name = "karren_flx"
        Me.karren_flx.Rows.Count = 1
        Me.karren_flx.Size = New System.Drawing.Size(1395, 200)
        Me.karren_flx.TabIndex = 0
        '
        'KarAanpassen_but
        '
        Me.KarAanpassen_but.Location = New System.Drawing.Point(13, 302)
        Me.KarAanpassen_but.Name = "KarAanpassen_but"
        Me.KarAanpassen_but.Size = New System.Drawing.Size(387, 50)
        Me.KarAanpassen_but.TabIndex = 2
        Me.KarAanpassen_but.Text = "Karren en lagen aanpassen en brief opnieuw printen"
        Me.KarAanpassen_but.UseVisualStyleBackColor = True
        '
        'EABAnnuleren_but
        '
        Me.EABAnnuleren_but.Location = New System.Drawing.Point(406, 302)
        Me.EABAnnuleren_but.Name = "EABAnnuleren_but"
        Me.EABAnnuleren_but.Size = New System.Drawing.Size(387, 50)
        Me.EABAnnuleren_but.TabIndex = 3
        Me.EABAnnuleren_but.Text = "Floriday brieven ongedaan maken (EAB annuleren)"
        Me.EABAnnuleren_but.UseVisualStyleBackColor = True
        '
        'TaskTimer
        '
        Me.TaskTimer.Interval = 2000
        '
        'StatusRapport_but
        '
        Me.StatusRapport_but.Location = New System.Drawing.Point(13, 246)
        Me.StatusRapport_but.Name = "StatusRapport_but"
        Me.StatusRapport_but.Size = New System.Drawing.Size(387, 50)
        Me.StatusRapport_but.TabIndex = 5
        Me.StatusRapport_but.Text = "Floriday status rapport"
        Me.StatusRapport_but.UseVisualStyleBackColor = True
        '
        'HerstelFoutStatus_but
        '
        Me.HerstelFoutStatus_but.Location = New System.Drawing.Point(406, 246)
        Me.HerstelFoutStatus_but.Name = "HerstelFoutStatus_but"
        Me.HerstelFoutStatus_but.Size = New System.Drawing.Size(387, 50)
        Me.HerstelFoutStatus_but.TabIndex = 6
        Me.HerstelFoutStatus_but.Text = "Floriday herstel fout status"
        Me.HerstelFoutStatus_but.UseVisualStyleBackColor = True
        '
        'KarCorrigeren_but
        '
        Me.KarCorrigeren_but.Location = New System.Drawing.Point(799, 302)
        Me.KarCorrigeren_but.Name = "KarCorrigeren_but"
        Me.KarCorrigeren_but.Size = New System.Drawing.Size(387, 50)
        Me.KarCorrigeren_but.TabIndex = 8
        Me.KarCorrigeren_but.Text = "Karren en lagen corrigeren (kar is al weg)"
        Me.KarCorrigeren_but.UseVisualStyleBackColor = True
        Me.KarCorrigeren_but.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(799, 246)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(387, 50)
        Me.ProgressBar1.TabIndex = 9
        '
        'View_txt
        '
        Me.View_txt.Location = New System.Drawing.Point(13, 375)
        Me.View_txt.Multiline = True
        Me.View_txt.Name = "View_txt"
        Me.View_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.View_txt.Size = New System.Drawing.Size(1394, 293)
        Me.View_txt.TabIndex = 10
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 680)
        Me.Controls.Add(Me.View_txt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.KarCorrigeren_but)
        Me.Controls.Add(Me.HerstelFoutStatus_but)
        Me.Controls.Add(Me.StatusRapport_but)
        Me.Controls.Add(Me.EABAnnuleren_but)
        Me.Controls.Add(Me.KarAanpassen_but)
        Me.Controls.Add(Me.karren_flx)
        Me.Name = "Form16"
        Me.Text = "Floriday Aanpassing"
        CType(Me.karren_flx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents karren_flx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents KarAanpassen_but As Button
    Friend WithEvents EABAnnuleren_but As Button
    Friend WithEvents TaskTimer As Timer
    Friend WithEvents StatusRapport_but As Button
    Friend WithEvents HerstelFoutStatus_but As Button
    Friend WithEvents KarCorrigeren_but As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents View_txt As TextBox
End Class
