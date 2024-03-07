<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompleteQ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompleteQ))
        Me.Timers1 = New Quiz_Maker.Timers()
        Me.TLP2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.QHead = New System.Windows.Forms.Label()
        Me.FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLP2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timers1
        '
        Me.Timers1.BackColor = System.Drawing.Color.White
        Me.Timers1.Location = New System.Drawing.Point(12, 12)
        Me.Timers1.Name = "Timers1"
        Me.Timers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Timers1.Size = New System.Drawing.Size(426, 231)
        Me.Timers1.TabIndex = 34
        '
        'TLP2
        '
        Me.TLP2.ColumnCount = 2
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.Controls.Add(Me.Button2, 0, 0)
        Me.TLP2.Controls.Add(Me.Button1, 1, 0)
        Me.TLP2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP2.Location = New System.Drawing.Point(0, 645)
        Me.TLP2.Name = "TLP2"
        Me.TLP2.RowCount = 1
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TLP2.Size = New System.Drawing.Size(1125, 70)
        Me.TLP2.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.Image = Global.Quiz_Maker.My.Resources.Resources.nextt
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(566, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(556, 64)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = " السابق >"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button1.Image = Global.Quiz_Maker.My.Resources.Resources.Previouss
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(557, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "التالي >"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(586, 9)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(607, 467)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 33
        Me.Picture.TabStop = False
        '
        'QHead
        '
        Me.QHead.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QHead.AutoSize = True
        Me.QHead.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.QHead.Location = New System.Drawing.Point(8, 115)
        Me.QHead.Name = "QHead"
        Me.QHead.Size = New System.Drawing.Size(270, 23)
        Me.QHead.TabIndex = 36
        Me.QHead.Text = "أكمل العبارات الأتية بما يناسبها:-"
        '
        'FLP
        '
        Me.FLP.Controls.Add(Me.Label1)
        Me.FLP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FLP.Location = New System.Drawing.Point(0, 482)
        Me.FLP.Name = "FLP"
        Me.FLP.Size = New System.Drawing.Size(1125, 163)
        Me.FLP.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1083, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'CompleteQ
        '
        Me.AcceptButton = Me.Button1
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1125, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.FLP)
        Me.Controls.Add(Me.QHead)
        Me.Controls.Add(Me.TLP2)
        Me.Controls.Add(Me.Timers1)
        Me.Controls.Add(Me.Picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompleteQ"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "أكمل العبارات الأتية بما يناسبها :-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TLP2.ResumeLayout(False)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FLP.ResumeLayout(False)
        Me.FLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Picture As PictureBox
    Friend WithEvents Timers1 As Timers
    Friend WithEvents TLP2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents QHead As Label
    Friend WithEvents FLP As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
