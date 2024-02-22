Public Class Game
    Dim player1 As New player
    Public randomGen As New Random

    Dim bulletSpeed As Integer = 25
    Dim baseHealth As Integer = 300
    Dim stage1, stage2, stage3, stage4 As Boolean
    Dim explosionCounter As Integer = 0
    Dim selectedEnemy As Rectangle

    Dim cloud1 As Image = My.Resources.cloud1
    Dim heart As Image = My.Resources.Heart
    Dim bg As Image = My.Resources.sky
    Dim bTrophy As Image = My.Resources.bronze
    Dim sTrophy As Image = My.Resources.silver
    Dim enemyImage As Image = My.Resources.enemy
    Dim heart2 As Image = My.Resources.heart2
    Dim explosionArray() As Image = {My.Resources._0001, My.Resources._0002, My.Resources._0003, My.Resources._0004, My.Resources._0005, My.Resources._0006,
        My.Resources._0007, My.Resources._0008, My.Resources._0009, My.Resources._0010, My.Resources._0011, My.Resources._0012, My.Resources._0013, My.Resources._0014,
        My.Resources._0015, My.Resources._0016, My.Resources._0017, My.Resources._0018, My.Resources._0019, My.Resources._0020, My.Resources._0021}

    Dim bulletFired, healthCreated, enemyHit As Boolean
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createClouds()
        createBronzeTrophy()
        createNewEnemies()
        tmrEnemy.Enabled = True
    End Sub

    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                tmrLeft.Start()
            Case Keys.D
                tmrRight.Start()
            Case Keys.Space
                If bulletFired = False Then
                    createBullet()
                    bulletFired = True
                End If
        End Select
    End Sub

    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.A
                tmrLeft.Stop()
            Case Keys.D
                tmrRight.Stop()
        End Select
    End Sub
    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim position As Point = playerPictureBox.Location
        position.X += player1.playerSpeed
        playerPictureBox.Location = position
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim position As Point = playerPictureBox.Location
        position.X -= player1.playerSpeed
        playerPictureBox.Location = position
    End Sub

    Private Sub tmrEnemy_Tick(sender As Object, e As EventArgs) Handles tmrEnemy.Tick 'main game loop
        collison()
        bulletCollision()
        increaseDifficulty()
        upgrades()
        changeEnemySpeed()

        If bulletPictureBox.Location.Y <= 0 Then
            resetBullet()
        End If

        If stage4 = True Then
            Shop.shopTrophyLabel.Text = player1.playerTrophies
            Me.Close()
            player1.alive = True
            player1.summary()
            GameOverScreen.Show()
        End If
    End Sub

    Private Sub collison()

        'check enemy collision
        For i As Integer = 0 To newEnemies.Length - 1
            If newEnemies(i).enemyRec.IntersectsWith(playerPictureBox.Bounds) Then
                resetNewEnemy(i)
                player1.playerLives -= 1
                upgradeLabel.ForeColor = Color.Red
                upgradeLabel.Text = "Collision"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
                Exit For
            End If
        Next

        'check trophy collision
        For i As Integer = 0 To bronzeTrophy.Length - 1
            If bronzeTrophy(i).powerRec.IntersectsWith(playerPictureBox.Bounds) Then
                resetBronzeTrophy(i)
                player1.playerTrophies += 1
                trophyLabel.Text = player1.playerTrophies
                upgradeLabel.ForeColor = Color.Gold
                upgradeLabel.Text = "+Trophy"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
                Exit For
            End If
        Next

        'check health pack collision
        If healthCreated = True Then
            If playerPictureBox.Bounds.IntersectsWith(healthPack.powerRec) Then
                player1.playerLives += 1
                resetHealthPack()
                upgradeLabel.ForeColor = Color.Green
                upgradeLabel.Text = "+Extra Life"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
            End If
        End If

        If player1.playerLives < 0 Then
            Me.Close()
            player1.alive = False
            player1.summary()
            GameOverScreen.Show()
            tmrScore.Stop()
        End If
    End Sub

    Private Sub changeEnemySpeed()
        For i As Integer = 0 To newEnemies.Length - 1
            If stage1 = True Then
                newEnemies(i).enemySpeed = randomGen.NextInt64(11, 15)
            ElseIf stage2 = True Then
                newEnemies(i).enemySpeed = randomGen.NextInt64(15, 20)
            ElseIf stage3 = True Then
                newEnemies(i).enemySpeed = randomGen.NextInt64(25, 30)
            Else
                newEnemies(i).enemySpeed = newEnemies(i).enemySpeed
            End If
        Next
    End Sub

    Private Sub tmrScore_Tick(sender As Object, e As EventArgs) Handles tmrScore.Tick
        timeLabel.Text = Format(player1.playerMinutes, "00:") & Format(player1.playerSeconds, "00")
        player1.playerSeconds += 1
        If player1.playerSeconds > 59 Then
            player1.playerSeconds = 0
            player1.playerMinutes += 1
        End If
    End Sub

    Private Sub increaseDifficulty()
        If player1.playerSeconds = 10 And player1.playerMinutes = 0 Then
            BackColor = Color.DarkCyan
            stage1 = True
            createHealthPack()
            healthCreated = True
        ElseIf player1.playerSeconds = 20 And player1.playerMinutes = 0 Then
            BackColor = Color.DarkBlue
            stage1 = False
            stage2 = True
        ElseIf player1.playerSeconds = 30 And player1.playerMinutes = 0 Then
            BackColor = Color.DarkRed
            stage2 = False
            stage3 = True
        ElseIf player1.playerSeconds = 40 And player1.playerMinutes = 0 Then
            stage3 = False
            stage4 = True
        End If
    End Sub

    Private Sub gamePaint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        'healpack draw
        If healthCreated = True Then
            If healthCreated = True And healthPack.powerRec.Location.Y >= 655 Then
                resetHealthPack()
            End If
            e.Graphics.DrawImage(heart, healthPack.powerX, healthPack.powerY, 25, 25)
        End If

        'clouds draw
        For i As Integer = 0 To clouds.Length - 1
            e.Graphics.DrawImage(cloud1, clouds(i).powerX, clouds(i).powerY, 125, 125)
        Next

        For i As Integer = 0 To clouds.Length - 1
            If clouds(i).powerRec.Location.Y >= 655 Then
                resetClouds()
                e.Graphics.DrawImage(cloud1, clouds(0).powerX, clouds(0).powerY, 125, 125)
            End If
        Next

        'trophy draw
        For i As Integer = 0 To bronzeTrophy.Length - 1
            e.Graphics.DrawImage(bTrophy, bronzeTrophy(i).powerX, bronzeTrophy(i).powerY, 41, 25)
        Next

        For i As Integer = 0 To bronzeTrophy.Length - 1
            If bronzeTrophy(i).powerRec.Location.Y >= 655 Then
                resetBronzeTrophy(i)
                e.Graphics.DrawImage(bTrophy, bronzeTrophy(i).powerX, bronzeTrophy(i).powerY, 41, 25)
            End If
        Next

        'enemy draw
        For i As Integer = 0 To newEnemies.Length - 1
            e.Graphics.DrawImage(enemyImage, newEnemies(i).enemyX, newEnemies(i).enemyY, 100, 85)
        Next

        For i As Integer = 0 To newEnemies.Length - 1
            If newEnemies(i).enemyRec.Location.Y >= 655 Then
                resetNewEnemy(i)
                subtractBaseHealth()
                e.Graphics.DrawImage(enemyImage, newEnemies(i).enemyX, newEnemies(i).enemyY, 100, 85)
            End If
        Next

        'explosionDraw
        If enemyHit = True Then
            Select Case explosionCounter
                Case explosionCounter
                    e.Graphics.DrawImage(explosionArray(explosionCounter), selectedEnemy.Location.X, selectedEnemy.Location.Y, 100, 100)
            End Select
        End If

        'draw player heart lives
        Select Case player1.playerLives
            Case >= 4
                e.Graphics.DrawImage(heart2, 650, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 700, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 750, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 650, 82, 50, 50)
            Case 3
                e.Graphics.DrawImage(heart2, 650, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 700, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 750, 32, 50, 50)
            Case 2
                e.Graphics.DrawImage(heart2, 650, 32, 50, 50)
                e.Graphics.DrawImage(heart2, 700, 32, 50, 50)
            Case 1
                e.Graphics.DrawImage(heart2, 650, 32, 50, 50)
        End Select
    End Sub

    Private Sub subtractBaseHealth()
        baseHealth -= 5
        baseHealthLabel.Text = baseHealth

        If baseHealth <= 0 Then
            Me.Close()
            player1.alive = False
            player1.summary()
            GameOverScreen.Show()
        End If
    End Sub

    Private Sub tmrCloud_Tick(sender As Object, e As EventArgs) Handles tmrCloud.Tick 'object move timer
        If healthCreated = True Then
            moveHealthPack()
        End If
        moveClouds()
        moveBronzeTrophy()
        moveNewEnemies()
        Refresh()
    End Sub

    Private Sub createBullet()
        bulletPictureBox.Location = New Point(playerPictureBox.Location.X + 35, playerPictureBox.Location.Y - 25)
        bulletPictureBox.Visible = True
        tmrBullet.Start()
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        Dim position As Point = bulletPictureBox.Location
        position.Y -= bulletSpeed
        bulletPictureBox.Location = position
    End Sub

    Private Sub bulletCollision()
        For i As Integer = 0 To newEnemies.Length - 1
            If bulletPictureBox.Bounds.IntersectsWith(newEnemies(i).enemyRec) Then
                selectedEnemy = newEnemies(i).enemyRec
                enemyHit = True
                resetBullet()
                player1.playerScore += 1
                scoreLabel.Text = player1.playerScore
                resetNewEnemy(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub resetBullet()
        bulletPictureBox.Visible = False
        bulletPictureBox.Location = New Point(1000, 1000)
        bulletFired = False
    End Sub

    Public Sub upgrades()
        Select Case player1.playerScore
            Case 10
                bulletSpeed = 50
                upgradeLabel.ForeColor = Color.White
                upgradeLabel.Text = "+Bullet Speed"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
            Case 20
                player1.playerSpeed = 35
                upgradeLabel.ForeColor = Color.White
                upgradeLabel.Text = "+Plane Speed"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
            Case 30
                'add upgrade
                bulletSpeed = 75
                upgradeLabel.ForeColor = Color.White
                upgradeLabel.Text = "Max Bullet Speed"
                upgradeLabel.Visible = True
                tmrUpgradeLabel.Start()
        End Select
    End Sub

    Private Sub tmrUpgradeLabel_Tick(sender As Object, e As EventArgs) Handles tmrUpgradeLabel.Tick
        upgradeLabel.Visible = False
        tmrUpgradeLabel.Stop()
    End Sub

    Private Sub tmrExplosion_Tick(sender As Object, e As EventArgs) Handles tmrExplosion.Tick
        If explosionCounter = 20 Then
            explosionCounter = 0
            enemyHit = False
        End If
        explosionCounter += 1
    End Sub

End Class