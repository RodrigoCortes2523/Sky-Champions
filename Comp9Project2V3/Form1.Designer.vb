<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.highScoreLabel = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.controlsButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(136, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sky Champions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(389, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "High Score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(389, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 102)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Credits: Rodrigo Cortes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                  Kyle Carrasco" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                  Bryan" &
    " Vasquez"
        '
        'highScoreLabel
        '
        Me.highScoreLabel.AutoSize = True
        Me.highScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.highScoreLabel.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.highScoreLabel.ForeColor = System.Drawing.Color.White
        Me.highScoreLabel.Location = New System.Drawing.Point(610, 117)
        Me.highScoreLabel.Name = "highScoreLabel"
        Me.highScoreLabel.Size = New System.Drawing.Size(36, 40)
        Me.highScoreLabel.TabIndex = 2
        Me.highScoreLabel.Text = "0"
        '
        'startButton
        '
        Me.startButton.BackColor = System.Drawing.Color.Transparent
        Me.startButton.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.greenButton
        Me.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.startButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startButton.FlatAppearance.BorderSize = 0
        Me.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startButton.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(31, 96)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(161, 101)
        Me.startButton.TabIndex = 1
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'controlsButton
        '
        Me.controlsButton.BackColor = System.Drawing.Color.Transparent
        Me.controlsButton.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.greyButton
        Me.controlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.controlsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.controlsButton.FlatAppearance.BorderSize = 0
        Me.controlsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.controlsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.controlsButton.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.controlsButton.Location = New System.Drawing.Point(31, 203)
        Me.controlsButton.Name = "controlsButton"
        Me.controlsButton.Size = New System.Drawing.Size(161, 101)
        Me.controlsButton.TabIndex = 2
        Me.controlsButton.Text = "Controls"
        Me.controlsButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.greyButton
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.exitButton.Location = New System.Drawing.Point(31, 310)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(161, 101)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.jet
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(241, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 146)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(223, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 135)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightBlue
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(18, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(395, 96)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Use A, D Keys to Move Left and Right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Avoid Other Planes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use SpaceBar to Shoot D" &
    "own Planes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Build Score to Gain Upgrades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.titleFrame
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(141, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 79)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(335, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Art Credits: Art assets from Itch.io" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.Comp9Project2V3.My.Resources.Resources.sky
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 502)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.controlsButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.highScoreLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Game Title"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents highScoreLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents controlsButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class
