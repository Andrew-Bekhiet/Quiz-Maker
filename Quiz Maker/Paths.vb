Imports System.IO
Public Class Paths
#Region "Variables"
    Friend Shared Instance As Paths

    Public ConnStr As New ADODB.Recordset()
    Public Conn As New ADODB.Connection()
    Public ConnStr2 As New ADODB.Recordset()
    Public Conn2 As New ADODB.Connection()

    Public MPassword As String = ""
    Public TableN As String = ""

    Dim FileName As String = ""
    Dim PENC As String

    Dim ConnStrI As Byte = 0
    Dim SelectI As Byte = 0
    Dim ArrangeI As Byte = 0
    Dim CompleteI As Byte = 0
    Dim JoinI As Byte = 0
    Dim SaveI As Byte = 0
    Dim TimerI As Byte = 0
    Dim ASSI As Byte = 0
    Dim counter As Byte = 0

    Public dev As Boolean = False
    Private c As Boolean = False
    Dim SS As Boolean = False
    Dim b As Boolean = True
    Dim aot As Boolean = False
#End Region
#Region "Make New Desgin Subs"
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If OpenS2.ShowDialog = DialogResult.OK Then
            TextBox5.Text = OpenS2.FileName
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OpenCh.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenCh.FileName
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If OpenCo.ShowDialog = DialogResult.OK Then
            TextBox2.Text = OpenCo.FileName
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If OpenJ.ShowDialog = DialogResult.OK Then
            TextBox3.Text = OpenJ.FileName
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If OpenS.ShowDialog = DialogResult.OK Then
            TextBox4.Text = OpenS.FileName
        End If
    End Sub
#End Region
    Private Sub Nam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nam2.TextChanged
        If Savings2C.Checked = True Then
            If Conn.State = 1 Then
addnew:         Debug.WriteLine("AddNew")
            Else
open:           Try
                    If Savings2PC.Checked Then
                        Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & TextBox5.Text & ";Jet OLEDB:Database Password = " & Savings2P.Text)
                    Else
                        Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & TextBox5.Text)
                    End If
                    ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    If ex.Message = "Operation is not allowed when the object is open." Then
                        Try
                            ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        Catch exe As Exception
                            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
                            Debug.WriteLine(ex.StackTrace)
                            Debug.WriteLine(ex.Message)
                        End Try
                        GoTo addnew
                    End If
                    MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2).", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
                    Nam.Eror = True
                End Try
            End If
        Else
            If (ConnStr2.State AndAlso 1) = 1 Then
                Debug.WriteLine("AddNew")
            Else
                My.Computer.FileSystem.WriteAllBytes(Directory & "\Savings2.mdb", My.Resources.Savings2, False)
                Try
                    If Savings2PC.Checked Then
                        Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & My.Application.Info.DirectoryPath & "\Savings2.mdb" & ";Jet OLEDB:Database Password = " & Savings2P.Text)
                        ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    Else
                        Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings2.mdb")
                        ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    End If
                Catch
                    MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2).", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
                    Nam.Eror = True
                End Try
            End If
        End If
    End Sub
