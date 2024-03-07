Public Class QMSettings
    Private Sub QMSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Paths.Instance.Paths_FormClosing(sender, e)
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text <> "" Then
            ShowP.Show()
        Else
            ShowP.Hide()
        End If
    End Sub

    Private Sub ASST_TextChanged(sender As Object, e As EventArgs) Handles ASST.TextChanged
        If Not (ASST.Text.ElementAt(ASST.Text.Length - 1) = "\") Then
            ASST.Text &= "\"
        End If
        If IO.Directory.Exists(sender.text) Then
            Button1.BackgroundImage = My.Resources.Tick
        Else
            Button1.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub ASSC_CheckedChanged(sender As Object, e As EventArgs) Handles ASSC.CheckedChanged
        If sender.checked Then
            ASST.Enabled = True
            Button1.Enabled = True
        Else
            ASST.Enabled = False
            Button1.Enabled = False
            Button1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub NameC_CheckedChanged(sender As Object, e As EventArgs) Handles NameC.CheckedChanged
        If sender.checked Then
            NameMax.Enabled = True
            NameMin.Enabled = True
        Else
            NameMax.Enabled = False
            NameMin.Enabled = False
        End If
    End Sub

    Private Sub Min_ValueChanged(sender As Object, e As EventArgs) Handles Min.ValueChanged
        If Min.Value = 0 AndAlso Hou.Value = 0 Then
            Sec.Minimum = 1
        Else
            Sec.Minimum = 0
        End If
    End Sub

    Private Sub NameMin_ValueChanged(sender As Object, e As EventArgs) Handles NameMin.ValueChanged
        NameMax.Minimum = NameMin.Value + 1
    End Sub

    Private Sub NameMax_ValueChanged(sender As Object, e As EventArgs) Handles NameMax.ValueChanged
        NameMin.Maximum = NameMax.Value - 1
    End Sub
    Private Sub ShowP_MouseDown(sender As Object, e As MouseEventArgs) Handles ShowP.MouseDown
        TextBox6.UseSystemPasswordChar = False
    End Sub

    Private Sub ShowP_MouseUp(sender As Object, e As MouseEventArgs) Handles ShowP.MouseUp
        TextBox6.UseSystemPasswordChar = True
    End Sub

    Private Sub Timer_CheckedChanged(sender As Object, e As EventArgs) Handles Timer.CheckedChanged
        Hou.Enabled = sender.Checked
        Min.Enabled = sender.Checked
        Sec.Enabled = sender.Checked
        Subs.Timer = sender.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ASS.ShowDialog = DialogResult.OK Then
            ASST.Text = ASS.SelectedPath
        End If
    End Sub

    Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Paths.Instance.Paths_FormClosing(sender, e)
    End Sub

    Private Sub QuizD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuizD.SelectedIndexChanged
        If Visible Then Tip.Show("يتطلب إعادة تشغيل البرنامج لتطبيق التغييرات", Me, sender.Location.X, sender.Location.y, 2300)
    End Sub

    Private Sub Feed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Feed.SelectedIndexChanged
        If Visible Then Tip.Show("يتطلب إعادة تشغيل البرنامج لتطبيق التغييرات", Me, sender.Location.X, sender.Location.y, 2300)
    End Sub

    Private Sub Update_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Update.SelectedIndexChanged
        If Visible Then Tip.Show("يتطلب إعادة تشغيل البرنامج لتطبيق التغييرات", Me, sender.Location.X, sender.Location.y, 2300)
    End Sub
End Class