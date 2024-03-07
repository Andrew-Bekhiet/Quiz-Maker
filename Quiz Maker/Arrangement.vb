Public Class Arrangement
    Private Sub Arrangement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Hide()
        Button2.Enabled = Not QMSettings.Previous.Checked
#If Not DEBUG Then
        Me.TopMost = True
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Me.Bounds = Screen.PrimaryScreen.Bounds
#End If

        ShowcurrentQ()
    End Sub

    Private Sub ShowcurrentQ()
        For Index = 0 To ArrangeQ.Count - 1
            If Subs.ArrangeQ(Index).Contains("Header=") Then
                QHead.Text = Subs.ArrangeQ(Index).Split("=")(1)
                QHead.Font = New FontConverter().ConvertFromString(Subs.ArrangeRA(Index))
                Index += 1
            End If

            Dim Q As New Button With {
                .Text = ArrangeQ(Index),
                .Tag = ArrangeRA(Index),
                .TabStop = False
            }
            Q.FlatAppearance.BorderSize = 0
            Q.FlatStyle = FlatStyle.Flat
            Q.BackColor = Color.White
            Q.Dock = DockStyle.Fill
            Q.Font = New Font("Arial", 15, FontStyle.Regular)
            AddHandler Q.Click, AddressOf Button_Click
            Table.RowCount += 1
            If Index = 0 Then
                Table.RowStyles(0) = New RowStyle(SizeType.Percent, CSng(100 / ArrangeQ.Count))
            Else
                Table.RowStyles.Add(New RowStyle(SizeType.Percent, CSng(100 / ArrangeQ.Count)))
            End If
            Table.Controls.Add(Q, 0, Index)
        Next
    End Sub

    ReadOnly Sender2 As New List(Of Button)
    Sub Button_Click(ByVal sender As Button, ByVal e As EventArgs)
        sender.BackColor = Color.Yellow
        If Sender2.Count = 0 Then
            Sender2.Add(sender)
        Else
            Dim posC1 As TableLayoutPanelCellPosition = Table.GetCellPosition(sender)
            Dim posC2 As TableLayoutPanelCellPosition = Table.GetCellPosition(Sender2(0))
            Table.SetCellPosition(Sender2(0), posC1)
            Table.SetCellPosition(sender, posC2)
            Sender2(0).BackColor = Color.White
            sender.BackColor = Color.White
            Sender2.Remove(Sender2(0))
        End If
        For Each but As Button In Table.Controls
            but.TabStop = False
            but.FlatAppearance.BorderSize = 0
        Next
    End Sub

    Public Sub Arrangement_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Arrangement_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
    Private Sub Arrangement_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        On Error Resume Next
        If Not (SelectQ.Visible OrElse JoinQ.Visible) Then
            Me.WindowState = FormWindowState.Maximized
            Activate()
            Me.Visible = True
        End If
    End Sub

    Private Sub Arrangement_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Questions(Questions.IndexOf(Me) - 1).Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 0 To ArrangeA.Count - 1
            For Each cont As Control In Table.Controls
                If Table.GetCellPosition(cont).Row = index Then
                    ArrangeA(index) = cont.Tag
                    ArrangeTF(index) = CBool(cont.Tag = index + 1)
                    Exit For
                End If
            Next
        Next
        Me.Hide()
        Questions(Questions.IndexOf(Me) + 1).Show()
    End Sub
End Class