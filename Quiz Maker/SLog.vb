Public Class SLog
    Private Sub SLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IndexP As UInteger = 0
        Dim OIndexP As UInteger = 0
        If Paths.Instance.SelectC.Checked Then
            Debug.WriteLine("SelectQ")
            For Index = 0 To Subs.SelectQ.Count - 1
                Dim Que As New Label() With {.Text = Subs.SelectQ(Index)}
                Que.FlatStyle = FlatStyle.Flat
                Que.BackColor = Color.White
                Que.Dock = DockStyle.Fill
                Que.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(Que, 0, Index)
                IndexP += 1
            Next

            For Index = 0 To Subs.SelectA.Count - 1
                Dim A As Label = New Label() With {.Text = Subs.SelectA(Index)}
                A.FlatStyle = FlatStyle.Flat
                A.BackColor = Color.White
                A.Dock = DockStyle.Fill
                A.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(A, 1, Index)
            Next

            For Index = 0 To Subs.SelectRA.Count - 1
                Dim RA As Label = New Label() With {.Text = Subs.SelectRA(Index)}
                RA.FlatStyle = FlatStyle.Flat
                RA.BackColor = Color.White
                RA.Dock = DockStyle.Fill
                RA.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(RA, 2, Index)
            Next

            For Index = 0 To Subs.SelectTF.Count - 1
                Dim TF As Label = New Label() With {.Text = If(Subs.SelectTF(Index), "إجابتك صحيحة", "إجابتك خاطئة"), .BackColor = If(Subs.SelectTF(Index), Color.Lime, Color.Red)}
                TF.FlatStyle = FlatStyle.Flat
                TF.Dock = DockStyle.Fill
                TF.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(TF, 3, Index)
            Next

            For Index = 0 To Subs.SelectD.Count - 1
                Dim D As Label = New Label() With {.Text = Subs.SelectD(Index)}
                D.FlatStyle = FlatStyle.Flat
                D.BackColor = Color.White
                D.Dock = DockStyle.Fill
                D.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(D, 4, Index)
            Next
            OIndexP = IndexP
        End If

        If Paths.Instance.CompleteC.Checked Then
            For Index = 0 To Subs.CompleteQ.Count - 1
                Dim Que = New Label() With {.Text = Subs.CompleteQ(Index).Replace("|", ".....")}
                Que.FlatStyle = FlatStyle.Flat
                Que.BackColor = Color.White
                Que.Dock = DockStyle.Fill
                Que.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(Que, 0, Index + OIndexP)
                IndexP += 1
            Next

            For Index = 0 To Subs.CompleteA.Count - 1
                Dim A As Label = New Label() With {.Text = Subs.CompleteA(Index).Replace(",", "-")}
                A.FlatStyle = FlatStyle.Flat
                A.BackColor = Color.White
                A.Dock = DockStyle.Fill
                A.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(A, 1, Index + OIndexP)
            Next

            For Index = 0 To Subs.CompleteRAs.Count - 1
                Dim RA As Label = New Label() With {.Text = If(CompleteRgx(Index), Subs.CompleteRAs(Index)(1), Subs.CompleteRAs(Index)(0))}
                RA.FlatStyle = FlatStyle.Flat
                RA.BackColor = Color.White
                RA.Dock = DockStyle.Fill
                RA.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(RA, 2, Index + OIndexP)
            Next

            For Index = 0 To Subs.CompleteTF.Count - 1
                Dim TF As Label = New Label() With {.Text = If(Subs.CompleteTF(Index), "إجابتك صحيحة", "إجابتك خاطئة"), .BackColor = If(Subs.CompleteTF(Index), Color.Lime, Color.Red)}
                TF.FlatStyle = FlatStyle.Flat
                TF.Dock = DockStyle.Fill
                TF.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(TF, 3, Index + OIndexP)
            Next

            For Index = 0 To Subs.CompleteD.Count - 1
                Dim D As Label = New Label() With {.Text = Subs.CompleteD(Index)}
                D.FlatStyle = FlatStyle.Flat
                D.BackColor = Color.White
                D.Dock = DockStyle.Fill
                D.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(D, 4, Index + OIndexP)
            Next
            OIndexP = IndexP
        End If

        If Paths.Instance.JoinC.Checked Then
            For Index = 0 To Subs.JoinC2.Count - 1
                Dim Que As New Label() With {.Text = Subs.JoinC2(Index)}
                Que.FlatStyle = FlatStyle.Flat
                Que.BackColor = Color.White
                Que.Dock = DockStyle.Fill
                Que.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(Que, 0, Index + OIndexP)
                IndexP += 1
            Next

            For Index = 0 To Subs.JoinC2.Count - 1
                Dim A As Label = New Label() With {.Text = Subs.JoinAC1(Index).Replace("<No Answer>", "<لا إجابة>")}
                A.FlatStyle = FlatStyle.Flat
                A.BackColor = Color.White
                A.Dock = DockStyle.Fill
                A.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(A, 1, Index + OIndexP)
            Next

            For Index = 0 To Subs.JoinC2.Count - 1
                Dim RA As Label = New Label() With {.Text = GetJoinRA(Subs.JoinC2(Index))}
                RA.FlatStyle = FlatStyle.Flat
                RA.BackColor = Color.White
                RA.Dock = DockStyle.Fill
                RA.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(RA, 2, Index + OIndexP)
            Next

            For Index = 0 To Subs.JoinTF.Count - 1
                Dim TF As Label = New Label() With {.Text = If(Subs.JoinTF(Index), "إجابتك صحيحة", "إجابتك خاطئة"), .BackColor = If(Subs.JoinTF(Index), Color.Lime, Color.Red)}
                TF.FlatStyle = FlatStyle.Flat
                TF.Dock = DockStyle.Fill
                TF.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(TF, 3, Index + OIndexP)
            Next

            For Index = 0 To Subs.JoinD.Count - 1
                Dim D As Label = New Label() With {.Text = Subs.JoinD(Index)}
                D.FlatStyle = FlatStyle.Flat
                D.BackColor = Color.White
                D.Dock = DockStyle.Fill
                D.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(D, 4, Index + OIndexP)
            Next
            OIndexP = IndexP
        End If

        If Paths.Instance.ArrangeC.Checked Then
            For Index = 0 To Subs.ArrangeQ.Count - 1
                Dim Que As New Label() With {.Text = Subs.ArrangeQ(Index)}
                Que.FlatStyle = FlatStyle.Flat
                Que.BackColor = Color.White
                Que.Dock = DockStyle.Fill
                Que.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(Que, 0, Index + OIndexP)
                IndexP += 1
            Next

            For Index = 0 To Subs.ArrangeA.Count - 1
                Dim A As Label = New Label() With {.Text = Subs.ArrangeA(Index)}
                A.FlatStyle = FlatStyle.Flat
                A.BackColor = Color.White
                A.Dock = DockStyle.Fill
                A.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(A, 1, Index + OIndexP)
            Next

            For Index = 0 To Subs.ArrangeRA.Count - 1
                Dim RA As Label = New Label() With {.Text = Subs.ArrangeRA(Index)}
                RA.FlatStyle = FlatStyle.Flat
                RA.BackColor = Color.White
                RA.Dock = DockStyle.Fill
                RA.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(RA, 2, Index + OIndexP)
            Next

            For Index = 0 To Subs.ArrangeTF.Count - 1
                Dim TF As Label = New Label() With {.Text = If(Subs.ArrangeTF(Index), "إجابتك صحيحة", "إجابتك خاطئة"), .BackColor = If(Subs.ArrangeTF(Index), Color.Lime, Color.Red)}
                TF.FlatStyle = FlatStyle.Flat
                TF.Dock = DockStyle.Fill
                TF.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(TF, 3, Index + OIndexP)
            Next

            For Index = 0 To Subs.ArrangeD.Count - 1
                Dim D As Label = New Label() With {.Text = Subs.ArrangeD(Index)}
                D.FlatStyle = FlatStyle.Flat
                D.BackColor = Color.White
                D.Dock = DockStyle.Fill
                D.Font = New Font("Arial", 15, FontStyle.Regular)
                Log.RowCount += 1
                Log.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                Log.Controls.Add(D, 4, Index + OIndexP)
            Next
        End If
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(Me.Size.Width, Me.Size.Height)
        Me.Controls.Add(TableLayoutPanel2)
    End Sub
    Public Function GetJoinRA(JoinC1 As String) As String
        Try
            Return JoinC2(JoinTQI.IndexOf(JoinTAI(Subs.JoinC1.IndexOf(JoinC1))))
        Catch
        End Try
        Return Subs.JoinC1(JoinTAI.IndexOf(JoinTQI(Subs.JoinC2.IndexOf(JoinC1))))
    End Function
End Class