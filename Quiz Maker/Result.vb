Imports System.Text.RegularExpressions

Public Class Result
    Dim Resultscon As ADODB.Connection = DB
    Dim Results As ADODB.Recordset = MainASSDB
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles Me.Load
        C = True
        Questions.RemoveAt(Questions.Count - 1)
        For Each MainQ As Form In Questions
            MainQ.Close()
        Next
        Stop_Timer()
        Questions = New List(Of Form)
        If QMSettings.ASSC.Checked = True AndAlso Results.State = 0 Then
            Resultscon.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " & QMSettings.ASST.Text & "\DB.mdb" & ";Jet OLEDB:Engine Type = 5")
        ElseIf Results.State = 0 Then
            Resultscon.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " & Directory & "\DB.mdb" & ";Jet OLEDB:Engine Type = 5")
        End If
        If Results.State = 0 Then Results.Open("ASS", Resultscon, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Main.Show()
        Me.Activate()
        Results.AddNew()
        If Paths.Instance.SelectC.Checked Then
            Results.Fields("Q").Value = "Select Question:"
            Results.Update()
            For Index = 0 To Subs.SelectQ.Count - 1
                Results.AddNew()
                Results.Fields("Q").Value = Subs.SelectQ(Index)
                Results.Fields("A").Value = Subs.SelectA(Index)
                Results.Fields("D").Value = Subs.SelectD(Index).ToString
                Results.Fields("TF").Value = Subs.SelectTF(Index).ToString
                Results.Update()
            Next
        End If

        Results.AddNew()
        If Paths.Instance.CompleteC.Checked Then
            Results.Fields("Q").Value = "Complete Question:"
            Results.Update()
            For Index = 0 To Subs.CompleteQ.Count - 1
                Results.AddNew()
                Results.Fields("Q").Value = Subs.CompleteQ(Index)
                Results.Fields("A").Value = Subs.CompleteA(Index)
                Results.Fields("D").Value = Subs.CompleteD(Index).ToString
                Results.Fields("TF").Value = Subs.CompleteTF(Index).ToString
                Results.Update()
            Next
        End If

        Results.AddNew()
        If Paths.Instance.JoinC.Checked Then
            Results.Fields("Q").Value = "Join Question:"
            Results.Update()
            For Index = 0 To Subs.JoinAC1.Count - 1
                Results.AddNew()
                Results.Fields("Q").Value = Subs.JoinAC1(Index)
                Results.Fields("A").Value = Subs.JoinAC2(Index)
                Results.Fields("D").Value = Subs.JoinD(Index).ToString
                Results.Fields("TF").Value = Subs.JoinTF(Index).ToString
                Results.Update()
            Next
        End If

        Results.AddNew()
        If Paths.Instance.ArrangeC.Checked Then
            Results.Fields("Q").Value = "Arrange Question:"
            Results.Update()
            For Index = 0 To Subs.ArrangeQ.Count - 1
                Results.AddNew()
                Results.Fields("Q").Value = Subs.ArrangeQ(Index)
                Results.Fields("A").Value = Subs.ArrangeA(Index)
                Results.Fields("D").Value = Subs.ArrangeD(Index).ToString
                Results.Fields("TF").Value = Subs.ArrangeTF(Index).ToString
                Results.Update()
            Next
        End If
        Try
            Results.Close()
        Catch
        Finally
            Resultscon.Close()
        End Try

        If Paths.Instance.SelectC.Checked Then
            For Index = 0 To SelectD.Count - 1
                If SelectTF(Index) Then
                    Q1.Text += SelectD(Index)
                End If
            Next
            For Each I As Double In SelectD
                Q1B.Text += I
            Next
        Else
            TableLayoutPanel3.Controls.Remove(Label1)
            TableLayoutPanel3.Controls.Remove(Q1)
            TableLayoutPanel3.Controls.Remove(Q1S)
            TableLayoutPanel3.Controls.Remove(Q1B)
            TableLayoutPanel3.Controls.Remove(Q1P)
            TableLayoutPanel3.Controls.Remove(Q1V)
            TableLayoutPanel3.ColumnCount -= 1
            TableLayoutPanel3.ColumnStyles.RemoveAt(1)
        End If

        If Paths.Instance.CompleteC.Checked Then
            For Index = 0 To CompleteD.Count - 1
                If CompleteRgx(Index) Then
                    Dim AnsRgx As New Regex(CompleteRAs(Index)(0).Split("#")(0), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
                    Dim Anss As String() = CompleteRAs(Index)(0).Split("#")
                    For Index2 = 0 To Anss.Count - 1
                        If AnsRgx.IsMatch(CompleteA(Index).Split(",")(Index2), Anss(Index2), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft) Then
                            Q2.Text += CDbl(CompleteD(Index) * (1 / Anss.Count))
                        End If
                    Next
                ElseIf CompleteTF(Index) Then
                    Q2.Text += CompleteD(Index)
                End If
            Next
            Q2.Text = Math.Round(CDec(If(Q2.Text = "", 0, Q2.Text)), 2)
            For Each I As Double In CompleteD
                Q2B.Text += I
            Next
        Else
            TableLayoutPanel3.Controls.Remove(Label2)
            TableLayoutPanel3.Controls.Remove(Q2)
            TableLayoutPanel3.Controls.Remove(Q2S)
            TableLayoutPanel3.Controls.Remove(Q2B)
            TableLayoutPanel3.Controls.Remove(Q2P)
            TableLayoutPanel3.Controls.Remove(Q2V)
            TableLayoutPanel3.ColumnCount -= 1
            If TableLayoutPanel3.ColumnCount = 3 Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(1)
            Else
                TableLayoutPanel3.ColumnStyles.RemoveAt(2)
            End If
        End If

        If Paths.Instance.JoinC.Checked Then
            For Index = 0 To JoinD.Count - 1
                If JoinTF(Index) Then
                    Q3.Text += JoinD(Index)
                End If
            Next
            For Each I As Double In JoinD
                Q3B.Text += I
            Next
        Else
            TableLayoutPanel3.Controls.Remove(Label3)
            TableLayoutPanel3.Controls.Remove(Q3)
            TableLayoutPanel3.Controls.Remove(Q3S)
            TableLayoutPanel3.Controls.Remove(Q3B)
            TableLayoutPanel3.Controls.Remove(Q3P)
            TableLayoutPanel3.Controls.Remove(Q3V)
            TableLayoutPanel3.ColumnCount -= 1
            If TableLayoutPanel3.ColumnCount = 3 Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(2)
            ElseIf TableLayoutPanel3.ColumnCount = 2 Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(1)
            Else
                TableLayoutPanel3.ColumnStyles.RemoveAt(3)
            End If
        End If

        If Paths.Instance.ArrangeC.Checked Then
            For Index = 0 To ArrangeD.Count - 1
                If ArrangeTF(Index) Then
                    Q4.Text += ArrangeD(Index)
                End If
            Next
            For Each I As Double In ArrangeD
                Q4B.Text += I
            Next
        Else
            TableLayoutPanel3.Controls.Remove(Label10)
            TableLayoutPanel3.Controls.Remove(Q4)
            TableLayoutPanel3.Controls.Remove(Q4S)
            TableLayoutPanel3.Controls.Remove(Q4B)
            TableLayoutPanel3.Controls.Remove(Q4P)
            TableLayoutPanel3.Controls.Remove(Q4V)
            TableLayoutPanel3.ColumnCount -= 1
            If TableLayoutPanel3.ColumnCount = 3 Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(2)
            ElseIf TableLayoutPanel3.ColumnCount = 2 Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(1)
            Else
                TableLayoutPanel3.ColumnStyles.RemoveAt(3)
            End If
        End If

        Final.Text = CDbl(Q1B.Text) + CDbl(Q2B.Text) + CDbl(Q3B.Text) + CDbl(Q4B.Text)
        Q1S.Text = Q1B.Text / 2
        Q2S.Text = Q2B.Text / 2
        Q3S.Text = Q3B.Text / 2
        Q4S.Text = Q4B.Text / 2
        Q1P.Text = Math.Round((Q1.Text / Q1B.Text) * 100, 3)
        Q2P.Text = Math.Round((Q2.Text / Q2B.Text) * 100, 3)
        Q3P.Text = Math.Round((Q3.Text / Q3B.Text) * 100, 3)
        Q4P.Text = Math.Round((Q4.Text / Q4B.Text) * 100, 3)
        If CDbl(Q1P.Text) > 85 Then
            Q1V.Text = "ممتاز"
            Q1.BackColor = Color.Lime
            Q1P.BackColor = Color.Lime
            Q1V.BackColor = Color.Lime
        ElseIf CDbl(Q1P.Text) > 75 Then
            Q1V.Text = "جيد جدًا"
            Q1.BackColor = Color.DodgerBlue
            Q1P.BackColor = Color.DodgerBlue
            Q1V.BackColor = Color.DodgerBlue
        ElseIf CDbl(Q1P.Text) > 65 Then
            Q1V.Text = "جيد"
            Q1.BackColor = Color.Orange
            Q1P.BackColor = Color.Orange
            Q1V.BackColor = Color.Orange
        ElseIf CDbl(Q1P.Text) >= 50 Then
            Q1V.Text = "مقبول"
            Q1.BackColor = Color.Gold
            Q1P.BackColor = Color.Gold
            Q1V.BackColor = Color.Gold
        Else
            Q1V.Text = "لم ينجح"
            Q1.BackColor = Color.Red
            Q1P.BackColor = Color.Red
            Q1V.BackColor = Color.Red
        End If
        If CDbl(Q2P.Text) > 85 Then
            Q2V.Text = "ممتاز"
            Q2.BackColor = Color.Lime
            Q2P.BackColor = Color.Lime
            Q2V.BackColor = Color.Lime
        ElseIf CDbl(Q2P.Text) > 75 Then
            Q2V.Text = "جيد جدًا"
            Q2.BackColor = Color.DodgerBlue
            Q2P.BackColor = Color.DodgerBlue
            Q2V.BackColor = Color.DodgerBlue
        ElseIf CDbl(Q2P.Text) > 65 Then
            Q2V.Text = "جيد"
            Q2.BackColor = Color.Orange
            Q2P.BackColor = Color.Orange
            Q2V.BackColor = Color.Orange
        ElseIf CDbl(Q2P.Text) >= 50 Then
            Q2V.Text = "مقبول"
            Q2.BackColor = Color.Gold
            Q2P.BackColor = Color.Gold
            Q2V.BackColor = Color.Gold
        Else
            Q2V.Text = "لم ينجح"
            Q2.BackColor = Color.Red
            Q2P.BackColor = Color.Red
            Q2V.BackColor = Color.Red
        End If
        If CDbl(Q3P.Text) > 85 Then
            Q3V.Text = "ممتاز"
            Q3.BackColor = Color.Lime
            Q3P.BackColor = Color.Lime
            Q3V.BackColor = Color.Lime
        ElseIf CDbl(Q3P.Text) > 75 Then
            Q3V.Text = "جيد جدًا"
            Q3.BackColor = Color.DodgerBlue
            Q3P.BackColor = Color.DodgerBlue
            Q3V.BackColor = Color.DodgerBlue
        ElseIf CDbl(Q3P.Text) > 65 Then
            Q3V.Text = "جيد"
            Q3.BackColor = Color.Orange
            Q3P.BackColor = Color.Orange
            Q3V.BackColor = Color.Orange
        ElseIf CDbl(Q3P.Text) >= 50 Then
            Q3V.Text = "مقبول"
            Q3.BackColor = Color.Gold
            Q3P.BackColor = Color.Gold
            Q3V.BackColor = Color.Gold
        Else
            Q3V.Text = "لم ينجح"
            Q3.BackColor = Color.Red
            Q3P.BackColor = Color.Red
            Q3V.BackColor = Color.Red
        End If
        If CDbl(Q4P.Text) > 85 Then
            Q4V.Text = "ممتاز"
            Q4.BackColor = Color.Lime
            Q4P.BackColor = Color.Lime
            Q4V.BackColor = Color.Lime
        ElseIf CDbl(Q4P.Text) > 75 Then
            Q4V.Text = "جيد جدًا"
            Q4.BackColor = Color.DodgerBlue
            Q4P.BackColor = Color.DodgerBlue
            Q4V.BackColor = Color.DodgerBlue
        ElseIf CDbl(Q4P.Text) > 65 Then
            Q4V.Text = "جيد"
            Q4.BackColor = Color.Orange
            Q4P.BackColor = Color.Orange
            Q4V.BackColor = Color.Orange
        ElseIf CDbl(Q4P.Text) >= 50 Then
            Q4V.Text = "مقبول"
            Q4.BackColor = Color.Gold
            Q4P.BackColor = Color.Gold
            Q4V.BackColor = Color.Gold
        Else
            Q4V.Text = "لم ينجح"
            Q4.BackColor = Color.Red
            Q4P.BackColor = Color.Red
            Q4V.BackColor = Color.Red
        End If
        Q1P.Text &= "%"
        Q2P.Text &= "%"
        Q3P.Text &= "%"
        Q4P.Text &= "%"
        Sum.Text = CDbl(Q1.Text) + CDbl(Q2.Text) + CDbl(Q3.Text) + CDbl(Q4.Text)
        SFinal.Text = Final.Text / 2
        Percent.Text = ((Sum.Text / Final.Text) * 100)
        If Percent.Text.Length > 7 Then Percent.Text = Percent.Text.Remove(7)
        If Not QMSettings.Timer.Checked Then
            TimerL.Text = "__"
        Else
            TimerL.Text = Hou.ToString() + ":" + Min.ToString() + ":" + Sec.ToString()
        End If
        If Paths.Instance.ConnStr2.State = 0 Then
            Try
                If Paths.Instance.Savings2PC.Checked Then
                    If Paths.Instance.Conn2.State = 0 Then Paths.Instance.Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & My.Application.Info.DirectoryPath & "\Savings2.mdb" & ";Jet OLEDB:Database Password = " & Paths.Instance.Savings2P.Text)
                    Paths.Instance.ConnStr2.Open(Paths.Instance.Savings2T.Text, Paths.Instance.Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Else
                    If Paths.Instance.Conn2.State = 0 Then Paths.Instance.Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings2.mdb")
                    Paths.Instance.ConnStr2.Open(Paths.Instance.Savings2T.Text, Paths.Instance.Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                End If
            Catch
                MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2).", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
            End Try
        End If
        If Paths.Instance.Savings2C.Checked Then Paths.Instance.ConnStr2.AddNew()
        With Paths.Instance.ConnStr2
            If CDbl(Percent.Text) > 85 Then
                If Paths.Instance.Savings2C.Checked Then .Fields("Valuation").Value = "ممتاز"
                Valuation.Text = "ممتاز"
                If Paths.Instance.Savings2C.Checked Then .Fields("Success").Value = True
                Success.Text = "ناجح"
                Success.BackColor = Color.MediumSpringGreen
                Sum.BackColor = Color.Lime
                Percent.BackColor = Color.Lime
            ElseIf CDbl(Percent.Text) > 75 Then
                If Paths.Instance.Savings2C.Checked Then .Fields("Valuation").Value = "جيد جدًا"
                Valuation.Text = "جيد جدًا"
                If Paths.Instance.Savings2C.Checked Then .Fields("Success").Value = True
                Success.Text = "ناجح"
                Success.BackColor = Color.MediumSpringGreen
                Sum.BackColor = Color.DodgerBlue
                Percent.BackColor = Color.DodgerBlue
            ElseIf CDbl(Percent.Text) > 65 Then
                If Paths.Instance.Savings2C.Checked Then .Fields("Valuation").Value = "جيد"
                Valuation.Text = "جيد"
                If Paths.Instance.Savings2C.Checked Then .Fields("Success").Value = True
                Success.Text = "ناجح"
                Success.BackColor = Color.MediumSpringGreen
                Sum.BackColor = Color.Orange
                Percent.BackColor = Color.Orange
            ElseIf CDbl(Percent.Text) >= 50 Then
                If Paths.Instance.Savings2C.Checked Then .Fields("Valuation").Value = "مقبول"
                Valuation.Text = "مقبول"
                If Paths.Instance.Savings2C.Checked Then .Fields("Success").Value = True
                Success.Text = "ناجح"
                Success.BackColor = Color.MediumSpringGreen
                Sum.BackColor = Color.Gold
                Percent.BackColor = Color.Gold
            Else
                If Paths.Instance.Savings2C.Checked Then .Fields("Valuation").Value = "راسب"
                Valuation.Text = "لم ينجح"
                If Paths.Instance.Savings2C.Checked Then .Fields("Success").Value = False
                Success.Text = "لم ينجح"
                Success.BackColor = Color.Red
                Sum.BackColor = Color.Red
                Percent.BackColor = Color.Red
            End If
        End With
        Try
            If Paths.Instance.SelectC.Checked = False Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(1)
                If Paths.Instance.CompleteC.Checked = False Then
                    TableLayoutPanel3.ColumnStyles.RemoveAt(1)
                ElseIf Paths.Instance.JoinC.Checked = False Then
                    TableLayoutPanel3.ColumnStyles.RemoveAt(2)
                End If
            ElseIf Paths.Instance.CompleteC.Checked = False Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(2)
                If Paths.Instance.JoinC.Checked = False Then
                    TableLayoutPanel3.ColumnStyles.RemoveAt(2)
                End If
            ElseIf Paths.Instance.JoinC.Checked = False Then
                TableLayoutPanel3.ColumnStyles.RemoveAt(2)
            End If
            TableLayoutPanel3.Update()
        Catch
        End Try

        If Paths.Instance.Savings2C.Checked Then
            Paths.Instance.ConnStr2.Fields("Nam").Value = Nam.Text.Replace("الإسم:", "")
            Paths.Instance.ConnStr2.Fields("Value1").Value = Q1.Text
            Paths.Instance.ConnStr2.Fields("Value2").Value = Q2.Text
            Paths.Instance.ConnStr2.Fields("Value3").Value = Q3.Text
            Paths.Instance.ConnStr2.Fields("Value4").Value = Q4.Text
            Paths.Instance.ConnStr2.Fields("Timer").Value = TimerL.Text
            Paths.Instance.ConnStr2.Fields("Total").Value = Sum.Text
            Paths.Instance.ConnStr2.Fields("Final").Value = Final.Text
            Paths.Instance.ConnStr2.Fields("Percent").Value = Percent.Text
            Paths.Instance.ConnStr2.Fields("PathToDB").Value = QMSettings.ASST.Text & "\" & Paths.Instance.Nam2.Text & ".mdb"
            Paths.Instance.ConnStr2.Update()
            Paths.Instance.ConnStr2.Close()
        End If
        ontime = False
        Hou = 0
        Min = 0
        Sec = 0
        Timer = True
        Percent.Text &= "%"
        If QMSettings.ASSC.Checked = False Then
            System.IO.File.Delete(Directory & "\DB.mdb")
        Else
            Try
                If QMSettings.ASSC.Checked Then My.Computer.FileSystem.RenameFile(QMSettings.ASST.Text & "\DB.mdb", Paths.Instance.Nam2.Text & ".mdb")
            Catch
            End Try
            If Not (QMSettings.ASSC.Checked) Then My.Computer.FileSystem.RenameFile("DB.mdb", Nam.Text & ".mdb")
        End If
        CloseC()

    End Sub

    Private Sub Result_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        If e.KeyValue = 27 Then
            Close()
            Results = Nothing
            Resultscon = Nothing
        End If
    End Sub

    Private Sub Result_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        C = Me.Visible
        If Visible Then ActiveF = Nothing
        If Visible Then Timer = False
    End Sub
    Private Sub Me_FormClosed(sennder As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Subs.SelectQ = New List(Of String)
        SelectA = New List(Of String)
        Subs.SelectAs = New List(Of String())
        SelectRA = New List(Of String)
        SelectD = New List(Of Double)
        SelectTF = New List(Of Boolean)

        Subs.CompleteQ = New List(Of String)
        CompleteA = New List(Of String)
        CompleteRAs = New List(Of String())
        CompleteD = New List(Of Double)
        CompleteTF = New List(Of Boolean)

        JoinC1 = New List(Of String)
        JoinC2 = New List(Of String)
        JoinAC1 = New List(Of String)
        JoinAC2 = New List(Of String)
        JoinTQI = New List(Of String)
        JoinTAI = New List(Of String)
        JoinD = New List(Of Double)
        JoinD2 = New List(Of Double)
        JoinTF = New List(Of Boolean)

        ArrangeQ = New List(Of String)
        ArrangeA = New List(Of String)
        ArrangeRA = New List(Of String)
        ArrangeD = New List(Of Double)
        ArrangeTF = New List(Of Boolean)
    End Sub

    Private Sub ShowLog_Click(sender As Object, e As EventArgs) Handles ShowLog.Click
        SLog.Show()
    End Sub
End Class