Public Class Timers
    Private Sub Timers_visiblechan(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not (ontime) AndAlso Result.Visible = False AndAlso Subs.Timer Then
            If QMSettings.Timer.Checked = True Then
                hou2.Text = QMSettings.Hou.Value
                min2.Text = QMSettings.Min.Value
                sec2.Text = QMSettings.Sec.Value
                Hou = hou2.Text
                Min = min2.Text
                Sec = sec2.Text
                ProgressBar.Maximum = ((((QMSettings.Hou.Value * 60) * 60) + (QMSettings.Min.Value * 60) + QMSettings.Sec.Value))
                ProgressBar.Value = ProgressBar.Maximum
                ontime = True
            ElseIf QMSettings.Timer.Checked = False Then
                sec2.Hide()
                min2.Hide()
                hou2.Hide()
                ProgressBar.Hide()
            End If
        ElseIf ontime Then
            hou2.Text = Hou
            min2.Text = Min
            sec2.Text = Sec
            ProgressBar.Maximum = ((((QMSettings.Hou.Value * 60) * 60) + (QMSettings.Min.Value * 60) + QMSettings.Sec.Value))
            ProgressBar.Value = ProgressBar.Maximum
            ontime = True
        End If
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Subs.TimerControls.Add(Me)
    End Sub
End Class
