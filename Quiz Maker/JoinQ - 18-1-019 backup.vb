Public Class JoinQ
#Region "Variables"
    Public deleteall As Boolean = False
    Public sender2 As New List(Of System.Object)
    Private ConnStr As New ADODB.Recordset()
    Private Conn As New ADODB.Connection()
    Private ConnStr2 As ADODB.Recordset = MainASSDB
    Private Conn2 As ADODB.Connection = DB
    Dim LLX As Integer = 0
    Dim LLY As Integer = 0
    Dim LRX As Integer = 0
    Dim LRY As Integer = 0
    Dim LN, RN As String
    Dim B As Boolean
    Dim Lin As Graphics = CreateGraphics()
    Dim Gsaver As Bitmap
    Dim counter As Integer = 0
    Dim er As Boolean = False
    Dim l As New Point
    Dim eras As Boolean = False
#End Region
    Private Sub JoinQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Hide()
        TextBox1.Text = Databasesselecter.TextBox3.Text
        Me.Bounds = My.Computer.Screen.Bounds
        Me.MinimumSize = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)
        Try
            Me.Bounds = Screen.PrimaryScreen.Bounds
            If Databasesselecter.JoinPC.Checked And Conn.State = 0 Then
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & TextBox1.Text & ";Jet OLEDB:Database Password = " & Databasesselecter.JoinP.Text)
            ElseIf Conn.State = 0 Then
                Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & TextBox1.Text)
            End If
            ConnStr.Open(Databasesselecter.JoinT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
        Catch ex As Exception
            MsgBox("(Join)حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة", 0 Or 48 Or MsgBoxStyle.MsgBoxRight)
            Debug.WriteLine(ex.Message & " " & ex.StackTrace)
            er = True
            Main.Show()
            C = True
            Me.Close()
            Exit Sub
        End Try
        If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
            B1.Text = Q(0).ToString()
            Try
                B1.Font = New Font(Q(1), CDec(Q(2)))
                PictureBox1.ImageLocation = Q(3).ToString
                B1.Image = PictureBox1.Image
                Me.BackgroundImage = PictureBox1.Image
                Me.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            PictureBox1.ImageLocation = ""
            B1.Text = ConnStr.Fields("Q").Value.ToString
        End If
        If ConnStr.Fields("A").Value.ToString.Contains(",") Then
            Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
            B12.Text = Q(0).ToString()
            Try
                B12.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                PictureBox1.ImageLocation = Q(3)
                B12.BackgroundImage = PictureBox1.Image
            Catch ex As IndexOutOfRangeException
            End Try
        Else
            PictureBox1.ImageLocation = ""
            B12.Text = ConnStr.Fields("A").Value.ToString
        End If
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B2.Text = Q(0).ToString()
                Try
                    B2.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B2.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B2.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B13.Text = Q(0).ToString()
                Try
                    B13.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B13.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B13.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B2.Hide()
            B13.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B3.Text = Q(0).ToString()
                Try
                    B3.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B3.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B3.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B14.Text = Q(0).ToString()
                Try
                    B14.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B14.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B14.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B3.Hide()
            B14.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B4.Text = Q(0).ToString()
                Try
                    B4.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B4.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B4.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B15.Text = Q(0).ToString()
                Try
                    B15.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B15.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B15.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B4.Hide()
            B15.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B5.Text = Q(0).ToString()
                Try
                    B5.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B5.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B5.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B16.Text = Q(0).ToString()
                Try
                    B16.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B16.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B16.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B5.Hide()
            B16.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B6.Text = Q(0).ToString()
                Try
                    B6.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B6.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B6.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B17.Text = Q(0).ToString()
                Try
                    B17.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B17.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B17.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B6.Hide()
            B17.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B7.Text = Q(0).ToString()
                Try
                    B7.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B7.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B7.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B18.Text = Q(0).ToString()
                Try
                    B18.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B18.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B18.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B7.Hide()
            B18.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B8.Text = Q(0).ToString()
                Try
                    B8.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B8.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B8.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B19.Text = Q(0).ToString()
                Try
                    B19.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B19.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B19.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B8.Hide()
            B19.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B9.Text = Q(0).ToString()
                Try
                    B9.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B9.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B9.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B20.Text = Q(0).ToString()
                Try
                    B20.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B20.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B20.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B9.Hide()
            B20.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B10.Text = Q(0).ToString()
                Try
                    B10.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B10.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B10.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B21.Text = Q(0).ToString()
                Try
                    B21.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B21.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B21.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B10.Hide()
            B21.Hide()
        End Try
        Try
            ConnStr.MoveNext()
            If ConnStr.Fields("Q").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("Q").Value.ToString.Split(",")
                B11.Text = Q(0).ToString()
                Try
                    B11.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B11.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B11.Text = ConnStr.Fields("Q").Value.ToString
            End If
            If ConnStr.Fields("A").Value.ToString.Contains(",") Then
                Dim Q() As String = ConnStr.Fields("A").Value.ToString.Split(",")
                B22.Text = Q(0).ToString()
                Try
                    B22.Font = New Font(Q(1), CDec(Q(2)), FontStyle.Bold)
                    PictureBox1.ImageLocation = Q(3)
                    B22.BackgroundImage = PictureBox1.Image
                Catch ex As IndexOutOfRangeException
                End Try
            Else
                PictureBox1.ImageLocation = ""
                B22.Text = ConnStr.Fields("A").Value.ToString
            End If
        Catch
            B11.Hide()
            B22.Hide()
        End Try
        BackgroundImage = B1.BackgroundImage
        ConnStr.MoveFirst()
        Gsaver = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        Lin = Graphics.FromImage(Gsaver)
        Lin.Clear(Color.White)
    End Sub
    Private Sub SelectQ_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Try
            If Not (er) Then
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
                    ConnStr2.Fields("Q").Value = "Join:"
                    ConnStr2.Update()
                End If
            ElseIf Not (SelectQ.Visible Or CompleteQ.Visible) Then
                Activate()
                Me.Visible = True
            End If
        Catch
        End Try
    End Sub
    Public Sub JoinQ_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not (C) Then e.Cancel = True
    End Sub
    Private Sub JoinQ_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
        If Not (SelectQ.Visible Or CompleteQ.Visible) Then
            Activate()
            Me.Visible = True
        End If
    End Sub
    Public Function RorF(ByRef Bo As Boolean)
        ConnStr.MoveFirst()
        Dim Q As String() = ConnStr.Fields("Q").Value.ToString.Split(",")
        While Q(0) <> LN
            ConnStr.MoveNext()
            Q = ConnStr.Fields("Q").Value.ToString.Split(",")
        End While
        ConnStr2.AddNew()
        ConnStr2.Fields("Q").Value = LN
        QMark.Value = ConnStr.Fields("Degree").Value.ToString
        ConnStr2.Fields("D").Value = ConnStr.Fields("Degree").Value.ToString
        LN = ConnStr.Fields("TAI").Value.ToString
        ConnStr.MoveFirst()
        Q = ConnStr.Fields("Q").Value.ToString.Split(",")
        Dim A As String() = ConnStr.Fields("A").Value.ToString.Split(",")
        While A(0) <> RN
            ConnStr.MoveNext()
            A = ConnStr.Fields("A").Value.ToString.Split(",")
        End While
        ConnStr2.Fields("A").Value = RN
        RN = ConnStr.Fields("TQI").Value.ToString
        If RN = LN Then
            Bo = True
        Else
            Bo = False
        End If
        ConnStr2.Fields("TF").Value = Bo.ToString
        ConnStr2.Update()
        Return Bo
        LN = ""
        RN = ""
    End Function
    Private Sub B8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles B13.MouseClick, B12.MouseClick, B7.MouseClick, B6.MouseClick, B5.MouseClick, B4.MouseClick, B3.MouseClick, B2.MouseClick, B18.MouseClick, B17.MouseClick, B16.MouseClick, B15.MouseClick, B14.MouseClick, B1.MouseClick, B21.MouseClick, B20.MouseClick, B19.MouseClick, B11.MouseClick, B10.MouseClick, B9.MouseClick, B8.MouseClick, B22.MouseClick
        Select Case sender.Name
            Case Is = "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11"
                If Not (eras) Then
                    LN = sender.text
                    If LLX = 0 And LLY = 0 And LRX = 0 And LRY = 0 Then
                        LLX = sender.location.x + sender.width
                        LLY = sender.location.y
                        B1.Enabled = False
                        B2.Enabled = False
                        B3.Enabled = False
                        B4.Enabled = False
                        B5.Enabled = False
                        B6.Enabled = False
                        B7.Enabled = False
                        B8.Enabled = False
                        B9.Enabled = False
                        B10.Enabled = False
                        B11.Enabled = False
                        sender.backcolor = Color.Yellow
                        sender2.Add(sender)
                    ElseIf Not (IsNothing(LRX = 0)) And Not (IsNothing(LRY = 0)) Then
                        LLX = sender.location.x + sender.width
                        LLY = sender.location.y
                        Lin = Graphics.FromImage(Gsaver)
                        Lin.DrawLine(Pens.Black, LLX, LLY + 23, LRX, LRY + 23)
                        Me.Invalidate()
                        RorF(B)
                        If B Then
                            FMark.Value += QMark.Value
                        End If
                        LRX = 0
                        LRY = 0
                        LLX = 0
                        LLY = 0
                        B12.Enabled = True
                        B13.Enabled = True
                        B14.Enabled = True
                        B15.Enabled = True
                        B16.Enabled = True
                        B17.Enabled = True
                        B18.Enabled = True
                        B19.Enabled = True
                        B20.Enabled = True
                        B21.Enabled = True
                        B22.Enabled = True
                        sender.enabled = False
                        sender2.Add(sender)
                        For Each item As Object In sender2
                            item.backcolor = Color.Gold
                            item.enabled = False
                        Next
                    End If
                Else
                    ConnStr2.MoveFirst()
                    Do Until ConnStr2.EOF
                        If ConnStr2.Fields("Q").Value.ToString = sender.text Then
                            Dim joined As String = ConnStr2.Fields("A").Value.ToString
                            ConnStr2.Delete()
                            sender2.Remove(sender)
                            sender.backcolor = SystemColors.ControlLight
                            If B12.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B12.Location.X, B12.Location.Y + 23, sender.location.x + B12.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B12)
                                B12.BackColor = SystemColors.ControlLight
                            ElseIf B13.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B13.Location.X, B13.Location.Y + 23, sender.location.x + B13.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B13)
                                B13.BackColor = SystemColors.ControlLight
                            ElseIf B14.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B14.Location.X, B14.Location.Y + 23, sender.location.x + B14.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B14)
                                B14.BackColor = SystemColors.ControlLight
                            ElseIf B15.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B15.Location.X, B15.Location.Y + 23, sender.location.x + B15.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B15)
                                B15.BackColor = SystemColors.ControlLight
                            ElseIf B16.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B16.Location.X, B16.Location.Y + 23, sender.location.x + B16.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B16)
                                B16.BackColor = SystemColors.ControlLight
                            ElseIf B17.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B17.Location.X, B17.Location.Y + 23, sender.location.x + B17.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B17)
                                B17.BackColor = SystemColors.ControlLight
                            ElseIf B18.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B18.Location.X, B18.Location.Y + 23, sender.location.x + B18.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B18)
                                B18.BackColor = SystemColors.ControlLight
                            ElseIf B19.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B19.Location.X, B19.Location.Y + 23, sender.location.x + B19.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B19)
                                B19.BackColor = SystemColors.ControlLight
                            ElseIf B20.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B20.Location.X, B20.Location.Y + 23, sender.location.x + B20.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B20)
                                B20.BackColor = SystemColors.ControlLight
                            ElseIf B21.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B21.Location.X, B21.Location.Y + 23, sender.location.x + B21.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B21)
                                B21.BackColor = SystemColors.ControlLight
                            ElseIf B22.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B22.Location.X, B22.Location.Y + 23, sender.location.x + B22.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B22)
                                B22.BackColor = SystemColors.ControlLight
                            End If
                            B1.Enabled = True
                            B2.Enabled = True
                            B3.Enabled = True
                            B4.Enabled = True
                            B5.Enabled = True
                            B6.Enabled = True
                            B7.Enabled = True
                            B8.Enabled = True
                            B9.Enabled = True
                            B10.Enabled = True
                            B11.Enabled = True
                            B12.Enabled = True
                            B13.Enabled = True
                            B14.Enabled = True
                            B15.Enabled = True
                            B16.Enabled = True
                            B17.Enabled = True
                            B18.Enabled = True
                            B19.Enabled = True
                            B20.Enabled = True
                            B21.Enabled = True
                            B22.Enabled = True
                            For Each item As Object In sender2
                                item.enabled = False
                            Next
                            eras = Not (eras)
                            Exit Do
                        End If
                        If ConnStr2.Fields("A").Value.ToString = sender.text Then
                            Dim joined As String = ConnStr2.Fields("Q").Value.ToString
                            ConnStr2.Delete()
                            sender2.Remove(sender)
                            sender.backcolor = SystemColors.ControlLight
                            If B12.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B12.Location.X, B12.Location.Y + 23, sender.location.x + B12.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B12)
                                B12.BackColor = SystemColors.ControlLight
                            ElseIf B13.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B13.Location.X, B13.Location.Y + 23, sender.location.x + B13.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B13)
                                B13.BackColor = SystemColors.ControlLight
                            ElseIf B14.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B14.Location.X, B14.Location.Y + 23, sender.location.x + B14.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B14)
                                B14.BackColor = SystemColors.ControlLight
                            ElseIf B15.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B15.Location.X, B15.Location.Y + 23, sender.location.x + B15.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B15)
                                B15.BackColor = SystemColors.ControlLight
                            ElseIf B16.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B16.Location.X, B16.Location.Y + 23, sender.location.x + B16.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B16)
                                B16.BackColor = SystemColors.ControlLight
                            ElseIf B17.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B17.Location.X, B17.Location.Y + 23, sender.location.x + B17.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B17)
                                B17.BackColor = SystemColors.ControlLight
                            ElseIf B18.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B18.Location.X, B18.Location.Y + 23, sender.location.x + B18.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B18)
                                B18.BackColor = SystemColors.ControlLight
                            ElseIf B19.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B19.Location.X, B19.Location.Y + 23, sender.location.x + B19.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B19)
                                B19.BackColor = SystemColors.ControlLight
                            ElseIf B20.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B20.Location.X, B20.Location.Y + 23, sender.location.x + B20.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B20)
                                B20.BackColor = SystemColors.ControlLight
                            ElseIf B21.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B21.Location.X, B21.Location.Y + 23, sender.location.x + B21.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B21)
                                B21.BackColor = SystemColors.ControlLight
                            ElseIf B22.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B22.Location.X, B22.Location.Y + 23, sender.location.x + B22.Width, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B22)
                                B22.BackColor = SystemColors.ControlLight
                            End If
                            B1.Enabled = True
                            B2.Enabled = True
                            B3.Enabled = True
                            B4.Enabled = True
                            B5.Enabled = True
                            B6.Enabled = True
                            B7.Enabled = True
                            B8.Enabled = True
                            B9.Enabled = True
                            B10.Enabled = True
                            B11.Enabled = True
                            B12.Enabled = True
                            B13.Enabled = True
                            B14.Enabled = True
                            B15.Enabled = True
                            B16.Enabled = True
                            B17.Enabled = True
                            B18.Enabled = True
                            B19.Enabled = True
                            B20.Enabled = True
                            B21.Enabled = True
                            B22.Enabled = True
                            For Each item As Object In sender2
                                item.enabled = False
                            Next
                            eras = Not (eras)
                            Exit Do
                        End If
                        ConnStr2.MoveNext()
                    Loop
                End If
            Case Is = "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22"
                If Not (eras) Then
                    RN = sender.text
                    If LRX = 0 And LRY = 0 And LLX = 0 And LLY = 0 Then
                        LRX = sender.location.x
                        LRY = sender.location.y
                        B12.Enabled = False
                        B13.Enabled = False
                        B14.Enabled = False
                        B15.Enabled = False
                        B16.Enabled = False
                        B17.Enabled = False
                        B18.Enabled = False
                        B19.Enabled = False
                        B20.Enabled = False
                        B21.Enabled = False
                        B22.Enabled = False
                        sender.backcolor = Color.Yellow
                        sender2.Add(sender)
                    ElseIf Not (IsNothing(LLX = 0)) And Not (IsNothing(LLY = 0)) Then
                        LRX = sender.location.x
                        LRY = sender.location.y
                        Lin = Graphics.FromImage(Gsaver)
                        Lin.DrawLine(Pens.Black, LLX, LLY + 23, LRX, LRY + 23)
                        Me.Invalidate()
                        RorF(B)
                        If B Then
                            FMark.Value += QMark.Value
                        End If
                        LRX = 0
                        LRY = 0
                        LLX = 0
                        LLY = 0
                        B1.Enabled = True
                        B2.Enabled = True
                        B3.Enabled = True
                        B4.Enabled = True
                        B5.Enabled = True
                        B6.Enabled = True
                        B7.Enabled = True
                        B8.Enabled = True
                        B9.Enabled = True
                        B10.Enabled = True
                        B11.Enabled = True
                        sender.enabled = False
                        sender2.Add(sender)
                        For Each item As Object In sender2
                            item.backcolor = Color.Gold
                            item.enabled = False
                        Next
                    End If
                Else
                    ConnStr2.MoveFirst()
                    Do Until ConnStr2.EOF
                        If ConnStr2.Fields("Q").Value.ToString = sender.text Then
                            Dim joined As String = ConnStr2.Fields("A").Value.ToString
                            ConnStr2.Delete()
                            sender2.Remove(sender)
                            sender.backcolor = SystemColors.ControlLight
                            If B1.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B1.Location.X, B1.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B1)
                                B1.BackColor = SystemColors.ControlLight
                            ElseIf B2.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B2.Location.X, B2.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B2.BackColor = SystemColors.ControlLight
                                sender2.Remove(B2)
                            ElseIf B3.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B3.Location.X, B3.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B3.BackColor = SystemColors.ControlLight
                                sender2.Remove(B3)
                            ElseIf B4.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B4.Location.X, B4.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B4.BackColor = SystemColors.ControlLight
                                sender2.Remove(B4)
                            ElseIf B5.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B5.Location.X, B5.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B5.BackColor = SystemColors.ControlLight
                                sender2.Remove(B5)
                            ElseIf B6.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B6.Location.X, B6.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B6.BackColor = SystemColors.ControlLight
                                sender2.Remove(B6)
                            ElseIf B7.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B7.Location.X, B7.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B7.BackColor = SystemColors.ControlLight
                                sender2.Remove(B7)
                            ElseIf B8.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B8.Location.X, B8.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B8.BackColor = SystemColors.ControlLight
                                sender2.Remove(B8)
                            ElseIf B9.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B9.Location.X, B9.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B9.BackColor = SystemColors.ControlLight
                                sender2.Remove(B9)
                            ElseIf B10.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B10.Location.X, B10.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B10.BackColor = SystemColors.ControlLight
                                sender2.Remove(B10)
                            ElseIf B11.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B11.Location.X, B11.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B11.BackColor = SystemColors.ControlLight
                                sender2.Remove(B11)
                            End If
                            B1.Enabled = True
                            B2.Enabled = True
                            B3.Enabled = True
                            B4.Enabled = True
                            B5.Enabled = True
                            B6.Enabled = True
                            B7.Enabled = True
                            B8.Enabled = True
                            B9.Enabled = True
                            B10.Enabled = True
                            B11.Enabled = True
                            B12.Enabled = True
                            B13.Enabled = True
                            B14.Enabled = True
                            B15.Enabled = True
                            B16.Enabled = True
                            B17.Enabled = True
                            B18.Enabled = True
                            B19.Enabled = True
                            B20.Enabled = True
                            B21.Enabled = True
                            B22.Enabled = True
                            For Each item As Object In sender2
                                item.enabled = False
                            Next
                            eras = Not (eras)
                            Exit Do
                        End If
                        If ConnStr2.Fields("A").Value.ToString = sender.text Then
                            Dim joined As String = ConnStr2.Fields("Q").Value.ToString
                            ConnStr2.Delete()
                            sender2.Remove(sender)
                            sender.backcolor = SystemColors.ControlLight
                            If B1.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B1.Location.X + B1.Width, B1.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                sender2.Remove(B1)
                                B1.BackColor = SystemColors.ControlLight
                            ElseIf B2.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B2.Location.X + B2.Width, B2.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B2.BackColor = SystemColors.ControlLight
                                sender2.Remove(B2)
                            ElseIf B3.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B3.Location.X + B3.Width, B3.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B3.BackColor = SystemColors.ControlLight
                                sender2.Remove(B3)
                            ElseIf B4.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B4.Location.X + B4.Width, B4.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B4.BackColor = SystemColors.ControlLight
                                sender2.Remove(B4)
                            ElseIf B5.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B5.Location.X + B5.Width, B5.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B5.BackColor = SystemColors.ControlLight
                                sender2.Remove(B5)
                            ElseIf B6.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B6.Location.X + B6.Width, B6.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B6.BackColor = SystemColors.ControlLight
                                sender2.Remove(B6)
                            ElseIf B7.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B7.Location.X + B7.Width, B7.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B7.BackColor = SystemColors.ControlLight
                                sender2.Remove(B7)
                            ElseIf B8.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B8.Location.X + B8.Width, B8.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B8.BackColor = SystemColors.ControlLight
                                sender2.Remove(B8)
                            ElseIf B9.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B9.Location.X + B9.Width, B9.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B9.BackColor = SystemColors.ControlLight
                                sender2.Remove(B9)
                            ElseIf B10.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B10.Location.X + B10.Width, B10.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B10.BackColor = SystemColors.ControlLight
                                sender2.Remove(B10)
                            ElseIf B11.Text = joined Then
                                Lin = Graphics.FromImage(Gsaver)
                                Lin.DrawLine(Pens.White, B11.Location.X + B11.Width, B11.Location.Y + 23, sender.location.x, sender.location.y + 23)
                                Me.Invalidate()
                                B11.BackColor = SystemColors.ControlLight
                                sender2.Remove(B11)
                            End If
                            B1.Enabled = True
                            B2.Enabled = True
                            B3.Enabled = True
                            B4.Enabled = True
                            B5.Enabled = True
                            B6.Enabled = True
                            B7.Enabled = True
                            B8.Enabled = True
                            B9.Enabled = True
                            B10.Enabled = True
                            B11.Enabled = True
                            B12.Enabled = True
                            B13.Enabled = True
                            B14.Enabled = True
                            B15.Enabled = True
                            B16.Enabled = True
                            B17.Enabled = True
                            B18.Enabled = True
                            B19.Enabled = True
                            B20.Enabled = True
                            B21.Enabled = True
                            B22.Enabled = True
                            For Each item As Object In sender2
                                item.enabled = False
                            Next
                            eras = Not (eras)
                            Exit Do
                        End If
                        ConnStr2.MoveNext()
                    Loop
                End If
        End Select
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If QMSettings.Previous.Checked Then
            sender.enabled = False
            Exit Sub
        End If
        If Databasesselecter.CompleteC.Checked Then
            CompleteQ.Show()
            Hide()
        ElseIf Databasesselecter.SelectC.Checked Then
            SelectQ.Show()
            Hide()
        Else
            sender.enabled = False
        End If
    End Sub

    Private Sub JoinQ_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
