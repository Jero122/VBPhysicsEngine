<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialForm
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
        Me.Tutoriallbl = New System.Windows.Forms.Label()
        Me.TutorialLbl1 = New System.Windows.Forms.LinkLabel()
        Me.TutorialLbl2 = New System.Windows.Forms.LinkLabel()
        Me.TutorialLbl3 = New System.Windows.Forms.LinkLabel()
        Me.TutorialLbl4 = New System.Windows.Forms.LinkLabel()
        Me.TutorialLbl5 = New System.Windows.Forms.LinkLabel()
        Me.TutorialLbl6 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Tutoriallbl
        '
        Me.Tutoriallbl.AutoSize = True
        Me.Tutoriallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutoriallbl.Location = New System.Drawing.Point(97, 9)
        Me.Tutoriallbl.Name = "Tutoriallbl"
        Me.Tutoriallbl.Size = New System.Drawing.Size(77, 25)
        Me.Tutoriallbl.TabIndex = 0
        Me.Tutoriallbl.Text = "Tutorial"
        '
        'TutorialLbl1
        '
        Me.TutorialLbl1.AutoSize = True
        Me.TutorialLbl1.Location = New System.Drawing.Point(38, 53)
        Me.TutorialLbl1.Name = "TutorialLbl1"
        Me.TutorialLbl1.Size = New System.Drawing.Size(173, 13)
        Me.TutorialLbl1.TabIndex = 1
        Me.TutorialLbl1.TabStop = True
        Me.TutorialLbl1.Text = "1. Adding particles to the simulation"
        '
        'TutorialLbl2
        '
        Me.TutorialLbl2.AutoSize = True
        Me.TutorialLbl2.Location = New System.Drawing.Point(38, 80)
        Me.TutorialLbl2.Name = "TutorialLbl2"
        Me.TutorialLbl2.Size = New System.Drawing.Size(199, 13)
        Me.TutorialLbl2.TabIndex = 2
        Me.TutorialLbl2.TabStop = True
        Me.TutorialLbl2.Text = "2. Removing particles from the simulation"
        '
        'TutorialLbl3
        '
        Me.TutorialLbl3.AutoSize = True
        Me.TutorialLbl3.Location = New System.Drawing.Point(38, 108)
        Me.TutorialLbl3.Name = "TutorialLbl3"
        Me.TutorialLbl3.Size = New System.Drawing.Size(196, 13)
        Me.TutorialLbl3.TabIndex = 3
        Me.TutorialLbl3.TabStop = True
        Me.TutorialLbl3.Text = "3.Manipulating particles in the simulation"
        '
        'TutorialLbl4
        '
        Me.TutorialLbl4.AutoSize = True
        Me.TutorialLbl4.Location = New System.Drawing.Point(38, 135)
        Me.TutorialLbl4.Name = "TutorialLbl4"
        Me.TutorialLbl4.Size = New System.Drawing.Size(146, 13)
        Me.TutorialLbl4.TabIndex = 4
        Me.TutorialLbl4.TabStop = True
        Me.TutorialLbl4.Text = "4. Manipulating the simulation"
        '
        'TutorialLbl5
        '
        Me.TutorialLbl5.AutoSize = True
        Me.TutorialLbl5.Location = New System.Drawing.Point(38, 164)
        Me.TutorialLbl5.Name = "TutorialLbl5"
        Me.TutorialLbl5.Size = New System.Drawing.Size(129, 13)
        Me.TutorialLbl5.TabIndex = 5
        Me.TutorialLbl5.TabStop = True
        Me.TutorialLbl5.Text = "5. Limitations of the model"
        '
        'TutorialLbl6
        '
        Me.TutorialLbl6.AutoSize = True
        Me.TutorialLbl6.Location = New System.Drawing.Point(38, 192)
        Me.TutorialLbl6.Name = "TutorialLbl6"
        Me.TutorialLbl6.Size = New System.Drawing.Size(156, 13)
        Me.TutorialLbl6.TabIndex = 6
        Me.TutorialLbl6.TabStop = True
        Me.TutorialLbl6.Text = "6. Maths used for the simulation"
        '
        'TutorialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 232)
        Me.Controls.Add(Me.TutorialLbl6)
        Me.Controls.Add(Me.TutorialLbl5)
        Me.Controls.Add(Me.TutorialLbl4)
        Me.Controls.Add(Me.TutorialLbl3)
        Me.Controls.Add(Me.TutorialLbl2)
        Me.Controls.Add(Me.TutorialLbl1)
        Me.Controls.Add(Me.Tutoriallbl)
        Me.Name = "TutorialForm"
        Me.Text = "TutorialForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tutoriallbl As Label
    Friend WithEvents TutorialLbl1 As LinkLabel
    Friend WithEvents TutorialLbl2 As LinkLabel
    Friend WithEvents TutorialLbl3 As LinkLabel
    Friend WithEvents TutorialLbl4 As LinkLabel
    Friend WithEvents TutorialLbl5 As LinkLabel
    Friend WithEvents TutorialLbl6 As LinkLabel
End Class
