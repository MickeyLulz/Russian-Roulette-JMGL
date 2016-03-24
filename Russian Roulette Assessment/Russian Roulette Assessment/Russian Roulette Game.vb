Public Class Russian_Roulette_Game

    Dim Chamber As Integer
    Dim FireChance As Integer = 1
    Dim ShootAwayChance As Integer = 1
    Public Score As Double

    Private Sub Russian_Roulette_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstruction.Text = "Load your gun"
        lblPlayerName.Text = Form1.PlayerName

        btnFire.Enabled = False
        btnSpinChamber.Enabled = False
        btnLoadGun.Enabled = True
        btnShootAway.Enabled = False

    End Sub

    Private Sub btnLoadGun_Click(sender As Object, e As EventArgs) Handles btnLoadGun.Click
        My.Computer.Audio.Play(My.Resources.revolver_reload, AudioPlayMode.Background)      'Plays an audio file to emulate loading a bullet into a chamber

        pbRevolverImage.Image = My.Resources.LoadRevolver

        lblInstruction.Text = "Spin the chamber"
        lblPlayerName.Text = Form1.PlayerName

        btnFire.Enabled = False
        btnLoadGun.Enabled = False
        btnSpinChamber.Enabled = True
        btnShootAway.Enabled = False

    End Sub

    Private Sub btnSpinChamber_Click(sender As Object, e As EventArgs) Handles btnSpinChamber.Click
        My.Computer.Audio.Play(My.Resources.spin_chamber, AudioPlayMode.Background)     'Plays an audio file to emulate spinning the revolver chamber

        pbRevolverImage.Image = My.Resources.SpinChamber

        lblInstruction.Text = "Fire the gun"
        lblPlayerName.Text = Form1.PlayerName

        btnFire.Enabled = True
        btnLoadGun.Enabled = False
        btnSpinChamber.Enabled = False
        btnShootAway.Enabled = True

        'Generates a random chamber position for the bullet
        Randomize()
        Chamber = CInt(Int((6 * Rnd()) + 1))

    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        pbRevolverImage.Image = My.Resources.ShootPlayer

        If Chamber = FireChance Then        'Plays an audio file of a loaded gun when the bullet is in the firing chamber
            My.Computer.Audio.Play(My.Resources.fire_gun, AudioPlayMode.Background)
            btnLoadGun.Enabled = True
            btnSpinChamber.Enabled = False
            btnSpinChamber.Enabled = False
        Else
            My.Computer.Audio.Play(My.Resources.revolver_misfire, AudioPlayMode.Background)     'Plays an audio file of a misfire when the chamber is empty
        End If

        Scoring()
        BulletImage()

    End Sub

    Private Sub btnShootAway_Click(sender As Object, e As EventArgs) Handles btnShootAway.Click
        pbRevolverImage.Image = My.Resources.ShootAway2

        'Condition for firing away chances
        If Chamber = FireChance Then        'If gun is shot away with the loaded chamber, the player wins
            My.Computer.Audio.Play(My.Resources.fire_gun, AudioPlayMode.Background)
            MsgBox("YOU SURVIVED!!!")
            Score = Score + 100
            Game_Over.Show()
            Me.Close()

        ElseIf ShootAwayChance = 1 And Chamber <> FireChance Then
            My.Computer.Audio.Play(My.Resources.revolver_misfire, AudioPlayMode.Background)
            btnShootAway.Text = "Shoot Away:" & vbCrLf & "Last Chance"

        ElseIf ShootAwayChance = 2 And Chamber <> FireChance Then       'If gun is shot away and have not fired the loaded chamber, the game will be over
            My.Computer.Audio.Play(My.Resources.revolver_misfire, AudioPlayMode.Background)
            btnShootAway.Enabled = False
            btnShootAway.Text = "Shoot Away:" & vbCrLf & "No Chances Left"
            MsgBox("GAME OVER!!! No more chances left to shoot away.")
            Score = 0
            Game_Over.Show()
            Me.Close()
        End If

        FireChance += 1
        ShootAwayChance += 1

        BulletImage()

    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Me.Close()

        Form1.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Public Sub Scoring()  'Sub Routine for the scoring
        If FireChance = Chamber Then
            Score = 0
            MsgBox("YOU'RE DEAD")
            Game_Over.Show()
            Me.Close()

        ElseIf FireChance = 5 And Chamber <> FireChance Then
            Score = 80

        ElseIf FireChance = 4 And Chamber <> FireChance Then
            Score = 65

        ElseIf FireChance = 3 And Chamber <> FireChance Then
            Score = 50

        ElseIf FireChance = 2 And Chamber <> FireChance Then
            Score = 35

        ElseIf FireChance = 1 And Chamber <> FireChance Then
            Score = 20
        End If

        FireChance += 1

    End Sub


    Private Sub BulletImage()  'Sub Routine for the shots fired images
        If FireChance = 1 Then
            pbShotsFired1.Visible = True
        ElseIf FireChance = 2 Then
            pbShotsFired2.Visible = True
        ElseIf FireChance = 3 Then
            pbShotsFired3.Visible = True
        ElseIf FireChance = 4 Then
            pbShotsFired4.Visible = True
        ElseIf FireChance = 5 Then
            pbShotsFired5.Visible = True
        ElseIf FireChance = 6 Then
            pbShotsFired6.Visible = True
        End If

    End Sub


End Class