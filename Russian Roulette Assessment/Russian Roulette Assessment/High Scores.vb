Imports System.IO

Public Class High_Scores
    Private Sub High_Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filename As String = Path & "\russianroulettehighscores.txt"

        Dim Line As String
        Dim HighScore() As String
        Dim Row As Integer

        Try     'Reads the high score .txt file and prints it on the data grid
            Dim FileRead As StreamReader
            FileRead = New StreamReader(filename)
            Do Until FileRead.EndOfStream
                Line = FileRead.ReadLine
                HighScore = Line.Split("|")

                dgvHighScores.Rows.Add()
                dgvHighScores.Rows(Row).Cells(0).Value = HighScore(0)
                dgvHighScores.Rows(Row).Cells(1).Value = HighScore(1)

                Row = Row + 1
            Loop

            FileRead.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


End Class