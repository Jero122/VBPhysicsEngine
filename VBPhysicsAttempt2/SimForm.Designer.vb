<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DrawingSurface = New System.Windows.Forms.PictureBox()
        Me.SimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.AddCircleBtn = New System.Windows.Forms.Button()
        Me.AddRectangleBtn = New System.Windows.Forms.Button()
        Me.RadiusLbl = New System.Windows.Forms.Label()
        Me.RadiusNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.CircMassNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.CircMassLbl = New System.Windows.Forms.Label()
        Me.CircleParticlesView = New System.Windows.Forms.ListView()
        Me.massheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sizeheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.densityheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xvelocityheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yvelocityheader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GravitySlider = New System.Windows.Forms.TrackBar()
        Me.GravityLabel = New System.Windows.Forms.Label()
        Me.SimSpeedSlider = New System.Windows.Forms.TrackBar()
        Me.TimeSliderLabel = New System.Windows.Forms.Label()
        Me.RectMassNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RectMassLbl = New System.Windows.Forms.Label()
        Me.WidthNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RectWidthLbl = New System.Windows.Forms.Label()
        Me.HeightNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RectHeightLbl = New System.Windows.Forms.Label()
        Me.DeleteModeBtn = New System.Windows.Forms.Button()
        Me.IsfixedCheckedBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CoRLbl = New System.Windows.Forms.Label()
        Me.CoRSlider = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ShowTutBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RectParticlesView = New System.Windows.Forms.ListView()
        Me.UpdateLists = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DrawingSurface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadiusNumericBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircMassNumericBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GravitySlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimSpeedSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RectMassNumericBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthNumericBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightNumericBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CoRSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingSurface
        '
        Me.DrawingSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawingSurface.Location = New System.Drawing.Point(130, 12)
        Me.DrawingSurface.Name = "DrawingSurface"
        Me.DrawingSurface.Size = New System.Drawing.Size(1070, 462)
        Me.DrawingSurface.TabIndex = 10
        Me.DrawingSurface.TabStop = False
        '
        'SimTimer
        '
        Me.SimTimer.Enabled = True
        Me.SimTimer.Interval = 1
        '
        'StartBtn
        '
        Me.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.StartBtn.ForeColor = System.Drawing.Color.Red
        Me.StartBtn.Location = New System.Drawing.Point(0, 256)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(124, 55)
        Me.StartBtn.TabIndex = 11
        Me.StartBtn.Text = "Sim Mode: Paused"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'AddCircleBtn
        '
        Me.AddCircleBtn.Location = New System.Drawing.Point(9, 83)
        Me.AddCircleBtn.Name = "AddCircleBtn"
        Me.AddCircleBtn.Size = New System.Drawing.Size(101, 23)
        Me.AddCircleBtn.TabIndex = 22
        Me.AddCircleBtn.Text = "Add Circle"
        Me.AddCircleBtn.UseVisualStyleBackColor = True
        '
        'AddRectangleBtn
        '
        Me.AddRectangleBtn.BackColor = System.Drawing.SystemColors.Control
        Me.AddRectangleBtn.Location = New System.Drawing.Point(9, 81)
        Me.AddRectangleBtn.Name = "AddRectangleBtn"
        Me.AddRectangleBtn.Size = New System.Drawing.Size(101, 23)
        Me.AddRectangleBtn.TabIndex = 23
        Me.AddRectangleBtn.Text = "Add Rectangle"
        Me.AddRectangleBtn.UseVisualStyleBackColor = False
        '
        'RadiusLbl
        '
        Me.RadiusLbl.AutoSize = True
        Me.RadiusLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadiusLbl.Location = New System.Drawing.Point(0, 5)
        Me.RadiusLbl.Name = "RadiusLbl"
        Me.RadiusLbl.Size = New System.Drawing.Size(57, 13)
        Me.RadiusLbl.TabIndex = 28
        Me.RadiusLbl.Text = "Radius (m)"
        '
        'RadiusNumericBox
        '
        Me.RadiusNumericBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadiusNumericBox.Location = New System.Drawing.Point(56, 3)
        Me.RadiusNumericBox.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RadiusNumericBox.Name = "RadiusNumericBox"
        Me.RadiusNumericBox.Size = New System.Drawing.Size(54, 20)
        Me.RadiusNumericBox.TabIndex = 29
        '
        'CircMassNumericBox
        '
        Me.CircMassNumericBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CircMassNumericBox.Location = New System.Drawing.Point(56, 29)
        Me.CircMassNumericBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CircMassNumericBox.Name = "CircMassNumericBox"
        Me.CircMassNumericBox.Size = New System.Drawing.Size(54, 20)
        Me.CircMassNumericBox.TabIndex = 31
        '
        'CircMassLbl
        '
        Me.CircMassLbl.AutoSize = True
        Me.CircMassLbl.Location = New System.Drawing.Point(0, 31)
        Me.CircMassLbl.Name = "CircMassLbl"
        Me.CircMassLbl.Size = New System.Drawing.Size(54, 13)
        Me.CircMassLbl.TabIndex = 30
        Me.CircMassLbl.Text = "Mass (Kg)"
        '
        'CircleParticlesView
        '
        Me.CircleParticlesView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.CircleParticlesView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CircleParticlesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.massheader, Me.Sizeheader, Me.densityheader, Me.xheader, Me.yheader, Me.xvelocityheader, Me.yvelocityheader})
        Me.CircleParticlesView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CircleParticlesView.FullRowSelect = True
        Me.CircleParticlesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.CircleParticlesView.HideSelection = False
        Me.CircleParticlesView.Location = New System.Drawing.Point(180, 480)
        Me.CircleParticlesView.Name = "CircleParticlesView"
        Me.CircleParticlesView.Size = New System.Drawing.Size(475, 190)
        Me.CircleParticlesView.TabIndex = 34
        Me.CircleParticlesView.UseCompatibleStateImageBehavior = False
        Me.CircleParticlesView.View = System.Windows.Forms.View.Details
        '
        'massheader
        '
        Me.massheader.Text = "Mass(kg)"
        '
        'Sizeheader
        '
        Me.Sizeheader.Text = "Radius(M)"
        Me.Sizeheader.Width = 63
        '
        'densityheader
        '
        Me.densityheader.Text = "Density(kg/m²)"
        Me.densityheader.Width = 91
        '
        'xheader
        '
        Me.xheader.Text = "X"
        Me.xheader.Width = 42
        '
        'yheader
        '
        Me.yheader.Text = "Y"
        Me.yheader.Width = 39
        '
        'xvelocityheader
        '
        Me.xvelocityheader.Text = "X Velocity"
        Me.xvelocityheader.Width = 69
        '
        'yvelocityheader
        '
        Me.yvelocityheader.Text = "Y Velocity"
        Me.yvelocityheader.Width = 72
        '
        'GravitySlider
        '
        Me.GravitySlider.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GravitySlider.LargeChange = 1
        Me.GravitySlider.Location = New System.Drawing.Point(5, 54)
        Me.GravitySlider.Maximum = 1000
        Me.GravitySlider.Name = "GravitySlider"
        Me.GravitySlider.Size = New System.Drawing.Size(104, 45)
        Me.GravitySlider.TabIndex = 35
        Me.GravitySlider.Value = 98
        '
        'GravityLabel
        '
        Me.GravityLabel.AutoSize = True
        Me.GravityLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GravityLabel.Location = New System.Drawing.Point(15, 86)
        Me.GravityLabel.Name = "GravityLabel"
        Me.GravityLabel.Size = New System.Drawing.Size(46, 13)
        Me.GravityLabel.TabIndex = 36
        Me.GravityLabel.Text = "Gravity: "
        '
        'SimSpeedSlider
        '
        Me.SimSpeedSlider.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SimSpeedSlider.LargeChange = 1
        Me.SimSpeedSlider.Location = New System.Drawing.Point(5, 3)
        Me.SimSpeedSlider.Maximum = 1200
        Me.SimSpeedSlider.Minimum = 60
        Me.SimSpeedSlider.Name = "SimSpeedSlider"
        Me.SimSpeedSlider.Size = New System.Drawing.Size(104, 45)
        Me.SimSpeedSlider.TabIndex = 37
        Me.SimSpeedSlider.Value = 60
        '
        'TimeSliderLabel
        '
        Me.TimeSliderLabel.AutoSize = True
        Me.TimeSliderLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TimeSliderLabel.Location = New System.Drawing.Point(18, 35)
        Me.TimeSliderLabel.Name = "TimeSliderLabel"
        Me.TimeSliderLabel.Size = New System.Drawing.Size(36, 13)
        Me.TimeSliderLabel.TabIndex = 38
        Me.TimeSliderLabel.Text = "Time: "
        '
        'RectMassNumericBox
        '
        Me.RectMassNumericBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectMassNumericBox.Location = New System.Drawing.Point(56, 55)
        Me.RectMassNumericBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.RectMassNumericBox.Name = "RectMassNumericBox"
        Me.RectMassNumericBox.Size = New System.Drawing.Size(54, 20)
        Me.RectMassNumericBox.TabIndex = 43
        '
        'RectMassLbl
        '
        Me.RectMassLbl.AutoSize = True
        Me.RectMassLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectMassLbl.Location = New System.Drawing.Point(3, 57)
        Me.RectMassLbl.Name = "RectMassLbl"
        Me.RectMassLbl.Size = New System.Drawing.Size(54, 13)
        Me.RectMassLbl.TabIndex = 42
        Me.RectMassLbl.Text = "Mass (Kg)"
        '
        'WidthNumericBox
        '
        Me.WidthNumericBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.WidthNumericBox.Location = New System.Drawing.Point(56, 3)
        Me.WidthNumericBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.WidthNumericBox.Name = "WidthNumericBox"
        Me.WidthNumericBox.Size = New System.Drawing.Size(54, 20)
        Me.WidthNumericBox.TabIndex = 41
        '
        'RectWidthLbl
        '
        Me.RectWidthLbl.AutoSize = True
        Me.RectWidthLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectWidthLbl.Location = New System.Drawing.Point(0, 5)
        Me.RectWidthLbl.Name = "RectWidthLbl"
        Me.RectWidthLbl.Size = New System.Drawing.Size(52, 13)
        Me.RectWidthLbl.TabIndex = 40
        Me.RectWidthLbl.Text = "Width (m)"
        '
        'HeightNumericBox
        '
        Me.HeightNumericBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HeightNumericBox.Location = New System.Drawing.Point(56, 29)
        Me.HeightNumericBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HeightNumericBox.Name = "HeightNumericBox"
        Me.HeightNumericBox.Size = New System.Drawing.Size(54, 20)
        Me.HeightNumericBox.TabIndex = 45
        '
        'RectHeightLbl
        '
        Me.RectHeightLbl.AutoSize = True
        Me.RectHeightLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectHeightLbl.Location = New System.Drawing.Point(0, 31)
        Me.RectHeightLbl.Name = "RectHeightLbl"
        Me.RectHeightLbl.Size = New System.Drawing.Size(55, 13)
        Me.RectHeightLbl.TabIndex = 44
        Me.RectHeightLbl.Text = "Height (m)"
        '
        'DeleteModeBtn
        '
        Me.DeleteModeBtn.ForeColor = System.Drawing.Color.Green
        Me.DeleteModeBtn.Location = New System.Drawing.Point(2, 317)
        Me.DeleteModeBtn.Name = "DeleteModeBtn"
        Me.DeleteModeBtn.Size = New System.Drawing.Size(122, 54)
        Me.DeleteModeBtn.TabIndex = 46
        Me.DeleteModeBtn.Text = "Mode: Moving"
        Me.DeleteModeBtn.UseVisualStyleBackColor = True
        '
        'IsfixedCheckedBox
        '
        Me.IsfixedCheckedBox.AutoSize = True
        Me.IsfixedCheckedBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IsfixedCheckedBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsfixedCheckedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsfixedCheckedBox.Location = New System.Drawing.Point(25, 55)
        Me.IsfixedCheckedBox.Name = "IsfixedCheckedBox"
        Me.IsfixedCheckedBox.Size = New System.Drawing.Size(51, 17)
        Me.IsfixedCheckedBox.TabIndex = 48
        Me.IsfixedCheckedBox.Text = "Fixed"
        Me.IsfixedCheckedBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IsfixedCheckedBox.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CoRLbl)
        Me.Panel1.Controls.Add(Me.CoRSlider)
        Me.Panel1.Controls.Add(Me.GravityLabel)
        Me.Panel1.Controls.Add(Me.TimeSliderLabel)
        Me.Panel1.Controls.Add(Me.SimSpeedSlider)
        Me.Panel1.Controls.Add(Me.GravitySlider)
        Me.Panel1.Location = New System.Drawing.Point(2, 480)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 190)
        Me.Panel1.TabIndex = 49
        '
        'CoRLbl
        '
        Me.CoRLbl.AutoSize = True
        Me.CoRLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CoRLbl.Location = New System.Drawing.Point(15, 140)
        Me.CoRLbl.Name = "CoRLbl"
        Me.CoRLbl.Size = New System.Drawing.Size(80, 13)
        Me.CoRLbl.TabIndex = 53
        Me.CoRLbl.Text = "Collisions CoR: "
        '
        'CoRSlider
        '
        Me.CoRSlider.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CoRSlider.LargeChange = 1
        Me.CoRSlider.Location = New System.Drawing.Point(5, 107)
        Me.CoRSlider.Maximum = 100
        Me.CoRSlider.Name = "CoRSlider"
        Me.CoRSlider.Size = New System.Drawing.Size(104, 45)
        Me.CoRSlider.TabIndex = 52
        Me.CoRSlider.Value = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.IsfixedCheckedBox)
        Me.Panel2.Controls.Add(Me.AddCircleBtn)
        Me.Panel2.Controls.Add(Me.CircMassLbl)
        Me.Panel2.Controls.Add(Me.CircMassNumericBox)
        Me.Panel2.Controls.Add(Me.RadiusLbl)
        Me.Panel2.Controls.Add(Me.RadiusNumericBox)
        Me.Panel2.Location = New System.Drawing.Point(2, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(121, 119)
        Me.Panel2.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AddRectangleBtn)
        Me.Panel3.Controls.Add(Me.WidthNumericBox)
        Me.Panel3.Controls.Add(Me.HeightNumericBox)
        Me.Panel3.Controls.Add(Me.RectWidthLbl)
        Me.Panel3.Controls.Add(Me.RectHeightLbl)
        Me.Panel3.Controls.Add(Me.RectMassLbl)
        Me.Panel3.Controls.Add(Me.RectMassNumericBox)
        Me.Panel3.Location = New System.Drawing.Point(2, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(121, 113)
        Me.Panel3.TabIndex = 51
        '
        'ShowTutBtn
        '
        Me.ShowTutBtn.ForeColor = System.Drawing.Color.Black
        Me.ShowTutBtn.Location = New System.Drawing.Point(2, 438)
        Me.ShowTutBtn.Name = "ShowTutBtn"
        Me.ShowTutBtn.Size = New System.Drawing.Size(122, 36)
        Me.ShowTutBtn.TabIndex = 52
        Me.ShowTutBtn.Text = "Show Tutorial"
        Me.ShowTutBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ResetBtn.ForeColor = System.Drawing.Color.Red
        Me.ResetBtn.Location = New System.Drawing.Point(2, 377)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(121, 54)
        Me.ResetBtn.TabIndex = 53
        Me.ResetBtn.Text = "RESET Simulation"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mass(kg)"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Width(cm)"
        Me.ColumnHeader2.Width = 63
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Height(cm)"
        Me.ColumnHeader8.Width = 65
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Density(kg/m²)"
        Me.ColumnHeader3.Width = 91
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "X"
        Me.ColumnHeader4.Width = 42
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Y"
        Me.ColumnHeader5.Width = 31
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "X Velocity"
        Me.ColumnHeader6.Width = 69
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Y Velocity"
        Me.ColumnHeader7.Width = 66
        '
        'RectParticlesView
        '
        Me.RectParticlesView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.RectParticlesView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectParticlesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.RectParticlesView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectParticlesView.FullRowSelect = True
        Me.RectParticlesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.RectParticlesView.HideSelection = False
        Me.RectParticlesView.Location = New System.Drawing.Point(661, 480)
        Me.RectParticlesView.Name = "RectParticlesView"
        Me.RectParticlesView.Size = New System.Drawing.Size(539, 190)
        Me.RectParticlesView.TabIndex = 39
        Me.RectParticlesView.UseCompatibleStateImageBehavior = False
        Me.RectParticlesView.View = System.Windows.Forms.View.Details
        '
        'UpdateLists
        '
        Me.UpdateLists.Enabled = True
        Me.UpdateLists.Interval = 30
        '
        'SimForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1217, 671)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.ShowTutBtn)
        Me.Controls.Add(Me.DeleteModeBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.RectParticlesView)
        Me.Controls.Add(Me.CircleParticlesView)
        Me.Controls.Add(Me.DrawingSurface)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "SimForm"
        Me.Text = "-"
        CType(Me.DrawingSurface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadiusNumericBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircMassNumericBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GravitySlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimSpeedSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RectMassNumericBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthNumericBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightNumericBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CoRSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawingSurface As PictureBox
    Friend WithEvents SimTimer As Timer
    Friend WithEvents StartBtn As Button
    Friend WithEvents AddCircleBtn As Button
    Friend WithEvents AddRectangleBtn As Button
    Friend WithEvents RadiusLbl As Label
    Friend WithEvents RadiusNumericBox As NumericUpDown
    Friend WithEvents CircMassNumericBox As NumericUpDown
    Friend WithEvents CircMassLbl As Label
    Friend WithEvents massheader As ColumnHeader
    Friend WithEvents Sizeheader As ColumnHeader
    Friend WithEvents densityheader As ColumnHeader
    Friend WithEvents xheader As ColumnHeader
    Friend WithEvents yheader As ColumnHeader
    Friend WithEvents xvelocityheader As ColumnHeader
    Friend WithEvents yvelocityheader As ColumnHeader
    Friend WithEvents GravitySlider As TrackBar
    Friend WithEvents GravityLabel As Label
    Friend WithEvents SimSpeedSlider As TrackBar
    Friend WithEvents TimeSliderLabel As Label
    Private WithEvents CircleParticlesView As ListView
    Friend WithEvents RectMassNumericBox As NumericUpDown
    Friend WithEvents RectMassLbl As Label
    Friend WithEvents WidthNumericBox As NumericUpDown
    Friend WithEvents RectWidthLbl As Label
    Friend WithEvents HeightNumericBox As NumericUpDown
    Friend WithEvents RectHeightLbl As Label
    Friend WithEvents DeleteModeBtn As Button
    Friend WithEvents IsfixedCheckedBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CoRLbl As Label
    Friend WithEvents CoRSlider As TrackBar
    Friend WithEvents ShowTutBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Private WithEvents RectParticlesView As ListView
    Friend WithEvents UpdateLists As Timer
End Class
