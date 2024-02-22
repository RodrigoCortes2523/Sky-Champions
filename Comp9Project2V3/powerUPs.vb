Public Class powerUPs
    Private location As Point
    Private rec As Rectangle
    Private speed As Integer
    Private image As Image
    Private x As Integer
    Private y As Integer

    Public Property powerLocation As Point
        Get
            Return location
        End Get
        Set(value As Point)
            location = value
        End Set
    End Property

    Public Property powerSpeed As Integer
        Get
            Return speed
        End Get
        Set(value As Integer)
            speed = value
        End Set
    End Property

    Public Property powerY As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property

    Public Property powerX As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            x = value
        End Set
    End Property

    Public Property powerRec As Rectangle
        Get
            Return rec
        End Get
        Set(value As Rectangle)
            rec = value
        End Set
    End Property

End Class
