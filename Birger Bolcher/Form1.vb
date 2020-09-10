Imports System.Data.SqlClient

Public Class Form1

    Dim SQL As New SQLControl
    Dim connection As New SqlConnection("Server=MSI;Database=Birger Bolcher;User=sa;Pwd=12345678")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData("")

        If SQL.HasConnection = True Then
            MsgBox("Successfully connected")
        End If
    End Sub

    Public Sub FilterData(valueToSearch As String)

        Dim searhQuery As String = "SELECT dbo.Bolcher.Navn, dbo.Farver.Navn, dbo.Smagstyper.Navn FROM [dbo].[Bolcher]
LEFT JOIN dbo.Farver
ON Bolcher.Farver_FarverID = Farver.idFarver
LEFT JOIN dbo.Smagstyper
ON Bolcher.Smagstyper_SmagstyperID = Smagstyper.idSmagstyper
WHERE Farver.Navn = '%" & TextBox1.Text & "%'"

        Dim Command As New SqlCommand(searhQuery, connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FilterData(TextBox1.Text)

    End Sub
End Class
