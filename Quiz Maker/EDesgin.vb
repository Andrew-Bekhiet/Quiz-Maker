Imports System.IO
Imports System.Net

Public Class EDesgin
    Private MainDB As New ADODB.Connection()
    Private SelectDT As New ADODB.Recordset()
    Private CompleteDT As New ADODB.Recordset()
    Private JoinDT As New ADODB.Recordset()
    Public SelectA As New List(Of List(Of String))
    Private Sub EDesgin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub JoinC_CheckedChanged(sender As Object, e As EventArgs) Handles JoinC.CheckedChanged
        JoinG.Enabled = sender.checked
    End Sub

    Private Sub CompleteC_CheckedChanged(sender As Object, e As EventArgs) Handles CompleteC.CheckedChanged
        CompleteG.Enabled = sender.checked
    End Sub

    Private Sub SelectC_CheckedChanged(sender As Object, e As EventArgs) Handles SelectC.CheckedChanged
        SelectG.Enabled = sender.checked
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MainDB.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & Paths.Instance.TextBox1.Text & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.SelectP.Text, Paths.Instance.SelectPC.Checked))
        SelectDT.Open(Paths.Instance.SelectT.Text, MainDB, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
        Do While Not (SelectDT.EOF)
            SelectDT.Delete()
            SelectDT.Update()
            SelectDT.MoveNext()
        Loop
        For i = 0 To SelectG.Rows.Count - 1
            SelectDT.AddNew()
            SelectDT.Fields("Question").Value = SelectG.Item(0, i).Value
            SelectDT.Fields("Answer 1").Value = SelectG.Item(1, i).Value
            SelectDT.Fields("Answer 2").Value = SelectG.Item(2, i).Value
            SelectDT.Fields("Answer 3").Value = SelectG.Item(3, i).Value
            SelectDT.Fields("Answer 4").Value = SelectG.Item(4, i).Value
            SelectDT.Fields("RAnswer").Value = SelectG.Item(5, i).Value
            SelectDT.Fields("Degree").Value = SelectG.Item(6, i).Value
            SelectDT.Update()
        Next
        SelectDT.UpdateBatch()
        SelectDT.Close()
        MainDB.Close()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        MainDB.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & Paths.Instance.TextBox1.Text & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.SelectP.Text, Paths.Instance.SelectPC.Checked))
        SelectDT.Open(Paths.Instance.SelectT.Text, MainDB)
        SelectG.DataSource = SelectDT
        SelectG.DataSource = Nothing
        SelectDT.MoveFirst()
        SelectA = New List(Of List(Of String))
        While Not (SelectDT.EOF)
            SelectA.Add(New List(Of String))
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Question").Value.ToString.Split(",")(0))
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Answer 1").Value.ToString)
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Answer 2").Value.ToString)
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Answer 3").Value.ToString)
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Answer 4").Value.ToString)
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("RAnswer").Value.ToString)
            SelectA(SelectA.Count - 1).Add(SelectDT.Fields("Degree").Value.ToString)
            SelectG.Rows.Add(SelectDT.Fields("Question").Value.ToString.Split(",")(0), SelectDT.Fields("Answer 1").Value, SelectDT.Fields("Answer 2").Value, SelectDT.Fields("Answer 3").Value, SelectDT.Fields("Answer 4").Value, SelectDT.Fields("RAnswer").Value, SelectDT.Fields("Degree").Value)
            SelectG.Item(0, SelectG.Rows.Count - 1).Tag = SelectDT.Fields("Question").Value
            SelectDT.MoveNext()
        End While
        SelectDT.Close()
        MainDB.Close()
    End Sub

    Private Sub SelectG_Button_TxtChng(sender As System.Object, e As DataGridViewCellEventArgs) Handles SelectG.CellErrorTextChanged
        Debug.WriteLine(DirectCast(sender, DataGridView))
    End Sub

    Public Sub SelectG_Button_Click(sender As System.Object, e As DataGridViewCellEventArgs) Handles SelectG.CellClick

        Dim senderGrid = DirectCast(sender, DataGridView)
        'MsgBox(DirectCast(SelectG(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell).Tag)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim I() As String = SelectA(e.RowIndex)(0).Split(",")
            EditQFrmt.Q.Text = I(0)
            If I.Length < 2 Then
                EditQFrmt.Q.Font = New Font("Tahoma", 14)
                EditQFrmt.Pic.ImageLocation = ""
            ElseIf I.Length < 3 Then
                EditQFrmt.Q.Font = New Font(I(1), 14)
                EditQFrmt.Pic.ImageLocation = ""
            ElseIf I.Length < 4 Then
                Dim wc As New WebClient()
                Dim bytes As Byte() = wc.DownloadData(I(3))
                Dim ms As New MemoryStream(bytes)
                Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                EditQFrmt.Pic.Image = img
            End If
            If EditQFrmt.ShowDialog() = DialogResult.OK Then
                Debug.WriteLine(EditQFrmt.Q.Text)
                Debug.WriteLine(EditQFrmt.Q.Font.Name.ToString)
                Debug.WriteLine(EditQFrmt.Q.Font.Size)
                Debug.WriteLine(EditQFrmt.Pic.ImageLocation.ToString)
                SelectA(e.RowIndex)(0) = EditQFrmt.Q.Text & "," & EditQFrmt.Q.Font.Name.ToString & "," & EditQFrmt.Q.Font.Size & "," & EditQFrmt.Pic.ImageLocation.ToString
                MainDB.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & Paths.Instance.TextBox1.Text & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.SelectP.Text, Paths.Instance.SelectPC.Checked))
                SelectDT.Open(Paths.Instance.SelectT.Text, MainDB, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                SelectDT.MoveFirst()
                For counter = 1 To SelectA.Count
                    Try
                        SelectDT.Delete()
                        SelectDT.Update()
                        SelectDT.MoveNext()
                    Catch ex As Runtime.InteropServices.COMException
                        If ex.Message <> "Either BOF or EOF is True, or the current record has been deleted. Requested operation requires a current record." Then
                            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
                        Else
                            Exit For
                        End If
                    End Try
                Next

                For Each item As List(Of String) In SelectA
                    SelectDT.AddNew()
                    SelectDT.Fields("Question").Value = item(0)
                    SelectDT.Fields("Answer 1").Value = item(1)
                    SelectDT.Fields("Answer 2").Value = item(2)
                    SelectDT.Fields("Answer 3").Value = item(3)
                    SelectDT.Fields("Answer 4").Value = item(4)
                    SelectDT.Fields("RAnswer").Value = item(5)
                    SelectDT.Fields("Degree").Value = item(6)
                    SelectDT.Update()
                Next
                SelectDT.Close()
                MainDB.Close()
                Refresh_Click(Nothing, Nothing)
            End If
        End If

    End Sub
End Class