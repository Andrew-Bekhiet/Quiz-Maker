<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhoQuizzed
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
        Me.List = New System.Windows.Forms.ListView()
        Me.Nam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SelectV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompleteV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JoinV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ArrangeV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimerV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalDegrees = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Final = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Percent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valuation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Success = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathToDB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nam, Me.SelectV, Me.CompleteV, Me.JoinV, Me.ArrangeV, Me.TimerV, Me.TotalDegrees, Me.Final, Me.Percent, Me.Valuation, Me.Success, Me.PathToDB})
        Me.List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List.HideSelection = False
        Me.List.Location = New System.Drawing.Point(0, 0)
        Me.List.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.List.Name = "List"
        Me.List.RightToLeftLayout = True
        Me.List.Size = New System.Drawing.Size(1252, 762)
        Me.List.TabIndex = 0
        Me.List.UseCompatibleStateImageBehavior = False
        Me.List.View = System.Windows.Forms.View.Details
        '
        'Nam
        '
        Me.Nam.Text = "الإسم"
        Me.Nam.Width = 173
        '
        'SelectV
        '
        Me.SelectV.Text = "درجة السؤال الاختياري"
        Me.SelectV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SelectV.Width = 227
        '
        'CompleteV
        '
        Me.CompleteV.Text = "درجة سؤال أكمل"
        Me.CompleteV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompleteV.Width = 177
        '
        'JoinV
        '
        Me.JoinV.Text = "درجة سؤال التوصيل"
        Me.JoinV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.JoinV.Width = 215
        '
        'ArrangeV
        '
        Me.ArrangeV.Text = "درجة سؤال الترتيب"
        Me.ArrangeV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ArrangeV.Width = 0
        '
        'TimerV
        '
        Me.TimerV.Text = "المؤقت"
        Me.TimerV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimerV.Width = 90
        '
        'TotalDegrees
        '
        Me.TotalDegrees.Text = "المجموع"
        Me.TotalDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalDegrees.Width = 108
        '
        'Final
        '
        Me.Final.Text = "الدرجة النهائية"
        Me.Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Final.Width = 149
        '
        'Percent
        '
        Me.Percent.Text = "النسبة"
        Me.Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Percent.Width = 82
        '
        'Valuation
        '
        Me.Valuation.Text = "التقدير"
        Me.Valuation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Valuation.Width = 80
        '
        'Success
        '
        Me.Success.Text = "النجاح"
        Me.Success.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Success.Width = 77
        '
        'PathToDB
        '
        Me.PathToDB.Text = "مكان الإمتحان"
        '
        'WhoQuizzed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1252, 762)
        Me.Controls.Add(Me.List)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "WhoQuizzed"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الممتحنون"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents List As ListView
    Friend WithEvents Nam As ColumnHeader
    Friend WithEvents SelectV As ColumnHeader
    Friend WithEvents CompleteV As ColumnHeader
    Friend WithEvents JoinV As ColumnHeader
    Friend WithEvents ArrangeV As ColumnHeader
    Friend WithEvents TimerV As ColumnHeader
    Friend WithEvents TotalDegrees As ColumnHeader
    Friend WithEvents Final As ColumnHeader
    Friend WithEvents Percent As ColumnHeader
    Friend WithEvents Valuation As ColumnHeader
    Friend WithEvents Success As ColumnHeader
    Friend WithEvents PathToDB As ColumnHeader
End Class
