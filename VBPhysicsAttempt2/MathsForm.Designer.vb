<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MathsForm))
        Me.EulerLbl = New System.Windows.Forms.Label()
        Me.EulerIntegratorTb = New System.Windows.Forms.TextBox()
        Me.EulerIntegratorPb = New System.Windows.Forms.PictureBox()
        Me.EulerIntegratorLbl = New System.Windows.Forms.LinkLabel()
        Me.ValuesofstepPb = New System.Windows.Forms.PictureBox()
        Me.CollisionLbl = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StepTableLbl = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AngleFreeLbl = New System.Windows.Forms.LinkLabel()
        Me.AngleEquationsLbl = New System.Windows.Forms.LinkLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.CollisionsTB = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CollisionsPb = New System.Windows.Forms.PictureBox()
        CType(Me.EulerIntegratorPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValuesofstepPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollisionsPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EulerLbl
        '
        Me.EulerLbl.AutoSize = True
        Me.EulerLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EulerLbl.Location = New System.Drawing.Point(35, 24)
        Me.EulerLbl.Name = "EulerLbl"
        Me.EulerLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EulerLbl.Size = New System.Drawing.Size(153, 25)
        Me.EulerLbl.TabIndex = 0
        Me.EulerLbl.Text = "Euler Integration"
        '
        'EulerIntegratorTb
        '
        Me.EulerIntegratorTb.Location = New System.Drawing.Point(228, 57)
        Me.EulerIntegratorTb.Multiline = True
        Me.EulerIntegratorTb.Name = "EulerIntegratorTb"
        Me.EulerIntegratorTb.ReadOnly = True
        Me.EulerIntegratorTb.Size = New System.Drawing.Size(209, 328)
        Me.EulerIntegratorTb.TabIndex = 1
        Me.EulerIntegratorTb.Text = resources.GetString("EulerIntegratorTb.Text")
        '
        'EulerIntegratorPb
        '
        Me.EulerIntegratorPb.Image = CType(resources.GetObject("EulerIntegratorPb.Image"), System.Drawing.Image)
        Me.EulerIntegratorPb.Location = New System.Drawing.Point(26, 57)
        Me.EulerIntegratorPb.Name = "EulerIntegratorPb"
        Me.EulerIntegratorPb.Size = New System.Drawing.Size(196, 153)
        Me.EulerIntegratorPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EulerIntegratorPb.TabIndex = 2
        Me.EulerIntegratorPb.TabStop = False
        '
        'EulerIntegratorLbl
        '
        Me.EulerIntegratorLbl.AutoSize = True
        Me.EulerIntegratorLbl.Location = New System.Drawing.Point(32, 213)
        Me.EulerIntegratorLbl.Name = "EulerIntegratorLbl"
        Me.EulerIntegratorLbl.Size = New System.Drawing.Size(155, 26)
        Me.EulerIntegratorLbl.TabIndex = 3
        Me.EulerIntegratorLbl.TabStop = True
        Me.EulerIntegratorLbl.Text = "Blue line is an unknown curve, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "red line is the approximation"
        '
        'ValuesofstepPb
        '
        Me.ValuesofstepPb.Image = CType(resources.GetObject("ValuesofstepPb.Image"), System.Drawing.Image)
        Me.ValuesofstepPb.Location = New System.Drawing.Point(12, 249)
        Me.ValuesofstepPb.Name = "ValuesofstepPb"
        Me.ValuesofstepPb.Size = New System.Drawing.Size(210, 136)
        Me.ValuesofstepPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ValuesofstepPb.TabIndex = 4
        Me.ValuesofstepPb.TabStop = False
        '
        'CollisionLbl
        '
        Me.CollisionLbl.AutoSize = True
        Me.CollisionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollisionLbl.Location = New System.Drawing.Point(465, 24)
        Me.CollisionLbl.Name = "CollisionLbl"
        Me.CollisionLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CollisionLbl.Size = New System.Drawing.Size(146, 25)
        Me.CollisionLbl.TabIndex = 5
        Me.CollisionLbl.Text = "Collisions in 2D"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StepTableLbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 420)
        Me.Panel1.TabIndex = 6
        '
        'StepTableLbl
        '
        Me.StepTableLbl.AutoSize = True
        Me.StepTableLbl.Location = New System.Drawing.Point(3, 373)
        Me.StepTableLbl.Name = "StepTableLbl"
        Me.StepTableLbl.Size = New System.Drawing.Size(253, 13)
        Me.StepTableLbl.TabIndex = 8
        Me.StepTableLbl.TabStop = True
        Me.StepTableLbl.Text = "Source: https://en.wikipedia.org/wiki/Euler_method"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.AngleFreeLbl)
        Me.Panel2.Controls.Add(Me.AngleEquationsLbl)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.CollisionsTB)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.CollisionsPb)
        Me.Panel2.Location = New System.Drawing.Point(462, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(442, 420)
        Me.Panel2.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(4, 166)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(432, 26)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Gif source: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://en.wikipedia.org/wiki/Elastic_collision#/media/File:Elastis" &
    "cher_sto%C3%9F_2D.gif"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ρ = mv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "F = ma"
        '
        'AngleFreeLbl
        '
        Me.AngleFreeLbl.AutoSize = True
        Me.AngleFreeLbl.Location = New System.Drawing.Point(4, 373)
        Me.AngleFreeLbl.Name = "AngleFreeLbl"
        Me.AngleFreeLbl.Size = New System.Drawing.Size(174, 13)
        Me.AngleFreeLbl.TabIndex = 7
        Me.AngleFreeLbl.TabStop = True
        Me.AngleFreeLbl.Text = "Angle free equations from wikipedia"
        '
        'AngleEquationsLbl
        '
        Me.AngleEquationsLbl.AutoSize = True
        Me.AngleEquationsLbl.Location = New System.Drawing.Point(4, 271)
        Me.AngleEquationsLbl.Name = "AngleEquationsLbl"
        Me.AngleEquationsLbl.Size = New System.Drawing.Size(154, 13)
        Me.AngleEquationsLbl.TabIndex = 6
        Me.AngleEquationsLbl.TabStop = True
        Me.AngleEquationsLbl.Text = "Angle Equations from wikipedia"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 287)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(289, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'CollisionsTB
        '
        Me.CollisionsTB.Location = New System.Drawing.Point(216, 30)
        Me.CollisionsTB.Multiline = True
        Me.CollisionsTB.Name = "CollisionsTB"
        Me.CollisionsTB.ReadOnly = True
        Me.CollisionsTB.Size = New System.Drawing.Size(225, 137)
        Me.CollisionsTB.TabIndex = 2
        Me.CollisionsTB.Text = resources.GetString("CollisionsTB.Text")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(3, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(438, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'CollisionsPb
        '
        Me.CollisionsPb.Image = CType(resources.GetObject("CollisionsPb.Image"), System.Drawing.Image)
        Me.CollisionsPb.Location = New System.Drawing.Point(0, 30)
        Me.CollisionsPb.Name = "CollisionsPb"
        Me.CollisionsPb.Size = New System.Drawing.Size(209, 153)
        Me.CollisionsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CollisionsPb.TabIndex = 0
        Me.CollisionsPb.TabStop = False
        '
        'MathsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 441)
        Me.Controls.Add(Me.CollisionLbl)
        Me.Controls.Add(Me.ValuesofstepPb)
        Me.Controls.Add(Me.EulerIntegratorLbl)
        Me.Controls.Add(Me.EulerIntegratorPb)
        Me.Controls.Add(Me.EulerIntegratorTb)
        Me.Controls.Add(Me.EulerLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MathsForm"
        Me.Text = "MathsForm"
        CType(Me.EulerIntegratorPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValuesofstepPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollisionsPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EulerLbl As Label
    Friend WithEvents EulerIntegratorTb As TextBox
    Friend WithEvents EulerIntegratorPb As PictureBox
    Friend WithEvents EulerIntegratorLbl As LinkLabel
    Friend WithEvents ValuesofstepPb As PictureBox
    Friend WithEvents CollisionLbl As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CollisionsPb As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CollisionsTB As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents AngleFreeLbl As LinkLabel
    Friend WithEvents AngleEquationsLbl As LinkLabel
    Friend WithEvents StepTableLbl As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
