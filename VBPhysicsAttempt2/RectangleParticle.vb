Public Class RectangleParticle
    Inherits AbstractShape
    'Private ReadOnly variables, encapsulated
    Private pWidth As Integer
    Private pHeight As Integer
    'Constructor
    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal width As Double, ByVal height As Double, ByVal mass As Double, ByVal isfixed As Boolean, ByVal Spawning As Boolean, ByVal color As Color)
        MyBase.New(x, y, mass, isfixed, mass / (width * height), Spawning, color)
        Me.pWidth = width
        Me.pHeight = height
    End Sub
    'Methods
    Overloads Sub update(ByVal e As PaintEventArgs)
        Draw(e)
        MyBase.update()
    End Sub
    Sub Draw(ByVal e As PaintEventArgs)
        Dim CollissionPen As New Pen(Color.Red)
        Dim VelocityPen As New Pen(Color.Blue)
        Dim OutlinePen As New Pen(Me.Color, 2)
        e.Graphics.DrawRectangle(OutlinePen, CInt(Me.Position.xCord), CInt(Me.Position.yCord), CInt(Me.Width), CInt(Me.Height))
    End Sub
    'Public ReadOnly Properties
    Public ReadOnly Property Width() As Integer
        Get
            Return pWidth
        End Get
    End Property
    Public ReadOnly Property Height() As Integer
        Get
            Return pHeight
        End Get
    End Property
End Class