Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=MSI;Database=Birger Bolcher;User=sa;Pwd=12345678;"}
    Public SQLCmd As SqlCommand

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class