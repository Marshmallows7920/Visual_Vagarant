<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.Buttonup = New System.Windows.Forms.Button
        Me.Buttondown = New System.Windows.Forms.Button
        Me.Buttonright = New System.Windows.Forms.Button
        Me.Buttonleft = New System.Windows.Forms.Button
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(78, 94)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(10, 13)
        Me.lbl2.TabIndex = 0
        Me.lbl2.Text = ","
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(78, 111)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(10, 13)
        Me.lbl5.TabIndex = 1
        Me.lbl5.Text = ","
        '
        'Buttonup
        '
        Me.Buttonup.Location = New System.Drawing.Point(215, 25)
        Me.Buttonup.Name = "Buttonup"
        Me.Buttonup.Size = New System.Drawing.Size(136, 54)
        Me.Buttonup.TabIndex = 2
        Me.Buttonup.Text = "Up"
        Me.Buttonup.UseVisualStyleBackColor = True
        '
        'Buttondown
        '
        Me.Buttondown.Location = New System.Drawing.Point(215, 145)
        Me.Buttondown.Name = "Buttondown"
        Me.Buttondown.Size = New System.Drawing.Size(136, 56)
        Me.Buttondown.TabIndex = 3
        Me.Buttondown.Text = "Down"
        Me.Buttondown.UseVisualStyleBackColor = True
        '
        'Buttonright
        '
        Me.Buttonright.Location = New System.Drawing.Point(291, 85)
        Me.Buttonright.Name = "Buttonright"
        Me.Buttonright.Size = New System.Drawing.Size(136, 54)
        Me.Buttonright.TabIndex = 4
        Me.Buttonright.Text = "Right"
        Me.Buttonright.UseVisualStyleBackColor = True
        '
        'Buttonleft
        '
        Me.Buttonleft.Location = New System.Drawing.Point(149, 85)
        Me.Buttonleft.Name = "Buttonleft"
        Me.Buttonleft.Size = New System.Drawing.Size(136, 54)
        Me.Buttonleft.TabIndex = 5
        Me.Buttonleft.Text = "Left"
        Me.Buttonleft.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(97, 111)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(10, 13)
        Me.lbl6.TabIndex = 6
        Me.lbl6.Text = ","
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(59, 111)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(10, 13)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = ","
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(59, 94)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(14, 13)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "P"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(97, 94)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(10, 13)
        Me.lbl3.TabIndex = 9
        Me.lbl3.Text = ","
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 264)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.Buttonleft)
        Me.Controls.Add(Me.Buttonright)
        Me.Controls.Add(Me.Buttondown)
        Me.Controls.Add(Me.Buttonup)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl2)
        Me.Name = "Form1"
        Me.Text = "P"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents Buttonup As System.Windows.Forms.Button
    Friend WithEvents Buttondown As System.Windows.Forms.Button
    Friend WithEvents Buttonright As System.Windows.Forms.Button
    Friend WithEvents Buttonleft As System.Windows.Forms.Button
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label

End Class
