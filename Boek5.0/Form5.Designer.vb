<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail_vervoerder_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mail_vervoerder_form))
        Me.Vervoer_flexgrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Vervoer_flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Toevoegen_but = New System.Windows.Forms.Button()
        Me.Verwijderen_but = New System.Windows.Forms.Button()
        Me.Versturen_but = New System.Windows.Forms.Button()
        Me.Ophalen1_chk = New System.Windows.Forms.CheckBox()
        Me.Opmerking_cmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ophalen2_chk = New System.Windows.Forms.CheckBox()
        CType(Me.Vervoer_flexgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vervoer_flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vervoer_flexgrid
        '
        Me.Vervoer_flexgrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Vervoer_flexgrid.ColumnInfo = resources.GetString("Vervoer_flexgrid.ColumnInfo")
        Me.Vervoer_flexgrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Vervoer_flexgrid.Location = New System.Drawing.Point(0, 0)
        Me.Vervoer_flexgrid.Name = "Vervoer_flexgrid"
        Me.Vervoer_flexgrid.Rows.Count = 1
        Me.Vervoer_flexgrid.Rows.DefaultSize = 17
        Me.Vervoer_flexgrid.Size = New System.Drawing.Size(1018, 454)
        Me.Vervoer_flexgrid.TabIndex = 0
        '
        'Vervoer_flex
        '
        Me.Vervoer_flex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Vervoer_flex.ColumnInfo = resources.GetString("Vervoer_flex.ColumnInfo")
        Me.Vervoer_flex.Dock = System.Windows.Forms.DockStyle.Top
        Me.Vervoer_flex.Location = New System.Drawing.Point(0, 0)
        Me.Vervoer_flex.Name = "Vervoer_flex"
        Me.Vervoer_flex.Rows.DefaultSize = 17
        Me.Vervoer_flex.Size = New System.Drawing.Size(749, 497)
        Me.Vervoer_flex.TabIndex = 0
        '
        'Toevoegen_but
        '
        Me.Toevoegen_but.Location = New System.Drawing.Point(777, 460)
        Me.Toevoegen_but.Name = "Toevoegen_but"
        Me.Toevoegen_but.Size = New System.Drawing.Size(132, 29)
        Me.Toevoegen_but.TabIndex = 1
        Me.Toevoegen_but.Text = "Regel Toevoegen"
        Me.Toevoegen_but.UseVisualStyleBackColor = True
        '
        'Verwijderen_but
        '
        Me.Verwijderen_but.Location = New System.Drawing.Point(915, 460)
        Me.Verwijderen_but.Name = "Verwijderen_but"
        Me.Verwijderen_but.Size = New System.Drawing.Size(103, 29)
        Me.Verwijderen_but.TabIndex = 2
        Me.Verwijderen_but.Text = "Regel Verwijderen"
        Me.Verwijderen_but.UseVisualStyleBackColor = True
        '
        'Versturen_but
        '
        Me.Versturen_but.Location = New System.Drawing.Point(376, 499)
        Me.Versturen_but.Name = "Versturen_but"
        Me.Versturen_but.Size = New System.Drawing.Size(267, 42)
        Me.Versturen_but.TabIndex = 3
        Me.Versturen_but.Text = "Versturen"
        Me.Versturen_but.UseVisualStyleBackColor = True
        '
        'Ophalen1_chk
        '
        Me.Ophalen1_chk.AutoSize = True
        Me.Ophalen1_chk.Location = New System.Drawing.Point(660, 499)
        Me.Ophalen1_chk.Name = "Ophalen1_chk"
        Me.Ophalen1_chk.Size = New System.Drawing.Size(87, 17)
        Me.Ophalen1_chk.TabIndex = 4
        Me.Ophalen1_chk.Text = "Ophalen op -"
        Me.Ophalen1_chk.UseVisualStyleBackColor = True
        '
        'Opmerking_cmb
        '
        Me.Opmerking_cmb.FormattingEnabled = True
        Me.Opmerking_cmb.Items.AddRange(New Object() {"Staat vrijdag om 14:00 klaar", "Zaterdag ophalen vanaf 8:15", "Zondag ophalen"})
        Me.Opmerking_cmb.Location = New System.Drawing.Point(104, 454)
        Me.Opmerking_cmb.Name = "Opmerking_cmb"
        Me.Opmerking_cmb.Size = New System.Drawing.Size(432, 21)
        Me.Opmerking_cmb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Extra opmerking:"
        '
        'Ophalen2_chk
        '
        Me.Ophalen2_chk.AutoSize = True
        Me.Ophalen2_chk.Location = New System.Drawing.Point(660, 522)
        Me.Ophalen2_chk.Name = "Ophalen2_chk"
        Me.Ophalen2_chk.Size = New System.Drawing.Size(87, 17)
        Me.Ophalen2_chk.TabIndex = 8
        Me.Ophalen2_chk.Text = "Ophalen op -"
        Me.Ophalen2_chk.UseVisualStyleBackColor = True
        '
        'Mail_vervoerder_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 554)
        Me.Controls.Add(Me.Ophalen2_chk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Opmerking_cmb)
        Me.Controls.Add(Me.Ophalen1_chk)
        Me.Controls.Add(Me.Versturen_but)
        Me.Controls.Add(Me.Verwijderen_but)
        Me.Controls.Add(Me.Toevoegen_but)
        Me.Controls.Add(Me.Vervoer_flexgrid)
        Me.Name = "Mail_vervoerder_form"
        Me.Text = "Vervoer Overzicht"
        CType(Me.Vervoer_flexgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vervoer_flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vervoer_flexgrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Vervoer_flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Toevoegen_but As System.Windows.Forms.Button
    Friend WithEvents Verwijderen_but As System.Windows.Forms.Button
    Friend WithEvents Versturen_but As System.Windows.Forms.Button
    Friend WithEvents Ophalen1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Opmerking_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ophalen2_chk As System.Windows.Forms.CheckBox
End Class
