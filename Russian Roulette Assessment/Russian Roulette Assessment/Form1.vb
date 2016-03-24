Public Class Form1

    Public PlayerName As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PlayerName = txtPlayerName.Text

        If PlayerName = "" Then
            MsgBox("Please enter your name.")
        Else
            Russian_Roulette_Game.Show()
            Me.Hide()
        End If

        txtPlayerName.Clear()

    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        High_Scores.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
