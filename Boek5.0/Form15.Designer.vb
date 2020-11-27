<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form15
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.foto_PictureBox = New System.Windows.Forms.PictureBox()
        Me.SelectImage_but = New System.Windows.Forms.Button()
        Me.Ok_but = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Status_lbl = New System.Windows.Forms.Label()
        Me.Foto_Filelist_flx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tradeitem_lbl = New System.Windows.Forms.Label()
        Me.selectedimage_lbl = New System.Windows.Forms.Label()
        Me.Verwijderen_but = New System.Windows.Forms.Button()
        CType(Me.foto_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto_Filelist_flx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'foto_PictureBox
        '
        Me.foto_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foto_PictureBox.Location = New System.Drawing.Point(12, 25)
        Me.foto_PictureBox.Name = "foto_PictureBox"
        Me.foto_PictureBox.Size = New System.Drawing.Size(400, 400)
        Me.foto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.foto_PictureBox.TabIndex = 0
        Me.foto_PictureBox.TabStop = False
        '
        'SelectImage_but
        '
        Me.SelectImage_but.Location = New System.Drawing.Point(12, 458)
        Me.SelectImage_but.Name = "SelectImage_but"
        Me.SelectImage_but.Size = New System.Drawing.Size(400, 35)
        Me.SelectImage_but.TabIndex = 2
        Me.SelectImage_but.Text = "Select new image"
        Me.SelectImage_but.UseVisualStyleBackColor = True
        '
        'Ok_but
        '
        Me.Ok_but.Location = New System.Drawing.Point(12, 499)
        Me.Ok_but.Name = "Ok_but"
        Me.Ok_but.Size = New System.Drawing.Size(400, 35)
        Me.Ok_but.TabIndex = 3
        Me.Ok_but.Text = "OK"
        Me.Ok_but.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Status_lbl
        '
        Me.Status_lbl.AutoSize = True
        Me.Status_lbl.Location = New System.Drawing.Point(9, 428)
        Me.Status_lbl.Name = "Status_lbl"
        Me.Status_lbl.Size = New System.Drawing.Size(37, 13)
        Me.Status_lbl.TabIndex = 4
        Me.Status_lbl.Text = "Status"
        '
        'Foto_Filelist_flx
        '
        Me.Foto_Filelist_flx.ColumnInfo = resources.GetString("Foto_Filelist_flx.ColumnInfo")
        Me.Foto_Filelist_flx.Location = New System.Drawing.Point(418, 25)
        Me.Foto_Filelist_flx.Name = "Foto_Filelist_flx"
        Me.Foto_Filelist_flx.Rows.Count = 1
        Me.Foto_Filelist_flx.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.Foto_Filelist_flx.Size = New System.Drawing.Size(560, 400)
        Me.Foto_Filelist_flx.TabIndex = 5
        '
        'tradeitem_lbl
        '
        Me.tradeitem_lbl.AutoSize = True
        Me.tradeitem_lbl.Location = New System.Drawing.Point(12, 9)
        Me.tradeitem_lbl.Name = "tradeitem_lbl"
        Me.tradeitem_lbl.Size = New System.Drawing.Size(57, 13)
        Me.tradeitem_lbl.TabIndex = 6
        Me.tradeitem_lbl.Text = "Tradeitem:"
        '
        'selectedimage_lbl
        '
        Me.selectedimage_lbl.AutoSize = True
        Me.selectedimage_lbl.Location = New System.Drawing.Point(415, 428)
        Me.selectedimage_lbl.Name = "selectedimage_lbl"
        Me.selectedimage_lbl.Size = New System.Drawing.Size(86, 13)
        Me.selectedimage_lbl.TabIndex = 7
        Me.selectedimage_lbl.Text = "Selected image :"
        '
        'Verwijderen_but
        '
        Me.Verwijderen_but.Location = New System.Drawing.Point(840, 446)
        Me.Verwijderen_but.Name = "Verwijderen_but"
        Me.Verwijderen_but.Size = New System.Drawing.Size(138, 33)
        Me.Verwijderen_but.TabIndex = 8
        Me.Verwijderen_but.Text = "Selectie verwijderen"
        Me.Verwijderen_but.UseVisualStyleBackColor = True
        '
        'Form15
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 541)
        Me.Controls.Add(Me.Verwijderen_but)
        Me.Controls.Add(Me.selectedimage_lbl)
        Me.Controls.Add(Me.tradeitem_lbl)
        Me.Controls.Add(Me.Foto_Filelist_flx)
        Me.Controls.Add(Me.Status_lbl)
        Me.Controls.Add(Me.Ok_but)
        Me.Controls.Add(Me.SelectImage_but)
        Me.Controls.Add(Me.foto_PictureBox)
        Me.Name = "Form15"
        Me.Text = "Foto's"
        CType(Me.foto_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto_Filelist_flx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents foto_PictureBox As PictureBox
    Friend WithEvents SelectImage_but As Button
    Friend WithEvents Ok_but As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Status_lbl As Label
    Friend WithEvents Foto_Filelist_flx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tradeitem_lbl As Label
    Friend WithEvents selectedimage_lbl As Label
    Friend WithEvents Verwijderen_but As Button
End Class
