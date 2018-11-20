Public Class Boss1
    Dim XSpeed As Single = -1
    Dim YSpeed As Single = -1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Ball.Top < 0 Then
            YSpeed = -YSpeed
        End If

        If Ball.Left < 0 Then
            XSpeed = -XSpeed
        End If

        'Check Bottom of the Screen
        If Ball.Bottom > Me.ClientRectangle.Height Then
            Timer1.Enabled = False
            Dim second As New RPS
            second.Show()
            Me.Hide()
        End If

        Dim Centre As Single = Ball.Left + Ball.Width / 2
        'Check for a Bat Hit
        If Centre > Bat.Left And Centre < Bat.Right And YSpeed > 0 _
        And Ball.Bottom > Bat.Top And Ball.Top < Bat.Top Then
            YSpeed = -YSpeed

        End If

        'Check Right Side of the Screen
        If Ball.Right > Me.ClientRectangle.Width Then
            XSpeed = -XSpeed
        End If

        Ball.Left += XSpeed
        Ball.Top += YSpeed
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        Bat.Width = 0.3 * Me.ClientRectangle.Width
        Bat.Height = 0.05 * Me.ClientRectangle.Height
        Bat.Top = 0.95 * Me.ClientRectangle.Height
        Bat.Left = e.X - (0.15 * Me.ClientRectangle.Width)

    End Sub
End Class
