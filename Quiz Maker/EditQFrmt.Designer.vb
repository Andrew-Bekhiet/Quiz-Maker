<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditQFrmt
    Inherits System.Windows.Forms.Form

    'UserControl overrides dispose to clean up the component list.
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
        Me.Q = New System.Windows.Forms.TextBox()
        Me.FntDilg = New System.Windows.Forms.FontDialog()
        Me.ChngFnt = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PicDilg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q
        '
        Me.Q.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Q.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q.Location = New System.Drawing.Point(12, 33)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(511, 24)
        Me.Q.TabIndex = 0
        '
        'FntDilg
        '
        Me.FntDilg.ShowApply = True
        Me.FntDilg.ShowColor = True
        Me.FntDilg.ShowEffects = False
        '
        'ChngFnt
        '
        Me.ChngFnt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChngFnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChngFnt.Location = New System.Drawing.Point(12, 66)
        Me.ChngFnt.Name = "ChngFnt"
        Me.ChngFnt.Size = New System.Drawing.Size(511, 62)
        Me.ChngFnt.TabIndex = 1
        Me.ChngFnt.Text = "تغيير الخط"
        Me.ChngFnt.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic.Location = New System.Drawing.Point(530, 33)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(473, 331)
        Me.Pic.TabIndex = 3
        Me.Pic.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "السؤال:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(526, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "معاينة للصورة:"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(511, 62)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "تغيير الصورة المصاحبة للسؤال"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(511, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "معاينة السؤال"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(12, 279)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(253, 82)
        Me.OK.TabIndex = 1
        Me.OK.Text = "حسنا"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(270, 279)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(253, 82)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "إلغاء الأمر"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'PicDilg
        '
        Me.PicDilg.FileName = "OpenFileDialog1"
        Me.PicDilg.Filter = "كل ملفات الصور|*.bmp,*.jpg,*.gif,*.png,*.tiff,*.jpeg|كل الملفات|*.*"
        Me.PicDilg.InitialDirectory = """Desktop"""
        Me.PicDilg.Title = "صورة السؤال"
        '
        'EditQFrmt
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1009, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChngFnt)
        Me.Controls.Add(Me.Q)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EditQFrmt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تعديل السؤال"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Q As TextBox
    Friend WithEvents FntDilg As FontDialog
    Friend WithEvents ChngFnt As Button
    Friend WithEvents Pic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PicDilg As OpenFileDialog
End Class
