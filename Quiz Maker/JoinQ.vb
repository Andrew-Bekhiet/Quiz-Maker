Imports System.IO
Imports System.Net

Public Class JoinQ
#Region "Variables"
    Public deleteall As Boolean = False
    Public sender2 As New List(Of System.Object)
    Dim LLX As Integer = 0
    Dim LLY As Integer = 0
    Dim LRX As Integer = 0
    Dim LRY As Integer = 0
    Dim LN, RN As String
    ReadOnly B As Boolean
    Dim Lin As Graphics = CreateGraphics()
    Dim Gsaver As Bitmap
    ReadOnly counter As Integer = 0
    ReadOnly er As Boolean = False
    Dim l As New Point
    Dim eras As Boolean = False
#End Region
    Private Sub JoinQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Hide()
        Button2.Enabled = Not QMSettings.Previous.Checked
#If Not DEBUG Then
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Me.Bounds = Screen.PrimaryScreen.Bounds
#End If
        If Subs.JoinC1(0).Contains("Header=") Then
            QHead.Text = Subs.JoinC1(0).Split("=")(1)
            QHead.Font = New FontConverter().ConvertFromString(Subs.JoinAC2(0))
        End If
        For Each Q As String In JoinC1
            Dim A As String = JoinC2(JoinC1.IndexOf(Q))
            Dim QB, AB As New Button()
            If Q.Contains(",") Then
                Dim Q2() As String = Q.Split(",")
                QB.Text = Q2(0).ToString()
                Try
                    QB.Font = New FontConverter().ConvertFromInvariantString(Q.Replace(Q2(0) + ",", ""))
                    Dim img As Image = Image.FromStream(New MemoryStream(New WebClient().DownloadData(Q2(3))))
                    QB.BackgroundImage = img
                    QB.BackgroundImageLayout = ImageLayout.None
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                QB.Font = New Font("Arial", 15, FontStyle.Regular)
                QB.Text = Q
            End If 'Set Q text and properties
            QB.Tag = JoinTAI(JoinC1.IndexOf(Q))
            If A.Contains(",") Then
                Dim Q2() As String = A.Split(",")
                AB.Text = Q2(0).ToString()
                Try
                    AB.Font = New FontConverter().ConvertFromInvariantString(A.Replace(Q2(0) + ",", ""))
                    Dim img As Image = Image.FromStream(New MemoryStream(New WebClient().DownloadData(Q2(3))))
                    AB.BackgroundImage = img
                    AB.BackgroundImageLayout = ImageLayout.None
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                AB.Font = New Font("Arial", 15, FontStyle.Regular)
                AB.Text = A
            End If 'Set A text and properties
            AB.Tag = JoinTQI(JoinC1.IndexOf(Q))

            AB.BackColor = SystemColors.ControlLight
            QB.BackColor = SystemColors.ControlLight
            AB.Dock = DockStyle.Fill
            QB.Dock = DockStyle.Fill
            AB.FlatStyle = FlatStyle.Flat
            QB.FlatStyle = FlatStyle.Flat
            QB.TabStop = False
            QB.FlatAppearance.BorderSize = 0
            AB.TabStop = False
            AB.FlatAppearance.BorderSize = 0
            Questions.RowCount += 1
            Questions.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / JoinC1.Count))
            Questions.Controls.Add(QB, 0, Questions.RowCount - 1)
            Questions.Controls.Add(AB, 2, Questions.RowCount - 1)
            AddHandler QB.Click, AddressOf Buttons_MouseClick
            AddHandler AB.Click, AddressOf Buttons_MouseClick
        Next
        Gsaver = New Bitmap(Questions.ClientRectangle.Width, Questions.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format64bppArgb)
        Lin = Graphics.FromImage(Gsaver)
        Lin.Clear(Color.White)
        If Subs.Questions(Subs.Questions.IndexOf(Me) + 1).GetType() Is Result.GetType() Then
            Button1.Text = "إنهاء"
            Button1.Image = My.Resources.Start
        Else
            Button1.Text = "التالي >"
            Button1.Image = My.Resources.Previouss
        End If
    End Sub
    Public Sub JoinQ_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Questions_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Questions.Paint
        Try
            Lin = e.Graphics
            Lin.DrawImage(Gsaver, 0, 0, Gsaver.Width, Gsaver.Height)
        Catch
        End Try
    End Sub
    Private Sub JoinQ_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
    Private Sub JoinQ_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Not (SelectQ.Visible OrElse CompleteQ.Visible) Then
            Me.WindowState = FormWindowState.Maximized
            Activate()
            Me.Visible = True

        End If
    End Sub
    Private Sub Buttons_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Static HalfHeight = (Questions.Controls.Item(0).Height / 2)
        Select Case Questions.Controls.IndexOf(sender) Mod 2
            Case Is = 1
                If Not (eras) Then
                    LN = sender.tag
                    If LLX = 0 AndAlso LLY = 0 AndAlso LRX = 0 AndAlso LRY = 0 Then
                        JoinAC1.Add(sender.Text)
                        LLX = sender.location.x + sender.width
                        LLY = sender.location.y
                        For Each Q As Button In Questions.Controls
                            If Questions.Controls.GetChildIndex(Q, False) Mod 2 = 1 Then
                                Q.Enabled = False
                            End If
                        Next
                        sender.backcolor = Color.Yellow
                        sender2.Add(sender)
                        For Each but As Button In Questions.Controls
                            but.TabStop = False
                            but.FlatAppearance.BorderSize = 0
                        Next
                    ElseIf Not (IsNothing(LRX = 0)) AndAlso Not (IsNothing(LRY = 0)) Then
                        JoinAC1.Add(sender.Text)
                        JoinD2.Add(JoinD(JoinC1.IndexOf(sender2(sender2.Count - 1).Text)))
                        LLX = sender.location.x + sender.width
                        LLY = sender.location.y
                        Lin = Graphics.FromImage(Gsaver)
                        Lin.DrawLine(Pens.Black, LLX, CSng(LLY + HalfHeight), LRX, CSng(LRY + HalfHeight))
                        Questions.Invalidate()
                        JoinTF.Add(CBool(LN = RN))
                        LRX = 0
                        LRY = 0
                        LLX = 0
                        LLY = 0
                        sender2.Add(sender)
                        For Each Q As Button In Questions.Controls
                            Q.Enabled = If(sender2.Contains(Q), False, True)
                            Q.BackColor = If(sender2.Contains(Q), Color.Gold, SystemColors.ControlLight)
                            Q.TabStop = False
                            Q.FlatAppearance.BorderSize = 0
                        Next
                    End If
                Else
                    'delete from records
                    JoinD2.RemoveAt(JoinAC1.IndexOf(sender.Text))
                    JoinTF.RemoveAt(JoinAC1.IndexOf(sender.Text))
                    JoinAC2.RemoveAt(JoinAC1.IndexOf(sender.Text))
                    JoinAC1.Remove(sender.Text)
                    'draw white color between them
                    Lin = Graphics.FromImage(Gsaver)
                    Lin.DrawLine(Pens.White,
                                 CSng(sender.location.x + sender.width),
                                 CSng(sender.location.y + HalfHeight),
                                 CSng(sender2.ElementAt(sender2.IndexOf(sender) + If(sender2.IndexOf(sender) Mod 2 = 0, +1, -1)).location.x),
                                 CSng(sender2.ElementAt(sender2.IndexOf(sender) + If(sender2.IndexOf(sender) Mod 2 = 0, +1, -1)).location.y + HalfHeight))
                    'invalidate()
                    Questions.Invalidate()
                    'delete from sender2
                    'and reset their colors
                    If sender2.IndexOf(sender) Mod 2 = 0 Then
                        DirectCast(sender2.ElementAt(sender2.IndexOf(sender) + 1), Button).BackColor = SystemColors.ControlLight
                        sender2.RemoveAt(sender2.IndexOf(sender) + 1)
                    Else
                        DirectCast(sender2.ElementAt(sender2.IndexOf(sender) - 1), Button).BackColor = SystemColors.ControlLight
                        sender2.RemoveAt(sender2.IndexOf(sender) - 1)
                    End If
                    sender.BackColor = SystemColors.ControlLight
                    sender2.Remove(sender)
                    For Each item As Button In Questions.Controls
                        If sender2.Contains(item) Then
                            item.Enabled = False
                        Else
                            item.Enabled = True
                        End If
                        item.TabStop = False
                        item.FlatAppearance.BorderSize = 0
                    Next
                    eras = Not (eras)
                End If
            Case Is = 0
                If Not (eras) Then
                    RN = sender.tag
                    If LRX = 0 AndAlso LRY = 0 AndAlso LLX = 0 AndAlso LLY = 0 Then
                        JoinAC2.Add(sender.Text)
                        LRX = sender.location.x
                        LRY = sender.location.y
                        For Each Q As Button In Questions.Controls
                            If Questions.Controls.GetChildIndex(Q, False) Mod 2 = 0 Then
                                Q.Enabled = False
                            End If
                        Next
                        sender.backcolor = Color.Yellow
                        sender2.Add(sender)
                        For Each Q As Button In Questions.Controls
                            Q.Enabled = If(sender2.Contains(Q), False, True)
                            Q.BackColor = If(sender2.Contains(Q), Color.Gold, SystemColors.ControlLight)
                            Q.TabStop = False
                            Q.FlatAppearance.BorderSize = 0
                        Next
                    ElseIf Not (IsNothing(LLX = 0)) AndAlso Not (IsNothing(LLY = 0)) Then
                        JoinAC2.Add(sender.Text)
                        JoinD2.Add(JoinD(JoinC1.IndexOf(sender.text)))
                        LRX = sender.location.x
                        LRY = sender.location.y
                        Lin = Graphics.FromImage(Gsaver)
                        Lin.DrawLine(Pens.Black, LLX, CSng(LLY + HalfHeight), LRX, CSng(LRY + HalfHeight))
                        Questions.Invalidate()
                        JoinTF.Add(CBool(LN = RN))
                        LRX = 0
                        LRY = 0
                        LLX = 0
                        LLY = 0
                        sender2.Add(sender)
                        For Each Q As Button In Questions.Controls
                            Q.Enabled = If(sender2.Contains(Q), False, True)
                            Q.BackColor = If(sender2.Contains(Q), Color.Gold, SystemColors.ControlLight)
                            Q.TabStop = False
                            Q.FlatAppearance.BorderSize = 0
                        Next
                    End If
                Else
                    JoinD2.RemoveAt(JoinAC2.IndexOf(sender.Text))
                    JoinTF.RemoveAt(JoinAC2.IndexOf(sender.Text))
                    JoinAC1.RemoveAt(JoinAC2.IndexOf(sender.Text))
                    JoinAC2.Remove(sender.Text)
                    'draw white color between them
                    Lin = Graphics.FromImage(Gsaver)

                    Lin.DrawLine(Pens.White,
                                 CSng(sender2.ElementAt(sender2.IndexOf(sender) + If(sender2.IndexOf(sender) Mod 2 = 0, +1, -1)).location.x + sender.width),
                                 CSng(sender2.ElementAt(sender2.IndexOf(sender) + If(sender2.IndexOf(sender) Mod 2 = 0, +1, -1)).location.y + HalfHeight),
                                 CSng(sender.location.x),
                                 CSng(sender.location.y + HalfHeight))
                    'invalidate()
                    Questions.Invalidate()
                    'delete from sender2
                    'and reset their colors
                    If sender2.IndexOf(sender) Mod 2 = 0 Then
                        DirectCast(sender2.ElementAt(sender2.IndexOf(sender) + 1), Button).BackColor = SystemColors.ControlLight
                        sender2.RemoveAt(sender2.IndexOf(sender) + 1)
                    Else
                        DirectCast(sender2.ElementAt(sender2.IndexOf(sender) - 1), Button).BackColor = SystemColors.ControlLight
                        sender2.RemoveAt(sender2.IndexOf(sender) - 1)
                    End If
                    sender.BackColor = SystemColors.ControlLight
                    sender2.Remove(sender)
                    For Each item As Button In Questions.Controls
                        If sender2.Contains(item) Then
                            item.Enabled = False
                        Else
                            item.Enabled = True
                        End If
                        item.TabStop = False
                        item.FlatAppearance.BorderSize = 0
                    Next
                    eras = Not (eras)
                End If
        End Select
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Subs.Questions(Subs.Questions.IndexOf(Me) - 1).Show()
    End Sub

    Private Sub JoinQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LRX = 0 AndAlso LRY = 0 AndAlso LLX = 0 AndAlso LLY = 0 Then
            For Each button As Button In Questions.Controls
                button.Enabled = eras
            Next
            For Each item As Object In sender2
                item.enabled = Not eras
            Next
            eras = Not (eras)
        ElseIf Not (IsNothing(LLX = 0)) AndAlso Not (IsNothing(LLY = 0)) Then
            LRX = 0
            LRY = 0
            LLX = 0
            LLY = 0
            sender2(sender2.Count - 1).backcolor = SystemColors.ControlLight
            sender2.RemoveAt(sender2.Count - 1)
            If JoinAC1.Count > JoinAC2.Count Then
                JoinAC1.RemoveAt(JoinAC1.Count - 1)
            ElseIf JoinAC2.Count > JoinAC1.Count Then
                JoinAC2.RemoveAt(JoinAC2.Count - 1)
            End If
            For Each button As Button In Questions.Controls
                button.Enabled = True
            Next
            For Each item As Object In sender2
                item.enabled = False
            Next
            LRX = 0
            LRY = LRX
        End If
    End Sub

    Private Sub Button3_Enter(sender As Object, e As EventArgs) Handles Button3.Enter, Button3.Leave
        B3Help.Visible = Not (B3Help.Visible)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While JoinTF.Count < JoinC1.Count
            JoinTF.Add(False)
            JoinAC1.Add("<No Answer>")
            JoinAC2.Add("<No Answer>")
        End While
        Subs.Questions(Subs.Questions.IndexOf(Me) + 1).Show()
    End Sub
End Class