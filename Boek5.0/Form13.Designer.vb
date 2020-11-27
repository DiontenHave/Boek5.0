<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form13
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
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OkButton_but = New System.Windows.Forms.Button()
        Me.text_txt = New System.Windows.Forms.TextBox()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.Panel1)
        Me.C1Sizer1.Controls.Add(Me.text_txt)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "88.4444444444444:False:False;8.88888888888889:False:True;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0719257540603:False:" &
    "False;"
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(862, 450)
        Me.C1Sizer1.TabIndex = 0
        Me.C1Sizer1.Text = "C1Sizer1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OkButton_but)
        Me.Panel1.Location = New System.Drawing.Point(4, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 40)
        Me.Panel1.TabIndex = 1
        '
        'OkButton_but
        '
        Me.OkButton_but.Location = New System.Drawing.Point(342, 3)
        Me.OkButton_but.Name = "OkButton_but"
        Me.OkButton_but.Size = New System.Drawing.Size(219, 34)
        Me.OkButton_but.TabIndex = 0
        Me.OkButton_but.Text = "OK"
        Me.OkButton_but.UseVisualStyleBackColor = True
        '
        'text_txt
        '
        Me.text_txt.Location = New System.Drawing.Point(4, 4)
        Me.text_txt.Multiline = True
        Me.text_txt.Name = "text_txt"
        Me.text_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.text_txt.Size = New System.Drawing.Size(854, 398)
        Me.text_txt.TabIndex = 0
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 450)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Name = "Form13"
        Me.Text = "Overzicht"
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        Me.C1Sizer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OkButton_but As Button
    Friend WithEvents text_txt As TextBox
End Class
