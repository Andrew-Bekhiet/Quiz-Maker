<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arrangement
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
        Me.L1 = New System.Windows.Forms.TableLayoutPanel()
        Me.QHead = New System.Windows.Forms.Label()
        Me.Table = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timers1 = New Quiz_Maker.Timers()
        Me.L1.SuspendLayout()
        Me.TLP2.SuspendLayout()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.ColumnCount = 1
        Me.L1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.L1.Controls.Add(Me.Timers1, 0, 0)
        Me.L1.Controls.Add(Me.QHead, 0, 1)
        Me.L1.Controls.Add(Me.Table, 0, 2)
        Me.L1.Controls.Add(Me.TLP2, 0, 3)
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.RowCount = 4
        Me.L1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.L1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.L1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.98718!))
        Me.L1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.14103!))
        Me.L1.Size = New System.Drawing.Size(963, 624)
        Me.L1.TabIndex = 1
        '
        'QHead
        '
        Me.QHead.AutoSize = True
        Me.QHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QHead.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.QHead.Location = New System.Drawing.Point(3, 93)
        Me.QHead.Name = "QHead"
        Me.QHead.Size = New System.Drawing.Size(957, 31)
        Me.QHead.TabIndex = 36
        Me.QHead.Text = "رتب العبارات التالية من الأول إلى الآخر:-"
        '
        'Table
        '
        Me.Table.ColumnCount = 1
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 127)
        Me.Table.Name = "Table"
        Me.Table.RowCount = 1
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table.Size = New System.Drawing.Size(957, 411)
        Me.Table.TabIndex = 37
        '
        'TLP2
        '
        Me.TLP2.ColumnCount = 2
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP2.Controls.Add(Me.Button2, 0, 0)
        Me.TLP2.Controls.Add(Me.Button1, 1, 0)
        Me.TLP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP2.Location = New System.Drawing.Point(3, 544)
        Me.TLP2.Name = "TLP2"
        Me.TLP2.RowCount = 1
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TLP2.Size = New System.Drawing.Size(957, 77)
        Me.TLP2.TabIndex = 36
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
        Me.Button2.Location = New System.Drawing.Point(482, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(472, 71)
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
        Me.Button1.Image = Global.Quiz_Maker.My.Resources.Resources.Start
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(473, 71)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "إنهاء"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timers1
        '
        Me.Timers1.BackColor = System.Drawing.Color.Transparent
        Me.Timers1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Timers1.Location = New System.Drawing.Point(3, 3)
        Me.Timers1.Name = "Timers1"
        Me.Timers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Timers1.Size = New System.Drawing.Size(957, 87)
        Me.Timers1.TabIndex = 0
        '
        'Arrangement
        '
        Me.ClientSize = New System.Drawing.Size(963, 624)
        Me.ControlBox = False
        Me.Controls.Add(Me.L1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Arrangement"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "رتب ما يلي:-"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.L1.ResumeLayout(False)
        Me.L1.PerformLayout()
        Me.TLP2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timers1 As Timers
    Friend WithEvents L1 As TableLayoutPanel
    Friend WithEvents TLP2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents QHead As Label
    Friend WithEvents Table As TableLayoutPanel
End Class
