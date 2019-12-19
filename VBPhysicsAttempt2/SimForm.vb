Public Class SimForm
    'These variables are global as they need to be used by multiple event handlers, which can't have additional arguements.
    Private Shared Spawning As Boolean = False
    Dim DeleteMode As Boolean = False
    Private Sub SimForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint = True And ControlStyles.UserPaint = True And ControlStyles.OptimizedDoubleBuffer = True, True) 'To reduce flicker when drawing
        'Label values are initialised here instead of on the form as if the default value for gravity, sim speed or CoR was changedin the designer in the future, the labels would be updated automatically.
        GravityLabel.Text = ("Acceleration due to gravity:" & GravitySlider.Value / 10)
        TimeSliderLabel.Text = ("Simulation Speed:" & Math.Round(CDbl(SimSpeedSlider.Value / 60), 2) & " x slower")
        CoRLbl.Text = "Collisions CoR: " & CoRSlider.Value / 100
    End Sub
    Private Sub SimTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles SimTimer.Tick
        DrawingSurface.Invalidate() 'Invalidating the DrawingSurface picturebox causes it's paint event to run
    End Sub
    Private Sub UpdateLists_Tick(sender As Object, e As EventArgs) Handles UpdateLists.Tick '30x slower than the sim timer to update the listviews less frequently to avoid flicker
        'An interval of 30ms instead of 1ms is a large enough difference to stop the flicker without making it visible that the listviews update with a delay since the delay is relatively small for us to notice.
        'Implemented during evaluation
        UpdateListViews()
    End Sub
    Private Sub DrawingSurface_Paint(sender As Object, e As PaintEventArgs) Handles DrawingSurface.Paint
        Simulator.StepUp(e) 'Simulation loop, painteventargs is passed through as particle classes will be responsible for painting themselves.
    End Sub
#Region "MouseEvents"
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DrawingSurface.MouseDown
        For i = 0 To Simulator.particles.Count - 1
            Dim particle As AbstractShape = Simulator.particles(i)
            If TypeOf particle Is CircleParticle Then
                Dim TempCircle As CircleParticle = particle
                Dim distance = ((TempCircle.Position.xCord + TempCircle.Radius - e.X) * (TempCircle.Position.xCord + TempCircle.Radius - e.X)) + ((TempCircle.Position.yCord + TempCircle.Radius - e.Y) * (TempCircle.Position.yCord + TempCircle.Radius - e.Y)) 'Distance between the circle's centre and the cursor's x and y position
                If distance < (TempCircle.Radius * TempCircle.Radius) And e.Button = Windows.Forms.MouseButtons.Right Then ' if this distance is less than the diameter of the circle, then the cursor MUST be in the circle. Right clicks are used for deleting particle and dragging them around
                    If DeleteMode = True Then 'If deletemode is true then particles will be deleted
                        Simulator.particles.Remove(TempCircle) 'Particle is removed from particles arraylist
                        DrawingSurface.Invalidate() 'This is called again to visually remove the particle
                        UpdateListViews() 'This is called again to update the listview, else the particle will stil remain in there.
                        Exit For ' particle is removed and the loop is exited
                    End If
                    TempCircle.BeingDragged = True 'if not in deletemode, then the particle that has the cursor over it is put into moving mode, allowing the MouseMove event to drag it around.
                    TempCircle.velocity *= 0  'Velocity of the particle is multiplied by 0 as it has been "grabbed", it makes sense to remove its velocities.
                ElseIf e.Button = Windows.Forms.MouseButtons.Left And distance < TempCircle.Radius * TempCircle.Radius And Spawning = False Then 'Left clicks are used for applying a force.
                    TempCircle.BeingPushed = True 'Then a force is being applied and the MouseUp event will calculate the magnitude of the force.
                End If
            ElseIf TypeOf particle Is RectangleParticle Then
                Dim TempRect As RectangleParticle = particle
                If e.Y > TempRect.Position.yCord And e.Y < TempRect.Position.yCord + TempRect.Height And e.X > TempRect.Position.xCord And e.X < TempRect.Position.xCord + TempRect.Width And e.Button = Windows.Forms.MouseButtons.Right Then 'If the cursor's x and y positions are within the rectangles's boundaries
                    If DeleteMode = True Then
                        Simulator.particles.Remove(TempRect) 'Particle is removed from particles arraylist
                        DrawingSurface.Invalidate() 'This is called again to visually remove the particle
                        UpdateListViews() 'This is called again to update the listview, else the particle will stil remain in there.
                        Exit For ' particle is removed and the loop is exited
                    End If
                    If Spawning = False Then
                        TempRect.BeingDragged = True 'if not in deletemode, then the particle that has the cursor over it is put into moveing mode, allowing the MouseMove event to drag it around.
                        'Velocity of the particle is multiplied by 0 as it has been "grabbed", it makes sense to remove its velocities.
                        TempRect.velocity *= 0 'Rectangles are usually spawned as fixed so this line wouldnt do much. However, if rectangles weren't fixed in the future, this line would be important.
                    End If
                ElseIf e.Y > TempRect.Position.yCord And e.Y < TempRect.Position.yCord + TempRect.Height And e.X > TempRect.Position.xCord And e.X < TempRect.Position.xCord + TempRect.Width And e.Button = Windows.Forms.MouseButtons.Right And e.Button = Windows.Forms.MouseButtons.Left And TempRect.fixed = False Then 'Left click validation.
                    'Notice how BeingPushed is only set to true if TempRect.fixed = false, meaning only non fixed particles will be pushable, which at the moment do not exist. However, if in the future rectangle particles are spawned as nonfixed (rotating rectangles), then this line would be necessary.
                    TempRect.BeingPushed = True  'Then a force is being applied and the MouseUp event will calculate the magnitude of the force
                End If
            End If
        Next
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingSurface.MouseMove
        ''.radius = mouse offset to bring the cursor in the centre of the circle
        '' _Width / 2 and  _Height / 2 to bring the cursor to the centre of the rectangle
        For i = 0 To Simulator.particles.Count - 1
            'If rectangle or circle particles are being spawned
            If TypeOf Simulator.particles(i) Is CircleParticle And (Simulator.particles(i).Spawning = True Or Simulator.particles(i).BeingDragged = True) Then 'If a circle particle is being spawned, then particle follows mouse position.
                Dim TempCircleParticle As CircleParticle = Simulator.particles(i)
                TempCircleParticle.Position.xCord = CInt(e.X - TempCircleParticle.Radius)
                TempCircleParticle.Position.yCord = CInt(e.Y - TempCircleParticle.Radius)
            ElseIf TypeOf Simulator.particles(i) Is RectangleParticle And (Simulator.particles(i).Spawning = True Or Simulator.particles(i).BeingDragged = True) Then 'If a rectangle particle is being spawned, then particle follows mouse position.
                Dim TempRectParticle As RectangleParticle = Simulator.particles(i)
                TempRectParticle.Position.xCord = CInt(e.X - TempRectParticle.Width / 2)
                TempRectParticle.Position.yCord = CInt(e.Y - TempRectParticle.Height / 2)
            End If
        Next
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DrawingSurface.MouseUp
        For i = 0 To Simulator.particles.Count - 1
            Dim TempParticle As AbstractShape = Simulator.particles(i) 'As mouse click is released, if any particle is in spawning mode, it is toggled off.
            If TempParticle.Spawning = True Then
                TempParticle.Spawning = False
                Spawning = False
            ElseIf TempParticle.BeingPushed = True Then 'A force is applied
                TempParticle.force.xCord += (TempParticle.Position.xCord - e.X) * 10 'The magnitude of force is being multiplied by 10 to add a significant amount of force to push the partcle.
                TempParticle.force.yCord += (TempParticle.Position.yCord - e.Y) * 10
                TempParticle.BeingPushed = False
            ElseIf TempParticle.BeingDragged = True Then 'Same as the spawning mode, it toggles moving mode off.
                TempParticle.BeingDragged = False
            End If
        Next
    End Sub
