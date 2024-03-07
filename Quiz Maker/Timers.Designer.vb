<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Timers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.hou2 = New System.Windows.Forms.Label()
        Me.min2 = New System.Windows.Forms.Label()
        Me.sec2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hou2
        '
        Me.hou2.BackColor = System.Drawing.Color.Cyan
        Me.hou2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.hou2.Location = New System.Drawing.Point(3, 34)
        Me.hou2.Name = "hou2"
        Me.hou2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hou2.Size = New System.Drawing.Size(69, 27)
        Me.hou2.TabIndex = 45
        Me.hou2.Text = "24"
        Me.hou2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'min2
        '
        Me.min2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.min2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.min2.Location = New System.Drawing.Point(99, 34)
        Me.min2.Name = "min2"
        Me.min2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.min2.Size = New System.Drawing.Size(69, 27)
        Me.min2.TabIndex = 46
        Me.min2.Text = "60"
        Me.min2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sec2
        '
        Me.sec2.BackColor = System.Drawing.Color.Lime
        Me.sec2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.sec2.Location = New System.Drawing.Point(195, 34)
        Me.sec2.Name = "sec2"
        Me.sec2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sec2.Size = New System.Drawing.Size(69, 27)
        Me.sec2.TabIndex = 47
        Me.sec2.Text = "60"
        Me.sec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(56, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "الوقت المتبقي :"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(3, 65)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar.Size = New System.Drawing.Size(261, 23)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 44
        Me.ProgressBar.Value = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(174, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(15, 19)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(78, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(15, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = ":"
        '
        'Timers
        '
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.hou2)
        Me.Controls.Add(Me.min2)
        Me.Controls.Add(Me.sec2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Timers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(267, 97)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents hou2 As Label
    Public WithEvents min2 As Label
    Public WithEvents sec2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
