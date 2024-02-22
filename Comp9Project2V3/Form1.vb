Public Class Form1
    Private Sub controlsButton_Click(sender As Object, e As EventArgs) Handles controlsButton.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Game.Show()
        'Me.Hide()
    End Sub

    Private Sub controlsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles controlsButton.MouseDown
        controlsButton.BackgroundImage = My.Resources.greyButtonPressed
    End Sub

    Private Sub controlsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles controlsButton.MouseUp
        controlsButton.BackgroundImage = My.Resources.greyButton
    End Sub

    Private Sub startButton_MouseUp(sender As Object, e As MouseEventArgs) Handles startButton.MouseUp
        startButton.BackgroundImage = My.Resources.greenButton
    End Sub

    Private Sub startButton_MouseDown(sender As Object, e As MouseEventArgs) Handles startButton.MouseDown
        startButton.BackgroundImage = My.Resources.greenButtonPressed
    End Sub
End Class