#End Region
#Region "ButtonClicks"
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If StartBtn.Text = "Sim Mode: Paused" Then
            StartBtn.ForeColor = Color.Green
            StartBtn.Text = "Sim Mode: Running"
        Else
            StartBtn.ForeColor = Color.Red
            StartBtn.Text = "Sim Mode: Paused"
        End If
    End Sub
    Private Sub AddCircleBtn_Click(sender As Object, e As EventArgs) Handles AddCircleBtn.Click
        If RadiusNumericBox.Value > 0 And CircMassNumericBox.Value > 0 Then
            If Spawning = False Then
                Simulator.particles.Add(New CircleParticle(0, 0, RadiusNumericBox.Value, CircMassNumericBox.Value, IsfixedCheckedBox.CheckState, True, GetRandomColor()))
                Spawning = True
            Else 'Validation for spawning an additional particle without spawning the first
                MessageBox.Show("Please spawn your current object first!")
            End If
        Else 'Validation for spawning a particle without specifiying dimensions and mass
            MessageBox.Show("Please enter a suitable value for the mass and radius!")
        End If
    End Sub
    Private Sub AddRectangleBtn_Click(sender As Object, e As EventArgs) Handles AddRectangleBtn.Click
        If HeightNumericBox.Value > 0 And WidthNumericBox.Value > 0 And RectMassNumericBox.Value > 0 Then
            If Spawning = False Then
                Simulator.particles.Add(New RectangleParticle(0, 0, WidthNumericBox.Value, HeightNumericBox.Value, CircMassNumericBox.Value, True, True, GetRandomColor()))
                Spawning = True
            Else 'Validation for spawning an additional particle without spawning the first
                MessageBox.Show("Please spawn your current object first!")
            End If
        Else 'Validation for spawning a particle without specifiying dimensions and mass
            MessageBox.Show("Please enter a suitable value for the mass, width and height!")
        End If
    End Sub
    Private Sub DeleteModeBtn_Click(sender As Object, e As EventArgs) Handles DeleteModeBtn.Click 'Toggles deletemode, allowing particles to be deleted
        If DeleteMode = False Then 'toggles delete mode on
            DeleteMode = True
            DeleteModeBtn.ForeColor = Color.Red
            DeleteModeBtn.Text = "Mode: Deleting"
        ElseIf DeleteMode = True Then 'toggles delete mode off
            DeleteMode = False
            DeleteModeBtn.ForeColor = Color.Green
            DeleteModeBtn.Text = "Mode: Moving"
        End If
    End Sub
    Private Sub ShowTutBtn_Click(sender As Object, e As EventArgs) Handles ShowTutBtn.Click
        TutorialForm.Show()
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click 'Resets the entire simulation
        Simulator.particles.Clear() ' removes particles
        'these lines reset the values of the sliders and corresponding labels
        GravitySlider.Value = 98
        CoRSlider.Value = 50
        SimSpeedSlider.Value = 60
        GravityLabel.Text = ("Acceleration due to gravity:" & GravitySlider.Value / 10) 'The grav slider value is divided by 10 as sliders can't have decimal values, so to have a value of 9.8, the slider's value must euqal 98
        TimeSliderLabel.Text = ("Simulation Speed:" & Math.Round(CDbl(SimSpeedSlider.Value / 60), 2) & " x slower")
        CoRLbl.Text = "Collisions CoR: " & CoRSlider.Value / 100 'unlike gravity, CoR has 2 deicmal places to keep things more accurate, hence it needs to be divided by 100
        'Resets the buttons
        'StartBtn
        StartBtn.ForeColor = Color.Red
        StartBtn.Text = "Sim Mode: Paused"
        'DeleteModeBtn
        DeleteMode = False
        DeleteModeBtn.ForeColor = Color.Green
        DeleteModeBtn.Text = "Mode: Moving"
    End Sub
