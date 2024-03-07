Public Class CompleteQ
    Private Conn2 As ADODB.Connection = DB
    Private ConnStr2 As ADODB.Recordset = MainASSDB
    Private Conn As New ADODB.Connection()
    Private ConnStr As New ADODB.Recordset()
    Dim CR As String()
    Dim AA As String
    Dim FirstS As String
    Dim l As New Point
    Private Sub CompleteQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Hide()
        TextBox2.Text = Databasesselecter.TextBox2.Text
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Try
            Me.Bounds = Screen.PrimaryScreen.Bounds
            If Databasesselecter.CompletePC.Checked And Not (Conn.State = 1) Then
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & TextBox2.Text & ";Jet OLEDB:Database Password = " & Databasesselecter.CompleteP.Text)
            ElseIf Not (Conn.State = 1) Then
                Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & TextBox2.Text)
            End If
            ConnStr.Open(Databasesselecter.CompleteT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
        Catch ex As Exception
            MsgBox("(Complete)حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة", 0 Or 48 Or MsgBoxStyle.MsgBoxRight)
            Debug.WriteLine(ex.Message & " " & ex.StackTrace)
            Main.Show()
            C = True
            Me.Close()
            C = False
            Exit Sub
        End Try
        ConnStr.MoveFirst()
        If ConnStr.Fields("Question").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Question").Value.ToString.Split(",")
            QLabel.Text = Q(0).ToString()
            Try
                QLabel.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                Picture.ImageLocation = Q(3)
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            Picture.ImageLocation = ""
            QLabel.Text = ConnStr.Fields("Question").Value.ToString
        End If
        FirstS = QLabel.Text
        Label2.Text = ConnStr.Fields("Degree").Value.ToString
    End Sub
#Region "Next + Previous + Show Current Question Sub"
    Private Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not (QMSettings.Previous.Checked) Then Button2.Enabled = True
        If Not (ConnStr2.EOF And ConnStr2.BOF) Then ConnStr2.MoveFirst()
        Do Until ConnStr2.EOF
            If Not (QLabel.Text = ConnStr2.Fields("Q").Value.ToString) Then
                ConnStr2.MoveNext()
            Else
                GoTo setA
            End If
        Loop
        If Not (ConnStr2.EOF) Then
            If (ConnStr2.Fields("Q").Value = QLabel.Text And ConnStr2.Fields("A").Value = AA And ConnStr2.Fields("D").Value = Label2.Text And ConnStr2.Fields("TF").Value = CStr(CBool(AA = ConnStr.Fields("RA1").Value.ToString Or AA = ConnStr.Fields("RA2").Value.ToString Or AA = ConnStr.Fields("RA3").Value.ToString))) Then
setA:           ConnStr2.Fields("Q").Value = QLabel.Text
                ConnStr2.Fields("A").Value = AA
                ConnStr2.Fields("D").Value = Label2.Text
                ConnStr2.Fields("TF").Value = CStr(CBool(AA = ConnStr.Fields("RA1").Value.ToString Or AA = ConnStr.Fields("RA2").Value.ToString Or AA = ConnStr.Fields("RA3").Value.ToString))
                CR = CStr(ConnStr2.Fields("Q").Value.ToString & "`" & ConnStr2.Fields("A").Value.ToString & "`" & ConnStr2.Fields("D").Value.ToString & "`" & ConnStr2.Fields("TF").Value.ToString).Split("`")
            Else
                GoTo Els
            End If
        Else
Els:        ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = QLabel.Text
            ConnStr2.Fields("A").Value = AA
            ConnStr2.Fields("D").Value = Label2.Text
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = ConnStr.Fields("RA1").Value.ToString Or AA = ConnStr.Fields("RA2").Value.ToString Or AA = ConnStr.Fields("RA3").Value.ToString))
            CR = CStr(ConnStr2.Fields("Q").Value.ToString & "`" & ConnStr2.Fields("A").Value.ToString & "`" & ConnStr2.Fields("D").Value.ToString & "`" & ConnStr2.Fields("TF").Value.ToString).Split("`")
            TextBox1.Text = ""
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
        If C Then Exit Sub
        TextBox1.Text = ConnStr2.Fields("A").Value.ToString
        If Not (ConnStr.Fields("RA1").Value.ToString = ConnStr2.Fields("A").Value.ToString Or ConnStr.Fields("RA2").Value.ToString = ConnStr2.Fields("A").Value.ToString Or ConnStr.Fields("RA3").Value.ToString = ConnStr2.Fields("A").Value.ToString) Then
            ConnStr2.MoveNext()
            If Not (ConnStr2.EOF) Then
                TextBox1.Text = ConnStr2.Fields("A").Value.ToString
                AA = ConnStr2.Fields("A").Value.ToString
                ConnStr2.MovePrevious()
                Exit Sub
            End If
            ConnStr2.MovePrevious()
        End If
        AA = ConnStr2.Fields("A").Value.ToString
    End Sub
    Public Sub ShowcurrentQ(NP As String)
        If NP = "Next" Then ConnStr.MoveNext()
        If NP = "Pre" Then ConnStr.MovePrevious()
        If ConnStr.EOF Then
            If Databasesselecter.JoinC.Checked Then
                Try
                    JoinQ.Show()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Me.Hide()
            Else
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
                Picture.ImageLocation = Q(3)
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            Picture.ImageLocation = ""
            QLabel.Text = ConnStr.Fields("Question").Value.ToString
        End If
        Label2.Text = ConnStr.Fields("Degree").Value.ToString
    End Sub
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FirstS = QLabel.Text And Not (Databasesselecter.SelectC.Checked) Then
            sender.enabled = False
            Exit Sub
        ElseIf FirstS = QLabel.Text And Databasesselecter.SelectC.Checked Then
            SelectQ.Show()
            If SelectQ.A1Label.Text = "" Then SelectQ.A1Label.Hide()
            If SelectQ.A2Label.Text = "" Then SelectQ.A2Label.Hide()
            If SelectQ.A3Label.Text = "" Then SelectQ.A3Label.Hide()
            If SelectQ.A4Label.Text = "" Then SelectQ.A4Label.Hide()
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
            ConnStr2.Fields("D").Value = Label2.Text
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = ConnStr.Fields("RA1").Value.ToString Or AA = ConnStr.Fields("RA2").Value.ToString Or AA = ConnStr.Fields("RA3").Value.ToString))
        Else
            ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = QLabel.Text
            ConnStr2.Fields("A").Value = AA
            ConnStr2.Fields("D").Value = Label2.Text
            ConnStr2.Fields("TF").Value = CStr(CBool(AA = ConnStr.Fields("RA1").Value.ToString Or AA = ConnStr.Fields("RA2").Value.ToString Or AA = ConnStr.Fields("RA3").Value.ToString))
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
        If C Then Exit Sub
        TextBox1.Text = ConnStr2.Fields("A").Value.ToString
        If Not (ConnStr.Fields("RA1").Value.ToString = ConnStr2.Fields("A").Value.ToString Or ConnStr.Fields("RA2").Value.ToString = ConnStr2.Fields("A").Value.ToString Or ConnStr.Fields("RA3").Value.ToString = ConnStr2.Fields("A").Value.ToString) Then
            ConnStr2.MoveNext()
            If Not (ConnStr2.EOF) Then
                TextBox1.Text = ConnStr2.Fields("A").Value.ToString
                AA = ConnStr2.Fields("A").Value.ToString
                ConnStr2.MovePrevious()
                If FirstS = QLabel.Text And Not (Databasesselecter.SelectC.Checked) Then
                    sender.enabled = False
                ElseIf FirstS = QLabel.Text And Databasesselecter.SelectC.Checked Then
                    sender.enabled = False
                End If
                Exit Sub
            End If
            ConnStr2.MovePrevious()
        End If
        AA = ConnStr2.Fields("A").Value.ToString
        If FirstS = QLabel.Text And Not (Databasesselecter.SelectC.Checked) Then
            sender.enabled = False
        End If
    End Sub
#End Region
    Public Sub CompleteQ_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then e.Cancel = True
    End Sub
    Private Sub SelectQ_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible = True Then
            If Conn2.State = 0 Then
                If QMSettings.ASSC.Checked = True Then
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & QMSettings.ASST.Text & "\DB.mdb")
                Else
                    Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\DB.mdb")
                End If
                ConnStr2.Open("ASS", Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            End If
            ConnStr2.AddNew()
            ConnStr2.Fields("Q").Value = "Complete:"
            ConnStr2.Update()
        ElseIf Not (SelectQ.Visible Or JoinQ.Visible) Then
            Activate()
            Me.Visible = True
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
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        AA = TextBox1.Text
    End Sub
    Private Sub CompleteQ_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
#If Not DEBUG Then
        On Error Resume Next
        If Not (SelectQ.Visible Or JoinQ.Visible) Then
            Activate()
            Me.Visible = True
        End If
#End If
    End Sub

    Private Sub CompleteQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
#If Not DEBUG Then
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds
#End If
    End Sub
End Class