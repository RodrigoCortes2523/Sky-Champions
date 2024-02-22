<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.playerPictureBox = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.bulletPictureBox = New System.Windows.Forms.PictureBox()
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.tmrCloud = New System.Windows.Forms.Timer(Me.components)
        Me.label4 = New System.Windows.Forms.Label()
        Me.baseHealthLabel = New System.Windows.Forms.Label()
        Me.upgradeLabel = New System.Windows.Forms.Label()
        Me.tmrUpgradeLabel = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trophyLabel = New System.Windows.Forms.Label()
        Me.tmrExplosion = New System.Windows.Forms.Timer(Me.components)
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bulletPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerPictureBox
        '
        Me.playerPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.playerPictureBox.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.jet
        Me.playerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.playerPictureBox.Location = New System.Drawing.Point(338, 526)
        Me.playerPictureBox.Name = "playerPictureBox"
        Me.playerPictureBox.Size = New System.Drawing.Size(78, 90)
        Me.playerPictureBox.TabIndex = 0
        Me.playerPictureBox.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 50
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 50
        '
        'tmrEnemy
        '
        Me.tmrEnemy.Interval = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(546, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lives:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Time:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.BackColor = System.Drawing.Color.Transparent
        Me.timeLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(101, -1)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(88, 33)
        Me.timeLabel.TabIndex = 5
        Me.timeLabel.Text = "00:00"
        '
        'tmrScore
        '
        Me.tmrScore.Enabled = True
        Me.tmrScore.Interval = 1000
        '
        'bulletPictureBox
        '
        Me.bulletPictureBox.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.bullet
        Me.bulletPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bulletPictureBox.Location = New System.Drawing.Point(372, 576)
        Me.bulletPictureBox.Name = "bulletPictureBox"
        Me.bulletPictureBox.Size = New System.Drawing.Size(10, 28)
        Me.bulletPictureBox.TabIndex = 6
        Me.bulletPictureBox.TabStop = False
        Me.bulletPictureBox.Visible = False
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Score:"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.scoreLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scoreLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.scoreLabel.Location = New System.Drawing.Point(101, 32)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(31, 33)
        Me.scoreLabel.TabIndex = 3
        Me.scoreLabel.Text = "0"
        '
        'tmrCloud
        '
        Me.tmrCloud.Enabled = True
        Me.tmrCloud.Interval = 50
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label4.Location = New System.Drawing.Point(546, -1)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(197, 33)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Base Health:"
        '
        'baseHealthLabel
        '
        Me.baseHealthLabel.AutoSize = True
        Me.baseHealthLabel.BackColor = System.Drawing.Color.Transparent
        Me.baseHealthLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.baseHealthLabel.ForeColor = System.Drawing.Color.White
        Me.baseHealthLabel.Location = New System.Drawing.Point(740, -1)
        Me.baseHealthLabel.Name = "baseHealthLabel"
        Me.baseHealthLabel.Size = New System.Drawing.Size(60, 33)
        Me.baseHealthLabel.TabIndex = 5
        Me.baseHealthLabel.Text = "300"
        '
        'upgradeLabel
        '
        Me.upgradeLabel.AutoSize = True
        Me.upgradeLabel.BackColor = System.Drawing.Color.Transparent
        Me.upgradeLabel.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.upgradeLabel.ForeColor = System.Drawing.Color.White
        Me.upgradeLabel.Location = New System.Drawing.Point(275, 244)
        Me.upgradeLabel.Name = "upgradeLabel"
        Me.upgradeLabel.Size = New System.Drawing.Size(254, 44)
        Me.upgradeLabel.TabIndex = 7
        Me.upgradeLabel.Text = "+Plane Speed"
        Me.upgradeLabel.Visible = False
        '
        'tmrUpgradeLabel
        '
        Me.tmrUpgradeLabel.Interval = 2000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Trophies"
        '
        'trophyLabel
        '
        Me.trophyLabel.AutoSize = True
        Me.trophyLabel.BackColor = System.Drawing.Color.Transparent
        Me.trophyLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.trophyLabel.ForeColor = System.Drawing.Color.Gold
        Me.trophyLabel.Location = New System.Drawing.Point(154, 65)
        Me.trophyLabel.Name = "trophyLabel"
        Me.trophyLabel.Size = New System.Drawing.Size(31, 33)
        Me.trophyLabel.TabIndex = 5
        Me.trophyLabel.Text = "0"
        '
        'tmrExplosion
        '
        Me.tmrExplosion.Enabled = True
        Me.tmrExplosion.Interval = 50
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.sky
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 616)
        Me.Controls.Add(Me.upgradeLabel)
        Me.Controls.Add(Me.bulletPictureBox)
        Me.Controls.Add(Me.trophyLabel)
        Me.Controls.Add(Me.baseHealthLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.playerPictureBox)
        Me.DoubleBuffered = True
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bulletPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playerPictureBox As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrEnemy As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents tmrScore As Timer
    Friend WithEvents tmrBullet As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents tmrCloud As Timer
    Public WithEvents bulletPictureBox As PictureBox
    Friend WithEvents label4 As Label
    Friend WithEvents baseHealthLabel As Label
    Friend WithEvents upgradeLabel As Label
    Friend WithEvents tmrUpgradeLabel As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents trophyLabel As Label
    Friend WithEvents tmrExplosion As Timer
End Class
