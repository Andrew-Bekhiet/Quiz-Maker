Public Class CompleteModernA
    Public Q As String = ""
    Dim _A As String = ""
    Public Property A As String
        Get
            Return _A
        End Get
        Set(value As String)
            _A = value
            ShowCurrentQ()
        End Set
    End Property

    'Public Property AA As String
    '    Get
    '        Return _AA
    '    End Get
    '    Set(value As String)
    '        _AA = value
    '    End Set
    'End Property

    Private Sub CompleteModernA_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            ShowCurrentQ()
        End If
    End Sub
    Sub ShowCurrentQ()
        If Q.Contains("|") Then
            Dim qu As String() = Q.Split("|")
            Dim index As Integer = 0
            For Each Text As String In qu
                Table1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / (qu.Count + If(A.Contains(","), A.Split(",").Count, 1))))
                Dim La As New Label
                If Q.Contains(",") Then
                    Dim Q2() As String = Q.Split(",")
                    La.Text = Text
                    Try
                        La.Font = New Font(Q2(1), CDec(Q2(2)), FontStyle.Bold)
                    Catch ex As IndexOutOfRangeException
                    End Try
                Else
                    La.Text = Text
                End If
                Table1.Controls.Add(La, index, 0)
                Dim txt As New TextBox
                txt.Font = La.Font
                'txt.Text = AA
                If A.Contains(",") Then
                    If A.Split(",").Count < qu.Count Then
                        If index <= A.Split(",").Count Then
                            Table1.Controls.Add(txt, index, 0)
                        End If
                    Else
                        Table1.Controls.Add(txt, index, 0)
                    End If
                Else
                    Table1.Controls.Add(txt, index, 0)
                End If
                index += 1
            Next
        End If
    End Sub
End Class