#If Not DEBUG Then
        If Visible Then Me.Bounds = Screen.PrimaryScreen.Bounds
#End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LRX = 0 And LRY = 0 And LLX = 0 And LLY = 0 Then
            If Not (eras) Then
                B1.Enabled = False
                B2.Enabled = False
                B3.Enabled = False
                B4.Enabled = False
                B5.Enabled = False
                B6.Enabled = False
                B7.Enabled = False
                B8.Enabled = False
                B9.Enabled = False
                B10.Enabled = False
                B11.Enabled = False
                B12.Enabled = False
                B13.Enabled = False
                B14.Enabled = False
                B15.Enabled = False
                B16.Enabled = False
                B17.Enabled = False
                B18.Enabled = False
                B19.Enabled = False
                B20.Enabled = False
                B21.Enabled = False
                B22.Enabled = False
                For Each item As Object In sender2
                    item.enabled = True
                Next
            Else
                B1.Enabled = True
                B2.Enabled = True
                B3.Enabled = True
                B4.Enabled = True
                B5.Enabled = True
                B6.Enabled = True
                B7.Enabled = True
                B8.Enabled = True
                B9.Enabled = True
                B10.Enabled = True
                B11.Enabled = True
                B12.Enabled = True
                B13.Enabled = True
                B14.Enabled = True
                B15.Enabled = True
                B16.Enabled = True
                B17.Enabled = True
                B18.Enabled = True
                B19.Enabled = True
                B20.Enabled = True
                B21.Enabled = True
                B22.Enabled = True
                For Each item As Object In sender2
                    item.enabled = False
                Next
            End If
            eras = Not (eras)
        ElseIf Not (IsNothing(LLX = 0)) And Not (IsNothing(LLY = 0)) Then
            LRX = 0
            LRY = 0
            LLX = 0
            LLY = 0
            sender2(sender2.Count - 1).backcolor = SystemColors.ControlLight
            sender2.RemoveAt(sender2.Count - 1)
            B1.Enabled = True
            B2.Enabled = True
            B3.Enabled = True
            B4.Enabled = True
            B5.Enabled = True
            B6.Enabled = True
            B7.Enabled = True
            B8.Enabled = True
            B9.Enabled = True
            B10.Enabled = True
            B11.Enabled = True
            B12.Enabled = True
            B13.Enabled = True
            B14.Enabled = True
            B15.Enabled = True
            B16.Enabled = True
            B17.Enabled = True
            B18.Enabled = True
            B19.Enabled = True
            B20.Enabled = True
            B21.Enabled = True
            B22.Enabled = True
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
        Result.Show()
    End Sub
End Class