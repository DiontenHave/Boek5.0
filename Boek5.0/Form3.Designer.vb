<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProgressBar
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
        Me.DataProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'DataProgressBar
        '
        Me.DataProgressBar.Location = New System.Drawing.Point(11, 9)
        Me.DataProgressBar.Name = "DataProgressBar"
        Me.DataProgressBar.Size = New System.Drawing.Size(299, 26)
        Me.DataProgressBar.TabIndex = 0
        '
        'FormProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 40)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataProgressBar)
        Me.Name = "FormProgressBar"
        Me.Text = "Reading Database..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataProgressBar As System.Windows.Forms.ProgressBar
End Class
