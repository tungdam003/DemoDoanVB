Imports System.Data.SqlClient

Module DatabaseModule
    Public Function GetConnection() As SqlConnection
        Dim connStr As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"
        Return New SqlConnection(connStr)
    End Function
End Module

