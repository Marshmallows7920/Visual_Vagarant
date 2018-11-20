Public Class Maze_win
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        My.Forms.Main.score = My.Forms.Main.score + 25
        Me.Hide()
        My.Forms.Main.Show()
    End Sub
End Class