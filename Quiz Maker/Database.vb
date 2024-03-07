Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Microsoft.VisualBasic.Logging

Public Class Database
    Public sql_cmd As New System.Data.SqlClient.SqlCommand
    Public sql_con As New System.Data.SqlClient.SqlConnection
    Public sql_adptr As New System.Data.SqlClient.SqlDataAdapter
    Public sql_rdr As System.Data.SqlClient.SqlDataReader
    Public Function CreateDB(DBName As String, Optional Location As String = "") As String
        sql_con.ConnectionString = "Data Source = " & If(Location(Location.Length - 1) = "\", Location, Location + "\") + DBName
        Debug.WriteLine(sql_con.Database)
        sql_con.Open()
    End Function
End Class