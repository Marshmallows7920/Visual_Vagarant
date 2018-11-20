Public Class XO

    Dim random As String = 1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        random += 1
        If random = 10 Then
            random = 1
        End If
    End Sub
    Public Sub PC()
        If random = 1 And Button1.Enabled = True Then
            Me.Button1.Text = "O"
            Me.Button1.Enabled = False
        End If
        If random = 2 And Button2.Enabled = True Then
            Me.Button2.Text = "O"
            Me.Button2.Enabled = False
        End If
        If random = 3 And Button3.Enabled = True Then
            Me.Button3.Text = "O"
            Me.Button3.Enabled = False
        End If
        If random = 4 And Button4.Enabled = True Then
            Me.Button4.Text = "O"
            Me.Button4.Enabled = False
        End If
        If random = 5 And Button5.Enabled = True Then
            Me.Button5.Text = "O"
            Me.Button5.Enabled = False
        End If
        If random = 6 And Button6.Enabled = True Then
            Me.Button6.Text = "O"
            Me.Button6.Enabled = False
        End If
        If random = 7 And Button7.Enabled = True Then
            Me.Button7.Text = "O"
            Me.Button7.Enabled = False
        End If
        If random = 8 And Button8.Enabled = True Then
            Me.Button8.Text = "O"
            Me.Button8.Enabled = False
        End If
        If random = 9 And Button9.Enabled = True Then
            Me.Button9.Text = "O"
            Me.Button9.Enabled = False
        End If
    End Sub
    Public Sub Options()

        'If user hits 1
        If Label1.Text = 1 Then
            If Button2.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button3.Text = "X" And Button2.Enabled = True Then
                With Button2
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button4.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button4.Enabled = True Then
                With Button4
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" Or Button6.Text = "X" Then
                hit()
            End If

        End If
        'If user hits 2
        If Label1.Text = 2 Then
            If Button1.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button1.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button8.Enabled = True Then
                With Button8
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" Or Button4.Text = "X" Or Button7.Text = "X" Or Button9.Text = "X" Then
                hit()
            End If
        End If
        'If user hits 3
        If Label1.Text = 3 Then
            If Button1.Text = "X" And Button2.Enabled = True Then
                With Button2
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button2.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button6.Enabled = True Then
                With Button6
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" Or Button4.Text = "X" Then
                hit()
            End If
        End If
        'If user hits 4
        If Label1.Text = 4 Then
            If Button1.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button6.Enabled = True Then
                With Button6
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button2.Text = "X" Or Button3.Text = "X" Or Button8.Text = "X" Or Button9.Text = "X" Then
                hit()
            End If
        End If
        'If user hits 5
        If Label1.Text = 5 Then
            If Button1.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button2.Text = "X" And Button8.Enabled = True Then
                With Button8
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" And Button2.Enabled = True Then
                With Button2
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button3.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" And Button4.Enabled = True Then
                With Button4
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button4.Text = "X" And Button6.Enabled = True Then
                With Button6
                    .Text = "O"
                    .Enabled = False
                End With
            End If
        End If

        'If user hits 6
        If Label1.Text = 6 Then
            If Button3.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button4.Enabled = True Then
                With Button4
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button4.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button1.Text = "X" Or Button2.Text = "X" Or Button7.Text = "X" Or Button8.Text = "X" Then
                hit()
            End If
        End If

        'If user hits 7
        If Label1.Text = 7 Then
            If Button1.Text = "X" And Button4.Enabled = True Then
                With Button4
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button4.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button3.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button8.Enabled = True Then
                With Button8
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" Or Button2.Text = "X" Then
                hit()
            End If
        End If

        'If user hits 8
        If Label1.Text = 8 Then
            If Button2.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button2.Enabled = True Then
                With Button2
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button9.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button9.Enabled = True Then
                With Button9
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button6.Text = "X" Or Button3.Text = "X" Or Button1.Text = "X" Or Button4.Text = "X" Then
                hit()
            End If
        End If
        'If user hits 9
        If Label1.Text = 9 Then
            If Button6.Text = "X" And Button3.Enabled = True Then
                With Button3
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button3.Text = "X" And Button6.Enabled = True Then
                With Me.Button6
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button5.Text = "X" And Button1.Enabled = True Then
                With Button1
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button1.Text = "X" And Button5.Enabled = True Then
                With Button5
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button8.Text = "X" And Button7.Enabled = True Then
                With Button7
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button7.Text = "X" And Button8.Enabled = True Then
                With Button8
                    .Text = "O"
                    .Enabled = False
                End With
            ElseIf Button2.Text = "X" Or Button4.Text = "X" Then
                hit()
            End If
        End If
    End Sub
    Public Sub CheckIfComputerWins()
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" _
        Or Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" _
        Or Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" _
        Or Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" _
        Or Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" _
        Or Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" _
        Or Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" _
        Or Button7.Text = "O" And Button5.Text = "O" And Button3.Text = "O" Then

            Me.Hide()
            My.Forms.event130_4.Show()

            Me.Button1.Text = ""
            Me.Button1.Enabled = True
            Me.Button2.Text = ""
            Me.Button2.Enabled = True
            Me.Button3.Text = ""
            Me.Button3.Enabled = True
            Me.Button4.Text = ""
            Me.Button4.Enabled = True
            Me.Button5.Text = ""
            Me.Button5.Enabled = True
            Me.Button6.Text = ""
            Me.Button6.Enabled = True
            Me.Button7.Text = ""
            Me.Button7.Enabled = True
            Me.Button8.Text = ""
            Me.Button8.Enabled = True
            Me.Button9.Text = ""
            Me.Button9.Enabled = True
        ElseIf Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" _
        Or Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" _
        Or Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" _
        Or Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" _
        Or Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" _
        Or Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" _
        Or Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" _
        Or Button7.Text = "X" And Button5.Text = "X" And Button3.Text = "X" Then

            Me.Hide()
            My.Forms.event130_4.Show()

            Me.Button1.Text = ""
            Me.Button1.Enabled = True
            Me.Button2.Text = ""
            Me.Button2.Enabled = True
            Me.Button3.Text = ""
            Me.Button3.Enabled = True
            Me.Button4.Text = ""
            Me.Button4.Enabled = True
            Me.Button5.Text = ""
            Me.Button5.Enabled = True
            Me.Button6.Text = ""
            Me.Button6.Enabled = True
            Me.Button7.Text = ""
            Me.Button7.Enabled = True
            Me.Button8.Text = ""
            Me.Button8.Enabled = True
            Me.Button9.Text = ""
            Me.Button9.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, _
    Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        sender.Text = "X"
        sender.Enabled = False
        Me.Timer1.Stop()
        Me.Label1.Text = sender.name
        Me.Label1.Text = Me.Label1.Text.Replace("Button", "")
        If random = Label1.Text Then
            random = random + 1
        End If
        If random > 0 Then
            PC()
            random = 0
        ElseIf random = 0 Then
            Options()
        End If
        Me.Label2.Text = random
        CheckIfComputerWins()
    End Sub
    Public Sub hit()
        For Each ctl As Control In Me.Controls
            If Me.Label1.Text < 9 Then
                If (ctl.Name.StartsWith("Button" & Label1.Text + 1)) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        btn.Text = "O"
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            Else
                If (ctl.Name.StartsWith("Button1")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        btn.Text = "O"
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Timer1.Stop()
        Me.Button1.Text = "O"
        Me.Label1.Text = 1
        Me.Button1.Enabled = False
        Me.Button10.Enabled = False
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Button1.Text = ""
        Me.Button1.Enabled = True
        Me.Button2.Text = ""
        Me.Button2.Enabled = True
        Me.Button3.Text = ""
        Me.Button3.Enabled = True
        Me.Button4.Text = ""
        Me.Button4.Enabled = True
        Me.Button5.Text = ""
        Me.Button5.Enabled = True
        Me.Button6.Text = ""
        Me.Button6.Enabled = True
        Me.Button7.Text = ""
        Me.Button7.Enabled = True
        Me.Button8.Text = ""
        Me.Button8.Enabled = True
        Me.Button9.Text = ""
        Me.Button9.Enabled = True
        Me.Button10.Enabled = True
        Me.Timer1.Start()
    End Sub

End Class