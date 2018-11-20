Public Class Form1

    Dim memory As Integer = 1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If memory < 1 Then
            memory = 1
        End If
        If memory > 6 Then
            memory = 6
        End If
        '  Randomize()
        '   Me.Label1.Text = Int(21 * Rnd() + 10)
        '   Me.Label2.Text = Int(21 * Rnd() + 10)
        '   Me.Label3.Text = Int(21 * Rnd() + 10)
        '   Me.Label4.Text = Int(21 * Rnd() + 10)
        '   Me.Label5.Text = Int(21 * Rnd() + 10)
        '   Me.Label6.Text = Int(21 * Rnd() + 10)

        '(highNumber - lowNumber + 1) * Rnd() + lowNumber()
    End Sub
    Private Sub Buttonup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonup.Click

        If memory = 5 Then
            memory = 2
            Me.lbl2.Text = "P"
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 2 Then
            Me.lbl1.Text = ","
            Me.lbl2.Text = "P"
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 3 Then
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = "P"
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 4 Then
            memory = 1
            Me.lbl1.Text = "P"
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 1 Then
            Me.lbl1.Text = "P"
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 6 Then
            memory = 3
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = "P"
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
    End Sub

    Private Sub Buttondown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttondown.Click

        If memory = 5 Then
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = "P"
            Me.lbl6.Text = ","
        End If
        If memory = 2 Then
            memory = 5
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = "P"
            Me.lbl6.Text = ","
        End If
        If memory = 3 Then
            memory = 6
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = "P"
        End If
        If memory = 4 Then
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = "P"
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 1 Then
            memory = 4
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = "P"
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 6 Then
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = "P"
        End If
    End Sub
    Private Sub Buttonright_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonright.Click

        If memory = 1 Then
            memory = memory + 1
            Me.lbl1.Text = ","
            Me.lbl2.Text = "P"
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        ElseIf memory = 2 Then
            memory = memory + 1
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = "P"
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        ElseIf memory = 3 Then
            memory = memory
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = "P"
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        ElseIf memory = 4 Then
            memory = memory + 1
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = "P"
            Me.lbl6.Text = ","
        ElseIf memory = 5 Then
            memory = memory + 1
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = "P"
        ElseIf memory = 6 Then
            memory = memory
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = "P"
        End If
    End Sub
    Private Sub Buttonleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonleft.Click

        If memory = 1 Then
            memory = 1
            Me.lbl1.Text = "P"
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 2 Then
            memory = 1
            Me.lbl1.Text = "P"
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 3 Then
            memory = 2
            Me.lbl1.Text = ","
            Me.lbl2.Text = "P"
            Me.lbl3.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 4 Then
            memory = 4
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = "P"
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 5 Then
            memory = 4
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl3.Text = ","
            Me.lbl4.Text = "P"
            Me.lbl5.Text = ","
            Me.lbl6.Text = ","
        End If
        If memory = 6 Then
            memory = 5
            Me.lbl1.Text = ","
            Me.lbl2.Text = ","
            Me.lbl4.Text = ","
            Me.lbl5.Text = "P"
            Me.lbl6.Text = ","
        End If
    End Sub
End Class

