Imports System.Text.RegularExpressions

Public Class CompleteQ
    ReadOnly CR As String()
    ReadOnly AA As String
    ReadOnly FirstS As String
    Dim Index As Integer = 0
    Dim l As New Point
    Private Sub CompleteQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Hide()
#If Not DEBUG Then
        Me.TopMost = True
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Me.Bounds = Screen.PrimaryScreen.Bounds
#End If

        ShowcurrentQ(+1)
    End Sub
#Region "Get Answer + Next + Previous + Show Current Question Sub"
    Function GetAnswer() As String
        Dim Result As String = ""
        Using TextType As New TextBox()
            For Each obj As Control In FLP.Controls
                If obj.GetType() Is TextType.GetType() Then
                    Result &= obj.Text & ","
                End If
            Next
        End Using
        Return Result.Remove(Result.Count - 1)
    End Function
    Private Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Enabled = Not QMSettings.Previous.Checked
        CompleteA(Index) = GetAnswer()
        If CompleteRgx(Index) Then
            Dim AnsRgx As New Regex(CompleteRAs(Index)(0).Split("#")(0), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
            Dim Anss As String() = CompleteRAs(Index)(0).Split("#")
            For Index2 = 0 To Anss.Count - 1
                If Index2 = 0 Then
                    CompleteTF(Index) = AnsRgx.IsMatch(GetAnswer().Split(",")(Index2), Anss(Index2), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
                Else
                    CompleteTF(Index) = CompleteTF(Index) AndAlso AnsRgx.IsMatch(GetAnswer().Split(",")(Index2), Anss(Index2), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
                End If
            Next
        Else
            CompleteTF(Index) = CBool(GetTagreed(CompleteRAs(Index)(0)) = GetAnswer() OrElse GetTagreed(CompleteRAs(Index)(1)) = GetAnswer() OrElse GetTagreed(CompleteRAs(Index)(2)) = GetAnswer())
        End If
        If Index = Subs.CompleteQ.Count - 1 Then
            Questions(Questions.IndexOf(Me) + 1).Show()
            Me.Hide()
        Else
            Index += 1
            ShowcurrentQ(+1)
        End If
    End Sub
    Public Sub ShowcurrentQ(ByVal FB As Integer)
        If Subs.CompleteQ(Index).Contains("Header=") Then
            QHead.Text = Subs.CompleteQ(Index).Split("=")(1)
            QHead.Font = New FontConverter().ConvertFromString(Subs.CompleteRAs(Index)(0))
            If Not (Index = 0 AndAlso FB = -1) Then
                Index += FB
            Else
                Index += 1
            End If
        End If
        Dim font As Font
        Dim txt As String = Subs.CompleteQ(Index)
        Me.Controls.Remove(FLP)
        Me.Controls.Remove(TLP2)
        FLP = New FlowLayoutPanel With {
            .Dock = DockStyle.Bottom
        }
        Me.Controls.Add(Me.FLP)
        Me.Controls.Add(Me.TLP2)
        FLP.Location = New Point(0, 482)
        FLP.Size = New Size(1125, 163)
        If Subs.CompleteQ(Index).Contains(",") Then
            Dim Q() As String = Subs.CompleteQ(Index).Split(",")
            txt = Q(0).ToString()
            Try
                font = New FontConverter().ConvertFromInvariantString(Subs.CompleteQ(Index).Replace(Q(0) + ",", ""))
                Picture.ImageLocation = Q(3)
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            font = New Font("Arial", 15, FontStyle.Regular)
            Picture.ImageLocation = ""
        End If
        If Subs.CompleteQ(Index).Contains("|") Then
            For Index2 = 0 To (Subs.CompleteQ(Index).Split("|").Count + CompleteRAs(Index)(0).Split(If(CompleteRgx(Index), "#", ",")).Count) - 1
                If Index2 Mod 2 = 0 Then
                    FLP.Controls.Add(New Label With {.AutoSize = False, .Size = TextRenderer.MeasureText(Subs.CompleteQ(Index).Split("|")(Index2 - (Index2 / 2)).Split(If(CompleteRgx(Index), "#", ","))(0), font), .Text = Subs.CompleteQ(Index).Split("|")(Index2 - (Index2 / 2)).Split(If(CompleteRgx(Index), "#", ","))(0), .Font = font, .UseCompatibleTextRendering = True})
                Else
                    Dim textbox As New TextBox With {
                        .Dock = DockStyle.Fill,
                        .Text = If(CompleteA(Index).Contains(","), CompleteA(Index), ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,").Split(",")((Index2 - ((Index2 / 2) + 0.5))),
                        .Font = font}
                    AddHandler textbox.Enter, AddressOf TextBox1_Enter
                    AddHandler textbox.Leave, AddressOf TextBox1_Leave
                    FLP.Controls.Add(textbox)
                End If
            Next
        Else
            Dim la As New Label With {
                .Font = font,
                .Text = txt,
                .UseCompatibleTextRendering = True
            }
            FLP.Controls.Add(la)
            Dim txtbx As New TextBox With {
                .Font = font,
                .Text = CompleteA(Index)
            }
            AddHandler txtbx.Enter, AddressOf TextBox1_Enter
            AddHandler txtbx.Leave, AddressOf TextBox1_Leave
            FLP.Controls.Add(txtbx)
        End If
        FLP.Controls.Item(1).Select()
        If Index = Subs.CompleteQ.Count - 1 AndAlso Questions(Questions.IndexOf(Me) + 1).GetType() Is Result.GetType() Then
            Button1.Text = "إنهاء"
            Button1.Image = My.Resources.Start
        Else
            Button1.Text = "التالي >"
            Button1.Image = My.Resources.Previouss
        End If
    End Sub
    Function GetTagreed(ByVal str As String) As String
        Return str.Replace("أ", "ا").Replace("آ", "ا").Replace("إ", "ا").Replace("ى", "ي").Replace("ة", "ه").ToLower()
    End Function
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CompleteA(Index) = GetAnswer()
        If CompleteRgx(Index) Then
            Dim AnsRgx As New Regex(CompleteRAs(Index)(0).Split("#")(0), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
            Dim Anss As String() = CompleteRAs(Index)(0).Split("#")
            For Index2 = 0 To Anss.Count - 1
                If Index2 = 0 Then
                    CompleteTF(Index) = AnsRgx.IsMatch(GetAnswer().Split(",")(Index2), Anss(Index2), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
                Else
                    CompleteTF(Index) = CompleteTF(Index) AndAlso AnsRgx.IsMatch(GetAnswer().Split(",")(Index2), Anss(Index2), RegexOptions.IgnoreCase Or RegexOptions.RightToLeft)
                End If
            Next
        Else
            CompleteTF(Index) = CBool(GetTagreed(CompleteRAs(Index)(0)) = GetAnswer() OrElse GetTagreed(CompleteRAs(Index)(1)) = GetAnswer() OrElse GetTagreed(CompleteRAs(Index)(2)) = GetAnswer())
        End If
        If (Index = 0 OrElse Subs.CompleteQ(Index - 1).Contains("Header=")) AndAlso Paths.Instance.SelectC.Checked Then
            Questions(Questions.IndexOf(Me) - 1).Show()
            Me.Hide()
        ElseIf (Index = 0 OrElse Subs.CompleteQ(Index - 1).Contains("Header=")) Then
            sender.enabled = False
        Else
            Index -= 1
            ShowcurrentQ(-1)
        End If
    End Sub
#End Region
    Public Sub CompleteQ_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs)
        If sender.text = "......." Then
            sender.text = ""
        End If
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs)
        If sender.text = "" Then
            sender.text = "......."
        End If
    End Sub
    Private Sub CompleteQ_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
    Private Sub CompleteQ_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        On Error Resume Next
        If Not (SelectQ.Visible OrElse JoinQ.Visible) Then
            Me.WindowState = FormWindowState.Maximized
            Activate()
            Me.Visible = True
        End If

    End Sub

    Private Sub CompleteQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds

    End Sub
End Class