<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JoinQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JoinQ))
        Me.Closeopen1 = New Quiz_Maker.Closeopen()
        Me.Timers1 = New Quiz_Maker.Timers()
        Me.JQControls = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.QHead = New System.Windows.Forms.Label()
        Me.Questions = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B3Help = New System.Windows.Forms.PictureBox()
        Me.JQControls.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.B3Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Closeopen1
        '
        Me.Closeopen1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Closeopen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Closeopen1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Closeopen1.Location = New System.Drawing.Point(296, 6)
        Me.Closeopen1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Closeopen1.Name = "Closeopen1"
        Me.Closeopen1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Closeopen1.Size = New System.Drawing.Size(277, 45)
        Me.Closeopen1.TabIndex = 3
        '
        'Timers1
        '
        Me.Timers1.BackColor = System.Drawing.Color.White
        Me.Timers1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Timers1.Location = New System.Drawing.Point(3, 3)
        Me.Timers1.Name = "Timers1"
        Me.Timers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Timers1.Size = New System.Drawing.Size(1157, 86)
        Me.Timers1.TabIndex = 41
        '
        'JQControls
        '
        Me.JQControls.ColumnCount = 4
        Me.JQControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.JQControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.JQControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.JQControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.JQControls.Controls.Add(Me.Button2, 0, 0)
        Me.JQControls.Controls.Add(Me.Button1, 3, 0)
        Me.JQControls.Controls.Add(Me.Closeopen1, 2, 0)
        Me.JQControls.Controls.Add(Me.Button3, 1, 0)
        Me.JQControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JQControls.Location = New System.Drawing.Point(3, 709)
        Me.JQControls.Name = "JQControls"
        Me.JQControls.RowCount = 1
        Me.JQControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.JQControls.Size = New System.Drawing.Size(1157, 57)
        Me.JQControls.TabIndex = 42
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
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(871, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(283, 51)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "< السابق"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.Button1.Size = New System.Drawing.Size(284, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "التالي >"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button3.Image = Global.Quiz_Maker.My.Resources.Resources.Eraser
        Me.Button3.Location = New System.Drawing.Point(582, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(283, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "الممحاة"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'QHead
        '
        Me.QHead.AutoSize = True
        Me.QHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QHead.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.QHead.Location = New System.Drawing.Point(3, 92)
        Me.QHead.Name = "QHead"
        Me.QHead.Size = New System.Drawing.Size(1157, 38)
        Me.QHead.TabIndex = 36
        Me.QHead.Text = "صل العبارات الأتية بما يناسبها :-"
        '
        'Questions
        '
        Me.Questions.ColumnCount = 3
        Me.Questions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Questions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Questions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Questions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Questions.Location = New System.Drawing.Point(3, 133)
        Me.Questions.Name = "Questions"
        Me.Questions.RowCount = 1
        Me.Questions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Questions.Size = New System.Drawing.Size(1157, 570)
        Me.Questions.TabIndex = 44
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Timers1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.QHead, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Questions, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.JQControls, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1163, 769)
        Me.TableLayoutPanel1.TabIndex = 45
        '
        'B3Help
        '
        Me.B3Help.BackColor = System.Drawing.SystemColors.ControlLight
        Me.B3Help.Image = Global.Quiz_Maker.My.Resources.Resources.Help
        Me.B3Help.Location = New System.Drawing.Point(592, 710)
        Me.B3Help.Name = "B3Help"
        Me.B3Help.Size = New System.Drawing.Size(46, 48)
        Me.B3Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.B3Help.TabIndex = 43
        Me.B3Help.TabStop = False
        Me.B3Help.Visible = False
        '
        'JoinQ
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(1163, 769)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.B3Help)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JoinQ"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "صل العبارات الأتية بما يناسبها :-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.JQControls.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.B3Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Closeopen1 As Quiz_Maker.Closeopen
    Friend WithEvents Timers1 As Timers
    Friend WithEvents JQControls As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents QHead As Label
    Friend WithEvents B3Help As PictureBox
    Friend WithEvents Questions As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
