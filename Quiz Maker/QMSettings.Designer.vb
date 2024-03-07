<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.ASS = New System.Windows.Forms.FolderBrowserDialog()
        Me.NameMax = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NameMin = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Hou = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Min = New System.Windows.Forms.NumericUpDown()
        Me.Sec = New System.Windows.Forms.NumericUpDown()
        Me.NameC = New System.Windows.Forms.CheckBox()
        Me.ASSC = New System.Windows.Forms.CheckBox()
        Me.Timer = New System.Windows.Forms.CheckBox()
        Me.ASST = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Previous = New System.Windows.Forms.CheckBox()
        Me.Update = New System.Windows.Forms.ComboBox()
        Me.Feed = New System.Windows.Forms.ComboBox()
        Me.QuizD = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowP = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NameMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameMax
        '
        Me.NameMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameMax.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NameMax.Location = New System.Drawing.Point(429, 79)
        Me.NameMax.Name = "NameMax"
        Me.NameMax.Size = New System.Drawing.Size(50, 27)
        Me.NameMax.TabIndex = 12
        Me.NameMax.Value = New Decimal(New Integer() {24, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(477, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "<"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameMin
        '
        Me.NameMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameMin.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NameMin.Location = New System.Drawing.Point(658, 79)
        Me.NameMin.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NameMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NameMin.Name = "NameMin"
        Me.NameMin.Size = New System.Drawing.Size(50, 27)
        Me.NameMin.TabIndex = 11
        Me.NameMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(511, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "عدد أحرف الإسم"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(626, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "<"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(447, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Tip.SetToolTip(Me.Button1, "المكان الذي سيتم فيه حفظ قواعد بيانات الممتحنين في حالة التصحيح اليدوي")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(127, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(198, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = ":"
        '
        'Hou
        '
        Me.Hou.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Hou.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Hou.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Hou.Location = New System.Drawing.Point(71, 11)
        Me.Hou.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.Hou.Name = "Hou"
        Me.Hou.Size = New System.Drawing.Size(50, 27)
        Me.Hou.TabIndex = 6
        Me.Hou.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(747, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "كلمة السر"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Min
        '
        Me.Min.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Min.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Min.Location = New System.Drawing.Point(146, 11)
        Me.Min.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(50, 27)
        Me.Min.TabIndex = 5
        '
        'Sec
        '
        Me.Sec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Sec.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Sec.Location = New System.Drawing.Point(221, 11)
        Me.Sec.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Sec.Name = "Sec"
        Me.Sec.Size = New System.Drawing.Size(50, 27)
        Me.Sec.TabIndex = 4
        '
        'NameC
        '
        Me.NameC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameC.Checked = True
        Me.NameC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NameC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NameC.Location = New System.Drawing.Point(707, 80)
        Me.NameC.Name = "NameC"
        Me.NameC.Size = New System.Drawing.Size(184, 23)
        Me.NameC.TabIndex = 10
        Me.NameC.Text = "الحد من طول الإسم:"
        Me.NameC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ASSC
        '
        Me.ASSC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASSC.Checked = True
        Me.ASSC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ASSC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ASSC.Location = New System.Drawing.Point(742, 12)
        Me.ASSC.Name = "ASSC"
        Me.ASSC.Size = New System.Drawing.Size(149, 22)
        Me.ASSC.TabIndex = 0
        Me.ASSC.Text = "حفظ الإجابات"
        Me.ASSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.ASSC, "المكان الذي سيتم فيه حفظ قواعد بيانات الممتحنين في حالة التصحيح اليدوي")
        '
        'Timer
        '
        Me.Timer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Timer.Checked = True
        Me.Timer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Timer.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Timer.Location = New System.Drawing.Point(329, 11)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(109, 24)
        Me.Timer.TabIndex = 3
        Me.Timer.Text = "المؤقت"
        Me.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Timer.UseVisualStyleBackColor = True
        '
        'ASST
        '
        Me.ASST.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASST.Location = New System.Drawing.Point(484, 16)
        Me.ASST.Name = "ASST"
        Me.ASST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ASST.Size = New System.Drawing.Size(237, 20)
        Me.ASST.TabIndex = 1
        Me.Tip.SetToolTip(Me.ASST, "المكان الذي سيتم فيه حفظ قواعد بيانات الممتحنين في حالة التصحيح اليدوي")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Previous)
        Me.Panel1.Controls.Add(Me.Update)
        Me.Panel1.Controls.Add(Me.Feed)
        Me.Panel1.Controls.Add(Me.QuizD)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NameMax)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.NameMin)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ShowP)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Hou)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Min)
        Me.Panel1.Controls.Add(Me.Sec)
        Me.Panel1.Controls.Add(Me.NameC)
        Me.Panel1.Controls.Add(Me.ASSC)
        Me.Panel1.Controls.Add(Me.Timer)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.ASST)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 258)
        Me.Panel1.TabIndex = 0
        '
        'Previous
        '
        Me.Previous.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Previous.Location = New System.Drawing.Point(787, 213)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(104, 24)
        Me.Previous.TabIndex = 24
        Me.Previous.Text = "لا تراجع"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Update.FormattingEnabled = True
        Me.Update.Items.AddRange(New Object() {"بدون كلمة سر", "عن طريق كلمة السر", "مخفي"})
        Me.Update.Location = New System.Drawing.Point(581, 184)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(180, 27)
        Me.Update.TabIndex = 15
        '
        'Feed
        '
        Me.Feed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Feed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Feed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Feed.FormattingEnabled = True
        Me.Feed.Items.AddRange(New Object() {"بدون كلمة سر", "عن طريق كلمة السر", "مخفي"})
        Me.Feed.Location = New System.Drawing.Point(581, 151)
        Me.Feed.Name = "Feed"
        Me.Feed.Size = New System.Drawing.Size(180, 27)
        Me.Feed.TabIndex = 14
        '
        'QuizD
        '
        Me.QuizD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.QuizD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuizD.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.QuizD.FormattingEnabled = True
        Me.QuizD.Items.AddRange(New Object() {"بدون كلمة سر", "عن طريق كلمة السر", "مخفي"})
        Me.QuizD.Location = New System.Drawing.Point(581, 118)
        Me.QuizD.Name = "QuizD"
        Me.QuizD.Size = New System.Drawing.Size(180, 27)
        Me.QuizD.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(791, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "التحديث: "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(791, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ردود الفعل: "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(767, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "تصميم الإختبار: "
        '
        'ShowP
        '
        Me.ShowP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShowP.BackColor = System.Drawing.Color.White
        Me.ShowP.BackgroundImage = Global.Quiz_Maker.My.Resources.Resources.Pass
        Me.ShowP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ShowP.FlatAppearance.BorderSize = 0
        Me.ShowP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.ShowP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ShowP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowP.Location = New System.Drawing.Point(485, 55)
        Me.ShowP.Name = "ShowP"
        Me.ShowP.Size = New System.Drawing.Size(18, 18)
        Me.ShowP.TabIndex = 9
        Me.ShowP.UseVisualStyleBackColor = False
        Me.ShowP.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox6.Location = New System.Drawing.Point(484, 54)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(237, 20)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.UseSystemPasswordChar = True
        '
        'QMSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(896, 258)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QMSettings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الإعدادات"
        CType(Me.NameMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ASS As FolderBrowserDialog
    Friend WithEvents NameMax As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents NameMin As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ShowP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Hou As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Min As NumericUpDown
    Friend WithEvents Sec As NumericUpDown
    Friend WithEvents NameC As CheckBox
    Friend WithEvents ASSC As CheckBox
    Friend WithEvents Timer As CheckBox
    Friend WithEvents ASST As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Update As ComboBox
    Friend WithEvents Feed As ComboBox
    Friend WithEvents QuizD As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tip As ToolTip
    Friend WithEvents Previous As CheckBox
End Class
