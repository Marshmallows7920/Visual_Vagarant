﻿Public Class RPS

    Dim userselected As Integer
    Dim gameresult As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Random As New Random
        Dim computerchoice = Random.Next(3)

        If computerchoice = userselected Then gameresult = 0
        Select Case computerchoice
            Case 0
                If userselected = 1 Then gameresult = 2
                If userselected = 2 Then gameresult = 1
            Case 1
                If userselected = 0 Then gameresult = 1
                If userselected = 2 Then gameresult = 2
            Case 2
                If userselected = 0 Then gameresult = 2
                If userselected = 1 Then gameresult = 1
        End Select

        Select Case gameresult
            Case 0
                Label1.Text = "It Was A Draw"
            Case 1
                Dim result1 As New Lose
                result1.Show()
                Me.Hide()
            Case 2
                Dim result2 As New Win
                result2.Show()
                Me.Hide()
        End Select


    End Sub
End Class