Public Class enemy
    Private image As Image
    Private speed As Integer
    Private x As Integer
    Private y As Integer
    Private rec As Rectangle
    Private location As Point

    Public Property enemyImage As Image
        Get
            Return image
        End Get
        Set(value As Image)
            image = value
        End Set
    End Property

    Public Property enemySpeed As Integer
        Get
            Return speed
        End Get
        Set(value As Integer)
            speed = value
        End Set
    End Property

    Public Property enemyX As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            x = value
        End Set
    End Property

    Public Property enemyY As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property
    Public Property enemyRec As Rectangle
        Get
            Return rec
        End Get
        Set(value As Rectangle)
            rec = value
        End Set
    End Property

    Public Property enemyLocation As Point
        Get
            Return location
        End Get
        Set(value As Point)
            location = value
        End Set
    End Property

End Class
