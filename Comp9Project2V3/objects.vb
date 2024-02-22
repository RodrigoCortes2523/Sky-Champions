Public Module objects
    Dim random As New Random
    Public clouds(1) As powerUPs
    Public healthPack As powerUPs
    Public bronzeTrophy(2) As powerUPs
    Public newEnemies(3) As enemy

    Public Sub createClouds()
        For i As Integer = 0 To clouds.Length - 1
            clouds(i) = New powerUPs
            clouds(i).powerX = random.NextInt64(25, 700)
            clouds(i).powerY = random.NextInt64(0, 800)
            clouds(i).powerRec = New Rectangle(clouds(i).powerX, clouds(i).powerY, 125, 125)
            clouds(i).powerSpeed = 1
        Next
    End Sub

    Public Sub moveClouds()
        For i As Integer = 0 To clouds.Length - 1
            clouds(i).powerY += clouds(i).powerSpeed
            clouds(i).powerRec = New Rectangle(clouds(i).powerX, clouds(i).powerY, 125, 125)
        Next
    End Sub

    Public Sub resetClouds()
        For i As Integer = 0 To clouds.Length - 1
            clouds(i).powerX = random.NextInt64(25, 700)
            clouds(i).powerY = random.NextInt64(-150, 0)
            clouds(i).powerRec = New Rectangle(clouds(0).powerX, clouds(0).powerY, 125, 125)
        Next
    End Sub

    Public Sub createHealthPack()
        healthPack = New powerUPs
        healthPack.powerX = random.NextInt64(25, 500)
        healthPack.powerY = -25
        healthPack.powerRec = New Rectangle(healthPack.powerX, healthPack.powerY, 25, 25)
        healthPack.powerSpeed = 4
    End Sub

    Public Sub moveHealthPack()
        healthPack.powerY += healthPack.powerSpeed
        healthPack.powerRec = New Rectangle(healthPack.powerX, healthPack.powerY, 25, 25)
    End Sub

    Public Sub resetHealthPack()
        healthPack.powerX = random.NextInt64(25, 700)
        healthPack.powerY = -415
        healthPack.powerRec = New Rectangle(healthPack.powerX, healthPack.powerY, 125, 125)
    End Sub

    Public Sub createBronzeTrophy()
        For i As Integer = 0 To bronzeTrophy.Length - 1
            bronzeTrophy(i) = New powerUPs
            bronzeTrophy(i).powerX = random.NextInt64(25, 700)
            bronzeTrophy(i).powerY = random.NextInt64(-1000, 0)
            bronzeTrophy(i).powerRec = New Rectangle(bronzeTrophy(i).powerX, bronzeTrophy(i).powerY, 41, 25)
            bronzeTrophy(i).powerLocation = New Point(bronzeTrophy(i).powerX, bronzeTrophy(i).powerY)
            bronzeTrophy(i).powerSpeed = 4
        Next
    End Sub

    Public Sub moveBronzeTrophy()
        For i As Integer = 0 To bronzeTrophy.Length - 1
            bronzeTrophy(i).powerY += bronzeTrophy(i).powerSpeed
            bronzeTrophy(i).powerRec = New Rectangle(bronzeTrophy(i).powerX, bronzeTrophy(i).powerY, 41, 25)
        Next
    End Sub

    Public Sub resetBronzeTrophy(ByVal bTrophyNumber)
        bronzeTrophy(bTrophyNumber).powerX = random.NextInt64(25, 700)
        bronzeTrophy(bTrophyNumber).powerY = random.NextInt64(-150, 0)
        bronzeTrophy(bTrophyNumber).powerRec = New Rectangle(newEnemies(0).enemyX, newEnemies(0).enemyY, 41, 25)
    End Sub

    Public Sub createNewEnemies()
        For i As Integer = 0 To newEnemies.Length - 1
            newEnemies(i) = New enemy
            newEnemies(i).enemyX = random.NextInt64(25, 700)
            newEnemies(i).enemyY = random.NextInt64(-350, 0)
            newEnemies(i).enemyRec = New Rectangle(newEnemies(i).enemyX, newEnemies(i).enemyY, 100, 85)
            newEnemies(i).enemyLocation = New Point(newEnemies(i).enemyX, newEnemies(i).enemyY)
            newEnemies(i).enemySpeed = 10
        Next
    End Sub
    Public Sub moveNewEnemies()
        For i As Integer = 0 To newEnemies.Length - 1
            newEnemies(i).enemyY += newEnemies(i).enemySpeed
            newEnemies(i).enemyRec = New Rectangle(newEnemies(i).enemyX, newEnemies(i).enemyY, 100, 85)
        Next
    End Sub

    Public Sub resetNewEnemy(ByVal number As Integer)
        newEnemies(number).enemyX = random.NextInt64(25, 700)
        newEnemies(number).enemyY = random.NextInt64(-150, 0)
        newEnemies(number).enemyRec = New Rectangle(newEnemies(0).enemyX, newEnemies(0).enemyY, 100, 85)
    End Sub

End Module
