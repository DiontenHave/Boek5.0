<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabelberichtInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabelberichtInfo))
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlexGridLB = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.reset_fouttelling_but = New System.Windows.Forms.Button()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FlexGridLB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.Panel1)
        Me.C1Sizer1.Controls.Add(Me.FlexGridLB)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "8.30564784053156:False:False;89.7009966777409:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.1761071060762:False" & _
            ":False;"
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(971, 602)
        Me.C1Sizer1.TabIndex = 0
        Me.C1Sizer1.Text = "C1Sizer1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reset_fouttelling_but)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 50)
        Me.Panel1.TabIndex = 1
        '
        'FlexGridLB
        '
        Me.FlexGridLB.ColumnInfo = resources.GetString("FlexGridLB.ColumnInfo")
        Me.FlexGridLB.Location = New System.Drawing.Point(4, 58)
        Me.FlexGridLB.Name = "FlexGridLB"
        Me.FlexGridLB.Rows.Count = 2
        Me.FlexGridLB.Rows.DefaultSize = 17
        Me.FlexGridLB.Size = New System.Drawing.Size(963, 540)
        Me.FlexGridLB.TabIndex = 0
        '
        'reset_fouttelling_but
        '
        Me.reset_fouttelling_but.Location = New System.Drawing.Point(3, 8)
        Me.reset_fouttelling_but.Name = "reset_fouttelling_but"
        Me.reset_fouttelling_but.Size = New System.Drawing.Size(148, 37)
        Me.reset_fouttelling_but.TabIndex = 0
        Me.reset_fouttelling_but.Text = "Reset fout telling"
        Me.reset_fouttelling_but.UseVisualStyleBackColor = True
        '
        'LabelberichtInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 602)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Name = "LabelberichtInfo"
        Me.Text = "Label bericht overzicht"
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.FlexGridLB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlexGridLB As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents reset_fouttelling_but As System.Windows.Forms.Button
End Class
