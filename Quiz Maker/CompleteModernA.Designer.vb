<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompleteModernA
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
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'Table1
        '
        Me.Table1.ColumnCount = 1
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table1.Location = New System.Drawing.Point(3, 3)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 1
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table1.Size = New System.Drawing.Size(1120, 215)
        Me.Table1.TabIndex = 0
        '
        'CompleteModernA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.Table1)
        Me.Name = "CompleteModernA"
        Me.Size = New System.Drawing.Size(1125, 233)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Table1 As TableLayoutPanel
End Class
