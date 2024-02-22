<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOverScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.endLabel = New System.Windows.Forms.Label()
        Me.endScoreLabel = New System.Windows.Forms.Label()
        Me.endTimeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.endTrophyLabel = New System.Windows.Forms.Label()
        Me.gameOverExitButton = New System.Windows.Forms.Button()
        Me.shopButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(60, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Time"
        '
        'endLabel
        '
        Me.endLabel.AutoSize = True
        Me.endLabel.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.endLabel.Location = New System.Drawing.Point(70, 9)
        Me.endLabel.Name = "endLabel"
        Me.endLabel.Size = New System.Drawing.Size(223, 46)
        Me.endLabel.TabIndex = 1
        Me.endLabel.Text = "Game Over"
        '
        'endScoreLabel
        '
        Me.endScoreLabel.AutoSize = True
        Me.endScoreLabel.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.endScoreLabel.ForeColor = System.Drawing.Color.White
        Me.endScoreLabel.Location = New System.Drawing.Point(234, 114)
        Me.endScoreLabel.Name = "endScoreLabel"
        Me.endScoreLabel.Size = New System.Drawing.Size(64, 20)
        Me.endScoreLabel.TabIndex = 2
        Me.endScoreLabel.Text = "Label4"
        '
        'endTimeLabel
        '
        Me.endTimeLabel.AutoSize = True
        Me.endTimeLabel.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.endTimeLabel.ForeColor = System.Drawing.Color.White
        Me.endTimeLabel.Location = New System.Drawing.Point(234, 158)
        Me.endTimeLabel.Name = "endTimeLabel"
        Me.endTimeLabel.Size = New System.Drawing.Size(64, 20)
        Me.endTimeLabel.TabIndex = 2
        Me.endTimeLabel.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(60, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Trophies:"
        '
        'endTrophyLabel
        '
        Me.endTrophyLabel.AutoSize = True
        Me.endTrophyLabel.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.endTrophyLabel.ForeColor = System.Drawing.Color.White
        Me.endTrophyLabel.Location = New System.Drawing.Point(234, 201)
        Me.endTrophyLabel.Name = "endTrophyLabel"
        Me.endTrophyLabel.Size = New System.Drawing.Size(64, 20)
        Me.endTrophyLabel.TabIndex = 2
        Me.endTrophyLabel.Text = "Label4"
        '
        'gameOverExitButton
        '
        Me.gameOverExitButton.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.greyButton
        Me.gameOverExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gameOverExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gameOverExitButton.FlatAppearance.BorderSize = 0
        Me.gameOverExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gameOverExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gameOverExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gameOverExitButton.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gameOverExitButton.Location = New System.Drawing.Point(109, 244)
        Me.gameOverExitButton.Name = "gameOverExitButton"
        Me.gameOverExitButton.Size = New System.Drawing.Size(133, 64)
        Me.gameOverExitButton.TabIndex = 3
        Me.gameOverExitButton.TabStop = False
        Me.gameOverExitButton.Text = "Exit"
        Me.gameOverExitButton.UseVisualStyleBackColor = True
        '
        'shopButton
        '
        Me.shopButton.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.greyButton
        Me.shopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shopButton.FlatAppearance.BorderSize = 0
        Me.shopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.shopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shopButton.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.shopButton.Location = New System.Drawing.Point(248, 244)
        Me.shopButton.Name = "shopButton"
        Me.shopButton.Size = New System.Drawing.Size(133, 64)
        Me.shopButton.TabIndex = 3
        Me.shopButton.TabStop = False
        Me.shopButton.Text = "Shop"
        Me.shopButton.UseVisualStyleBackColor = True
        Me.shopButton.Visible = False
        '
        'GameOverScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(374, 320)
        Me.Controls.Add(Me.shopButton)
        Me.Controls.Add(Me.gameOverExitButton)
        Me.Controls.Add(Me.endTrophyLabel)
        Me.Controls.Add(Me.endTimeLabel)
        Me.Controls.Add(Me.endScoreLabel)
        Me.Controls.Add(Me.endLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GameOverScreen"
        Me.Text = "GameOverScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents endLabel As Label
    Friend WithEvents endScoreLabel As Label
    Friend WithEvents endTimeLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents endTrophyLabel As Label
    Friend WithEvents gameOverExitButton As Button
    Friend WithEvents shopButton As Button
End Class
