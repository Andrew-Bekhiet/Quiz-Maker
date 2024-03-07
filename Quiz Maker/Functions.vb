Imports System.Data.SqlClient
Imports Quiz_Maker

Module Subs
    Public ActiveF As New System.Windows.Forms.Form
    Public Directory As String = My.Application.Info.DirectoryPath
    Public ontime As Boolean = False
    Public Hou, Min, Sec As Integer
    Public Timer As Boolean = False
    Public MainASSDB As New ADODB.Recordset()
    Public DB As New ADODB.Connection()
    Public C As Boolean = False
    Public NP As Integer
    Public P As Byte = 100
    Private _questions As New List(Of Form)

    Public SelectQ As New List(Of String)
    Public SelectA As New List(Of String)
    Public SelectAs As New List(Of String())
    Public SelectRA As New List(Of String)
    Public SelectD As New List(Of Double)
    Public SelectTF As New List(Of Boolean)

    Public CompleteQ As New List(Of String)
    Public CompleteA As New List(Of String)
    Public CompleteRAs As New List(Of String())
    Public CompleteD As New List(Of Double)
    Public CompleteTF As New List(Of Boolean)
    Public CompleteRgx As New List(Of Boolean)

    Public JoinC1 As New List(Of String)
    Public JoinC2 As New List(Of String)
    Public JoinAC1 As New List(Of String)
    Public JoinAC2 As New List(Of String)
    Public JoinTQI As New List(Of String)
    Public JoinTAI As New List(Of String)
    Public JoinD As New List(Of Double)
    Public JoinD2 As New List(Of Double)
    Public JoinTF As New List(Of Boolean)

    Public ArrangeQ As New List(Of String)
    Public ArrangeA As New List(Of String)
    Public ArrangeRA As New List(Of String)
    Public ArrangeD As New List(Of Double)
    Public ArrangeTF As New List(Of Boolean)

    Public TimerControls As New List(Of Timers)
    Public WithEvents Ticker As New Timer() With {.Interval = 1000}
    Public ProgBar As Integer

#Region "Timer"
    Public Sub Start_Timer()
        Ticker.Start()
    End Sub
    Public Sub Stop_Timer()
        Ticker.Stop()
        TimerControls = New List(Of Timers)
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Ticker.Tick
        If QMSettings.Timer.Checked Then
            If Sec = 0 Then
                Sec = 60
                TimerControls.ForEach(New Action(Of Timers)(AddressOf Seconds))
                If Min = 0 Then
                    Min = 59
                    TimerControls.ForEach(New Action(Of Timers)(AddressOf Minutes))
                    If Not (Hou = 0) Then
                        Hou -= 1
                        TimerControls.ForEach(New Action(Of Timers)(AddressOf Hours))
                    Else
timeend:                Hou = 0
                        Min = 0
                        Sec = 0
                        TimerControls.ForEach(New Action(Of Timers)(AddressOf Seconds))
                        TimerControls.ForEach(New Action(Of Timers)(AddressOf Minutes))
                        TimerControls.ForEach(New Action(Of Timers)(AddressOf Hours))
                        ProgBar = 0
                        TimerControls.ForEach(New Action(Of Timers)(AddressOf Progress))
                        Ticker.Stop()
                        Result.TimerL.Text = Hou & ":" & Min & ":" & Sec
                        MsgBox("إنتهي الوقت!", MsgBoxStyle.MsgBoxRight OrElse MsgBoxStyle.Exclamation)
                        Result.Show()
                        Exit Sub
                    End If
                Else
                    Min -= 1
                    TimerControls.ForEach(New Action(Of Timers)(AddressOf Minutes))
                End If
            End If
            Sec -= 1
            TimerControls.ForEach(New Action(Of Timers)(AddressOf Seconds))
            Try
                ProgBar = ((((Hou * 60) * 60) + (Min * 60) + Sec))
                TimerControls.ForEach(New Action(Of Timers)(AddressOf Progress))
                Result.TimerL.Text = Hou & ":" & Min & ":" & Sec
            Catch ex As System.ArgumentOutOfRangeException
            End Try
        End If
        If Hou = 0 AndAlso Min = 0 AndAlso Sec = 0 Then GoTo timeend
    End Sub
    Private Sub Seconds(Timer As Timers)
        Timer.sec2.Text = Sec
    End Sub
    Private Sub Minutes(Timer As Timers)
        Timer.min2.Text = Min
    End Sub
    Private Sub Hours(Timer As Timers)
        Timer.hou2.Text = Hou
    End Sub
    Private Sub Progress(Timer As Timers)
        Timer.ProgressBar.Value = ProgBar
    End Sub
