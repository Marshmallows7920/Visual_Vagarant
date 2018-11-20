<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boss1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boss1))
        Me.Ball = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.White
        Me.Ball.ForeColor = System.Drawing.Color.Black
        Me.Ball.Location = New System.Drawing.Point(212, 127)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(24, 24)
        Me.Ball.TabIndex = 0
        Me.Ball.Text = "Button1"
        Me.Ball.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Bat
        '
        Me.Bat.BackColor = System.Drawing.Color.White
        Me.Bat.Location = New System.Drawing.Point(159, 249)
        Me.Bat.Name = "Bat"
        Me.Bat.Size = New System.Drawing.Size(130, 20)
        Me.Bat.TabIndex = 1
        Me.Bat.UseVisualStyleBackColor = False
        '
        'Boss1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(449, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.Bat)
        Me.Controls.Add(Me.Ball)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Boss1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boss1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ball As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Bat As System.Windows.Forms.Button

End Class
