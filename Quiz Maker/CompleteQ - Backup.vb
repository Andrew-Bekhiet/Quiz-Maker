Public Class CompleteQ
    Private Conn2 As ADODB.Connection = DB
    Private ConnStr2 As ADODB.Recordset = MainASSDB
    Private Conn As New ADODB.Connection()
    Private ConnStr As New ADODB.Recordset()
    Private Sub CompleteQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Databasesselecter.TextBox2.Text
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Try
            If Databasesselecter.CompletePC.Checked And Not (Conn.State = 1) Then
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & TextBox2.Text & ";Jet OLEDB:Database Password = " & Databasesselecter.CompleteP.Text)
            ElseIf Not (Conn.State = 1) Then
                Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & TextBox2.Text)
            End If
            ConnStr.Open(Databasesselecter.CompleteT.Text, Conn, ADODB.CursorTypeEnum.adOpenDynamic Or ADODB.CursorTypeEnum.adOpenKeyset Or ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic Or ADODB.LockTypeEnum.adLockBatchOptimistic Or ADODB.LockTypeEnum.adLockOptimistic)
        Catch
            MsgBox("(Complete)حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة", 0 Or 48 Or MsgBoxStyle.MsgBoxRight)
            Main.Show()
            Close()
            Exit Sub
        End Try
        ConnStr.MoveFirst()
        If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
            Label1.Text = Q(0).ToString()
            Try
                Label1.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                PictureBox1.ImageLocation = Q(3)
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            PictureBox1.ImageLocation = ""
            Label1.Text = ConnStr.Fields("Question").Value.ToString
        End If
        Label2.Text = ConnStr.Fields("Degree").Value.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ConnStr.BOF Then ConnStr.MoveFirst()
        Button2.Enabled = True
        If NP = 0 Then
            ConnStr2.MoveNext()
            ConnStr2.AddNew()
        Else
            NP -= 1
        End If
        ConnStr2.Fields("Q").Value = Label1.Text
        If TextBox1.Text = ConnStr.Fields("RA1").Value _
        Or TextBox1.Text = ConnStr.Fields("RA2").Value And Not (ConnStr.Fields("RA2").Value = "") _
        Or TextBox1.Text = ConnStr.Fields("RA3").Value And Not (ConnStr.Fields("RA3").Value = "") Then
            FMark.Value += Label2.Text
            ConnStr2.Fields("TF").Value = "True"
        Else
            ConnStr2.Fields("TF").Value = "False"
        End If
        ConnStr2.Fields("A").Value = TextBox1.Text
        ConnStr2.Fields("D").Value = Label2.Text
        ConnStr2.Update()
        ConnStr.MoveNext()
        If ConnStr.EOF Then
            If Databasesselecter.JoinC.Checked Then
                Try
                    JoinQ.Show()
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
            Else
                Result.Show()
            End If
            Hide()
            TextBox1.Text = ""
            Exit Sub
        ElseIf ConnStr.BOF Then
            TextBox1.Text = ""
            Exit Sub
        End If
        If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
            Label1.Text = Q(0).ToString()
            Try
                Label1.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                PictureBox1.ImageLocation = Q(3)
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            PictureBox1.ImageLocation = ""
            Label1.Text = ConnStr.Fields("Question").Value.ToString
        End If
        Label2.Text = ConnStr.Fields("Degree").Value.ToString
        If NP > 0 Then
            If Not (ConnStr2.Fields("Q").Value.ToString = "Select:") Then
                ConnStr2.MoveFirst()
                Do While Label1.Text <> ConnStr2.Fields("Q").Value.ToString.Split(",").ElementAt(0)
                    ConnStr2.MoveNext()
                Loop
                TextBox1.Text = ConnStr2.Fields("A").Value.ToString
            End If
        Else
            TextBox1.Text = ""
        End If
    End Sub
    Public Sub CompleteQ_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then e.Cancel = True
    End Sub
    Private Sub CompleteQ_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If ConnStr.State = 1 Then
                ConnStr.UpdateBatch()
                ConnStr.Close()
                Conn.Close()
            End If
            If ConnStr2.State = 1 Then
                ConnStr2.UpdateBatch()
                ConnStr2.Close()
                Conn2.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        SelectQ.Close()
    End Sub
    Private Sub SelectQ_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            If Conn2.State = 0 Then
                If QMSettings.ASSC.Checked = True Then
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & QMSettings.ASST.Text & "\" & Databasesselecter.Nam2.Text & ".mdb")
                Else
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\" & Databasesselecter.Nam2.Text & ".mdb")
                End If
                ConnStr2.Open("ASS", Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            End If
            ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = "Complete:"
            ConnStr2.Update()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (ConnStr2.BOF Or ConnStr.BOF Or ConnStr2.Fields("Q").Value = "Select:") Then
            ConnStr.MovePrevious()
            If ConnStr.BOF Then
                SelectQ.Previous_Click(sender, e)
                SelectQ.Show()
                Hide()
                Exit Sub
            End If
            If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
                Label1.Text = Q(0).ToString()
                Try
                    Label1.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                Label1.Text = ConnStr.Fields("Question").Value.ToString
            End If
            Label2.Text = ConnStr.Fields("Degree").Value.ToString
            NP += 1
            If Not (ConnStr2.Fields("Q").Value.ToString = "Select:") Then
                ConnStr2.MoveFirst()
                Do While Label1.Text <> ConnStr2.Fields("Q").Value.ToString.Split(",").ElementAt(0)
                    ConnStr2.MoveNext()
                Loop
                TextBox1.Text = ConnStr2.Fields("A").Value.ToString
            Else
                sender.enabled = False
            End If
        Else
            sender.enabled = False
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If sender.text = "......." Then
            sender.text = ""
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If sender.text = "" Then
            sender.text = "......."
        End If
    End Sub

    Private Sub CompleteQ_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
End Class