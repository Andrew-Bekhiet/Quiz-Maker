Public Class SelectQ
    Private Conn As New ADODB.Connection()
    Private ConnStr As New ADODB.Recordset()
    Private Conn2 As ADODB.Connection = DB
    Private ConnStr2 As ADODB.Recordset = MainASSDB
    Dim FirstS As String = ""
    Dim CR() As String
    Dim AA As String
    Dim L As New Point
#Region "Load + VisibleChange + Close"
    Private Sub SelectQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not (EditQFrmt.Visible) Then
            Me.TopMost = True
            Main.Hide()
            L = Me.Location
            TextBox1.Text = "Data Source= " & Databasesselecter.TextBox1.Text
            Me.Bounds = My.Computer.Screen.Bounds
            Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
            Try
                Me.Bounds = Screen.PrimaryScreen.Bounds
                If Databasesselecter.SelectPC.Checked Then
                    Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;" & TextBox1.Text & ";Jet OLEDB:Database Password = " & Databasesselecter.SelectP.Text)
                Else
                    Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;" & TextBox1.Text)
                End If
                ConnStr.Open(Databasesselecter.SelectT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                FirstS = ConnStr.Fields("Question").Value.ToString.Split(",")(0)
            Catch ex As Exception
                MsgBox("(Select)حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة", 0 Or 48 Or MsgBoxStyle.MsgBoxRight)
                Debug.WriteLine(ex.Message & " " & ex.StackTrace)
                Main.Show()
                C = True
                Me.Close()
                C = False
                Exit Sub
            End Try
            If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
                QLabel.Text = Q(0).ToString()
                Try
                    QLabel.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                QLabel.Text = ConnStr.Fields("Question").Value.ToString
            End If
            If ConnStr.Fields("Answer 1").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Answer 1").Value.ToString.Split(",")
                A1Label.Text = Q(0).ToString()
                Try
                    A1Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A1Label.Text = ConnStr.Fields("Answer 1").Value.ToString
            End If
            If ConnStr.Fields("Answer 2").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Answer 2").Value.ToString.Split(",")
                A2Label.Text = Q(0).ToString()
                Try
                    A2Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A2Label.Text = ConnStr.Fields("Answer 2").Value.ToString
            End If
            If ConnStr.Fields("Answer 3").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Answer 3").Value.ToString.Split(",")
                A3Label.Text = Q(0).ToString()
                Try
                    A3Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A3Label.Text = ConnStr.Fields("Answer 3").Value.ToString
            End If
            If ConnStr.Fields("Answer 4").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Answer 4").Value.ToString.Split(",")
                A4Label.Text = Q(0).ToString()
                Try
                    A4Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A4Label.Text = ConnStr.Fields("Answer 4").Value.ToString
            End If
            RALabel.Text = ConnStr.Fields("RAnswer").Value.ToString
            DL.Value = ConnStr.Fields("Degree").Value.ToString
            If A1Label.Text = "" Then A1Label.Hide()
            If A2Label.Text = "" Then A2Label.Hide()
            If A3Label.Text = "" Then A3Label.Hide()
            If A4Label.Text = "" Then A4Label.Hide()
            ConnStr.MoveFirst()
            If ConnStr.EOF Then
                If Databasesselecter.CompleteC.Checked = False And Databasesselecter.JoinC.Checked = False Then
                    Result.Show()
                ElseIf Databasesselecter.CompleteC.Checked = False Then
                    ConnStr2.MoveLast()
                    JoinQ.Show()
                    Me.Hide()
                Else
                    ConnStr2.MoveLast()
                    CompleteQ.Show()
                    Me.Hide()
                End If
                Hide()
                Exit Sub
            ElseIf ConnStr.BOF Then
                Exit Sub
            End If
        Else

        End If
    End Sub
    Private Sub SelectQ_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            If Conn2.State = 0 Then
                If QMSettings.ASSC.Checked = True Then
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & QMSettings.ASST.Text & "\DB.mdb")
                Else
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\DB.mdb")
                End If
                ConnStr2.Open("ASS", Conn2, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                ConnStr2.AddNew()
                ConnStr2.Fields("Q").Value = "Select:"
                ConnStr2.Update()
            End If
        ElseIf Not (CompleteQ.Visible Or JoinQ.Visible) Then
#If Not DEBUG Then
            Activate()
            Me.Visible = True
#End If
        End If
    End Sub
    Private Sub SelectQ_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CR = Nothing
        AA = Nothing
        FirstS = Nothing
    End Sub
#End Region
#Region "Next + Previous + Show Current Question"
    Private Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not (QMSettings.Previous.Checked) Then Button1.Enabled = True
        If Not (ConnStr2.EOF And ConnStr2.BOF) Then ConnStr2.MoveFirst()
        Do Until ConnStr2.EOF
            If Not (QLabel.Text = ConnStr2.Fields("Q").Value.ToString) Then
                ConnStr2.MoveNext()
            Else
                GoTo setA
            End If
        Loop
        If Not (ConnStr2.EOF) Then
            If (ConnStr2.Fields("Q").Value = QLabel.Text And ConnStr2.Fields("A").Value = AA And ConnStr2.Fields("D").Value = DL.Value And ConnStr2.Fields("TF").Value = CStr(CBool(AA = RALabel.Text))) Then
setA:           ConnStr2.Fields("Q").Value = QLabel.Text
                ConnStr2.Fields("A").Value = AA
                ConnStr2.Fields("D").Value = DL.Value
                ConnStr2.Fields("TF").Value = CStr(CBool(AA = RALabel.Text))
                CR = CStr(ConnStr2.Fields("Q").Value.ToString & "`" & ConnStr2.Fields("A").Value.ToString & "`" & ConnStr2.Fields("D").Value.ToString & "`" & ConnStr2.Fields("TF").Value.ToString).Split("`")
            Else
                GoTo Els
            End If
        Else
Els:        ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = QLabel.Text
            ConnStr2.Fields("A").Value = AA
            ConnStr2.Fields("D").Value = DL.Value
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = RALabel.Text))
            CR = CStr(ConnStr2.Fields("Q").Value.ToString & "`" & ConnStr2.Fields("A").Value.ToString & "`" & ConnStr2.Fields("D").Value.ToString & "`" & ConnStr2.Fields("TF").Value.ToString).Split("`")
            A1Label.Checked = False
            A2Label.Checked = False
            A3Label.Checked = False
            A4Label.Checked = False
        End If
        ConnStr2.Update()
        ConnStr2.Requery()
        Do While (CR(0) <> ConnStr2.Fields("Q").Value.ToString Or CR(1) <> ConnStr2.Fields("A").Value.ToString Or CR(2) <> ConnStr2.Fields("D").Value.ToString Or CR(3) <> ConnStr2.Fields("TF").Value.ToString)
            ConnStr2.MoveNext()
        Loop
        ConnStr2.MoveNext()
        If ConnStr2.EOF Then ConnStr2.MovePrevious()
        ShowcurrentQ("Next")
        If Not (Visible) Then Exit Sub
        If ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Then A1Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Then A2Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Then A3Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString Then A4Label.Checked = True
        If Not (ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString) Then
            ConnStr2.MoveNext()
            If Not (ConnStr2.EOF) Then
                If ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Then A1Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Then A2Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Then A3Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString Then A4Label.Checked = True
                AA = ConnStr2.Fields("A").Value.ToString
                ConnStr2.MovePrevious()
                Exit Sub
            End If
            ConnStr2.MovePrevious()
        End If
        AA = ConnStr2.Fields("A").Value.ToString
    End Sub
    Public Sub ShowcurrentQ(NP As String)
        A1Label.Show()
        A2Label.Show()
        A3Label.Show()
        A4Label.Show()
        If NP = "Next" Then ConnStr.MoveNext()
        If NP = "Pre" Then ConnStr.MovePrevious()
        If ConnStr.EOF Then
            If Databasesselecter.CompleteC.Checked Then
                ConnStr2.Requery()
                CompleteQ.Show()
                Me.Hide()
            ElseIf Databasesselecter.JoinC.Checked Then
                ConnStr2.Requery()
                JoinQ.Show()
                Me.Hide()
            Else
                ConnStr2.Requery()
                Result.Show()
            End If
            ConnStr.MovePrevious()
            Me.Hide()
            Exit Sub
        End If
        If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
            QLabel.Text = Q(0).ToString()
            Try
                QLabel.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3).ToString
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.StackTrace)
            End Try
        Else
            Picture.ImageLocation = ""
            QLabel.Text = ConnStr.Fields("Question").Value.ToString
        End If
        If ConnStr.Fields("Answer 1").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Answer 1").Value.ToString.Split(",")
            A1Label.Text = Q(0).ToString()
            Try
                A1Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3).ToString
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.StackTrace)
            End Try
        Else
            Picture.ImageLocation = ""
            A1Label.Text = ConnStr.Fields("Answer 1").Value.ToString
        End If
        If ConnStr.Fields("Answer 2").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Answer 2").Value.ToString.Split(",")
            A2Label.Text = Q(0).ToString()
            Try
                A2Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3).ToString
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.StackTrace)
            End Try
        Else
            Picture.ImageLocation = ""
            A2Label.Text = ConnStr.Fields("Answer 2").Value.ToString
        End If
        If ConnStr.Fields("Answer 3").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Answer 3").Value.ToString.Split(",")
            A3Label.Text = Q(0).ToString()
            Try
                A3Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3).ToString
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.StackTrace)
            End Try
        Else
            Picture.ImageLocation = ""
            A3Label.Text = ConnStr.Fields("Answer 3").Value.ToString
        End If
        If ConnStr.Fields("Answer 4").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Answer 4").Value.ToString.Split(",")
            A4Label.Text = Q(0).ToString()
            Try
                A4Label.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3).ToString
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.StackTrace)
            End Try
        Else
            Picture.ImageLocation = ""
            A4Label.Text = ConnStr.Fields("Answer 4").Value.ToString
        End If
        RALabel.Text = ConnStr.Fields("RAnswer").Value.ToString
        DL.Value = ConnStr.Fields("Degree").Value.ToString
        If A1Label.Text = "" Then A1Label.Hide()
        If A2Label.Text = "" Then A2Label.Hide()
        If A3Label.Text = "" Then A3Label.Hide()
        If A4Label.Text = "" Then A4Label.Hide()
        If FirstS = QLabel.Text Then Button1.Enabled = False
    End Sub
    Public Sub Previous_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FirstS = QLabel.Text Then
            sender.enabled = False
            Exit Sub
        End If
        ConnStr2.MoveFirst()
        Do Until ConnStr2.EOF
            If Not (QLabel.Text = ConnStr2.Fields("Q").Value.ToString) Then
                ConnStr2.MoveNext()
            Else
                GoTo setA
            End If
        Loop
        If Not (ConnStr2.EOF) Then ConnStr2.MoveNext()
        If Not (ConnStr2.EOF) Then
            ConnStr2.MovePrevious()
