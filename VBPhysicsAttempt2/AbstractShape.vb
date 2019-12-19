Public MustInherit Class AbstractShape
    'Private ReadOnly variables, encapsulated
    Private pFixed As Boolean
    Private pMass As Integer
    Private Pcolor As Color
    Private  Pdensity As Double
    'Private ReadWrite variables, encapsulated
    'vectors
    Private pPosition As Vector
    Private pforce As New Vector(0, 0)
    Private pAcceleration As New Vector(0, 0)
    Private pvelocity As New Vector(0, 0)
    Private Shared pGravity As New Vector(0, 0)
    'booleans
    Private pSpawning As Boolean
    Private pBeingPushed As Boolean
    Private pDragged As Boolean = False
    'constructor
    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal m As Double, ByVal isfixed As Boolean, ByVal Density As Double, ByVal Spawning As Boolean, ByVal color As Color)
        Position = New Vector(x, y)
        pMass = m
        pFixed = isfixed
        pSpawning = Spawning
        BeingDragged = False
        Pcolor = color
        Pdensity = Density
    End Sub
    'Methods
    Public Sub update()
        pGravity.yCord = SimForm.GravitySlider.Value / 10
        Acceleration = (force / Mass) + Gravity ' Force = mass * acceleration. Therefore acceleration = Force/ mass. This is Newton's second law of motion.
        force *= 0 ' Force is set to 0 the force only exists while the ball is being pushed, once the ball is stopped being pushed, no force is applied, hence it 0
    End Sub
    'Public ReadOnly Properties
    Public ReadOnly Property Density() As Double
        Get
            Return Pdensity
        End Get
    End Property
    Public ReadOnly Property Color() As Color
        Get
            Return Pcolor
        End Get
    End Property
    Public ReadOnly Property Mass() As Integer
        Get
            Return pMass
        End Get
    End Property
    Public ReadOnly Property fixed() As Boolean
        Get
            Return pFixed
        End Get
    End Property
    'Public ReadWrite Properties
    Public Property Gravity() As Vector
        Get
            Return pGravity
        End Get
        Set(value As Vector)
            pGravity = value
        End Set
    End Property
    Public Property force() As Vector
        Get
            Return pforce
        End Get
        Set(value As Vector)
            pforce = value
        End Set
    End Property
    Public Property Acceleration() As Vector
        Get
            Return pAcceleration
        End Get
        Set(value As Vector)
            pAcceleration = value
        End Set
    End Property
    Public Property velocity() As Vector
        Get
            Return pvelocity
        End Get
        Set(value As Vector)
            pvelocity = value
        End Set
    End Property
    Public Property Position() As Vector
        Get
            Return pPosition
        End Get
        Set(value As Vector)
            pPosition = value
        End Set
    End Property
    Public Property Spawning() As Boolean
        Get
            Return pSpawning
        End Get
        Set(value As Boolean)
            pSpawning = value
        End Set
    End Property
    Public Property BeingPushed() As Boolean
        Get
            Return pBeingPushed
        End Get
        Set(value As Boolean)
            pBeingPushed = value
        End Set
    End Property
    Public Property BeingDragged() As Boolean
        Get
            Return pDragged
        End Get
        Set(value As Boolean)
            pDragged = value
        End Set
    End Property
End Class