Public MustInherit Class Simulator
    Public Shared particles As New ArrayList()
    Public Shared Sub StepUp(ByVal e As PaintEventArgs) ''The simulation loop
        For i = 0 To particles.Count - 1 'Loops through each particle, integrating their velocities ,
            'doing collisions checks And updating them.
            Dim Tempparticle As AbstractShape = particles(i)
            integrate(Tempparticle) 'Applies euler integration to particles.
            collisioncheck(Tempparticle) 'Quadratic loop as the collisioncheck sub itself is a loop.
            If TypeOf Tempparticle Is CircleParticle Then
                Dim TempCircle As CircleParticle = particles(i)
                TempCircle.update(e) 'The particle is painted in it's own class as the visual appearance of a particle is the particle's own property.
                'Hence, to maintain cohesion it is not painted in simulator or SimForm.
            ElseIf TypeOf Tempparticle Is RectangleParticle Then
                Dim TempRectangle As RectangleParticle = particles(i)
                TempRectangle.update(e)
            End If
            Collider.BoundaryDetection(Tempparticle) 'Boundary detection happens twice to ensure that after updating particles, 
            'they are inside the boundaries. This Is due to a bug that was found during implementation where
            'the particle would go outside of the boundaries if the value of acceleration due to gravity was too high.
        Next
    End Sub
    Private Shared Sub integrate(ByVal Tempparticle As AbstractShape) 'Euler Integration
        If Tempparticle.BeingDragged = False And Tempparticle.fixed = False And Tempparticle.Spawning = False Then
            Tempparticle.velocity += Tempparticle.Acceleration * GetDT()
            Tempparticle.Position += Tempparticle.velocity * GetDT()
        End If
    End Sub
    Private Shared Function GetDT()
        Dim timeStep As Double
        If SimForm.StartBtn.Text = "Sim Mode: Paused" Then
            Return 0 'rather than diabling the timer, which would stop everything, so particles could not be added, 
            'setting the timestep To 0 makes it so particles dont obey physics, which "pauses" the simulation without stopping everything.
            'The disadvantage of this is that the program would be consuming the computer's resources if it was paused this way rather than stopping the timer.
            'However, the advantage Is that it allows the user to add particles And manipulate them without simulating phyiscs.
        ElseIf SimForm.SimSpeedSlider.Value <> 60 Then
        timeStep = (1 / SimForm.SimSpeedSlider.Value) * 10
            Return timeStep
        Else
            timeStep = 1 / 6 'Default timestep
            Return timeStep
        End If
    End Function
    Private Shared Sub collisioncheck(ByVal Tempparticle As AbstractShape)
        Collider.BoundaryDetection(Tempparticle)
        For j = 0 To particles.Count - 1 'Quadratic loop as it is called inside a loop itself in StepUp.
            'Loops through every other particle And passes it into the collider class.
            Dim Tempparticle2 As AbstractShape = particles(j)
            If Tempparticle IsNot Tempparticle2 Then 'makes sure a collision test between the same particle does not occur.
                Collider.DetermineCollision(Tempparticle, Tempparticle2)
            End If
        Next
    End Sub
End Class