Public MustInherit Class Collider
    Public Shared Sub DetermineCollision(ByVal A As AbstractShape, ByVal B As AbstractShape) 'Determines which type of particles are being tested for collisions.
        Dim CoefficientOfRestitution As Single = SimForm.CoRSlider.Value / 100
        If TypeOf A Is RectangleParticle And TypeOf B Is RectangleParticle Then
            'As Rectangles are used as static objects, resolving collissions beetween them is pointless as I do want them to intersect, so users can create different shaped obstacles
            'Therefore, nothing happens.
        ElseIf TypeOf A Is CircleParticle And TypeOf B Is CircleParticle Then
            CirclevsCircle(A, B, CoefficientOfRestitution)
        ElseIf TypeOf A Is RectangleParticle And TypeOf B Is CircleParticle Then
            AABBvsCircle(A, B, CoefficientOfRestitution)
        ElseIf TypeOf A Is CircleParticle And TypeOf B Is RectangleParticle Then
            AABBvsCircle(B, A, CoefficientOfRestitution)
        End If
    End Sub
    Private Shared Sub AABBvsCircle(ByVal Rect As RectangleParticle, ByVal Circ As CircleParticle, ByVal CoefficientOfRestitution As Double) 'Circle vs rectangles
        Dim nearestX = Math.Max(Rect.Position.xCord, Math.Min(Circ.Position.xCord + Circ.Radius, Rect.Position.xCord + Rect.Width)) 'the closest point to the circle's center 
        Dim nearestY = Math.Max(Rect.Position.yCord, Math.Min(Circ.Position.yCord + Circ.Radius, Rect.Position.yCord + Rect.Height))
        Dim distance As Vector = New Vector(Circ.Position.xCord + Circ.Radius - nearestX, Circ.Position.yCord + Circ.Radius - nearestY)
        If Vector.MagnitudeSquared(distance) < Circ.Radius * Circ.Radius Then  'DistanceSquared is used here to avoid using math.sqrt, which is only used when a collision actually occurs. 
            'This Is the size Of one vector, hence one argument. If True, collission has occured.
            Dim CollisionDepth = Circ.Radius - Vector.Magnitude(distance) 'Sqrt is only used if the collision occurs to make an efficient solution.
            Dim DisplacementVector As Vector = (Vector.Normalise(distance) * CollisionDepth)
            'Static Resolution
            If Circ.fixed = False Then 'As fixed circles should be able to intersect particles, they will not be displaced.
                Circ.Position += DisplacementVector
            End If
            'Dynamic Resolution
            Dim normalOfDistance As Vector = New Vector(-distance.yCord, distance.xCord)
            Dim normalAngle = Math.Atan2(normalOfDistance.yCord, normalOfDistance.xCord)
            Dim incomingAngle = Math.Atan2(Circ.velocity.yCord, Circ.velocity.xCord)
            Dim theta = normalAngle - incomingAngle
            Circ.velocity = Vector.rotate(Circ.velocity, 2 * theta)
            If nearestY > Rect.Position.yCord And nearestY < Rect.Position.yCord + Rect.Height Then 'This only applies the CoR multiplication on the appropriate axis. 
                'If a circle Is rolling On top Of a rectangle, Then the CoR Is only applied To the vertical component.
                'This ensures that a circle is able to roll on top of a rectangle as otherwise, 
                'the CoR will be constantly be applied To the horizontal component Of the velocity When the circle Is rolling On top Of a rectangle As it Is always colliding,
                'leading to a very inaccurate result.
                Circ.velocity.xCord *= CoefficientOfRestitution
                Else
                    Circ.velocity.yCord *= CoefficientOfRestitution
            End If
        End If
    End Sub
    Private Shared Sub CirclevsCircle(ByVal A As CircleParticle, ByVal B As CircleParticle, ByVal CoefficientOfRestitution As Double)
        Dim TempRadiusVectorA As New Vector(A.Radius, A.Radius) 'Temporary vectors to hold the radii as a vector so the ycan be added to position
        Dim TempRadiusVectorB As New Vector(B.Radius, B.Radius)
        Dim distanceSquared As Double = Vector.MagnitudeSquared(A.Position + TempRadiusVectorA, B.Position + TempRadiusVectorB) 'DistanceSquared is used here to avoid using math.sqrt, 
        'which Is only used When a collision actually occurs. This Is the distance between two points, hence two arguments are passed in.
        Dim RadiiSum As Double = A.Radius + B.Radius
        If distanceSquared < (RadiiSum * RadiiSum) Then ' As we are using DistanceSquared, It has to be compared with RadiiSum Squared aswell
            Dim Distance As Double = Vector.Magnitude(A.Position + TempRadiusVectorA, B.Position + TempRadiusVectorB) 'The distance between the two circle's centres
            Dim overlap As Double = ((Distance - RadiiSum) * 0.5)
            'STATIC RESOLUTION
            If A.fixed = True Or B.fixed = True Then 'If a circle is fixed, it is not displaced, only the non-fixed circle is
                If A.fixed = True Then
                    A.velocity *= 0
                    B.Position += ((A.Position - B.Position) / Distance) * overlap
                Else
                    B.velocity *= 0
                    A.Position -= ((A.Position - B.Position) / Distance) * overlap
                End If
            Else 'If neither circle is fixed than both circles are displaced.
                A.Position -= ((A.Position - B.Position) / Distance) * overlap
                B.Position += ((A.Position - B.Position) / Distance) * overlap
            End If

            'The links below are the sources for equations used for dynamic Resolution.
            ''https://en.wikipedia.org/wiki/Elastic_collision
            ' https://youtu.be/LPzyNOHY3A4?t=1881
            'DYNAMIC RESOLUTION

            Dim normal As Vector = Vector.Normalise(A.Position, B.Position)
            Dim k As Vector = A.velocity - B.velocity
            Dim p = 2 * ((normal.xCord * k.xCord) + (normal.yCord * k.yCord)) / (A.Mass + B.Mass)
            A.velocity -= (normal * B.Mass) * p * CoefficientOfRestitution
            B.velocity += (normal * A.Mass) * p * CoefficientOfRestitution

            If A.BeingDragged = True Then 'Makes sure that the circle that is being dragged always has its velocities set to 0 as it is being manually dragged around.
                A.velocity *= 0
            ElseIf B.BeingDragged = True Then
                B.velocity *= 0
            End If
        End If
    End Sub
    Public Shared Sub BoundaryDetection(ByVal Particle As AbstractShape)
        Dim CircCoefficientOfRestitution As Single = SimForm.CoRSlider.Value / 100
        If TypeOf Particle Is CircleParticle And Particle.fixed = False Then ' As rectangle particles only exist to act as walls/ barriers, no boundary detection is needed for them,
            'however it can be implemented easily.
            Dim ParticleA As CircleParticle = Particle
            If ParticleA.Position.yCord + ParticleA.BoundingBoxWidthHeight >= SimForm.DrawingSurface.Height Then  'Bottom of Picturebox
                ParticleA.Position.yCord = SimForm.DrawingSurface.Height - ParticleA.BoundingBoxWidthHeight - 0.2 '-0.2 is the exta offset to make sure that
                ParticleA.velocity.yCord = ParticleA.velocity.yCord * -CircCoefficientOfRestitution
            ElseIf ParticleA.Position.yCord < 0 Then  'Top of Picturebox
                ParticleA.Position.yCord = 0
                ParticleA.velocity.yCord = ParticleA.velocity.yCord * -CircCoefficientOfRestitution
            ElseIf ParticleA.Position.xCord + ParticleA.BoundingBoxWidthHeight >= SimForm.DrawingSurface.Width Then  'right side of Picturebox
                ParticleA.Position.xCord = SimForm.DrawingSurface.Width - ParticleA.BoundingBoxWidthHeight - 0.2
                ParticleA.velocity.xCord = ParticleA.velocity.xCord * -CircCoefficientOfRestitution
            ElseIf ParticleA.Position.xCord <= 0 Then 'left side of Picturebox
                ParticleA.Position.xCord = 1
                ParticleA.velocity.xCord = ParticleA.velocity.xCord * -CircCoefficientOfRestitution
            End If
        ElseIf TypeOf Particle Is RectangleParticle Then
            ''Rectangle Boundary detection can go here if needed in the future.
        End If
    End Sub
End Class