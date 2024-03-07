Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim FileName As String
        FileName = ""
        If Not String.IsNullOrEmpty(Command()) Then
            FileName = Command()
        Else
            If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments) Then
                If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData) Then
                    If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Count) Then
                        For i As Integer = 0 To AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Count - 1
                            FileName = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(i)
                        Next i
                    End If
                End If
            End If
        End If
        Label1.Text = My.Application.Info.AssemblyName
        Label4.Text = My.Application.Info.CompanyName
        Label3.Text = My.Application.Info.Copyright
        Label2.Text = My.Application.Info.Version.ToString
    End Sub
End Class