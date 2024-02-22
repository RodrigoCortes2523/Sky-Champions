Public Class player
    Private lives As Integer = 3
    Private isAlive As Boolean
    Private speed As Integer = 25
    Private score As Integer
    Private trophies As Integer
    Private seconds As Integer
    Private minutes As Integer

    Public Property alive As Boolean
        Get
            Return isAlive
        End Get
        Set(value As Boolean)
            isAlive = value
        End Set
    End Property

    Public Property playerSpeed As Integer
        Get
            Return speed
        End Get
        Set(value As Integer)
            speed = value
        End Set
    End Property

    Public Property playerLives As Integer
        Get
            Return lives
        End Get
        Set(value As Integer)
            lives = value
        End Set
    End Property

    Public Property playerScore As Integer
        Get
            Return score
        End Get
        Set(value As Integer)
            score = value
        End Set
    End Property

    Public Property playerTrophies As Integer
        Get
            Return trophies
        End Get
        Set(value As Integer)
            trophies = value
        End Set
    End Property

    Public Property playerSeconds As Integer
        Get
            Return seconds
        End Get
        Set(value As Integer)
            seconds = value
        End Set
    End Property

    Public Property playerMinutes As Integer
        Get
            Return minutes
        End Get
        Set(value As Integer)
            minutes = value
        End Set
    End Property

    Public Function summary() As String
        Dim sum As String = ""

        If isAlive = False Then
            loseScreen()
        Else
            winScreen()
        End If

        sum = score
        Return sum

    End Function

    Private Sub loseScreen()
        GameOverScreen.endLabel.Text = "Game Over"
        GameOverScreen.endScoreLabel.Text = score
        GameOverScreen.endTimeLabel.Text = Format(minutes, "00:") & Format(seconds, "00")
        GameOverScreen.endTrophyLabel.Text = trophies
        Form1.highScoreLabel.Text = score
    End Sub

    Private Sub winScreen()
        GameOverScreen.endLabel.Text = "Level Complete"
        GameOverScreen.endScoreLabel.Text = score
        GameOverScreen.endTimeLabel.Text = Format(minutes, "00:") & Format(seconds, "00")
        GameOverScreen.endTrophyLabel.Text = trophies
        Form1.highScoreLabel.Text = score

        GameOverScreen.Size = New Size(500, 359)
        GameOverScreen.shopButton.Location = New Point(109, 244)
        GameOverScreen.gameOverExitButton.Location = New Point(248, 244)
        GameOverScreen.shopButton.Visible = True
        GameOverScreen.Text = "Level Complete"
    End Sub

End Class
