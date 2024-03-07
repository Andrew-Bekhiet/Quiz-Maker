Public Class Closeopen
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        C = True
        JoinQ.Close()
        JoinAC1 = New List(Of String)
        JoinAC2 = New List(Of String)
        JoinD2 = New List(Of Double)
        JoinTF = New List(Of Boolean)
        C = False
        JoinQ.Show()
    End Sub
End Class
