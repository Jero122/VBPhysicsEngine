Public Class CircleParticle
    Inherits AbstractShape
    'Private ReadOnly variables, encapsulated
    Private pBoundingBoxWidthHeight As Integer 'Since a boundingbox of a circle is a square, width and height variables are combined as they are same.
    Private pRadius As Integer
    'Constructor
    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal r As Double, ByVal mass As Double, ByVal isfixed As Boolean, ByVal Spawning As Boolean, ByVal color As Color)
        MyBase.New(x, y, mass, isfixed, mass / (Math.PI * ((r / 100) * (r / 100))), Spawning, color)
        pRadius = r
        pBoundingBoxWidthHeight = pRadius * 2
    End Sub
    'Methods
    Overloads Sub update(ByVal e As PaintEventArgs)
        draw(e)
        MyBase.update()
    End Sub
    Sub Draw(ByVal e As PaintEventArgs)
        Dim CollissionPen As New Pen(Color.Red)
        Dim VelocityPen As New Pen(Color.Blue)
        Dim VelocityPen2 As New Pen(Color.Red)
        Dim OutlinePen As New Pen(Me.Color, 2)
        e.Graphics.DrawEllipse(OutlinePen, CSng(Me.Position.xCord), CSng(Me.Position.yCord), CSng(Me.pBoundingBoxWidthHeight), CSng(Me.pBoundingBoxWidthHeight))
        e.Graphics.DrawLine(VelocityPen, CSng(Me.Position.xCord + Me.pRadius), CSng(Me.Position.yCord + Me.pRadius), CSng(Me.Position.xCord + Me.pRadius + Me.velocity.xCord), CSng(Me.Position.yCord + Me.pRadius + Me.velocity.yCord))
    End Sub
    'Public ReadOnly Properties
    Public ReadOnly Property Radius() As Integer
        Get
            Return pRadius
        End Get
    End Property
    Public ReadOnly Property BoundingBoxWidthHeight() As Integer
        Get
            Return pBoundingBoxWidthHeight
        End Get
    End Property
End Class