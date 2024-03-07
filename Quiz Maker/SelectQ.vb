Public Class SelectQ
    Dim FirstS As String = ""
    Dim CR() As String
    Dim AA As String
    Dim L As New Point
    Dim Index As Integer = 0
#Region "Load + VisibleChange + Close"
    Private Sub SelectQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not (EditQFrmt.Visible) Then
            Main.Hide()
#If Not DEBUG Then
            Me.TopMost = True
            L = Me.Location
            Me.Bounds = My.Computer.Screen.Bounds
            Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
#End If
            ShowcurrentQ(+1)
        Else

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
        sender.Enabled = False
        SelectA(Index) = AA
        SelectTF(Index) = CBool(SelectRA(Index) = AA)
        If Index = Subs.SelectQ.Count - 1 Then
            Questions(Questions.IndexOf(Me) + 1).Show()
            Me.Hide()
        Else
            Index += 1
            AA = SelectA(Index)
            ShowcurrentQ(+1)
        End If
        sender.Enabled = True
    End Sub
    Public Sub ShowcurrentQ(FB As Integer)
        A1Label.Show()
        A2Label.Show()
        A3Label.Show()
        A4Label.Show()
        If Subs.SelectQ(Index).Contains("Header=") Then
            QHead.Text = Subs.SelectQ(Index).Split("=")(1)
            QHead.Font = New FontConverter().ConvertFromString(Subs.SelectAs(Index)(0))
            If Not (Index = 0 AndAlso FB = -1) Then
                Index += FB
            Else
                Index += 1
            End If
        End If
        If Index >= 0 Then
            If Subs.SelectQ(Index).Contains(",") Then
                Dim Q() As String = Subs.SelectQ(Index).Split(",")
                QLabel.Text = Q(0).ToString()
                Try
                    QLabel.Font = New FontConverter().ConvertFromInvariantString(Subs.SelectQ(Index).Replace(Q(0) + ",", ""))
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                QLabel.Text = Subs.SelectQ(Index).ToString
            End If
            If Subs.SelectAs(Index)(0).Contains(",") Then
                Dim Q() As String = Subs.SelectAs(0)(Index).Split(",")
                A1Label.Text = Q(0).ToString()
                Try
                    A1Label.Font = New FontConverter().ConvertFromInvariantString(Subs.SelectAs(Index)(0).Replace(Q(0) + ",", ""))
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A1Label.Text = Subs.SelectAs(Index)(0)
            End If
            If Subs.SelectAs(Index)(1).Contains(",") Then
                Dim Q() As String = Subs.SelectAs(Index)(1).Split(",")
                A2Label.Text = Q(0).ToString()
                Try
                    A2Label.Font = New FontConverter().ConvertFromInvariantString(Subs.SelectAs(Index)(1).Replace(Q(0) + ",", ""))
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A2Label.Text = Subs.SelectAs(Index)(1)
            End If
            If Subs.SelectAs(Index)(2).Contains(",") Then
                Dim Q() As String = Subs.SelectAs(Index)(2).Split(",")
                A3Label.Text = Q(0).ToString()
                Try
                    A3Label.Font = New FontConverter().ConvertFromInvariantString(Subs.SelectAs(Index)(2).Replace(Q(0) + ",", ""))
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A3Label.Text = Subs.SelectAs(Index)(2)
            End If
            If Subs.SelectAs(Index)(3).Contains(",") Then
                Dim Q() As String = Subs.SelectAs(Index)(3).Split(",")
                A4Label.Text = Q(0).ToString()
                Try
                    A4Label.Font = New FontConverter().ConvertFromInvariantString(Subs.SelectAs(Index)(3).Replace(Q(0) + ",", ""))
                    Picture.ImageLocation = Q(3).ToString
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine(ex.StackTrace)
                End Try
            Else
                Picture.ImageLocation = ""
                A4Label.Text = Subs.SelectAs(Index)(3)
            End If
            If SelectA(Index) = A1Label.Text.ToString Then A1Label.Checked = True
            If SelectA(Index) = A2Label.Text.ToString Then A2Label.Checked = True
            If SelectA(Index) = A3Label.Text.ToString Then A3Label.Checked = True
            If SelectA(Index) = A4Label.Text.ToString Then A4Label.Checked = True
            Button1.Enabled = If(Index = 0 OrElse Subs.SelectQ(Index).Contains("Header="), False, If(QMSettings.Previous.Checked, False, True))
        End If
        If Index = Subs.SelectQ.Count - 1 AndAlso Questions(Questions.IndexOf(Me) + 1).GetType() Is Result.GetType() Then
            Button2.Text = "إنهاء"
            Button2.Image = My.Resources.Start
        Else
            Button2.Text = "التالي >"
            Button2.Image = My.Resources.Previouss
        End If
        If A1Label.Text = "" Then A1Label.Hide()
        If A2Label.Text = "" Then A2Label.Hide()
        If A3Label.Text = "" Then A3Label.Hide()
        If A4Label.Text = "" Then A4Label.Hide()
    End Sub
    Public Sub Previous_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sender.Enabled = False
        SelectA(Index) = AA
        SelectTF(Index) = CBool(SelectRA(Index) = AA)
        If Not (Index = 1 AndAlso Subs.SelectQ(Index - 1).Contains("Header=")) Then
            Index -= 1
            AA = SelectA(Index)
            ShowcurrentQ(-1)
        End If
        Button1.Enabled = If(Index = 0 OrElse Subs.SelectQ(Index).Contains("Header="), False, Not QMSettings.Previous.Checked)
    End Sub
#End Region
    Private Sub SelectQ_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ActiveF = Me
    End Sub
    Public Sub SelectQ_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SelectQ_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Debug.WriteLine(CompleteQ.Visible)
        Debug.WriteLine(JoinQ.Visible)
        If Not (CompleteQ.Visible OrElse JoinQ.Visible) Then
            Me.WindowState = FormWindowState.Maximized
            Activate()
            Me.Visible = True
            Me.Show()
        End If
    End Sub
    Private Sub A1Label_CheckedChanged(sender As Object, e As EventArgs) Handles A1Label.CheckedChanged, A2Label.CheckedChanged, A3Label.CheckedChanged, A4Label.CheckedChanged, A4Label.Click, A3Label.Click, A2Label.Click, A1Label.Click, A1Label.TextChanged, A2Label.TextChanged, A3Label.TextChanged, A4Label.TextChanged
        If sender.checked Then AA = sender.text
    End Sub

    Private Sub SelectQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub
End Class