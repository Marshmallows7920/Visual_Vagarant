Public Class event153
    Public Sub New()
        InitializeComponent()
        MovetoStart()
    End Sub

    Private Sub finish_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Cursor.Show()
        MessageBox.Show("Well done")
        Me.Hide()
        Dim result As New Maze_win
        result.Show()
    End Sub
    Private Sub MovetoStart()
        Dim StartingPoint = start.Location
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub event153_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cursor.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblplayer.Location = New Point(PointToClient(Cursor.Position))
    End Sub

    Private Sub Wall(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label37.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label2.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MovetoStart()
    End Sub
End Class