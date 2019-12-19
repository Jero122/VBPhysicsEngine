Public Class Vector
    'Private fields
    Private pxCord As Double
    Private pyCord As Double
    'Constructor
    Public Sub New(ByVal x As Double, ByVal y As Double)
        pxCord = x
        pyCord = y
    End Sub
    'Public properties
    Public Property xCord() As Double
        Get
            Return pxCord
        End Get
        Set(value As Double)
            pxCord = value
        End Set
    End Property
    Public Property yCord() As Double
        Get
            Return pyCord
        End Get
        Set(value As Double)
            pyCord = value
        End Set
    End Property
    'Shared Methods
    Shared Function rotate(ByVal Vector1 As Vector, ByVal theta As Double) As Vector 'applies the rotational matrix to a vector with a specified angle.
        Return New Vector(Vector1.xCord * Math.Cos(theta) - Vector1.yCord * Math.Sin(theta), Vector1.xCord * Math.Sin(theta) + Vector1.yCord * Math.Cos(theta))
    End Function
    Shared Function Magnitude(ByVal Vector1 As Vector, ByVal Vector2 As Vector) As Double 'Measures the distance between two vector points
        Return Math.Abs(Math.Sqrt(((Vector1.xCord - Vector2.xCord) * (Vector1.xCord - Vector2.xCord)) + ((Vector1.yCord - Vector2.yCord) * (Vector1.yCord - Vector2.yCord))))
    End Function
    Shared Function Magnitude(ByVal Vector1 As Vector) As Double 'Measures the distance between the origin and the vector point
        Return Math.Abs(Math.Sqrt(((Vector1.xCord) * (Vector1.xCord)) + ((Vector1.yCord) * (Vector1.yCord))))
    End Function
    Shared Function MagnitudeSquared(ByVal Vector1 As Vector, ByVal Vector2 As Vector) As Double 'Avoids Sqrt for the distance between two points, used in collision detection
        Return Math.Abs(((Vector1.xCord - Vector2.xCord) * (Vector1.xCord - Vector2.xCord)) + ((Vector1.yCord - Vector2.yCord) * (Vector1.yCord - Vector2.yCord)))
    End Function
    Shared Function MagnitudeSquared(ByVal Vector1 As Vector) As Double 'Avoids Sqrt for the distance between the origin and a point
        Return Math.Abs(((Vector1.xCord) * (Vector1.xCord)) + ((Vector1.yCord) * (Vector1.yCord)))
    End Function
    Shared Function Normalise(ByVal Vector1 As Vector) As Vector ' Returns a vector with magnitude 1 but same direction as the vector passed in.
        Dim magnitude = Vector.Magnitude(Vector1)
        Return New Vector(Vector1.xCord / magnitude, Vector1.yCord / magnitude)
    End Function
    Shared Function Normalise(ByVal Vector1 As Vector, ByVal vector2 As Vector) As Vector 'Returns a vector with magnitude 1 but same direction as the vectors passed in.
        Dim magnitude = Vector.Magnitude(Vector1, vector2)
        Return New Vector((vector2.xCord - Vector1.xCord) / magnitude, (vector2.yCord - Vector1.yCord) / magnitude)
    End Function
    'Operator Overloading
    Shared Operator /(ByVal Vector1 As Vector, ByVal Scalar1 As Double)
        Return New Vector(Vector1.xCord / Scalar1, Vector1.yCord / Scalar1)
    End Operator
    Shared Operator *(ByVal vector1 As Vector, ByVal Scalar1 As Double)
        'There are two * overloads because of the order of the arguements, one is used for scalar * vector and the other is used for vector * scalar.
        'While the order Of input Is Not important For the maths,
        'It is important for defensive programming as a line of code that passes in (scalar, vector) would throw an error when it logically shouldn't
        Return New Vector(vector1.xCord * Scalar1, vector1.yCord * Scalar1)
    End Operator
    Shared Operator *(ByVal Scalar1 As Double, ByVal vector1 As Vector)
        Return New Vector(vector1.xCord * Scalar1, vector1.yCord * Scalar1)
    End Operator
    Shared Operator +(ByVal vector1 As Vector, ByVal vector2 As Vector)
        Return New Vector(vector1.xCord + vector2.xCord, vector1.yCord + vector2.yCord)
    End Operator
    Shared Operator -(ByVal vector1 As Vector, ByVal vector2 As Vector)
        Return New Vector(vector1.xCord - vector2.xCord, vector1.yCord - vector2.yCord)
    End Operator
End Class
