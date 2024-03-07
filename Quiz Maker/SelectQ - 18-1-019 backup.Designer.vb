<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectQ))
        Me.QLabel = New System.Windows.Forms.Label()
        Me.RALabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DL = New System.Windows.Forms.NumericUpDown()
        Me.Timers1 = New Quiz_Maker.Timers()
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.A3Label = New System.Windows.Forms.RadioButton()
        Me.A4Label = New System.Windows.Forms.RadioButton()
        Me.A1Label = New System.Windows.Forms.RadioButton()
        Me.A2Label = New System.Windows.Forms.RadioButton()
        Me.Picture = New System.Windows.Forms.PictureBox()
        CType(Me.DL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP1.SuspendLayout()
        Me.TLP2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QLabel
        '
        Me.QLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.QLabel.Location = New System.Drawing.Point(3, 0)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(1150, 79)
        Me.QLabel.TabIndex = 6
        Me.QLabel.Text = "السؤال:"
        Me.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RALabel
        '
        Me.RALabel.Location = New System.Drawing.Point(350, 12)
        Me.RALabel.Name = "RALabel"
        Me.RALabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RALabel.Size = New System.Drawing.Size(116, 28)
        Me.RALabel.TabIndex = 10
        Me.RALabel.Text = "الإجابة الصحيحة:"
        Me.RALabel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(500, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Visible = False
        '
        'DL
        '
        Me.DL.Location = New System.Drawing.Point(472, 12)
        Me.DL.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.DL.Name = "DL"
        Me.DL.Size = New System.Drawing.Size(46, 20)
        Me.DL.TabIndex = 17
        Me.DL.Visible = False
        '
        'Timers1
        '
        Me.Timers1.BackColor = System.Drawing.Color.White
        Me.Timers1.Location = New System.Drawing.Point(12, 12)
        Me.Timers1.Name = "Timers1"
        Me.Timers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Timers1.Size = New System.Drawing.Size(272, 97)
        Me.Timers1.TabIndex = 24
        '
        'TLP1
        '
        Me.TLP1.ColumnCount = 1
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP1.Controls.Add(Me.TLP2, 0, 1)
        Me.TLP1.Controls.Add(Me.QLabel, 0, 0)
        Me.TLP1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP1.Location = New System.Drawing.Point(0, 358)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 2
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.Size = New System.Drawing.Size(1156, 343)
        Me.TLP1.TabIndex = 1
        '
        'TLP2
        '
        Me.TLP2.ColumnCount = 2
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.Controls.Add(Me.Button1, 0, 2)
        Me.TLP2.Controls.Add(Me.Button2, 1, 2)
        Me.TLP2.Controls.Add(Me.A3Label, 0, 1)
        Me.TLP2.Controls.Add(Me.A4Label, 1, 1)
        Me.TLP2.Controls.Add(Me.A1Label, 0, 0)
        Me.TLP2.Controls.Add(Me.A2Label, 1, 0)
        Me.TLP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP2.Location = New System.Drawing.Point(3, 82)
        Me.TLP2.Name = "TLP2"
        Me.TLP2.RowCount = 3
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP2.Size = New System.Drawing.Size(1150, 258)
        Me.TLP2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button1.Image = Global.Quiz_Maker.My.Resources.Resources.nextt
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(578, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(569, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "السابق >"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.Image = Global.Quiz_Maker.My.Resources.Resources.Previouss
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(569, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "التالي >"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'A3Label
        '
        Me.A3Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A3Label.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.A3Label.Location = New System.Drawing.Point(578, 99)
        Me.A3Label.Name = "A3Label"
        Me.A3Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A3Label.Size = New System.Drawing.Size(569, 90)
        Me.A3Label.TabIndex = 2
        Me.A3Label.Text = "إجابة 3:"
        '
        'A4Label
        '
        Me.A4Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A4Label.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.A4Label.Location = New System.Drawing.Point(3, 99)
        Me.A4Label.Name = "A4Label"
        Me.A4Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A4Label.Size = New System.Drawing.Size(569, 90)
        Me.A4Label.TabIndex = 3
        Me.A4Label.Text = "إجابة 4:"
        '
        'A1Label
        '
        Me.A1Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A1Label.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.A1Label.Location = New System.Drawing.Point(578, 3)
        Me.A1Label.Name = "A1Label"
        Me.A1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A1Label.Size = New System.Drawing.Size(569, 90)
        Me.A1Label.TabIndex = 0
        Me.A1Label.Text = "إجابة 1:"
        '
        'A2Label
        '
        Me.A2Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A2Label.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.A2Label.Location = New System.Drawing.Point(3, 3)
        Me.A2Label.Name = "A2Label"
        Me.A2Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.A2Label.Size = New System.Drawing.Size(569, 90)
        Me.A2Label.TabIndex = 1
        Me.A2Label.Text = "إجابة 2:"
        '
        'Picture
        '
        Me.Picture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture.ImageLocation = ""
        Me.Picture.Location = New System.Drawing.Point(524, 12)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(674, 406)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 23
        Me.Picture.TabStop = False
        '
        'SelectQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.TLP1)
        Me.Controls.Add(Me.Timers1)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.DL)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RALabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectQ"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "إختر الإجابة الصحيحة مما يأتي :-"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP1.ResumeLayout(False)
        Me.TLP2.ResumeLayout(False)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents QLabel As System.Windows.Forms.Label
    Friend WithEvents RALabel As System.Windows.Forms.Label
    Friend WithEvents DL As System.Windows.Forms.NumericUpDown
    Friend WithEvents Picture As PictureBox
    Friend WithEvents Timers1 As Timers
    Friend WithEvents TLP1 As TableLayoutPanel
    Friend WithEvents TLP2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents A3Label As RadioButton
    Friend WithEvents A4Label As RadioButton
    Friend WithEvents A1Label As RadioButton
    Friend WithEvents A2Label As RadioButton
End Class
