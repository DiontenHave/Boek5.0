<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.annuleren_but = New System.Windows.Forms.Button()
        Me.order_aanpassen_but = New System.Windows.Forms.Button()
        Me.aantal_bestelling_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prijs_bestelling_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fustcode_bestelling_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.apf_bestelling_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.reden_aanpassing_txt = New System.Windows.Forms.TextBox()
        Me.apf_aanpassing_txt = New System.Windows.Forms.TextBox()
        Me.fustcode_aanpassing_txt = New System.Windows.Forms.TextBox()
        Me.prijs_aanpassing_txt = New System.Windows.Forms.TextBox()
        Me.aantal_aanpassing_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.reden_annuleren_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OrderID_lbl = New System.Windows.Forms.Label()
        Me.fust = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.aantalperfust2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'annuleren_but
        '
        Me.annuleren_but.Location = New System.Drawing.Point(165, 67)
        Me.annuleren_but.Name = "annuleren_but"
        Me.annuleren_but.Size = New System.Drawing.Size(252, 29)
        Me.annuleren_but.TabIndex = 0
        Me.annuleren_but.Text = "Order geheel anulleren"
        Me.annuleren_but.UseVisualStyleBackColor = True
        '
        'order_aanpassen_but
        '
        Me.order_aanpassen_but.Location = New System.Drawing.Point(165, 172)
        Me.order_aanpassen_but.Name = "order_aanpassen_but"
        Me.order_aanpassen_but.Size = New System.Drawing.Size(252, 29)
        Me.order_aanpassen_but.TabIndex = 1
        Me.order_aanpassen_but.Text = "Order aanpassen"
        Me.order_aanpassen_but.UseVisualStyleBackColor = True
        '
        'aantal_bestelling_txt
        '
        Me.aantal_bestelling_txt.Enabled = False
        Me.aantal_bestelling_txt.Location = New System.Drawing.Point(165, 42)
        Me.aantal_bestelling_txt.Name = "aantal_bestelling_txt"
        Me.aantal_bestelling_txt.Size = New System.Drawing.Size(120, 20)
        Me.aantal_bestelling_txt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aantal stuks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prijs"
        '
        'prijs_bestelling_txt
        '
        Me.prijs_bestelling_txt.Enabled = False
        Me.prijs_bestelling_txt.Location = New System.Drawing.Point(165, 68)
        Me.prijs_bestelling_txt.Name = "prijs_bestelling_txt"
        Me.prijs_bestelling_txt.Size = New System.Drawing.Size(120, 20)
        Me.prijs_bestelling_txt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fustcode"
        '
        'fustcode_bestelling_txt
        '
        Me.fustcode_bestelling_txt.Enabled = False
        Me.fustcode_bestelling_txt.Location = New System.Drawing.Point(165, 94)
        Me.fustcode_bestelling_txt.Name = "fustcode_bestelling_txt"
        Me.fustcode_bestelling_txt.Size = New System.Drawing.Size(120, 20)
        Me.fustcode_bestelling_txt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Aantal per fust"
        '
        'apf_bestelling_txt
        '
        Me.apf_bestelling_txt.Enabled = False
        Me.apf_bestelling_txt.Location = New System.Drawing.Point(165, 120)
        Me.apf_bestelling_txt.Name = "apf_bestelling_txt"
        Me.apf_bestelling_txt.Size = New System.Drawing.Size(120, 20)
        Me.apf_bestelling_txt.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Reden voor aanpassen"
        '
        'reden_aanpassing_txt
        '
        Me.reden_aanpassing_txt.Location = New System.Drawing.Point(165, 146)
        Me.reden_aanpassing_txt.Name = "reden_aanpassing_txt"
        Me.reden_aanpassing_txt.Size = New System.Drawing.Size(252, 20)
        Me.reden_aanpassing_txt.TabIndex = 16
        '
        'apf_aanpassing_txt
        '
        Me.apf_aanpassing_txt.Location = New System.Drawing.Point(297, 120)
        Me.apf_aanpassing_txt.Name = "apf_aanpassing_txt"
        Me.apf_aanpassing_txt.Size = New System.Drawing.Size(120, 20)
        Me.apf_aanpassing_txt.TabIndex = 15
        '
        'fustcode_aanpassing_txt
        '
        Me.fustcode_aanpassing_txt.Location = New System.Drawing.Point(297, 94)
        Me.fustcode_aanpassing_txt.Name = "fustcode_aanpassing_txt"
        Me.fustcode_aanpassing_txt.Size = New System.Drawing.Size(120, 20)
        Me.fustcode_aanpassing_txt.TabIndex = 14
        '
        'prijs_aanpassing_txt
        '
        Me.prijs_aanpassing_txt.Location = New System.Drawing.Point(297, 68)
        Me.prijs_aanpassing_txt.Name = "prijs_aanpassing_txt"
        Me.prijs_aanpassing_txt.Size = New System.Drawing.Size(120, 20)
        Me.prijs_aanpassing_txt.TabIndex = 13
        '
        'aantal_aanpassing_txt
        '
        Me.aantal_aanpassing_txt.Enabled = False
        Me.aantal_aanpassing_txt.Location = New System.Drawing.Point(297, 42)
        Me.aantal_aanpassing_txt.Name = "aantal_aanpassing_txt"
        Me.aantal_aanpassing_txt.Size = New System.Drawing.Size(120, 20)
        Me.aantal_aanpassing_txt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Bestelling"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Aanpassing"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Reden voor annuleren"
        '
        'reden_annuleren_txt
        '
        Me.reden_annuleren_txt.Location = New System.Drawing.Point(165, 41)
        Me.reden_annuleren_txt.Name = "reden_annuleren_txt"
        Me.reden_annuleren_txt.Size = New System.Drawing.Size(252, 20)
        Me.reden_annuleren_txt.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.reden_annuleren_txt)
        Me.GroupBox1.Controls.Add(Me.annuleren_but)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 123)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order annuleren"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.aantalperfust2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.fust)
        Me.GroupBox2.Controls.Add(Me.aantal_bestelling_txt)
        Me.GroupBox2.Controls.Add(Me.order_aanpassen_but)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.prijs_bestelling_txt)
        Me.GroupBox2.Controls.Add(Me.reden_aanpassing_txt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.apf_aanpassing_txt)
        Me.GroupBox2.Controls.Add(Me.fustcode_bestelling_txt)
        Me.GroupBox2.Controls.Add(Me.fustcode_aanpassing_txt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.prijs_aanpassing_txt)
        Me.GroupBox2.Controls.Add(Me.apf_bestelling_txt)
        Me.GroupBox2.Controls.Add(Me.aantal_aanpassing_txt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 239)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order aanpassen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Order ID:"
        '
        'OrderID_lbl
        '
        Me.OrderID_lbl.AutoSize = True
        Me.OrderID_lbl.Location = New System.Drawing.Point(68, 398)
        Me.OrderID_lbl.Name = "OrderID_lbl"
        Me.OrderID_lbl.Size = New System.Drawing.Size(24, 13)
        Me.OrderID_lbl.TabIndex = 23
        Me.OrderID_lbl.Text = "-ID-"
        '
        'fust
        '
        Me.fust.Location = New System.Drawing.Point(434, 42)
        Me.fust.Name = "fust"
        Me.fust.Size = New System.Drawing.Size(38, 20)
        Me.fust.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(478, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "x"
        '
        'aantalperfust2
        '
        Me.aantalperfust2.Enabled = False
        Me.aantalperfust2.Location = New System.Drawing.Point(496, 42)
        Me.aantalperfust2.Name = "aantalperfust2"
        Me.aantalperfust2.Size = New System.Drawing.Size(43, 20)
        Me.aantalperfust2.TabIndex = 21
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 420)
        Me.Controls.Add(Me.OrderID_lbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form14"
        Me.Text = "Sales order correctie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents annuleren_but As Button
    Friend WithEvents order_aanpassen_but As Button
    Friend WithEvents aantal_bestelling_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents prijs_bestelling_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fustcode_bestelling_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents apf_bestelling_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents reden_aanpassing_txt As TextBox
    Friend WithEvents apf_aanpassing_txt As TextBox
    Friend WithEvents fustcode_aanpassing_txt As TextBox
    Friend WithEvents prijs_aanpassing_txt As TextBox
    Friend WithEvents aantal_aanpassing_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents reden_annuleren_txt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OrderID_lbl As Label
    Friend WithEvents aantalperfust2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents fust As TextBox
End Class
