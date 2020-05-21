<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vervoerslog_form
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.print_but = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1024, 733)
        Me.WebBrowser1.TabIndex = 0
        '
        'print_but
        '
        Me.print_but.Location = New System.Drawing.Point(422, 744)
        Me.print_but.Name = "print_but"
        Me.print_but.Size = New System.Drawing.Size(177, 34)
        Me.print_but.TabIndex = 1
        Me.print_but.Text = "Print"
        Me.print_but.UseVisualStyleBackColor = True
        '
        'vervoerslog_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 783)
        Me.Controls.Add(Me.print_but)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "vervoerslog_form"
        Me.Text = "Vervoerslog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents print_but As System.Windows.Forms.Button
End Class