setA:       ConnStr2.Fields("Q").Value = QLabel.Text
            ConnStr2.Fields("A").Value = AA
            ConnStr2.Fields("D").Value = DL.Value
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = RALabel.Text))
        Else
            ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = QLabel.Text
            ConnStr2.Fields("A").Value = AA
            ConnStr2.Fields("D").Value = DL.Value
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = RALabel.Text))
        End If
        CR = CStr(ConnStr2.Fields("Q").Value.ToString & "`" & ConnStr2.Fields("A").Value.ToString & "`" & ConnStr2.Fields("D").Value.ToString & "`" & ConnStr2.Fields("TF").Value.ToString).Split("`")
        ConnStr2.Update()
        ConnStr2.UpdateBatch()
        ConnStr2.Requery()
        Do While (CR(0) <> ConnStr2.Fields("Q").Value.ToString Or CR(1) <> ConnStr2.Fields("A").Value.ToString Or CR(2) <> ConnStr2.Fields("D").Value.ToString Or CR(3) <> ConnStr2.Fields("TF").Value.ToString)
            ConnStr2.MoveNext()
        Loop
        ConnStr2.MovePrevious()
        If ConnStr2.BOF Then
            ConnStr2.MoveNext()
            ShowcurrentQ("Next")
            Exit Sub
        End If
        ShowcurrentQ("Pre")
              If ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Then A1Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Then A2Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Then A3Label.Checked = True
        If ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString Then A4Label.Checked = True
        If Not (ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Or ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString) Then
            ConnStr2.MoveNext()
            If Not (ConnStr2.EOF) Then
                If ConnStr2.Fields("A").Value.ToString = A1Label.Text.ToString Then A1Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A2Label.Text.ToString Then A2Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A3Label.Text.ToString Then A3Label.Checked = True
                If ConnStr2.Fields("A").Value.ToString = A4Label.Text.ToString Then A4Label.Checked = True
                AA = ConnStr2.Fields("A").Value.ToString
                ConnStr2.MovePrevious()
                If FirstS = QLabel.Text Then
                    sender.enabled = False
                End If
                Exit Sub
            End If
            ConnStr2.MovePrevious()
        End If
        AA = ConnStr2.Fields("A").Value.ToString
        If FirstS = QLabel.Text Then
            sender.enabled = False
        End If
    End Sub
#End Region
    Private Sub SelectQ_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
    Public Sub SelectQ_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then e.Cancel = True
    End Sub
    Private Sub SelectQ_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Not (CompleteQ.Visible Or JoinQ.Visible) Then
            Activate()
            Me.Visible = True
            Me.Show()
        End If
    End Sub
    Private Sub A1Label_CheckedChanged(sender As Object, e As EventArgs) Handles A1Label.CheckedChanged, A2Label.CheckedChanged, A3Label.CheckedChanged, A4Label.CheckedChanged, A4Label.Click, A3Label.Click, A2Label.Click, A1Label.Click, A1Label.TextChanged, A2Label.TextChanged, A3Label.TextChanged, A4Label.TextChanged
        If sender.checked Then AA = sender.text
    End Sub

    Private Sub SelectQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
#If Not DEBUG Then
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds
#End If
    End Sub
End Class