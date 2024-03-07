Public Class Nam
    ReadOnly osk As New Process
    ReadOnly SelectC As Boolean = Paths.Instance.SelectC.Checked
    ReadOnly SelectPC As Boolean = Paths.Instance.SelectPC.Checked
    ReadOnly CompleteC As Boolean = Paths.Instance.CompleteC.Checked
    ReadOnly CompletePC As Boolean = Paths.Instance.CompletePC.Checked
    ReadOnly JoinC As Boolean = Paths.Instance.JoinC.Checked
    ReadOnly JoinPC As Boolean = Paths.Instance.JoinPC.Checked
    ReadOnly SelectL As String = Paths.Instance.TextBox1.Text
    ReadOnly SelectTa As String = Paths.Instance.SelectT.Text
    ReadOnly CompleteL As String = Paths.Instance.TextBox2.Text
    ReadOnly CompleteTa As String = Paths.Instance.CompleteT.Text
    ReadOnly ArrangeC As Boolean = Paths.Instance.ArrangeC.Checked
    ReadOnly ArrangePC As Boolean = Paths.Instance.ArrangePC.Checked
    ReadOnly ArrangeL As String = Paths.Instance.Arrange.Text
    ReadOnly ArrangeTa As String = Paths.Instance.ArrangeT.Text
    ReadOnly JoinL As String = Paths.Instance.TextBox3.Text
    ReadOnly JoinTa As String = Paths.Instance.JoinT.Text
    Public Eror As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sender.Enabled = False
        If Paths.Instance.SelectC.Checked = False AndAlso Paths.Instance.CompleteC.Checked = False AndAlso Paths.Instance.JoinC.Checked = False Then
            MsgBox("لا يوجد اختبار لاظهاره!", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("من فضلك ادخل اسمك", 0 OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
        ElseIf TextBox1.Text.Length <= QMSettings.NameMin.Value AndAlso QMSettings.NameC.Checked = True OrElse CountoO(TextBox1.Text, " ") <= 1 Then
            MsgBox("يرجى كتابة الإسم ثلاثي", 0 OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
        ElseIf TextBox1.Text.Contains(";") OrElse TextBox1.Text.Contains(">") OrElse TextBox1.Text.Contains("<") OrElse TextBox1.Text.Contains("|") OrElse TextBox1.Text.Contains("?") OrElse TextBox1.Text.Contains("\") OrElse TextBox1.Text.Contains("/") OrElse TextBox1.Text.Contains(":") OrElse TextBox1.Text.Contains("""") OrElse TextBox1.Text.Contains("*") Then
            MsgBox("يجب ألا يحتوي الإسم على الحرف التالية:" & vbCrLf & """ : ; < > | . \ / ? *", 0 OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
        Else
            Try
                If Not (Eror) Then
                    Paths.Instance.Nam2.Text = TextBox1.Text
                    If Eror Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
                If IO.File.Exists("DB.mdb") Then My.Computer.FileSystem.DeleteFile("DB.mdb")
                If IO.File.Exists(QMSettings.ASST.Text & "\DB.mdb") Then My.Computer.FileSystem.DeleteFile(QMSettings.ASST.Text & "\DB.mdb")
                If QMSettings.ASSC.Checked = True Then
                    Debug.WriteLine(QMSettings.ASST.Text)
                    Process.Start("RenameDB.exe", "C Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & QMSettings.ASST.Text & "\DB.mdb" & ";Jet OLEDB:Engine Type=5").WaitForExit()
                    Dim con As New OleDb.OleDbConnection With {
                        .ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & QMSettings.ASST.Text & "\DB.mdb" & ";Jet OLEDB:Engine Type = 5"
                    }
                    con.Open()
                    Dim dbSchema As DataTable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, QMSettings.ASST.Text & "\DB", "TABLE"})
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & "ASS" & "] ([ID] COUNTER, [Q] TEXT, [A] TEXT, [D] TEXT, [TF] TEXT)", con)
                    cmd.ExecuteNonQuery()
                    If con.State = 1 Then
                        con.Close()
                    End If
                    con = Nothing
                    dbSchema = Nothing
                    cmd = Nothing
                Else
                    Process.Start("RenameDB.exe", "C Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directory & "\DB.mdb" & ";Jet OLEDB:Engine Type=5").WaitForExit()
                    Dim con As New OleDb.OleDbConnection With {
                        .ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & My.Application.Info.DirectoryPath & "\DB.mdb" & ";Jet OLEDB:Engine Type = 5"
                    }
                    con.Open()
                    Dim dbSchema As DataTable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Directory & "\DB", "TABLE"})
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & "ASS" & "] ([ID] COUNTER, [Q] TEXT, [A] TEXT, [D] TEXT, [TF] TEXT)", con)
                    cmd.ExecuteNonQuery()
                    If con.State = 1 Then
                        con.Close()
                    End If
                    con = Nothing
                    dbSchema = Nothing
                    cmd = Nothing
                End If
            Catch ex As Exception
                MsgBox("حدث خطأ أثناء تحمبل الإختبار" & vbCrLf & ex.Message, 16 OrElse 0 OrElse MsgBoxStyle.MsgBoxRight)
                MsgBox("حدث خطأ أثناء تحمبل الإختبار", 16 OrElse 0 OrElse MsgBoxStyle.MsgBoxRight)
                Debug.WriteLine(ex.Message)

                Exit Sub
            End Try
            LoadQuiz.RunWorkerAsync(TextBox1.Text)
        End If
        sender.Enabled = True
    End Sub

    Private Sub Nam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If QMSettings.NameC.Checked = True Then
            TextBox1.MaxLength = QMSettings.NameMax.Value
        End If
        Try
            osk.Start(Environment.SystemDirectory + "\osk.exe")
        Catch
        End Try
    End Sub

    Private Sub Nam_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Eror Then Main.Show()
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName("osk")
            p.Kill()
        Next
    End Sub

    <STAThread> Private Sub LoadQuiz_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadQuiz.DoWork
        Try
            'Timer = QMSettings.Timer.Checked
            'Fill Quiz into Lists then display it'

            If SelectC Then
                Dim SelectQ As New ADODB.Connection
                If SelectPC Then
                    SelectQ.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & SelectL & ";Jet OLEDB:Database Password = " & Paths.Instance.SelectP.Text & ";")
                Else
                    SelectQ.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = " & SelectL & ";")
                End If
                Dim SelectT As New ADODB.Recordset()
                SelectT.Open(SelectTa, SelectQ, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                SelectT.MoveFirst()
                Do While Not SelectT.EOF
                    Subs.SelectQ.Add(SelectT.Fields("Question").Value.ToString())
                    Subs.SelectRA.Add(SelectT.Fields("RAnswer").Value.ToString())
                    Subs.SelectAs.Add((SelectT.Fields("Answer 1").Value + "~" + SelectT.Fields("Answer 2").Value + "~" + SelectT.Fields("Answer 3").Value + "~" + SelectT.Fields("Answer 4").Value).ToString().Split("~"))
                    Subs.SelectD.Add(SelectT.Fields("Degree").Value.ToString())
                    SelectA.Add("")
                    SelectTF.Add(False)
                    SelectT.MoveNext()
                Loop
                SelectT.Close()
                SelectQ.Close()
                SelectT = Nothing
                SelectQ = Nothing
                Invoke(Sub() Questions.Add(New SelectQ))
            End If
            If CompleteC Then
                Dim CompleteQ As New ADODB.Connection
                If CompletePC Then
                    CompleteQ.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & CompleteL & ";Jet OLEDB:Database Password = " & Paths.Instance.CompleteP.Text & ";")
                Else
                    CompleteQ.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = " & CompleteL & ";")
                End If
                Dim CompleteT As New ADODB.Recordset
                CompleteT.Open(CompleteTa, CompleteQ, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                CompleteT.MoveFirst()
                Do While Not CompleteT.EOF
                    Subs.CompleteQ.Add(CompleteT.Fields("Question").Value.ToString())
                    Subs.CompleteRAs.Add((CompleteT.Fields("RA1").Value + "~" + CompleteT.Fields("RA2").Value + "~" + CompleteT.Fields("RA3").Value).ToString().Split("~"))
                    Subs.CompleteD.Add(CompleteT.Fields("Degree").Value.ToString())
                    CompleteA.Add("")
                    CompleteTF.Add(False)
                    CompleteRgx.Add(CBool(CompleteRAs(CompleteRAs.Count - 1)(2) = "IsRegex=VTrue"))
                    CompleteT.MoveNext()
                Loop
                CompleteT.Close()
                CompleteQ.Close()
                CompleteT = Nothing
                CompleteQ = Nothing
                Invoke(Sub() Questions.Add(New CompleteQ))
            End If

            If JoinC Then
                Dim JoinQ As New ADODB.Connection
                If JoinPC Then
                    JoinQ.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & JoinL & ";Jet OLEDB:Database Password = " & Paths.Instance.JoinP.Text & ";")
                Else
                    JoinQ.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = " & JoinL & ";")
                End If
                Dim JoinT As New ADODB.Recordset
                JoinT.Open(JoinTa, JoinQ, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                JoinT.MoveFirst()
                Do While Not JoinT.EOF
                    Subs.JoinC1.Add(JoinT.Fields("Q").Value.ToString())
                    Subs.JoinC2.Add(JoinT.Fields("A").Value.ToString())
                    Subs.JoinTQI.Add(JoinT.Fields("TQI").Value.ToString())
                    Subs.JoinTAI.Add(JoinT.Fields("TAI").Value.ToString())
                    Subs.JoinD.Add(JoinT.Fields("Degree").Value)
                    JoinT.MoveNext()
                Loop
                JoinT.Close()
                JoinQ.Close()
                JoinT = Nothing
                JoinQ = Nothing
                Invoke(Sub() Questions.Add(New JoinQ))
            End If
            If ArrangeC Then
                Dim ArrangeQ As New ADODB.Connection
                If ArrangePC Then
                    ArrangeQ.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & ArrangeL & ";Jet OLEDB:Database Password = " & Paths.Instance.ArrangeP.Text & ";")
                Else
                    ArrangeQ.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = " & ArrangeL & ";")
                End If
                Dim ArrangeT As New ADODB.Recordset()
                ArrangeT.Open(ArrangeTa, ArrangeQ, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                ArrangeT.MoveFirst()
                Do While Not ArrangeT.EOF
                    Subs.ArrangeQ.Add(ArrangeT.Fields("Q").Value.ToString())
                    Subs.ArrangeRA.Add(ArrangeT.Fields("Arr").Value.ToString())
                    Subs.ArrangeD.Add(ArrangeT.Fields("Degree").Value.ToString())
                    ArrangeA.Add("")
                    ArrangeTF.Add(False)
                    ArrangeT.MoveNext()
                Loop
                ArrangeT.Close()
                ArrangeQ.Close()
                ArrangeT = Nothing
                ArrangeQ = Nothing
                Invoke(Sub() Questions.Add(New Arrangement))
            End If
            Questions.Add(New Result)
            Invoke(Sub() DirectCast(Questions(Questions.Count - 1), Result).Nam.Text &= TextBox1.Text)
            Invoke(New ShowQuiz(AddressOf ShwQz))
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Delegate Sub ShowQuiz()
    Sub ShwQz()
        ActiveF = Questions(0)
        Questions(0).Show()
        Eror = Nothing
        Try
            TextBox1.Text = ""
            Hide()
            Start_Timer()
            Close()
        Catch
        End Try
    End Sub
End Class