#End Region
    Private Sub UpdateListViews() 'Updates the listviews with information on particles
        CircleParticlesView.SuspendLayout() 'SuspendLayout and ResumeLayout are used at the start and end of this subroutine to make the refreshes as smooth as possible to avoid flicker. This method does not reduce flicker on its own but together with the UpdateLists timer, it makes a significant improvement.
        RectParticlesView.SuspendLayout()
        'removes all current partircles from list views
        CircleParticlesView.Items.Clear()
        RectParticlesView.Items.Clear()
        'adds particles again
        'Information s rounded down to whole numbers in the list views to make it easier for the user to read the information since a table full of decimals will appear unnecessarily cluttered.
        For Each particle In Simulator.particles
            Dim tempparticle As AbstractShape = particle
            Dim ListViewItem As ListViewItem = New ListViewItem(tempparticle.Mass.ToString)
            ListViewItem.ForeColor = tempparticle.Color
            If TypeOf tempparticle Is CircleParticle Then 'Adds information into the circle list view
                Dim Tempcirc As CircleParticle = tempparticle
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.Radius).ToString)
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.Density).ToString)
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.Position.xCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.Position.yCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.velocity.xCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(Tempcirc.velocity.yCord).ToString)
                ListViewItem.Tag = tempparticle
                CircleParticlesView.Items.Add(ListViewItem)
            Else 'Adds information into the rectangle list view
                Dim TempRect As RectangleParticle = tempparticle
                ListViewItem.SubItems.Add(Math.Round(TempRect.Width).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.Height).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.Density).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.Position.xCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.Position.yCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.velocity.xCord).ToString)
                ListViewItem.SubItems.Add(Math.Round(TempRect.velocity.yCord).ToString)
                ListViewItem.Tag = tempparticle
                RectParticlesView.Items.Add(ListViewItem)
            End If
        Next
        CircleParticlesView.ResumeLayout()
        RectParticlesView.ResumeLayout()
    End Sub
    Private Function GetRandomColor() As Color 'Function for generating a random colour to be used for particle outlines.
        Randomize()
        Dim RandomColor As Random = New Random()
        Return Color.FromArgb(RandomColor.Next(0, 256), RandomColor.Next(0, 256), RandomColor.Next(0, 256))
    End Function
    Private Sub SimSpeedSlider_Scroll(sender As Object, e As EventArgs) Handles SimSpeedSlider.Scroll
        TimeSliderLabel.Text = ("Simulation Speed:" & Math.Round(CDbl(SimSpeedSlider.Value / 60), 2) & " x slower")
    End Sub
    Private Sub GravitySlider_Scroll(sender As Object, e As EventArgs) Handles GravitySlider.Scroll
        GravityLabel.Text = ("Acceleration due to gravity:" & GravitySlider.Value / 10)
    End Sub
    Private Sub CoRSlider_Scroll(sender As Object, e As EventArgs) Handles CoRSlider.Scroll
        CoRLbl.Text = "Collisions CoR: " & CoRSlider.Value / 100
    End Sub
End Class