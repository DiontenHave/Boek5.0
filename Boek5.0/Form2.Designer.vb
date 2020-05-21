<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WpsWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WpsWindow))
        Me.Wps_Kar_Links_but = New System.Windows.Forms.Button()
        Me.Wps_Kar_Rechts_but = New System.Windows.Forms.Button()
        Me.Wps_Kar_invoer_but = New System.Windows.Forms.Button()
        Me.Wps_kopernaam2_lbl = New System.Windows.Forms.Label()
        Me.Wps_ordercount_lbl = New System.Windows.Forms.Label()
        Me.Wps_karcount_lbl = New System.Windows.Forms.Label()
        Me.Wps_kartype_lbl = New System.Windows.Forms.Label()
        Me.Wps_FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Wps_Kar_reset_but = New System.Windows.Forms.Button()
        Me.Wps_Order_Links_but = New System.Windows.Forms.Button()
        Me.Wps_Order_Rechts_but = New System.Windows.Forms.Button()
        Me.Wps_kopernaam1_lbl = New System.Windows.Forms.Label()
        Me.Wps_Order_versie_lbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Wps_opmerking_lbl1 = New System.Windows.Forms.Label()
        Me.Wps_Kar_printpakbon = New System.Windows.Forms.Button()
        Me.Wps_opmerking_lbl2 = New System.Windows.Forms.Label()
        CType(Me.Wps_FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wps_Kar_Links_but
        '
        Me.Wps_Kar_Links_but.Location = New System.Drawing.Point(11, 68)
        Me.Wps_Kar_Links_but.Name = "Wps_Kar_Links_but"
        Me.Wps_Kar_Links_but.Size = New System.Drawing.Size(44, 41)
        Me.Wps_Kar_Links_but.TabIndex = 0
        Me.Wps_Kar_Links_but.Text = "<"
        Me.Wps_Kar_Links_but.UseVisualStyleBackColor = True
        '
        'Wps_Kar_Rechts_but
        '
        Me.Wps_Kar_Rechts_but.Location = New System.Drawing.Point(225, 68)
        Me.Wps_Kar_Rechts_but.Name = "Wps_Kar_Rechts_but"
        Me.Wps_Kar_Rechts_but.Size = New System.Drawing.Size(44, 41)
        Me.Wps_Kar_Rechts_but.TabIndex = 1
        Me.Wps_Kar_Rechts_but.Text = ">"
        Me.Wps_Kar_Rechts_but.UseVisualStyleBackColor = True
        '
        'Wps_Kar_invoer_but
        '
        Me.Wps_Kar_invoer_but.Location = New System.Drawing.Point(143, 68)
        Me.Wps_Kar_invoer_but.Name = "Wps_Kar_invoer_but"
        Me.Wps_Kar_invoer_but.Size = New System.Drawing.Size(76, 41)
        Me.Wps_Kar_invoer_but.TabIndex = 4
        Me.Wps_Kar_invoer_but.Text = "Kar ingevoerd"
        Me.Wps_Kar_invoer_but.UseVisualStyleBackColor = True
        '
        'Wps_kopernaam2_lbl
        '
        Me.Wps_kopernaam2_lbl.AutoSize = True
        Me.Wps_kopernaam2_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wps_kopernaam2_lbl.Location = New System.Drawing.Point(9, 124)
        Me.Wps_kopernaam2_lbl.Name = "Wps_kopernaam2_lbl"
        Me.Wps_kopernaam2_lbl.Size = New System.Drawing.Size(142, 16)
        Me.Wps_kopernaam2_lbl.TabIndex = 5
        Me.Wps_kopernaam2_lbl.Text = "Janus Timmermans"
        '
        'Wps_ordercount_lbl
        '
        Me.Wps_ordercount_lbl.AutoSize = True
        Me.Wps_ordercount_lbl.Location = New System.Drawing.Point(103, 9)
        Me.Wps_ordercount_lbl.Name = "Wps_ordercount_lbl"
        Me.Wps_ordercount_lbl.Size = New System.Drawing.Size(72, 13)
        Me.Wps_ordercount_lbl.TabIndex = 6
        Me.Wps_ordercount_lbl.Text = "Order 1 van 5"
        '
        'Wps_karcount_lbl
        '
        Me.Wps_karcount_lbl.AutoSize = True
        Me.Wps_karcount_lbl.Location = New System.Drawing.Point(9, 140)
        Me.Wps_karcount_lbl.Name = "Wps_karcount_lbl"
        Me.Wps_karcount_lbl.Size = New System.Drawing.Size(62, 13)
        Me.Wps_karcount_lbl.TabIndex = 7
        Me.Wps_karcount_lbl.Text = "Kar 1 van 2"
        '
        'Wps_kartype_lbl
        '
        Me.Wps_kartype_lbl.AutoSize = True
        Me.Wps_kartype_lbl.Location = New System.Drawing.Point(9, 153)
        Me.Wps_kartype_lbl.Name = "Wps_kartype_lbl"
        Me.Wps_kartype_lbl.Size = New System.Drawing.Size(107, 13)
        Me.Wps_kartype_lbl.TabIndex = 9
        Me.Wps_kartype_lbl.Text = "Deen DC zonder Slot"
        '
        'Wps_FlexGrid1
        '
        Me.Wps_FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Wps_FlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Wps_FlexGrid1.ColumnInfo = resources.GetString("Wps_FlexGrid1.ColumnInfo")
        Me.Wps_FlexGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Wps_FlexGrid1.Location = New System.Drawing.Point(0, 208)
        Me.Wps_FlexGrid1.Name = "Wps_FlexGrid1"
        Me.Wps_FlexGrid1.Rows.Count = 12
        Me.Wps_FlexGrid1.Rows.DefaultSize = 17
        Me.Wps_FlexGrid1.Size = New System.Drawing.Size(282, 211)
        Me.Wps_FlexGrid1.TabIndex = 10
        '
        'Wps_Kar_reset_but
        '
        Me.Wps_Kar_reset_but.Location = New System.Drawing.Point(61, 68)
        Me.Wps_Kar_reset_but.Name = "Wps_Kar_reset_but"
        Me.Wps_Kar_reset_but.Size = New System.Drawing.Size(76, 41)
        Me.Wps_Kar_reset_but.TabIndex = 11
        Me.Wps_Kar_reset_but.Text = "Kar Reset"
        Me.Wps_Kar_reset_but.UseVisualStyleBackColor = True
        '
        'Wps_Order_Links_but
        '
        Me.Wps_Order_Links_but.Location = New System.Drawing.Point(14, 9)
        Me.Wps_Order_Links_but.Name = "Wps_Order_Links_but"
        Me.Wps_Order_Links_but.Size = New System.Drawing.Size(42, 30)
        Me.Wps_Order_Links_but.TabIndex = 12
        Me.Wps_Order_Links_but.Text = "<"
        Me.Wps_Order_Links_but.UseVisualStyleBackColor = True
        '
        'Wps_Order_Rechts_but
        '
        Me.Wps_Order_Rechts_but.Location = New System.Drawing.Point(226, 9)
        Me.Wps_Order_Rechts_but.Name = "Wps_Order_Rechts_but"
        Me.Wps_Order_Rechts_but.Size = New System.Drawing.Size(44, 30)
        Me.Wps_Order_Rechts_but.TabIndex = 13
        Me.Wps_Order_Rechts_but.Text = ">"
        Me.Wps_Order_Rechts_but.UseVisualStyleBackColor = True
        '
        'Wps_kopernaam1_lbl
        '
        Me.Wps_kopernaam1_lbl.AutoSize = True
        Me.Wps_kopernaam1_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wps_kopernaam1_lbl.Location = New System.Drawing.Point(62, 23)
        Me.Wps_kopernaam1_lbl.Name = "Wps_kopernaam1_lbl"
        Me.Wps_kopernaam1_lbl.Size = New System.Drawing.Size(142, 16)
        Me.Wps_kopernaam1_lbl.TabIndex = 14
        Me.Wps_kopernaam1_lbl.Text = "Janus Timmermans"
        '
        'Wps_Order_versie_lbl
        '
        Me.Wps_Order_versie_lbl.AutoSize = True
        Me.Wps_Order_versie_lbl.Location = New System.Drawing.Point(115, 39)
        Me.Wps_Order_versie_lbl.Name = "Wps_Order_versie_lbl"
        Me.Wps_Order_versie_lbl.Size = New System.Drawing.Size(36, 13)
        Me.Wps_Order_versie_lbl.TabIndex = 16
        Me.Wps_Order_versie_lbl.Text = "Versie"
        Me.Wps_Order_versie_lbl.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 1000
        '
        'Wps_opmerking_lbl1
        '
        Me.Wps_opmerking_lbl1.AutoSize = True
        Me.Wps_opmerking_lbl1.Location = New System.Drawing.Point(9, 166)
        Me.Wps_opmerking_lbl1.Name = "Wps_opmerking_lbl1"
        Me.Wps_opmerking_lbl1.Size = New System.Drawing.Size(35, 13)
        Me.Wps_opmerking_lbl1.TabIndex = 17
        Me.Wps_opmerking_lbl1.Text = "Opm :"
        '
        'Wps_Kar_printpakbon
        '
        Me.Wps_Kar_printpakbon.Location = New System.Drawing.Point(177, 145)
        Me.Wps_Kar_printpakbon.Name = "Wps_Kar_printpakbon"
        Me.Wps_Kar_printpakbon.Size = New System.Drawing.Size(93, 21)
        Me.Wps_Kar_printpakbon.TabIndex = 18
        Me.Wps_Kar_printpakbon.Text = "Print pakbon"
        Me.Wps_Kar_printpakbon.UseVisualStyleBackColor = True
        '
        'Wps_opmerking_lbl2
        '
        Me.Wps_opmerking_lbl2.AutoSize = True
        Me.Wps_opmerking_lbl2.Location = New System.Drawing.Point(9, 179)
        Me.Wps_opmerking_lbl2.Name = "Wps_opmerking_lbl2"
        Me.Wps_opmerking_lbl2.Size = New System.Drawing.Size(47, 13)
        Me.Wps_opmerking_lbl2.TabIndex = 19
        Me.Wps_opmerking_lbl2.Text = "Pakbon:"
        '
        'WpsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 419)
        Me.Controls.Add(Me.Wps_opmerking_lbl2)
        Me.Controls.Add(Me.Wps_Kar_printpakbon)
        Me.Controls.Add(Me.Wps_opmerking_lbl1)
        Me.Controls.Add(Me.Wps_Order_versie_lbl)
        Me.Controls.Add(Me.Wps_kopernaam1_lbl)
        Me.Controls.Add(Me.Wps_Order_Rechts_but)
        Me.Controls.Add(Me.Wps_Order_Links_but)
        Me.Controls.Add(Me.Wps_Kar_reset_but)
        Me.Controls.Add(Me.Wps_FlexGrid1)
        Me.Controls.Add(Me.Wps_kartype_lbl)
        Me.Controls.Add(Me.Wps_karcount_lbl)
        Me.Controls.Add(Me.Wps_ordercount_lbl)
        Me.Controls.Add(Me.Wps_kopernaam2_lbl)
        Me.Controls.Add(Me.Wps_Kar_invoer_but)
        Me.Controls.Add(Me.Wps_Kar_Rechts_but)
        Me.Controls.Add(Me.Wps_Kar_Links_but)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WpsWindow"
        Me.Text = "Wps Orders"
        CType(Me.Wps_FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wps_Kar_Links_but As System.Windows.Forms.Button
    Friend WithEvents Wps_Kar_Rechts_but As System.Windows.Forms.Button
    Friend WithEvents Wps_Kar_invoer_but As System.Windows.Forms.Button
    Friend WithEvents Wps_kopernaam2_lbl As System.Windows.Forms.Label
    Friend WithEvents Wps_ordercount_lbl As System.Windows.Forms.Label
    Friend WithEvents Wps_karcount_lbl As System.Windows.Forms.Label
    Friend WithEvents Wps_kartype_lbl As System.Windows.Forms.Label
    Friend WithEvents Wps_FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Wps_Kar_reset_but As System.Windows.Forms.Button
    Friend WithEvents Wps_Order_Links_but As System.Windows.Forms.Button
    Friend WithEvents Wps_Order_Rechts_but As System.Windows.Forms.Button
    Friend WithEvents Wps_kopernaam1_lbl As System.Windows.Forms.Label
    Friend WithEvents Wps_Order_versie_lbl As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Wps_opmerking_lbl1 As System.Windows.Forms.Label
    Friend WithEvents Wps_Kar_printpakbon As System.Windows.Forms.Button
    Friend WithEvents Wps_opmerking_lbl2 As System.Windows.Forms.Label
End Class
