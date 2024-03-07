Public Class WhoQuizzed
    Private Sub WhoQuizzed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Paths.Instance.Savings2PC.Checked AndAlso Paths.Instance.Conn2.State = 0 Then
                Paths.Instance.Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & Paths.Instance.TextBox5.Text & ";Jet OLEDB:Database Password = " & Paths.Instance.Savings2P.Text)
            ElseIf Paths.Instance.Conn2.State = 0 Then
                Paths.Instance.Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & Paths.Instance.TextBox5.Text)
            End If
            If Paths.Instance.ConnStr2.State = 0 Then
                Paths.Instance.ConnStr2.Open(Paths.Instance.Savings2T.Text, Paths.Instance.Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            End If
            While Not Paths.Instance.ConnStr2.EOF
                Dim Person As New List(Of String)

                Person.Add(Paths.Instance.ConnStr2.Fields("Nam").Value)
                Person.Add(Paths.Instance.ConnStr2.Fields("Value1").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Value2").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Value3").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Value4").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Timer").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Total").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Final").Value.ToString())
                Person.Add(Paths.Instance.ConnStr2.Fields("Percent").Value.ToString() + "%")
                Person.Add(Paths.Instance.ConnStr2.Fields("Valuation").Value.ToString())
                Person.Add(If(Paths.Instance.ConnStr2.Fields("Success").Value, "نجح", "لم ينجح"))
                Person.Add(Paths.Instance.ConnStr2.Fields("PathToDB").Value.ToString())

                List.Items.Add(New ListViewItem(Person.ToArray()))

                Paths.Instance.ConnStr2.MoveNext()
            End While
        Catch
            MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2).", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
        End Try
        Paths.Instance.ConnStr2.Close()
        Paths.Instance.Conn2.Close()
    End Sub

    Private Sub List_ItemActivate(sender As Object, e As EventArgs) Handles List.ItemActivate
        Debugger.Break()
    End Sub
End Class