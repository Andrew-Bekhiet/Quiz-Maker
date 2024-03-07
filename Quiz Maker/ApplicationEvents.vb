Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim s As Boolean = Encrypting.Extract_DLLs()
            Splash.Show()
            If Not (IO.File.Exists(Directory & "\UnRAR.exe")) Then
                My.Computer.FileSystem.WriteAllBytes(Directory & "\UnRAR.exe", My.Resources.UnRAR, False)
            End If
            If Not (IO.File.Exists(Directory & "\Rar.exe")) Then
                My.Computer.FileSystem.WriteAllBytes(Directory & "\Rar.exe", My.Resources.Rar, False)
            End If
            If Not (IO.File.Exists(Directory & "\RenameDB.exe")) Then
                My.Computer.FileSystem.WriteAllBytes(Directory & "\RenameDB.exe", My.Resources.RenameDB, False)
            End If
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QM", "TableN", Nothing) Is Nothing Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "TableN", "")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QM", "Password", "")
            Else
                Paths.MPassword = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QM", "Password", Nothing).ToString
                Paths.TableN = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QM", "TableN", Nothing).ToString
            End If
            My.Computer.Registry.CurrentUser.OpenSubKey("QM", True).DeleteValue("Encryption", False)
            My.Computer.Registry.CurrentUser.OpenSubKey("QM", True).DeleteValue("Status", False)
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\QM").SetValue("Encryption", "", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\QM").SetValue("Status", "0", Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\QM").SetValue("AppPath", My.Application.Info.DirectoryPath, Microsoft.Win32.RegistryValueKind.String)
            ''EDesgin.Show()()
            'EDesgin.Hide()
            Paths.Paths_Load(Nothing, Nothing)
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            'e.ExitApplication = False
            MsgBox(e.Exception.Message + vbCrLf + e.Exception.StackTrace)
        End Sub
    End Class
End Namespace