#Region "Load + Close"
    Public Sub Paths_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If ((((TextBox1.Enabled = True AndAlso TextBox1.Text <> "" AndAlso SelectT.Text <> "" AndAlso ((SelectP.Text <> "" AndAlso SelectP.Enabled = True) OrElse SelectPC.Checked = False)) OrElse TextBox1.Enabled = False))) _
            AndAlso (((TextBox2.Enabled = True AndAlso TextBox2.Text <> "" AndAlso CompleteT.Text <> "" AndAlso ((CompleteP.Text <> "" AndAlso CompleteP.Enabled = True) OrElse CompletePC.Checked = False)) OrElse TextBox2.Enabled = False)) _
            AndAlso (((TextBox3.Enabled = True AndAlso TextBox3.Text <> "" AndAlso JoinT.Text <> "" AndAlso ((JoinP.Text <> "" AndAlso JoinP.Enabled = True) OrElse JoinPC.Checked = False)) OrElse TextBox3.Enabled = False)) _
            AndAlso (((TextBox5.Enabled = True AndAlso TextBox5.Text <> "" AndAlso Savings2T.Text <> "" AndAlso ((Savings2P.Text <> "" AndAlso Savings2P.Enabled = True) OrElse Savings2PC.Checked = False)) OrElse TextBox5.Enabled = False)) _
            AndAlso (((QMSettings.ASST.Enabled = True AndAlso QMSettings.ASST.Text <> "") OrElse QMSettings.ASSC.Checked = False)) _
            AndAlso (QMSettings.TextBox6.Text <> "") _
            AndAlso (QMSettings.QuizD.SelectedIndex <> -1 AndAlso QMSettings.Update.SelectedIndex <> -1 AndAlso QMSettings.Feed.SelectedIndex <> -1) Then
            If TextBox4.Text = "" Then
                If MsgBox("لقد تركت مكان حفظ البيانات فارغًا" & vbCrLf & "هل تريد من البرنامج وضع البيانات التي أدخلتها في قاعدة بيانات جديدة؟", MsgBoxStyle.YesNo OrElse MsgBoxStyle.Information OrElse MsgBoxStyle.MsgBoxRight) = MsgBoxResult.Yes Then
                    b = False
                Else
                    b = True
                End If
            End If
            If Conn2.State = 0 AndAlso Savings2C.Checked = True Then
                Try
                    Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & TextBox5.Text & SIF(";Jet OLEDB:Database Password = " & Savings2P.Text, SavingsPC.Checked))
                    ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Catch
                    MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2).", 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
                End Try
            ElseIf Conn2.State = 0 AndAlso Savings2C.Checked = False Then
                Try
                    If Savings2PC.Checked Then
                        Conn2.Open("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " & My.Application.Info.DirectoryPath & "\Savings2.mdb" & SIF(";Jet OLEDB:Database Password = " & Savings2P.Text, SavingsPC.Checked))
                        ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    Else
                        Conn2.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings2.mdb" & SIF(";Jet OLEDB:Database Password = " & Savings2P.Text, SavingsPC.Checked))
                        ConnStr2.Open(Savings2T.Text, Conn2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    End If
                Catch ex As System.Exception
                    MsgBox("حدث خطأ أثناء محاولة تحميل قاعدة البيانات أو كلمة سر خاطئة(Savings2)." & vbCrLf & ex.StackTrace, 0 OrElse 48 OrElse MsgBoxStyle.MsgBoxRight)
                End Try
            End If
            If Not (b) Then
                Dim cat As ADOX.Catalog = New ADOX.Catalog()
                Try
                    cat.Create("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked))
                Catch ex As System.Runtime.InteropServices.COMException
                    If MsgBox("يوجد قاعدة بيانات في نفس المجلد." & vbCrLf & "هل تريد المتابعة بحذف قاعدة البيانات القديمة ووضع الجديدة؟", MsgBoxStyle.Information OrElse MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If ConnStr.State = 1 Then
                            ConnStr.UpdateBatch()
                            ConnStr.Close()
                            Conn.Close()
                        End If
                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\Savings.mdb")
                        cat.Create("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked))
                    Else
                        sender.Hide()
                        If SS Then QMSettings.Hide()
                        If ConnStr.State = 1 Then
                            ConnStr.UpdateBatch()
                            ConnStr.Close()
                            Conn.Close()
                        End If
                        If ConnStr2.State = 1 Then
                            ConnStr2.UpdateBatch()
                            ConnStr2.Close()
                            Conn2.Close()
                        End If
                        Exit Sub
                    End If
                End Try

                Dim con As New OleDb.OleDbConnection With
                {
                    .ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked)
                }
                con.Open()
                Dim dbSchema As DataTable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, My.Application.Info.DirectoryPath & "\Savings.mdb", "TABLE"})
                con.Close()
                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & SavingsT.Text & "] ([ID] TEXT, [Valu] TEXT, [TableN] TEXT, [Password] TEXT)", con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                If MPassword <> "" Then MPassword = ""
                If TableN <> "" Then TableN = ""
                If Me.SavingsPC.Checked Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "Password", Encrypting.EncryptData(Me.SavingsP.Text))
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "TableN", Encrypting.EncryptData(Me.SavingsT.Text))
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked))
                ConnStr.Open(SavingsT.Text, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Savings2C.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Save"
                    ConnStr.Fields("Valu").Value = TextBox5.Text
                    ConnStr.Fields("TableN").Value = Savings2T.Text
                    If Savings2PC.Checked = True Then
                        ConnStr.Fields("Password").Value = Encrypting.EncryptData(Savings2P.Text.ToString)
                    End If
                    Savings2C.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Save"
                    ConnStr.Fields("Valu").Value = "False"
                    Savings2C.Checked = False
                End If
                ConnStr.Update()
                If QMSettings.ASSC.Checked Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "ASS"
                    ConnStr.Fields("Valu").Value = QMSettings.ASST.Text
                    ConnStr.Update()
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "ASS"
                    ConnStr.Fields("Valu").Value = "False"
                    ConnStr.Update()
                End If
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "NoBack"
                ConnStr.Fields("Valu").Value = QMSettings.Previous.Checked.ToString()
                ConnStr.Update()
                If QMSettings.NameC.Checked Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "NameMax"
                    ConnStr.Fields("Valu").Value = QMSettings.NameMax.Value
                    ConnStr.Update()
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "NameMin"
                    ConnStr.Fields("Valu").Value = QMSettings.NameMin.Value
                    ConnStr.Update()
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "NameMax"
                    ConnStr.Fields("Valu").Value = False
                    ConnStr.Update()
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "NameMin"
                    ConnStr.Fields("Valu").Value = False
                    ConnStr.Update()
                End If
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "FeedC"
                ConnStr.Fields("Valu").Value = QMSettings.Feed.SelectedIndex
                ConnStr.Update()
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "QuizD"
                ConnStr.Fields("Valu").Value = QMSettings.QuizD.SelectedIndex
                ConnStr.Update()
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Update"
                ConnStr.Fields("Valu").Value = QMSettings.Update.SelectedIndex
                ConnStr.Update()
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Password"
                ConnStr.Fields("Valu").Value = QMSettings.TextBox6.Text
                ConnStr.Update()
                If QMSettings.Timer.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Timer"
                    ConnStr.Fields("Valu").Value = QMSettings.Hou.Value & ":" & QMSettings.Min.Value & ":" & QMSettings.Sec.Value
                    QMSettings.Timer.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Timer"
                    ConnStr.Fields("Valu").Value = "False"
                    QMSettings.Timer.Checked = False
                End If
                ConnStr.Update()
                If SelectC.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Select"
                    ConnStr.Fields("Valu").Value = TextBox1.Text
                    ConnStr.Fields("TableN").Value = SelectT.Text
                    If SelectPC.Checked = True Then
                        ConnStr.Fields("Password").Value = Encrypting.EncryptData(SelectP.Text.ToString)
                    End If
                    SelectC.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Select"
                    ConnStr.Fields("Valu").Value = "False"
                    SelectC.Checked = False
                End If
                ConnStr.Update()
                If ArrangeC.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Arrange"
                    ConnStr.Fields("Valu").Value = Arrange.Text
                    ConnStr.Fields("TableN").Value = ArrangeT.Text
                    If ArrangePC.Checked = True Then
                        ConnStr.Fields("Password").Value = Encrypting.EncryptData(ArrangeP.Text.ToString)
                    End If
                    ArrangeC.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Arrange"
                    ConnStr.Fields("Valu").Value = "False"
                    ArrangeC.Checked = False
                End If
                ConnStr.Update()
                If CompleteC.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Complete"
                    ConnStr.Fields("Valu").Value = TextBox2.Text
                    ConnStr.Fields("TableN").Value = CompleteT.Text
                    If CompletePC.Checked = True Then
                        ConnStr.Fields("Password").Value = Encrypting.EncryptData(CompleteP.Text.ToString)
                    End If
                    CompleteC.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Complete"
                    ConnStr.Fields("Valu").Value = "False"
                    CompleteC.Checked = False
                End If
                ConnStr.Update()
                If JoinC.Checked = True Then
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Join"
                    ConnStr.Fields("Valu").Value = TextBox3.Text
                    ConnStr.Fields("TableN").Value = JoinT.Text
                    If JoinPC.Checked = True Then
                        ConnStr.Fields("Password").Value = Encrypting.EncryptData(JoinP.Text.ToString)
                    End If
                    JoinC.Checked = True
                Else
                    ConnStr.AddNew()
                    ConnStr.Fields("ID").Value = "Join"
                    ConnStr.Fields("Valu").Value = "False"
                    JoinC.Checked = False
                End If
                ConnStr.Update()
                ConnStr.UpdateBatch()
                ConnStr.Close()
                Conn.Close()
                TextBox4.Text = My.Application.Info.DirectoryPath & "\Savings.mdb"
                MsgBox("رجاء إعادة تشغيل البرنامج لإجراء التعديلات اللازمة وظهور البيانات الصحيحة", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.Information)
                Process.Start(Directory & "\Quiz Maker.exe")
                End
            End If
            If Conn.State = 0 Then
                If Not (b) Then
                    Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & TextBox4.Text & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked))
                    ConnStr.Open(TableN, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Else
                    Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Engine Type = 5" & SIF(";Jet OLEDB:Database Password = " & SavingsP.Text, SavingsPC.Checked))
                    ConnStr.Open(TableN, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                End If
                ConnStrI = 1
            End If
            ConnStr.MoveFirst()
            If sender.name = sender.name Then
                sender.Hide()
                If SS Then QMSettings.Hide()
                For counter = 1 To 30
                    Try
                        ConnStr.Delete()
                        ConnStr.Update()
                        ConnStr.MoveNext()
                    Catch ex As Runtime.InteropServices.COMException
                        If ex.Message <> "Either BOF or EOF is True, or the current record has been deleted. Requested operation requires a current record." Then
                            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
                        Else
                            Exit For
                        End If
                    End Try
                Next
            End If
            If Savings2C.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Save"
                ConnStr.Fields("Valu").Value = TextBox5.Text
                ConnStr.Fields("TableN").Value = Savings2T.Text
                If Savings2PC.Checked = True Then
                    ConnStr.Fields("Password").Value = Encrypting.EncryptData(Savings2P.Text.ToString)
                End If
                Savings2C.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Save"
                ConnStr.Fields("Valu").Value = "False"
                Savings2C.Checked = False
            End If
            ConnStr.Update()
            If QMSettings.ASSC.Checked Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "ASS"
                ConnStr.Fields("Valu").Value = QMSettings.ASST.Text
                ConnStr.Update()
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "ASS"
                ConnStr.Fields("Valu").Value = "False"
                ConnStr.Update()
            End If
            ConnStr.AddNew()
            ConnStr.Fields("ID").Value = "NoBack"
            ConnStr.Fields("Valu").Value = QMSettings.Previous.Checked.ToString()
            ConnStr.Update()
            If QMSettings.NameC.Checked Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "NameMax"
                ConnStr.Fields("Valu").Value = QMSettings.NameMax.Value
                ConnStr.Update()
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "NameMin"
                ConnStr.Fields("Valu").Value = QMSettings.NameMin.Value
                ConnStr.Update()
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "NameMax"
                ConnStr.Fields("Valu").Value = False
                ConnStr.Update()
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "NameMin"
                ConnStr.Fields("Valu").Value = False
                ConnStr.Update()
            End If
            ConnStr.AddNew()
            ConnStr.Fields("ID").Value = "FeedC"
            ConnStr.Fields("Valu").Value = QMSettings.Feed.SelectedIndex
            ConnStr.Update()
            ConnStr.AddNew()
            ConnStr.Fields("ID").Value = "QuizD"
            ConnStr.Fields("Valu").Value = QMSettings.QuizD.SelectedIndex
            ConnStr.Update()
            ConnStr.AddNew()
            ConnStr.Fields("ID").Value = "Update"
            ConnStr.Fields("Valu").Value = QMSettings.Update.SelectedIndex
            ConnStr.Update()
            ConnStr.AddNew()
            ConnStr.Fields("ID").Value = "Password"
            ConnStr.Fields("Valu").Value = QMSettings.TextBox6.Text
            ConnStr.Update()
            If QMSettings.Timer.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Timer"
                ConnStr.Fields("Valu").Value = QMSettings.Hou.Value & ":" & QMSettings.Min.Value & ":" & QMSettings.Sec.Value
                QMSettings.Timer.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Timer"
                ConnStr.Fields("Valu").Value = "False"
                QMSettings.Timer.Checked = False
            End If
            ConnStr.Update()
            If SelectC.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Select"
                ConnStr.Fields("Valu").Value = TextBox1.Text
                ConnStr.Fields("TableN").Value = SelectT.Text
                If SelectPC.Checked = True Then
                    ConnStr.Fields("Password").Value = Encrypting.EncryptData(SelectP.Text.ToString)
                End If
                SelectC.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Select"
                ConnStr.Fields("Valu").Value = "False"
                SelectC.Checked = False
            End If
            ConnStr.Update()
            If ArrangeC.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Arrange"
                ConnStr.Fields("Valu").Value = Arrange.Text
                ConnStr.Fields("TableN").Value = ArrangeT.Text
                If ArrangePC.Checked = True Then
                    ConnStr.Fields("Password").Value = Encrypting.EncryptData(ArrangeP.Text.ToString)
                End If
                ArrangeC.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Arrange"
                ConnStr.Fields("Valu").Value = "False"
                ArrangeC.Checked = False
            End If
            ConnStr.Update()
            If CompleteC.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Complete"
                ConnStr.Fields("Valu").Value = TextBox2.Text
                ConnStr.Fields("TableN").Value = CompleteT.Text
                If CompletePC.Checked = True Then
                    ConnStr.Fields("Password").Value = Encrypting.EncryptData(CompleteP.Text.ToString)
                End If
                CompleteC.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Complete"
                ConnStr.Fields("Valu").Value = "False"
                CompleteC.Checked = False
            End If
            ConnStr.Update()
            If JoinC.Checked = True Then
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Join"
                ConnStr.Fields("Valu").Value = TextBox3.Text
                ConnStr.Fields("TableN").Value = JoinT.Text
                If JoinPC.Checked = True Then
                    ConnStr.Fields("Password").Value = Encrypting.EncryptData(JoinP.Text.ToString)
                End If
                JoinC.Checked = True
            Else
                ConnStr.AddNew()
                ConnStr.Fields("ID").Value = "Join"
                ConnStr.Fields("Valu").Value = "False"
                JoinC.Checked = False
            End If
            ConnStr.Update()
            ConnStr.UpdateBatch()
            ConnStr.Close()
            Conn.Close()
        ElseIf CheckBox1.Checked AndAlso TextBox4.Text <> "" Then
            If Not (IO.File.Exists(TextBox4.Text)) Then
                MsgBox("الملف الذي تم كتابة مكانة غير موجود يرجى لتأجد من وجوده" & vbCrLf & "(Savings)", MsgBoxStyle.Exclamation OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
                sender.Hide()
                If SS Then QMSettings.Hide()
                If ConnStr.State = 1 Then
                    ConnStr.UpdateBatch()
                    ConnStr.Close()
                    Conn.Close()
                End If
                If ConnStr2.State = 1 Then
                    ConnStr2.UpdateBatch()
                    ConnStr2.Close()
                    Conn2.Close()
                End If
                Exit Sub
            Else
                System.IO.File.Copy(TextBox4.Text, Directory & "\Savings.mdb")
                IO.File.SetAttributes(Directory & "\Savings.mdb", IO.FileAttributes.Hidden)
                MsgBox("رجاء إعادة تشغيل البرنامج لإجراء التعديلات اللازمة وظهور البيانات الصحيحة", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.Information)
                End
            End If
        Else
            If sender.name = sender.name Then
                If MsgBox("من فضلك أملاء باقي البيانات", MsgBoxStyle.YesNo OrElse 0 OrElse 64 OrElse MsgBoxStyle.MsgBoxRight) = MsgBoxResult.No Then
                    sender.Hide()
                    If SS Then QMSettings.Hide()
                End If
            End If
        End If
        If ConnStr.State = 1 Then
            ConnStr.UpdateBatch()
            ConnStr.Close()
            Conn.Close()
        End If
        If ConnStr2.State = 1 Then
            Try
                ConnStr2.UpdateBatch()
            Finally
                ConnStr2.Close()
                Conn2.Close()
            End Try
        End If
    End Sub

    Public Sub Paths_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Instance = Me
        Splash.Version.Text = "الإصدار: " & My.Application.Info.Version.ToString
        Splash.Refresh()
        Splash.Copyright.Text = My.Application.Info.Copyright
        Splash.I.Show()
        Splash.Refresh()
        If Not String.IsNullOrEmpty(Command()) Then
            FileName = Command().Replace("""", "")
            GoTo ImportF
        ElseIf My.Application.CommandLineArgs.Count <> 0 Then
            FileName = My.Application.CommandLineArgs(0)
            GoTo ImportF
        Else
            If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments) Then
                If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData) Then
                    If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Count) Then
                        For i As Integer = 0 To AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Count - 1
                            FileName = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(i)
                        Next i
ImportF:                NewD.Import_Quiz(FileName)
                    End If
                End If
            End If
        End If
        Splash.Refresh()
        My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\QM").SetValue("Encryption", "", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\QM").SetValue("Status", "0", Microsoft.Win32.RegistryValueKind.DWord)
        Dim sql As New SqlClient.SqlConnection("Data Source=")
        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb") Then
            Try
                Splash.Label1.Text = "جار فك التشفير:"
                Splash.II.Show()
                If MPassword <> "" Then
                    MPassword = Encrypting.DecryptData(MPassword.ToString)
                    Try
                        Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings.mdb" & ";Jet OLEDB:Database Password = " & MPassword)
                        ConnStrI = 1
                    Catch ex As Exception
                        If ex.Message <> "Not a valid password." Then
                            Debug.WriteLine(ex.Message)
                        End If
                    End Try
                    TableN = Encrypting.DecryptData(TableN.ToString)
                    ConnStr.Open(TableN, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    SavingsPC.Checked = True
                Else
                    Conn.Open("Provider= Microsoft.Jet.OLEDB.4.0;Data Source =" & My.Application.Info.DirectoryPath & "\Savings.mdb")
                    TableN = Encrypting.DecryptData(TableN)
                    Try
                        ConnStr.Open(TableN, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        ConnStrI = 1
                    Catch ex As Exception
                        If ex.Message <> "Invalid SQL statement; expected 'DELETE', 'INSERT', 'PROCEDURE', 'SELECT', or 'UPDATE'." Then
                            Debug.WriteLine(ex.Message)
                        End If
                    End Try
                    SavingsPC.Checked = False
                End If
            Catch ex As Exception
                MsgBox("حدث خطأ أثناء محاولة تحميل البيانات من قاعدة البيانات." & vbCrLf & "قد يكون ذلك بسبب اسم جدول خاطئ أو كلمة سر خاطئة أو أو الجدول غير موجود" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
                Debug.WriteLine(ex.StackTrace)
                Splash.Close()
                Debug.WriteLine(Encrypting.EncryptData("Savings"))
                Exit Sub
            End Try
Aa:         My.Computer.Registry.CurrentUser.OpenSubKey("QM", True).DeleteValue("Encryption", False)
            My.Computer.Registry.CurrentUser.OpenSubKey("QM", True).DeleteValue("Status", False)
            Splash.Progress.Size = New Size(0, Splash.Progress.Size.Height)
            SavingsP.Text = MPassword
            SavingsT.Text = TableN
            Splash.Data.Text = "جار الحصول على البيانات والإعدادات ..."
            Splash.III.Show()
            Splash.Refresh()
            ConnStr.MoveFirst()
            For counter = 1 To 30
                Try
                    If ConnStr.Fields("ID").Value = "Select" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso SelectI = 0 Then
                        TextBox1.Text = ConnStr.Fields("Valu").Value.ToString
                        SelectT.Text = ConnStr.Fields("TableN").Value.ToString
                        If Not (ConnStr.Fields("Password").Value.ToString = "") Then
                            SelectP.Text = Encrypting.DecryptData(ConnStr.Fields("Password").Value.ToString)
                            SelectPC.Checked = True
                        End If
                        SelectC.Checked = True
                        SelectI = 1
                    ElseIf SelectI = 0 AndAlso ConnStr.Fields("ID").Value = "Select" Then
                        SelectC.Checked = False
                        SelectI = 1
                    ElseIf ConnStr.Fields("ID").Value = "Arrange" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso ArrangeI = 0 Then
                        Arrange.Text = ConnStr.Fields("Valu").Value.ToString
                        ArrangeT.Text = ConnStr.Fields("TableN").Value.ToString
                        If Not (ConnStr.Fields("Password").Value.ToString = "") Then
                            ArrangeP.Text = Encrypting.DecryptData(ConnStr.Fields("Password").Value.ToString)
                            ArrangePC.Checked = True
                        End If
                        ArrangeC.Checked = True
                        ArrangeI = 1
                    ElseIf ArrangeI = 0 AndAlso ConnStr.Fields("ID").Value = "Arrange" Then
                        ArrangeC.Checked = False
                        ArrangeI = 1
                    ElseIf ConnStr.Fields("ID").Value = "Complete" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso CompleteI = 0 Then
                        TextBox2.Text = ConnStr.Fields("Valu").Value.ToString
                        CompleteT.Text = ConnStr.Fields("TableN").Value.ToString
                        If Not (ConnStr.Fields("Password").Value.ToString = "") Then
                            CompleteP.Text = Encrypting.DecryptData(ConnStr.Fields("Password").Value.ToString)
                            CompletePC.Checked = True
                        End If
                        CompleteC.Checked = True
                        CompleteI = 1
                    ElseIf CompleteI = 0 AndAlso ConnStr.Fields("ID").Value = "Complete" Then
                        CompleteC.Checked = False
                        CompleteI = 1
                    ElseIf ConnStr.Fields("ID").Value = "Join" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso JoinI = 0 Then
                        TextBox3.Text = ConnStr.Fields("Valu").Value.ToString
                        JoinT.Text = ConnStr.Fields("TableN").Value.ToString
                        If Not (ConnStr.Fields("Password").Value.ToString = "") Then
                            JoinP.Text = Encrypting.DecryptData(ConnStr.Fields("Password").Value.ToString)
                            JoinPC.Checked = True
                        End If
                        JoinC.Checked = True
                        JoinI = 1
                    ElseIf JoinI = 0 AndAlso ConnStr.Fields("ID").Value = "Join" Then
                        JoinC.Checked = False
                        JoinI = 1
                    ElseIf ConnStr.Fields("ID").Value = "Save" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso SaveI = 0 Then
                        TextBox5.Text = ConnStr.Fields("Valu").Value.ToString
                        Savings2T.Text = ConnStr.Fields("TableN").Value.ToString
                        If Not (ConnStr.Fields("Password").Value.ToString = "") Then
                            Savings2P.Text = Encrypting.DecryptData(ConnStr.Fields("Password").Value.ToString)
                            Savings2PC.Checked = True
                        End If
                        Savings2C.Checked = True
                        SaveI = 1
                    ElseIf SaveI = 0 AndAlso ConnStr.Fields("ID").Value = "Save" Then
                        Savings2C.Checked = False
                        SaveI = 1
                    ElseIf ConnStr.Fields("ID").Value = "ASS" AndAlso ConnStr.Fields("Valu").Value.ToString <> "False" Then
                        ASSI = 1
                        QMSettings.ASST.Text = ConnStr.Fields("Valu").Value.ToString
                        QMSettings.ASSC.Checked = True
                    ElseIf ConnStr.Fields("ID").Value = "NoBack" Then
                        QMSettings.Previous.Checked = CBool(ConnStr.Fields("Valu").Value)
                    ElseIf ASSI <> 1 Then
                        QMSettings.ASSC.Checked = False
                    ElseIf ConnStr.Fields("ID").Value = "FeedC" Then
                        QMSettings.Feed.SelectedIndex = CInt(ConnStr.Fields("Valu").Value.ToString)
                    ElseIf ConnStr.Fields("ID").Value = "QuizD" Then
                        QMSettings.QuizD.SelectedIndex = CInt(ConnStr.Fields("Valu").Value.ToString)
                    ElseIf ConnStr.Fields("ID").Value = "Update" Then
                        QMSettings.Update.SelectedIndex = CInt(ConnStr.Fields("Valu").Value.ToString)
                    ElseIf ConnStr.Fields("ID").Value = "NameMax" AndAlso Not ((ConnStr.Fields("Valu").Value.ToString) = "False" OrElse ConnStr.Fields("Valu").Value.ToString = "0") Then
                        QMSettings.NameC.Checked = True
                        QMSettings.NameMax.Value = CDec(ConnStr.Fields("Valu").Value)
                    ElseIf ConnStr.Fields("ID").Value = "NameMax" AndAlso (ConnStr.Fields("Valu").Value.ToString = "False" OrElse ConnStr.Fields("Valu").Value.ToString = "0") Then
                        QMSettings.NameC.Checked = False
                    ElseIf ConnStr.Fields("ID").Value = "NameMin" AndAlso Not ((ConnStr.Fields("Valu").Value.ToString) = "False" OrElse ConnStr.Fields("Valu").Value.ToString = "0") Then
                        QMSettings.NameC.Checked = True
                        QMSettings.NameMin.Value = CDec(ConnStr.Fields("Valu").Value)
                    ElseIf ConnStr.Fields("ID").Value = "NameMin" AndAlso (ConnStr.Fields("Valu").Value.ToString = "False" OrElse ConnStr.Fields("Valu").Value.ToString = "0") Then
                        QMSettings.NameC.Checked = False
                    ElseIf ConnStr.Fields("ID").Value = "Password" Then
                        QMSettings.TextBox6.Text = ConnStr.Fields("Valu").Value.ToString
                    ElseIf ConnStr.Fields("ID").Value = "Timer" AndAlso Not (ConnStr.Fields("Valu").Value = "False") AndAlso TimerI = 0 Then
                        Dim S() As String = ConnStr.Fields("Valu").Value.ToString.Split(":")
                        QMSettings.Hou.Value = CDec(S(0))
                        QMSettings.Min.Value = CDec(S(1))
                        QMSettings.Sec.Value = CDec(S(2))
                        QMSettings.Timer.Checked = True
                        QMSettings.Hou.Enabled = True
                        QMSettings.Min.Enabled = True
                        QMSettings.Sec.Enabled = True
                        TimerI = 1
                    ElseIf TimerI = 0 AndAlso ConnStr.Fields("ID").Value = "Timer" Then
                        QMSettings.Timer.Checked = False
                        TimerI = 1
                    End If
                    ConnStr.MoveNext()
                Catch ex As Exception
                    If Not (ex.Message.Contains("Either BOF or EOF is True, or the current record has been deleted. Requested operation requires a current record.") OrElse ex.Message = "Either BOF or EOF is True, or the current record has been deleted. Requested operation requires a current record.") Then
                        MsgBox(ex.Message & vbCrLf & ex.StackTrace)
                    Else
                        Exit For
                    End If
                End Try
            Next
            TextBox4.Text = My.Application.Info.DirectoryPath & "\Savings.mdb"
            Splash.Setts.Text = "جار ملء البيانات ..."
            Splash.IIII.Show()
            If Not (SelectC.Checked OrElse CompleteC.Checked OrElse JoinC.Checked) Then
                MsgBox("لا يوجد اختبار لتحميله!", MsgBoxStyle.Exclamation OrElse MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.MsgBoxRtlReading)
            End If
            If SelectC.Checked Then
                If ConnStr.State = 1 Then
                    ConnStr.UpdateBatch()
                    ConnStr.Close()
                    Conn.Close()
                End If
                If ConnStr2.State = 1 Then
                    ConnStr2.UpdateBatch()
                    ConnStr2.Close()
                    Conn2.Close()
                End If
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & TextBox1.Text & SIF(";Jet OLEDB:Database Password = " & SelectP.Text, SelectPC.Checked))
                ConnStr.Open(SelectT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                ConnStr.MoveFirst()
                While Not (ConnStr.EOF)
                    EDesgin.SelectG.Rows.Add(ConnStr.Fields("Question").Value.ToString.Split(",")(0), ConnStr.Fields("Answer 1").Value, ConnStr.Fields("Answer 2").Value, ConnStr.Fields("Answer 3").Value, ConnStr.Fields("Answer 4").Value, ConnStr.Fields("RAnswer").Value, ConnStr.Fields("Degree").Value)
                    EDesgin.SelectA.Add(New List(Of String))
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Question").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Answer 1").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Answer 2").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Answer 3").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Answer 4").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("RAnswer").Value.ToString)
                    EDesgin.SelectA(EDesgin.SelectA.Count - 1).Add(ConnStr.Fields("Degree").Value.ToString)
                    ConnStr.MoveNext()
                End While
                'Debug.WriteLine(EDesgin.SelectG(0, EDesgin.SelectG.Rows.Count - 2).Tag.ToString)
            End If
            If CompleteC.Checked Then
                If ConnStr.State = 1 Then
                    ConnStr.UpdateBatch()
                    ConnStr.Close()
                    Conn.Close()
                End If
                If ConnStr2.State = 1 Then
                    ConnStr2.UpdateBatch()
                    ConnStr2.Close()
                    Conn2.Close()
                End If
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & TextBox2.Text & SIF(";Jet OLEDB:Database Password = " & CompleteP.Text, CompletePC.Checked))
                ConnStr.Open(CompleteT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                ConnStr.MoveFirst()
                While Not (ConnStr.EOF)
                    EDesgin.CompleteG.Rows.Add(ConnStr.Fields("Question").Value, ConnStr.Fields("RA1").Value, ConnStr.Fields("RA2").Value, ConnStr.Fields("RA3").Value, ConnStr.Fields("Degree").Value)
                    ConnStr.MoveNext()
                End While
            End If
            If JoinC.Checked Then
                If ConnStr.State = 1 Then
                    ConnStr.UpdateBatch()
                    ConnStr.Close()
                    Conn.Close()
                End If
                If ConnStr2.State = 1 Then
                    ConnStr2.UpdateBatch()
                    ConnStr2.Close()
                    Conn2.Close()
                End If
                Conn.Open("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" & TextBox3.Text & SIF(";Jet OLEDB:Database Password = " & JoinP.Text, JoinPC.Checked))
                ConnStr.Open(JoinT.Text, Conn, ADODB.CursorTypeEnum.adOpenUnspecified, ADODB.LockTypeEnum.adLockPessimistic)
                ConnStr.MoveFirst()
                While Not (ConnStr.EOF)
                    EDesgin.JoinG.Rows.Add(ConnStr.Fields("A").Value, ConnStr.Fields("TAI").Value, ConnStr.Fields("Q").Value, ConnStr.Fields("TQI").Value, ConnStr.Fields("Degree").Value)
                    ConnStr.MoveNext()
                End While
            End If
        End If
        EDesgin.SelectC.Checked = SelectC.Checked
        EDesgin.SelectG.Enabled = SelectC.Checked
        EDesgin.CompleteC.Checked = CompleteC.Checked
        EDesgin.CompleteG.Enabled = CompleteC.Checked
        EDesgin.JoinC.Checked = JoinC.Checked
        EDesgin.JoinG.Enabled = JoinC.Checked
        QMSettings.Hide()
        If ConnStr.State = 1 Then
            ConnStr.UpdateBatch()
            ConnStr.Close()
            Conn.Close()
        End If
        If ConnStr2.State = 1 Then
            ConnStr2.UpdateBatch()
            ConnStr2.Close()
            Conn2.Close()
        End If
        Splash.Start.Text = "جار البدء ..."
        Splash.V.Show()
        Splash.Refresh()
        Splash.Close()
        P = 0
    End Sub
#End Region
#Region "Checks Changed"
    Private Sub SelectC_CheckedChanged(sender As Object, e As EventArgs) Handles SelectC.CheckedChanged
        If sender.checked Then
            TextBox1.Enabled = True
            SelectT.Enabled = True
            Button5.Enabled = True
            SelectPC.Enabled = True
            EDesgin.SelectC.Checked = True
        Else
            TextBox1.Enabled = False
            SelectT.Enabled = False
            Button5.Enabled = False
            Button5.BackgroundImage = Nothing
            SelectPC.Enabled = False
            SelectP.Enabled = False
            EDesgin.SelectC.Checked = False
        End If
    End Sub

    Private Sub CompleteC_CheckedChanged(sender As Object, e As EventArgs) Handles CompleteC.CheckedChanged
        If sender.checked Then
            TextBox2.Enabled = True
            CompleteT.Enabled = True
            Button6.Enabled = True
            CompletePC.Enabled = True
        Else
            TextBox2.Enabled = False
            CompleteT.Enabled = False
            Button6.Enabled = False
            Button6.BackgroundImage = Nothing
            CompletePC.Enabled = False
            CompleteP.Enabled = False
        End If
    End Sub

    Private Sub Joinc_CheckedChanged(sender As Object, e As EventArgs) Handles JoinC.CheckedChanged
        If sender.checked Then
            TextBox3.Enabled = True
            JoinT.Enabled = True
            Button7.Enabled = True
            JoinPC.Enabled = True
        Else
            TextBox3.Enabled = False
            JoinT.Enabled = False
            Button7.Enabled = False
            Button7.BackgroundImage = Nothing
            JoinPC.Enabled = False
            JoinP.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SelectPC.EnabledChanged, SelectPC.CheckedChanged
        If sender.checked Then
            SelectP.Enabled = True
        Else
            SelectP.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CompletePC.EnabledChanged, CompletePC.CheckedChanged
        If sender.checked Then
            CompleteP.Enabled = True
        Else
            CompleteP.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles JoinPC.EnabledChanged, JoinPC.CheckedChanged
        If sender.checked Then
            JoinP.Enabled = True
        Else
            JoinP.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles Savings2PC.CheckedChanged
        If sender.checked Then
            Savings2P.Enabled = True
        Else
            Savings2P.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = False Then
            b = False
            Panel1.Enabled = True
            TextBox4.Enabled = False
            Button8.Enabled = False
            QMSettings.Enabled = True
        Else
            b = True
            Panel1.Enabled = False
            TextBox4.Enabled = True
            Button8.Enabled = True
            Button8.BackgroundImage = Nothing
            QMSettings.Enabled = False
        End If
    End Sub

    Private Sub Savings2C_CheckedChanged(sender As Object, e As EventArgs) Handles Savings2C.CheckedChanged
        If sender.checked Then
            TextBox5.Enabled = True
            Savings2T.Enabled = True
            Button11.Enabled = True
            Savings2PC.Enabled = True
        Else
            TextBox5.Enabled = False
            Savings2T.Enabled = False
            Button11.Enabled = False
            Button11.BackgroundImage = Nothing
            Savings2PC.Enabled = False
            Savings2P.Enabled = False
        End If
    End Sub
#End Region
#Region "Texts Changed"
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IO.File.Exists(sender.text) Then
            Button5.BackgroundImage = My.Resources.Tick
        Else
            Button5.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IO.File.Exists(sender.text) Then
            Button6.BackgroundImage = My.Resources.Tick
        Else
            Button6.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IO.File.Exists(sender.text) Then
            Button7.BackgroundImage = My.Resources.Tick
        Else
            Button7.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If IO.File.Exists(sender.text) Then
            Button11.BackgroundImage = My.Resources.Tick
        Else
            Button11.BackgroundImage = My.Resources.eror2
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If IO.File.Exists(sender.text) Then
            Button8.BackgroundImage = My.Resources.Tick
        Else
            Button8.BackgroundImage = My.Resources.eror2
        End If
    End Sub
    Private Sub SavingsPC_CheckedChanged(sender As Object, e As EventArgs) Handles SavingsPC.CheckedChanged
        If sender.checked Then
            SavingsP.Enabled = True
        Else
            SavingsP.Enabled = False
        End If
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (SS) OrElse QMSettings.Visible = False OrElse sender.text = "إظهار الإعدادات V" Then
            QMSettings.Show()
            QMSettings.Location = New Point(Me.Location.X + 3, (Me.Location.Y + 249))
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + QMSettings.Size.Height)
            QMSettings.FormBorderStyle = FormBorderStyle.None
            sender.text = "إخفاء الإعدادات ^"
            Panel2.Size = QMSettings.Size
        Else
            QMSettings.Hide()
            sender.text = "إظهار الإعدادات V"
            QMSettings.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.Size = New Size(926, 253)
            aot = False
        End If
        SS = Not (SS)
    End Sub
    Private Sub Paths_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If QMSettings.Visible Then QMSettings.Location = New Point(Me.Location.X + 3, (Me.Location.Y + 249))
    End Sub

    Private Sub Paths_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible AndAlso Not (System.IO.File.Exists("C:\Windows\Temp\Savings.mdb") OrElse IO.File.Exists(My.Application.Info.DirectoryPath & "\Savings.mdb")) Then
            QMSettings.Show()
            QMSettings.Activate()
            Activate()
            QMSettings.Location = New Point(Me.Location.X + 3, (Me.Location.Y + 249))
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + QMSettings.Size.Height)
            QMSettings.FormBorderStyle = FormBorderStyle.None
            Button1.Text = "إخفاء الإعدادات ^"
            Panel2.Size = QMSettings.Size
        Else
            QMSettings.Hide()
            Button1.Text = "إظهار الإعدادات V"
            QMSettings.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.Size = New Size(926, 253)
        End If
    End Sub

    Private Sub Panel2_Enter(sender As Object, e As EventArgs) Handles Panel2.Enter
        QMSettings.Activate()
    End Sub

    Private Sub Paths_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MPassword = Nothing
        TableN = Nothing
        ConnStr = Nothing
        Conn = Nothing
        ConnStr2 = Nothing
        Conn2 = Nothing
        dev = Nothing
        c = Nothing
        ConnStrI = Nothing
        SS = Nothing
        SelectI = Nothing
        CompleteI = Nothing
        JoinI = Nothing
        SaveI = Nothing
        TimerI = Nothing
        ASSI = Nothing
        counter = Nothing
        b = Nothing
        PENC = Nothing
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        QMSettings.Activate()
    End Sub

    Private Sub Paths_Activated(sender As Object, e As EventArgs)
        If Not (aot) AndAlso QMSettings.Visible Then
            QMSettings.Activate()
            Me.Activate()
            aot = Not (aot)
        End If
    End Sub

    Private Sub Paths_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Activate()
    End Sub
End Class