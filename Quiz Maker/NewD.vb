Imports System.IO
Public Class NewD
    Private Connection As New ADODB.Connection
    Private Fields As New ADODB.Recordset
    Dim SelectL, CompleteL, JoinL, ArrangeL, SavingsL, QL As String
    Dim X As Integer = 0

    Private Sub NewD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If Not DEBUG Then
        Button1.Enabled = False
#End If
        If Main.Button2.Image Is My.Resources.Resources.eror2 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = Not (False)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Paths.Instance.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WhoQuizzed.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EDesgin.Show()
        Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        QMSettings.Show()
        Close()
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If OImport.ShowDialog() = DialogResult.OK Then
            Import_Quiz(OImport.FileName)
        End If
    End Sub

    Public Shared Sub Import_Quiz(FileName As String)
        If FileName <> My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QM", "LastF", "") Then
            Dim L As String = FileName
            CloseC()
            If IO.File.Exists("Savings.mdb") Then My.Computer.FileSystem.DeleteFile("Savings.mdb")
            If IO.File.Exists("b.pqf") Then My.Computer.FileSystem.DeleteFile("b.pqf")
            If IO.File.Exists("b.rar") Then My.Computer.FileSystem.DeleteFile("b.rar")
            If IO.Directory.Exists("Resources") Then My.Computer.FileSystem.DeleteDirectory("Resources", FileIO.DeleteDirectoryOption.DeleteAllContents)
            IO.File.Copy(L, "b.rar")
            Process.Start("Rar.exe", "x b.rar").WaitForExit()
            Dim Cre() As String = File.ReadAllLines("Resources\Options.txt")
            If Not (Cre(0) = "QMO Start:") Then
                MsgBox("الملف الذي حددته تالف أو ليس من النوع المراد.", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading OrElse MsgBoxStyle.Exclamation OrElse MsgBoxStyle.OkOnly)
                Exit Sub
            Else
                If Cre(1).Contains("Password") Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "Password", Cre(1).Split(":")(1))
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "TableN", Cre(2).Split(":")(1))
                Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "Password", "")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "TableN", Cre(1).Split(":")(1))
                End If
            End If
            File.Move("Resources\Savings.mdb", "Savings.mdb")
            My.Computer.FileSystem.DeleteFile("b.rar")
            My.Computer.FileSystem.DeleteFile("Resources\Options.txt")
            Process.Start("""" + My.Application.Info.DirectoryPath + "\Quiz Maker.exe""")
            My.Computer.Registry.CurrentUser.CreateSubKey("QM").SetValue("LastF", L, Microsoft.Win32.RegistryValueKind.String)
            End
        End If
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Paths.Instance.SelectC.Checked Then
            SelectL = "\" & Path.GetFileName(Paths.Instance.TextBox1.Text)
        End If
        If Paths.Instance.CompleteC.Checked Then
            CompleteL = "\" & Path.GetFileName(Paths.Instance.TextBox2.Text)
        End If
        If Paths.Instance.JoinC.Checked Then
            JoinL = "\" & Path.GetFileName(Paths.Instance.TextBox3.Text)
        End If
        If Paths.Instance.ArrangeC.Checked Then
            ArrangeL = "\" & Path.GetFileName(Paths.Instance.Arrange.Text)
        End If
        If Paths.Instance.Savings2C.Checked Then
            SavingsL = "\" & Path.GetFileName(Paths.Instance.TextBox5.Text)
        End If
        If IO.Directory.Exists(Directory & "\Resources") Then My.Computer.FileSystem.DeleteDirectory(Directory & "\Resources", FileIO.DeleteDirectoryOption.DeleteAllContents)
        If IO.File.Exists("a.pqf") Then My.Computer.FileSystem.DeleteFile("a.pqf")
        If IO.File.Exists("a.rar") Then My.Computer.FileSystem.DeleteFile("a.rar")
        IO.Directory.CreateDirectory(Directory & "\Resources")
        My.Computer.FileSystem.CopyFile(Paths.Instance.TextBox4.Text, "Resources\Savings.mdb")
        Debug.WriteLine(Paths.Instance.TextBox1.Text)
        If Paths.Instance.SelectC.Checked Then _
        My.Computer.FileSystem.CopyFile(Paths.Instance.TextBox1.Text, "Resources" & SelectL, True)
        If Paths.Instance.CompleteC.Checked Then _
        My.Computer.FileSystem.CopyFile(Paths.Instance.TextBox2.Text, "Resources" & CompleteL, True)
        If Paths.Instance.JoinC.Checked Then _
        My.Computer.FileSystem.CopyFile(Paths.Instance.TextBox3.Text, "Resources" & JoinL, True)
        If Paths.Instance.ArrangeC.Checked Then _
        My.Computer.FileSystem.CopyFile(Paths.Instance.Arrange.Text, "Resources" & ArrangeL, True)
        If Paths.Instance.Savings2C.Checked Then _
        My.Computer.FileSystem.CopyFile(Paths.Instance.TextBox5.Text, "Resources" & SavingsL, True)
        Connection.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & "Resources\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.SavingsP.Text, Paths.Instance.SavingsPC.Checked))
        Fields.Open(Paths.Instance.SavingsT.Text, Connection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Fields.MoveFirst()
        Do Until Fields.EOF
            If Fields.Fields("ID").Value = "Save" AndAlso Paths.Instance.Savings2C.Checked Then
                Fields.Fields("Valu").Value = "Resources\Savings2.mdb"
            ElseIf Fields.Fields("ID").Value = "Save" Then
                Fields.Fields("Valu").Value = "False"
            End If
            If Fields.Fields("ID").Value = "ASS" Then
                Fields.Fields("Valu").Value = "."
            End If
            If Fields.Fields("ID").Value = "Select" AndAlso Paths.Instance.SelectC.Checked Then
                Fields.Fields("Valu").Value = "Resources" & SelectL
            ElseIf Fields.Fields("ID").Value = "Select" Then
                Fields.Fields("Valu").Value = "False"
            End If
            If Fields.Fields("ID").Value = "Complete" AndAlso Paths.Instance.CompleteC.Checked Then
                Fields.Fields("Valu").Value = "Resources" & CompleteL
            ElseIf Fields.Fields("ID").Value = "Complete" Then
                Fields.Fields("Valu").Value = "False"
            End If
            If Fields.Fields("ID").Value = "Join" AndAlso Paths.Instance.JoinC.Checked Then
                Fields.Fields("Valu").Value = "Resources" & JoinL
            ElseIf Fields.Fields("ID").Value = "Join" Then
                Fields.Fields("Valu").Value = "False"
            End If
            If Fields.Fields("ID").Value = "Arrange" AndAlso Paths.Instance.ArrangeC.Checked Then
                Fields.Fields("Valu").Value = "Resources" & ArrangeL
            ElseIf Fields.Fields("ID").Value = "Arrange" Then
                Fields.Fields("Valu").Value = "False"
            End If
            Fields.Update()
            Fields.MoveNext()
        Loop
        Fields.Close()
        Connection.Close()
        IO.Directory.CreateDirectory("Resources\Images")
        If Paths.Instance.SelectC.Checked Then
            Connection.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = Resources" & SelectL & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.SelectP.Text, Paths.Instance.SelectPC.Checked))
            Fields.Open(Paths.Instance.SelectT.Text, Connection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Fields.MoveFirst()
            Do Until Fields.EOF
                If Fields.Fields("Question").Value.ToString.Contains(",") Then
                    Dim Q() As String = Fields.Fields("Question").Value.ToString.Split(",")
                    Try
                        Debug.WriteLine(Q(3).ToString)
                        X = Q(3).ToString.Length
                        Do While X <> 0
                            Debug.WriteLine(Q(3).ToString.ElementAt(X - 1))
                            If Q(3).ToString.ElementAt(X - 1) = "\" Then
                                QL = Mid(Q(3).ToString, X)
                                Exit Do
                            Else
                                X -= 1
                            End If
                        Loop
                        IO.File.Copy(Fields.Fields("Question").Value.ToString.Split(",")(3), "Resources\Images" & QL)
                        Fields.Fields("Question").Value = Q(0) & "," & Q(1) & "," & Q(2) & "," & "Resources\Images" & QL
                        Fields.Update()
                    Catch ex As Exception
                        Debug.WriteLine(ex.Message)
                        Debug.WriteLine(ex.StackTrace)
                    End Try
                End If
                Fields.MoveNext()
            Loop
            Fields.Close()
            Connection.Close()
        End If
        If Paths.Instance.CompleteC.Checked Then
            Connection.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source = Resources" & CompleteL & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & Paths.Instance.CompleteP.Text, Paths.Instance.CompletePC.Checked))
            Fields.Open(Paths.Instance.CompleteT.Text, Connection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Fields.MoveFirst()
            Do Until Fields.EOF
                If Fields.Fields("Question").Value.ToString.Contains(",") Then
                    Dim Q() As String = Fields.Fields("Question").Value.ToString.Split(",")
                    Try
                        Debug.WriteLine(Q(3).ToString)
                        X = Q(3).ToString.Length
                        Do While X <> 0
                            Debug.WriteLine(Q(3).ToString.ElementAt(X - 1))
                            If Q(3).ToString.ElementAt(X - 1) = "\" Then
                                QL = Mid(Q(3).ToString, X)
                                Exit Do
                            Else
                                X -= 1
                            End If
                        Loop
                        IO.File.Copy(Fields.Fields("Question").Value.ToString.Split(",")(3), "Resources\Images" & QL)
                        Fields.Fields("Question").Value = Q(0) & "," & Q(1) & "," & Q(2) & "," & "Resources\Images" & QL
                        Fields.Update()
                    Catch ex As Exception
                        Debug.WriteLine(ex.Message)
                        Debug.WriteLine(ex.StackTrace)
                    End Try
                End If
                Fields.MoveNext()
            Loop
            Fields.Close()
            Connection.Close()
        End If
        Dim R As New Random
        Dim I As Integer = R.Next(-50, 50)
        Dim T As String
        If Paths.Instance.SavingsPC.Checked Then
            T = "QMO Start:" & vbCrLf & "Password:" _
                & Encrypting.EncryptData(Paths.Instance.SavingsP.Text) & vbCrLf _
                & "TableN:" & Encrypting.EncryptData(Paths.Instance.SavingsT.Text)
        Else
            T = "QMO Start:" & vbCrLf & "TableN:" _
                & Encrypting.EncryptData(Paths.Instance.SavingsT.Text)
        End If
        IO.File.WriteAllText("Resources\Options.txt", T)
        Process.Start("Rar", "a a.rar " & "Resources").WaitForExit()
        My.Computer.FileSystem.RenameFile("a.rar", "a.pqf")
        If SExport.ShowDialog = DialogResult.OK Then
            If File.Exists(SExport.FileName) Then My.Computer.FileSystem.DeleteFile(SExport.FileName)
            File.Copy("a.pqf", SExport.FileName)
        ElseIf IO.File.Exists("a.pqf") Then
            My.Computer.FileSystem.DeleteFile("a.pqf")
        End If
    End Sub
End Class