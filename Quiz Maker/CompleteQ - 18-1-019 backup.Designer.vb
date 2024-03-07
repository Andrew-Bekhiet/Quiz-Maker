<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompleteQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompleteQ))
        Me.QLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FMark = New System.Windows.Forms.NumericUpDown()
        Me.Timers1 = New Quiz_Maker.Timers()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        CType(Me.FMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QLabel
        '
        Me.QLabel.BackColor = System.Drawing.Color.White
        Me.QLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QLabel.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.QLabel.Location = New System.Drawing.Point(566, 0)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(556, 174)
        Me.QLabel.TabIndex = 0
        Me.QLabel.Text = "    "
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(557, 30)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(705, 415)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(632, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mark"
        Me.Label2.Visible = False
        '
        'FMark
        '
        Me.FMark.Location = New System.Drawing.Point(635, 416)
        Me.FMark.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.FMark.Name = "FMark"
        Me.FMark.Size = New System.Drawing.Size(64, 20)
        Me.FMark.TabIndex = 5
        Me.FMark.Visible = False
        '
        'Timers1
        '
        Me.Timers1.BackColor = System.Drawing.Color.White
        Me.Timers1.Location = New System.Drawing.Point(12, 12)
        Me.Timers1.Name = "Timers1"
        Me.Timers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Timers1.Size = New System.Drawing.Size(282, 100)
        Me.Timers1.TabIndex = 34
        '
        'TLP
        '
        Me.TLP.ColumnCount = 2
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP.Controls.Add(Me.QLabel, 0, 0)
        Me.TLP.Controls.Add(Me.TextBox1, 1, 0)
        Me.TLP.Controls.Add(Me.Button2, 0, 1)
        Me.TLP.Controls.Add(Me.Button1, 1, 1)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP.Location = New System.Drawing.Point(0, 482)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 2
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP.Size = New System.Drawing.Size(1125, 233)
        Me.TLP.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.Image = Global.Quiz_Maker.My.Resources.Resources.nextt
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(566, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(556, 53)
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
        Me.Button1.Location = New System.Drawing.Point(3, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(557, 53)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "التالي >"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Picture
        '
        Me.Picture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture.Location = New System.Drawing.Point(506, 9)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(607, 467)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 33
        Me.Picture.TabStop = False
        '
        'CompleteQ
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1125, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.TLP)
        Me.Controls.Add(Me.Timers1)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.FMark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompleteQ"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "أكمل العبارات الأتية بما يناسبها :-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP.ResumeLayout(False)
        Me.TLP.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FMark As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Picture As PictureBox
    Friend WithEvents Timers1 As Timers
    Friend WithEvents TLP As TableLayoutPanel
End Class
