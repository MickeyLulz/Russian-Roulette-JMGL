<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Russian_Roulette_Game
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
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnLoadGun = New System.Windows.Forms.Button()
        Me.btnSpinChamber = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblShots = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShootAway = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.pbShotsFired6 = New System.Windows.Forms.PictureBox()
        Me.pbShotsFired2 = New System.Windows.Forms.PictureBox()
        Me.pbShotsFired3 = New System.Windows.Forms.PictureBox()
        Me.pbShotsFired4 = New System.Windows.Forms.PictureBox()
        Me.pbShotsFired5 = New System.Windows.Forms.PictureBox()
        Me.pbShotsFired1 = New System.Windows.Forms.PictureBox()
        Me.pbRevolverImage = New System.Windows.Forms.PictureBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        CType(Me.pbShotsFired6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShotsFired2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShotsFired3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShotsFired4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShotsFired5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShotsFired1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRevolverImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFire
        '
        Me.btnFire.BackColor = System.Drawing.Color.Firebrick
        Me.btnFire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(224, 453)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(227, 61)
        Me.btnFire.TabIndex = 30
        Me.btnFire.Text = "FIRE"
        Me.btnFire.UseVisualStyleBackColor = False
        '
        'btnLoadGun
        '
        Me.btnLoadGun.BackColor = System.Drawing.Color.Firebrick
        Me.btnLoadGun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadGun.Location = New System.Drawing.Point(224, 410)
        Me.btnLoadGun.Name = "btnLoadGun"
        Me.btnLoadGun.Size = New System.Drawing.Size(108, 37)
        Me.btnLoadGun.TabIndex = 29
        Me.btnLoadGun.Text = "Load Gun"
        Me.btnLoadGun.UseVisualStyleBackColor = False
        '
        'btnSpinChamber
        '
        Me.btnSpinChamber.BackColor = System.Drawing.Color.Firebrick
        Me.btnSpinChamber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinChamber.Location = New System.Drawing.Point(343, 410)
        Me.btnSpinChamber.Name = "btnSpinChamber"
        Me.btnSpinChamber.Size = New System.Drawing.Size(108, 37)
        Me.btnSpinChamber.TabIndex = 28
        Me.btnSpinChamber.Text = "Spin Chamber"
        Me.btnSpinChamber.UseVisualStyleBackColor = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Firebrick
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(591, 306)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(91, 23)
        Me.btnNewGame.TabIndex = 27
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'lblShots
        '
        Me.lblShots.AutoSize = True
        Me.lblShots.BackColor = System.Drawing.Color.Transparent
        Me.lblShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShots.ForeColor = System.Drawing.Color.Firebrick
        Me.lblShots.Location = New System.Drawing.Point(58, 346)
        Me.lblShots.Name = "lblShots"
        Me.lblShots.Size = New System.Drawing.Size(71, 13)
        Me.lblShots.TabIndex = 22
        Me.lblShots.Text = "Shots Fired"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(591, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnShootAway
        '
        Me.btnShootAway.BackColor = System.Drawing.Color.Firebrick
        Me.btnShootAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShootAway.Location = New System.Drawing.Point(457, 453)
        Me.btnShootAway.Name = "btnShootAway"
        Me.btnShootAway.Size = New System.Drawing.Size(94, 61)
        Me.btnShootAway.TabIndex = 39
        Me.btnShootAway.Text = "Shoot Away: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 Chances"
        Me.btnShootAway.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInstruction.Location = New System.Drawing.Point(586, 143)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(112, 25)
        Me.lblInstruction.TabIndex = 40
        Me.lblInstruction.Text = "Instruction"
        '
        'pbShotsFired6
        '
        Me.pbShotsFired6.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired6.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired6.Location = New System.Drawing.Point(319, 335)
        Me.pbShotsFired6.Name = "pbShotsFired6"
        Me.pbShotsFired6.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired6.TabIndex = 38
        Me.pbShotsFired6.TabStop = False
        Me.pbShotsFired6.Visible = False
        '
        'pbShotsFired2
        '
        Me.pbShotsFired2.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired2.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired2.Location = New System.Drawing.Point(171, 335)
        Me.pbShotsFired2.Name = "pbShotsFired2"
        Me.pbShotsFired2.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired2.TabIndex = 37
        Me.pbShotsFired2.TabStop = False
        Me.pbShotsFired2.Visible = False
        '
        'pbShotsFired3
        '
        Me.pbShotsFired3.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired3.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired3.Location = New System.Drawing.Point(208, 335)
        Me.pbShotsFired3.Name = "pbShotsFired3"
        Me.pbShotsFired3.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired3.TabIndex = 36
        Me.pbShotsFired3.TabStop = False
        Me.pbShotsFired3.Visible = False
        '
        'pbShotsFired4
        '
        Me.pbShotsFired4.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired4.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired4.Location = New System.Drawing.Point(245, 335)
        Me.pbShotsFired4.Name = "pbShotsFired4"
        Me.pbShotsFired4.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired4.TabIndex = 35
        Me.pbShotsFired4.TabStop = False
        Me.pbShotsFired4.Visible = False
        '
        'pbShotsFired5
        '
        Me.pbShotsFired5.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired5.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired5.Location = New System.Drawing.Point(282, 335)
        Me.pbShotsFired5.Name = "pbShotsFired5"
        Me.pbShotsFired5.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired5.TabIndex = 34
        Me.pbShotsFired5.TabStop = False
        Me.pbShotsFired5.Visible = False
        '
        'pbShotsFired1
        '
        Me.pbShotsFired1.BackColor = System.Drawing.Color.Transparent
        Me.pbShotsFired1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShotsFired1.Image = Global.Russian_Roulette_Assessment.My.Resources.Resources.RevolverBullet
        Me.pbShotsFired1.Location = New System.Drawing.Point(134, 335)
        Me.pbShotsFired1.Name = "pbShotsFired1"
        Me.pbShotsFired1.Size = New System.Drawing.Size(31, 43)
        Me.pbShotsFired1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShotsFired1.TabIndex = 33
        Me.pbShotsFired1.TabStop = False
        Me.pbShotsFired1.Visible = False
        '
        'pbRevolverImage
        '
        Me.pbRevolverImage.BackColor = System.Drawing.Color.Transparent
        Me.pbRevolverImage.Location = New System.Drawing.Point(134, 47)
        Me.pbRevolverImage.Name = "pbRevolverImage"
        Me.pbRevolverImage.Size = New System.Drawing.Size(341, 253)
        Me.pbRevolverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRevolverImage.TabIndex = 31
        Me.pbRevolverImage.TabStop = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPlayerName.Location = New System.Drawing.Point(614, 168)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(68, 25)
        Me.lblPlayerName.TabIndex = 41
        Me.lblPlayerName.Text = "Name"
        '
        'Russian_Roulette_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Russian_Roulette_Assessment.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(783, 556)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnShootAway)
        Me.Controls.Add(Me.pbShotsFired6)
        Me.Controls.Add(Me.pbShotsFired2)
        Me.Controls.Add(Me.pbShotsFired3)
        Me.Controls.Add(Me.pbShotsFired4)
        Me.Controls.Add(Me.pbShotsFired5)
        Me.Controls.Add(Me.pbShotsFired1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbRevolverImage)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnLoadGun)
        Me.Controls.Add(Me.btnSpinChamber)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblShots)
        Me.Name = "Russian_Roulette_Game"
        Me.Text = "Russian Roulette"
        CType(Me.pbShotsFired6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShotsFired2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShotsFired3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShotsFired4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShotsFired5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShotsFired1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRevolverImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRevolverImage As PictureBox
    Friend WithEvents btnFire As Button
    Friend WithEvents btnLoadGun As Button
    Friend WithEvents btnSpinChamber As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents lblShots As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents pbShotsFired1 As PictureBox
    Friend WithEvents pbShotsFired5 As PictureBox
    Friend WithEvents pbShotsFired4 As PictureBox
    Friend WithEvents pbShotsFired3 As PictureBox
    Friend WithEvents pbShotsFired2 As PictureBox
    Friend WithEvents pbShotsFired6 As PictureBox
    Friend WithEvents btnShootAway As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblPlayerName As Label
End Class
