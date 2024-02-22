Public Class GameOverScreen
    Private Sub gameOverExitButton_Click(sender As Object, e As EventArgs) Handles gameOverExitButton.Click
        Me.Close()
    End Sub

    Private Sub shopButton_Click(sender As Object, e As EventArgs) Handles shopButton.Click
        Shop.Show()
        Me.Close()

        'open shop screen
    End Sub

End Class