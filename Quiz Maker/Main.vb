Imports System.IO
Public Class Main
#Region "Buttons Click"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not (Paths.Instance.Visible = True) Then
            CloseC()
            Me.Close()
        Else
            If MsgBox("الخروج بهذا الشكل يؤدي إلى فقدان البيانات." & vbCrLf & "هل تريد المتابعة؟", MsgBoxStyle.Exclamation OrElse MsgBoxStyle.YesNo OrElse MsgBoxStyle.MsgBoxRight, "خروج غير آمن") = 6 Then
                CloseC()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Nam.Show()
        Hide()
    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Debug.WriteLine(QMSettings.QuizD.SelectedIndex)
        If (System.IO.File.Exists("C:\Windows\Temp\Savings.mdb") OrElse IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb")) AndAlso QMSettings.QuizD.SelectedIndex = 1 Then
            If Password.ShowDialog() = DialogResult.Yes Then
                NewD.Show()
            End If
        Else
            NewD.Show()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (System.IO.File.Exists("C:\Windows\Temp\Savings.mdb") OrElse IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb")) AndAlso QMSettings.Feed.SelectedIndex = 1 Then
            If Password.ShowDialog() = DialogResult.Yes Then
                Feedback.Show()
            End If
        Else
            Feedback.Show()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If QMSettings.Update.SelectedIndex = 1 Then
            If Password.ShowDialog() = DialogResult.Yes Then
                sender.enabled = False
                CheckUpdates.RunWorkerAsync()
            End If
        Else
            sender.enabled = False
            CheckUpdates.RunWorkerAsync()
        End If
    End Sub
#End Region
    Private Sub CheckUpdates_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CheckUpdates.DoWork
        Try
            Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create("https://pastebin.com/raw/8Ew16ZaF"), Net.HttpWebRequest)
            Dim response As System.Net.HttpWebResponse = DirectCast(request.GetResponse(), Net.HttpWebResponse)
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As Version = New Version(sr.ReadLine())
            Dim currentversion As Version = My.Application.Info.Version
            If newestversion = currentversion Then
                MsgBox("مبروك!لديك أخر إصدار!", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading OrElse MsgBoxStyle.Information)
                Exit Sub
            ElseIf newestversion > currentversion Then
                If MsgBox("يوجد إصدار جديد!" & vbCrLf & "هل تريد تنزيله؟" & vbCrLf & "الحالي: " & currentversion.ToString() & vbCrLf & "الجديد: " & newestversion.ToString() & vbCrLf, MsgBoxStyle.MsgBoxRtlReading OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If IO.File.Exists(My.Application.Info.DirectoryPath & "\Setup.rar") Then
                        My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\Setup.rar")
                    End If
                    request = DirectCast(System.Net.HttpWebRequest.Create(sr.ReadLine()), Net.HttpWebRequest)
                    response = DirectCast(request.GetResponse(), Net.HttpWebResponse)
                    My.Computer.Network.DownloadFile(response.ResponseUri, My.Application.Info.DirectoryPath & "\Setup.rar")
                    MsgBox("تم تنزيل التحديث بنجاح!", MsgBoxStyle.Information OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
                    Dim tempt As String = "x """ & (My.Application.Info.DirectoryPath & "\Setup.rar""") & " """ & (My.Application.Info.DirectoryPath) & """"
                    If IO.File.Exists("UnRAR.exe") Then
                        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Setup") Then FileIO.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\Setup", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Process.Start("UnRAR.exe", tempt).WaitForExit()
                        Process.Start(Directory & "\Setup\setup.exe")
                        End
                    Else
                        If MsgBox("يجب تنزيل برنامج WinRAR لإكمال التنصيب." & vbCrLf & "هل تريد تنزيله؟", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading OrElse MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Process.Start("https://www.win-rar.com/download.html")
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End If
        Catch ex As System.Net.WebException
            MsgBox("حدث خطأ أثناء المحاولة." & vbCrLf & "يرجى التحقق من الإتصال بالإنترنت.", MsgBoxStyle.Exclamation OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
            sender.Enabled = True
            Exit Sub
        End Try
    End Sub
#Region "Main Events"
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Paths.Instance.ConnStr.State = 1 Then
            CloseC()
        End If
    End Sub
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        With Paths.Instance
            If ((((.TextBox1.Enabled = True AndAlso .TextBox1.Text <> "" AndAlso .SelectT.Text <> "" AndAlso ((.SelectP.Text <> "" AndAlso .SelectP.Enabled = True) OrElse .SelectPC.Checked = False)) OrElse .TextBox1.Enabled = False)) _
            AndAlso (((.TextBox2.Enabled = True AndAlso .TextBox2.Text <> "" AndAlso .CompleteT.Text <> "" AndAlso ((.CompleteP.Text <> "" AndAlso .CompleteP.Enabled = True) OrElse .CompletePC.Checked = False)) OrElse .TextBox2.Enabled = False)) _
            AndAlso (((.TextBox3.Enabled = True AndAlso .TextBox3.Text <> "" AndAlso .JoinT.Text <> "" AndAlso ((.JoinP.Text <> "" AndAlso .JoinP.Enabled = True) OrElse .JoinPC.Checked = False)) OrElse .TextBox3.Enabled = False))) _
            AndAlso (((.TextBox5.Enabled = True AndAlso .TextBox5.Text <> "" AndAlso .Savings2T.Text <> "" AndAlso ((.Savings2P.Text <> "" AndAlso .Savings2P.Enabled = True) OrElse .Savings2PC.Checked = False)) OrElse .TextBox5.Enabled = False)) _
            AndAlso (((QMSettings.ASST.Enabled = True AndAlso QMSettings.ASST.Text <> "") OrElse QMSettings.ASSC.Checked = False)) _
            AndAlso (QMSettings.TextBox6.Text <> "") _
            AndAlso (QMSettings.QuizD.SelectedIndex <> -1 AndAlso QMSettings.Update.SelectedIndex <> -1 AndAlso QMSettings.Feed.SelectedIndex <> -1) Then
                Button2.Image = My.Resources.images22
                Button1.Enabled = True
                Button2.Text = "تعديل الإختبار"
            ElseIf ((((.TextBox1.Enabled = True AndAlso .TextBox1.Text <> "" AndAlso .SelectT.Text <> "" AndAlso ((.SelectP.Text <> "" AndAlso .SelectP.Enabled = True) OrElse .SelectPC.Checked = False)) OrElse .TextBox1.Enabled = False)) _
            AndAlso (((.TextBox2.Enabled = True AndAlso .TextBox2.Text <> "" AndAlso .CompleteT.Text <> "" AndAlso ((.CompleteP.Text <> "" AndAlso .CompleteP.Enabled = True) OrElse .CompletePC.Checked = False)) OrElse .TextBox2.Enabled = False)) _
            AndAlso (((.TextBox3.Enabled = True AndAlso .TextBox3.Text <> "" AndAlso .JoinT.Text <> "" AndAlso ((.JoinP.Text <> "" AndAlso .JoinP.Enabled = True) OrElse .JoinPC.Checked = False)) OrElse .TextBox3.Enabled = False))) _
            OrElse (((.TextBox5.Enabled = True AndAlso .TextBox5.Text <> "" AndAlso .Savings2T.Text <> "" AndAlso ((.Savings2P.Text <> "" AndAlso .Savings2P.Enabled = True) OrElse .Savings2PC.Checked = False)) OrElse .TextBox5.Enabled = False)) _
            OrElse (((QMSettings.ASST.Enabled = True AndAlso QMSettings.ASST.Text <> "") OrElse QMSettings.ASSC.Checked = False)) _
            OrElse (QMSettings.TextBox6.Text <> "") _
            OrElse (QMSettings.QuizD.SelectedIndex <> -1 AndAlso QMSettings.Update.SelectedIndex <> -1 AndAlso QMSettings.Feed.SelectedIndex <> -1) Then
                Button2.Image = My.Resources.eror2
                Button1.Enabled = False
                If IO.File.Exists("C:\Windows\Temp\Savings.mdb") OrElse IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb") Then
                    Button2.Text = "تعديل الإختبار"
                Else
                    Button2.Text = "تصميم إختبار"
                End If
            End If
        End With
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        If QMSettings.QuizD.SelectedIndex = 2 Then
            Table.RowStyles.RemoveAt(1)
            Button2.Hide()
            If QMSettings.Feed.SelectedIndex = 2 Then
                Table.RowStyles.RemoveAt(1)
                Button5.Hide()
                If QMSettings.Update.SelectedIndex = 2 Then
                    Table.RowStyles.RemoveAt(1)
                    Button6.Hide()
                    Table.SetRow(Button3, 1)
                    Table.SetRow(Button4, 2)
                Else
                    Table.SetRow(Button6, 1)
                    Table.SetRow(Button3, 2)
                    Table.SetRow(Button4, 3)
                End If
            Else
                Table.SetRow(Button5, 1)
                Table.SetRow(Button6, 2)
                Table.SetRow(Button3, 3)
                Table.SetRow(Button4, 4)
            End If
        ElseIf QMSettings.Feed.SelectedIndex = 2 Then
            Table.RowStyles.RemoveAt(2)
            Button5.Hide()
            If QMSettings.Update.SelectedIndex = 2 Then
                Table.RowStyles.RemoveAt(2)
                Button6.Hide()
                Table.SetRow(Button3, 2)
                Table.SetRow(Button4, 3)
            Else
                Table.SetRow(Button6, 2)
                Table.SetRow(Button3, 3)
                Table.SetRow(Button4, 4)
            End If
        ElseIf QMSettings.Update.SelectedIndex = 2 Then
            Table.RowStyles.RemoveAt(3)
            Button6.Hide()
            Table.SetRow(Button3, 3)
            Table.SetRow(Button4, 4)
        End If
        Table.Refresh()
        Table.Update()
        If IO.File.Exists("C:\Windows\Temp\Savings.mdb") OrElse IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb") Then
            Button1.Enabled = True
        End If
        If Not (My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\.QME", "QME", Nothing) Is Nothing) Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("HKEY_CLASSES_ROOT\.QME").SetValue("", "QME", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.ClassesRoot.CreateSubKey("HKEY_CLASSES_ROOT\QME\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)
        End If
        ''EDesgin.Show()()
    End Sub
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ActiveF = Nothing
        Directory = Nothing
        ontime = Nothing
        Hou = Nothing
        Min = Nothing
        Sec = Nothing
        MainASSDB = Nothing
        DB = Nothing
        C = Nothing
        Timer = Nothing
        NP = Nothing
        P = Nothing
    End Sub
#End Region
End Class