<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EDesgin
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SelectG = New System.Windows.Forms.DataGridView()
        Me.Question = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Answer1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Answer2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Answer3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Answer4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectC = New System.Windows.Forms.CheckBox()
        Me.CompleteC = New System.Windows.Forms.CheckBox()
        Me.CompleteG = New System.Windows.Forms.DataGridView()
        Me.Question2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RA3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.JoinC = New System.Windows.Forms.CheckBox()
        Me.JoinG = New System.Windows.Forms.DataGridView()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Q = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TQI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PathsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SelectG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.JoinG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PathsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectG
        '
        Me.SelectG.AllowUserToOrderColumns = True
        Me.SelectG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.SelectG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Question, Me.Answer1, Me.Answer2, Me.Answer3, Me.Answer4, Me.RAnswer, Me.Degree})
        Me.SelectG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectG.EnableHeadersVisualStyles = False
        Me.SelectG.GridColor = System.Drawing.SystemColors.Control
        Me.SelectG.Location = New System.Drawing.Point(3, 48)
        Me.SelectG.Name = "SelectG"
        Me.SelectG.Size = New System.Drawing.Size(1063, 198)
        Me.SelectG.TabIndex = 1
        '
        'Question
        '
        Me.Question.HeaderText = "السؤال"
        Me.Question.Name = "Question"
        Me.Question.Text = "إظهار نص وتنسيق السؤال ..."
        Me.Question.ToolTipText = "نص السؤال"
        Me.Question.Width = 250
        '
        'Answer1
        '
        Me.Answer1.HeaderText = "الإجابة 1"
        Me.Answer1.Name = "Answer1"
        Me.Answer1.ToolTipText = "الإختيار الأول"
        Me.Answer1.Width = 125
        '
        'Answer2
        '
        Me.Answer2.HeaderText = "الإجابة 2"
        Me.Answer2.Name = "Answer2"
        Me.Answer2.ToolTipText = "الإختيار الثاني"
        Me.Answer2.Width = 125
        '
        'Answer3
        '
        Me.Answer3.HeaderText = "الإجابة 3"
        Me.Answer3.Name = "Answer3"
        Me.Answer3.ToolTipText = "الإختيار الثالث"
        Me.Answer3.Width = 125
        '
        'Answer4
        '
        Me.Answer4.HeaderText = "الإجابة 4"
        Me.Answer4.Name = "Answer4"
        Me.Answer4.ToolTipText = "الإختيار الرابع"
        Me.Answer4.Width = 125
        '
        'RAnswer
        '
        Me.RAnswer.HeaderText = "الإجابة الصحيحة"
        Me.RAnswer.Name = "RAnswer"
        Me.RAnswer.ToolTipText = "الإختيار الصحيح"
        '
        'Degree
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Degree.DefaultCellStyle = DataGridViewCellStyle1
        Me.Degree.HeaderText = "درجة السؤال"
        Me.Degree.Name = "Degree"
        Me.Degree.ToolTipText = "درجة السؤال في حالة كانت الإجابة صحيحة"
        '
        'SelectC
        '
        Me.SelectC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SelectC.Location = New System.Drawing.Point(3, 3)
        Me.SelectC.Name = "SelectC"
        Me.SelectC.Size = New System.Drawing.Size(1063, 39)
        Me.SelectC.TabIndex = 2
        Me.SelectC.Text = "سؤال اختر"
        Me.SelectC.UseVisualStyleBackColor = True
        '
        'CompleteC
        '
        Me.CompleteC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompleteC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CompleteC.Location = New System.Drawing.Point(3, 252)
        Me.CompleteC.Name = "CompleteC"
        Me.CompleteC.Size = New System.Drawing.Size(1063, 39)
        Me.CompleteC.TabIndex = 2
        Me.CompleteC.Text = "سؤال أكمل"
        Me.CompleteC.UseVisualStyleBackColor = True
        '
        'CompleteG
        '
        Me.CompleteG.AllowUserToOrderColumns = True
        Me.CompleteG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompleteG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Question2, Me.RA1, Me.RA2, Me.RA3, Me.Degree2})
        Me.CompleteG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompleteG.EnableHeadersVisualStyles = False
        Me.CompleteG.Location = New System.Drawing.Point(3, 297)
        Me.CompleteG.Name = "CompleteG"
        Me.CompleteG.Size = New System.Drawing.Size(1063, 198)
        Me.CompleteG.TabIndex = 1
        '
        'Question2
        '
        Me.Question2.HeaderText = "السؤال"
        Me.Question2.Name = "Question2"
        Me.Question2.Width = 250
        '
        'RA1
        '
        Me.RA1.HeaderText = "الإجابة الصحيحة 1"
        Me.RA1.Name = "RA1"
        Me.RA1.Width = 125
        '
        'RA2
        '
        Me.RA2.HeaderText = "الإجابة الصحيحة 2"
        Me.RA2.Name = "RA2"
        Me.RA2.Width = 125
        '
        'RA3
        '
        Me.RA3.HeaderText = "الإجابة الصحيحة 3"
        Me.RA3.Name = "RA3"
        Me.RA3.Width = 125
        '
        'Degree2
        '
        Me.Degree2.HeaderText = "درجة السؤال"
        Me.Degree2.Name = "Degree2"
        '
        'CheckBox3
        '
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(12, 756)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(159, 32)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "سؤال التوصيل"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SelectC, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectG, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CompleteG, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CompleteC, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.JoinC, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.JoinG, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.091288!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.24296!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.089917!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.24296!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.089917!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.24296!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1069, 752)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'JoinC
        '
        Me.JoinC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JoinC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.JoinC.Location = New System.Drawing.Point(3, 501)
        Me.JoinC.Name = "JoinC"
        Me.JoinC.Size = New System.Drawing.Size(1063, 39)
        Me.JoinC.TabIndex = 2
        Me.JoinC.Text = "سؤال وصل"
        Me.JoinC.UseVisualStyleBackColor = True
        '
        'JoinG
        '
        Me.JoinG.AllowUserToOrderColumns = True
        Me.JoinG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JoinG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.A, Me.TAI, Me.Q, Me.TQI, Me.Degree3})
        Me.JoinG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JoinG.Location = New System.Drawing.Point(3, 546)
        Me.JoinG.Name = "JoinG"
        Me.JoinG.Size = New System.Drawing.Size(1063, 203)
        Me.JoinG.TabIndex = 3
        '
        'A
        '
        Me.A.HeaderText = "السؤال"
        Me.A.Name = "A"
        Me.A.Width = 250
        '
        'TAI
        '
        Me.TAI.HeaderText = "الحرف المشترك للسؤال"
        Me.TAI.Name = "TAI"
        '
        'Q
        '
        Me.Q.HeaderText = "الإجابة"
        Me.Q.Name = "Q"
        Me.Q.Width = 250
        '
        'TQI
        '
        Me.TQI.HeaderText = "الحرف المشترك للإجابة"
        Me.TQI.Name = "TQI"
        '
        'Degree3
        '
        Me.Degree3.HeaderText = "الدرجة"
        Me.Degree3.Name = "Degree3"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1075, 30)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 27)
        Me.ToolStripButton1.Text = "حفظ"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 27)
        Me.ToolStripButton2.Text = "إعادة تحميل"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.93401!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.06599!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1075, 788)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'PathsBindingSource
        '
        Me.PathsBindingSource.DataSource = GetType(Quiz_Maker.Paths)
        '
        'EDesgin
        '
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1092, 652)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.CheckBox3)
        Me.Name = "EDesgin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "التصميم السهل"
        CType(Me.SelectG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.JoinG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PathsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectG As DataGridView
    Friend WithEvents SelectC As CheckBox
    Friend WithEvents CompleteC As CheckBox
    Friend WithEvents CompleteG As DataGridView
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents JoinC As CheckBox
    Friend WithEvents JoinG As DataGridView
    Friend WithEvents Question2 As DataGridViewTextBoxColumn
    Friend WithEvents RA1 As DataGridViewTextBoxColumn
    Friend WithEvents RA2 As DataGridViewTextBoxColumn
    Friend WithEvents RA3 As DataGridViewTextBoxColumn
    Friend WithEvents Degree2 As DataGridViewTextBoxColumn
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents TAI As DataGridViewTextBoxColumn
    Friend WithEvents Q As DataGridViewTextBoxColumn
    Friend WithEvents TQI As DataGridViewTextBoxColumn
    Friend WithEvents Degree3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Answer1 As DataGridViewTextBoxColumn
    Friend WithEvents Answer2 As DataGridViewTextBoxColumn
    Friend WithEvents Answer3 As DataGridViewTextBoxColumn
    Friend WithEvents Answer4 As DataGridViewTextBoxColumn
    Friend WithEvents RAnswer As DataGridViewTextBoxColumn
    Friend WithEvents Degree As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn As DataGridViewButtonColumn
    Friend WithEvents Question As DataGridViewButtonColumn
    Friend WithEvents PathsBindingSource As BindingSource
End Class