#End Region

    Public Property Questions As List(Of Form)
        Get
            Return _questions
        End Get
        Set(value As List(Of Form))
            _questions = value
        End Set
    End Property

    Public Sub Redraw(ByRef sender As Object)
        sender.close()
        sender.show()
    End Sub
    Public Function CountoO(BString As String, SString As String) As Integer
        Dim NoO As Integer = 0
        Dim Co As Integer
        For Co = 0 To BString.Length - 1
            If BString.ElementAt(Co) = SString Then NoO += 1
        Next
        Return NoO
    End Function
    Public Function SIF(S As String, B As Boolean) As String
        If CBool(B) Then
            Return S
        Else
            Return ""
        End If
    End Function
    Public Sub CloseC()
        Try
            If Paths.Instance.ConnStr.State = 1 Then
                Paths.Instance.ConnStr.UpdateBatch()
                Paths.Instance.ConnStr.Close()
                Paths.Instance.Conn.Close()
            End If
            If Paths.Instance.ConnStr2.State = 1 Then
                Paths.Instance.ConnStr2.UpdateBatch()
                Paths.Instance.ConnStr2.Close()
                Paths.Instance.Conn2.Close()
            End If
        Catch
        End Try
    End Sub
    Public Class DataAccess
        ''' <summary>
        ''' Function to retrieve the connection from the app.config
        ''' </summary>
        ''' <param name="conName">Name of the connectionString to retrieve</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetConnectionString(ByVal conName As String) As String
            Return ""
        End Function

        ''' <summary>
        ''' Returns a BindingSource, which is used with, for example, a DataGridView control
        ''' </summary>
        ''' <param name="cmd">"pre-Loaded" command, ready to be executed</param>
        ''' <returns>BindingSource</returns>
        ''' <remarks>Use this function to ease populating controls that use a BindingSource</remarks>
        Public Shared Function GetBindingSource(ByVal cmd As SqlCommand) As BindingSource
            'declare our binding source
            Dim oBindingSource As New BindingSource()
            ' Create a new data adapter based on the specified query.
            Dim daGet As New SqlDataAdapter(cmd)
            ' Populate a new data table and bind it to the BindingSource.
            Dim dtGet As New DataTable()
            'set the timeout of the SqlCommandObject
            cmd.CommandTimeout = 240
            dtGet.Locale = System.Globalization.CultureInfo.InvariantCulture
            Try
                'fill the DataTable with the SqlDataAdapter
                daGet.Fill(dtGet)
            Catch ex As Exception
                'check for errors
                MsgBox(ex.Message, "Error in GetBindingSource")
                Return Nothing
            End Try
            'set the DataSource for the BindingSource to the DataTable
            oBindingSource.DataSource = dtGet
            'return the BindingSource to the calling method or control
            Return oBindingSource
        End Function

        ''' <summary>
        ''' Method for handling the ConnectionState of 
        ''' the connection object passed to it
        ''' </summary>
        ''' <param name="conn">The SqlConnection Object</param>
        ''' <remarks></remarks>
        Public Shared Sub HandleConnection(ByVal conn As SqlConnection)
            With conn
                'do a switch on the state of the connection
                Select Case .State
                    Case ConnectionState.Open
                        'the connection is open
                        'close then re-open
                        .Close()
                        .Open()
                        Exit Select
                    Case ConnectionState.Closed
                        'connection is open
                        'open the connection
                        .Open()
                        Exit Select
                    Case Else
                        .Close()
                        .Open()
                        Exit Select
                End Select
            End With
        End Sub

        Public Shared Function InsertNewRecord(ByVal item1 As String, ByVal item2 As String, ByVal item3 As String) As Boolean
            'Create the objects we need to insert a new record
            Dim cnInsert As New SqlConnection(GetConnectionString("YourConnName"))
            Dim cmdInsert As New SqlCommand
            Dim sSQL As New String("")
            Dim iSqlStatus As Integer

            'Set the stored procedure we're going to execute
            sSQL = "YourProcName"

            'Inline sql needs to be structured like so
            'sSQL = "INSERT INTO YourTable(column1,column2,column3) VALUES('" & item1 & "','" & item2 & "','" & item3 & "')"

            'Clear any parameters
            cmdInsert.Parameters.Clear()
            Try
                'Set the SqlCommand Object Properties
                With cmdInsert
                    'Tell it what to execute
                    .CommandText = sSQL 'Your sql statement if using inline sql
                    'Tell it its a stored procedure
                    .CommandType = CommandType.StoredProcedure 'CommandType.Text for inline sql
                    'If you are indeed using a stored procedure
                    'the next 3 lines pertain to you
                    'Now add the parameters to our procedure
                    'NOTE: Replace @value1.... with your parameter names in your stored procedure
                    'and add all your parameters in this fashion
                    .Parameters.AddWithValue("@value1", item1)
                    .Parameters.AddWithValue("@value2", item2)
                    .Parameters.AddWithValue("@value3", item3)
                    'Set the connection of the object
                    .Connection = cnInsert
                End With

                'Now take care of the connection
                HandleConnection(cnInsert)

                'Set the iSqlStatus to the ExecuteNonQuery status of the insert (0 = success, 1 = failed)
                iSqlStatus = cmdInsert.ExecuteNonQuery

                'Now check the status
                If Not iSqlStatus = 0 Then
                    'DO your failed messaging here
                    Return False
                Else
                    'Do your success work here
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Error")
                HandleConnection(cnInsert)
                Return False
            Finally
                'Now close the connection
                HandleConnection(cnInsert)
            End Try
            Return True
        End Function

        Public Shared Function DeleteRecord(ByVal id As Integer) As Boolean
            'Create the objects we need to insert a new record
            Dim cnDelete As New SqlConnection(GetConnectionString("YourConnName"))
            Dim cmdDelete As New SqlCommand
            Dim sSQL As New String("")
            Dim iSqlStatus As Integer

            'Set the stored procedure we're going to execute
            sSQL = "YourProcName"

            'Inline sql needs to be structured like so
            'sSQL = "DELETE FROM YourTable WHERE YourID = " & id

            'Clear any parameters
            cmdDelete.Parameters.Clear()
            Try
                'Set the SqlCommand Object Properties
                With cmdDelete
                    'Tell it what to execute
                    .CommandText = sSQL 'Your sql statement if using inline sql
                    'Tell it its a stored procedure
                    .CommandType = CommandType.StoredProcedure 'CommandType.Text for inline sql
                    'If you are indeed using a stored procedure
                    'the next 3 lines pertain to you
                    'Now add the parameters to our procedure
                    'NOTE: Replace @value1.... with your parameter names in your stored procedure
                    'and add all your parameters in this fashion
                    .Parameters.AddWithValue("@YourID", id)
                    'Set the connection of the object
                    .Connection = cnDelete
                End With

                'Now take care of the connection
                HandleConnection(cnDelete)

                'Set the iSqlStatus to the ExecuteNonQuery 
                'status of the insert (0 = success, 1 = failed)
                iSqlStatus = cmdDelete.ExecuteNonQuery

                'Now check the status
                If Not iSqlStatus = 0 Then
                    'DO your failed messaging here
                    Return False
                Else
                    'Do your success work here
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Error")
                Return False
            Finally
                'Now close the connection
                HandleConnection(cnDelete)
            End Try
            Return True
        End Function

        Public Shared Function UpdateRecord(ByVal item1 As String, ByVal item2 As String, ByVal id As Integer) As Boolean
            'Create the objects we need to insert a new record
            Dim cnUpdate As New SqlConnection(GetConnectionString("YourConnName"))
            Dim cmdUpdate As New SqlCommand
            Dim sSQL As New String("")
            Dim iSqlStatus As Integer

            'Set the stored procedure we're going to execute
            sSQL = "YourProcName"

            'Inline sql needs to be structured like so
            'sSQL = "UPDATE YourTable SET column1 = '" & item1 & "',column2 = '" & item2 & "' WHERE YourId = " & id

            'Clear any parameters
            cmdUpdate.Parameters.Clear()
            Try
                'Set the SqlCommand Object Properties
                With cmdUpdate
                    'Tell it what to execute
                    .CommandText = sSQL 'Your sql statement if using inline sql
                    'Tell it its a stored procedure
                    .CommandType = CommandType.StoredProcedure 'CommandType.Text for inline sql
                    'If you are indeed using a stored procedure
                    'the next 3 lines pertain to you
                    'Now add the parameters to our procedure
                    'NOTE: Replace @value1.... with your parameter names in your stored procedure
                    'and add all your parameters in this fashion
                    .Parameters.AddWithValue("@value1", item1)
                    .Parameters.AddWithValue("@value2", item2)
                    .Parameters.AddWithValue("@YourID", id)
                    'Set the connection of the object
                    .Connection = cnUpdate
                End With

                'Now take care of the connection
                HandleConnection(cnUpdate)

                'Set the iSqlStatus to the ExecuteNonQuery 
                'status of the insert (0 = success, 1 = failed)
                iSqlStatus = cmdUpdate.ExecuteNonQuery

                'Now check the status
                If Not iSqlStatus = 0 Then
                    'DO your failed messaging here
                    Return False
                Else
                    'Do your success work here
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Error")
            Finally
                'Now close the connection
                HandleConnection(cnUpdate)
            End Try
        End Function


        Public Shared Function GetRecords() As BindingSource
            'The value that will be passed to the Command Object (this is a stored procedure)
            Dim sSQL As String = "YourProcName"
            'If using inline sql format is as such
            'sSQL = "SELECT * FROM YourTable
            'Stored procedure to execute
            Dim cnGetRecords As New SqlConnection(GetConnectionString("YourConnectionName"))
            'SqlConnection Object to use
            Dim cmdGetRecords As New SqlCommand()
            'SqlCommand Object to use
            Dim daGetRecords As New SqlDataAdapter()
            Dim dsGetRecords As New DataSet()
            'Clear any parameters
            cmdGetRecords.Parameters.Clear()
            Try
                With cmdGetRecords
                    'set the SqlCommand Object Parameters
                    .CommandText = sSQL
                    'tell it what to execute
                    .CommandType = CommandType.StoredProcedure
                    'Set the Connection for the Command Object
                    .Connection = cnGetRecords
                End With
                'set the state of the SqlConnection Object
                HandleConnection(cnGetRecords)
                'create BindingSource to return for our DataGrid Control
                Dim oBindingSource As BindingSource = GetBindingSource(cmdGetRecords)
                'now check to make sure a BindingSource was returned
                If Not oBindingSource Is Nothing Then
                    'return the binding source to the calling method
                    Return oBindingSource
                Else
                    'no binding source was returned
                    'let the user know the error
                    Throw New Exception("There was no BindingSource returned")
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Error Retrieving Data")
                Return Nothing
            Finally
                HandleConnection(cnGetRecords)
            End Try
        End Function
    End Class
End Module