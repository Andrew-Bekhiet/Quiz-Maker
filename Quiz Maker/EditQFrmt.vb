Imports System.IO
Imports System.Net

Public Class EditQFrmt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChngFnt.Click
        FntDilg.Font = Q.Font
        If FntDilg.ShowDialog() = DialogResult.OK Then
            Q.Font = FntDilg.Font
            Debug.WriteLine(FntDilg.Font.ToString())
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If PicDilg.ShowDialog() = DialogResult.OK Then
            Dim wc As New WebClient()
            Dim bytes As Byte() = wc.DownloadData(PicDilg.FileName)
            Dim ms As New MemoryStream(bytes)
            Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            Pic.Image = img
            Pic.ImageLocation = PicDilg.FileName
        End If
    End Sub
End Class
