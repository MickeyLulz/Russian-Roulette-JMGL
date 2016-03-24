Imports System.IO

Public Class Game_Over
    Private Sub Game_Over_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayerName.Text = Form1.PlayerName
        lblScore.Text = "Score: " & Russian_Roulette_Game.Score

        Dim Path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)        'Creates a new .txt file for the scores
        Dim filename As String = Path & "\russianroulettehighscores.txt"

        If Not System.IO.File.Exists(filename) Then     'Checks if the file already exists to avoid replacing the file by accident
            System.IO.File.Create(filename).Dispose()
        End If

        Try     'Writes on the high score .txt file
            Dim FileWrite As StreamWriter

            FileWrite = File.AppendText(filename)
            FileWrite.WriteLine(Form1.PlayerName & "|" & Russian_Roulette_Game.Score)

            FileWrite.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Me.Close()

        Russian_Roulette_Game.Show()

    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        High_Scores.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub
End Class