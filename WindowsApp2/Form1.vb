Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\Win10\WindowsApp2\WindowsApp2\Database1.mdf;Integrated Security=True"
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from teilnehmer"
        cmd.Connection = conn
        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Dim liste As New List(Of Teilnehmer)
            Using reader
                While reader.Read

                    liste.Add(New Teilnehmer With {.Id = reader("id"), .FamName = reader("FamName")})

                End While
            End Using
            DataGridView1.DataSource = liste
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

    End Sub
End Class
