Public Class Lose

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Main.score = My.Forms.Main.score - 10
        Me.Hide()
        My.Forms.Main.Show()
    End Sub

End Class