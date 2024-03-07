Public Class QMSettings
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        If TextBox6.Text <> "" Then
            ShowP.Show()
        Else
            ShowP.Hide()
        End If
    End Sub

    Private Sub ASST_TextChanged(sender As Object, e As EventArgs)
        If IO.Directory.Exists(sender.text) Then
            Button1.BackgroundImage = My.Resources.Tick
        Else
            Button1.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub ASSC_CheckedChanged(sender As Object, e As EventArgs)
        If sender.checked Then
            ASST.Enabled = True
            Button1.Enabled = True
        Else
            ASST.Enabled = False
            Button1.Enabled = False
            Button1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub NameC_CheckedChanged(sender As Object, e As EventArgs)
        If sender.checked Then
            NameMax.Enabled = True
            NameMin.Enabled = True
        Else
            NameMax.Enabled = False
            NameMin.Enabled = False
        End If
    End Sub

    Private Sub Min_ValueChanged(sender As Object, e As EventArgs)
        If Min.Value = 0 And Hou.Value = 0 Then
            Sec.Minimum = 1
        Else
            Sec.Minimum = 0
        End If
    End Sub

    Private Sub NameMin_ValueChanged(sender As Object, e As EventArgs)
        NameMax.Minimum = NameMin.Value + 1
    End Sub

    Private Sub NameMax_ValueChanged(sender As Object, e As EventArgs)
        NameMin.Maximum = NameMax.Value - 1
    End Sub
    Private Sub ShowP_MouseDown(sender As Object, e As MouseEventArgs)
        TextBox6.UseSystemPasswordChar = False
    End Sub

    Private Sub ShowP_MouseUp(sender As Object, e As MouseEventArgs)
        TextBox6.UseSystemPasswordChar = True
    End Sub

    Private Sub Timer_CheckedChanged(sender As Object, e As EventArgs)
        If sender.checked = True Then
            Hou.Enabled = True
            Min.Enabled = True
            Sec.Enabled = True
        Else
            Hou.Enabled = False
            Min.Enabled = False
            Sec.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If ASS.ShowDialog = DialogResult.OK Then
            ASST.Text = ASS.SelectedPath
        End If
    End Sub

    Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Databasesselecter.Databasesselecter_FormClosing(sender, e)
    End Sub
End Class